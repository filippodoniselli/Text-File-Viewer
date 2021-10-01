using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace xaml_UI
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Valid text extensions|*.txt;*.config;*.xml;*.json;*.ini"
            };
            if ((bool)openFileDialog.ShowDialog())
            {
                pathBox.Text = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                changeButton.IsEnabled = true;
                chooseButton.IsEnabled = false;
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            changeButton.IsEnabled = false;
            chooseButton.IsEnabled = true;
        }
    }
}
