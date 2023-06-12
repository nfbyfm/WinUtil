using Serilog;
using System.Diagnostics;
using YACUF.Utilities;

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

            mTB_StartTime.Text = "00:00:00.000";
            mTB_EndTime.Text = "00:00:00.000";
        }

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

                //get arguments based on user input values
                //ffmpeg -i input.wav -vn -ar 44100 -ac 2 -b:a 192k output.mp3
                string arguments = " -i \"" + sourceFilePath + "\" -vn -ar 44100 -ac 2 -b:a 192k \"" + outputFilePath+"\"";

                if (rB_ConvertSection.Checked)
                {
                    //todo: switch to / create own time picker with milliseconds option (add to YACUF?) https://www.codeproject.com/Articles/170684/Time-Picker
                    //todo: get duration of input fle and limit end time control

                    //try to parse start and end time from inputs
                    bool startTimeOk = DateTime.TryParse(mTB_StartTime.Text, out DateTime startTime);
                    bool endTimeOk = DateTime.TryParse(mTB_EndTime.Text, out DateTime endTime);

                    if (startTimeOk && endTimeOk)
                    {
                        Log.Debug("Parsed start time: " + startTime.ToString("HH:mm:ss.fff")+ "; end time: " + endTime.ToString("HH:mm:ss.fff"));
                        
                        //calculate the duration
                        TimeSpan duration;

                        if (endTime > startTime)
                            duration = endTime - startTime;
                        else
                            duration = startTime - endTime;

                        string durationString = string.Format("{0}:{1}:{2}.{3}", (int)duration.TotalHours, duration.Minutes, duration.Seconds, duration.Milliseconds);
                        Log.Debug("Calculated duration: " + durationString);

                        //create argument string for ffmpeg
                        arguments = " -i \"" + sourceFilePath + "\" -ss " + startTime.ToString("HH:mm:ss.fff")+ " -t "+ durationString + " -vn -ar 44100 -ac 2 -b:a 192k \"" + outputFilePath + "\"";
                    }
                    else
                    {
                        if(!startTimeOk)
                            Log.Error("Failed to parse start time from the input value.");

                        if(!endTimeOk)
                            Log.Error("Failed to parse end time from the input value.");

                        return;
                    }
                }

                Log.Debug("Arguments for ffmpeg: '" + arguments + "'");

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
                        if(e.Data.IsValidString())
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
            string inputFilePath = tB_SourceFilePath.Text;

            if (inputFilePath.IsValidString() && File.Exists(inputFilePath))
            {
                string outputFilePath = inputFilePath.Remove(inputFilePath.LastIndexOf(".")) + ".mp3";
                tB_OutputFilePath.Text = outputFilePath;
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
                Filter = "mp4|*.mp4|mpeg|*.mpeg|webm|*.webm",
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
            mTB_StartTime.Enabled = useStartEndTime;
            mTB_EndTime.Enabled = useStartEndTime;
        }
    }
}
