using System.Diagnostics;

namespace FifaCareerManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGithub(object sender, System.Windows.RoutedEventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/ddervisis/fcm/issues",
                UseShellExecute = true
            };
            Process.Start(processStartInfo);
        }
    }
}
