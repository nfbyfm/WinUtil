using Serilog;
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
        public UC_Batchdownload()
        {
            InitializeComponent();

            rTB_Urls.DragDrop += RTB_Urls_DragDrop;
            rTB_Urls.AllowDrop = true;

            NamingSettingsChanged(this, EventArgs.Empty);
        }

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
            /*
            //create and show file select dialog
            OpenFileDialog oDi = new()
            {
                RestoreDirectory = true,
                Filter = "txt-file|*.txt",
                Multiselect = false
            };

            if (oDi.ShowDialog() == DialogResult.OK)
            {
                //try to load text from file into rich tectbox control
                try
                {
                    rTB_Urls.Text = File.ReadAllText(oDi.FileName);
                }
                catch (Exception ex)
                {
                    Log.Error("Failed to load text from file '" + oDi.FileName + "': " + ex.Message);
                }
            }
            */
        }

        /// <summary>
        /// sets list of urls from clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromClipboard_Click(object sender, EventArgs e)
        {
            rTB_Urls.SetFileListFromClipboard();
            /*
            if (Clipboard.ContainsText())
            {
                rTB_Urls.Text = Clipboard.GetText();
            }
            else
            {
                Log.Error("Clipboard doesn't contain any text.");
            }
            */
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
    }
}
