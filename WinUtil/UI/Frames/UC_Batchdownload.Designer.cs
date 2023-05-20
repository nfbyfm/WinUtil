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
            b_FromClipboard = new Button();
            rTB_Urls = new RichTextBox();
            b_FromFile = new Button();
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
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "URLs";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.Controls.Add(b_FromClipboard, 2, 1);
            tableLayoutPanel1.Controls.Add(rTB_Urls, 0, 0);
            tableLayoutPanel1.Controls.Add(b_FromFile, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(858, 380);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // b_FromClipboard
            // 
            b_FromClipboard.Dock = DockStyle.Fill;
            b_FromClipboard.Location = new Point(766, 356);
            b_FromClipboard.Name = "b_FromClipboard";
            b_FromClipboard.Size = new Size(89, 21);
            b_FromClipboard.TabIndex = 12;
            b_FromClipboard.Text = "from clipboard";
            b_FromClipboard.UseVisualStyleBackColor = true;
            b_FromClipboard.Click += FromClipboard_Click;
            // 
            // rTB_Urls
            // 
            tableLayoutPanel1.SetColumnSpan(rTB_Urls, 3);
            rTB_Urls.Dock = DockStyle.Fill;
            rTB_Urls.Location = new Point(3, 3);
            rTB_Urls.Name = "rTB_Urls";
            rTB_Urls.Size = new Size(852, 347);
            rTB_Urls.TabIndex = 0;
            rTB_Urls.Text = "";
            // 
            // b_FromFile
            // 
            b_FromFile.Dock = DockStyle.Fill;
            b_FromFile.Location = new Point(671, 356);
            b_FromFile.Name = "b_FromFile";
            b_FromFile.Size = new Size(89, 21);
            b_FromFile.TabIndex = 13;
            b_FromFile.Text = "from file ...";
            b_FromFile.UseVisualStyleBackColor = true;
            b_FromFile.Click += FromFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 519);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 1;
            label1.Text = "Download directory:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_DownloadDirectory
            // 
            tB_DownloadDirectory.Dock = DockStyle.Fill;
            tB_DownloadDirectory.Location = new Point(111, 522);
            tB_DownloadDirectory.Name = "tB_DownloadDirectory";
            tB_DownloadDirectory.Size = new Size(405, 21);
            tB_DownloadDirectory.TabIndex = 2;
            // 
            // b_Select
            // 
            b_Select.Location = new Point(522, 522);
            b_Select.Name = "b_Select";
            b_Select.Size = new Size(75, 21);
            b_Select.TabIndex = 3;
            b_Select.Text = "Select";
            b_Select.UseVisualStyleBackColor = true;
            b_Select.Click += Select_Click;
            // 
            // b_Start
            // 
            tableLayoutPanel2.SetColumnSpan(b_Start, 2);
            b_Start.Location = new Point(3, 554);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(75, 21);
            b_Start.TabIndex = 4;
            b_Start.Text = "Start";
            b_Start.UseVisualStyleBackColor = true;
            b_Start.Click += Start_Click;
            // 
            // rB_SameFileNames
            // 
            rB_SameFileNames.AutoSize = true;
            rB_SameFileNames.Checked = true;
            tableLayoutPanel2.SetColumnSpan(rB_SameFileNames, 3);
            rB_SameFileNames.Dock = DockStyle.Fill;
            rB_SameFileNames.Location = new Point(3, 414);
            rB_SameFileNames.Name = "rB_SameFileNames";
            rB_SameFileNames.Size = new Size(513, 21);
            rB_SameFileNames.TabIndex = 5;
            rB_SameFileNames.TabStop = true;
            rB_SameFileNames.Text = "use same file names";
            rB_SameFileNames.UseVisualStyleBackColor = true;
            rB_SameFileNames.CheckedChanged += NamingSettingsChanged;
            // 
            // rB_CreateNewFileNames
            // 
            rB_CreateNewFileNames.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(rB_CreateNewFileNames, 3);
            rB_CreateNewFileNames.Dock = DockStyle.Fill;
            rB_CreateNewFileNames.Location = new Point(3, 441);
            rB_CreateNewFileNames.Name = "rB_CreateNewFileNames";
            rB_CreateNewFileNames.Size = new Size(513, 21);
            rB_CreateNewFileNames.TabIndex = 6;
            rB_CreateNewFileNames.Text = "create new filenames";
            rB_CreateNewFileNames.UseVisualStyleBackColor = true;
            rB_CreateNewFileNames.CheckedChanged += NamingSettingsChanged;
            // 
            // l_Prefix
            // 
            l_Prefix.AutoSize = true;
            l_Prefix.Dock = DockStyle.Fill;
            l_Prefix.Location = new Point(23, 465);
            l_Prefix.Name = "l_Prefix";
            l_Prefix.Size = new Size(82, 27);
            l_Prefix.TabIndex = 7;
            l_Prefix.Text = "Prefix:";
            l_Prefix.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_Suffix
            // 
            l_Suffix.AutoSize = true;
            l_Suffix.Dock = DockStyle.Fill;
            l_Suffix.Location = new Point(23, 492);
            l_Suffix.Name = "l_Suffix";
            l_Suffix.Size = new Size(82, 27);
            l_Suffix.TabIndex = 9;
            l_Suffix.Text = "Suffix:";
            l_Suffix.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_Prefix
            // 
            tB_Prefix.Location = new Point(111, 468);
            tB_Prefix.Name = "tB_Prefix";
            tB_Prefix.Size = new Size(226, 21);
            tB_Prefix.TabIndex = 10;
            // 
            // tB_Suffix
            // 
            tB_Suffix.Location = new Point(111, 495);
            tB_Suffix.Name = "tB_Suffix";
            tB_Suffix.Size = new Size(226, 21);
            tB_Suffix.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 411F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(rB_SameFileNames, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(b_Select, 3, 6);
            tableLayoutPanel2.Controls.Add(b_Start, 0, 8);
            tableLayoutPanel2.Controls.Add(tB_Suffix, 2, 5);
            tableLayoutPanel2.Controls.Add(rB_CreateNewFileNames, 0, 3);
            tableLayoutPanel2.Controls.Add(tB_DownloadDirectory, 2, 6);
            tableLayoutPanel2.Controls.Add(l_Suffix, 1, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 6);
            tableLayoutPanel2.Controls.Add(tB_Prefix, 2, 4);
            tableLayoutPanel2.Controls.Add(l_Prefix, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.Size = new Size(870, 578);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // UC_Batchdownload
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "UC_Batchdownload";
            Size = new Size(870, 578);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
    }
}
