using Serilog;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using WinUtil.Extensions;
using WinUtil.Model;
using WinUtil.UI.Dialogs;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// Usercontrol for batch downloading files
    /// </summary>
    public partial class UC_Batchdownload : UserControl
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AddClipboardFormatListener(IntPtr hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        public UC_Batchdownload()
        {
            InitializeComponent();

            rTB_Urls.DragDrop += RTB_Urls_DragDrop;
            rTB_Urls.AllowDrop = true;

            NamingSettingsChanged(this, EventArgs.Empty);
        }

        #region internal setter functions
        /// <summary>
        /// adds single url to the list
        /// </summary>
        /// <param name="urlString"></param>
        internal void AddURL(string urlString)
        {
            if (rTB_Urls.Lines.Length > 0)
                rTB_Urls.Text += Environment.NewLine;

            rTB_Urls.Text += urlString + Environment.NewLine;
        }

        /// <summary>
        /// adds a list of urls
        /// </summary>
        /// <param name="urls"></param>
        internal void AddURLs(string[] urls)
        {
            if (urls.Length > 0)
            {
                if (rTB_Urls.Lines.Length > 0)
                    rTB_Urls.Text += Environment.NewLine;

                foreach (string urlString in urls)
                    rTB_Urls.Text += urlString + Environment.NewLine;
            }
        }

        /// <summary>
        /// sets the list of files based on file contents
        /// </summary>
        /// <param name="filePath"></param>
        internal void LoadFromFile(string filePath)
        {
            rTB_Urls.SetPathListFromTextFile(filePath);
        }

        /// <summary>
        /// sets the download directory path
        /// </summary>
        /// <param name="directoryPath"></param>
        internal void SetTargetDirectory(string directoryPath)
        {
            tB_DownloadDirectory.Text = directoryPath;
        }
        #endregion

        #region UI input event listeners
        /// <summary>
        /// reacts to drag and drop event of the rich textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RTB_Urls_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                object filename = e.Data.GetData("FileDrop");
                if (filename != null)
                {
                    string[]? list = (string[])filename;

                    if (list != null && list.HasElements())
                    {
                        string filePath = list[0];

                        if (filePath.IsValidString())
                        {
                            rTB_Urls.Clear();

                            try
                            {
                                rTB_Urls.Text = File.ReadAllText(filePath);
                                rTB_Urls.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                            }
                            catch (Exception ex)
                            {
                                Log.Error("Failed to load text from file '" + filePath + "': " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// lets the user select the download directory via dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDownloadDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory),
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tB_DownloadDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// reacts to chenged in the radio buttons for the filename settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NamingSettingsChanged(object sender, EventArgs e)
        {
            bool createNewFileNames = rB_CreateNewFileNames.Checked;

            if (sender == rB_SameFileNames)
                createNewFileNames = !rB_SameFileNames.Checked;

            if (rB_SameFileNames.Checked != !createNewFileNames)
                rB_SameFileNames.Checked = !createNewFileNames;

            if (rB_CreateNewFileNames.Checked != createNewFileNames)
                rB_CreateNewFileNames.Checked = createNewFileNames;

            l_Prefix.Enabled = createNewFileNames;
            l_Suffix.Enabled = createNewFileNames;
            tB_Prefix.Enabled = createNewFileNames;
            tB_Suffix.Enabled = createNewFileNames;
        }

        /// <summary>
        /// loads urls from text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromFile_Click(object sender, EventArgs e)
        {
            rTB_Urls.SetFileListFromTextFile();
        }

        /// <summary>
        /// sets list of urls from clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromClipboard_Click(object sender, EventArgs e)
        {
            rTB_Urls.SetFileListFromClipboard();
        }

        /// <summary>
        /// starts the download
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            List<string> urls = rTB_Urls.Lines.ToList();
            string targetDirectory = tB_DownloadDirectory.Text;

            bool urlsOK = urls.HasElements(out int elemCount);
            bool directorySet = targetDirectory.IsValidString();

            if (urlsOK && directorySet)
            {
                //get parameters from UI
                bool overWriteExistingFiles = cB_OverWriteExistingFiles.Checked;
                int numberOfParallelDownloads = (int)Math.Max(1, nUD_ParallelDownloads.Value);
                bool createNewFileName = rB_CreateNewFileNames.Checked;
                string prefix = tB_Prefix.Text;
                string suffix = tB_Suffix.Text;

                //check if the directory exists and if not, try to create it
                bool directoryOk = true;
                if (!Directory.Exists(targetDirectory))
                {
                    try
                    {
                        Directory.CreateDirectory(targetDirectory);
                        Log.Debug("Download directory '" + targetDirectory + "' has been successfully created.");
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Failed to create the download directory '" + targetDirectory + "': " + ex.Message);
                        directoryOk = false;
                    }
                }

                if (directoryOk)
                {
                    List<DownloadFileInfo> dataList = new();
                    int maxDigits = elemCount.Digits();

                    for (int i = 0; i < elemCount; i++)
                    {
                        string filePath = urls[i].Remove(0, urls[i].LastIndexOf(@"/") + 1);

                        if (createNewFileName)
                        {
                            string fileExtension = filePath.Remove(0, filePath.LastIndexOf("."));

                            filePath = prefix + i.ToString("D" + maxDigits.ToString()) + suffix + fileExtension;
                        }

                        filePath = Path.Combine(targetDirectory, filePath);

                        if (File.Exists(filePath) && !overWriteExistingFiles)
                        {
                            Log.Debug("File '" + filePath + "' already exists (not added to the download list).");
                        }
                        else
                        {
                            dataList.Add(new(urls[i], filePath));
                            Log.Debug("Added the following file to the download list: url: '" + urls[i] + "'; filepath: '" + filePath + "'.");
                        }
                    }

                    if (dataList.Count > 0)
                    {
                        Log.Information("Starting download of " + dataList.Count + " files ...");

                        //download all files
                        try
                        {
                            Task.Run(async () => await DownloadUtil.DownloadUrlsAsync(dataList, numberOfParallelDownloads));
                        }
                        catch (Exception ex)
                        {
                            Log.Error("An error occured while downloading files: " + ex.Message);
                        }
                    }
                    else
                    {
                        Log.Information("All files have been (already) downloaded.");
                    }
                }
            }
            else
            {
                if (!urlsOK)
                    Log.Error("Current list of urls is empty.");

                if (!directorySet)
                    Log.Error("The target directroy hasn't been set yet.");
            }
        }

        /// <summary>
        /// lets user generate multiple URLs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateURLs_Click(object sender, EventArgs e)
        {
            GenerateURLsDialog urlDialog = new();

            if (urlDialog.ShowDialog() == DialogResult.OK)
            {
                if (urlDialog.GetURLList(out List<string> urls))
                    rTB_Urls.SetFilePathList(urls);
                else
                    Log.Error("Failed to generate list of URLs from dialog inputs.");
            }
        }

        /// <summary>
        /// allows the monitoring of the clipboard data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonitorClipboard_Click(object sender, EventArgs e)
        {
            _clipboardSurveillanceActive = !_clipboardSurveillanceActive;

            if (_clipboardSurveillanceActive)
                b_CheckClipboard.BackColor = Color.LightGreen;
            else
                b_CheckClipboard.BackColor = SystemColors.Control;

            if (_clipboardSurveillanceActive)
            {
                Log.Debug("Starting monitoring of clipboard.");
                AddClipboardFormatListener(this.Handle);
            }
            else
            {
                RemoveClipboardFormatListener(this.Handle);
                Log.Debug("Monitoring of clipboard stopped.");
            }
        }

        #endregion

        #region clipboard monitoring functions
        private bool _clipboardSurveillanceActive = false;
        private string prevClipboardString = "";
        private const int WM_CLIPBOARDUPDATE = 0x031D;

        private void AppendURLList(string newURL)
        {
            if (rTB_Urls.InvokeRequired)
            {
                rTB_Urls.Invoke(new MethodInvoker(() => { AppendURLList(newURL); }));
            }
            else
            {
                if (rTB_Urls.Lines.Length > 0)
                    rTB_Urls.Text += Environment.NewLine;

                rTB_Urls.Text += newURL;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_CLIPBOARDUPDATE:
                    IDataObject iData = Clipboard.GetDataObject();
                    if (iData.GetDataPresent(DataFormats.Text))
                    {
                        string data = (string)iData.GetData(DataFormats.Text);

                        if (data.IsURL() && prevClipboardString != data)
                        {
                            AppendURLList(data);
                            prevClipboardString = data;
                        }
                    }
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        #endregion
    }
}
