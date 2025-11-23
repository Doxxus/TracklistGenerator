namespace TracklistGenerator.Dialogs
{
    partial class ExportTracklistDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportTracklistDialog));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tracklistNameGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tracklistNameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.tracklistIDTextBox = new System.Windows.Forms.TextBox();
            this.jsonIdentifierGroupBox = new System.Windows.Forms.GroupBox();
            this.jsonIdentifierLayout = new System.Windows.Forms.TableLayoutPanel();
            this.endTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.startTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.trackTitleGroupBox = new System.Windows.Forms.GroupBox();
            this.trackTitleTextBox = new System.Windows.Forms.TextBox();
            this.artistGroupBox = new System.Windows.Forms.GroupBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.trackIdGroupBox = new System.Windows.Forms.GroupBox();
            this.trackIdTextBox = new System.Windows.Forms.TextBox();
            this.mainLayout.SuspendLayout();
            this.tracklistNameGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.jsonIdentifierGroupBox.SuspendLayout();
            this.jsonIdentifierLayout.SuspendLayout();
            this.endTimeGroupBox.SuspendLayout();
            this.startTimeGroupBox.SuspendLayout();
            this.trackTitleGroupBox.SuspendLayout();
            this.artistGroupBox.SuspendLayout();
            this.trackIdGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.mainLayout.Controls.Add(this.cancelButton, 2, 3);
            this.mainLayout.Controls.Add(this.okButton, 1, 3);
            this.mainLayout.Controls.Add(this.tracklistNameGroupBox, 0, 0);
            this.mainLayout.Controls.Add(this.jsonIdentifierGroupBox, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.Size = new System.Drawing.Size(784, 161);
            this.mainLayout.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(637, 131);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(144, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(487, 131);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(144, 30);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tracklistNameGroupBox
            // 
            this.mainLayout.SetColumnSpan(this.tracklistNameGroupBox, 3);
            this.tracklistNameGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.tracklistNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracklistNameGroupBox.Location = new System.Drawing.Point(3, 3);
            this.tracklistNameGroupBox.Name = "tracklistNameGroupBox";
            this.tracklistNameGroupBox.Size = new System.Drawing.Size(778, 44);
            this.tracklistNameGroupBox.TabIndex = 0;
            this.tracklistNameGroupBox.TabStop = false;
            this.tracklistNameGroupBox.Text = "Tracklist Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tracklistNameTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tracklistIDTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 23);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tracklistNameTextBox
            // 
            this.tracklistNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracklistNameTextBox.Location = new System.Drawing.Point(63, 1);
            this.tracklistNameTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.tracklistNameTextBox.Name = "tracklistNameTextBox";
            this.tracklistNameTextBox.Size = new System.Drawing.Size(706, 22);
            this.tracklistNameTextBox.TabIndex = 2;
            this.tracklistNameTextBox.Text = "Tracklist Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLabel.Location = new System.Drawing.Point(3, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 23);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tracklistIDTextBox
            // 
            this.tracklistIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracklistIDTextBox.Location = new System.Drawing.Point(33, 1);
            this.tracklistIDTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.tracklistIDTextBox.Name = "tracklistIDTextBox";
            this.tracklistIDTextBox.Size = new System.Drawing.Size(24, 22);
            this.tracklistIDTextBox.TabIndex = 1;
            this.tracklistIDTextBox.Text = "1";
            this.tracklistIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jsonIdentifierGroupBox
            // 
            this.mainLayout.SetColumnSpan(this.jsonIdentifierGroupBox, 3);
            this.jsonIdentifierGroupBox.Controls.Add(this.jsonIdentifierLayout);
            this.jsonIdentifierGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonIdentifierGroupBox.Location = new System.Drawing.Point(3, 53);
            this.jsonIdentifierGroupBox.Name = "jsonIdentifierGroupBox";
            this.jsonIdentifierGroupBox.Size = new System.Drawing.Size(778, 74);
            this.jsonIdentifierGroupBox.TabIndex = 5;
            this.jsonIdentifierGroupBox.TabStop = false;
            this.jsonIdentifierGroupBox.Text = "JSON Track Identifier Strings";
            // 
            // jsonIdentifierLayout
            // 
            this.jsonIdentifierLayout.ColumnCount = 5;
            this.jsonIdentifierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.jsonIdentifierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.jsonIdentifierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.jsonIdentifierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.jsonIdentifierLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.jsonIdentifierLayout.Controls.Add(this.endTimeGroupBox, 4, 0);
            this.jsonIdentifierLayout.Controls.Add(this.startTimeGroupBox, 3, 0);
            this.jsonIdentifierLayout.Controls.Add(this.trackTitleGroupBox, 2, 0);
            this.jsonIdentifierLayout.Controls.Add(this.artistGroupBox, 1, 0);
            this.jsonIdentifierLayout.Controls.Add(this.trackIdGroupBox, 0, 0);
            this.jsonIdentifierLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonIdentifierLayout.Location = new System.Drawing.Point(3, 18);
            this.jsonIdentifierLayout.Name = "jsonIdentifierLayout";
            this.jsonIdentifierLayout.RowCount = 1;
            this.jsonIdentifierLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.jsonIdentifierLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jsonIdentifierLayout.Size = new System.Drawing.Size(772, 53);
            this.jsonIdentifierLayout.TabIndex = 0;
            // 
            // endTimeGroupBox
            // 
            this.endTimeGroupBox.Controls.Add(this.endTimeTextBox);
            this.endTimeGroupBox.Location = new System.Drawing.Point(619, 3);
            this.endTimeGroupBox.Name = "endTimeGroupBox";
            this.endTimeGroupBox.Size = new System.Drawing.Size(148, 47);
            this.endTimeGroupBox.TabIndex = 4;
            this.endTimeGroupBox.TabStop = false;
            this.endTimeGroupBox.Text = "End Time";
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endTimeTextBox.Location = new System.Drawing.Point(3, 18);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(142, 22);
            this.endTimeTextBox.TabIndex = 0;
            this.endTimeTextBox.Text = "end_time";
            this.endTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startTimeGroupBox
            // 
            this.startTimeGroupBox.Controls.Add(this.startTimeTextBox);
            this.startTimeGroupBox.Location = new System.Drawing.Point(465, 3);
            this.startTimeGroupBox.Name = "startTimeGroupBox";
            this.startTimeGroupBox.Size = new System.Drawing.Size(148, 47);
            this.startTimeGroupBox.TabIndex = 3;
            this.startTimeGroupBox.TabStop = false;
            this.startTimeGroupBox.Text = "Start Time";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTimeTextBox.Location = new System.Drawing.Point(3, 18);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(142, 22);
            this.startTimeTextBox.TabIndex = 0;
            this.startTimeTextBox.Text = "start_time";
            this.startTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackTitleGroupBox
            // 
            this.trackTitleGroupBox.Controls.Add(this.trackTitleTextBox);
            this.trackTitleGroupBox.Location = new System.Drawing.Point(311, 3);
            this.trackTitleGroupBox.Name = "trackTitleGroupBox";
            this.trackTitleGroupBox.Size = new System.Drawing.Size(148, 47);
            this.trackTitleGroupBox.TabIndex = 2;
            this.trackTitleGroupBox.TabStop = false;
            this.trackTitleGroupBox.Text = "Title";
            // 
            // trackTitleTextBox
            // 
            this.trackTitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackTitleTextBox.Location = new System.Drawing.Point(3, 18);
            this.trackTitleTextBox.Name = "trackTitleTextBox";
            this.trackTitleTextBox.Size = new System.Drawing.Size(142, 22);
            this.trackTitleTextBox.TabIndex = 0;
            this.trackTitleTextBox.Text = "title";
            this.trackTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // artistGroupBox
            // 
            this.artistGroupBox.Controls.Add(this.artistTextBox);
            this.artistGroupBox.Location = new System.Drawing.Point(157, 3);
            this.artistGroupBox.Name = "artistGroupBox";
            this.artistGroupBox.Size = new System.Drawing.Size(148, 47);
            this.artistGroupBox.TabIndex = 1;
            this.artistGroupBox.TabStop = false;
            this.artistGroupBox.Text = "Artist";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artistTextBox.Location = new System.Drawing.Point(3, 18);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(142, 22);
            this.artistTextBox.TabIndex = 0;
            this.artistTextBox.Text = "artist";
            this.artistTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackIdGroupBox
            // 
            this.trackIdGroupBox.Controls.Add(this.trackIdTextBox);
            this.trackIdGroupBox.Location = new System.Drawing.Point(3, 3);
            this.trackIdGroupBox.Name = "trackIdGroupBox";
            this.trackIdGroupBox.Size = new System.Drawing.Size(148, 47);
            this.trackIdGroupBox.TabIndex = 0;
            this.trackIdGroupBox.TabStop = false;
            this.trackIdGroupBox.Text = "Track ID";
            // 
            // trackIdTextBox
            // 
            this.trackIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackIdTextBox.Location = new System.Drawing.Point(3, 18);
            this.trackIdTextBox.Name = "trackIdTextBox";
            this.trackIdTextBox.Size = new System.Drawing.Size(142, 22);
            this.trackIdTextBox.TabIndex = 0;
            this.trackIdTextBox.Text = "id";
            this.trackIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExportTracklistDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 161);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 200);
            this.Name = "ExportTracklistDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Tracklist";
            this.mainLayout.ResumeLayout(false);
            this.tracklistNameGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.jsonIdentifierGroupBox.ResumeLayout(false);
            this.jsonIdentifierLayout.ResumeLayout(false);
            this.endTimeGroupBox.ResumeLayout(false);
            this.endTimeGroupBox.PerformLayout();
            this.startTimeGroupBox.ResumeLayout(false);
            this.startTimeGroupBox.PerformLayout();
            this.trackTitleGroupBox.ResumeLayout(false);
            this.trackTitleGroupBox.PerformLayout();
            this.artistGroupBox.ResumeLayout(false);
            this.artistGroupBox.PerformLayout();
            this.trackIdGroupBox.ResumeLayout(false);
            this.trackIdGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox tracklistNameGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tracklistNameTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox tracklistIDTextBox;
        private System.Windows.Forms.GroupBox jsonIdentifierGroupBox;
        private System.Windows.Forms.TableLayoutPanel jsonIdentifierLayout;
        private System.Windows.Forms.GroupBox trackIdGroupBox;
        private System.Windows.Forms.GroupBox endTimeGroupBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.GroupBox startTimeGroupBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.GroupBox trackTitleGroupBox;
        private System.Windows.Forms.TextBox trackTitleTextBox;
        private System.Windows.Forms.GroupBox artistGroupBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox trackIdTextBox;
    }
}