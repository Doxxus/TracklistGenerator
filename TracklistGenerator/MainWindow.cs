using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracklistGenerator.Dialogs;
using TracklistGenerator.Model;

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
                ofd.Filter = "Ableton Project|*.als|XML File|*.xml";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileTextBox.Text = ofd.FileName;
                    List<Track> tracklist = new List<Track>();

                    Task.Factory.StartNew(async () =>
                    {
                        tracklist = await ProjectFileParser.GetTracklistFromProject(fileTextBox.Text);
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

            TrackListOperations.Sort(ref tracklist);
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

            TrackListOperations.CombineAllDuplicates(ref tracklist);
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
                    tracklist.ExportJson(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cannot export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
