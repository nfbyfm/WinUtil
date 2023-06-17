using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.Model
{
    /// <summary>
    /// class for the simple description of a file
    /// </summary>
    internal class SimpleFileInfo
    {
        #region variables / properties
        /// <summary>
        /// the absolute path of the file
        /// </summary>
        public string? FilePath { get; private set; }

        /// <summary>
        /// the size of the file in bytes
        /// </summary>
        public long SizeInBytes { get; private set; }

        /// <summary>
        /// the short filename (no directories)
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// the string used in a chart legend
        /// </summary>
        public string FileInfoLegendString { get; private set; }

        #endregion

        #region constructors
        /// <summary>
        /// constructor for simple file info class
        /// </summary>
        /// <param name="filePath">the absolute path of the file</param>
        public SimpleFileInfo(string? filePath)
        {
            //set the path and update/get the size
            FilePath = filePath;
            SizeInBytes = FileHandlingUtil.GetFileSize(filePath);

            if (filePath.IsValidString())
                FileName = Path.GetFileName(filePath);
            else
                FileName = "";

            FileInfoLegendString = FileName + " [" + FileHandlingUtil.GetFileSizeAsString(SizeInBytes) + "]";
        }

        #endregion

    }
}
