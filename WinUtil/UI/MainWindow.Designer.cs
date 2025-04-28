using WinUtil.UI.Frames;

namespace WinUtil
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.mainTabControl = new System.Windows.Forms.TabControl();
      this.tabPageAutoDownload = new System.Windows.Forms.TabPage();
      this.uC_AutoDownload = new WinUtil.UI.Frames.UC_AutoDownload();
      this.tabPageBatchDownload = new System.Windows.Forms.TabPage();
      this.uC_Batchdownload = new WinUtil.UI.Frames.UC_Batchdownload();
      this.tabPageRename = new System.Windows.Forms.TabPage();
      this.uC_RenameFiles = new WinUtil.UI.Frames.UC_Rename();
      this.tabPageMove = new System.Windows.Forms.TabPage();
      this.uC_MoveFiles = new WinUtil.UI.Frames.UC_Move();
      this.tabPageMP3Tag = new System.Windows.Forms.TabPage();
      this.uC_mP3TagEditor = new WinUtil.UI.Frames.UC_MP3TagEditor();
      this.tabPageDirectoryInfo = new System.Windows.Forms.TabPage();
      this.uC_DirectoryInfo = new WinUtil.UI.Frames.UC_DirectoryInfo();
      this.tabPageVideoAudioConvert = new System.Windows.Forms.TabPage();
      this.uC_VideoToAudio = new WinUtil.UI.Frames.UC_VideoToAudio();
      this.tabPageVideoEdit = new System.Windows.Forms.TabPage();
      this.uC_VideoCut = new WinUtil.UI.Frames.UC_VideoCut();
      this.tabPageWebPConvert = new System.Windows.Forms.TabPage();
      this.uC_WebPConvert = new WinUtil.UI.Frames.UC_WebPConvert();
      this.tabPageImageResize = new System.Windows.Forms.TabPage();
      this.uC_ImageResize = new WinUtil.UI.Frames.UC_ImageResize();
      this.tabPageConvertToMp3 = new System.Windows.Forms.TabPage();
      this.uC_ConvertToMp3 = new WinUtil.UI.Frames.UC_ConvertToMp3();
      this.tabPageBskySort = new System.Windows.Forms.TabPage();
      this.uC_BskySort = new WinUtil.UI.Frames.UC_BskySort();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.mainTabControl.SuspendLayout();
      this.tabPageAutoDownload.SuspendLayout();
      this.tabPageBatchDownload.SuspendLayout();
      this.tabPageRename.SuspendLayout();
      this.tabPageMove.SuspendLayout();
      this.tabPageMP3Tag.SuspendLayout();
      this.tabPageDirectoryInfo.SuspendLayout();
      this.tabPageVideoAudioConvert.SuspendLayout();
      this.tabPageVideoEdit.SuspendLayout();
      this.tabPageWebPConvert.SuspendLayout();
      this.tabPageImageResize.SuspendLayout();
      this.tabPageConvertToMp3.SuspendLayout();
      this.tabPageBskySort.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extrasToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(937, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.quitToolStripMenuItem.Text = "&Quit";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // extrasToolStripMenuItem
      // 
      this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem});
      this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
      this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.extrasToolStripMenuItem.Text = "&Extras";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
      // 
      // settingsToolStripMenuItem
      // 
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.settingsToolStripMenuItem.Text = "&Settings";
      this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 833);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.statusStrip1.Size = new System.Drawing.Size(937, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.mainTabControl);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
      this.splitContainer1.Size = new System.Drawing.Size(937, 809);
      this.splitContainer1.SplitterDistance = 532;
      this.splitContainer1.SplitterWidth = 5;
      this.splitContainer1.TabIndex = 2;
      // 
      // mainTabControl
      // 
      this.mainTabControl.Controls.Add(this.tabPageAutoDownload);
      this.mainTabControl.Controls.Add(this.tabPageBatchDownload);
      this.mainTabControl.Controls.Add(this.tabPageRename);
      this.mainTabControl.Controls.Add(this.tabPageMove);
      this.mainTabControl.Controls.Add(this.tabPageMP3Tag);
      this.mainTabControl.Controls.Add(this.tabPageDirectoryInfo);
      this.mainTabControl.Controls.Add(this.tabPageVideoAudioConvert);
      this.mainTabControl.Controls.Add(this.tabPageVideoEdit);
      this.mainTabControl.Controls.Add(this.tabPageWebPConvert);
      this.mainTabControl.Controls.Add(this.tabPageImageResize);
      this.mainTabControl.Controls.Add(this.tabPageConvertToMp3);
      this.mainTabControl.Controls.Add(this.tabPageBskySort);
      this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainTabControl.Location = new System.Drawing.Point(0, 0);
      this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
      this.mainTabControl.Multiline = true;
      this.mainTabControl.Name = "mainTabControl";
      this.mainTabControl.SelectedIndex = 0;
      this.mainTabControl.Size = new System.Drawing.Size(937, 532);
      this.mainTabControl.TabIndex = 0;
      // 
      // tabPageAutoDownload
      // 
      this.tabPageAutoDownload.Controls.Add(this.uC_AutoDownload);
      this.tabPageAutoDownload.Location = new System.Drawing.Point(4, 44);
      this.tabPageAutoDownload.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageAutoDownload.Name = "tabPageAutoDownload";
      this.tabPageAutoDownload.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageAutoDownload.Size = new System.Drawing.Size(929, 484);
      this.tabPageAutoDownload.TabIndex = 3;
      this.tabPageAutoDownload.Text = "auto download";
      this.tabPageAutoDownload.UseVisualStyleBackColor = true;
      // 
      // uC_AutoDownload
      // 
      this.uC_AutoDownload.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_AutoDownload.Location = new System.Drawing.Point(4, 4);
      this.uC_AutoDownload.Margin = new System.Windows.Forms.Padding(5);
      this.uC_AutoDownload.Name = "uC_AutoDownload";
      this.uC_AutoDownload.Size = new System.Drawing.Size(921, 476);
      this.uC_AutoDownload.TabIndex = 0;
      // 
      // tabPageBatchDownload
      // 
      this.tabPageBatchDownload.Controls.Add(this.uC_Batchdownload);
      this.tabPageBatchDownload.Location = new System.Drawing.Point(4, 44);
      this.tabPageBatchDownload.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageBatchDownload.Name = "tabPageBatchDownload";
      this.tabPageBatchDownload.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageBatchDownload.Size = new System.Drawing.Size(192, 52);
      this.tabPageBatchDownload.TabIndex = 3;
      this.tabPageBatchDownload.Text = "batch download files";
      this.tabPageBatchDownload.UseVisualStyleBackColor = true;
      // 
      // uC_Batchdownload
      // 
      this.uC_Batchdownload.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_Batchdownload.Location = new System.Drawing.Point(4, 4);
      this.uC_Batchdownload.Margin = new System.Windows.Forms.Padding(5);
      this.uC_Batchdownload.Name = "uC_Batchdownload";
      this.uC_Batchdownload.Size = new System.Drawing.Size(184, 44);
      this.uC_Batchdownload.TabIndex = 0;
      // 
      // tabPageRename
      // 
      this.tabPageRename.Controls.Add(this.uC_RenameFiles);
      this.tabPageRename.Location = new System.Drawing.Point(4, 64);
      this.tabPageRename.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageRename.Name = "tabPageRename";
      this.tabPageRename.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageRename.Size = new System.Drawing.Size(192, 32);
      this.tabPageRename.TabIndex = 1;
      this.tabPageRename.Text = "rename files";
      this.tabPageRename.UseVisualStyleBackColor = true;
      // 
      // uC_RenameFiles
      // 
      this.uC_RenameFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_RenameFiles.Location = new System.Drawing.Point(4, 4);
      this.uC_RenameFiles.Margin = new System.Windows.Forms.Padding(5);
      this.uC_RenameFiles.Name = "uC_RenameFiles";
      this.uC_RenameFiles.Size = new System.Drawing.Size(184, 24);
      this.uC_RenameFiles.TabIndex = 0;
      // 
      // tabPageMove
      // 
      this.tabPageMove.Controls.Add(this.uC_MoveFiles);
      this.tabPageMove.Location = new System.Drawing.Point(4, 64);
      this.tabPageMove.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageMove.Name = "tabPageMove";
      this.tabPageMove.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageMove.Size = new System.Drawing.Size(192, 32);
      this.tabPageMove.TabIndex = 2;
      this.tabPageMove.Text = "move files";
      this.tabPageMove.UseVisualStyleBackColor = true;
      // 
      // uC_MoveFiles
      // 
      this.uC_MoveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_MoveFiles.Location = new System.Drawing.Point(4, 4);
      this.uC_MoveFiles.Margin = new System.Windows.Forms.Padding(5);
      this.uC_MoveFiles.Name = "uC_MoveFiles";
      this.uC_MoveFiles.Size = new System.Drawing.Size(184, 24);
      this.uC_MoveFiles.TabIndex = 0;
      // 
      // tabPageMP3Tag
      // 
      this.tabPageMP3Tag.Controls.Add(this.uC_mP3TagEditor);
      this.tabPageMP3Tag.Location = new System.Drawing.Point(4, 84);
      this.tabPageMP3Tag.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageMP3Tag.Name = "tabPageMP3Tag";
      this.tabPageMP3Tag.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageMP3Tag.Size = new System.Drawing.Size(192, 12);
      this.tabPageMP3Tag.TabIndex = 4;
      this.tabPageMP3Tag.Text = "edit mp3 tags";
      this.tabPageMP3Tag.UseVisualStyleBackColor = true;
      // 
      // uC_mP3TagEditor
      // 
      this.uC_mP3TagEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_mP3TagEditor.Location = new System.Drawing.Point(4, 4);
      this.uC_mP3TagEditor.Margin = new System.Windows.Forms.Padding(5);
      this.uC_mP3TagEditor.Name = "uC_mP3TagEditor";
      this.uC_mP3TagEditor.Size = new System.Drawing.Size(184, 4);
      this.uC_mP3TagEditor.TabIndex = 0;
      // 
      // tabPageDirectoryInfo
      // 
      this.tabPageDirectoryInfo.Controls.Add(this.uC_DirectoryInfo);
      this.tabPageDirectoryInfo.Location = new System.Drawing.Point(4, 84);
      this.tabPageDirectoryInfo.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageDirectoryInfo.Name = "tabPageDirectoryInfo";
      this.tabPageDirectoryInfo.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageDirectoryInfo.Size = new System.Drawing.Size(192, 12);
      this.tabPageDirectoryInfo.TabIndex = 5;
      this.tabPageDirectoryInfo.Text = "directory info";
      this.tabPageDirectoryInfo.UseVisualStyleBackColor = true;
      // 
      // uC_DirectoryInfo
      // 
      this.uC_DirectoryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_DirectoryInfo.Location = new System.Drawing.Point(4, 4);
      this.uC_DirectoryInfo.Margin = new System.Windows.Forms.Padding(5);
      this.uC_DirectoryInfo.Name = "uC_DirectoryInfo";
      this.uC_DirectoryInfo.Size = new System.Drawing.Size(184, 4);
      this.uC_DirectoryInfo.TabIndex = 0;
      // 
      // tabPageVideoAudioConvert
      // 
      this.tabPageVideoAudioConvert.Controls.Add(this.uC_VideoToAudio);
      this.tabPageVideoAudioConvert.Location = new System.Drawing.Point(4, 104);
      this.tabPageVideoAudioConvert.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageVideoAudioConvert.Name = "tabPageVideoAudioConvert";
      this.tabPageVideoAudioConvert.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageVideoAudioConvert.Size = new System.Drawing.Size(192, 0);
      this.tabPageVideoAudioConvert.TabIndex = 2;
      this.tabPageVideoAudioConvert.Text = "video to audio convert";
      this.tabPageVideoAudioConvert.UseVisualStyleBackColor = true;
      // 
      // uC_VideoToAudio
      // 
      this.uC_VideoToAudio.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_VideoToAudio.Location = new System.Drawing.Point(4, 4);
      this.uC_VideoToAudio.Margin = new System.Windows.Forms.Padding(5);
      this.uC_VideoToAudio.Name = "uC_VideoToAudio";
      this.uC_VideoToAudio.Size = new System.Drawing.Size(184, 0);
      this.uC_VideoToAudio.TabIndex = 0;
      // 
      // tabPageVideoEdit
      // 
      this.tabPageVideoEdit.Controls.Add(this.uC_VideoCut);
      this.tabPageVideoEdit.Location = new System.Drawing.Point(4, 104);
      this.tabPageVideoEdit.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageVideoEdit.Name = "tabPageVideoEdit";
      this.tabPageVideoEdit.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageVideoEdit.Size = new System.Drawing.Size(192, 0);
      this.tabPageVideoEdit.TabIndex = 2;
      this.tabPageVideoEdit.Text = "video edit";
      this.tabPageVideoEdit.UseVisualStyleBackColor = true;
      // 
      // uC_VideoCut
      // 
      this.uC_VideoCut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_VideoCut.Location = new System.Drawing.Point(4, 4);
      this.uC_VideoCut.Margin = new System.Windows.Forms.Padding(5);
      this.uC_VideoCut.Name = "uC_VideoCut";
      this.uC_VideoCut.Size = new System.Drawing.Size(184, 0);
      this.uC_VideoCut.TabIndex = 0;
      // 
      // tabPageWebPConvert
      // 
      this.tabPageWebPConvert.Controls.Add(this.uC_WebPConvert);
      this.tabPageWebPConvert.Location = new System.Drawing.Point(4, 124);
      this.tabPageWebPConvert.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageWebPConvert.Name = "tabPageWebPConvert";
      this.tabPageWebPConvert.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageWebPConvert.Size = new System.Drawing.Size(192, 0);
      this.tabPageWebPConvert.TabIndex = 2;
      this.tabPageWebPConvert.Text = "WebP convert";
      this.tabPageWebPConvert.UseVisualStyleBackColor = true;
      // 
      // uC_WebPConvert
      // 
      this.uC_WebPConvert.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_WebPConvert.Location = new System.Drawing.Point(4, 4);
      this.uC_WebPConvert.Margin = new System.Windows.Forms.Padding(5);
      this.uC_WebPConvert.Name = "uC_WebPConvert";
      this.uC_WebPConvert.Size = new System.Drawing.Size(184, 0);
      this.uC_WebPConvert.TabIndex = 0;
      // 
      // tabPageImageResize
      // 
      this.tabPageImageResize.Controls.Add(this.uC_ImageResize);
      this.tabPageImageResize.Location = new System.Drawing.Point(4, 124);
      this.tabPageImageResize.Margin = new System.Windows.Forms.Padding(4);
      this.tabPageImageResize.Name = "tabPageImageResize";
      this.tabPageImageResize.Padding = new System.Windows.Forms.Padding(4);
      this.tabPageImageResize.Size = new System.Drawing.Size(192, 0);
      this.tabPageImageResize.TabIndex = 2;
      this.tabPageImageResize.Text = "image resize";
      this.tabPageImageResize.UseVisualStyleBackColor = true;
      // 
      // uC_ImageResize
      // 
      this.uC_ImageResize.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_ImageResize.Location = new System.Drawing.Point(4, 4);
      this.uC_ImageResize.Margin = new System.Windows.Forms.Padding(5);
      this.uC_ImageResize.Name = "uC_ImageResize";
      this.uC_ImageResize.Size = new System.Drawing.Size(184, 0);
      this.uC_ImageResize.TabIndex = 0;
      // 
      // tabPageConvertToMp3
      // 
      this.tabPageConvertToMp3.Controls.Add(this.uC_ConvertToMp3);
      this.tabPageConvertToMp3.Location = new System.Drawing.Point(4, 144);
      this.tabPageConvertToMp3.Name = "tabPageConvertToMp3";
      this.tabPageConvertToMp3.Size = new System.Drawing.Size(192, 0);
      this.tabPageConvertToMp3.TabIndex = 6;
      this.tabPageConvertToMp3.Text = "convert to mp3";
      this.tabPageConvertToMp3.UseVisualStyleBackColor = true;
      // 
      // uC_ConvertToMp3
      // 
      this.uC_ConvertToMp3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_ConvertToMp3.Location = new System.Drawing.Point(0, 0);
      this.uC_ConvertToMp3.Name = "uC_ConvertToMp3";
      this.uC_ConvertToMp3.Size = new System.Drawing.Size(192, 0);
      this.uC_ConvertToMp3.TabIndex = 0;
      // 
      // tabPageBskySort
      // 
      this.tabPageBskySort.Controls.Add(this.uC_BskySort);
      this.tabPageBskySort.Location = new System.Drawing.Point(4, 44);
      this.tabPageBskySort.Name = "tabPageBskySort";
      this.tabPageBskySort.Size = new System.Drawing.Size(929, 484);
      this.tabPageBskySort.TabIndex = 7;
      this.tabPageBskySort.Text = "bluesky sort";
      this.tabPageBskySort.UseVisualStyleBackColor = true;
      // 
      // uC_BskySort
      // 
      this.uC_BskySort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uC_BskySort.Location = new System.Drawing.Point(0, 0);
      this.uC_BskySort.Name = "uC_BskySort";
      this.uC_BskySort.Size = new System.Drawing.Size(929, 484);
      this.uC_BskySort.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.outputRichTextBox);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(937, 272);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Ouput";
      // 
      // outputRichTextBox
      // 
      this.outputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.outputRichTextBox.Location = new System.Drawing.Point(4, 20);
      this.outputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.outputRichTextBox.Name = "outputRichTextBox";
      this.outputRichTextBox.Size = new System.Drawing.Size(929, 248);
      this.outputRichTextBox.TabIndex = 0;
      this.outputRichTextBox.Text = "";
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(937, 855);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainWindow";
      this.Text = "Windows Utility Tool";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.mainTabControl.ResumeLayout(false);
      this.tabPageAutoDownload.ResumeLayout(false);
      this.tabPageBatchDownload.ResumeLayout(false);
      this.tabPageRename.ResumeLayout(false);
      this.tabPageMove.ResumeLayout(false);
      this.tabPageMP3Tag.ResumeLayout(false);
      this.tabPageDirectoryInfo.ResumeLayout(false);
      this.tabPageVideoAudioConvert.ResumeLayout(false);
      this.tabPageVideoEdit.ResumeLayout(false);
      this.tabPageWebPConvert.ResumeLayout(false);
      this.tabPageImageResize.ResumeLayout(false);
      this.tabPageConvertToMp3.ResumeLayout(false);
      this.tabPageBskySort.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private TabControl mainTabControl;
        private TabPage tabPageRename;
        private GroupBox groupBox1;
        private RichTextBox outputRichTextBox;
        private TabPage tabPageMove;
        private TabPage tabPageAutoDownload;
        private TabPage tabPageBatchDownload;
        private TabPage tabPageMP3Tag;
        private TabPage tabPageVideoAudioConvert;
        private TabPage tabPageVideoEdit;
        private TabPage tabPageWebPConvert;
        private TabPage tabPageImageResize;
        private UI.Frames.UC_Batchdownload uC_Batchdownload;
        private UI.Frames.UC_Rename uC_RenameFiles;
        private TabPage tabPageDirectoryInfo;
        private UI.Frames.UC_Move uC_MoveFiles;
        private UI.Frames.UC_MP3TagEditor uC_mP3TagEditor;
        private UI.Frames.UC_DirectoryInfo uC_DirectoryInfo;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem extrasToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private UI.Frames.UC_VideoToAudio uC_VideoToAudio;
        private UI.Frames.UC_VideoCut uC_VideoCut;
        private UI.Frames.UC_AutoDownload uC_AutoDownload;
        private UI.Frames.UC_WebPConvert uC_WebPConvert;
        private UI.Frames.UC_ImageResize uC_ImageResize;
        private TabPage tabPageConvertToMp3;
        private UC_ConvertToMp3 uC_ConvertToMp3;
        private TabPage tabPageBskySort;
        private UC_BskySort uC_BskySort;
    }
}