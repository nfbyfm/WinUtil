using Serilog;
using System.Diagnostics;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
    /// <summary>
    /// usercontrol for converting a video file into an audio file
    /// </summary>
    public partial class UC_VideoToAudio : UserControl
    {
        public UC_VideoToAudio()
        {
            InitializeComponent();

            //update the checked states of the radio buttons
            ConvertOptionsChanged(this, EventArgs.Empty);
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
        /// executes the actual conversion of the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertFile_Click(object sender, EventArgs e)
        {
            string ffmpegFilePath = Properties.Settings.Default.ffmpegFilePath;
            string sourceFilePath = tB_SourceFilePath.Text;

            bool ffmpegOK = ffmpegFilePath.IsValidString() && File.Exists(ffmpegFilePath);
            bool filePathOk = sourceFilePath.IsValidString() && File.Exists(sourceFilePath);

            if (ffmpegOK && filePathOk)
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

                //get arguments based on user input values
                string arguments = " -i \"" + sourceFilePath + "\" -vn -ar 44100 -ac 2 -b:a 192k \"" + outputFilePath + "\"";

                if (rB_ConvertSection.Checked)
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

                    //create argument string for ffmpeg
                    arguments = " -i \"" + sourceFilePath + "\" -ss " + startTimeString + " -t " + durationString + " -vn -ar 44100 -ac 2 -b:a 192k \"" + outputFilePath + "\"";
                }

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
            }
        }

        /// <summary>
        /// sets the default output file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetDefaultOutputFilePath(object sender, EventArgs e)
        {
            string? inputFilePath = tB_SourceFilePath.Text;

            if (inputFilePath.IsValidString() && File.Exists(inputFilePath))
            {
                //if the output file path hasn't been set: put together a possible new path based on the input file path
                if (!tB_OutputFilePath.Text.IsValidString())
                {
                    string outputFilePath = inputFilePath.Remove(inputFilePath.LastIndexOf(".")) + ".mp3";
                    tB_OutputFilePath.Text = outputFilePath;
                }

                //set the end time based on the duration of the input file
                if (FileHandlingUtil.GetVideoFileDuration(inputFilePath, out TimeSpan duration))
                    tP_EndTime.Value = duration;
            }
       }

        /// <summary>
        /// lets the user set the output file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetOutputFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saDi = new()
            {
                Filter = "mp3|*.mp3|wav|*.wav|flac|*.flac",
                RestoreDirectory = true,
                Title = "Set output file path"
            };

            if (saDi.ShowDialog() == DialogResult.OK)
                tB_OutputFilePath.Text = saDi.FileName;
        }

        /// <summary>
        /// lets the user select the source file path via dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSourceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDi = new()
            {
                Filter = "video file|*.mp4;*.mpeg;*.mpg;*.webm;*.avi",
                Multiselect = false,
                RestoreDirectory = true,
                Title = "Select video file for conversion"
            };

            if (oDi.ShowDialog() == DialogResult.OK)
                tB_SourceFilePath.Text = oDi.FileName;
        }

        /// <summary>
        /// reacts to changes in the conversion options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertOptionsChanged(object sender, EventArgs e)
        {
            if (rB_ConvertSection.Checked)
                if (rB_ConvertWholeFile.Checked)
                    rB_ConvertWholeFile.Checked = false;

            if (rB_ConvertWholeFile.Checked)
                if (rB_ConvertSection.Checked)
                    rB_ConvertSection.Checked = false;


            bool useStartEndTime = rB_ConvertSection.Checked;

            l_StartTime.Enabled = useStartEndTime;
            l_EndTime.Enabled = useStartEndTime;
            tP_StartTime.Enabled = useStartEndTime;
            tP_EndTime.Enabled = useStartEndTime;
        }

        #endregion
    }
}
