namespace WinUtil.UI.Frames
{
    partial class UC_VideoCut
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
            b_SelectOutputFilePath = new Button();
            l_StartTime = new Label();
            l_EndTime = new Label();
            b_Convert = new Button();
            tP_StartTime = new Controls.TimePicker();
            tP_EndTime = new Controls.TimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            cB_CutVideo = new CheckBox();
            cB_RotateVideo = new CheckBox();
            l_Rotate = new Label();
            cB_RotationAngle = new ComboBox();
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
            label1.Size = new Size(97, 27);
            label1.TabIndex = 0;
            label1.Text = "input file:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_SourceFilePath
            // 
            tB_SourceFilePath.Dock = DockStyle.Fill;
            tB_SourceFilePath.Location = new Point(106, 3);
            tB_SourceFilePath.Name = "tB_SourceFilePath";
            tB_SourceFilePath.Size = new Size(418, 21);
            tB_SourceFilePath.TabIndex = 1;
            tB_SourceFilePath.TextChanged += SetDefaultOutputFilePath;
            // 
            // b_SelectSourceFile
            // 
            b_SelectSourceFile.Location = new Point(530, 3);
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
            label2.Size = new Size(97, 27);
            label2.TabIndex = 3;
            label2.Text = "output file:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tB_OutputFilePath
            // 
            tB_OutputFilePath.Dock = DockStyle.Fill;
            tB_OutputFilePath.Location = new Point(106, 30);
            tB_OutputFilePath.Name = "tB_OutputFilePath";
            tB_OutputFilePath.Size = new Size(418, 21);
            tB_OutputFilePath.TabIndex = 4;
            // 
            // b_SelectOutputFilePath
            // 
            b_SelectOutputFilePath.Location = new Point(530, 30);
            b_SelectOutputFilePath.Name = "b_SelectOutputFilePath";
            b_SelectOutputFilePath.Size = new Size(75, 21);
            b_SelectOutputFilePath.TabIndex = 5;
            b_SelectOutputFilePath.Text = "select";
            b_SelectOutputFilePath.UseVisualStyleBackColor = true;
            b_SelectOutputFilePath.Click += SelectOutputFilePath_Click;
            // 
            // l_StartTime
            // 
            l_StartTime.AutoSize = true;
            l_StartTime.Dock = DockStyle.Fill;
            l_StartTime.Location = new Point(29, 86);
            l_StartTime.Name = "l_StartTime";
            l_StartTime.Size = new Size(71, 27);
            l_StartTime.TabIndex = 6;
            l_StartTime.Text = "start time:";
            l_StartTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_EndTime
            // 
            l_EndTime.AutoSize = true;
            l_EndTime.Dock = DockStyle.Fill;
            l_EndTime.Location = new Point(29, 113);
            l_EndTime.Name = "l_EndTime";
            l_EndTime.Size = new Size(71, 27);
            l_EndTime.TabIndex = 7;
            l_EndTime.Text = "end time:";
            l_EndTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_Convert
            // 
            b_Convert.Location = new Point(530, 608);
            b_Convert.Name = "b_Convert";
            b_Convert.Size = new Size(75, 21);
            b_Convert.TabIndex = 8;
            b_Convert.Text = "convert";
            b_Convert.UseVisualStyleBackColor = true;
            b_Convert.Click += Convert_Click;
            // 
            // tP_StartTime
            // 
            tP_StartTime.Hours = 0;
            tP_StartTime.Location = new Point(106, 89);
            tP_StartTime.Milliseconds = 0;
            tP_StartTime.Minutes = 0;
            tP_StartTime.Name = "tP_StartTime";
            tP_StartTime.Seconds = 0;
            tP_StartTime.Size = new Size(75, 18);
            tP_StartTime.TabIndex = 11;
            tP_StartTime.Value = TimeSpan.Parse("00:00:00");
            // 
            // tP_EndTime
            // 
            tP_EndTime.Hours = 0;
            tP_EndTime.Location = new Point(106, 116);
            tP_EndTime.Milliseconds = 0;
            tP_EndTime.Minutes = 0;
            tP_EndTime.Name = "tP_EndTime";
            tP_EndTime.Seconds = 0;
            tP_EndTime.Size = new Size(75, 18);
            tP_EndTime.TabIndex = 12;
            tP_EndTime.Value = TimeSpan.Parse("00:00:00");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(b_Convert, 3, 10);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(tB_SourceFilePath, 2, 0);
            tableLayoutPanel1.Controls.Add(b_SelectSourceFile, 3, 0);
            tableLayoutPanel1.Controls.Add(tB_OutputFilePath, 2, 1);
            tableLayoutPanel1.Controls.Add(b_SelectOutputFilePath, 3, 1);
            tableLayoutPanel1.Controls.Add(l_EndTime, 1, 5);
            tableLayoutPanel1.Controls.Add(l_StartTime, 1, 4);
            tableLayoutPanel1.Controls.Add(tP_EndTime, 2, 5);
            tableLayoutPanel1.Controls.Add(tP_StartTime, 2, 4);
            tableLayoutPanel1.Controls.Add(cB_CutVideo, 0, 3);
            tableLayoutPanel1.Controls.Add(cB_RotateVideo, 0, 7);
            tableLayoutPanel1.Controls.Add(l_Rotate, 1, 8);
            tableLayoutPanel1.Controls.Add(cB_RotationAngle, 2, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(612, 632);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // cB_CutVideo
            // 
            cB_CutVideo.AutoSize = true;
            cB_CutVideo.Checked = true;
            cB_CutVideo.CheckState = CheckState.Checked;
            tableLayoutPanel1.SetColumnSpan(cB_CutVideo, 3);
            cB_CutVideo.Dock = DockStyle.Fill;
            cB_CutVideo.Location = new Point(3, 62);
            cB_CutVideo.Name = "cB_CutVideo";
            cB_CutVideo.Size = new Size(521, 21);
            cB_CutVideo.TabIndex = 13;
            cB_CutVideo.Text = "cut out segment";
            cB_CutVideo.UseVisualStyleBackColor = true;
            cB_CutVideo.CheckedChanged += EditOptions_CheckedChanged;
            // 
            // cB_RotateVideo
            // 
            cB_RotateVideo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cB_RotateVideo, 3);
            cB_RotateVideo.Dock = DockStyle.Fill;
            cB_RotateVideo.Location = new Point(3, 148);
            cB_RotateVideo.Name = "cB_RotateVideo";
            cB_RotateVideo.Size = new Size(521, 21);
            cB_RotateVideo.TabIndex = 14;
            cB_RotateVideo.Text = "rotate";
            cB_RotateVideo.UseVisualStyleBackColor = true;
            cB_RotateVideo.CheckedChanged += EditOptions_CheckedChanged;
            // 
            // l_Rotate
            // 
            l_Rotate.AutoSize = true;
            l_Rotate.Dock = DockStyle.Fill;
            l_Rotate.Location = new Point(29, 172);
            l_Rotate.Name = "l_Rotate";
            l_Rotate.Size = new Size(71, 27);
            l_Rotate.TabIndex = 15;
            l_Rotate.Text = "rotation angle:";
            l_Rotate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cB_RotationAngle
            // 
            cB_RotationAngle.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_RotationAngle.FormattingEnabled = true;
            cB_RotationAngle.Items.AddRange(new object[] { "90° counterclockwise and vertical flip", "90° clockwise", "90° counterclockwise", "90° clockwise and vertical flip", "180°" });
            cB_RotationAngle.Location = new Point(106, 175);
            cB_RotationAngle.Name = "cB_RotationAngle";
            cB_RotationAngle.Size = new Size(202, 20);
            cB_RotationAngle.TabIndex = 16;
            // 
            // UC_VideoCut
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_VideoCut";
            Size = new Size(612, 632);
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
        private Button b_SelectOutputFilePath;
        private Label l_StartTime;
        private Label l_EndTime;
        private Button b_Convert;
        private Controls.TimePicker tP_StartTime;
        private Controls.TimePicker tP_EndTime;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox cB_CutVideo;
        private CheckBox cB_RotateVideo;
        private Label l_Rotate;
        private ComboBox cB_RotationAngle;
    }
}
