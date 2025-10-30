using System;
using System.Windows.Forms;

namespace TracklistGenerator.Dialogs
{
    public partial class ExportTracklistDialog : Form
    {
        public ExportTracklistDialog()
        {
            InitializeComponent();
        }

        public void GetOutputs(out int id, out string name, out string track_id_identifier, out string track_artist_identifier, out string track_title_identifier, out string start_time_identifier, out string end_time_identifier)
        {
            id = int.Parse(tracklistIDTextBox.Text);
            name = tracklistNameTextBox.Text;
            track_id_identifier = trackIdTextBox.Text;
            track_artist_identifier = artistTextBox.Text;
            track_title_identifier = trackTitleTextBox.Text;
            start_time_identifier = startTimeTextBox.Text;
            end_time_identifier = endTimeTextBox.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tracklistIDTextBox.Text, out var _))
            {
                MessageBox.Show("Please enter a valid tracklist ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
