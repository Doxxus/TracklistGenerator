using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracklistGenerator.Dialogs
{
    public partial class UploadTracklistDialog : Form
    {
        public string MixName
        {
            get => mixNameTextBox.Text;
        }

        public string TracklistName 
        {
            get => tracklistNameTextBox.Text;
        }

        public string ArtworkPath
        {
            get => pathToArtworkTextBox.Text;
        }

        public string AudioFilePath
        {
            get => pathToAudioFileTextBox.Text;
        }

        public UploadTracklistDialog()
        {
            InitializeComponent();
        }

        private void mixNameTextBox_TextChanged(object sender, EventArgs e)
        {
            tracklistNameTextBox.Text = mixNameTextBox.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
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
