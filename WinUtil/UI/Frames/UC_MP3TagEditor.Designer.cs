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
            tB_SourceDirectory = new TextBox();
            b_SelectSource = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rTB_FileList = new RichTextBox();
            b_FileListFromFile = new Button();
            b_FileListFromClipboard = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            b_Start = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tB_SourceDirectory
            // 
            tB_SourceDirectory.Location = new Point(102, 9);
            tB_SourceDirectory.Name = "tB_SourceDirectory";
            tB_SourceDirectory.Size = new Size(217, 21);
            tB_SourceDirectory.TabIndex = 14;
            // 
            // b_SelectSource
            // 
            b_SelectSource.Location = new Point(328, 13);
            b_SelectSource.Name = "b_SelectSource";
            b_SelectSource.Size = new Size(75, 23);
            b_SelectSource.TabIndex = 13;
            b_SelectSource.Text = "select";
            b_SelectSource.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 139);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "files to edit";
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 16);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "include subdirectories";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(78, 12);
            label2.TabIndex = 10;
            label2.Text = "Source directory:";
            // 
            // b_Start
            // 
            b_Start.Location = new Point(25, 398);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(75, 23);
            b_Start.TabIndex = 15;
            b_Start.Text = "Start";
            b_Start.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 234);
            label1.Name = "label1";
            label1.Size = new Size(28, 12);
            label1.TabIndex = 16;
            label1.Text = "Artist:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 255);
            label3.Name = "label3";
            label3.Size = new Size(36, 12);
            label3.TabIndex = 17;
            label3.Text = "Album:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 277);
            label4.Name = "label4";
            label4.Size = new Size(60, 12);
            label4.TabIndex = 18;
            label4.Text = "Release year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 303);
            label5.Name = "label5";
            label5.Size = new Size(62, 12);
            label5.TabIndex = 19;
            label5.Text = "Cover image:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(20, 332);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 16);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "set track number";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(55, 356);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(97, 16);
            checkBox3.TabIndex = 21;
            checkBox3.Text = "... from file name";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // UC_MP3TagEditor
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(b_Start);
            Controls.Add(tB_SourceDirectory);
            Controls.Add(b_SelectSource);
            Controls.Add(groupBox1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Name = "UC_MP3TagEditor";
            Size = new Size(639, 435);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tB_SourceDirectory;
        private Button b_SelectSource;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox rTB_FileList;
        private Button b_FileListFromFile;
        private Button b_FileListFromClipboard;
        private CheckBox checkBox1;
        private Label label2;
        private Button b_Start;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}
