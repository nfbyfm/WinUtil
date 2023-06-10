namespace WinUtil.UI.Frames
{
    partial class UC_DirectoryInfo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            tB_Directory = new TextBox();
            b_SelectDirectory = new Button();
            groupBox1 = new GroupBox();
            tV_DirectoryStrucutre = new TreeView();
            groupBox2 = new GroupBox();
            chartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 0;
            label1.Text = "Directory:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_Directory
            // 
            tB_Directory.Dock = DockStyle.Fill;
            tB_Directory.Location = new Point(103, 3);
            tB_Directory.Name = "tB_Directory";
            tB_Directory.Size = new Size(614, 21);
            tB_Directory.TabIndex = 1;
            tB_Directory.TextChanged += Directory_TextChanged;
            // 
            // b_SelectDirectory
            // 
            b_SelectDirectory.Dock = DockStyle.Fill;
            b_SelectDirectory.Location = new Point(723, 3);
            b_SelectDirectory.Name = "b_SelectDirectory";
            b_SelectDirectory.Size = new Size(94, 24);
            b_SelectDirectory.TabIndex = 2;
            b_SelectDirectory.Text = "select";
            b_SelectDirectory.UseVisualStyleBackColor = true;
            b_SelectDirectory.Click += SelectDirectory_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tV_DirectoryStrucutre);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 523);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Directory structure";
            // 
            // tV_DirectoryStrucutre
            // 
            tV_DirectoryStrucutre.Dock = DockStyle.Fill;
            tV_DirectoryStrucutre.Location = new Point(3, 17);
            tV_DirectoryStrucutre.Name = "tV_DirectoryStrucutre";
            tV_DirectoryStrucutre.Size = new Size(207, 503);
            tV_DirectoryStrucutre.TabIndex = 0;
            tV_DirectoryStrucutre.AfterSelect += tV_DirectoryStrucutre_AfterSelect;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chartView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(597, 523);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Directory contents";
            // 
            // chartView
            // 
            chartArea1.Name = "ChartArea1";
            chartView.ChartAreas.Add(chartArea1);
            chartView.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartView.Legends.Add(legend1);
            chartView.Location = new Point(3, 17);
            chartView.Name = "chartView";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartView.Series.Add(series1);
            chartView.Size = new Size(591, 503);
            chartView.TabIndex = 0;
            chartView.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tB_Directory, 1, 0);
            tableLayoutPanel1.Controls.Add(b_SelectDirectory, 2, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(820, 559);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            tableLayoutPanel1.SetColumnSpan(splitContainer1, 3);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(814, 523);
            splitContainer1.SplitterDistance = 213;
            splitContainer1.TabIndex = 3;
            // 
            // UC_DirectoryInfo
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_DirectoryInfo";
            Size = new Size(820, 559);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tB_Directory;
        private Button b_SelectDirectory;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TreeView tV_DirectoryStrucutre;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartView;
    }
}
