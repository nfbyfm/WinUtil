namespace WinUtil.Model
{
    /// <summary>
    /// (helper) class for describing a file to be downloaded
    /// </summary>
    public class DownloadFileInfo
    {        
        #region varaibles
        /// <summary>
        /// the url of the file to be downloaded
        /// </summary>
        public string URL { get; set; } = "";

        /// <summary>
        /// the absolute file path where the file is supposed to get downloaded to
        /// </summary>
        public string FilePath { get; set; } = "";

        #endregion

        #region constructors
        
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="uRL">the url of the file</param>
        /// <param name="filePath">the absolute filepath the data is supposed to get saved to</param>
        public DownloadFileInfo(string uRL, string filePath)
        {
            URL = uRL;
            FilePath = filePath;
        }

        #endregion
    }
}
