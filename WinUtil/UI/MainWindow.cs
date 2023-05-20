using Serilog;
using Serilog.Sinks.RichTextBoxForms.Themes;

namespace WinUtil
{
    /// <summary>
    /// the main window of the application
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// constructor of the main window of the application
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            //setup the logger (send / display in the rich textbox)
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.RichTextBox(this.outputRichTextBox,
                    theme: ThemePresets.Dark,
                    outputTemplate: "[{Timestamp:yyyy.MM.dd HH:mm:ss}] [{Level:u3}]:  {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            Log.Information("Application started.");
        }
    }
}