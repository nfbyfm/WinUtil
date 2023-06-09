namespace WinUtil.UI.Dialogs
{
    partial class FilesFromDirectoryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesFromDirectoryDialog));
            tB_FileExtensionFilter = new TextBox();
            tB_SourceDirectory = new TextBox();
            b_SelectSource = new Button();
            cB_FilterFiles = new CheckBox();
            cB_IncludeSubdirectories = new CheckBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            b_OK = new Button();
            b_Cancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tB_FileExtensionFilter
            // 
            tB_FileExtensionFilter.Location = new Point(153, 63);
            tB_FileExtensionFilter.Name = "tB_FileExtensionFilter";
            tB_FileExtensionFilter.Size = new Size(100, 21);
            tB_FileExtensionFilter.TabIndex = 22;
            tB_FileExtensionFilter.Text = "*.*";
            tB_FileExtensionFilter.TextChanged += CheckCurrentInputValues;
            // 
            // tB_SourceDirectory
            // 
            tableLayoutPanel1.SetColumnSpan(tB_SourceDirectory, 3);
            tB_SourceDirectory.Dock = DockStyle.Fill;
            tB_SourceDirectory.Location = new Point(100, 3);
            tB_SourceDirectory.Name = "tB_SourceDirectory";
            tB_SourceDirectory.Size = new Size(428, 21);
            tB_SourceDirectory.TabIndex = 21;
            tB_SourceDirectory.TextChanged += CheckCurrentInputValues;
            // 
            // b_SelectSource
            // 
            b_SelectSource.Dock = DockStyle.Fill;
            b_SelectSource.Location = new Point(534, 3);
            b_SelectSource.Name = "b_SelectSource";
            b_SelectSource.Size = new Size(74, 24);
            b_SelectSource.TabIndex = 20;
            b_SelectSource.Text = "select";
            b_SelectSource.UseVisualStyleBackColor = true;
            b_SelectSource.Click += SelectSource_Click;
            // 
            // cB_FilterFiles
            // 
            cB_FilterFiles.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cB_FilterFiles, 2);
            cB_FilterFiles.Dock = DockStyle.Fill;
            cB_FilterFiles.Location = new Point(23, 63);
            cB_FilterFiles.Name = "cB_FilterFiles";
            cB_FilterFiles.Size = new Size(124, 24);
            cB_FilterFiles.TabIndex = 19;
            cB_FilterFiles.Text = "filter files by extension:";
            cB_FilterFiles.UseVisualStyleBackColor = true;
            cB_FilterFiles.CheckedChanged += CheckCurrentInputValues;
            // 
            // cB_IncludeSubdirectories
            // 
            cB_IncludeSubdirectories.AutoSize = true;
            cB_IncludeSubdirectories.Checked = true;
            cB_IncludeSubdirectories.CheckState = CheckState.Checked;
            tableLayoutPanel1.SetColumnSpan(cB_IncludeSubdirectories, 3);
            cB_IncludeSubdirectories.Dock = DockStyle.Fill;
            cB_IncludeSubdirectories.Location = new Point(23, 33);
            cB_IncludeSubdirectories.Name = "cB_IncludeSubdirectories";
            cB_IncludeSubdirectories.Size = new Size(425, 24);
            cB_IncludeSubdirectories.TabIndex = 18;
            cB_IncludeSubdirectories.Text = "include subdirectories";
            cB_IncludeSubdirectories.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 17;
            label1.Text = "Source directory:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tB_SourceDirectory, 2, 0);
            tableLayoutPanel1.Controls.Add(cB_FilterFiles, 1, 2);
            tableLayoutPanel1.Controls.Add(cB_IncludeSubdirectories, 1, 1);
            tableLayoutPanel1.Controls.Add(tB_FileExtensionFilter, 3, 2);
            tableLayoutPanel1.Controls.Add(b_SelectSource, 5, 0);
            tableLayoutPanel1.Controls.Add(b_OK, 4, 4);
            tableLayoutPanel1.Controls.Add(b_Cancel, 5, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(611, 136);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // b_OK
            // 
            b_OK.Dock = DockStyle.Fill;
            b_OK.Location = new Point(454, 109);
            b_OK.Name = "b_OK";
            b_OK.Size = new Size(74, 24);
            b_OK.TabIndex = 23;
            b_OK.Text = "OK";
            b_OK.UseVisualStyleBackColor = true;
            b_OK.Click += OK_Click;
            // 
            // b_Cancel
            // 
            b_Cancel.Dock = DockStyle.Fill;
            b_Cancel.Location = new Point(534, 109);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(74, 24);
            b_Cancel.TabIndex = 24;
            b_Cancel.Text = "Cancel";
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Click += Cancel_Click;
            // 
            // FilesFromDirectoryDialog
            // 
            AcceptButton = b_OK;
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_Cancel;
            ClientSize = new Size(611, 136);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilesFromDirectoryDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select files from directory";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tB_FileExtensionFilter;
        private TextBox tB_SourceDirectory;
        private Button b_SelectSource;
        private CheckBox cB_FilterFiles;
        private CheckBox cB_IncludeSubdirectories;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button b_OK;
        private Button b_Cancel;
    }
}