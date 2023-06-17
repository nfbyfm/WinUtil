using Serilog;
using System.Diagnostics;
using System.Runtime;
using System.Windows.Forms.DataVisualization.Charting;
using WinUtil.Model;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// User control for showing structure / size of a given directory
    /// </summary>
    public partial class UC_DirectoryInfo : UserControl
    {
        /// <summary>
        /// constructor for user control ( for showing structure / size of a given directory)
        /// </summary>
        public UC_DirectoryInfo()
        {
            InitializeComponent();
            UpdateViews();
        }

        #region internal setter functions
        /// <summary>
        /// sets the directory path
        /// </summary>
        /// <param name="directoryPath"></param>
        internal void SetDirectoryPath(string directoryPath)
        {
            tB_Directory.Text = directoryPath.Trim();
        }

        #endregion

        #region user input event listeners
        /// <summary>
        /// lets the user select the directory path via dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDi = new();

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
            string directoryPath = tB_Directory.Text;

            if (directoryPath.IsValidString())
            {
                if (Directory.Exists(directoryPath))
                {
                    Task.Run(() =>
                    {
                        Log.Information($"Starting the building of informational data for directory '{directoryPath}'. Depending on the size this may take a while.");

                        //create the mode (this maight take a while)
                        SimpleDirectoryInfo newInfoData = new(directoryPath);

                        //display the result
                        UpdateViews(newInfoData);
                    });
                }
                else
                {
                    Log.Warning($"The directory path '{directoryPath}' is invalid. The directory doesn't exist.");
                }
            }
        }

        /// <summary>
        /// reacts to the change in the slecetd treeview node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirectoryStrucutre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SimpleDirectoryInfo? infoData = null;
            TreeNode? selectedNode = tV_DirectoryStrucutre.SelectedNode;

            if (selectedNode != null)
            {
                object? tagObject = selectedNode.Tag;

                if (tagObject != null && tagObject.GetType() == typeof(SimpleDirectoryInfo))
                    infoData = (SimpleDirectoryInfo)tagObject;
            }

            UpdateChartView(infoData);
        }

        /// <summary>
        /// opens the currently selected directory in the file explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenInFileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tV_DirectoryStrucutre.SelectedNode != null)
            {
                object? tagObject = tV_DirectoryStrucutre.SelectedNode.Tag;
                if (tagObject != null)
                {
                    string argument = "";

                    if (tagObject.GetType() == typeof(SimpleDirectoryInfo))
                    {
                        SimpleDirectoryInfo dirInfo = (SimpleDirectoryInfo)tagObject;
                        if (dirInfo.DirectoryPath.IsValidString())
                            argument = dirInfo.DirectoryPath;
                        else
                            Log.Error("Directory path of the selected node is invalid.");
                    }
                    else if(tagObject.GetType() == typeof(SimpleFileInfo))
                    {
                        SimpleFileInfo fileInfo = (SimpleFileInfo)tagObject;
                        if (fileInfo.FilePath.IsValidString())
                            argument = fileInfo.FilePath;
                        else
                            Log.Error("File path of the selected node is invalid.");
                    }

                    if(argument.IsValidString())
                    {
                        Process process = new()
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "explorer.exe",
                                Arguments = argument,
                                UseShellExecute = false,
                                CreateNoWindow = true
                            }
                        };

                        process.Start();
                    }                    
                }
            }
            else
            {
                Log.Information("Currently no directory is selected.");
            }
        }
        #endregion

        #region update functions for views
        /// <summary>
        /// updates the tree and chart view
        /// </summary>
        /// <param name="infoData">(optional) directory model (if null, views get reset)</param>
        private void UpdateViews(SimpleDirectoryInfo? infoData = null)
        {
            if (tV_DirectoryStrucutre.InvokeRequired || chartView.InvokeRequired)
            {
                tV_DirectoryStrucutre.Invoke(new MethodInvoker(() => { UpdateViews(infoData); }));
            }
            else
            {
                //update the tree view
                tV_DirectoryStrucutre.Nodes.Clear();

                if (infoData != null)
                {
                    if (infoData.GetDirectoryTreeNode(out TreeNode? node))
                    {
                        tV_DirectoryStrucutre.Nodes.Add(node);

                        if (node.Nodes.Count > 0)
                            node.Expand();
                    }
                }

                //update the chart view
                UpdateChartView(infoData);
            }
        }

        /// <summary>
        /// updates the chart view for a given directory
        /// </summary>
        /// <param name="infoData">(optional) directory model </param>
        private void UpdateChartView(SimpleDirectoryInfo? infoData = null)
        {
            //reset data
            chartView.Series.Clear();
            chartView.Legends.Clear();
            chartView.Annotations.Clear();
            chartView.Titles.Clear();
            
            //calculate files / directroy sizes and show as doughnut chart
            if (infoData != null)
            {
                //set the chart title
                chartView.Titles.Add(infoData.DirectoryInfoString);

                Series fileSeries = chartView.Series.Add("Files");
                fileSeries.ChartType = SeriesChartType.Doughnut;
                fileSeries.CustomProperties = "PieLabelStyle=Outside";

                chartView.ChartAreas[0].Area3DStyle.Enable3D = true;
                chartView.ChartAreas[0].Area3DStyle.IsClustered = true;
                //chartView.ChartAreas[0].Area3DStyle.Inclination = 50;

                if (infoData.SubDirectories != null && infoData.SubDirectories.HasElements(out int dirCount))
                {
                    // point for each subdirectroy
                    for (int i = 0; i < dirCount; i++)
                    {
                        SimpleDirectoryInfo subDirectory = infoData.SubDirectories[i];

                        // Add point
                        fileSeries.Points.AddXY(subDirectory.DirectoryInfoString, subDirectory.TotalSizeInBytes);
                        fileSeries.Points[fileSeries.Points.Count - 1].LegendText = subDirectory.DirectoryInfoLegendString;
                    }
                }

                if (infoData.Files != null && infoData.Files.HasElements(out int fileCount))
                {
                    // point for each file
                    for (int i = 0; i < fileCount; i++)
                    {
                        SimpleFileInfo fileInfo = infoData.Files[i];

                        string fileName = fileInfo.FileName;
                        long size = fileInfo.SizeInBytes;// GetFileSize(files[i]);

                        // Add point
                        fileSeries.Points.AddXY(fileName, size);
                        fileSeries.Points[fileSeries.Points.Count - 1].LegendText = fileInfo.FileInfoLegendString;
                    }
                }

                // Create a new legend called "SizeLegend".
                chartView.Legends.Add(new Legend("SizeLegend"));

                // Assign the legend to fileSeries.
                fileSeries.Legend = "SizeLegend";
                fileSeries.IsVisibleInLegend = true;
            }
        }

        #endregion
    }
}
