using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUtil.Extensions;
using YACUF.Extensions;

namespace WinUtil.UI.Frames
{
    public partial class UC_ImageResize : UserControl
    {
        public UC_ImageResize()
        {
            InitializeComponent();
            FileNamesOptions_Changed(this, EventArgs.Empty);
        }

        #region ui event listeners

        private void FileNamesOptions_Changed(object sender, EventArgs e)
        {
            bool createNewFileNames = rB_CreateNewFileNames.Checked;

            l_Prefix.Enabled = createNewFileNames;
            l_Suffix.Enabled = createNewFileNames;
            tB_Prefix.Enabled = createNewFileNames;
            tB_Suffix.Enabled = createNewFileNames;
        }

        private void FilesFromDialog_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListViaFileDialog("Select images to convert", "image file|*.jpg;*.jpeg;*.png;*.bmp");
        }

        private void FilesFromDirectory_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListFromDirectorySimple("*.jpg;*.jpeg;*.png;*.bmp");
        }

        private void FilesFromClipboard_Click(object sender, EventArgs e)
        {
            rTB_FileList.SetFileListFromClipboard();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ResizeImageFiles(rTB_FileList.Lines.ToList(), (int)nUD_ImageWidth.Value, rB_UseSameFileNames.Checked, tB_Prefix.Text, tB_Suffix.Text);
        }

        #endregion

        /// <summary>
        /// resizes a list of images based on new width
        /// </summary>
        /// <param name="filePaths"></param>
        private void ResizeImageFiles(List<string> filePaths, int newWidth, bool useSameFilePath, string prefix, string suffix)
        {
            if (filePaths.HasElements(out int fileCount))
            {
                for (int i = 0; i < fileCount; i++)
                {
                    if (File.Exists(filePaths[i]))
                    {
                        try
                        {
                            Bitmap img = new(filePaths[i]);

                            if (img.Width != newWidth)
                            {
                                int newHeight = (int)((double)newWidth * ((double)img.Height / (double)img.Width));

                                using (Bitmap newImage = ResizeImage(img, newWidth, newHeight))
                                {
                                    img.Dispose();

                                    if (useSameFilePath)
                                    {
                                        newImage.Save(filePaths[i]);
                                        Log.Information($"Resized and saved '{filePaths[i]}'.");
                                    }
                                    else
                                    {
                                        string? directoryPath = Path.GetDirectoryName(filePaths[i]);
                                        string? fileExtension = Path.GetExtension(filePaths[i]);
                                        bool validDirectory = Directory.Exists(directoryPath);
                                        bool validExtension = fileExtension != null;

                                        if (validDirectory && validExtension)
                                        {
                                            string newFilePath = Path.Combine(directoryPath, prefix + (i+1).ToString() + suffix + "." + fileExtension);
                                            newImage.Save(newFilePath);
                                            Log.Information($"Resized and saved '{filePaths[i]}' to '{newFilePath}'.");
                                        }
                                        else
                                        {
                                            if (!validDirectory)
                                                Log.Error($"Failed to get the directory path from '{filePaths[i]}'.");

                                            if (!validExtension)
                                                Log.Error($"Filed to get the extension of '{filePaths[i]}'.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                img.Dispose();
                                Log.Information($"Image '{filePaths[i]}' already has a width of {newWidth} pixel.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Error($"Failed to convert image '{filePaths[i]}': {ex.Message}; {ex.StackTrace}");
                        }
                    }
                }
            }
            else
            {
                Log.Warning("No file paths found.");
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        internal static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
