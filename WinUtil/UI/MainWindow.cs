using Serilog;
using Serilog.Sinks.RichTextBoxForms.Themes;

namespace WinUtil
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

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