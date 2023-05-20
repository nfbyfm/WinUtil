using Serilog;
using System.Security.Cryptography;
using WinUtil.Extensions;
using WinUtil.Model;
using WinUtil.Util;
using YACUF.Utilities;

namespace WinUtil.UI.Frames
{
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

                        if(filePath.IsValidString())
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

        //todo: support drag and drop of text files

        private void Select_Click(object sender, EventArgs e)
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
        }

        /// <summary>
        /// sets list of urls from clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rTB_Urls.Text = Clipboard.GetText();
            }
            else
            {
                Log.Error("Clipboard doesn't contain any text.");
            }
        }

        /// <summary>
        /// starts the download
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            List<string> urls = rTB_Urls.Lines.ToList();

            if (urls.HasElements(out int elemCount))
            {
                string targetDirectory = tB_DownloadDirectory.Text;

                if (targetDirectory.IsValidString())
                {
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

                        bool createNewFileName = rB_CreateNewFileNames.Checked;
                        string prefix = tB_Prefix.Text;
                        string suffix = tB_Suffix.Text;
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

                            dataList.Add(new(urls[i], filePath));

                            Log.Debug("Added the following file to the download list: url: '" + urls[i] + "'; filepath: '" + filePath + "'.");
                        }

                        Log.Information("Starting download of " + dataList.Count + " files ...");

                        //download all files
                        try
                        {
                            Task.Run(async () => await DownloadUtil.DownloadUrlsAsync(dataList, 10));
                        }
                        catch (Exception ex)
                        {
                            Log.Error("An error occured while downloading files: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                Log.Error("Current list of urls is empty.");
            }
        }
    }
}
