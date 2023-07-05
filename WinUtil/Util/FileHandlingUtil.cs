using Serilog;
using System.Diagnostics;
using WinUtil.Model;
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

        #region file size functions
        /// <summary>
        /// tries to get the file size in bytes
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static long GetFileSize(string? filePath)
        {
            long size = 0;

            if (filePath.IsValidString() && File.Exists(filePath))
                size = new FileInfo(filePath).Length;

            return size;
        }

        /// <summary>
        /// creates the size info string for a treenode
        /// </summary>
        /// <param name="directorySize"></param>
        /// <param name="fileSize"></param>
        /// <returns></returns>
        public static string GetSizeString(long directorySize, long fileSize)
        {
            string result = "[" + GetFileSizeAsString(directorySize + fileSize);

            if (directorySize > 0)
            {
                if (fileSize <= 0)
                    result += "; dirs only";
                else
                    result += "; dir: " + GetFileSizeAsString(directorySize);
            }

            if (fileSize > 0)
            {
                if (directorySize <= 0)
                    result += "; files only";
                else
                    result += "; files: " + GetFileSizeAsString(fileSize);
            }

            result += "]";

            return result;
        }

        /// <summary>
        /// creates string consisting of converted size and league of bytes
        /// </summary>
        /// <param name="sizeInBytes"></param>
        /// <returns></returns>
        public static string GetFileSizeAsString(long sizeInBytes)
        {
            FileSize tSize = GetFileSize(sizeInBytes, out int totalSize);

            string result = totalSize.ToString() + " ";

            switch (tSize)
            {
                case FileSize.Bytes:
                    result += "bytes";
                    break;
                case FileSize.KiloBytes:
                    result += "KB";
                    break;
                case FileSize.MegaBytes:
                    result += "MB";
                    break;
                case FileSize.GigaBytes:
                    result += "GB";
                    break;
                case FileSize.PetaBytes:
                    result += "PB";
                    break;
                default:
                    result += "undef";
                    break;
            }

            return result;
        }

        /// <summary>
        /// converts size in bytes into human usable league
        /// </summary>
        /// <param name="sizeInBytes"></param>
        /// <param name="convertedSize"></param>
        /// <returns></returns>
        public static FileSize GetFileSize(long sizeInBytes, out int convertedSize)
        {
            FileSize result = FileSize.Bytes;
            convertedSize = 0;

            if (sizeInBytes > 0)
            {
                if (sizeInBytes > 1024)
                {
                    sizeInBytes /= 1024;

                    if (sizeInBytes > 1024)
                    {
                        sizeInBytes /= 1024;

                        if (sizeInBytes > 1024)
                        {
                            sizeInBytes /= 1024;

                            if (sizeInBytes > 1024)
                            {
                                sizeInBytes /= 1024;
                                result = FileSize.PetaBytes;
                                convertedSize = (int)sizeInBytes;
                            }
                            else
                            {
                                result = FileSize.GigaBytes;
                                convertedSize = (int)sizeInBytes;
                            }
                        }
                        else
                        {
                            result = FileSize.MegaBytes;
                            convertedSize = (int)sizeInBytes;
                        }
                    }
                    else
                    {
                        result = FileSize.KiloBytes;
                        convertedSize = (int)sizeInBytes;
                    }
                }
                else
                {
                    convertedSize = (int)sizeInBytes;
                }
            }


            return result;
        }

        #endregion

        /// <summary>
        /// searches through a directory, checks for files whose names begin and end with specified string and then searches for the maximum number occuring in the found filenames
        /// </summary>
        /// <param name="fileOrDirectoryPath">path of the directory or file path whose directory to search through</param>
        /// <param name="fileNamePrefix">the start of the file names</param>
        /// <param name="fileNameSuffix">the end of the file names</param>
        /// <returns>maximum number found in file names plus one</returns>
        public static int GetFileNumberStartIndex(string? fileOrDirectoryPath, string fileNamePrefix, string fileNameSuffix)
        {
            int startIndex = 0;

            if (fileOrDirectoryPath.IsValidString())
            {
                string? directoryPath = null;

                if (File.Exists(fileOrDirectoryPath))
                {
                    directoryPath = Path.GetDirectoryName(fileOrDirectoryPath);

                    if (directoryPath == null)
                    {
                        Log.Error($"Failed to get directory path from file path '{fileOrDirectoryPath}'.");
                        return 0;
                    }
                }
                else if (Directory.Exists(fileOrDirectoryPath))
                    directoryPath = fileOrDirectoryPath;

                if (directoryPath.IsValidString())
                {
                    List<string> existingFiles = Directory.GetFiles(directoryPath).ToList();

                    if (existingFiles.Count > 0)
                    {
                        int foundIndex = -1;

                        foreach (string filePath in existingFiles)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(filePath);
                            if (fileName.StartsWith(fileNamePrefix) && fileName.EndsWith(fileNameSuffix))
                            {
                                string possibleFileIndex = fileName;

                                if (fileNamePrefix.IsValidString())
                                    possibleFileIndex = possibleFileIndex.Replace(fileNamePrefix, "");

                                if (fileNameSuffix.IsValidString())
                                    possibleFileIndex = possibleFileIndex.Replace(fileNameSuffix, "");

                                if (int.TryParse(possibleFileIndex, out int number))
                                {
                                    foundIndex = Math.Max(foundIndex, number);
                                }
                            }
                        }

                        startIndex = foundIndex + 1;
                    }
                }
            }
            return startIndex;
        }
    }
}
