using YACUF.Extensions;

namespace WinUtil.UI.Dialogs
{
    /// <summary>
    /// Dialog for setting search parameters of files in a specific directory
    /// </summary>
    public partial class FilesFromDirectoryDialog : Form
    {
        #region properties
        public string DirectoryPath { get; private set; } = "";
        public bool IncludeSubDirectories { get; private set; }
        public bool FilterByExtension { get; private set; }
        public string FileExtensionFilter { get; private set; } = "";

        #endregion

        public FilesFromDirectoryDialog(bool lockFileFilter, string fileFilter = "*.*")
        {
            InitializeComponent();

            if (lockFileFilter)
            {
                cB_FilterFiles.Enabled = false;
                tB_FileExtensionFilter.Enabled = false;
            }

            tB_FileExtensionFilter.Text = fileFilter;

            CheckCurrentInputValues(this, EventArgs.Empty);
            UpdatePropertiesFromInput();
        }

        #region user input event listeners
        private void OK_Click(object sender, EventArgs e)
        {
            UpdatePropertiesFromInput();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UpdatePropertiesFromInput();

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SelectSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDi = new()
            {
                ShowNewFolderButton = false
            };

            if (fDi.ShowDialog() == DialogResult.OK)
                tB_SourceDirectory.Text = fDi.SelectedPath;
        }
        #endregion

        #region logic / check functions
        private void CheckCurrentInputValues(object sender, EventArgs e)
        {
            bool inputValid = false;

            if (tB_SourceDirectory.Text.IsValidString() && tB_FileExtensionFilter.Text.IsValidString())
            {
                if (Directory.Exists(tB_SourceDirectory.Text))
                    inputValid = true;
            }

            b_OK.Enabled = inputValid;

            tB_FileExtensionFilter.Enabled = cB_FilterFiles.Checked;
        }

        private void UpdatePropertiesFromInput()
        {
            DirectoryPath = tB_SourceDirectory.Text;
            IncludeSubDirectories = cB_IncludeSubdirectories.Checked;
            FilterByExtension = cB_FilterFiles.Checked;
            FileExtensionFilter = tB_FileExtensionFilter.Text;
        }

        #endregion
    }
}
