using Serilog;
using System.Diagnostics;
using WinUtil.Extensions;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
  public partial class UC_ConvertToMp3 : UserControl
  {
    public UC_ConvertToMp3()
    {
      InitializeComponent();
    }

    #region UI event listeners
    private void SelectFromClipboard_Click(object sender, EventArgs e)
    {
      lV_Files.SetFileListFromClipboard();
    }

    private void SelectFromDirectory_Click(object sender, EventArgs e)
    {
      var folderDialog = new FolderBrowserDialog();

      if (folderDialog.ShowDialog() == DialogResult.OK)
        lV_Files.SetFileListFromDirectoryPath(folderDialog.SelectedPath);
    }

    private void StartConvert_Click(object sender, EventArgs e)
    {
      var filePaths = lV_Files.GetFilePaths();
      if (filePaths == null || filePaths.Count == 0)
        return;

      Parallel.ForEach(filePaths, filePath => {
        ConvertFileToMp3(filePath);
      });      

      Log.Information($"Finished converting {filePaths.Count} files into the mp3 format.");
    }


    private void ConvertFileToMp3(string sourceFilePath)
    {
      string ffmpegFilePath = Properties.Settings.Default.ffmpegFilePath;

      var outputFilePath = $"{sourceFilePath.Remove(sourceFilePath.LastIndexOf('.'))}.mp3";
      var arguments = " -i \"" + sourceFilePath + "\" -vn -ar 44100 -ac 2 -b:a 192k \"" + outputFilePath + "\"";

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

    #endregion

  }
}
