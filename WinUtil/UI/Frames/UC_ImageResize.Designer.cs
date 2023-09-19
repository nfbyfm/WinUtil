namespace WinUtil.UI.Frames
{
    partial class UC_ImageResize
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            rTB_FileList = new RichTextBox();
            b_FilesFromDialog = new Button();
            b_FilesFromDirectory = new Button();
            b_FilesFromClipboard = new Button();
            rB_UseSameFileNames = new RadioButton();
            rB_CreateNewFileNames = new RadioButton();
            l_Prefix = new Label();
            l_Suffix = new Label();
            tB_Prefix = new TextBox();
            tB_Suffix = new TextBox();
            b_Start = new Button();
            label2 = new Label();
            nUD_ImageWidth = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ImageWidth).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(rB_UseSameFileNames, 0, 1);
            tableLayoutPanel1.Controls.Add(rB_CreateNewFileNames, 0, 2);
            tableLayoutPanel1.Controls.Add(l_Prefix, 0, 3);
            tableLayoutPanel1.Controls.Add(l_Suffix, 0, 4);
            tableLayoutPanel1.Controls.Add(tB_Prefix, 1, 3);
            tableLayoutPanel1.Controls.Add(tB_Suffix, 1, 4);
            tableLayoutPanel1.Controls.Add(b_Start, 2, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 5);
            tableLayoutPanel1.Controls.Add(nUD_ImageWidth, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(478, 456);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 3);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "files to convert";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(rTB_FileList, 0, 0);
            tableLayoutPanel2.Controls.Add(b_FilesFromDialog, 1, 1);
            tableLayoutPanel2.Controls.Add(b_FilesFromDirectory, 1, 2);
            tableLayoutPanel2.Controls.Add(b_FilesFromClipboard, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 17);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(466, 268);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(379, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 27);
            label1.TabIndex = 0;
            label1.Text = "add file paths:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTB_FileList
            // 
            rTB_FileList.Dock = DockStyle.Fill;
            rTB_FileList.Location = new Point(3, 3);
            rTB_FileList.Name = "rTB_FileList";
            tableLayoutPanel2.SetRowSpan(rTB_FileList, 6);
            rTB_FileList.Size = new Size(370, 262);
            rTB_FileList.TabIndex = 1;
            rTB_FileList.Text = "";
            // 
            // b_FilesFromDialog
            // 
            b_FilesFromDialog.Dock = DockStyle.Fill;
            b_FilesFromDialog.Location = new Point(379, 30);
            b_FilesFromDialog.Name = "b_FilesFromDialog";
            b_FilesFromDialog.Size = new Size(84, 21);
            b_FilesFromDialog.TabIndex = 2;
            b_FilesFromDialog.Text = "via file dialog";
            b_FilesFromDialog.UseVisualStyleBackColor = true;
            b_FilesFromDialog.Click += FilesFromDialog_Click;
            // 
            // b_FilesFromDirectory
            // 
            b_FilesFromDirectory.Dock = DockStyle.Fill;
            b_FilesFromDirectory.Location = new Point(379, 57);
            b_FilesFromDirectory.Name = "b_FilesFromDirectory";
            b_FilesFromDirectory.Size = new Size(84, 21);
            b_FilesFromDirectory.TabIndex = 3;
            b_FilesFromDirectory.Text = "from directory";
            b_FilesFromDirectory.UseVisualStyleBackColor = true;
            b_FilesFromDirectory.Click += FilesFromDirectory_Click;
            // 
            // b_FilesFromClipboard
            // 
            b_FilesFromClipboard.Dock = DockStyle.Fill;
            b_FilesFromClipboard.Location = new Point(379, 84);
            b_FilesFromClipboard.Name = "b_FilesFromClipboard";
            b_FilesFromClipboard.Size = new Size(84, 21);
            b_FilesFromClipboard.TabIndex = 4;
            b_FilesFromClipboard.Text = "from clipboard";
            b_FilesFromClipboard.UseVisualStyleBackColor = true;
            b_FilesFromClipboard.Click += FilesFromClipboard_Click;
            // 
            // rB_UseSameFileNames
            // 
            rB_UseSameFileNames.AutoSize = true;
            rB_UseSameFileNames.Checked = true;
            rB_UseSameFileNames.Location = new Point(3, 297);
            rB_UseSameFileNames.Name = "rB_UseSameFileNames";
            rB_UseSameFileNames.Size = new Size(91, 16);
            rB_UseSameFileNames.TabIndex = 1;
            rB_UseSameFileNames.TabStop = true;
            rB_UseSameFileNames.Text = "use same file names";
            rB_UseSameFileNames.UseVisualStyleBackColor = true;
            rB_UseSameFileNames.CheckedChanged += FileNamesOptions_Changed;
            // 
            // rB_CreateNewFileNames
            // 
            rB_CreateNewFileNames.AutoSize = true;
            rB_CreateNewFileNames.Location = new Point(3, 324);
            rB_CreateNewFileNames.Name = "rB_CreateNewFileNames";
            rB_CreateNewFileNames.Size = new Size(91, 16);
            rB_CreateNewFileNames.TabIndex = 2;
            rB_CreateNewFileNames.Text = "create new file names";
            rB_CreateNewFileNames.UseVisualStyleBackColor = true;
            rB_CreateNewFileNames.CheckedChanged += FileNamesOptions_Changed;
            // 
            // l_Prefix
            // 
            l_Prefix.AutoSize = true;
            l_Prefix.Dock = DockStyle.Fill;
            l_Prefix.Location = new Point(3, 348);
            l_Prefix.Name = "l_Prefix";
            l_Prefix.Size = new Size(91, 27);
            l_Prefix.TabIndex = 3;
            l_Prefix.Text = "prefix:";
            l_Prefix.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_Suffix
            // 
            l_Suffix.AutoSize = true;
            l_Suffix.Dock = DockStyle.Fill;
            l_Suffix.Location = new Point(3, 375);
            l_Suffix.Name = "l_Suffix";
            l_Suffix.Size = new Size(91, 27);
            l_Suffix.TabIndex = 4;
            l_Suffix.Text = "suffix:";
            l_Suffix.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tB_Prefix
            // 
            tB_Prefix.Location = new Point(100, 351);
            tB_Prefix.Name = "tB_Prefix";
            tB_Prefix.Size = new Size(100, 21);
            tB_Prefix.TabIndex = 5;
            // 
            // tB_Suffix
            // 
            tB_Suffix.Location = new Point(100, 378);
            tB_Suffix.Name = "tB_Suffix";
            tB_Suffix.Size = new Size(100, 21);
            tB_Suffix.TabIndex = 6;
            // 
            // b_Start
            // 
            b_Start.Location = new Point(396, 432);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(75, 21);
            b_Start.TabIndex = 7;
            b_Start.Text = "start";
            b_Start.UseVisualStyleBackColor = true;
            b_Start.Click += Start_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 402);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 8;
            label2.Text = "new width:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nUD_ImageWidth
            // 
            nUD_ImageWidth.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nUD_ImageWidth.Location = new Point(100, 405);
            nUD_ImageWidth.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nUD_ImageWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUD_ImageWidth.Name = "nUD_ImageWidth";
            nUD_ImageWidth.Size = new Size(120, 21);
            nUD_ImageWidth.TabIndex = 9;
            nUD_ImageWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // UC_ImageResize
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_ImageResize";
            Size = new Size(478, 456);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_ImageWidth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private RichTextBox rTB_FileList;
        private Button b_FilesFromDialog;
        private Button b_FilesFromDirectory;
        private Button b_FilesFromClipboard;
        private RadioButton rB_UseSameFileNames;
        private RadioButton rB_CreateNewFileNames;
        private Label l_Prefix;
        private Label l_Suffix;
        private TextBox tB_Prefix;
        private TextBox tB_Suffix;
        private Button b_Start;
        private Label label2;
        private NumericUpDown nUD_ImageWidth;
    }
}
