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
        public static string Path { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
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
                Path = openFileDialog.FileName;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult confirm = MessageBox.Show("Are you sure to delete this file?", "Notice", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (confirm == MessageBoxResult.Yes)
            {
                File.Delete(Path);
                MessageBox.Show("File succesfully deleted", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                resetButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            Path = "";
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = ".txt, .config, .xml, .ini|*.txt;*.config;*.xml;*.ini|.json|*.json" };
            if ((bool)saveFileDialog.ShowDialog())
            {
                bool result = ButtonFunctions.SaveFile(saveFileDialog.FileName, textBox.Text);
                MessageBox.Show(result ? "File succesfully saved" : "Invalid sintax", "Notice", MessageBoxButton.OK, result ? MessageBoxImage.Information : MessageBoxImage.Error );
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            bool result = ButtonFunctions.UpdateFile(Path, textBox.Text);
            MessageBox.Show(result ? "File succesfully updated" : "Invalid sintax", "Notice", MessageBoxButton.OK, result ? MessageBoxImage.Information : MessageBoxImage.Error);
        }
        private void IndentButton_Click(object sender, RoutedEventArgs e) => textBox.Text = ButtonFunctions.IndentJSON(textBox.Text);

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Draggable(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
