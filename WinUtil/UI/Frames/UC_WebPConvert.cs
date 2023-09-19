using Serilog;
using System.Diagnostics;
using WinUtil.Extensions;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// usercontrol for converting webp files into another format
    /// </summary>
    public partial class UC_WebPConvert : UserControl
    {
        public UC_WebPConvert()
        {
            InitializeComponent();

            FileNamesOptions_Changed(this, EventArgs.Empty);
            cB_ConvertFileExtension.SelectedIndex = 0;
        }

        #region ui event listeners
        private void FileNamesOptions_Changed(object sender, EventArgs e)
        {
            bool createNewFileNames = rB_CreateNewFileNames.Checked;

            l_Prefix.Enabled = createNewFileNames;
            l_Suffix.Enabled = createNewFileNames;
            tB_Prefix.Enabled = createNewFileNames;
            tB_Suffix.Enabled = createNewFileNames;
        }

        private void FilesFromDialog_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListViaFileDialog("Select webp files", "webp file|*.webp|avif files|*.avif");
        }

        private void FilesFromDirectory_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListFromDirectorySimple("*.webp");
        }

        private void FilesFromClipboard_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListFromClipboard();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            List<string> filePaths = rTB_FileList.Lines.ToList();
            bool createNewFileNames = rB_CreateNewFileNames.Checked;
            string prefix = tB_Prefix.Text;
            string suffix = tB_Suffix.Text;
            string targetFileExtension = cB_ConvertFileExtension.Text;

            Task.Run(() => ConvertWebPFiles(filePaths, createNewFileNames, prefix, suffix, targetFileExtension));
        }
        #endregion

        #region convert functions
        /// <summary>
        /// converts a list of webp files into another file format (using ffmpeg)
        /// </summary>
        /// <param name="filePaths"></param>
        /// <param name="createNewFileNames"></param>
        /// <param name="prefix"></param>
        /// <param name="suffix"></param>
        /// <param name="targetFileExtension"></param>
        internal static void ConvertWebPFiles(List<string> filePaths, bool createNewFileNames, string prefix, string suffix, string targetFileExtension = ".jpg")
        {
            string ffmpegFilePath = Properties.Settings.Default.ffmpegFilePath;

            bool ffmpegOK = ffmpegFilePath.IsValidString() && File.Exists(ffmpegFilePath);

            if (filePaths.Count > 0 && ffmpegOK)
            {
                int startIndex = 0;
                string directoryPath = "";
                int maxDigits = filePaths.Count.Digits();

                if (createNewFileNames)
                {
                    startIndex = FileHandlingUtil.GetFileNumberStartIndex(filePaths[0], prefix, suffix);
                    maxDigits = (filePaths.Count + startIndex).Digits();

                    string? tmpPath = Path.GetDirectoryName(filePaths[0]);
                    if (tmpPath != null)
                        directoryPath = tmpPath;
                    else
                    {
                        Log.Error($"Failed to get directroy path from '{filePaths[0]}'.");
                        return;
                    }
                }

                for (int i = 0; i < filePaths.Count; i++)
                {
                    string targetFilePath;

                    if (createNewFileNames)
                        targetFilePath = Path.Combine(directoryPath, prefix + (startIndex + i).ToString("D" + maxDigits.ToString()) + suffix + targetFileExtension);
                    else
                        targetFilePath = filePaths[i].Remove(filePaths[i].LastIndexOf('.')) + targetFileExtension;

                    ConvertWebPFile(filePaths[i], targetFilePath);
                }
            }
            else
            {
                if (filePaths.Count <= 0)
                    Log.Warning("There are no file paths in the current list.");

                if (!ffmpegOK)
                    Log.Error("Couldn't find the ffmpeg executable file (needed for conversion).");
            }
        }

        /// <summary>
        /// converts a single webp file into another format (using ffmpeg)
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="outputFilePath"></param>
        internal static void ConvertWebPFile(string sourceFilePath, string outputFilePath)
        {
            //ffmpeg -i 1.sm.webp a.png

            string ffmpegFilePath = Properties.Settings.Default.ffmpegFilePath;

            bool ffmpegOK = ffmpegFilePath.IsValidString() && File.Exists(ffmpegFilePath);
            bool filePathOk = sourceFilePath.IsValidString() && File.Exists(sourceFilePath);

            if (ffmpegOK && filePathOk)
            {
                //get arguments based on user input values
                string arguments = " -i \"" + sourceFilePath + "\" \"" + outputFilePath + "\"";

                Log.Debug($"Arguments for ffmpeg: '{arguments}'");

                try
                {
                    Process process = new()
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = ffmpegFilePath,
                            Arguments = arguments,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        },
                        EnableRaisingEvents = true
                    };

                    process.Exited += (sender, e) =>
                    {
                        if (File.Exists(outputFilePath))
                            Log.Information($"File '{Path.GetFileName(outputFilePath)}' has been successfully converted.");
                        else
                            Log.Error($"An unknown error has occured: output file '{Path.GetFileName(outputFilePath)}' hasn't been created.");
                    };

                    process.OutputDataReceived += (Sender, e) =>
                    {
                        if (e.Data.IsValidString())
                            Log.Information(e.Data);
                    };

                    process.Start();

                    //reroute the process output to the logger
                    while (!process.StandardOutput.EndOfStream)
                    {
                        string? line = process.StandardOutput.ReadLine();

                        if (line.IsValidString())
                            Log.Information(line);
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to convert the webp file '{sourceFilePath}': {ex.Message}");
                }
            }
            else
            {
                if (!ffmpegOK)
                    Log.Error("Couldn't find the ffmpeg executable file.");

                if (!filePathOk)
                    Log.Error($"The path of the source file ({sourceFilePath}) is either not set or wrong.");
            }
        }

        #endregion
    }
}
