using WinUtil.Model;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.Extensions
{
    /// <summary>
    /// extensions class for RenameFileinfo
    /// </summary>
    internal static class RenameFileInfoExtensions
    {
        /// <summary>
        /// converts a list of filepaths into a list of renamefileinfos
        /// </summary>
        /// <param name="fileList"></param>
        /// <returns></returns>
        public static List<RenameFileInfo> ToRenameFileInfoList(this List<string>? fileList)
        {
            List<RenameFileInfo> result = new();

            if(fileList !=null && fileList.HasElements(out int elemCount))
            {
                for(int i=0;i<elemCount;i++)
                {
                    result.Add(new(fileList[i]));
                }
            }

            return result;
        }

        /// <summary>
        /// replaces text in each destionation path of the list elements with a replacement text
        /// </summary>
        /// <param name="dataList"></param>
        /// <param name="searchText"></param>
        /// <param name="replacementText"></param>
        public static bool ReplaceText(this List<RenameFileInfo>? dataList, string searchText, string replacementText)
        {
            bool searchTextFound = false;

            if (dataList.HasElements(out int elemCount) && searchText.IsValidString() && replacementText!=null)
            {
                for (int i = 0; i < elemCount; i++)
                {
                    string fileName = Path.GetFileNameWithoutExtension(dataList[i].DestinationFilePath);
                    
                    if (fileName.Contains(searchText))
                    {
                        string? directory = Path.GetDirectoryName(dataList[i].DestinationFilePath);
                        string extension = Path.GetExtension(dataList[i].DestinationFilePath);

                        fileName = fileName.Replace(searchText, replacementText) + extension;
                                                
                        if (directory != null)
                        {
                            dataList[i].DestinationFilePath = Path.Combine(directory, fileName);
                        }
                        else
                        {
                            dataList[i].DestinationFilePath = fileName;
                        }

                        searchTextFound = true;
                    }
                }
            }

            return searchTextFound;
        }

        /// <summary>
        /// creates new file names for the current list of files
        /// </summary>
        /// <param name="dataList"></param>
        /// <param name="prefix"></param>
        /// <param name="suffix"></param>
        /// <param name="sortCriteria"></param>
        public static void CreateNewFileNames(this List<RenameFileInfo>? dataList, string prefix, string suffix,  OrderFileListByCriteria sortCriteria)
        {
            if(dataList.HasElements(out int fileCount))
            {
                List<string> filePaths = dataList.Select(x => x.SourecFilePath).ToList();

                switch (sortCriteria)
                {
                    case OrderFileListByCriteria.CreationDate:
                        filePaths = filePaths.OrderBy(x => (new FileInfo(x)).CreationTime).ToList();
                        break;
                    case OrderFileListByCriteria.ChangeDate:
                        filePaths = filePaths.OrderBy(x => (new FileInfo(x)).LastWriteTime).ToList();
                        break;
                    case OrderFileListByCriteria.FileName:
                    default:
                        filePaths = filePaths.OrderBy(x => x).ToList();
                        break;
                }

                dataList.Clear();

                int startIndex = FileHandlingUtil.GetFileNumberStartIndex(filePaths[0], prefix, suffix);
                int maxDigits = (filePaths.Count + startIndex).Digits();

                for (int i=0;i< filePaths.Count; i++)
                {                    
                    string? directory = Path.GetDirectoryName(filePaths[i]);
                    string extension = Path.GetExtension(filePaths[i]);

                    if(directory.IsValidString())
                    {
                        string targetFilePath = Path.Combine(directory, prefix + (startIndex + i).ToString("D" + maxDigits.ToString()) + suffix + extension);
                        dataList.Add(new(filePaths[i], targetFilePath));
                    }                    
                }
            }
        }
    }
}
