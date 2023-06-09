using Serilog;
using YACUF.Utilities;

namespace WinUtil.UI.Frames
{
    public partial class UC_DirectoryInfo : UserControl
    {
        public UC_DirectoryInfo()
        {
            InitializeComponent();
        }

        #region user input event listeners
        private void SelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDi = new()
            {
                ShowNewFolderButton = false
            };

            if (fDi.ShowDialog() == DialogResult.OK)
                tB_Directory.Text = fDi.SelectedPath;
        }

        private void Directory_TextChanged(object sender, EventArgs e)
        {
            UpdateViews();
        }
        #endregion

        #region logic
        /// <summary>
        /// updates the views based on the currently selected direcory
        /// </summary>
        private void UpdateViews()
        {
            string directoryPath = tB_Directory.Text;

            if (directoryPath.IsValidString())
            {
                if (Directory.Exists(directoryPath))
                {
                    //todo: implement collection and display of information concerning the current directory

                }
                else
                {
                    Log.Warning("The given directory path '" + directoryPath + "' doesn't exitst.");
                }
            }
            else
            {
                Log.Warning("The current directory is not a vlid path.");
            }
        }
        #endregion


    }
}
