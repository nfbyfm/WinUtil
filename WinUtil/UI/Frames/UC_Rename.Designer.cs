﻿namespace WinUtil.UI.Frames
{
    partial class UC_Rename
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
            tB_TragetDirectory = new TextBox();
            b_Select = new Button();
            groupBox1 = new GroupBox();
            lV_Files = new ListView();
            tB_ExtensionFilter = new TextBox();
            cB_ReplaceText = new CheckBox();
            l_ReplaceSearchText = new Label();
            l_ReplaceReplacement = new Label();
            cB_RemoveText = new CheckBox();
            l_RemoveText = new Label();
            tB_ReplaceSearchText = new TextBox();
            tB_ReplaceReplacementText = new TextBox();
            tB_RemovalText = new TextBox();
            b_Start = new Button();
            cB_DirectoryRecursive = new CheckBox();
            cB_FileFilter = new CheckBox();
            l_FilterExtension = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 26);
            label1.TabIndex = 0;
            label1.Text = "Directory:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_TragetDirectory
            // 
            tB_TragetDirectory.Dock = DockStyle.Fill;
            tB_TragetDirectory.Location = new Point(67, 3);
            tB_TragetDirectory.Name = "tB_TragetDirectory";
            tB_TragetDirectory.Size = new Size(863, 21);
            tB_TragetDirectory.TabIndex = 1;
            tB_TragetDirectory.TextChanged += UpdateFileList;
            // 
            // b_Select
            // 
            b_Select.Location = new Point(936, 3);
            b_Select.Name = "b_Select";
            b_Select.Size = new Size(69, 20);
            b_Select.TabIndex = 2;
            b_Select.Text = "select";
            b_Select.UseVisualStyleBackColor = true;
            b_Select.Click += Select_Click;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(lV_Files);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 260);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of files";
            // 
            // lV_Files
            // 
            lV_Files.Dock = DockStyle.Fill;
            lV_Files.Location = new Point(3, 17);
            lV_Files.Name = "lV_Files";
            lV_Files.Size = new Size(1002, 240);
            lV_Files.TabIndex = 0;
            lV_Files.UseCompatibleStateImageBehavior = false;
            lV_Files.View = View.List;
            // 
            // tB_ExtensionFilter
            // 
            tB_ExtensionFilter.Dock = DockStyle.Fill;
            tB_ExtensionFilter.Enabled = false;
            tB_ExtensionFilter.Location = new Point(123, 355);
            tB_ExtensionFilter.Name = "tB_ExtensionFilter";
            tB_ExtensionFilter.Size = new Size(194, 21);
            tB_ExtensionFilter.TabIndex = 6;
            tB_ExtensionFilter.Text = "*.*";
            tB_ExtensionFilter.TextChanged += UpdateFileList;
            // 
            // cB_ReplaceText
            // 
            cB_ReplaceText.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cB_ReplaceText, 2);
            cB_ReplaceText.Dock = DockStyle.Fill;
            cB_ReplaceText.Location = new Point(3, 387);
            cB_ReplaceText.Name = "cB_ReplaceText";
            cB_ReplaceText.Size = new Size(114, 21);
            cB_ReplaceText.TabIndex = 7;
            cB_ReplaceText.Text = "replace text";
            cB_ReplaceText.UseVisualStyleBackColor = true;
            cB_ReplaceText.CheckedChanged += OperationOptionsChanged;
            // 
            // l_ReplaceSearchText
            // 
            l_ReplaceSearchText.AutoSize = true;
            l_ReplaceSearchText.Dock = DockStyle.Fill;
            l_ReplaceSearchText.Enabled = false;
            l_ReplaceSearchText.Location = new Point(23, 411);
            l_ReplaceSearchText.Name = "l_ReplaceSearchText";
            l_ReplaceSearchText.Size = new Size(94, 27);
            l_ReplaceSearchText.TabIndex = 8;
            l_ReplaceSearchText.Text = "Search text:";
            l_ReplaceSearchText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_ReplaceReplacement
            // 
            l_ReplaceReplacement.AutoSize = true;
            l_ReplaceReplacement.Dock = DockStyle.Fill;
            l_ReplaceReplacement.Enabled = false;
            l_ReplaceReplacement.Location = new Point(23, 438);
            l_ReplaceReplacement.Name = "l_ReplaceReplacement";
            l_ReplaceReplacement.Size = new Size(94, 27);
            l_ReplaceReplacement.TabIndex = 9;
            l_ReplaceReplacement.Text = "Replacement:";
            l_ReplaceReplacement.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cB_RemoveText
            // 
            cB_RemoveText.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cB_RemoveText, 2);
            cB_RemoveText.Dock = DockStyle.Fill;
            cB_RemoveText.Location = new Point(3, 473);
            cB_RemoveText.Name = "cB_RemoveText";
            cB_RemoveText.Size = new Size(114, 21);
            cB_RemoveText.TabIndex = 10;
            cB_RemoveText.Text = "remove text";
            cB_RemoveText.UseVisualStyleBackColor = true;
            cB_RemoveText.CheckedChanged += OperationOptionsChanged;
            // 
            // l_RemoveText
            // 
            l_RemoveText.AutoSize = true;
            l_RemoveText.Dock = DockStyle.Fill;
            l_RemoveText.Enabled = false;
            l_RemoveText.Location = new Point(23, 497);
            l_RemoveText.Name = "l_RemoveText";
            l_RemoveText.Size = new Size(94, 27);
            l_RemoveText.TabIndex = 11;
            l_RemoveText.Text = "Text to remove:";
            l_RemoveText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_ReplaceSearchText
            // 
            tB_ReplaceSearchText.Dock = DockStyle.Fill;
            tB_ReplaceSearchText.Enabled = false;
            tB_ReplaceSearchText.Location = new Point(123, 414);
            tB_ReplaceSearchText.Name = "tB_ReplaceSearchText";
            tB_ReplaceSearchText.Size = new Size(194, 21);
            tB_ReplaceSearchText.TabIndex = 12;
            // 
            // tB_ReplaceReplacementText
            // 
            tB_ReplaceReplacementText.Dock = DockStyle.Fill;
            tB_ReplaceReplacementText.Enabled = false;
            tB_ReplaceReplacementText.Location = new Point(123, 441);
            tB_ReplaceReplacementText.Name = "tB_ReplaceReplacementText";
            tB_ReplaceReplacementText.Size = new Size(194, 21);
            tB_ReplaceReplacementText.TabIndex = 13;
            // 
            // tB_RemovalText
            // 
            tB_RemovalText.Dock = DockStyle.Fill;
            tB_RemovalText.Enabled = false;
            tB_RemovalText.Location = new Point(123, 500);
            tB_RemovalText.Name = "tB_RemovalText";
            tB_RemovalText.Size = new Size(194, 21);
            tB_RemovalText.TabIndex = 14;
            // 
            // b_Start
            // 
            tableLayoutPanel1.SetColumnSpan(b_Start, 2);
            b_Start.Location = new Point(3, 537);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(75, 21);
            b_Start.TabIndex = 15;
            b_Start.Text = "Start";
            b_Start.UseVisualStyleBackColor = true;
            b_Start.Click += Start_Click;
            // 
            // cB_DirectoryRecursive
            // 
            cB_DirectoryRecursive.AutoSize = true;
            cB_DirectoryRecursive.Checked = true;
            cB_DirectoryRecursive.CheckState = CheckState.Checked;
            tableLayoutPanel1.SetColumnSpan(cB_DirectoryRecursive, 2);
            cB_DirectoryRecursive.Dock = DockStyle.Fill;
            cB_DirectoryRecursive.Location = new Point(23, 35);
            cB_DirectoryRecursive.Name = "cB_DirectoryRecursive";
            cB_DirectoryRecursive.Size = new Size(294, 21);
            cB_DirectoryRecursive.TabIndex = 16;
            cB_DirectoryRecursive.Text = "include sub directories";
            cB_DirectoryRecursive.UseVisualStyleBackColor = true;
            cB_DirectoryRecursive.CheckedChanged += UpdateFileList;
            // 
            // cB_FileFilter
            // 
            cB_FileFilter.AutoSize = true;
            cB_FileFilter.Checked = true;
            cB_FileFilter.CheckState = CheckState.Checked;
            tableLayoutPanel1.SetColumnSpan(cB_FileFilter, 3);
            cB_FileFilter.Dock = DockStyle.Fill;
            cB_FileFilter.Location = new Point(3, 328);
            cB_FileFilter.Name = "cB_FileFilter";
            cB_FileFilter.Size = new Size(314, 21);
            cB_FileFilter.TabIndex = 17;
            cB_FileFilter.Text = "rename all files";
            cB_FileFilter.UseVisualStyleBackColor = true;
            cB_FileFilter.CheckedChanged += FileFilter_CheckedChanged;
            // 
            // l_FilterExtension
            // 
            l_FilterExtension.AutoSize = true;
            l_FilterExtension.Dock = DockStyle.Fill;
            l_FilterExtension.Enabled = false;
            l_FilterExtension.Location = new Point(23, 352);
            l_FilterExtension.Name = "l_FilterExtension";
            l_FilterExtension.Size = new Size(94, 27);
            l_FilterExtension.TabIndex = 18;
            l_FilterExtension.Text = "rename files with extension";
            l_FilterExtension.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(l_FilterExtension, 1, 4);
            tableLayoutPanel1.Controls.Add(tB_RemovalText, 2, 11);
            tableLayoutPanel1.Controls.Add(cB_DirectoryRecursive, 1, 1);
            tableLayoutPanel1.Controls.Add(l_RemoveText, 1, 11);
            tableLayoutPanel1.Controls.Add(tB_ReplaceReplacementText, 2, 8);
            tableLayoutPanel1.Controls.Add(cB_RemoveText, 0, 10);
            tableLayoutPanel1.Controls.Add(cB_FileFilter, 0, 3);
            tableLayoutPanel1.Controls.Add(tB_ReplaceSearchText, 2, 7);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(l_ReplaceReplacement, 1, 8);
            tableLayoutPanel1.Controls.Add(tB_ExtensionFilter, 2, 4);
            tableLayoutPanel1.Controls.Add(cB_ReplaceText, 0, 6);
            tableLayoutPanel1.Controls.Add(l_ReplaceSearchText, 1, 7);
            tableLayoutPanel1.Controls.Add(b_Start, 0, 13);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1014, 561);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tB_TragetDirectory, 1, 0);
            tableLayoutPanel2.Controls.Add(b_Select, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1008, 26);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // UC_Rename
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Rename";
            Size = new Size(1014, 561);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tB_TragetDirectory;
        private Button b_Select;
        private GroupBox groupBox1;
        private ListView lV_Files;
        private TextBox tB_ExtensionFilter;
        private CheckBox cB_ReplaceText;
        private Label l_ReplaceSearchText;
        private Label l_ReplaceReplacement;
        private CheckBox cB_RemoveText;
        private Label l_RemoveText;
        private TextBox tB_ReplaceSearchText;
        private TextBox tB_ReplaceReplacementText;
        private TextBox tB_RemovalText;
        private Button b_Start;
        private CheckBox cB_DirectoryRecursive;
        private CheckBox cB_FileFilter;
        private Label l_FilterExtension;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
