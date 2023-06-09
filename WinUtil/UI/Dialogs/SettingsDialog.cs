﻿using YACUF.Extensions;

namespace WinUtil.UI.Dialogs
{
    /// <summary>
    /// dialog for setting the application settings
    /// </summary>
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();

            LoadFromSettings();
        }

        #region user input event listeners
        /// <summary>
        /// lets the user select the file path of the ffmpeg executable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFFmpegPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDi = new()
            {
                RestoreDirectory = true,
                Filter = "executable|*.exe",
                Title = "Select path of ffmpeg executable",
                Multiselect = false
            };

            if (oDi.ShowDialog() == DialogResult.OK)
                tB_FFmpegPath.Text = oDi.FileName;
        }

        /// <summary>
        /// lets the user select the downlaod directory path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDownloadDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog oDi = new()
            {
                ShowNewFolderButton = true
            };

            if (oDi.ShowDialog() == DialogResult.OK)
                tB_DownloadDirectory.Text = oDi.SelectedPath;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SetSettingsFromUI();
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region settings functions

        /// <summary>
        /// loads current settings into the UI elements
        /// </summary>
        private void LoadFromSettings()
        {
            tB_FFmpegPath.Text = Properties.Settings.Default.ffmpegFilePath;
            string downloadDirectory = Properties.Settings.Default.downloadDirectroyPath;

            if (!downloadDirectory.IsValidString())
            {
                downloadDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                Properties.Settings.Default.downloadDirectroyPath = downloadDirectory;
                Properties.Settings.Default.Save();
            }

            tB_DownloadDirectory.Text = downloadDirectory;
        }

        /// <summary>
        /// set the settings values based on the UI element values
        /// </summary>
        private void SetSettingsFromUI()
        {
            Properties.Settings.Default.ffmpegFilePath = tB_FFmpegPath.Text;
            Properties.Settings.Default.downloadDirectroyPath = tB_DownloadDirectory.Text;
        }

        #endregion
    }
}
