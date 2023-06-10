using YACUF.Utilities;

namespace WinUtil.UI.Dialogs
{
    /// <summary>
    /// dialog for generating urls
    /// </summary>
    public partial class GenerateURLsDialog : Form
    {
        public GenerateURLsDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// handles user click onto OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// handles user click onto Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// generates a list of urls based on the user input
        /// </summary>
        /// <param name="urls">list of generated urls</param>
        /// <returns>ture if inputs are valid</returns>
        public bool GetURLList(out List<string> urls)
        {
            urls = new();

            string prefix = tB_UrlPrefix.Text;
            string suffix = TB_UrlSuffix.Text;
            uint tmpNumber1 = (uint)nUD_StartNumber.Value;
            uint tmpNumber2 = (uint)nUD_EndNumber.Value;

            if(prefix.IsValidString() && suffix.IsValidString() && tmpNumber1 != tmpNumber2)
            {
                uint startNumber = Math.Min(tmpNumber1, tmpNumber2);
                uint endNumber = Math.Max(tmpNumber1, tmpNumber2);

                for (int i = (int)startNumber; i <= endNumber; i++)
                {
                    string url = prefix + i.ToString() + suffix;
                    urls.Add(url);
                }
            }

            return urls.Count>0;
        }
    }
}
