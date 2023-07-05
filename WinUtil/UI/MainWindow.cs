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
        #region private variables

        private const int autoDownloadTabIndex = 0;
        private const int batchDownloadTabIndex = 1;
        private const int renameTabIndex = 2;
        private const int moveFilesTabIndex = 3;
        private const int mp3EditTabIndex = 4;
        private const int directoryInfoTabIndex = 5;
        private const int videoToAutdioTabIndex = 6;
        private const int videoEditTabIndex = 7;
        private const int webPConvertTabIndex = 8;

        #endregion

        /// <summary>
        /// constructor of the main window of the application
        /// </summary>
        /// <param name="args">optional arguments</param>
        public MainWindow(string[] args)
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

            //parse the optional arguments
            ParseStartupArguments(args);
        }

        #region startup parameter functions
        /// <summary>
        /// parses data from the startup parameters (if non existant, checks clipboard as well)
        /// </summary>
        /// <param name="args"></param>
        private void ParseStartupArguments(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    if (args.Length > 1)
                        HandleMultipleStartupArguments(args);
                    else
                        HandleSingleStartupArgument(args[0]);
                }
                else if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();

                    if (clipboardText.Contains(Environment.NewLine))
                        HandleMultipleStartupArguments(clipboardText.Split(Environment.NewLine));
                    else
                        HandleSingleStartupArgument(clipboardText);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Failed to process startup parameters: {ex.Message}");
            }
        }
        
        /// <summary>
        /// handles single startup argument
        /// </summary>
        /// <param name="argument"></param>
        private void HandleSingleStartupArgument(string argument)
        {
            if (argument.IsURL())
            {
                uC_Batchdownload.AddURL(argument);
                mainTabControl.SelectedIndex = batchDownloadTabIndex;
            }
            else if (Directory.Exists(argument))
            {
                uC_DirectoryInfo.SetDirectoryPath(argument);
                uC_RenameFiles.SetDirectoryPath(argument);
                uC_Batchdownload.SetTargetDirectory(argument);
                uC_MoveFiles.SetTargetDirectory(argument);

                mainTabControl.SelectedIndex = directoryInfoTabIndex;
            }
            else if (File.Exists(argument))
            {
                switch (argument.GetBasicFileType())
                {
                    case YACUF.Models.BasicFileType.Text:
                        //load the first line of the text file -> then decide what to do with it
                        string firstLine;

                        using (StreamReader reader = new(argument))
                        {
                            firstLine = reader.ReadLine() ?? "";
                        }

                        if (firstLine.IsValidString())
                        {
                            if (firstLine.IsURL())
                            {
                                uC_Batchdownload.LoadFromFile(argument);
                            }
                            else if (firstLine.EndsWith(".mp3"))
                            {
                                uC_mP3TagEditor.LoadFromFile(argument);
                                mainTabControl.SelectedIndex = mp3EditTabIndex;
                            }
                            else
                            {
                                uC_MoveFiles.LoadFromFile(argument);
                                mainTabControl.SelectedIndex = moveFilesTabIndex;
                            }
                        }
                        else
                        {
                            uC_MoveFiles.AddFilePath(argument);
                            mainTabControl.SelectedIndex = moveFilesTabIndex;
                        }
                        break;

                    case YACUF.Models.BasicFileType.MP3:

                        uC_mP3TagEditor.AddFilePath(argument);
                        mainTabControl.SelectedIndex = mp3EditTabIndex;
                        break;

                    case YACUF.Models.BasicFileType.Video:

                        if (File.Exists(Properties.Settings.Default.ffmpegFilePath))
                        {
                            //add to video convert and video edit usercontrols
                            uC_VideoToAudio.SetSourceFile(argument);
                            uC_VideoCut.SetSourceFile(argument);
                            mainTabControl.SelectedIndex = videoToAutdioTabIndex;
                        }
                        else
                        {
                            //add to move 
                            uC_MoveFiles.AddFilePath(argument);
                            mainTabControl.SelectedIndex = moveFilesTabIndex;
                        }
                        break;
                    default:

                        //unknown -> add to move
                        uC_MoveFiles.AddFilePath(argument);
                        mainTabControl.SelectedIndex = moveFilesTabIndex;
                        break;
                }
            }
            else
            {
                Log.Debug($"Got startup parameter ({argument}) but can't find any use for it.");
                mainTabControl.SelectedIndex = autoDownloadTabIndex;
            }
        }

        /// <summary>
        /// handles a list of startup arguments
        /// </summary>
        /// <param name="arguments"></param>
        private void HandleMultipleStartupArguments(string[] arguments)
        {
            //take a look at first element -> handle similar to single argument method

            if (arguments.Length > 0)
            {
                //search through list of arguments for one that is valid / can be used in any of the user controls
                for (int i = 0; i < arguments.Length; i++)
                {
                    string arg = arguments[i];

                    if (arg.IsValidString())
                    {
                        Log.Debug($"Startup parameter at index {i} is a valid string ({arg}).");
                        if (arg.IsURL())
                        {
                            uC_Batchdownload.AddURLs(arguments);
                            mainTabControl.SelectedIndex = 0;
                            break;
                        }
                        else if (Directory.Exists(arg))
                        {
                            //list of directories? -> doesn't make much sense -> use only the first one 
                            uC_DirectoryInfo.SetDirectoryPath(arg);
                            uC_RenameFiles.SetDirectoryPath(arg);
                            uC_Batchdownload.SetTargetDirectory(arg);
                            uC_MoveFiles.SetTargetDirectory(arg);

                            mainTabControl.SelectedIndex = 4;
                            break;
                        }
                        else if (File.Exists(arg))
                        {
                            if (arg.GetBasicFileType() == YACUF.Models.BasicFileType.MP3)
                            {
                                //list of mp3 files
                                uC_mP3TagEditor.AddFilePaths(arguments);
                                mainTabControl.SelectedIndex = 3;
                            }
                            else
                            {
                                //unknown / text or multiple video files -> add to move and rename
                                uC_MoveFiles.AddFilePaths(arguments);
                                mainTabControl.SelectedIndex = 2;
                            }

                            break;
                        }
                        else
                        {
                            Log.Debug($"Got {arguments.Length} startup arguments. Argument at index {i} couldn't be categorized ({arg}). Searching for next usable one.");
                        }
                    }
                }
            }
        }

        #endregion

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
                mainTabControl.TabPages.Remove(tabPageWebPConvert);
            }
            else
            {
                if (!mainTabControl.TabPages.Contains(tabPageVideoAudioConvert))
                    mainTabControl.TabPages.Add(tabPageVideoAudioConvert);

                if (!mainTabControl.TabPages.Contains(tabPageVideoEdit))
                    mainTabControl.TabPages.Add(tabPageVideoEdit);

                if(!mainTabControl.TabPages.Contains(tabPageWebPConvert))
                    mainTabControl.TabPages.Add(tabPageWebPConvert);
            }

            uC_AutoDownload.SettingsHaveChanged();
            uC_Batchdownload.SettingsHaveChanged();
        }
        #endregion
    }
}