using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }
    }
}
