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
                    Task.Factory.StartNew(async () =>
                    {
                        await ProjectFileParser.GetTracklistFromProject(fileTextBox.Text);
                    });
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
