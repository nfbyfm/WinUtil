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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            extrasToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            splitContainer1 = new SplitContainer();
            mainTabControl = new TabControl();
            tabPageBatchDownload = new TabPage();
            uC_Batchdownload = new UI.Frames.UC_Batchdownload();
            tabPageRename = new TabPage();
            uC_RenameFiles = new UI.Frames.UC_Rename();
            tabPageMove = new TabPage();
            uC_MoveFiles = new UI.Frames.UC_Move();
            tabPageMP3Tag = new TabPage();
            uC_mP3TagEditor = new UI.Frames.UC_MP3TagEditor();
            tabPageDirectoryInfo = new TabPage();
            uC_DirectoryInfo = new UI.Frames.UC_DirectoryInfo();
            tabPageVideoAudioConvert = new TabPage();
            tabPageVideoEdit = new TabPage();
            groupBox1 = new GroupBox();
            outputRichTextBox = new RichTextBox();
            uC_VideoToAudio = new UI.Frames.UC_VideoToAudio();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            mainTabControl.SuspendLayout();
            tabPageBatchDownload.SuspendLayout();
            tabPageRename.SuspendLayout();
            tabPageMove.SuspendLayout();
            tabPageMP3Tag.SuspendLayout();
            tabPageDirectoryInfo.SuspendLayout();
            tabPageVideoAudioConvert.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, extrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(556, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(31, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(126, 22);
            quitToolStripMenuItem.Text = "&Quit";
            quitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // extrasToolStripMenuItem
            // 
            extrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, toolStripSeparator1, settingsToolStripMenuItem });
            extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            extrasToolStripMenuItem.Size = new Size(42, 20);
            extrasToolStripMenuItem.Text = "&Extras";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.F1;
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "&Settings";
            settingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 662);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(556, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(mainTabControl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(556, 638);
            splitContainer1.SplitterDistance = 420;
            splitContainer1.TabIndex = 2;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPageBatchDownload);
            mainTabControl.Controls.Add(tabPageRename);
            mainTabControl.Controls.Add(tabPageMove);
            mainTabControl.Controls.Add(tabPageMP3Tag);
            mainTabControl.Controls.Add(tabPageDirectoryInfo);
            mainTabControl.Controls.Add(tabPageVideoAudioConvert);
            mainTabControl.Controls.Add(tabPageVideoEdit);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Multiline = true;
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(556, 420);
            mainTabControl.TabIndex = 0;
            // 
            // tabPageBatchDownload
            // 
            tabPageBatchDownload.Controls.Add(uC_Batchdownload);
            tabPageBatchDownload.Location = new Point(4, 21);
            tabPageBatchDownload.Name = "tabPageBatchDownload";
            tabPageBatchDownload.Padding = new Padding(3);
            tabPageBatchDownload.Size = new Size(548, 395);
            tabPageBatchDownload.TabIndex = 3;
            tabPageBatchDownload.Text = "batch download files";
            tabPageBatchDownload.UseVisualStyleBackColor = true;
            // 
            // uC_Batchdownload
            // 
            uC_Batchdownload.Dock = DockStyle.Fill;
            uC_Batchdownload.Location = new Point(3, 3);
            uC_Batchdownload.Name = "uC_Batchdownload";
            uC_Batchdownload.Size = new Size(542, 389);
            uC_Batchdownload.TabIndex = 0;
            // 
            // tabPageRename
            // 
            tabPageRename.Controls.Add(uC_RenameFiles);
            tabPageRename.Location = new Point(4, 21);
            tabPageRename.Name = "tabPageRename";
            tabPageRename.Padding = new Padding(3);
            tabPageRename.Size = new Size(548, 395);
            tabPageRename.TabIndex = 1;
            tabPageRename.Text = "rename files";
            tabPageRename.UseVisualStyleBackColor = true;
            // 
            // uC_RenameFiles
            // 
            uC_RenameFiles.Dock = DockStyle.Fill;
            uC_RenameFiles.Location = new Point(3, 3);
            uC_RenameFiles.Name = "uC_RenameFiles";
            uC_RenameFiles.Size = new Size(542, 389);
            uC_RenameFiles.TabIndex = 0;
            // 
            // tabPageMove
            // 
            tabPageMove.Controls.Add(uC_MoveFiles);
            tabPageMove.Location = new Point(4, 21);
            tabPageMove.Name = "tabPageMove";
            tabPageMove.Padding = new Padding(3);
            tabPageMove.Size = new Size(548, 395);
            tabPageMove.TabIndex = 2;
            tabPageMove.Text = "move files";
            tabPageMove.UseVisualStyleBackColor = true;
            // 
            // uC_MoveFiles
            // 
            uC_MoveFiles.Dock = DockStyle.Fill;
            uC_MoveFiles.Location = new Point(3, 3);
            uC_MoveFiles.Name = "uC_MoveFiles";
            uC_MoveFiles.Size = new Size(542, 389);
            uC_MoveFiles.TabIndex = 0;
            // 
            // tabPageMP3Tag
            // 
            tabPageMP3Tag.Controls.Add(uC_mP3TagEditor);
            tabPageMP3Tag.Location = new Point(4, 21);
            tabPageMP3Tag.Name = "tabPageMP3Tag";
            tabPageMP3Tag.Padding = new Padding(3);
            tabPageMP3Tag.Size = new Size(548, 395);
            tabPageMP3Tag.TabIndex = 4;
            tabPageMP3Tag.Text = "edit mp3 tags";
            tabPageMP3Tag.UseVisualStyleBackColor = true;
            // 
            // uC_mP3TagEditor
            // 
            uC_mP3TagEditor.Dock = DockStyle.Fill;
            uC_mP3TagEditor.Location = new Point(3, 3);
            uC_mP3TagEditor.Name = "uC_mP3TagEditor";
            uC_mP3TagEditor.Size = new Size(542, 389);
            uC_mP3TagEditor.TabIndex = 0;
            // 
            // tabPageDirectoryInfo
            // 
            tabPageDirectoryInfo.Controls.Add(uC_DirectoryInfo);
            tabPageDirectoryInfo.Location = new Point(4, 21);
            tabPageDirectoryInfo.Name = "tabPageDirectoryInfo";
            tabPageDirectoryInfo.Padding = new Padding(3);
            tabPageDirectoryInfo.Size = new Size(548, 395);
            tabPageDirectoryInfo.TabIndex = 5;
            tabPageDirectoryInfo.Text = "directory info";
            tabPageDirectoryInfo.UseVisualStyleBackColor = true;
            // 
            // uC_DirectoryInfo
            // 
            uC_DirectoryInfo.Dock = DockStyle.Fill;
            uC_DirectoryInfo.Location = new Point(3, 3);
            uC_DirectoryInfo.Name = "uC_DirectoryInfo";
            uC_DirectoryInfo.Size = new Size(542, 389);
            uC_DirectoryInfo.TabIndex = 0;
            // 
            // tabPageVideoAudioConvert
            // 
            tabPageVideoAudioConvert.Controls.Add(uC_VideoToAudio);
            tabPageVideoAudioConvert.Location = new Point(4, 21);
            tabPageVideoAudioConvert.Name = "tabPageVideoAudioConvert";
            tabPageVideoAudioConvert.Padding = new Padding(3);
            tabPageVideoAudioConvert.Size = new Size(548, 395);
            tabPageVideoAudioConvert.TabIndex = 2;
            tabPageVideoAudioConvert.Text = "video to audio convert";
            tabPageVideoAudioConvert.UseVisualStyleBackColor = true;
            // 
            // tabPageVideoEdit
            // 
            tabPageVideoEdit.Location = new Point(4, 21);
            tabPageVideoEdit.Name = "tabPageVideoEdit";
            tabPageVideoEdit.Padding = new Padding(3);
            tabPageVideoEdit.Size = new Size(548, 395);
            tabPageVideoEdit.TabIndex = 2;
            tabPageVideoEdit.Text = "video edit";
            tabPageVideoEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(outputRichTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ouput";
            // 
            // outputRichTextBox
            // 
            outputRichTextBox.Dock = DockStyle.Fill;
            outputRichTextBox.Location = new Point(3, 17);
            outputRichTextBox.Name = "outputRichTextBox";
            outputRichTextBox.Size = new Size(550, 194);
            outputRichTextBox.TabIndex = 0;
            outputRichTextBox.Text = "";
            // 
            // uC_VideoToAudio
            // 
            uC_VideoToAudio.Dock = DockStyle.Fill;
            uC_VideoToAudio.Location = new Point(3, 3);
            uC_VideoToAudio.Name = "uC_VideoToAudio";
            uC_VideoToAudio.Size = new Size(542, 389);
            uC_VideoToAudio.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 684);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Windows Utility Tool";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            mainTabControl.ResumeLayout(false);
            tabPageBatchDownload.ResumeLayout(false);
            tabPageRename.ResumeLayout(false);
            tabPageMove.ResumeLayout(false);
            tabPageMP3Tag.ResumeLayout(false);
            tabPageDirectoryInfo.ResumeLayout(false);
            tabPageVideoAudioConvert.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TabPage tabPageBatchDownload;
        private TabPage tabPageMP3Tag;
        private TabPage tabPageVideoAudioConvert;
        private TabPage tabPageVideoEdit;
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
    }
}