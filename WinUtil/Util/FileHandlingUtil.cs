using Serilog;
using YACUF.Utilities;

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

    }
}
