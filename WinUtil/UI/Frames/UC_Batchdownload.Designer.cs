namespace WinUtil.UI.Frames
{
    partial class UC_Batchdownload
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
            rTB_Urls = new RichTextBox();
            label3 = new Label();
            b_FromFile = new Button();
            b_FromClipboard = new Button();
            b_GenerateURLs = new Button();
            label1 = new Label();
            tB_DownloadDirectory = new TextBox();
            b_Select = new Button();
            b_Start = new Button();
            rB_SameFileNames = new RadioButton();
            rB_CreateNewFileNames = new RadioButton();
            l_Prefix = new Label();
            l_Suffix = new Label();
            tB_Prefix = new TextBox();
            tB_Suffix = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cB_OverWriteExistingFiles = new CheckBox();
            label2 = new Label();
            nUD_ParallelDownloads = new NumericUpDown();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ParallelDownloads).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox1, 5);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 452);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "URLs";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(rTB_Urls, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(b_FromFile, 1, 1);
            tableLayoutPanel1.Controls.Add(b_FromClipboard, 1, 2);
            tableLayoutPanel1.Controls.Add(b_GenerateURLs, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(511, 432);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // rTB_Urls
            // 
            rTB_Urls.Dock = DockStyle.Fill;
            rTB_Urls.Location = new Point(3, 3);
            rTB_Urls.Name = "rTB_Urls";
            tableLayoutPanel1.SetRowSpan(rTB_Urls, 5);
            rTB_Urls.Size = new Size(410, 426);
            rTB_Urls.TabIndex = 0;
            rTB_Urls.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(419, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 14;
            label3.Text = "add URLs:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_FromFile
            // 
            b_FromFile.Dock = DockStyle.Fill;
            b_FromFile.Location = new Point(419, 30);
            b_FromFile.Name = "b_FromFile";
            b_FromFile.Size = new Size(89, 21);
            b_FromFile.TabIndex = 13;
            b_FromFile.Text = "from text file";
            b_FromFile.UseVisualStyleBackColor = true;
            b_FromFile.Click += FromFile_Click;
            // 
            // b_FromClipboard
            // 
            b_FromClipboard.Dock = DockStyle.Fill;
            b_FromClipboard.Location = new Point(419, 57);
            b_FromClipboard.Name = "b_FromClipboard";
            b_FromClipboard.Size = new Size(89, 21);
            b_FromClipboard.TabIndex = 12;
            b_FromClipboard.Text = "from clipboard";
            b_FromClipboard.UseVisualStyleBackColor = true;
            b_FromClipboard.Click += FromClipboard_Click;
            // 
            // b_GenerateURLs
            // 
            b_GenerateURLs.Dock = DockStyle.Fill;
            b_GenerateURLs.Location = new Point(419, 84);
            b_GenerateURLs.Name = "b_GenerateURLs";
            b_GenerateURLs.Size = new Size(89, 21);
            b_GenerateURLs.TabIndex = 15;
            b_GenerateURLs.Text = "generate";
            b_GenerateURLs.UseVisualStyleBackColor = true;
            b_GenerateURLs.Click += GenerateURLs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 598);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 1;
            label1.Text = "download directory:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_DownloadDirectory
            // 
            tB_DownloadDirectory.Dock = DockStyle.Fill;
            tB_DownloadDirectory.Location = new Point(150, 601);
            tB_DownloadDirectory.Name = "tB_DownloadDirectory";
            tB_DownloadDirectory.Size = new Size(290, 21);
            tB_DownloadDirectory.TabIndex = 2;
            // 
            // b_Select
            // 
            b_Select.Location = new Point(446, 601);
            b_Select.Name = "b_Select";
            b_Select.Size = new Size(74, 21);
            b_Select.TabIndex = 3;
            b_Select.Text = "select";
            b_Select.UseVisualStyleBackColor = true;
            b_Select.Click += SelectDownloadDirectory_Click;
            // 
            // b_Start
            // 
            b_Start.Location = new Point(446, 660);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(74, 21);
            b_Start.TabIndex = 4;
            b_Start.Text = "start";
            b_Start.UseVisualStyleBackColor = true;
            b_Start.Click += Start_Click;
            // 
            // rB_SameFileNames
            // 
            rB_SameFileNames.AutoSize = true;
            rB_SameFileNames.Checked = true;
            tableLayoutPanel2.SetColumnSpan(rB_SameFileNames, 4);
            rB_SameFileNames.Dock = DockStyle.Fill;
            rB_SameFileNames.Location = new Point(3, 466);
            rB_SameFileNames.Name = "rB_SameFileNames";
            rB_SameFileNames.Size = new Size(437, 21);
            rB_SameFileNames.TabIndex = 5;
            rB_SameFileNames.TabStop = true;
            rB_SameFileNames.Text = "use same file names";
            rB_SameFileNames.UseVisualStyleBackColor = true;
            rB_SameFileNames.CheckedChanged += NamingSettingsChanged;
            // 
            // rB_CreateNewFileNames
            // 
            rB_CreateNewFileNames.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(rB_CreateNewFileNames, 4);
            rB_CreateNewFileNames.Dock = DockStyle.Fill;
            rB_CreateNewFileNames.Location = new Point(3, 493);
            rB_CreateNewFileNames.Name = "rB_CreateNewFileNames";
            rB_CreateNewFileNames.Size = new Size(437, 21);
            rB_CreateNewFileNames.TabIndex = 6;
            rB_CreateNewFileNames.Text = "create new filenames";
            rB_CreateNewFileNames.UseVisualStyleBackColor = true;
            rB_CreateNewFileNames.CheckedChanged += NamingSettingsChanged;
            // 
            // l_Prefix
            // 
            l_Prefix.AutoSize = true;
            l_Prefix.Dock = DockStyle.Fill;
            l_Prefix.Location = new Point(23, 517);
            l_Prefix.Name = "l_Prefix";
            l_Prefix.Size = new Size(76, 27);
            l_Prefix.TabIndex = 7;
            l_Prefix.Text = "prefix:";
            l_Prefix.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_Suffix
            // 
            l_Suffix.AutoSize = true;
            l_Suffix.Dock = DockStyle.Fill;
            l_Suffix.Location = new Point(23, 544);
            l_Suffix.Name = "l_Suffix";
            l_Suffix.Size = new Size(76, 27);
            l_Suffix.TabIndex = 9;
            l_Suffix.Text = "suffix:";
            l_Suffix.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_Prefix
            // 
            tableLayoutPanel2.SetColumnSpan(tB_Prefix, 2);
            tB_Prefix.Location = new Point(105, 520);
            tB_Prefix.Name = "tB_Prefix";
            tB_Prefix.Size = new Size(105, 21);
            tB_Prefix.TabIndex = 10;
            // 
            // tB_Suffix
            // 
            tableLayoutPanel2.SetColumnSpan(tB_Suffix, 2);
            tB_Suffix.Location = new Point(105, 547);
            tB_Suffix.Name = "tB_Suffix";
            tB_Suffix.Size = new Size(105, 21);
            tB_Suffix.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.Controls.Add(rB_SameFileNames, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(rB_CreateNewFileNames, 0, 3);
            tableLayoutPanel2.Controls.Add(l_Suffix, 1, 5);
            tableLayoutPanel2.Controls.Add(l_Prefix, 1, 4);
            tableLayoutPanel2.Controls.Add(cB_OverWriteExistingFiles, 0, 6);
            tableLayoutPanel2.Controls.Add(label1, 0, 7);
            tableLayoutPanel2.Controls.Add(tB_DownloadDirectory, 3, 7);
            tableLayoutPanel2.Controls.Add(b_Select, 4, 7);
            tableLayoutPanel2.Controls.Add(label2, 0, 8);
            tableLayoutPanel2.Controls.Add(tB_Prefix, 2, 4);
            tableLayoutPanel2.Controls.Add(tB_Suffix, 2, 5);
            tableLayoutPanel2.Controls.Add(nUD_ParallelDownloads, 3, 8);
            tableLayoutPanel2.Controls.Add(b_Start, 4, 10);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 11;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.Size = new Size(523, 684);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // cB_OverWriteExistingFiles
            // 
            cB_OverWriteExistingFiles.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(cB_OverWriteExistingFiles, 3);
            cB_OverWriteExistingFiles.Dock = DockStyle.Fill;
            cB_OverWriteExistingFiles.Location = new Point(3, 574);
            cB_OverWriteExistingFiles.Name = "cB_OverWriteExistingFiles";
            cB_OverWriteExistingFiles.Size = new Size(141, 21);
            cB_OverWriteExistingFiles.TabIndex = 12;
            cB_OverWriteExistingFiles.Text = "overwrite existing files";
            cB_OverWriteExistingFiles.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label2, 3);
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 625);
            label2.Name = "label2";
            label2.Size = new Size(141, 27);
            label2.TabIndex = 13;
            label2.Text = "number of parallel downloads:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nUD_ParallelDownloads
            // 
            nUD_ParallelDownloads.Location = new Point(150, 628);
            nUD_ParallelDownloads.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUD_ParallelDownloads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUD_ParallelDownloads.Name = "nUD_ParallelDownloads";
            nUD_ParallelDownloads.Size = new Size(60, 21);
            nUD_ParallelDownloads.TabIndex = 14;
            nUD_ParallelDownloads.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // UC_Batchdownload
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "UC_Batchdownload";
            Size = new Size(523, 684);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ParallelDownloads).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private RichTextBox rTB_Urls;
        private TextBox tB_DownloadDirectory;
        private Button b_Select;
        private Button b_Start;
        private RadioButton rB_SameFileNames;
        private RadioButton rB_CreateNewFileNames;
        private Label l_Prefix;
        private Label l_Suffix;
        private TextBox tB_Prefix;
        private TextBox tB_Suffix;
        private TableLayoutPanel tableLayoutPanel1;
        private Button b_FromClipboard;
        private Button b_FromFile;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox cB_OverWriteExistingFiles;
        private Label label2;
        private NumericUpDown nUD_ParallelDownloads;
        private Label label3;
        private Button b_GenerateURLs;
    }
}
