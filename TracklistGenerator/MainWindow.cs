using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracklistGenerator.Dialogs;
using TracklistGenerator.Model;
using DoxCom.Database;

namespace TracklistGenerator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All Files|*.*|Ableton Project|*.als|XML File|*.xml|JSON|*.json";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileTextBox.Text = ofd.FileName;
                    List<Track> tracklist = new List<Track>();

                    Task.Factory.StartNew(async () =>
                    {
                        switch (ofd.FileName.Substring(ofd.FileName.LastIndexOf('.')))
                        {
                            case ".als":
                                tracklist = await FileParser.GetTracklistFromProject(ofd.FileName);
                                break;
                            case ".json":
                                tracklist = await FileParser.GetTracklistFromJson(ofd.FileName);
                                break;
                            case ".xml":
                                MessageBox.Show("XML files aren't supported yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                MessageBox.Show("Unsupported file type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }

                        Invoke(new MethodInvoker(delegate
                        {
                            tracklistDataGrid.DataSource = tracklist;
                        }));
                    });
                }
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<Track> tracklist = tracklistDataGrid.DataSource as List<Track>;
            if (tracklist == null)
            {
                MessageBox.Show("Traklist is unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tracklist.SortTracklist();
            tracklistDataGrid.DataSource = tracklist;
            tracklistDataGrid.Refresh();
        }

        private void rectifyButton_Click(object sender, EventArgs e)
        {
            List<Track> tracklist = tracklistDataGrid.DataSource as List<Track>;
            if (tracklist == null)
            {
                MessageBox.Show("Traklist is unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tracklistDataGrid.DataSource = tracklist.CombineAllDuplicates();
            tracklistDataGrid.Refresh();
        }

        private void zeroTracklistButton_Click(object sender, EventArgs e)
        {
            List<Track> tracklist = tracklistDataGrid.DataSource as List<Track>;
            if (tracklist == null)
            {
                MessageBox.Show("Traklist is unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tracklist.ZeroTracklist();
            tracklistDataGrid.DataSource = tracklist;
            tracklistDataGrid.Refresh();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportTracklistDialog etd = new ExportTracklistDialog();

            if (etd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "JSON|*.json";
                    sfd.DefaultExt = "json";

                    if (sfd.ShowDialog() != DialogResult.OK) MessageBox.Show("Nothing to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    etd.GetOutputs(out int id, out string name, out string track_id_identifier, out string track_artist_identifier, out string track_title_identifier, out string start_time_identifier, out string end_time_identifier);
                    List<Track> tracks = tracklistDataGrid.DataSource as List<Track>;

                    if (tracks == null) throw new Exception("Datasource is null.");

                    Tracklist tracklist = new Tracklist(id, name, track_id_identifier, track_artist_identifier, track_title_identifier, start_time_identifier, end_time_identifier, tracks);
                    if (tracklist.ExportJson(sfd.FileName)) MessageBox.Show($"Successfully exported tracklist to {sfd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cannot export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            UploadTracklistDialog utd = new UploadTracklistDialog();

            if (utd.ShowDialog() == DialogResult.OK)
            {
                string connection_string = ConfigurationManager.GetConnectionString($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}connection_config.xml");
                QueryMarshal qm = new QueryMarshal(connection_string);

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        DataTable mix_data = qm.ExecuteOleDbStoredProcedure("GetMix", new Dictionary<string, object> { { "@MixName", utd.MixName } });

                        if (mix_data == null || mix_data.Rows.Count == 0)
                        {
                            Dictionary<string, object> parameters = new Dictionary<string, object>
                            {
                                { "@MixName", utd.MixName },
                                { "@ArtworkPath", utd.ArtworkPath },
                                { "@AudioFilePath", utd.AudioFilePath },
                            };

                            qm.ExecuteOleDbStoredProcedure("NewMix", parameters);
                            DataTable new_mix = qm.ExecuteOleDbStoredProcedure("GetMix", new Dictionary<string, object> { { "@MixName", utd.MixName } });
                            if (new_mix == null || new_mix.Rows.Count == 0) throw new Exception("Could not retrieve newly created mix.");
                            int new_mix_id = Convert.ToInt32(new_mix.Rows[0]["MixMasterID"]);

                            parameters = new Dictionary<string, object>
                            {
                                { "@MixMasterID", new_mix_id.ToString() },
                                { "@TracklistName", utd.TracklistName }
                            };

                            qm.ExecuteOleDbStoredProcedure("NewTracklist", parameters);
                            DataTable new_tracklist = qm.ExecuteOleDbStoredProcedure("GetTracklistMaster", new Dictionary<string, object> { { "@MixMasterID", new_mix_id.ToString() } });
                            if (new_tracklist == null || new_tracklist.Rows.Count == 0) throw new Exception("Could not retrieve newly created tracklist.");
                            int new_tracklist_id = Convert.ToInt32(new_tracklist.Rows[0]["TracklistMasterID"]);

                            List<Track> tracks = tracklistDataGrid.DataSource as List<Track>;
                            Tracklist tracklist = new Tracklist(new_tracklist_id, utd.TracklistName, "", "", "", "", "", tracks);

                            tracklist.UploadToDatabase(qm);

                            MessageBox.Show("Mix and tracklist successfully uploaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new NotImplementedException("Updating existing mixes is not implemented yet.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error encountered while uploading tracklist: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }
    }
}
