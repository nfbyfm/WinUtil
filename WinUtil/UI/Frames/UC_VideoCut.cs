using Serilog;
using System.Diagnostics;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// user control for cutting specific segments out of a given video file
    /// </summary>
    public partial class UC_VideoCut : UserControl
    {
        private static string _videoExtensions = "mp4|*.mp4|webm|*.webm|avi|*.avi|mpeg|*.mpeg|mkv|*.mkv";

        public UC_VideoCut()
        {
            InitializeComponent();

            cB_RotationAngle.SelectedIndex = 0;
            EditOptions_CheckedChanged(this, EventArgs.Empty);
        }

        #region internal setter functions
        /// <summary>
        /// sets the source file path
        /// </summary>
        /// <param name="filePath"></param>
        internal void SetSourceFile(string filePath)
        {
            tB_SourceFilePath.Text = filePath;
        }
        #endregion

        #region UI event listeners
        /// <summary>
        /// lets the user convert the given input file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Convert_Click(object sender, EventArgs e)
        {
            string ffmpegFilePath = Properties.Settings.Default.ffmpegFilePath;
            string sourceFilePath = tB_SourceFilePath.Text;

            bool ffmpegOK = ffmpegFilePath.IsValidString() && File.Exists(ffmpegFilePath);
            bool filePathOk = sourceFilePath.IsValidString() && File.Exists(sourceFilePath);
            bool optionSelected = cB_RotateVideo.Checked || cB_CutVideo.Checked;

            if (ffmpegOK && filePathOk && optionSelected)
            {
                //check if output file path is set
                string outputFilePath = tB_OutputFilePath.Text;

                if (!outputFilePath.IsValidString())
                {
                    SetDefaultOutputFilePath(this, EventArgs.Empty);
                    outputFilePath = tB_OutputFilePath.Text;
                }

                //check if output file already exists
                if (File.Exists(outputFilePath))
                {
                    DialogResult questionResult = MessageBox.Show("The output file already exists. Delete before conversion?", "Convert to audio", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (questionResult == DialogResult.Yes)
                    {
                        try
                        {
                            File.Delete(outputFilePath);
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Error deleting existing output file: " + ex.Message);
                        }
                    }
                    else if (questionResult == DialogResult.Cancel)
                    {
                        //cancel rest of function
                        return;
                    }
                }

                string cutOption = "";
                if (cB_CutVideo.Checked)
                {
                    //calculate the duration
                    TimeSpan duration;

                    TimeSpan start = tP_StartTime.Value;
                    TimeSpan end = tP_EndTime.Value;

                    if (end > start)
                        duration = end - start;
                    else
                        duration = start - end;

                    string durationString = string.Format("{0}:{1:00}:{2:00}.{3:000}", (int)duration.TotalHours, duration.Minutes, duration.Seconds, duration.Milliseconds);
                    string startTimeString = string.Format("{0}:{1:00}:{2:00}.{3:000}", (int)start.TotalHours, start.Minutes, start.Seconds, start.Milliseconds);

                    Log.Debug($"Start time: {startTimeString}; calculated duration: {durationString}");
                    cutOption = $"-ss {startTimeString} -t {durationString}";
                }

                string rotateOption = "";
                if (cB_RotateVideo.Checked)
                {
                    switch (cB_RotationAngle.SelectedIndex)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            rotateOption = $"-vf \"transpose={cB_RotationAngle.SelectedIndex}\" ";
                            break;
                        case 4:
                            rotateOption = $"-vf \"transpose=2,transpose=2\" ";
                            break;
                        default:
                            break;
                    }
                }


                //create argument string for ffmpeg
                //ffmpeg -i movie.mp4 -ss 00:00:03 -t 00:00:08 -async 1 cut.mp4
                string arguments = $" -i \"{sourceFilePath}\" {cutOption} {rotateOption}-async 1 \"{outputFilePath}\"";

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
                            Log.Information("File '" + Path.GetFileName(outputFilePath) + "' has been successfully converted.");
                        else
                            Log.Error("An unknown error has occured: output file '" + Path.GetFileName(outputFilePath) + "' hasn't been created.");
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
                    Log.Error("Failed to convert the selected file: " + ex.Message);
                }
            }
            else
            {
                if (!ffmpegOK)
                    Log.Error("Couldn't find the ffmpeg executable file.");

                if (!filePathOk)
                    Log.Error("The path of the source file is either not set or wrong.");

                if (!optionSelected)
                    Log.Error("Neither rotation or cut option is selected.");
            }
        }

        /// <summary>
        /// lets the user select the input file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSourceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDi = new()
            {
                Title = "Select video file",
                RestoreDirectory = true,
                Multiselect = false,
                Filter = _videoExtensions
            };

            if (oDi.ShowDialog() == DialogResult.OK)
                tB_SourceFilePath.Text = oDi.FileName;
        }

        /// <summary>
        /// lets the user set the path of the output file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectOutputFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saDi = new()
            {
                Title = "Set path of output file",
                RestoreDirectory = true,
                Filter = _videoExtensions
            };

            if (saDi.ShowDialog() == DialogResult.OK)
                tB_OutputFilePath.Text = saDi.FileName;
        }

        /// <summary>
        /// sets the default output file path and maximum duration based on the current input file (path)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetDefaultOutputFilePath(object sender, EventArgs e)
        {
            string? inputFilePath = tB_SourceFilePath.Text;

            if (inputFilePath.IsValidString() && File.Exists(inputFilePath))
            {
                //create output file path based on input file path and set it if there isn't a path set already
                if (!tB_OutputFilePath.Text.IsValidString())
                {
                    string extension = Path.GetExtension(inputFilePath);
                    string outPutFilePath = inputFilePath.Remove(inputFilePath.LastIndexOf(".")) + "_edited" + extension;
                    tB_OutputFilePath.Text = outPutFilePath;
                }

                //set the end time based on the duration of the input file
                if (FileHandlingUtil.GetVideoFileDuration(inputFilePath, out TimeSpan duration))
                    tP_EndTime.Value = duration;
            }
        }

        /// <summary>
        /// reacts to changed in the edit options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditOptions_CheckedChanged(object sender, EventArgs e)
        {
            bool rotateActive = cB_RotateVideo.Checked;
            bool cutActive = cB_CutVideo.Checked;

            l_EndTime.Enabled = cutActive;
            l_StartTime.Enabled = cutActive;
            tP_StartTime.Enabled = cutActive;
            tP_EndTime.Enabled = cutActive;

            l_Rotate.Enabled = rotateActive;
            cB_RotationAngle.Enabled = rotateActive;

        }

        #endregion
    }
}
