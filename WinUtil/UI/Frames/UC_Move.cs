using Serilog;
using WinUtil.Extensions;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// UserControl for moving multiple files into one target directory
    /// </summary>
    public partial class UC_Move : UserControl
    {
        public UC_Move()
        {
            InitializeComponent();
        }

        #region user input event listeners

        /// <summary>
        /// sets the target directory by lketting the user choose the path via folder browser dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTargetDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDi = new()
            {
                ShowNewFolderButton = true
            };

            if (fDi.ShowDialog() == DialogResult.OK)
                tB_TargetDirectory.Text = fDi.SelectedPath;
        }

        /// <summary>
        /// sets/appends file list based on selection made by the user (via file selection dialog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileListFromFileDialog_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListViaFileDialog();
        }

        /// <summary>
        /// sets/appends file list based on selected directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileListFromDirectory_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListFromDirectoryExtended(false);
        }

        /// <summary>
        /// sets/appends file list based on text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileListFromFile_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListFromTextFile();
        }

        /// <summary>
        /// sets/appends list of files based on text currently in the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileListFromClipboard_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListFromClipboard();
        }

        /// <summary>
        /// moves the files in the current list to the selected directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            MoveFiles();
        }

        #endregion

        #region logic

        /// <summary>
        /// moves files in current list to another directory
        /// </summary>
        private void MoveFiles()
        {
            List<string> filePaths = rTB_FileList.Lines.ToList();
            string targetDirectory = tB_TargetDirectory.Text;
            bool fileCountOk = filePaths.Count > 0;
            bool targetDirectoryExists = Directory.Exists(targetDirectory);

            if (fileCountOk && targetDirectoryExists)
            {
                Log.Debug("Moving " + filePaths.Count + " files to '" + targetDirectory + "'.");

                foreach (string filePath in filePaths)
                {
                    if (File.Exists(filePath))
                    {
                        string fileName = Path.GetFileName(filePath);
                        string newFilePath = Path.Combine(targetDirectory, fileName);

                        try
                        {
                            File.Move(filePath, newFilePath);
                            Log.Information("Moved file '" + fileName + "' to new location '" + newFilePath + "'.");
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Failed to move '" + filePath + "' to '" + newFilePath + "': " + ex.Message);
                        }
                    }
                    else
                    {
                        Log.Warning("File '" + filePath + "' doesn't exist.");
                    }
                }

                //delete directories that are empty
                if (cB_DeleteEmptyDirecories.Checked)
                {
                    //create hashset / list with unique items of all directory paths of the moved files
                    HashSet<string> directoryList = new();

                    foreach (string filePath in filePaths)
                    {
                        try
                        {
                            string? direcoryPath = Path.GetDirectoryName(filePath);

                            if (direcoryPath.IsValidString())
                                directoryList.Add(direcoryPath);
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Failed to get the directory path from file '" + filePath + "': " + ex.Message);
                        }
                    }

                    //delete all empty directories
                    foreach (string directory in directoryList)
                        FileHandlingUtil.DeleteEmptyDirectories(directory);

                    Log.Information("Finished deletion of empty directories.");
                }

                Log.Information("Finished moving files.");
            }
            else
            {
                if (!fileCountOk)
                    Log.Error("There are currently no files defined.");

                if (!targetDirectoryExists)
                {
                    if (tB_TargetDirectory.Text.IsValidString())
                        Log.Error("The target directory hasn't been set yet.");
                    else
                        Log.Error("The target directory doesn't exist.");
                }
            }
        }

        #endregion

        #region internal setter functions
        /// <summary>
        /// loads list of files from a text file
        /// </summary>
        /// <param name="filePath"></param>
        internal void LoadFromFile(string filePath)
        {
            rTB_FileList.SetPathListFromTextFile(filePath);
        }

        /// <summary>
        /// adds file path to current list
        /// </summary>
        /// <param name="filePath"></param>
        internal void AddFilePath(string filePath)
        {
            if (rTB_FileList.Lines.Length > 0)
                rTB_FileList.Text += Environment.NewLine;

            rTB_FileList.Text += filePath + Environment.NewLine;
        }

        /// <summary>
        /// adds list of file paths to current list
        /// </summary>
        /// <param name="filePath"></param>
        internal void AddFilePaths(string[] filePaths)
        {
            if(filePaths.Length>0)
            {
                if (rTB_FileList.Lines.Length > 0)
                    rTB_FileList.Text += Environment.NewLine;

                foreach(string filePath in filePaths)
                    rTB_FileList.Text += filePath + Environment.NewLine;
            }            
        }

        /// <summary>
        /// sets the download directory path
        /// </summary>
        /// <param name="directoryPath"></param>
        internal void SetTargetDirectory(string directoryPath)
        {
            tB_TargetDirectory.Text = directoryPath;
        }
        #endregion

        
    }
}
