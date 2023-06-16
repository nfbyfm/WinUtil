using Serilog;
using WinUtil.UI.Dialogs;
using YACUF.Extensions;

namespace WinUtil.Extensions
{
    /// <summary>
    /// A extesion class for the RichTextBox class (WinForms)
    /// </summary>
    public static class RichTextBoxExtensions
    {
        /// <summary>
        /// sets or append the current list of file paths
        /// </summary>
        /// <param name="rTB_FileList">     The richt text box to act upon.</param>
        /// <param name="newFilePaths">     The list of new file paths</param>
        public static void SetFilePathList(this RichTextBox rTB_FileList, List<string> newFilePaths)
        {
            if (newFilePaths.HasElements(out int pathCount))
            {
                if (rTB_FileList.AppendFilePathList())
                {
                    List<string> existingLines = rTB_FileList.Lines.ToList();
                    newFilePaths = existingLines.Concat(newFilePaths).ToList();
                }

                rTB_FileList.Clear();
                rTB_FileList.Lines = newFilePaths.ToArray();

                Log.Information("Added " + pathCount + " new file paths to the current list.");
            }
        }

        /// <summary>
        /// sets or append the current list of file paths
        /// </summary>
        /// <param name="rTB_FileList">     The richt text box to act upon.</param>
        /// <param name="newFilePaths">     The list of new file paths</param>
        /// <param name="appendList">       if true, the current list gets appended, cleared before adding new paths beforehand</param>
        public static void SetFilePathList(this RichTextBox rTB_FileList, List<string> newFilePaths, bool appendList)
        {
            if (newFilePaths.HasElements(out int pathCount))
            {
                if (appendList)
                {
                    List<string> existingLines = rTB_FileList.Lines.ToList();
                    newFilePaths = existingLines.Concat(newFilePaths).ToList();
                }

                rTB_FileList.Clear();
                rTB_FileList.Lines = newFilePaths.ToArray();

                Log.Information("Added " + pathCount + " new file paths to the current list.");
            }
        }

        /// <summary>
        /// checks if there are already file paths in the list and if so, asks the user if the list is to be appended with the new paths
        /// </summary>
        /// <param name="rTB_FileList">     The rich text box to act upon.</param>
        /// <param name="messageBoxTitle">  (optional) title of the message box</param>
        /// <returns>true if appending of the current list of file paths is wanted, false otherwise</returns>
        public static bool AppendFilePathList(this RichTextBox rTB_FileList, string messageBoxTitle = "Add new file paths")
        {
            bool appendList = false;

            if (rTB_FileList.Lines.Length > 0)
            {
                if (MessageBox.Show("Append the current list?", messageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    appendList = true;
                }
            }

            return appendList;
        }

        /// <summary>
        /// sets/appends the current list of files with the text in the clipboard
        /// </summary>
        /// <param name="rTB_FileList">     The rich textbox to act upon.</param>
        public static void SetFileListFromClipboard(this RichTextBox rTB_FileList)
        {
            if (Clipboard.ContainsText())
            {
                if(rTB_FileList.AppendFilePathList())
                    rTB_FileList.Text += Clipboard.GetText();
                else
                    rTB_FileList.Text += Clipboard.GetText();
            }
            else
            {
                Log.Error("Clipboard doesn't contain any text.");
            }
        }

        /// <summary>
        /// sets/appends the current list of files based lines in text file(-s)
        /// </summary>
        /// <param name="rTB_FileList">     The rich textbox to act upon.</param>
        /// <param name="dialogTitle">      (optional) title of the file select dialog</param>
        public static void SetFileListFromTextFile(this RichTextBox rTB_FileList, string dialogTitle = "Select text files")
        {
            //create and show file dialog
            OpenFileDialog oDi = new()
            {
                Title = dialogTitle,
                RestoreDirectory = true,
                Filter = "text file|*.txt",
                Multiselect = true
            };

            //if input is ok, set/append file paths
            if (oDi.ShowDialog() == DialogResult.OK)
            {
                //open each file and try to add the filepaths within
                foreach (string filePath in oDi.FileNames)
                {
                    if (File.Exists(filePath))
                    {
                        List<string> filePaths = File.ReadAllLines(filePath).ToList();

                        if (filePaths.HasElements(out int pathCount))
                        {
                            rTB_FileList.SetFilePathList(filePaths, true);
                            Log.Information("Added " + pathCount + " file paths from '" + Path.GetFileName(filePath) + "'.");
                        }
                        else
                        {
                            Log.Warning("File '" + filePath + "' contains no lines / mp3 file paths.");
                        }
                    }
                    else
                    {
                        Log.Error("File '" + filePath + "' for import doesn't exist.");
                    }
                }
            }
        }

        /// <summary>
        /// sets/appends the current list of files based on user input (OpenFileDialog)
        /// </summary>
        /// <param name="rTB_FileList">     The rich textbox to act upon.</param>
        /// <param name="dialogTitle">      (optional) Title of the file select dialog</param>
        /// <param name="fileFilter">       (optional) Filter for the file types to select.</param>
        public static void SetFileListViaFileDialog(this RichTextBox rTB_FileList, string dialogTitle = "Select files", string fileFilter = "any file|*.*")
        {
            //create and show file dialog
            OpenFileDialog oDi = new()
            {
                Title = dialogTitle,
                RestoreDirectory = true,
                Filter = fileFilter,
                Multiselect = true
            };

            //if input is ok, set/append file paths
            if (oDi.ShowDialog() == DialogResult.OK)
                rTB_FileList.SetFilePathList(oDi.FileNames.ToList());
        }

        /// <summary>
        /// sets/appends the current list of files based on user input (files in selected directory)
        /// </summary>
        /// <param name="rTB_FileList">     The rich textbox to act upon.</param>
        /// <param name="fileFilter">       (optional) Filter for the file types to select.</param>
        public static void SetFileListFromDirectorySimple(this RichTextBox rTB_FileList, string fileFilter="*.*")
        {
            FolderBrowserDialog fDi = new()
            {
                ShowNewFolderButton = true
            };

            if (fDi.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = fDi.SelectedPath;
                string messageBoxTitle = "file paths from directory";
                SearchOption fileSearchOption = SearchOption.TopDirectoryOnly;

                if (Directory.GetDirectories(directoryPath).Length > 0)
                {
                    if (MessageBox.Show("Include files in sub directories?", messageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        fileSearchOption = SearchOption.AllDirectories;
                    }
                }

                List<string> newFilePaths = Directory.GetFiles(directoryPath, fileFilter, fileSearchOption).ToList();

                if (newFilePaths.HasElements())
                {
                    rTB_FileList.SetFilePathList(newFilePaths);
                }
                else
                {
                    Log.Error("Couldn't find any "+fileFilter+" files in the '" + directoryPath + "' directory.");
                }
            }
        }

        /// <summary>
        /// sets/appends the current list of files based on user input (files in selected directory, using more thorough dialog / advanced input possibilities)
        /// </summary>
        /// <param name="rTB_FileList">     The rich textbox to act upon.</param>
        /// <param name="lockFileFilter">   If set to true, the user won't be able to set the file filter options in the dialog</param>
        /// <param name="fileFilter">       (optional) Filter for the file types to select.</param>
        public static void SetFileListFromDirectoryExtended(this RichTextBox rTB_FileList, bool lockFileFilter, string fileFilter = "*.*")
        {
            FilesFromDirectoryDialog fDi = new(lockFileFilter, fileFilter);

            if(fDi.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    SearchOption searchOption = SearchOption.TopDirectoryOnly;

                    if (fDi.IncludeSubDirectories)
                        searchOption = SearchOption.AllDirectories;

                    string filter = "*.*";

                    if (fDi.FilterByExtension)
                        filter = fDi.FileExtensionFilter;

                    List<string> filePaths = Directory.GetFiles(fDi.DirectoryPath, filter, searchOption).ToList();

                    if (filePaths.Count > 0)
                        rTB_FileList.SetFilePathList(filePaths);
                    else
                        Log.Error("Couldn't find any files in directory '" + fDi.DirectoryPath + "' matching the given criteria (include subdirectories: "+fDi.IncludeSubDirectories+"; filtering active: "+fDi.FilterByExtension+"; filter: '"+fDi.FileExtensionFilter+"').");
                }
                catch(Exception ex)
                {
                    Log.Error("Failed to get files matching criteria from directory '" + fDi.DirectoryPath + "': " + ex.Message);
                }
            }
        }
    }
}
