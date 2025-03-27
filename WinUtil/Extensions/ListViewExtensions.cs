using Serilog;
using YACUF.Extensions;

namespace WinUtil.Extensions
{
  public static class ListViewExtensions
  {
    public static void SetFileListFromClipboard(this ListView listView)
    {
      var clipboardText = Clipboard.GetText();

      if (!clipboardText.IsValidString())
      {
        Log.Error("Current clipboard is empty.");
        return;
      }

      var lines = clipboardText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
      var filePaths = lines.Where(x => File.Exists(x));

      if(filePaths==null || filePaths.Count() == 0)
      {
        Log.Error("No file paths could be found in the current clipboard text.");
        return;
      }

      listView.Items.Clear();
      filePaths.ForEach(x => listView.Items.Add(x));
    }

    public static void SetFileListFromDirectoryPath(this ListView listView, string directoryPath, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
    {
      if(!Directory.Exists(directoryPath))
      {
        Log.Error($"Directory '{directoryPath}' does not exist.");
        return;
      }

      var filePaths = Directory.GetFiles(directoryPath, searchPattern, searchOption).ToList();

      if (filePaths == null || filePaths.Count() == 0)
      {
        Log.Error($"No file paths could be found in the directory '{directoryPath}'.");
        return;
      }

      listView.Items.Clear();
      filePaths.ForEach(x => listView.Items.Add(x));
    }

    public static List<string> GetFilePaths(this ListView listView)
    {
      var filePaths = new List<string>();

      foreach(var item in listView.Items)
      {
        if (item == null) continue;
        
        var filePath = ((ListViewItem)item).Text;
        if (!filePath.IsValidString()) continue;

        filePaths.Add(filePath);
      }

      return filePaths;       
    }
  }
}
