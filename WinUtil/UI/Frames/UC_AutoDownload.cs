using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUtil.Model;
using WinUtil.Util;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
  public partial class UC_AutoDownload : UserControl
  {
    #region private variables
    private bool muteRBFileName = false;
    private bool muteRBDirectoryPath = false;
    private bool clipboardSurveillanceActive = false;

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AddClipboardFormatListener(IntPtr hwnd);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

    #endregion

    public UC_AutoDownload()
    {
      InitializeComponent();

      FileNameOptionsChanged(this, EventArgs.Empty);
      DownloadDirectoryOptionsChanged(this, EventArgs.Empty);
    }

    #region ui event listener functions
    private void FileNameOptionsChanged(object sender, EventArgs e)
    {
      if (!muteRBFileName)
      {
        muteRBFileName = true;

        if (sender == rB_CreateNewFileNames)
          rB_SameFileNames.Checked = !rB_CreateNewFileNames.Checked;
        else
          rB_CreateNewFileNames.Checked = !rB_SameFileNames.Checked;

        bool createFileNames = rB_CreateNewFileNames.Checked;

        l_Prefix.Enabled = createFileNames;
        l_Suffix.Enabled = createFileNames;
        tB_Prefix.Enabled = createFileNames;
        tB_Suffix.Enabled = createFileNames;

        muteRBFileName = false;
      }
    }

    private void Select_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fDi = new()
      {
        ShowNewFolderButton = true,
        RootFolder = Environment.SpecialFolder.UserProfile
      };

      if (fDi.ShowDialog() == DialogResult.OK)
        tB_DownloadDirectory.Text = fDi.SelectedPath;
    }

    private void Start_Click(object sender, EventArgs e)
    {
      clipboardSurveillanceActive = !clipboardSurveillanceActive;

      if (clipboardSurveillanceActive)
        b_Start.BackColor = Color.LightGreen;
      else
        b_Start.BackColor = SystemColors.Control;

      if (clipboardSurveillanceActive)
      {
        Log.Debug("Starting monitoring of clipboard.");
        AddClipboardFormatListener(this.Handle);
      }
      else
      {
        RemoveClipboardFormatListener(this.Handle);
        Log.Debug("Monitoring of clipboard stopped.");
      }
    }

    private void DownloadDirectoryOptionsChanged(object sender, EventArgs e)
    {
      if (!muteRBDirectoryPath)
      {
        muteRBDirectoryPath = true;

        if (sender == rB_UseSpecificDirectory)
          rB_URLBasedDirectory.Checked = !rB_UseSpecificDirectory.Checked;
        else //if (sender == rB_URLBasedDirectory)
          rB_UseSpecificDirectory.Checked = !rB_URLBasedDirectory.Checked;

        bool useURLDirectory = rB_URLBasedDirectory.Checked;

        tB_DownloadDirectory.Enabled = !useURLDirectory;
        b_Select.Enabled = !useURLDirectory;

        if (!useURLDirectory && !tB_DownloadDirectory.Text.IsValidString())
          tB_DownloadDirectory.Text = GetDefaultDownloadDirectoryPath();

        muteRBDirectoryPath = false;
      }
    }

    #endregion

    #region clipboard monitoring functions
    private string prevClipboardString = "";
    private const int WM_CLIPBOARDUPDATE = 0x031D;

    protected override void WndProc(ref Message m)
    {
      switch (m.Msg)
      {
        case WM_CLIPBOARDUPDATE:
          IDataObject iData = Clipboard.GetDataObject();
          if (iData.GetDataPresent(DataFormats.Text))
          {
            string data = (string)iData.GetData(DataFormats.Text);

            if (data.IsURL() && prevClipboardString != data)
            {
              bool createNewFileName = rB_CreateNewFileNames.Checked;
              string prefix = tB_Prefix.Text;
              string suffix = tB_Suffix.Text;

              bool createDirectoryFromURL = rB_URLBasedDirectory.Checked;
              string directoryPath = tB_DownloadDirectory.Text;

              int parallelDownloads = (int)nUD_ParallelDownloads.Value;

              bool overWriteExistingFile = cB_OverWriteExistingFiles.Checked;

              Task.Run(() => DownloadFiles(data, createNewFileName, prefix, suffix, createDirectoryFromURL, directoryPath, parallelDownloads, overWriteExistingFile));
              prevClipboardString = data;
            }
          }
          break;

        default:
          base.WndProc(ref m);
          break;
      }
    }

    private void DownloadFiles(string urls, bool createNewFileName, string prefix, string suffix, bool createDirectoryFromURL, string directoryPath, int parallelDownloads, bool overWriteExistingFile)
    {
      List<string> urlList = new();
      List<DownloadFileInfo> dataList = new();

      if (urls.Contains(Environment.NewLine))
        urlList = urls.Split(Environment.NewLine).ToList();
      else
        urlList = new() { urls };

      foreach (string singleUrl in urlList)
      {
        if (GenerateDownloadFileInfo(singleUrl, createDirectoryFromURL, directoryPath, createNewFileName, prefix, suffix, overWriteExistingFile, out DownloadFileInfo info))
        {
          dataList.Add(info);
          Log.Information($"Added '{info.URL}' to download list.");
        }
        else
          Log.Information($"Couldn't create download information for '{singleUrl}'.");
      }

      if (dataList.Count > 0)
      {
        //acutally download files
        try
        {
          Log.Debug($"Starting download of {dataList.Count} file(-s).");
          Task.Run(async () => await DownloadUtil.DownloadUrlsAsync(dataList, parallelDownloads));
        }
        catch (Exception ex)
        {
          Log.Error("An error occured while downloading files: " + ex.Message);
        }
      }
    }

    #endregion

    #region settings functions
    /// <summary>
    /// reacts to changes in the application settings
    /// </summary>
    internal void SettingsHaveChanged()
    {
      tB_DownloadDirectory.Text = Properties.Settings.Default.downloadDirectroyPath;
    }
    #endregion

    #region download functions
    /// <summary>
    /// generates the needed download file info object for the download
    /// </summary>
    /// <param name="url"></param>
    /// <param name="createDirectoryFromURL"></param>
    /// <param name="directoryPath"></param>
    /// <param name="createNewFileName"></param>
    /// <param name="prefix"></param>
    /// <param name="suffix"></param>
    /// <param name="overWriteExistingFile"></param>
    /// <param name="info"></param>
    /// <returns></returns>
    private bool GenerateDownloadFileInfo(string url, bool createDirectoryFromURL, string directoryPath, bool createNewFileName, string prefix, string suffix, bool overWriteExistingFile, out DownloadFileInfo info)
    {
      bool success = false;
      if (url.Contains('?'))
        url = url.Remove(url.LastIndexOf('?'));

      info = new(url, "");

      //check / create download directory
      string targetDirectoryPath;

      if (createDirectoryFromURL)
      {
        //try to get main name of the website from the file url
        Uri tmpUri = new(url);
        string hostName = tmpUri.Host;

        if (hostName.Contains('.'))
        {
          string[] domainEndings = { ".net", ".com", ".org" };

          foreach (string domainEnding in domainEndings)
          {
            if (hostName.EndsWith(domainEnding))
              hostName = hostName.Replace(domainEnding, "");
          }

          if (hostName.Contains('.'))
          {
            string[] splits = hostName.Split('.');
            int maxStringLength = -1;

            for (int i = 0; i < splits.Length; i++)
            {
              if (splits[i].ToLower().Contains("static"))
                continue;

              if (maxStringLength <= 0)
              {
                maxStringLength = splits[i].Length;
                hostName = splits[i];
              }
              else
              {
                int strLength = splits[i].Length;

                if (strLength > maxStringLength)
                {
                  maxStringLength = strLength;
                  hostName = splits[i];
                }
              }
            }
          }
        }

        targetDirectoryPath = Path.Combine(GetDefaultDownloadDirectoryPath(), hostName);
      }
      else
      {
        targetDirectoryPath = directoryPath;
      }

      bool directoryOK = Directory.Exists(targetDirectoryPath);
      if (!directoryOK)
      {
        try
        {
          Directory.CreateDirectory(targetDirectoryPath);
          directoryOK = true;
          Log.Information($"Successfully created download directory '{targetDirectoryPath}.");
        }
        catch (Exception ex)
        {
          Log.Error($"Failed to create download directory '{targetDirectoryPath}': {ex.Message}");
        }
      }

      if (directoryOK)
      {
        //check / create file path
        string filePath = url.Remove(0, url.LastIndexOf(@"/") + 1);

        if(url.Contains("video-pr"))
        {
          var splits = url.Split('/');
          filePath = $"{splits[splits.Length - 3]}.mp4";
        }
          
        if (filePath.Contains('?'))
          filePath = filePath.Remove(filePath.IndexOf('?'));

        if (createNewFileName)
        {
          string fileExtension = ".jpg";

          if (filePath.Contains('.'))
            fileExtension = filePath.Remove(0, filePath.LastIndexOf("."));
          else
          {
            foreach (string ext in DownloadUtil.FileExtensionList)
            {
              if (filePath.Contains(ext))
              {
                fileExtension = "." + ext;
                break;
              }
            }
          }

          int fileNumber = GetNextFileIndex(targetDirectoryPath, prefix, suffix, fileExtension);

          filePath = prefix + fileNumber.ToString() + suffix + fileExtension;
        }

        filePath = Path.Combine(targetDirectoryPath, filePath);

        if (File.Exists(filePath) && !overWriteExistingFile)
          Log.Warning($"File '{filePath}' already exists.");
        else
        {
          success = true;
          info = new(url, filePath);
        }
      }

      return success;
    }


    private int GetNextFileIndex(string directoryPath, string fileNamePrefix, string fileNameSuffix, string fileExtension)
    {
      int result = 0;

      if (Directory.Exists(directoryPath))
      {
        string[] files = Directory.GetFiles(directoryPath);
        string fileNameEnd = fileNameSuffix + fileExtension;

        foreach (string filePath in files)
        {
          string fileName = Path.GetFileName(filePath);
          if (fileName.StartsWith(fileNamePrefix) && fileName.EndsWith(fileNameEnd))
          {
            string fileNumberString = fileName.Replace(fileNamePrefix, "").Replace(fileNameEnd, "");

            if (int.TryParse(fileNumberString, out int fileNumber))
              result = Math.Max(result, fileNumber);
          }
        }

        if (result != 0)
          result += 1;
      }

      return result;
    }

    private string GetDefaultDownloadDirectoryPath()
    {
      string directoryPath = Properties.Settings.Default.downloadDirectroyPath;

      if (!Directory.Exists(directoryPath))
        directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

      return directoryPath;
    }
    #endregion
  }
}
