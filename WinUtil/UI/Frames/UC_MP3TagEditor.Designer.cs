namespace WinUtil.UI.Frames
{
    partial class UC_MP3TagEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rTB_FileList = new RichTextBox();
            label2 = new Label();
            b_FileListFromClipboard = new Button();
            b_FromDirectory = new Button();
            b_FileListFromFile = new Button();
            b_SelectFiles = new Button();
            b_WriteTags = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cB_SetTrackNumber = new CheckBox();
            cB_TrackNumberFromFilename = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tB_ArtistName = new TextBox();
            tB_AlbumName = new TextBox();
            tB_AlbumCoverFilePath = new TextBox();
            b_SelectAlbumCoverFilePath = new Button();
            nUD_ReleaseYear = new NumericUpDown();
            cB_SetTitleFromFileName = new CheckBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ReleaseYear).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 458);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of files to edit";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Controls.Add(rTB_FileList, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(b_FileListFromClipboard, 1, 4);
            tableLayoutPanel1.Controls.Add(b_FromDirectory, 1, 3);
            tableLayoutPanel1.Controls.Add(b_FileListFromFile, 1, 2);
            tableLayoutPanel1.Controls.Add(b_SelectFiles, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(627, 438);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rTB_FileList
            // 
            rTB_FileList.Dock = DockStyle.Fill;
            rTB_FileList.Location = new Point(3, 3);
            rTB_FileList.Name = "rTB_FileList";
            tableLayoutPanel1.SetRowSpan(rTB_FileList, 6);
            rTB_FileList.Size = new Size(519, 432);
            rTB_FileList.TabIndex = 0;
            rTB_FileList.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(528, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 4;
            label2.Text = "add file paths:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_FileListFromClipboard
            // 
            b_FileListFromClipboard.Dock = DockStyle.Fill;
            b_FileListFromClipboard.Location = new Point(528, 120);
            b_FileListFromClipboard.Name = "b_FileListFromClipboard";
            b_FileListFromClipboard.Size = new Size(96, 24);
            b_FileListFromClipboard.TabIndex = 2;
            b_FileListFromClipboard.Text = "from clipboard";
            b_FileListFromClipboard.UseVisualStyleBackColor = true;
            b_FileListFromClipboard.Click += FileListFromClipboard_Click;
            // 
            // b_FromDirectory
            // 
            b_FromDirectory.Dock = DockStyle.Fill;
            b_FromDirectory.Location = new Point(528, 90);
            b_FromDirectory.Name = "b_FromDirectory";
            b_FromDirectory.Size = new Size(96, 24);
            b_FromDirectory.TabIndex = 3;
            b_FromDirectory.Text = "from directory";
            b_FromDirectory.UseVisualStyleBackColor = true;
            b_FromDirectory.Click += FromDirectory_Click;
            // 
            // b_FileListFromFile
            // 
            b_FileListFromFile.Dock = DockStyle.Fill;
            b_FileListFromFile.Location = new Point(528, 60);
            b_FileListFromFile.Name = "b_FileListFromFile";
            b_FileListFromFile.Size = new Size(96, 24);
            b_FileListFromFile.TabIndex = 1;
            b_FileListFromFile.Text = "from text file";
            b_FileListFromFile.UseVisualStyleBackColor = true;
            b_FileListFromFile.Click += FileListFromFile_Click;
            // 
            // b_SelectFiles
            // 
            b_SelectFiles.Dock = DockStyle.Fill;
            b_SelectFiles.Location = new Point(528, 30);
            b_SelectFiles.Name = "b_SelectFiles";
            b_SelectFiles.Size = new Size(96, 24);
            b_SelectFiles.TabIndex = 5;
            b_SelectFiles.Text = "via file dialog";
            b_SelectFiles.UseVisualStyleBackColor = true;
            b_SelectFiles.Click += SelectSingleFiles_Click;
            // 
            // b_WriteTags
            // 
            b_WriteTags.Dock = DockStyle.Fill;
            b_WriteTags.Location = new Point(552, 687);
            b_WriteTags.Name = "b_WriteTags";
            b_WriteTags.Size = new Size(84, 24);
            b_WriteTags.TabIndex = 15;
            b_WriteTags.Text = "write tags";
            b_WriteTags.UseVisualStyleBackColor = true;
            b_WriteTags.Click += SetTags_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 16;
            label1.Text = "Artist:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 27);
            label3.Name = "label3";
            label3.Size = new Size(78, 27);
            label3.TabIndex = 17;
            label3.Text = "Album:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(78, 27);
            label4.TabIndex = 18;
            label4.Text = "Release year:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 81);
            label5.Name = "label5";
            label5.Size = new Size(78, 27);
            label5.TabIndex = 19;
            label5.Text = "Cover image:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cB_SetTrackNumber
            // 
            cB_SetTrackNumber.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(cB_SetTrackNumber, 3);
            cB_SetTrackNumber.Dock = DockStyle.Fill;
            cB_SetTrackNumber.Location = new Point(3, 111);
            cB_SetTrackNumber.Name = "cB_SetTrackNumber";
            cB_SetTrackNumber.Size = new Size(541, 21);
            cB_SetTrackNumber.TabIndex = 20;
            cB_SetTrackNumber.Text = "set track number";
            cB_SetTrackNumber.UseVisualStyleBackColor = true;
            cB_SetTrackNumber.CheckedChanged += SetTrackNumber_CheckedChanged;
            // 
            // cB_TrackNumberFromFilename
            // 
            cB_TrackNumberFromFilename.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(cB_TrackNumberFromFilename, 2);
            cB_TrackNumberFromFilename.Dock = DockStyle.Fill;
            cB_TrackNumberFromFilename.Location = new Point(23, 138);
            cB_TrackNumberFromFilename.Name = "cB_TrackNumberFromFilename";
            cB_TrackNumberFromFilename.Size = new Size(521, 21);
            cB_TrackNumberFromFilename.TabIndex = 21;
            cB_TrackNumberFromFilename.Text = "... from file name";
            cB_TrackNumberFromFilename.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.Controls.Add(b_WriteTags, 1, 2);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(639, 714);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // groupBox2
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 467);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(633, 214);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tag values";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(cB_TrackNumberFromFilename, 1, 5);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(cB_SetTrackNumber, 0, 4);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(label5, 0, 3);
            tableLayoutPanel3.Controls.Add(tB_ArtistName, 2, 0);
            tableLayoutPanel3.Controls.Add(tB_AlbumName, 2, 1);
            tableLayoutPanel3.Controls.Add(tB_AlbumCoverFilePath, 2, 3);
            tableLayoutPanel3.Controls.Add(b_SelectAlbumCoverFilePath, 3, 3);
            tableLayoutPanel3.Controls.Add(nUD_ReleaseYear, 2, 2);
            tableLayoutPanel3.Controls.Add(cB_SetTitleFromFileName, 0, 6);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 17);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(627, 194);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tB_ArtistName
            // 
            tB_ArtistName.Dock = DockStyle.Fill;
            tB_ArtistName.Location = new Point(87, 3);
            tB_ArtistName.Name = "tB_ArtistName";
            tB_ArtistName.Size = new Size(457, 21);
            tB_ArtistName.TabIndex = 22;
            // 
            // tB_AlbumName
            // 
            tB_AlbumName.Dock = DockStyle.Fill;
            tB_AlbumName.Location = new Point(87, 30);
            tB_AlbumName.Name = "tB_AlbumName";
            tB_AlbumName.Size = new Size(457, 21);
            tB_AlbumName.TabIndex = 23;
            // 
            // tB_AlbumCoverFilePath
            // 
            tB_AlbumCoverFilePath.Dock = DockStyle.Fill;
            tB_AlbumCoverFilePath.Location = new Point(87, 84);
            tB_AlbumCoverFilePath.Name = "tB_AlbumCoverFilePath";
            tB_AlbumCoverFilePath.Size = new Size(457, 21);
            tB_AlbumCoverFilePath.TabIndex = 25;
            // 
            // b_SelectAlbumCoverFilePath
            // 
            b_SelectAlbumCoverFilePath.Dock = DockStyle.Fill;
            b_SelectAlbumCoverFilePath.Location = new Point(550, 84);
            b_SelectAlbumCoverFilePath.Name = "b_SelectAlbumCoverFilePath";
            b_SelectAlbumCoverFilePath.Size = new Size(74, 21);
            b_SelectAlbumCoverFilePath.TabIndex = 26;
            b_SelectAlbumCoverFilePath.Text = "select";
            b_SelectAlbumCoverFilePath.UseVisualStyleBackColor = true;
            b_SelectAlbumCoverFilePath.Click += SelectAlbumCoverFilePath_Click;
            // 
            // nUD_ReleaseYear
            // 
            nUD_ReleaseYear.Dock = DockStyle.Fill;
            nUD_ReleaseYear.Location = new Point(87, 57);
            nUD_ReleaseYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nUD_ReleaseYear.Name = "nUD_ReleaseYear";
            nUD_ReleaseYear.Size = new Size(457, 21);
            nUD_ReleaseYear.TabIndex = 27;
            // 
            // cB_SetTitleFromFileName
            // 
            cB_SetTitleFromFileName.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(cB_SetTitleFromFileName, 3);
            cB_SetTitleFromFileName.Dock = DockStyle.Fill;
            cB_SetTitleFromFileName.Location = new Point(3, 165);
            cB_SetTitleFromFileName.Name = "cB_SetTitleFromFileName";
            cB_SetTitleFromFileName.Size = new Size(541, 26);
            cB_SetTitleFromFileName.TabIndex = 28;
            cB_SetTitleFromFileName.Text = "set title based on file name";
            cB_SetTitleFromFileName.UseVisualStyleBackColor = true;
            // 
            // UC_MP3TagEditor
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "UC_MP3TagEditor";
            Size = new Size(639, 714);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ReleaseYear).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox rTB_FileList;
        private Button b_FileListFromFile;
        private Button b_FileListFromClipboard;
        private Button b_WriteTags;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox cB_SetTrackNumber;
        private CheckBox cB_TrackNumberFromFilename;
        private Label label2;
        private Button b_FromDirectory;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tB_ArtistName;
        private TextBox tB_AlbumName;
        private TextBox tB_AlbumCoverFilePath;
        private Button b_SelectAlbumCoverFilePath;
        private NumericUpDown nUD_ReleaseYear;
        private Button b_SelectFiles;
        private CheckBox cB_SetTitleFromFileName;
    }
}
