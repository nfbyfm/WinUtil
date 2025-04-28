using Serilog;

namespace WinUtil.UI.Frames
{
  public partial class UC_BskySort : UserControl
  {
    private Dictionary<string, List<string>> _sortedFiles = new();

    public UC_BskySort()
    {
      InitializeComponent();
    }

    private void b_SelectDirectory_Click(object sender, EventArgs e)
    {
      var folderDialog = new FolderBrowserDialog()
      {
        InitialDirectory = Properties.Settings.Default.downloadDirectroyPath,
        ShowNewFolderButton = true
      };

      if (folderDialog.ShowDialog() == DialogResult.OK)
      {
        tB_DirectoryPath.Text = folderDialog.SelectedPath;
        UpdateSortedDictionary();
      }
    }

    private void Update_Click(object sender, EventArgs e)
    {
      UpdateSortedDictionary();
    }

    private void ExecuteSort_Click(object sender, EventArgs e)
    {
      if(_sortedFiles.Count <= 0)
        UpdateSortedDictionary();

      if (_sortedFiles.Count <= 0)
        return;

      string baseDirectoryPath = tB_DirectoryPath.Text;

      foreach (var entry in _sortedFiles)
        CreateSortedDirectory(baseDirectoryPath, entry.Key, entry.Value);

      Log.Information("Sorting files finished.");
    }

    private void CreateSortedDirectory(string baseDirectoryPath, string userName, List<string> filePaths)
    {
      var newDirectoryPath = Path.Combine(baseDirectoryPath, userName);
      if(!Directory.Exists(newDirectoryPath))
      {
        try
        {
          Directory.CreateDirectory(newDirectoryPath);
        }
        catch(Exception ex)
        {
          Log.Error($"Failed to create directory for user name '{userName}': {ex.Message}");
          return;
        }
      }

      foreach(var filePath in filePaths)
      {
        var fileName = Path.GetFileName(filePath);
        //var soureFilePath = Path.Combine(baseDirectoryPath, filePath);
        var targetFilePath = Path.Combine(newDirectoryPath, fileName);

        try
        {
          File.Move(filePath, targetFilePath);
        }
        catch(Exception ex)
        {
          Log.Error($"Failed to move file '{fileName}' to the newly created directory '{userName}': {ex.Message}");
        }
      }
    }

    private void UpdateSortedDictionary()
    {
      _sortedFiles = GetSortedFileDictionary(tB_DirectoryPath.Text, (int)nUD_FilesPerDirectory.Value);
      UpdateTreeView(_sortedFiles);
    }

    private void UpdateTreeView(Dictionary<string, List<string>> sortedFileDictionary)
    {
      tV_SortedFiles.Nodes.Clear();

      if (sortedFileDictionary == null || sortedFileDictionary.Count <= 0)
      {
        Log.Information("No unsorted files could be found.");
        return;
      }
      
      foreach(var sortedDirectory in sortedFileDictionary)
      {
        var nodeText = $"{sortedDirectory.Key} ({sortedDirectory.Value.Count})";
        var node = new TreeNode(nodeText);
        foreach (var filePath in sortedDirectory.Value)
          node.Nodes.Add(Path.GetFileName(filePath));

        tV_SortedFiles.Nodes.Add(node);
      }
    }

    private static Dictionary<string, List<string>> GetSortedFileDictionary(string directoryPath, int minNumberOfFiles)
    {
      var files = Directory.GetFiles(directoryPath, "*", SearchOption.TopDirectoryOnly);
      var sortedFiles = new Dictionary<string, List<string>>();

      foreach (var file in files)
      {
        if (!GetUserNameFromFileName(file, out var userName)) continue;

        if (sortedFiles.ContainsKey(userName))
          sortedFiles[userName].Add(file);
        else
          sortedFiles.Add(userName, new List<string>() { file });
      }

      for(int i = sortedFiles.Count-1; i>=0; i--)
      {
        var keyValuePair = sortedFiles.ElementAt(i);

        if(keyValuePair.Value.Count()<minNumberOfFiles)
          sortedFiles.Remove(keyValuePair.Key);
      }

      return sortedFiles;
    }

    private static bool GetUserNameFromFileName(string filePath, out string userName)
    {
      userName = string.Empty;

      if (string.IsNullOrEmpty(filePath)) return false;
      
      var fileName = Path.GetFileName(filePath);
      if(string.IsNullOrEmpty(fileName)) return false;

      if (!fileName.Contains('_')) return false;
      if (fileName.ToLower().Contains("bsky_"))
      {
        var splits = fileName.Split('_');
        if (splits.Length < 2) return false;

        userName = splits[1];
      }
      else
      {
        userName = fileName.Remove(fileName.IndexOf('_'));        
      }

      return true;
    }
  }
}
