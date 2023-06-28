namespace WinUtil.UI.Frames
{
    partial class UC_AutoDownload
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
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            rB_SameFileNames = new RadioButton();
            rB_CreateNewFileNames = new RadioButton();
            cB_OverWriteExistingFiles = new CheckBox();
            l_Suffix = new Label();
            l_Prefix = new Label();
            tB_Suffix = new TextBox();
            tB_Prefix = new TextBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rB_UseSpecificDirectory = new RadioButton();
            tB_DownloadDirectory = new TextBox();
            b_Select = new Button();
            rB_URLBasedDirectory = new RadioButton();
            nUD_ParallelDownloads = new NumericUpDown();
            label2 = new Label();
            b_Start = new Button();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ParallelDownloads).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(nUD_ParallelDownloads, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(b_Start, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(499, 547);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox1, 3);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 159);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "file name creation";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(cB_OverWriteExistingFiles, 0, 4);
            tableLayoutPanel3.Controls.Add(l_Suffix, 1, 3);
            tableLayoutPanel3.Controls.Add(rB_CreateNewFileNames, 0, 1);
            tableLayoutPanel3.Controls.Add(l_Prefix, 1, 2);
            tableLayoutPanel3.Controls.Add(rB_SameFileNames, 0, 0);
            tableLayoutPanel3.Controls.Add(tB_Suffix, 2, 3);
            tableLayoutPanel3.Controls.Add(tB_Prefix, 2, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 17);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(487, 139);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // rB_SameFileNames
            // 
            rB_SameFileNames.AutoSize = true;
            rB_SameFileNames.Checked = true;
            tableLayoutPanel3.SetColumnSpan(rB_SameFileNames, 3);
            rB_SameFileNames.Dock = DockStyle.Fill;
            rB_SameFileNames.Location = new Point(3, 3);
            rB_SameFileNames.Name = "rB_SameFileNames";
            rB_SameFileNames.Size = new Size(481, 21);
            rB_SameFileNames.TabIndex = 5;
            rB_SameFileNames.TabStop = true;
            rB_SameFileNames.Text = "use same file names";
            rB_SameFileNames.UseVisualStyleBackColor = true;
            rB_SameFileNames.CheckedChanged += FileNameOptionsChanged;
            // 
            // rB_CreateNewFileNames
            // 
            rB_CreateNewFileNames.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(rB_CreateNewFileNames, 3);
            rB_CreateNewFileNames.Dock = DockStyle.Fill;
            rB_CreateNewFileNames.Location = new Point(3, 30);
            rB_CreateNewFileNames.Name = "rB_CreateNewFileNames";
            rB_CreateNewFileNames.Size = new Size(481, 21);
            rB_CreateNewFileNames.TabIndex = 6;
            rB_CreateNewFileNames.Text = "create new filenames";
            rB_CreateNewFileNames.UseVisualStyleBackColor = true;
            rB_CreateNewFileNames.CheckedChanged += FileNameOptionsChanged;
            // 
            // cB_OverWriteExistingFiles
            // 
            cB_OverWriteExistingFiles.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(cB_OverWriteExistingFiles, 3);
            cB_OverWriteExistingFiles.Dock = DockStyle.Fill;
            cB_OverWriteExistingFiles.Location = new Point(3, 111);
            cB_OverWriteExistingFiles.Name = "cB_OverWriteExistingFiles";
            cB_OverWriteExistingFiles.Size = new Size(481, 21);
            cB_OverWriteExistingFiles.TabIndex = 12;
            cB_OverWriteExistingFiles.Text = "overwrite existing files";
            cB_OverWriteExistingFiles.UseVisualStyleBackColor = true;
            // 
            // l_Suffix
            // 
            l_Suffix.AutoSize = true;
            l_Suffix.Dock = DockStyle.Fill;
            l_Suffix.Location = new Point(23, 81);
            l_Suffix.Name = "l_Suffix";
            l_Suffix.Size = new Size(59, 27);
            l_Suffix.TabIndex = 9;
            l_Suffix.Text = "suffix:";
            l_Suffix.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_Prefix
            // 
            l_Prefix.AutoSize = true;
            l_Prefix.Dock = DockStyle.Fill;
            l_Prefix.Location = new Point(23, 54);
            l_Prefix.Name = "l_Prefix";
            l_Prefix.Size = new Size(59, 27);
            l_Prefix.TabIndex = 7;
            l_Prefix.Text = "prefix:";
            l_Prefix.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_Suffix
            // 
            tB_Suffix.Location = new Point(88, 84);
            tB_Suffix.Name = "tB_Suffix";
            tB_Suffix.Size = new Size(105, 21);
            tB_Suffix.TabIndex = 11;
            // 
            // tB_Prefix
            // 
            tB_Prefix.Location = new Point(88, 57);
            tB_Prefix.Name = "tB_Prefix";
            tB_Prefix.Size = new Size(105, 21);
            tB_Prefix.TabIndex = 10;
            // 
            // groupBox2
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox2, 3);
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 74);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "download directory";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Controls.Add(rB_UseSpecificDirectory, 1, 0);
            tableLayoutPanel1.Controls.Add(tB_DownloadDirectory, 2, 0);
            tableLayoutPanel1.Controls.Add(b_Select, 3, 0);
            tableLayoutPanel1.Controls.Add(rB_URLBasedDirectory, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(487, 54);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rB_UseSpecificDirectory
            // 
            rB_UseSpecificDirectory.AutoSize = true;
            rB_UseSpecificDirectory.Location = new Point(23, 3);
            rB_UseSpecificDirectory.Name = "rB_UseSpecificDirectory";
            rB_UseSpecificDirectory.Size = new Size(75, 16);
            rB_UseSpecificDirectory.TabIndex = 15;
            rB_UseSpecificDirectory.Text = "use specific:";
            rB_UseSpecificDirectory.UseVisualStyleBackColor = true;
            rB_UseSpecificDirectory.CheckedChanged += DownloadDirectoryOptionsChanged;
            // 
            // tB_DownloadDirectory
            // 
            tB_DownloadDirectory.Location = new Point(143, 3);
            tB_DownloadDirectory.Name = "tB_DownloadDirectory";
            tB_DownloadDirectory.Size = new Size(256, 21);
            tB_DownloadDirectory.TabIndex = 2;
            // 
            // b_Select
            // 
            b_Select.Location = new Point(405, 3);
            b_Select.Name = "b_Select";
            b_Select.Size = new Size(74, 21);
            b_Select.TabIndex = 3;
            b_Select.Text = "select";
            b_Select.UseVisualStyleBackColor = true;
            b_Select.Click += b_Select_Click;
            // 
            // rB_URLBasedDirectory
            // 
            rB_URLBasedDirectory.AutoSize = true;
            rB_URLBasedDirectory.Checked = true;
            rB_URLBasedDirectory.Location = new Point(23, 30);
            rB_URLBasedDirectory.Name = "rB_URLBasedDirectory";
            rB_URLBasedDirectory.Size = new Size(107, 16);
            rB_URLBasedDirectory.TabIndex = 16;
            rB_URLBasedDirectory.TabStop = true;
            rB_URLBasedDirectory.Text = "create based on url";
            rB_URLBasedDirectory.UseVisualStyleBackColor = true;
            rB_URLBasedDirectory.CheckedChanged += DownloadDirectoryOptionsChanged;
            // 
            // nUD_ParallelDownloads
            // 
            nUD_ParallelDownloads.Location = new Point(172, 248);
            nUD_ParallelDownloads.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUD_ParallelDownloads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUD_ParallelDownloads.Name = "nUD_ParallelDownloads";
            nUD_ParallelDownloads.Size = new Size(60, 21);
            nUD_ParallelDownloads.TabIndex = 14;
            nUD_ParallelDownloads.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 245);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 13;
            label2.Text = "number of parallel downloads:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_Start
            // 
            b_Start.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(b_Start, 2);
            b_Start.Location = new Point(387, 275);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(109, 21);
            b_Start.TabIndex = 4;
            b_Start.Text = "monitor clipboard";
            b_Start.UseVisualStyleBackColor = true;
            b_Start.Click += b_Start_Click;
            // 
            // UC_AutoDownload
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "UC_AutoDownload";
            Size = new Size(499, 547);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ParallelDownloads).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton rB_SameFileNames;
        private RadioButton rB_CreateNewFileNames;
        private Label l_Suffix;
        private Label l_Prefix;
        private CheckBox cB_OverWriteExistingFiles;
        private TextBox tB_DownloadDirectory;
        private Button b_Select;
        private Label label2;
        private TextBox tB_Prefix;
        private TextBox tB_Suffix;
        private NumericUpDown nUD_ParallelDownloads;
        private Button b_Start;
        private RadioButton rB_UseSpecificDirectory;
        private RadioButton rB_URLBasedDirectory;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
