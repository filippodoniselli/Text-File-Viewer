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

        public static class TextFile
        {
            private static string path = "";

            public static string Path { get => path; set => path = value; }
        }
        private void ChooseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Valid text extensions|*.txt;*.config;*.xml;*.json;*.ini" };
            if ((bool)openFileDialog.ShowDialog())
            {
                pathBox.Text = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                textBox.IsEnabled = true;
                changeButton.IsEnabled = true;
                chooseButton.IsEnabled = false;
                saveButton.IsEnabled = true;
                deleteButton.IsEnabled = true;
                updateButton.IsEnabled = true;
                TextFile.Path = openFileDialog.FileName;
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            TextFile.Path = "";
            textBox.IsEnabled = false;
            changeButton.IsEnabled = false;
            chooseButton.IsEnabled = true;
            saveButton.IsEnabled = false;
            deleteButton.IsEnabled = false;
            updateButton.IsEnabled = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Text file|*.txt;*.config;*.xml;*.ini|JSON file|*.json" };
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FilterIndex == 2)
            {
                MessageBox.Show("File json saved", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                MessageBox.Show("File succesfully saved", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(TextFile.Path);
            MessageBox.Show("File succesfully deleted", "Notice", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            textBox.Text = "";
            pathBox.Text = "";
            TextFile.Path = "";
            textBox.IsEnabled = false;
            changeButton.IsEnabled = false;
            chooseButton.IsEnabled = true;
            saveButton.IsEnabled = false;
            deleteButton.IsEnabled = false;
            updateButton.IsEnabled = false;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(TextFile.Path, textBox.Text);
            MessageBox.Show("File succesfully updated", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
