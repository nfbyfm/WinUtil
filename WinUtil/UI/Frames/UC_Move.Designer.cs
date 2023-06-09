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
            label2 = new Label();
            cB_DeleteEmptyDirecories = new CheckBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rTB_FileList = new RichTextBox();
            label1 = new Label();
            b_FileListFromDirectory = new Button();
            b_FileListFromFileDialog = new Button();
            b_FileListFromFile = new Button();
            b_FileListFromClipboard = new Button();
            b_SelectTarget = new Button();
            b_Start = new Button();
            tB_TargetDirectory = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 461);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 1;
            label2.Text = "Target directory:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cB_DeleteEmptyDirecories
            // 
            cB_DeleteEmptyDirecories.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(cB_DeleteEmptyDirecories, 2);
            cB_DeleteEmptyDirecories.Dock = DockStyle.Fill;
            cB_DeleteEmptyDirecories.Location = new Point(13, 494);
            cB_DeleteEmptyDirecories.Name = "cB_DeleteEmptyDirecories";
            cB_DeleteEmptyDirecories.Size = new Size(455, 24);
            cB_DeleteEmptyDirecories.TabIndex = 3;
            cB_DeleteEmptyDirecories.Text = "delete empty directories afterwards";
            cB_DeleteEmptyDirecories.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 455);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "files to move";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.Controls.Add(rTB_FileList, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(b_FileListFromDirectory, 1, 2);
            tableLayoutPanel1.Controls.Add(b_FileListFromFileDialog, 1, 1);
            tableLayoutPanel1.Controls.Add(b_FileListFromFile, 1, 3);
            tableLayoutPanel1.Controls.Add(b_FileListFromClipboard, 1, 4);
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
            tableLayoutPanel1.Size = new Size(574, 435);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rTB_FileList
            // 
            rTB_FileList.Dock = DockStyle.Fill;
            rTB_FileList.Location = new Point(3, 3);
            rTB_FileList.Name = "rTB_FileList";
            tableLayoutPanel1.SetRowSpan(rTB_FileList, 6);
            rTB_FileList.Size = new Size(458, 429);
            rTB_FileList.TabIndex = 0;
            rTB_FileList.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(467, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 27);
            label1.TabIndex = 4;
            label1.Text = "add file paths:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_FileListFromDirectory
            // 
            b_FileListFromDirectory.Dock = DockStyle.Fill;
            b_FileListFromDirectory.Location = new Point(467, 60);
            b_FileListFromDirectory.Name = "b_FileListFromDirectory";
            b_FileListFromDirectory.Size = new Size(104, 24);
            b_FileListFromDirectory.TabIndex = 3;
            b_FileListFromDirectory.Text = "from directory";
            b_FileListFromDirectory.UseVisualStyleBackColor = true;
            b_FileListFromDirectory.Click += FileListFromDirectory_Click;
            // 
            // b_FileListFromFileDialog
            // 
            b_FileListFromFileDialog.Dock = DockStyle.Fill;
            b_FileListFromFileDialog.Location = new Point(467, 30);
            b_FileListFromFileDialog.Name = "b_FileListFromFileDialog";
            b_FileListFromFileDialog.Size = new Size(104, 24);
            b_FileListFromFileDialog.TabIndex = 5;
            b_FileListFromFileDialog.Text = "via file dialog";
            b_FileListFromFileDialog.UseVisualStyleBackColor = true;
            b_FileListFromFileDialog.Click += FileListFromFileDialog_Click;
            // 
            // b_FileListFromFile
            // 
            b_FileListFromFile.Dock = DockStyle.Fill;
            b_FileListFromFile.Location = new Point(467, 90);
            b_FileListFromFile.Name = "b_FileListFromFile";
            b_FileListFromFile.Size = new Size(104, 24);
            b_FileListFromFile.TabIndex = 1;
            b_FileListFromFile.Text = "from text file";
            b_FileListFromFile.UseVisualStyleBackColor = true;
            b_FileListFromFile.Click += FileListFromFile_Click;
            // 
            // b_FileListFromClipboard
            // 
            b_FileListFromClipboard.Dock = DockStyle.Fill;
            b_FileListFromClipboard.Location = new Point(467, 120);
            b_FileListFromClipboard.Name = "b_FileListFromClipboard";
            b_FileListFromClipboard.Size = new Size(104, 24);
            b_FileListFromClipboard.TabIndex = 2;
            b_FileListFromClipboard.Text = "from clipboard";
            b_FileListFromClipboard.UseVisualStyleBackColor = true;
            b_FileListFromClipboard.Click += FileListFromClipboard_Click;
            // 
            // b_SelectTarget
            // 
            b_SelectTarget.Dock = DockStyle.Fill;
            b_SelectTarget.Location = new Point(474, 464);
            b_SelectTarget.Name = "b_SelectTarget";
            b_SelectTarget.Size = new Size(109, 24);
            b_SelectTarget.TabIndex = 7;
            b_SelectTarget.Text = "select";
            b_SelectTarget.UseVisualStyleBackColor = true;
            b_SelectTarget.Click += SelectTargetDirectory_Click;
            // 
            // b_Start
            // 
            tableLayoutPanel2.SetColumnSpan(b_Start, 2);
            b_Start.Location = new Point(3, 524);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(75, 23);
            b_Start.TabIndex = 8;
            b_Start.Text = "Start";
            b_Start.UseVisualStyleBackColor = true;
            b_Start.Click += Start_Click;
            // 
            // tB_TargetDirectory
            // 
            tB_TargetDirectory.Dock = DockStyle.Fill;
            tB_TargetDirectory.Location = new Point(98, 464);
            tB_TargetDirectory.Name = "tB_TargetDirectory";
            tB_TargetDirectory.Size = new Size(370, 21);
            tB_TargetDirectory.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutPanel2.Controls.Add(cB_DeleteEmptyDirecories, 1, 2);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(tB_TargetDirectory, 2, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(b_Start, 0, 3);
            tableLayoutPanel2.Controls.Add(b_SelectTarget, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(586, 551);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // UC_Move
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "UC_Move";
            Size = new Size(586, 551);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private CheckBox cB_DeleteEmptyDirecories;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox rTB_FileList;
        private Button b_FileListFromFile;
        private Button b_FileListFromClipboard;
        private Button b_SelectTarget;
        private Button b_Start;
        private TextBox tB_TargetDirectory;
        private Button b_FileListFromDirectory;
        private Label label1;
        private Button b_FileListFromFileDialog;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
