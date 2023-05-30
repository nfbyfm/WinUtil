using Serilog;
using YACUF.Utilities;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// user control for editing tags of mp3 files
    /// </summary>
    public partial class UC_MP3TagEditor : UserControl
    {
        public UC_MP3TagEditor()
        {
            InitializeComponent();

            //set the default value for the release year
            nUD_ReleaseYear.Value = DateTime.Today.Year;

            UpdateCheckBoxCheckedStates();
        }

        #region user interaction functions
        private void FileListFromFile_Click(object sender, EventArgs e)
        {
            //show user a dialog for selection of text files with file paths
            OpenFileDialog oDi = new()
            {
                RestoreDirectory = true,
                Filter = "text file|*.txt",
                Multiselect = true,
                Title = "Select files"
            };

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
                            SetFilePathList(filePaths, true);
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

        private void FromDirectory_Click(object sender, EventArgs e)
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

                List<string> newFilePaths = Directory.GetFiles(directoryPath, "*.mp3", fileSearchOption).ToList();

                if (newFilePaths.HasElements())
                {
                    bool appendList = AppendFilePathList(messageBoxTitle);
                    SetFilePathList(newFilePaths, appendList);
                }
                else
                {
                    Log.Error("Couldn't find any mp3 files in the '" + directoryPath + "' directory.");
                }
            }
        }

        private void FileListFromClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rTB_FileList.Text = Clipboard.GetText();
            }
            else
            {
                Log.Error("Clipboard doesn't contain any text.");
            }
        }

        private void SelectAlbumCoverFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDi = new()
            {
                RestoreDirectory = true,
                Filter = "image file | *.jpg",
                Title = "Select album cover image",
                Multiselect = false
            };

            if (oDi.ShowDialog() == DialogResult.OK)
            {
                tB_AlbumCoverFilePath.Text = oDi.FileName;
            }
        }

        private void SetTags_Click(object sender, EventArgs e)
        {
            List<string> filePaths = rTB_FileList.Lines.ToList();

            if (filePaths.HasElements(out int pathCount))
            {
                TagLib.Id3v2.AttachmentFrame? cover = null;

                if (File.Exists(tB_AlbumCoverFilePath.Text))
                {
                    try
                    {
                        Image img = Image.FromFile(tB_AlbumCoverFilePath.Text);
                        byte[] imageBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imageBytes = ms.ToArray();
                        }

                        cover = new TagLib.Id3v2.AttachmentFrame
                        {
                            Type = TagLib.PictureType.FrontCover,
                            Description = "Cover",
                            MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg,
                            Data = imageBytes,
                            TextEncoding = TagLib.StringType.UTF16
                        };
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Failed to get album cover image: " + ex.Message);
                    }
                }
                string albumTitle = tB_AlbumName.Text;
                uint publishYear = (uint)nUD_ReleaseYear.Value;
                string[] artistNames;
                string tmpArtistName = tB_ArtistName.Text;

                if (tmpArtistName.Contains(";"))
                    artistNames = tmpArtistName.Split(";", StringSplitOptions.RemoveEmptyEntries);
                else if (tmpArtistName.Contains(","))
                    artistNames = tmpArtistName.Split(",", StringSplitOptions.RemoveEmptyEntries);
                else if (tmpArtistName.Contains("|"))
                    artistNames = tmpArtistName.Split("|", StringSplitOptions.RemoveEmptyEntries);
                else
                    artistNames = new[] { tmpArtistName };

                bool setTitlefromFileName = cB_SetTitleFromFileName.Checked;
                bool setTrackNumber = cB_SetTrackNumber.Checked;
                bool setTrackNumberFromFileName = cB_TrackNumberFromFilename.Checked;

                for (int i = 0; i < pathCount; i++)
                {
                    uint trackNumber = (uint)(i+1);
                    string filePath = filePaths[i];
                    Log.Debug("Setting tags for element " + trackNumber + " in list (" + filePath + ").");

                    Task.Run(() => SetMp3FileTags(filePath, setTitlefromFileName, setTrackNumber, setTrackNumberFromFileName, trackNumber, (uint)pathCount, albumTitle, artistNames, publishYear, cover));
                }
            }
            else
            {
                Log.Error("The list of file paths contains no elements.");
            }
        }

        private void SelectSingleFiles_Click(object sender, EventArgs e)
        {
            //show file dialog to the user to select single files
            OpenFileDialog oDi = new()
            {
                RestoreDirectory = true,
                Filter = "mp3 file|*.mp3",
                Multiselect = true,
                Title = "Select mp3 files"
            };

            if (oDi.ShowDialog() == DialogResult.OK)
            {
                //add file paths to the current list (if there are any)
                List<string> newFilePaths = oDi.FileNames.ToList();

                if (newFilePaths.HasElements())
                {
                    bool appendList = AppendFilePathList();
                    SetFilePathList(newFilePaths, appendList);
                }
            }
        }

        private void SetTrackNumber_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxCheckedStates();
        }
        #endregion

        #region helper / logic functions
        /// <summary>
        /// sets or append the current list of file paths
        /// </summary>
        /// <param name="newFilePaths">list of new file paths</param>
        /// <param name="appendList">if true, the current list gets appended, cleared before adding new paths beforehand</param>
        private void SetFilePathList(List<string> newFilePaths, bool appendList)
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
        /// <param name="messageBoxTitle">(optional) title of the message box</param>
        /// <returns>true if appending of the current list of file paths is wanted, false otherwise</returns>
        private bool AppendFilePathList(string messageBoxTitle = "Add new file paths")
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
        /// updates the enable / visibility of checkboxes with dependencies
        /// </summary>
        private void UpdateCheckBoxCheckedStates()
        {
            cB_TrackNumberFromFilename.Enabled = cB_SetTrackNumber.Checked;
        }

        /// <summary>
        /// sets the tags of a mp3 file
        /// </summary>
        /// <param name="filePath">absolute file path of the mp3 file</param>
        /// <param name="setTitleFromFileName">set the title of the mp3 file based on the file name</param>
        /// <param name="setTrackNumber">set the track number</param>
        /// <param name="setTrackNumberFromFileName">get the track number from the file name</param>
        /// <param name="trackNumber">the track number (if not set via file name)</param>
        /// <param name="trackCount">total number of tracks</param>
        /// <param name="albumTitle">title of the album</param>
        /// <param name="artists">list of artists</param>
        /// <param name="publishYear">year of publishing</param>
        /// <param name="albumCover">album cover image</param>
        private void SetMp3FileTags(string filePath, bool setTitleFromFileName, bool setTrackNumber, bool setTrackNumberFromFileName, uint trackNumber, uint trackCount, string albumTitle, string[] artists, uint publishYear, TagLib.Id3v2.AttachmentFrame? albumCover)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(filePath);

                    TagLib.File tFile = TagLib.File.Create(filePath);

                    if (setTitleFromFileName)
                    {
                        //get file name without extension and remove any numbering in front
                        string trimmedFileName = fileName.TrimStart('.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9');

                        tFile.Tag.Title = trimmedFileName;
                    }

                    if (setTrackNumber)
                    {
                        if (setTrackNumberFromFileName)
                        {
                            //try to get the first few digits
                            string digits = new String(fileName.TakeWhile(Char.IsDigit).ToArray());

                            if (Int32.TryParse(digits, out int newTrackNumber))
                                tFile.Tag.Track = (uint)newTrackNumber;
                            else
                                Log.Error("Failed to get track number from filename '" + fileName + "'. No number has been set.");
                        }
                        else
                        {
                            tFile.Tag.Track = trackNumber;
                        }

                        tFile.Tag.TrackCount = trackCount;
                    }

                    tFile.Tag.Album = albumTitle;
                    tFile.Tag.AlbumArtists = artists;
                    tFile.Tag.Performers = artists;
                    tFile.Tag.Year = publishYear;

                    if (albumCover != null)
                        tFile.Tag.Pictures = new TagLib.IPicture[] { albumCover };

                    tFile.Save();

                    Log.Information("Successfully written tags of '" + fileName + "'.");
                }
                catch (Exception ex)
                {
                    Log.Error("Failed to set the tags of '" + Path.GetFileName(filePath) + "' :" + ex.Message);
                }
            }
            else
            {
                Log.Error("File '" + filePath + "' doesn't exist.");
            }
        }
        #endregion
    }
}
