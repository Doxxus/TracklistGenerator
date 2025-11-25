namespace TracklistGenerator.Dialogs
{
    partial class UploadTracklistDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadTracklistDialog));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mixNameGroupBox = new System.Windows.Forms.GroupBox();
            this.trackilstNameGroupBox = new System.Windows.Forms.GroupBox();
            this.mixArtworkGroupBox = new System.Windows.Forms.GroupBox();
            this.mixAudioPathGroupBox = new System.Windows.Forms.GroupBox();
            this.mixNameTextBox = new System.Windows.Forms.TextBox();
            this.tracklistNameTextBox = new System.Windows.Forms.TextBox();
            this.pathToArtworkTextBox = new System.Windows.Forms.TextBox();
            this.pathToAudioFileTextBox = new System.Windows.Forms.TextBox();
            this.dialogButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.mixNameGroupBox.SuspendLayout();
            this.trackilstNameGroupBox.SuspendLayout();
            this.mixArtworkGroupBox.SuspendLayout();
            this.mixAudioPathGroupBox.SuspendLayout();
            this.dialogButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.mixAudioPathGroupBox, 0, 2);
            this.mainLayout.Controls.Add(this.mixArtworkGroupBox, 0, 1);
            this.mainLayout.Controls.Add(this.trackilstNameGroupBox, 1, 0);
            this.mainLayout.Controls.Add(this.mixNameGroupBox, 0, 0);
            this.mainLayout.Controls.Add(this.dialogButtonLayout, 1, 4);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 5;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.Size = new System.Drawing.Size(784, 181);
            this.mainLayout.TabIndex = 0;
            // 
            // mixNameGroupBox
            // 
            this.mixNameGroupBox.Controls.Add(this.mixNameTextBox);
            this.mixNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixNameGroupBox.Location = new System.Drawing.Point(3, 3);
            this.mixNameGroupBox.Name = "mixNameGroupBox";
            this.mixNameGroupBox.Size = new System.Drawing.Size(386, 44);
            this.mixNameGroupBox.TabIndex = 0;
            this.mixNameGroupBox.TabStop = false;
            this.mixNameGroupBox.Text = "Mix Name";
            // 
            // trackilstNameGroupBox
            // 
            this.trackilstNameGroupBox.Controls.Add(this.tracklistNameTextBox);
            this.trackilstNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackilstNameGroupBox.Location = new System.Drawing.Point(395, 3);
            this.trackilstNameGroupBox.Name = "trackilstNameGroupBox";
            this.trackilstNameGroupBox.Size = new System.Drawing.Size(386, 44);
            this.trackilstNameGroupBox.TabIndex = 1;
            this.trackilstNameGroupBox.TabStop = false;
            this.trackilstNameGroupBox.Text = "Tracklist Name";
            // 
            // mixArtworkGroupBox
            // 
            this.mainLayout.SetColumnSpan(this.mixArtworkGroupBox, 2);
            this.mixArtworkGroupBox.Controls.Add(this.pathToArtworkTextBox);
            this.mixArtworkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixArtworkGroupBox.Location = new System.Drawing.Point(3, 53);
            this.mixArtworkGroupBox.Name = "mixArtworkGroupBox";
            this.mixArtworkGroupBox.Size = new System.Drawing.Size(778, 44);
            this.mixArtworkGroupBox.TabIndex = 2;
            this.mixArtworkGroupBox.TabStop = false;
            this.mixArtworkGroupBox.Text = "Path To Artwork";
            // 
            // mixAudioPathGroupBox
            // 
            this.mainLayout.SetColumnSpan(this.mixAudioPathGroupBox, 2);
            this.mixAudioPathGroupBox.Controls.Add(this.pathToAudioFileTextBox);
            this.mixAudioPathGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixAudioPathGroupBox.Location = new System.Drawing.Point(3, 103);
            this.mixAudioPathGroupBox.Name = "mixAudioPathGroupBox";
            this.mixAudioPathGroupBox.Size = new System.Drawing.Size(778, 44);
            this.mixAudioPathGroupBox.TabIndex = 3;
            this.mixAudioPathGroupBox.TabStop = false;
            this.mixAudioPathGroupBox.Text = "Path To Audio File";
            // 
            // mixNameTextBox
            // 
            this.mixNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.mixNameTextBox.Name = "mixNameTextBox";
            this.mixNameTextBox.Size = new System.Drawing.Size(380, 22);
            this.mixNameTextBox.TabIndex = 0;
            this.mixNameTextBox.TextChanged += new System.EventHandler(this.mixNameTextBox_TextChanged);
            // 
            // tracklistNameTextBox
            // 
            this.tracklistNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracklistNameTextBox.Location = new System.Drawing.Point(3, 18);
            this.tracklistNameTextBox.Name = "tracklistNameTextBox";
            this.tracklistNameTextBox.Size = new System.Drawing.Size(380, 22);
            this.tracklistNameTextBox.TabIndex = 1;
            // 
            // pathToArtworkTextBox
            // 
            this.pathToArtworkTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathToArtworkTextBox.Location = new System.Drawing.Point(3, 18);
            this.pathToArtworkTextBox.Name = "pathToArtworkTextBox";
            this.pathToArtworkTextBox.Size = new System.Drawing.Size(772, 22);
            this.pathToArtworkTextBox.TabIndex = 1;
            // 
            // pathToAudioFileTextBox
            // 
            this.pathToAudioFileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathToAudioFileTextBox.Location = new System.Drawing.Point(3, 18);
            this.pathToAudioFileTextBox.Name = "pathToAudioFileTextBox";
            this.pathToAudioFileTextBox.Size = new System.Drawing.Size(772, 22);
            this.pathToAudioFileTextBox.TabIndex = 1;
            // 
            // dialogButtonLayout
            // 
            this.dialogButtonLayout.ColumnCount = 3;
            this.dialogButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dialogButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.dialogButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.dialogButtonLayout.Controls.Add(this.cancelButton, 2, 0);
            this.dialogButtonLayout.Controls.Add(this.okButton, 1, 0);
            this.dialogButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogButtonLayout.Location = new System.Drawing.Point(392, 151);
            this.dialogButtonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.dialogButtonLayout.Name = "dialogButtonLayout";
            this.dialogButtonLayout.RowCount = 1;
            this.dialogButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dialogButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dialogButtonLayout.Size = new System.Drawing.Size(392, 30);
            this.dialogButtonLayout.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(95, 0);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(144, 30);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(245, 0);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(144, 30);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UploadTracklistDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 181);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 220);
            this.Name = "UploadTracklistDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Tracklist";
            this.mainLayout.ResumeLayout(false);
            this.mixNameGroupBox.ResumeLayout(false);
            this.mixNameGroupBox.PerformLayout();
            this.trackilstNameGroupBox.ResumeLayout(false);
            this.trackilstNameGroupBox.PerformLayout();
            this.mixArtworkGroupBox.ResumeLayout(false);
            this.mixArtworkGroupBox.PerformLayout();
            this.mixAudioPathGroupBox.ResumeLayout(false);
            this.mixAudioPathGroupBox.PerformLayout();
            this.dialogButtonLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.GroupBox trackilstNameGroupBox;
        private System.Windows.Forms.GroupBox mixNameGroupBox;
        private System.Windows.Forms.GroupBox mixAudioPathGroupBox;
        private System.Windows.Forms.GroupBox mixArtworkGroupBox;
        private System.Windows.Forms.TextBox pathToAudioFileTextBox;
        private System.Windows.Forms.TextBox pathToArtworkTextBox;
        private System.Windows.Forms.TextBox tracklistNameTextBox;
        private System.Windows.Forms.TextBox mixNameTextBox;
        private System.Windows.Forms.TableLayoutPanel dialogButtonLayout;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}