using Serilog;
using System.Diagnostics;
using YACUF.Extensions;

namespace WinUtil.Util
{
    public static class FileHandlingUtil
    {
        /// <summary>
        /// deletes a directory and its sub directories if none of them contain files anymore
        /// </summary>
        /// <param name="directoryPath">the path of the directory to delete if empty</param>
        public static void DeleteEmptyDirectories(string directoryPath)
        {
            if (directoryPath.IsValidString() && Directory.Exists(directoryPath))
            {
                try
                {
                    //try to delete sub directories
                    foreach (string subDirectoryPath in Directory.EnumerateDirectories(directoryPath))
                        DeleteEmptyDirectories(subDirectoryPath);

                    //check if directory has any elements left (if so, don't delete the directory)
                    List<string> entries = Directory.EnumerateFileSystemEntries(directoryPath).ToList();

                    if (!entries.Any())
                    {
                        try
                        {
                            Directory.Delete(directoryPath);
                            Log.Information("Successfully deleted directory '" + directoryPath + "' (is empty).");
                        }
                        catch (Exception ex)
                        {
                            Log.Error("Failed to delete directory '" + directoryPath + "': " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Error("Failed to delete directory '" + directoryPath + "': " + ex.Message);
                }
            }

        }


        /// <summary>
        /// tries to get the duration of a video file using ffmpeg
        /// </summary>
        /// <param name="filePath">the absolute path of the video file</param>
        /// <param name="result">the duration of the video file</param>
        /// <param name="ffmpegExecutableFilePath">(optional) the path of the ffmpeg executable (if left empty, the path from the application settings gets used)</param>
        /// <returns>true if duration could be found out, false otherwise</returns>
        public static bool GetVideoFileDuration(string filePath, out TimeSpan result, string ffmpegExecutableFilePath = "")
        {
            if (!File.Exists(ffmpegExecutableFilePath))
                ffmpegExecutableFilePath = Properties.Settings.Default.ffmpegFilePath;

            if (File.Exists(ffmpegExecutableFilePath))
            {
                StreamReader errorreader;

                Process ffmpeg = new Process();

                ffmpeg.StartInfo.UseShellExecute = false;
                ffmpeg.StartInfo.ErrorDialog = false;
                ffmpeg.StartInfo.RedirectStandardError = true;



                ffmpeg.StartInfo.FileName = ffmpegExecutableFilePath;
                ffmpeg.StartInfo.Arguments = "-i \"" + filePath + "\"";

                ffmpeg.Start();

                errorreader = ffmpeg.StandardError;

                ffmpeg.WaitForExit();

                string res = errorreader.ReadToEnd();

                string duration = res.Substring(res.IndexOf("Duration: ") + ("Duration: ").Length, ("00:00:00.00").Length);

                return TimeSpan.TryParse(duration, out result);
            }
            else
            {
                result = new();
                return false;
            }
        }
    }
}
