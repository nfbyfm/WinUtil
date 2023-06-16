using Serilog;
using Serilog.Sinks.RichTextBoxForms.Themes;
using System.Reflection;
using WinUtil.UI.Dialogs;
using YACUF.Extensions;

namespace WinUtil
{
    /// <summary>
    /// the main window of the application
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// constructor of the main window of the application
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            //check settings and update UI elements
            CheckSettings();

            //setup the logger (send / display in the rich textbox)
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.RichTextBox(this.outputRichTextBox,
                    theme: ThemePresets.Dark,
                    outputTemplate: "[{Timestamp:yyyy.MM.dd HH:mm:ss}] [{Level:u3}]:  {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            Log.Information("Application started.");
        }


        #region UI input event listeners
        /// <summary>
        /// closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// shows the about dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create strings for message box
            string dialogTitle = "WinUtil";
            string dialogMessage = "Windows desktop application with various utility functions." + Environment.NewLine;

            try
            {
                Version? appVersion = Assembly.GetExecutingAssembly().GetName().Version;

                if (appVersion != null)
                    dialogMessage += Environment.NewLine + "Version: " + appVersion.ToString();
            }
            catch (Exception ex)
            {
                Log.Error("Failed to get the version of the current application: " + ex.Message);
            }

            dialogMessage += Environment.NewLine + "https://github.com/nfbyfm/WinUtil";

            //show messagebox
            MessageBox.Show(dialogMessage, dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// shows the settings dialog to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsDialog setDi = new();

            if (setDi.ShowDialog() == DialogResult.OK)
                CheckSettings();
        }

        #endregion

        #region UI logic functions

        /// <summary>
        /// checks settings and updates the UI accordingly
        /// </summary>
        private void CheckSettings()
        {
            bool ffmpegFound = false;
            string? ffmpegFilePath = Properties.Settings.Default.ffmpegFilePath;

            if (ffmpegFilePath.IsValidString())
                ffmpegFound = File.Exists(ffmpegFilePath);

            if (!ffmpegFound)
            {
                mainTabControl.TabPages.Remove(tabPageVideoAudioConvert);
                mainTabControl.TabPages.Remove(tabPageVideoEdit);
            }
            else
            {
                if (!mainTabControl.TabPages.Contains(tabPageVideoAudioConvert))
                    mainTabControl.TabPages.Add(tabPageVideoAudioConvert);

                if (!mainTabControl.TabPages.Contains(tabPageVideoEdit))
                    mainTabControl.TabPages.Add(tabPageVideoEdit);
            }
        }
        #endregion
    }
}