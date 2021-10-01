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

        private void chooseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Valid text extensions|*.txt;*.config;*.xml;*.json;*.ini"
            };
            openFileDialog.ShowDialog();
            pathBox.Text = openFileDialog.FileName;
            textBox.Text = File.ReadAllText(openFileDialog.FileName);
            resetButton.IsEnabled = true;
            chooseButton.IsEnabled = false;
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            resetButton.IsEnabled = false;
            chooseButton.IsEnabled = true;
        }
    }
}
