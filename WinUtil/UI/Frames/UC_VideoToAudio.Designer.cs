namespace WinUtil.UI.Frames
{
    partial class UC_VideoToAudio
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
            tB_SourceFilePath = new TextBox();
            b_SelectSourceFile = new Button();
            label2 = new Label();
            tB_OutputFilePath = new TextBox();
            b_SetOutputFilePath = new Button();
            b_SetDefaultOutputFilePath = new Button();
            rB_ConvertWholeFile = new RadioButton();
            rB_ConvertSection = new RadioButton();
            l_StartTime = new Label();
            l_EndTime = new Label();
            mTB_StartTime = new MaskedTextBox();
            mTB_EndTime = new MaskedTextBox();
            b_Convert = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 27);
            label1.TabIndex = 0;
            label1.Text = "File to convert:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_SourceFilePath
            // 
            tB_SourceFilePath.Dock = DockStyle.Fill;
            tB_SourceFilePath.Location = new Point(104, 3);
            tB_SourceFilePath.Name = "tB_SourceFilePath";
            tB_SourceFilePath.Size = new Size(167, 21);
            tB_SourceFilePath.TabIndex = 1;
            tB_SourceFilePath.TextChanged += SetDefaultOutputFilePath;
            // 
            // b_SelectSourceFile
            // 
            b_SelectSourceFile.Location = new Point(277, 3);
            b_SelectSourceFile.Name = "b_SelectSourceFile";
            b_SelectSourceFile.Size = new Size(75, 21);
            b_SelectSourceFile.TabIndex = 2;
            b_SelectSourceFile.Text = "select";
            b_SelectSourceFile.UseVisualStyleBackColor = true;
            b_SelectSourceFile.Click += SelectSourceFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 3;
            label2.Text = "Path of output file:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_OutputFilePath
            // 
            tB_OutputFilePath.Dock = DockStyle.Fill;
            tB_OutputFilePath.Location = new Point(104, 30);
            tB_OutputFilePath.Name = "tB_OutputFilePath";
            tB_OutputFilePath.Size = new Size(167, 21);
            tB_OutputFilePath.TabIndex = 4;
            // 
            // b_SetOutputFilePath
            // 
            b_SetOutputFilePath.Location = new Point(277, 30);
            b_SetOutputFilePath.Name = "b_SetOutputFilePath";
            b_SetOutputFilePath.Size = new Size(75, 21);
            b_SetOutputFilePath.TabIndex = 5;
            b_SetOutputFilePath.Text = "select";
            b_SetOutputFilePath.UseVisualStyleBackColor = true;
            b_SetOutputFilePath.Click += SetOutputFilePath_Click;
            // 
            // b_SetDefaultOutputFilePath
            // 
            b_SetDefaultOutputFilePath.Location = new Point(362, 30);
            b_SetDefaultOutputFilePath.Name = "b_SetDefaultOutputFilePath";
            b_SetDefaultOutputFilePath.Size = new Size(75, 21);
            b_SetDefaultOutputFilePath.TabIndex = 6;
            b_SetDefaultOutputFilePath.Text = "default mp3";
            b_SetDefaultOutputFilePath.UseVisualStyleBackColor = true;
            b_SetDefaultOutputFilePath.Click += SetDefaultOutputFilePath;
            // 
            // rB_ConvertWholeFile
            // 
            rB_ConvertWholeFile.AutoSize = true;
            rB_ConvertWholeFile.Checked = true;
            tableLayoutPanel1.SetColumnSpan(rB_ConvertWholeFile, 3);
            rB_ConvertWholeFile.Dock = DockStyle.Fill;
            rB_ConvertWholeFile.Location = new Point(3, 62);
            rB_ConvertWholeFile.Name = "rB_ConvertWholeFile";
            rB_ConvertWholeFile.Size = new Size(268, 21);
            rB_ConvertWholeFile.TabIndex = 7;
            rB_ConvertWholeFile.TabStop = true;
            rB_ConvertWholeFile.Text = "convert whole file";
            rB_ConvertWholeFile.UseVisualStyleBackColor = true;
            rB_ConvertWholeFile.CheckedChanged += ConvertOptionsChanged;
            // 
            // rB_ConvertSection
            // 
            rB_ConvertSection.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(rB_ConvertSection, 3);
            rB_ConvertSection.Dock = DockStyle.Fill;
            rB_ConvertSection.Location = new Point(3, 89);
            rB_ConvertSection.Name = "rB_ConvertSection";
            rB_ConvertSection.Size = new Size(268, 21);
            rB_ConvertSection.TabIndex = 8;
            rB_ConvertSection.TabStop = true;
            rB_ConvertSection.Text = "convert section";
            rB_ConvertSection.UseVisualStyleBackColor = true;
            rB_ConvertSection.CheckedChanged += ConvertOptionsChanged;
            // 
            // l_StartTime
            // 
            l_StartTime.AutoSize = true;
            l_StartTime.Dock = DockStyle.Fill;
            l_StartTime.Location = new Point(23, 113);
            l_StartTime.Name = "l_StartTime";
            l_StartTime.Size = new Size(75, 27);
            l_StartTime.TabIndex = 9;
            l_StartTime.Text = "start time:";
            l_StartTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_EndTime
            // 
            l_EndTime.AutoSize = true;
            l_EndTime.Dock = DockStyle.Fill;
            l_EndTime.Location = new Point(23, 140);
            l_EndTime.Name = "l_EndTime";
            l_EndTime.Size = new Size(75, 27);
            l_EndTime.TabIndex = 10;
            l_EndTime.Text = "end time:";
            l_EndTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mTB_StartTime
            // 
            mTB_StartTime.Location = new Point(104, 116);
            mTB_StartTime.Mask = "00:00:00.000";
            mTB_StartTime.Name = "mTB_StartTime";
            mTB_StartTime.Size = new Size(100, 21);
            mTB_StartTime.TabIndex = 12;
            // 
            // mTB_EndTime
            // 
            mTB_EndTime.Location = new Point(104, 143);
            mTB_EndTime.Mask = "00:00:00.000";
            mTB_EndTime.Name = "mTB_EndTime";
            mTB_EndTime.Size = new Size(100, 21);
            mTB_EndTime.TabIndex = 13;
            // 
            // b_Convert
            // 
            b_Convert.Location = new Point(362, 280);
            b_Convert.Name = "b_Convert";
            b_Convert.Size = new Size(75, 21);
            b_Convert.TabIndex = 14;
            b_Convert.Text = "Convert";
            b_Convert.UseVisualStyleBackColor = true;
            b_Convert.Click += ConvertFile_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(mTB_EndTime, 2, 6);
            tableLayoutPanel1.Controls.Add(mTB_StartTime, 2, 5);
            tableLayoutPanel1.Controls.Add(l_EndTime, 1, 6);
            tableLayoutPanel1.Controls.Add(tB_SourceFilePath, 2, 0);
            tableLayoutPanel1.Controls.Add(b_SelectSourceFile, 3, 0);
            tableLayoutPanel1.Controls.Add(l_StartTime, 1, 5);
            tableLayoutPanel1.Controls.Add(b_SetOutputFilePath, 3, 1);
            tableLayoutPanel1.Controls.Add(rB_ConvertSection, 0, 4);
            tableLayoutPanel1.Controls.Add(b_SetDefaultOutputFilePath, 4, 1);
            tableLayoutPanel1.Controls.Add(rB_ConvertWholeFile, 0, 3);
            tableLayoutPanel1.Controls.Add(tB_OutputFilePath, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(b_Convert, 4, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(444, 304);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // UC_VideoToAudio
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_VideoToAudio";
            Size = new Size(444, 304);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tB_SourceFilePath;
        private Button b_SelectSourceFile;
        private Label label2;
        private TextBox tB_OutputFilePath;
        private Button b_SetOutputFilePath;
        private Button b_SetDefaultOutputFilePath;
        private RadioButton rB_ConvertWholeFile;
        private RadioButton rB_ConvertSection;
        private Label l_StartTime;
        private Label l_EndTime;
        private MaskedTextBox mTB_StartTime;
        private MaskedTextBox mTB_EndTime;
        private Button b_Convert;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
