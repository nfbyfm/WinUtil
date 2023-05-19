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
            menuStrip1 = new MenuStrip();
            statusStrip1 = new StatusStrip();
            splitContainer1 = new SplitContainer();
            mainTabControl = new TabControl();
            tabPageImageDownload = new TabPage();
            tabPageBatchDownload = new TabPage();
            tabPageRename = new TabPage();
            tabPageMove = new TabPage();
            tabPageMP3Tag = new TabPage();
            groupBox1 = new GroupBox();
            outputRichTextBox = new RichTextBox();
            uC_ImageDownload1 = new UI.Frames.UC_ImageDownload();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            mainTabControl.SuspendLayout();
            tabPageImageDownload.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
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
            splitContainer1.Size = new Size(800, 404);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 2;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPageImageDownload);
            mainTabControl.Controls.Add(tabPageBatchDownload);
            mainTabControl.Controls.Add(tabPageRename);
            mainTabControl.Controls.Add(tabPageMove);
            mainTabControl.Controls.Add(tabPageMP3Tag);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 266);
            mainTabControl.TabIndex = 0;
            // 
            // tabPageImageDownload
            // 
            tabPageImageDownload.Controls.Add(uC_ImageDownload1);
            tabPageImageDownload.Location = new Point(4, 21);
            tabPageImageDownload.Name = "tabPageImageDownload";
            tabPageImageDownload.Padding = new Padding(3);
            tabPageImageDownload.Size = new Size(792, 241);
            tabPageImageDownload.TabIndex = 0;
            tabPageImageDownload.Text = "Image download";
            tabPageImageDownload.UseVisualStyleBackColor = true;
            // 
            // tabPageBatchDownload
            // 
            tabPageBatchDownload.Location = new Point(4, 21);
            tabPageBatchDownload.Name = "tabPageBatchDownload";
            tabPageBatchDownload.Padding = new Padding(3);
            tabPageBatchDownload.Size = new Size(792, 241);
            tabPageBatchDownload.TabIndex = 3;
            tabPageBatchDownload.Text = "Batch download";
            tabPageBatchDownload.UseVisualStyleBackColor = true;
            // 
            // tabPageRename
            // 
            tabPageRename.Location = new Point(4, 21);
            tabPageRename.Name = "tabPageRename";
            tabPageRename.Padding = new Padding(3);
            tabPageRename.Size = new Size(792, 241);
            tabPageRename.TabIndex = 1;
            tabPageRename.Text = "Rename";
            tabPageRename.UseVisualStyleBackColor = true;
            // 
            // tabPageMove
            // 
            tabPageMove.Location = new Point(4, 21);
            tabPageMove.Name = "tabPageMove";
            tabPageMove.Padding = new Padding(3);
            tabPageMove.Size = new Size(792, 241);
            tabPageMove.TabIndex = 2;
            tabPageMove.Text = "Move";
            tabPageMove.UseVisualStyleBackColor = true;
            // 
            // tabPageMP3Tag
            // 
            tabPageMP3Tag.Location = new Point(4, 21);
            tabPageMP3Tag.Name = "tabPageMP3Tag";
            tabPageMP3Tag.Padding = new Padding(3);
            tabPageMP3Tag.Size = new Size(792, 241);
            tabPageMP3Tag.TabIndex = 4;
            tabPageMP3Tag.Text = "mp3 tags";
            tabPageMP3Tag.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(outputRichTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ouput";
            // 
            // outputRichTextBox
            // 
            outputRichTextBox.Dock = DockStyle.Fill;
            outputRichTextBox.Location = new Point(3, 17);
            outputRichTextBox.Name = "outputRichTextBox";
            outputRichTextBox.Size = new Size(794, 114);
            outputRichTextBox.TabIndex = 0;
            outputRichTextBox.Text = "";
            // 
            // uC_ImageDownload1
            // 
            uC_ImageDownload1.Dock = DockStyle.Fill;
            uC_ImageDownload1.Location = new Point(3, 3);
            uC_ImageDownload1.Name = "uC_ImageDownload1";
            uC_ImageDownload1.Size = new Size(786, 235);
            uC_ImageDownload1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Windows Utility Tool";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            mainTabControl.ResumeLayout(false);
            tabPageImageDownload.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private TabControl mainTabControl;
        private TabPage tabPageImageDownload;
        private TabPage tabPageRename;
        private GroupBox groupBox1;
        private RichTextBox outputRichTextBox;
        private TabPage tabPageMove;
        private TabPage tabPageBatchDownload;
        private TabPage tabPageMP3Tag;
        private UI.Frames.UC_ImageDownload uC_ImageDownload1;
    }
}