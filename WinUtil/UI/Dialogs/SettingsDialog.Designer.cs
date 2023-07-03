namespace WinUtil.UI.Dialogs
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            b_Save = new Button();
            b_Cancel = new Button();
            label1 = new Label();
            tB_FFmpegPath = new TextBox();
            b_SelectFFmpegPath = new Button();
            label2 = new Label();
            tB_DownloadDirectory = new TextBox();
            b_SelectDownloadDirectory = new Button();
            SuspendLayout();
            // 
            // b_Save
            // 
            b_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            b_Save.Location = new Point(287, 79);
            b_Save.Name = "b_Save";
            b_Save.Size = new Size(75, 23);
            b_Save.TabIndex = 0;
            b_Save.Text = "Save";
            b_Save.UseVisualStyleBackColor = true;
            b_Save.Click += Save_Click;
            // 
            // b_Cancel
            // 
            b_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            b_Cancel.Location = new Point(368, 79);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(75, 23);
            b_Cancel.TabIndex = 2;
            b_Cancel.Text = "Cancel";
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Click += Cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(124, 12);
            label1.TabIndex = 3;
            label1.Text = "path of ffmpeg executable:";
            // 
            // tB_FFmpegPath
            // 
            tB_FFmpegPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tB_FFmpegPath.Location = new Point(142, 14);
            tB_FFmpegPath.Name = "tB_FFmpegPath";
            tB_FFmpegPath.Size = new Size(220, 21);
            tB_FFmpegPath.TabIndex = 4;
            // 
            // b_SelectFFmpegPath
            // 
            b_SelectFFmpegPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_SelectFFmpegPath.Location = new Point(368, 12);
            b_SelectFFmpegPath.Name = "b_SelectFFmpegPath";
            b_SelectFFmpegPath.Size = new Size(75, 23);
            b_SelectFFmpegPath.TabIndex = 5;
            b_SelectFFmpegPath.Text = "select";
            b_SelectFFmpegPath.UseVisualStyleBackColor = true;
            b_SelectFFmpegPath.Click += SelectFFmpegPath_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 44);
            label2.Name = "label2";
            label2.Size = new Size(125, 12);
            label2.TabIndex = 6;
            label2.Text = "default download directory:";
            // 
            // tB_DownloadDirectory
            // 
            tB_DownloadDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tB_DownloadDirectory.Location = new Point(143, 41);
            tB_DownloadDirectory.Name = "tB_DownloadDirectory";
            tB_DownloadDirectory.Size = new Size(219, 21);
            tB_DownloadDirectory.TabIndex = 7;
            // 
            // b_SelectDownloadDirectory
            // 
            b_SelectDownloadDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_SelectDownloadDirectory.Location = new Point(368, 39);
            b_SelectDownloadDirectory.Name = "b_SelectDownloadDirectory";
            b_SelectDownloadDirectory.Size = new Size(75, 23);
            b_SelectDownloadDirectory.TabIndex = 8;
            b_SelectDownloadDirectory.Text = "select";
            b_SelectDownloadDirectory.UseVisualStyleBackColor = true;
            b_SelectDownloadDirectory.Click += SelectDownloadDirectory_Click;
            // 
            // SettingsDialog
            // 
            AcceptButton = b_Save;
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = b_Cancel;
            ClientSize = new Size(455, 114);
            Controls.Add(b_SelectDownloadDirectory);
            Controls.Add(tB_DownloadDirectory);
            Controls.Add(label2);
            Controls.Add(b_SelectFFmpegPath);
            Controls.Add(tB_FFmpegPath);
            Controls.Add(label1);
            Controls.Add(b_Cancel);
            Controls.Add(b_Save);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsDialog";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Save;
        private Button b_Cancel;
        private Label label1;
        private TextBox tB_FFmpegPath;
        private Button b_SelectFFmpegPath;
        private Label label2;
        private TextBox tB_DownloadDirectory;
        private Button b_SelectDownloadDirectory;
    }
}