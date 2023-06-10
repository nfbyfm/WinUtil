using Serilog;
using WinUtil.Model;
using YACUF.Utilities;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// User control for showing status of a given directory
    /// </summary>
    public partial class UC_DirectoryInfo : UserControl
    {
        public UC_DirectoryInfo()
        {
            InitializeComponent();
            UpdateChartView("");
        }

        #region user input event listeners
        /// <summary>
        /// öets the user select the directory path via dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDi = new()
            {
                ShowNewFolderButton = false
            };

            if (fDi.ShowDialog() == DialogResult.OK)
                tB_Directory.Text = fDi.SelectedPath;
        }


        /// <summary>
        /// reatcs to chenges in the directory path textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Directory_TextChanged(object sender, EventArgs e)
        {
            UpdateViews();
        }

        /// <summary>
        /// reacts to the change in the slecetd treeview node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tV_DirectoryStrucutre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedDirectory = "";

            TreeNode? selectedNode = tV_DirectoryStrucutre.SelectedNode;
            if (selectedNode != null)
            {
                object? tagObject = selectedNode.Tag;

                if (tagObject != null)
                {
                    selectedDirectory = (string)tagObject;
                }
            }

            UpdateChartView(selectedDirectory);
        }
        #endregion

        #region general UI functions

        /// <summary>
        /// updates the views based on the currently selected direcory
        /// </summary>
        private void UpdateViews()
        {
            string directoryPath = tB_Directory.Text;

            //update chart view
            UpdateChartView(directoryPath);

            //update the tree view
            tV_DirectoryStrucutre.Nodes.Clear();

            if (directoryPath.IsValidString())
            {
                if (Directory.Exists(directoryPath))
                {
                    //create main treeview node
                    if (GetDirectoryTreeNode(directoryPath, out TreeNode node, out _))
                    {
                        tV_DirectoryStrucutre.Nodes.Add(node);

                        if (node.Nodes.Count > 0)
                            node.Expand();
                    }
                }
                else
                {
                    Log.Warning("The given directory path '" + directoryPath + "' doesn't exitst.");
                }
            }
            else
            {
                Log.Warning("The current directory is not a valid path.");
            }
        }

        /// <summary>
        /// updates the chart view for a given directory
        /// </summary>
        /// <param name="directoryPath"></param>
        private void UpdateChartView(string directoryPath)
        {
            //todo: implement display of information via chart view

            //reset data
            chartView.Series.Clear();
            chartView.Legends.Clear();
            chartView.Annotations.Clear();
            chartView.Titles.Clear();

            if (directoryPath.IsValidString() && Directory.Exists(directoryPath))
            {
                string directoryString = new DirectoryInfo(directoryPath).Name;
                chartView.Titles.Add(directoryString);

                //chartView.Series["Test"].ChartType = SeriesChartType.Pie;  
            }
        }


        #endregion

        #region logic

        /// <summary>
        /// creates treenode of the given directory
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="node"></param>
        /// <param name="totalSize"></param>
        /// <returns></returns>
        private bool GetDirectoryTreeNode(string directoryPath, out TreeNode node, out long totalSize)
        {
            bool nodeCreated = false;
            node = new("");
            totalSize = 0;

            if (directoryPath.IsValidString() && Directory.Exists(directoryPath))
            {
                try
                {
                    string directoryString = new DirectoryInfo(directoryPath).Name;

                    List<string> filePaths = Directory.GetFiles(directoryPath, "*.*", SearchOption.TopDirectoryOnly).ToList();
                    List<string> subDirectories = Directory.GetDirectories(directoryPath).ToList();

                    long directorySize = 0;
                    long fileSize = 0;

                    //calcualte totalsize of sub directories (and create their treenodes)
                    if (subDirectories.HasElements(out int dirCount))
                    {
                        for (int i = 0; i < dirCount; i++)
                        {
                            if (GetDirectoryTreeNode(subDirectories[i], out TreeNode subNode, out long tSize))
                            {
                                node.Nodes.Add(subNode);
                                directorySize += tSize;
                            }
                        }
                    }

                    //calculate total size of files
                    if (filePaths.HasElements(out int fileCount))
                    {
                        for (int i = 0; i < fileCount; i++)
                        {
                            fileSize += GetFileSize(filePaths[i]);
                        }
                    }

                    //set node properties
                    node.Text = directoryString + " " + GetSizeString(directorySize, fileSize);
                    node.Tag = directoryPath;

                    //calcualte total size
                    totalSize = directorySize + fileSize;

                    //set method return value
                    nodeCreated = true;
                }
                catch (Exception ex)
                {
                    Log.Error("Error creating treenode for directory '" + directoryPath + "': " + ex.Message);
                }
            }

            return nodeCreated;
        }

        /// <summary>
        /// tries to get the file size in bytes
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private long GetFileSize(string filePath)
        {
            long size = 0;

            if (File.Exists(filePath))
                size = new FileInfo(filePath).Length;

            return size;
        }

        /// <summary>
        /// creates the size info string for a treenode
        /// </summary>
        /// <param name="directorySize"></param>
        /// <param name="fileSize"></param>
        /// <returns></returns>
        private string GetSizeString(long directorySize, long fileSize)
        {
            string result = "[" + GetFileSizeAsString(directorySize + fileSize);

            if (directorySize > 0)
                result += "; Dir: " + GetFileSizeAsString(directorySize);

            if (fileSize > 0)
                result += "; Files: " + GetFileSizeAsString(fileSize);

            result += "]";

            return result;
        }

        /// <summary>
        /// creates string consisting of converted size and league of bytes
        /// </summary>
        /// <param name="sizeInBytes"></param>
        /// <returns></returns>
        private string GetFileSizeAsString(long sizeInBytes)
        {
            FileSize tSize = GetFileSize(sizeInBytes, out int totalSize);

            string result = totalSize.ToString() + " ";

            switch (tSize)
            {
                case FileSize.Bytes:
                    result += "bytes";
                    break;
                case FileSize.KiloBytes:
                    result += "KB";
                    break;
                case FileSize.MegaBytes:
                    result += "MB";
                    break;
                case FileSize.GigaBytes:
                    result += "GB";
                    break;
                case FileSize.PetaBytes:
                    result += "PB";
                    break;
                default:
                    result += "undef";
                    break;
            }

            return result;
        }

        /// <summary>
        /// converts size in bytes into human usable league
        /// </summary>
        /// <param name="sizeInBytes"></param>
        /// <param name="convertedSize"></param>
        /// <returns></returns>
        private FileSize GetFileSize(long sizeInBytes, out int convertedSize)
        {
            FileSize result = FileSize.Bytes;
            convertedSize = 0;

            if (sizeInBytes > 0)
            {
                if (sizeInBytes > 1024)
                {
                    sizeInBytes /= 1024;

                    if (sizeInBytes > 1024)
                    {
                        sizeInBytes /= 1024;

                        if (sizeInBytes > 1024)
                        {
                            sizeInBytes /= 1024;

                            if (sizeInBytes > 1024)
                            {
                                sizeInBytes /= 1024;
                                result = FileSize.PetaBytes;
                                convertedSize = (int)sizeInBytes;
                            }
                            else
                            {
                                result = FileSize.GigaBytes;
                                convertedSize = (int)sizeInBytes;
                            }
                        }
                        else
                        {
                            result = FileSize.MegaBytes;
                            convertedSize = (int)sizeInBytes;
                        }
                    }
                    else
                    {
                        result = FileSize.KiloBytes;
                        convertedSize = (int)sizeInBytes;
                    }
                }
                else
                {
                    convertedSize = (int)sizeInBytes;
                }
            }


            return result;
        }
        #endregion



    }
}
