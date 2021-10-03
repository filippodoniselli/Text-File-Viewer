using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Windows.Controls.Primitives;
using ClassLibrary;

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
                indentButton.IsEnabled = true;
                resetButton.IsEnabled = true;
                TextFile.Path = openFileDialog.FileName;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult confirm = MessageBox.Show("Are you sure to delete this file?", "Notice", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (confirm == MessageBoxResult.Yes)
            {
                File.Delete(TextFile.Path);
                MessageBox.Show("File succesfully deleted", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                textBox.Text = "";
                pathBox.Text = "";
                TextFile.Path = "";
                indentButton.IsEnabled = false;
                textBox.IsEnabled = false;
                changeButton.IsEnabled = false;
                chooseButton.IsEnabled = true;
                saveButton.IsEnabled = false;
                deleteButton.IsEnabled = false;
                updateButton.IsEnabled = false;
                resetButton.IsEnabled = false;
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            TextFile.Path = "";
            indentButton.IsEnabled = false;
            textBox.IsEnabled = false;
            changeButton.IsEnabled = false;
            chooseButton.IsEnabled = true;
            saveButton.IsEnabled = false;
            deleteButton.IsEnabled = false;
            updateButton.IsEnabled = false;
            resetButton.IsEnabled = false;
        }
        private void ChangeButton_Click(object sender, RoutedEventArgs e) => chooseButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        
        private void SaveButton_Click(object sender, RoutedEventArgs e) => ButtonFunctions.SaveFile(textBox.Text);

        private void UpdateButton_Click(object sender, RoutedEventArgs e) => ButtonFunctions.UpdateFile(TextFile.Path, textBox.Text);

        private void IndentButton_Click(object sender, RoutedEventArgs e) => textBox.Text = ButtonFunctions.IndentJSON(textBox.Text);


    }
}
