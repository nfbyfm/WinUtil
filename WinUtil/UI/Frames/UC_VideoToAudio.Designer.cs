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
            rB_ConvertWholeFile = new RadioButton();
            rB_ConvertSection = new RadioButton();
            l_StartTime = new Label();
            l_EndTime = new Label();
            b_Convert = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tP_StartTime = new Controls.TimePicker();
            tP_EndTime = new Controls.TimePicker();
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
            label1.Size = new Size(75, 27);
            label1.TabIndex = 0;
            label1.Text = "input file:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_SourceFilePath
            // 
            tB_SourceFilePath.Dock = DockStyle.Fill;
            tB_SourceFilePath.Location = new Point(84, 3);
            tB_SourceFilePath.Name = "tB_SourceFilePath";
            tB_SourceFilePath.Size = new Size(272, 21);
            tB_SourceFilePath.TabIndex = 1;
            tB_SourceFilePath.TextChanged += SetDefaultOutputFilePath;
            // 
            // b_SelectSourceFile
            // 
            b_SelectSourceFile.Location = new Point(362, 3);
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
            label2.Size = new Size(75, 27);
            label2.TabIndex = 3;
            label2.Text = "output file:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_OutputFilePath
            // 
            tB_OutputFilePath.Dock = DockStyle.Fill;
            tB_OutputFilePath.Location = new Point(84, 30);
            tB_OutputFilePath.Name = "tB_OutputFilePath";
            tB_OutputFilePath.Size = new Size(272, 21);
            tB_OutputFilePath.TabIndex = 4;
            // 
            // b_SetOutputFilePath
            // 
            b_SetOutputFilePath.Location = new Point(362, 30);
            b_SetOutputFilePath.Name = "b_SetOutputFilePath";
            b_SetOutputFilePath.Size = new Size(75, 21);
            b_SetOutputFilePath.TabIndex = 5;
            b_SetOutputFilePath.Text = "select";
            b_SetOutputFilePath.UseVisualStyleBackColor = true;
            b_SetOutputFilePath.Click += SetOutputFilePath_Click;
            // 
            // rB_ConvertWholeFile
            // 
            rB_ConvertWholeFile.AutoSize = true;
            rB_ConvertWholeFile.Checked = true;
            tableLayoutPanel1.SetColumnSpan(rB_ConvertWholeFile, 3);
            rB_ConvertWholeFile.Dock = DockStyle.Fill;
            rB_ConvertWholeFile.Location = new Point(3, 62);
            rB_ConvertWholeFile.Name = "rB_ConvertWholeFile";
            rB_ConvertWholeFile.Size = new Size(353, 21);
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
            rB_ConvertSection.Size = new Size(353, 21);
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
            l_StartTime.Size = new Size(55, 27);
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
            l_EndTime.Size = new Size(55, 27);
            l_EndTime.TabIndex = 10;
            l_EndTime.Text = "end time:";
            l_EndTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_Convert
            // 
            b_Convert.Location = new Point(362, 280);
            b_Convert.Name = "b_Convert";
            b_Convert.Size = new Size(75, 21);
            b_Convert.TabIndex = 14;
            b_Convert.Text = "convert";
            b_Convert.UseVisualStyleBackColor = true;
            b_Convert.Click += ConvertFile_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(l_EndTime, 1, 6);
            tableLayoutPanel1.Controls.Add(tB_SourceFilePath, 2, 0);
            tableLayoutPanel1.Controls.Add(b_SelectSourceFile, 3, 0);
            tableLayoutPanel1.Controls.Add(l_StartTime, 1, 5);
            tableLayoutPanel1.Controls.Add(b_SetOutputFilePath, 3, 1);
            tableLayoutPanel1.Controls.Add(rB_ConvertSection, 0, 4);
            tableLayoutPanel1.Controls.Add(rB_ConvertWholeFile, 0, 3);
            tableLayoutPanel1.Controls.Add(tB_OutputFilePath, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(b_Convert, 3, 8);
            tableLayoutPanel1.Controls.Add(tP_StartTime, 2, 5);
            tableLayoutPanel1.Controls.Add(tP_EndTime, 2, 6);
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
            // tP_StartTime
            // 
            tP_StartTime.Hours = 0;
            tP_StartTime.Location = new Point(84, 116);
            tP_StartTime.Milliseconds = 0;
            tP_StartTime.Minutes = 0;
            tP_StartTime.Name = "tP_StartTime";
            tP_StartTime.Seconds = 0;
            tP_StartTime.Size = new Size(75, 18);
            tP_StartTime.TabIndex = 15;
            tP_StartTime.Value = TimeSpan.Parse("00:00:00");
            // 
            // tP_EndTime
            // 
            tP_EndTime.Hours = 0;
            tP_EndTime.Location = new Point(84, 143);
            tP_EndTime.Milliseconds = 0;
            tP_EndTime.Minutes = 0;
            tP_EndTime.Name = "tP_EndTime";
            tP_EndTime.Seconds = 0;
            tP_EndTime.Size = new Size(75, 18);
            tP_EndTime.TabIndex = 16;
            tP_EndTime.Value = TimeSpan.Parse("00:00:00");
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
        private RadioButton rB_ConvertWholeFile;
        private RadioButton rB_ConvertSection;
        private Label l_StartTime;
        private Label l_EndTime;
        private Button b_Convert;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.TimePicker tP_StartTime;
        private Controls.TimePicker tP_EndTime;
    }
}
