using Serilog;
using WinUtil.Model;
using WinUtil.Util;
using YACUF.Utilities;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// Usercontrol for downloading images from a website
    /// </summary>
    public partial class UC_ImageDownload : UserControl
    {
        /// <summary>
        /// constructor for usercontrol (for downloading images from a website)
        /// </summary>
        public UC_ImageDownload()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event listener for the 'select' directory button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDirectory_Click(object sender, EventArgs e)
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
        /// starts the download
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            //check if all informations are there
            bool prefixSet = tB_UrlPrefix.Text.IsValidString();
            bool suffixSet = TB_UrlSuffix.Text.IsValidString();
            bool numbersOk = nUD_StartNumber.Value < nUD_EndNumber.Value;
            bool directorySet = tB_DownloadDirectory.Text.IsValidString();

            bool downloadPossible = prefixSet && suffixSet && numbersOk && directorySet;

            if (downloadPossible)
            {
                //check if the directory exists (try to create if not)
                string targetDirectory = tB_DownloadDirectory.Text;
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
                        Log.Error("Failed to create the directory '" + targetDirectory + "': " + ex.Message);
                        directoryOk = false;
                    }
                }

                //if directory exists: create list of files, then execute the downloads
                if (directoryOk)
                {
                    //create list of files to download
                    string prefix = tB_UrlPrefix.Text;
                    string suffix = TB_UrlSuffix.Text;

                    List<DownloadFileInfo> dataList = new();

                    for (int i = (int)nUD_StartNumber.Value; i <= (int)nUD_EndNumber.Value; i++)
                    {
                        string url = prefix + i.ToString() + suffix;
                        string filePath = prefix.Remove(0, prefix.LastIndexOf(@"/")+1) + i.ToString() + suffix;
                        filePath = Path.Combine(targetDirectory, filePath);

                        Log.Debug("Added the following file to the download list: url: '" + url + "'; filepath: '" + filePath + "'.");

                        dataList.Add(new(url, filePath));
                    }

                    Log.Information("Starting download of " + dataList.Count + " files ...");

                    //download all files
                    try
                    {
                        Task.Run(async () => await DownloadUtil.DownloadUrlsAsync(dataList, 10));
                        //var task = Task.Run(async () => await DownloadUtil.DownloadUrlsAsync(dataList, 10));
                        //task.Wait();
                    }
                    catch (Exception ex)
                    {
                        Log.Error("An error occured while downloading files: " + ex.Message);
                    }
                }
            }
            else
            {
                string errorMsg = "Download of images is not possible. ";

                if (!prefixSet)
                    errorMsg += "Prefix isn't set. ";

                if (!suffixSet)
                    errorMsg += "Suffix isn't set. ";

                if (!numbersOk)
                    errorMsg += "End number ("+nUD_EndNumber.Value.ToString()+") is smaller than or equal to start number ("+nUD_StartNumber.Value.ToString()+"). ";

                if (!directorySet)
                    errorMsg += "Download directory isn't set. ";

                Log.Error(errorMsg);
            }
        }

    }
}
