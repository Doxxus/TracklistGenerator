namespace TracklistGenerator
{
    partial class MainWindow
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.exportButton = new System.Windows.Forms.Button();
            this.fileBrowserGroupBox = new System.Windows.Forms.GroupBox();
            this.fileBrowserLayout = new System.Windows.Forms.TableLayoutPanel();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.infoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sortButton = new System.Windows.Forms.Button();
            this.rectifyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeSignatureLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tsDenominator = new System.Windows.Forms.NumericUpDown();
            this.tsSlashLabel = new System.Windows.Forms.Label();
            this.tsNumerator = new System.Windows.Forms.NumericUpDown();
            this.tempoGroupBox = new System.Windows.Forms.GroupBox();
            this.tempoUpDown = new System.Windows.Forms.NumericUpDown();
            this.sepLabel = new System.Windows.Forms.Label();
            this.tracklistDataGrid = new System.Windows.Forms.DataGridView();
            this.MainLayout.SuspendLayout();
            this.fileBrowserGroupBox.SuspendLayout();
            this.fileBrowserLayout.SuspendLayout();
            this.infoLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.timeSignatureLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsDenominator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsNumerator)).BeginInit();
            this.tempoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracklistDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.exportButton, 0, 3);
            this.MainLayout.Controls.Add(this.fileBrowserGroupBox, 0, 0);
            this.MainLayout.Controls.Add(this.infoLayout, 0, 1);
            this.MainLayout.Controls.Add(this.tracklistDataGrid, 0, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.Size = new System.Drawing.Size(1264, 681);
            this.MainLayout.TabIndex = 0;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(3, 651);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(1258, 30);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // fileBrowserGroupBox
            // 
            this.fileBrowserGroupBox.Controls.Add(this.fileBrowserLayout);
            this.fileBrowserGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileBrowserGroupBox.Location = new System.Drawing.Point(3, 3);
            this.fileBrowserGroupBox.Name = "fileBrowserGroupBox";
            this.fileBrowserGroupBox.Size = new System.Drawing.Size(1258, 44);
            this.fileBrowserGroupBox.TabIndex = 0;
            this.fileBrowserGroupBox.TabStop = false;
            this.fileBrowserGroupBox.Text = "Ableton Project";
            // 
            // fileBrowserLayout
            // 
            this.fileBrowserLayout.ColumnCount = 2;
            this.fileBrowserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileBrowserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fileBrowserLayout.Controls.Add(this.fileTextBox, 0, 0);
            this.fileBrowserLayout.Controls.Add(this.browseButton, 1, 0);
            this.fileBrowserLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileBrowserLayout.Location = new System.Drawing.Point(3, 18);
            this.fileBrowserLayout.Margin = new System.Windows.Forms.Padding(0);
            this.fileBrowserLayout.Name = "fileBrowserLayout";
            this.fileBrowserLayout.RowCount = 1;
            this.fileBrowserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileBrowserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.fileBrowserLayout.Size = new System.Drawing.Size(1252, 23);
            this.fileBrowserLayout.TabIndex = 0;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTextBox.Location = new System.Drawing.Point(3, 0);
            this.fileTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(1146, 22);
            this.fileTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(1155, 0);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(94, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // infoLayout
            // 
            this.infoLayout.ColumnCount = 6;
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoLayout.Controls.Add(this.sortButton, 3, 0);
            this.infoLayout.Controls.Add(this.rectifyButton, 4, 0);
            this.infoLayout.Controls.Add(this.groupBox1, 1, 0);
            this.infoLayout.Controls.Add(this.tempoGroupBox, 0, 0);
            this.infoLayout.Controls.Add(this.sepLabel, 2, 0);
            this.infoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLayout.Location = new System.Drawing.Point(0, 50);
            this.infoLayout.Margin = new System.Windows.Forms.Padding(0);
            this.infoLayout.Name = "infoLayout";
            this.infoLayout.RowCount = 1;
            this.infoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoLayout.Size = new System.Drawing.Size(1264, 50);
            this.infoLayout.TabIndex = 3;
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortButton.ForeColor = System.Drawing.Color.White;
            this.sortButton.Location = new System.Drawing.Point(228, 5);
            this.sortButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(94, 40);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort Tracklist";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // rectifyButton
            // 
            this.rectifyButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rectifyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectifyButton.ForeColor = System.Drawing.Color.White;
            this.rectifyButton.Location = new System.Drawing.Point(328, 5);
            this.rectifyButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rectifyButton.Name = "rectifyButton";
            this.rectifyButton.Size = new System.Drawing.Size(94, 40);
            this.rectifyButton.TabIndex = 2;
            this.rectifyButton.Text = "Combine All Duplicates";
            this.rectifyButton.UseVisualStyleBackColor = false;
            this.rectifyButton.Click += new System.EventHandler(this.rectifyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeSignatureLayout);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(103, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Signature";
            // 
            // timeSignatureLayout
            // 
            this.timeSignatureLayout.ColumnCount = 3;
            this.timeSignatureLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeSignatureLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.timeSignatureLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeSignatureLayout.Controls.Add(this.tsDenominator, 2, 0);
            this.timeSignatureLayout.Controls.Add(this.tsSlashLabel, 1, 0);
            this.timeSignatureLayout.Controls.Add(this.tsNumerator, 0, 0);
            this.timeSignatureLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeSignatureLayout.Location = new System.Drawing.Point(3, 18);
            this.timeSignatureLayout.Margin = new System.Windows.Forms.Padding(0);
            this.timeSignatureLayout.Name = "timeSignatureLayout";
            this.timeSignatureLayout.RowCount = 1;
            this.timeSignatureLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeSignatureLayout.Size = new System.Drawing.Size(108, 23);
            this.timeSignatureLayout.TabIndex = 0;
            // 
            // tsDenominator
            // 
            this.tsDenominator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsDenominator.Location = new System.Drawing.Point(64, 3);
            this.tsDenominator.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.tsDenominator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tsDenominator.Name = "tsDenominator";
            this.tsDenominator.Size = new System.Drawing.Size(41, 22);
            this.tsDenominator.TabIndex = 2;
            this.tsDenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsDenominator.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tsSlashLabel
            // 
            this.tsSlashLabel.AutoSize = true;
            this.tsSlashLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsSlashLabel.Location = new System.Drawing.Point(49, 0);
            this.tsSlashLabel.Name = "tsSlashLabel";
            this.tsSlashLabel.Size = new System.Drawing.Size(9, 23);
            this.tsSlashLabel.TabIndex = 0;
            this.tsSlashLabel.Text = "/";
            this.tsSlashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsNumerator
            // 
            this.tsNumerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsNumerator.Location = new System.Drawing.Point(3, 3);
            this.tsNumerator.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.tsNumerator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tsNumerator.Name = "tsNumerator";
            this.tsNumerator.Size = new System.Drawing.Size(40, 22);
            this.tsNumerator.TabIndex = 1;
            this.tsNumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsNumerator.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.tsNumerator.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tempoGroupBox
            // 
            this.tempoGroupBox.Controls.Add(this.tempoUpDown);
            this.tempoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.tempoGroupBox.Name = "tempoGroupBox";
            this.tempoGroupBox.Size = new System.Drawing.Size(94, 44);
            this.tempoGroupBox.TabIndex = 0;
            this.tempoGroupBox.TabStop = false;
            this.tempoGroupBox.Text = "Tempo";
            // 
            // tempoUpDown
            // 
            this.tempoUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempoUpDown.Location = new System.Drawing.Point(3, 18);
            this.tempoUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.tempoUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tempoUpDown.Name = "tempoUpDown";
            this.tempoUpDown.Size = new System.Drawing.Size(88, 22);
            this.tempoUpDown.TabIndex = 0;
            this.tempoUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempoUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // sepLabel
            // 
            this.sepLabel.AutoSize = true;
            this.sepLabel.BackColor = System.Drawing.Color.Black;
            this.sepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sepLabel.Location = new System.Drawing.Point(220, 0);
            this.sepLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sepLabel.Name = "sepLabel";
            this.sepLabel.Size = new System.Drawing.Size(5, 50);
            this.sepLabel.TabIndex = 4;
            // 
            // tracklistDataGrid
            // 
            this.tracklistDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tracklistDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.tracklistDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tracklistDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracklistDataGrid.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tracklistDataGrid.Location = new System.Drawing.Point(3, 103);
            this.tracklistDataGrid.Name = "tracklistDataGrid";
            this.tracklistDataGrid.RowHeadersVisible = false;
            this.tracklistDataGrid.Size = new System.Drawing.Size(1258, 545);
            this.tracklistDataGrid.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tracklist Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainLayout.ResumeLayout(false);
            this.fileBrowserGroupBox.ResumeLayout(false);
            this.fileBrowserLayout.ResumeLayout(false);
            this.fileBrowserLayout.PerformLayout();
            this.infoLayout.ResumeLayout(false);
            this.infoLayout.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.timeSignatureLayout.ResumeLayout(false);
            this.timeSignatureLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsDenominator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsNumerator)).EndInit();
            this.tempoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tempoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracklistDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.GroupBox fileBrowserGroupBox;
        private System.Windows.Forms.TableLayoutPanel fileBrowserLayout;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TableLayoutPanel infoLayout;
        private System.Windows.Forms.GroupBox tempoGroupBox;
        private System.Windows.Forms.NumericUpDown tempoUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel timeSignatureLayout;
        private System.Windows.Forms.Label tsSlashLabel;
        private System.Windows.Forms.NumericUpDown tsNumerator;
        private System.Windows.Forms.NumericUpDown tsDenominator;
        private System.Windows.Forms.DataGridView tracklistDataGrid;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button rectifyButton;
        private System.Windows.Forms.Label sepLabel;
    }
}