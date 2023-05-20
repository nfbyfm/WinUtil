namespace WinUtil.Model
{
    /// <summary>
    /// helper class for renaming files
    /// </summary>
    internal class RenameFileInfo
    {
        #region variables
        /// <summary>
        /// the absolute filepath of the source file
        /// </summary>
        public string SourecFilePath { get; set; } = "";

        /// <summary>
        /// the new absolute filepath of the sourec file
        /// </summary>
        public string DestinationFilePath { get; set; } = "";
        #endregion

        #region constructors
        /// <summary>
        /// constructor for file info for renaming a file
        /// </summary>
        /// <param name="sourecFilePath"></param>
        /// <param name="destinationFilePath"></param>
        public RenameFileInfo(string sourecFilePath, string destinationFilePath)
        {
            SourecFilePath = sourecFilePath;
            DestinationFilePath = destinationFilePath;
        }

        /// <summary>
        /// constructor for file info for renaming a file
        /// </summary>
        /// <param name="sourceFilepath">the absoulte file path of the original file (destination file path gets to the same path)</param>
        public RenameFileInfo(string sourceFilepath)
        {
            this.SourecFilePath = sourceFilepath;
            this.DestinationFilePath = sourceFilepath;
        }
        #endregion

    }
}
