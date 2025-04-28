namespace WinUtil.UI.Frames
{
  partial class UC_BskySort
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.tB_DirectoryPath = new System.Windows.Forms.TextBox();
      this.b_SelectDirectory = new System.Windows.Forms.Button();
      this.tV_SortedFiles = new System.Windows.Forms.TreeView();
      this.b_Update = new System.Windows.Forms.Button();
      this.b_ExecuteSort = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.nUD_FilesPerDirectory = new System.Windows.Forms.NumericUpDown();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      ((System.ComponentModel.ISupportInitialize)(this.nUD_FilesPerDirectory)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 34);
      this.label1.TabIndex = 0;
      this.label1.Text = "directory:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tB_DirectoryPath
      // 
      this.tB_DirectoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tB_DirectoryPath.Location = new System.Drawing.Point(83, 3);
      this.tB_DirectoryPath.Name = "tB_DirectoryPath";
      this.tB_DirectoryPath.Size = new System.Drawing.Size(550, 23);
      this.tB_DirectoryPath.TabIndex = 1;
      // 
      // b_SelectDirectory
      // 
      this.b_SelectDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b_SelectDirectory.Location = new System.Drawing.Point(639, 3);
      this.b_SelectDirectory.Name = "b_SelectDirectory";
      this.b_SelectDirectory.Size = new System.Drawing.Size(94, 28);
      this.b_SelectDirectory.TabIndex = 2;
      this.b_SelectDirectory.Text = "select";
      this.b_SelectDirectory.UseVisualStyleBackColor = true;
      this.b_SelectDirectory.Click += new System.EventHandler(this.b_SelectDirectory_Click);
      // 
      // tV_SortedFiles
      // 
      this.tV_SortedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tV_SortedFiles.Location = new System.Drawing.Point(0, 0);
      this.tV_SortedFiles.Name = "tV_SortedFiles";
      this.tV_SortedFiles.Size = new System.Drawing.Size(245, 499);
      this.tV_SortedFiles.TabIndex = 3;
      // 
      // b_Update
      // 
      this.b_Update.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b_Update.Location = new System.Drawing.Point(360, 442);
      this.b_Update.Name = "b_Update";
      this.b_Update.Size = new System.Drawing.Size(124, 24);
      this.b_Update.TabIndex = 4;
      this.b_Update.Text = "update sorting";
      this.b_Update.UseVisualStyleBackColor = true;
      this.b_Update.Click += new System.EventHandler(this.Update_Click);
      // 
      // b_ExecuteSort
      // 
      this.b_ExecuteSort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.b_ExecuteSort.Location = new System.Drawing.Point(360, 472);
      this.b_ExecuteSort.Name = "b_ExecuteSort";
      this.b_ExecuteSort.Size = new System.Drawing.Size(124, 24);
      this.b_ExecuteSort.TabIndex = 5;
      this.b_ExecuteSort.Text = "execute sort";
      this.b_ExecuteSort.UseVisualStyleBackColor = true;
      this.b_ExecuteSort.Click += new System.EventHandler(this.ExecuteSort_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(3, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(351, 27);
      this.label2.TabIndex = 6;
      this.label2.Text = "minimal number of files per directory:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // nUD_FilesPerDirectory
      // 
      this.nUD_FilesPerDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.nUD_FilesPerDirectory.Location = new System.Drawing.Point(360, 3);
      this.nUD_FilesPerDirectory.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.nUD_FilesPerDirectory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nUD_FilesPerDirectory.Name = "nUD_FilesPerDirectory";
      this.nUD_FilesPerDirectory.Size = new System.Drawing.Size(124, 23);
      this.nUD_FilesPerDirectory.TabIndex = 7;
      this.nUD_FilesPerDirectory.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.Controls.Add(this.b_SelectDirectory, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.tB_DirectoryPath, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 34);
      this.tableLayoutPanel1.TabIndex = 8;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.splitContainer1, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(742, 545);
      this.tableLayoutPanel2.TabIndex = 9;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 43);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tV_SortedFiles);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
      this.splitContainer1.Size = new System.Drawing.Size(736, 499);
      this.splitContainer1.SplitterDistance = 245;
      this.splitContainer1.TabIndex = 0;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.b_ExecuteSort, 1, 4);
      this.tableLayoutPanel3.Controls.Add(this.b_Update, 1, 3);
      this.tableLayoutPanel3.Controls.Add(this.nUD_FilesPerDirectory, 1, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 5;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(487, 499);
      this.tableLayoutPanel3.TabIndex = 10;
      // 
      // UC_BskySort
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel2);
      this.Name = "UC_BskySort";
      this.Size = new System.Drawing.Size(742, 545);
      ((System.ComponentModel.ISupportInitialize)(this.nUD_FilesPerDirectory)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private Label label1;
        private TextBox tB_DirectoryPath;
        private Button b_SelectDirectory;
        private TreeView tV_SortedFiles;
        private Button b_Update;
        private Button b_ExecuteSort;
        private Label label2;
        private NumericUpDown nUD_FilesPerDirectory;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
