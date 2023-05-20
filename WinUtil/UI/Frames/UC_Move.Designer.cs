namespace WinUtil.UI.Frames
{
    partial class UC_Move
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
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rTB_FileList = new RichTextBox();
            b_FileListFromFile = new Button();
            b_FileListFromClipboard = new Button();
            b_SelectSource = new Button();
            b_SelectTarget = new Button();
            b_Start = new Button();
            tB_SourceDirectory = new TextBox();
            tB_FileExtensionFilter = new TextBox();
            tB_TargetDirectory = new TextBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 12);
            label1.TabIndex = 0;
            label1.Text = "Source directory:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 258);
            label2.Name = "label2";
            label2.Size = new Size(75, 12);
            label2.TabIndex = 1;
            label2.Text = "Target directory:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(55, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 16);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "include subdirectories";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(17, 293);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(175, 16);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "delete empty directories afterwards";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(18, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 139);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "files to move";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(55, 69);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(122, 16);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "filter files by extension:";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.Controls.Add(rTB_FileList, 0, 0);
            tableLayoutPanel1.Controls.Add(b_FileListFromFile, 1, 1);
            tableLayoutPanel1.Controls.Add(b_FileListFromClipboard, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(329, 119);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rTB_FileList
            // 
            tableLayoutPanel1.SetColumnSpan(rTB_FileList, 3);
            rTB_FileList.Dock = DockStyle.Fill;
            rTB_FileList.Location = new Point(3, 3);
            rTB_FileList.Name = "rTB_FileList";
            rTB_FileList.Size = new Size(323, 86);
            rTB_FileList.TabIndex = 0;
            rTB_FileList.Text = "";
            // 
            // b_FileListFromFile
            // 
            b_FileListFromFile.Dock = DockStyle.Fill;
            b_FileListFromFile.Location = new Point(142, 95);
            b_FileListFromFile.Name = "b_FileListFromFile";
            b_FileListFromFile.Size = new Size(89, 21);
            b_FileListFromFile.TabIndex = 1;
            b_FileListFromFile.Text = "from file ...";
            b_FileListFromFile.UseVisualStyleBackColor = true;
            // 
            // b_FileListFromClipboard
            // 
            b_FileListFromClipboard.Dock = DockStyle.Fill;
            b_FileListFromClipboard.Location = new Point(237, 95);
            b_FileListFromClipboard.Name = "b_FileListFromClipboard";
            b_FileListFromClipboard.Size = new Size(89, 21);
            b_FileListFromClipboard.TabIndex = 2;
            b_FileListFromClipboard.Text = "from clipboard";
            b_FileListFromClipboard.UseVisualStyleBackColor = true;
            // 
            // b_SelectSource
            // 
            b_SelectSource.Location = new Point(342, 18);
            b_SelectSource.Name = "b_SelectSource";
            b_SelectSource.Size = new Size(75, 23);
            b_SelectSource.TabIndex = 6;
            b_SelectSource.Text = "select";
            b_SelectSource.UseVisualStyleBackColor = true;
            // 
            // b_SelectTarget
            // 
            b_SelectTarget.Location = new Point(339, 261);
            b_SelectTarget.Name = "b_SelectTarget";
            b_SelectTarget.Size = new Size(75, 23);
            b_SelectTarget.TabIndex = 7;
            b_SelectTarget.Text = "select";
            b_SelectTarget.UseVisualStyleBackColor = true;
            // 
            // b_Start
            // 
            b_Start.Location = new Point(26, 334);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(75, 23);
            b_Start.TabIndex = 8;
            b_Start.Text = "Start";
            b_Start.UseVisualStyleBackColor = true;
            // 
            // tB_SourceDirectory
            // 
            tB_SourceDirectory.Location = new Point(116, 14);
            tB_SourceDirectory.Name = "tB_SourceDirectory";
            tB_SourceDirectory.Size = new Size(217, 21);
            tB_SourceDirectory.TabIndex = 9;
            // 
            // tB_FileExtensionFilter
            // 
            tB_FileExtensionFilter.Location = new Point(196, 69);
            tB_FileExtensionFilter.Name = "tB_FileExtensionFilter";
            tB_FileExtensionFilter.Size = new Size(100, 21);
            tB_FileExtensionFilter.TabIndex = 10;
            // 
            // tB_TargetDirectory
            // 
            tB_TargetDirectory.Location = new Point(107, 258);
            tB_TargetDirectory.Name = "tB_TargetDirectory";
            tB_TargetDirectory.Size = new Size(206, 21);
            tB_TargetDirectory.TabIndex = 11;
            // 
            // UC_Move
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tB_TargetDirectory);
            Controls.Add(tB_FileExtensionFilter);
            Controls.Add(tB_SourceDirectory);
            Controls.Add(b_Start);
            Controls.Add(b_SelectTarget);
            Controls.Add(b_SelectSource);
            Controls.Add(checkBox3);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Move";
            Size = new Size(475, 360);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox rTB_FileList;
        private Button b_FileListFromFile;
        private Button b_FileListFromClipboard;
        private Button b_SelectSource;
        private Button b_SelectTarget;
        private Button b_Start;
        private TextBox tB_SourceDirectory;
        private TextBox tB_FileExtensionFilter;
        private TextBox tB_TargetDirectory;
    }
}
