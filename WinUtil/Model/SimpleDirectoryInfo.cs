using Serilog;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.Model
{
    /// <summary>
    /// class for the simple description of a directory
    /// </summary>
    internal class SimpleDirectoryInfo
    {
        #region properties
        /// <summary>
        /// list of al subdirectories (top level only)
        /// </summary>
        public List<SimpleDirectoryInfo>? SubDirectories { get; private set; }

        /// <summary>
        /// list of all files (top level only)
        /// </summary>
        public List<SimpleFileInfo>? Files { get; private set; }

        /// <summary>
        /// the absolute path of the directory
        /// </summary>
        public string? DirectoryPath { get; private set; }

        /// <summary>
        /// the short directory name
        /// </summary>
        public string DirectoryName { get; private set; }

        /// <summary>
        /// size of all subdirectories in number of bytes (top level only)
        /// </summary>
        public long SubDirectorySizeInBytes { get; private set; }

        /// <summary>
        /// size of all files in number of bytes (top level only)
        /// </summary>
        public long FilesSizeInBytes { get; private set; }

        /// <summary>
        /// the total size of the directroy in bytes
        /// </summary>
        public long TotalSizeInBytes { get; private set; }

        /// <summary>
        /// the name and size data of the current directory
        /// </summary>
        public string DirectoryInfoString { get; private set; }

        /// <summary>
        /// the string used in a chart legend
        /// </summary>
        public string DirectoryInfoLegendString { get; private set; }
        #endregion

        #region constructors
        /// <summary>
        /// constructor for a simple directory information object
        /// </summary>
        /// <param name="directoryPath"></param>
        public SimpleDirectoryInfo(string? directoryPath)
        {
            //set the path
            DirectoryPath = directoryPath;

            //update the name
            if (directoryPath.IsValidString())
                DirectoryName = new DirectoryInfo(directoryPath).Name;
            else
                DirectoryName = "";
            //reset the info strings
            DirectoryInfoString = "";
            DirectoryInfoLegendString = "";

            //create lists of sub directories and files for the first time
            UpdateContents();            
        }

        #endregion

        #region update functions
        /// <summary>
        /// updates the contents of the current directory (recursively)
        /// </summary>
        public void UpdateContents()
        {
            if (SubDirectories != null)
                SubDirectories.Clear();
            else
                SubDirectories = new();

            if (Files != null)
                Files.Clear();
            else
                Files = new();
            
            //reset the sizes
            SubDirectorySizeInBytes = 0;
            FilesSizeInBytes = 0;
            TotalSizeInBytes = 0;

            //reset the info strings
            DirectoryInfoString = "";
            DirectoryInfoLegendString = "";

            if (DirectoryPath.IsValidString() && Directory.Exists(DirectoryPath))
            {
                //(re-)build the informational data / list of sub directories and files
                try
                {
                    string[] subDirectories = Directory.GetDirectories(DirectoryPath);
                    ConcurrentBag<SimpleDirectoryInfo> subDirs = new();
                    Parallel.ForEach(subDirectories, subDirPath =>
                    {
                        SimpleDirectoryInfo newDirectory = new(subDirPath);
                        subDirs.Add(newDirectory);
                    });

                    SubDirectories = subDirs.OrderBy(x => x.DirectoryName).ToList();
                    SubDirectorySizeInBytes = SubDirectories.Sum(x => x.TotalSizeInBytes);
                    subDirs.Clear();
                    /*
                    for (int i = 0; i < subDirectories.Length; i++)
                    {
                        SimpleDirectoryInfo newDirectory = new(subDirectories[i]);
                        SubDirectories.Add(newDirectory);
                        SubDirectorySizeInBytes += newDirectory.TotalSizeInBytes;
                    }
                    */

                    string[] files = Directory.GetFiles(DirectoryPath);

                    for (int i = 0; i < files.Length; i++)
                    {
                        SimpleFileInfo newFile = new(files[i]);
                        FilesSizeInBytes += newFile.SizeInBytes;
                    }
                }
                catch (Exception ex)
                {
                    //Log.Error($"Failed to get content information of directory '{DirectoryPath}': {ex.Message}");
                    Log.Error(ex.Message);
                }
            }

            //update the info strings
            DirectoryInfoString = DirectoryName + " " + FileHandlingUtil.GetSizeString(SubDirectorySizeInBytes, FilesSizeInBytes);
            DirectoryInfoLegendString = DirectoryName + " [" + FileHandlingUtil.GetFileSizeAsString(TotalSizeInBytes) + "]";

            //update the total size
            TotalSizeInBytes = FilesSizeInBytes + SubDirectorySizeInBytes;

            if (!DirectoryInfoString.IsValidString())
                Log.Error($"Failed to create the directory info string for {DirectoryPath}");
        }

        #endregion


        /// <summary>
        /// creates treenode of the given directory
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="node"></param>
        /// <param name="totalSize"></param>
        /// <returns>true if node could be generated successfully</returns>
        public bool GetDirectoryTreeNode([NotNullWhen(true)] out TreeNode? node)
        {
            node = null;

            if(DirectoryPath.IsValidString())
            {
                node = new(DirectoryInfoString)
                {
                    Tag = this
                };
                
                if (SubDirectories != null && SubDirectories.HasElements(out int dirCount))
                {
                    for (int i = 0; i < dirCount; i++)
                    {
                        if (SubDirectories[i].GetDirectoryTreeNode(out TreeNode? subNode))
                            node.Nodes.Add(subNode);
                    }
                }
            }

            return node != null;
        }

        
    }
}
