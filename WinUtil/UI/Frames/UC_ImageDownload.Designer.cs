namespace WinUtil.UI.Frames
{
    partial class UC_ImageDownload
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tB_UrlPrefix = new TextBox();
            nUD_StartNumber = new NumericUpDown();
            nUD_EndNumber = new NumericUpDown();
            TB_UrlSuffix = new TextBox();
            tB_DownloadDirectory = new TextBox();
            b_SelectDirectory = new Button();
            b_Start = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nUD_StartNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_EndNumber).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 0;
            label1.Text = "URL prefix:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(8, 29);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 1;
            label2.Text = "Start number:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(8, 53);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 2;
            label3.Text = "End number:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(8, 77);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 3;
            label4.Text = "URL suffix:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(8, 101);
            label5.Name = "label5";
            label5.Size = new Size(104, 26);
            label5.TabIndex = 4;
            label5.Text = "Download directory:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_UrlPrefix
            // 
            tB_UrlPrefix.Dock = DockStyle.Fill;
            tB_UrlPrefix.Location = new Point(118, 8);
            tB_UrlPrefix.Name = "tB_UrlPrefix";
            tB_UrlPrefix.Size = new Size(234, 21);
            tB_UrlPrefix.TabIndex = 5;
            // 
            // nUD_StartNumber
            // 
            nUD_StartNumber.Location = new Point(118, 32);
            nUD_StartNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nUD_StartNumber.Name = "nUD_StartNumber";
            nUD_StartNumber.Size = new Size(120, 21);
            nUD_StartNumber.TabIndex = 6;
            // 
            // nUD_EndNumber
            // 
            nUD_EndNumber.Location = new Point(118, 56);
            nUD_EndNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUD_EndNumber.Name = "nUD_EndNumber";
            nUD_EndNumber.Size = new Size(120, 21);
            nUD_EndNumber.TabIndex = 7;
            // 
            // TB_UrlSuffix
            // 
            TB_UrlSuffix.Dock = DockStyle.Fill;
            TB_UrlSuffix.Location = new Point(118, 80);
            TB_UrlSuffix.Name = "TB_UrlSuffix";
            TB_UrlSuffix.Size = new Size(234, 21);
            TB_UrlSuffix.TabIndex = 8;
            // 
            // tB_DownloadDirectory
            // 
            tB_DownloadDirectory.Dock = DockStyle.Fill;
            tB_DownloadDirectory.Location = new Point(118, 104);
            tB_DownloadDirectory.Name = "tB_DownloadDirectory";
            tB_DownloadDirectory.Size = new Size(234, 21);
            tB_DownloadDirectory.TabIndex = 9;
            // 
            // b_SelectDirectory
            // 
            b_SelectDirectory.Location = new Point(358, 104);
            b_SelectDirectory.Name = "b_SelectDirectory";
            b_SelectDirectory.Size = new Size(75, 20);
            b_SelectDirectory.TabIndex = 10;
            b_SelectDirectory.Text = "select";
            b_SelectDirectory.UseVisualStyleBackColor = true;
            b_SelectDirectory.Click += SelectDirectory_Click;
            // 
            // b_Start
            // 
            b_Start.Location = new Point(8, 154);
            b_Start.Name = "b_Start";
            b_Start.Size = new Size(75, 23);
            b_Start.TabIndex = 11;
            b_Start.Text = "Start";
            b_Start.UseVisualStyleBackColor = true;
            b_Start.Click += Start_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(b_Start, 1, 7);
            tableLayoutPanel1.Controls.Add(tB_UrlPrefix, 3, 1);
            tableLayoutPanel1.Controls.Add(b_SelectDirectory, 4, 5);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(tB_DownloadDirectory, 3, 5);
            tableLayoutPanel1.Controls.Add(nUD_StartNumber, 3, 2);
            tableLayoutPanel1.Controls.Add(label5, 1, 5);
            tableLayoutPanel1.Controls.Add(TB_UrlSuffix, 3, 4);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(nUD_EndNumber, 3, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1092, 493);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // UC_ImageDownload
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_ImageDownload";
            Size = new Size(1092, 493);
            ((System.ComponentModel.ISupportInitialize)nUD_StartNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_EndNumber).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tB_UrlPrefix;
        private NumericUpDown nUD_StartNumber;
        private NumericUpDown nUD_EndNumber;
        private TextBox TB_UrlSuffix;
        private TextBox tB_DownloadDirectory;
        private Button b_SelectDirectory;
        private Button b_Start;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
