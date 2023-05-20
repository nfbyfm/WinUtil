using Serilog;
using WinUtil.Extensions;
using WinUtil.Model;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// Usercontrol for renaming many files in a directory
    /// </summary>
    public partial class UC_Rename : UserControl
    {
        /// <summary>
        /// Constructor for usercontrol for renaming many files in a directory
        /// </summary>
        public UC_Rename()
        {
            InitializeComponent();

            OperationOptionsChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// lets the user change the target direcory via folder bvrowser dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDi = new()
            {
                InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory),
                ShowNewFolderButton = true
            };

            if (fDi.ShowDialog() == DialogResult.OK)
            {
                tB_TragetDirectory.Text = fDi.SelectedPath;
                UpdateFileList(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// updates the current list of files to rename
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void UpdateFileList(object sender, EventArgs eventArgs)
        {
            lV_Files.Clear();

            if (GetFileList(out List<string> fileList))
            {
                for (int i = 0; i < fileList.Count; i++)
                {
                    lV_Files.Items.Add(fileList[i]);
                }
            }
        }

        /// <summary>
        /// reacts to the change of the filter for the files in the target directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileFilter_CheckedChanged(object sender, EventArgs e)
        {
            bool filterFile = cB_FileFilter.Checked;

            l_FilterExtension.Enabled = !filterFile;
            tB_ExtensionFilter.Enabled = !filterFile;

            UpdateFileList(sender, e);
        }

        /// <summary>
        /// reacts to changes in the file operation options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationOptionsChanged(object sender, EventArgs e)
        {
            bool removeText = cB_RemoveText.Checked;

            l_RemoveText.Enabled = removeText;
            tB_RemovalText.Enabled = removeText;

            bool replaceText = cB_ReplaceText.Checked;

            l_ReplaceReplacement.Enabled = replaceText;
            l_ReplaceSearchText.Enabled = replaceText;
            tB_ReplaceSearchText.Enabled = replaceText;
            tB_ReplaceReplacementText.Enabled = replaceText;

            b_Start.Enabled = (removeText || replaceText);
        }

        /// <summary>
        /// starts the renaming of files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            UpdateFileList(sender, e);

            if (GetFileList(out List<string> fileList))
            {
                List<RenameFileInfo> dataList = fileList.ToRenameFileInfoList();

                bool neededChangeDetected = false;

                //remove text
                if (cB_RemoveText.Checked)
                    if (dataList.ReplaceText(tB_RemovalText.Text, ""))
                        neededChangeDetected = true;

                //replace texts
                if (cB_ReplaceText.Checked)
                    if (dataList.ReplaceText(tB_ReplaceSearchText.Text, tB_ReplaceReplacementText.Text))
                        neededChangeDetected = true;

                if (neededChangeDetected)
                {
                    //actually rename all files in the current list of files
                    Parallel.ForEach(dataList, file =>
                    {
                        try
                        {
                            if (file.SourecFilePath != file.DestinationFilePath)
                            {
                                File.Move(file.SourecFilePath, file.DestinationFilePath);
                                Log.Information("Renamed '" + file.SourecFilePath + "' to '" + file.DestinationFilePath + "'.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Failed to rename '" + file.SourecFilePath + "' to '" + file.DestinationFilePath + "': " + ex.Message);
                        }
                    });

                    UpdateFileList(sender, e);
                }
                else
                {
                    Log.Warning("Couldn't find any files that meet the renaming criteria.");
                }
            }
        }

        /// <summary>
        /// tries to get the list of files based on the current user inputs
        /// </summary>
        /// <param name="fileList"></param>
        /// <returns></returns>
        private bool GetFileList(out List<string> fileList)
        {
            fileList = new();

            string targetDirectory = tB_TragetDirectory.Text;

            if (Directory.Exists(targetDirectory))
            {
                string searchPattern = "*.*";

                if (!cB_FileFilter.Checked)
                {
                    string tmpPattern = tB_ExtensionFilter.Text;

                    if (tmpPattern.StartsWith("*."))
                    {
                        searchPattern = tmpPattern;
                    }
                    else
                    {
                        if (tmpPattern.StartsWith("."))
                        {
                            searchPattern = "*" + tmpPattern;
                        }
                        else
                        {
                            searchPattern = "*." + tmpPattern;
                        }
                    }
                }

                SearchOption searchOpt = SearchOption.TopDirectoryOnly;

                if (cB_DirectoryRecursive.Checked)
                {
                    searchOpt = SearchOption.AllDirectories;
                }

                fileList = Directory.GetFiles(targetDirectory, searchPattern, searchOpt).ToList();

                if (fileList.Count <= 0)
                {
                    Log.Error("Directory '" + targetDirectory + "' doesn't contain any files matching the current search options.");
                }
            }
            else
            {
                Log.Error("Directory '" + targetDirectory + "' doesn't exist / no files could be found.");
            }

            return fileList.Count > 0;
        }
    }
}
