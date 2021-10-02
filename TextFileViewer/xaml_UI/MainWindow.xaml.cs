using System.Windows;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Controls.Primitives;
using System.Text;

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

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            chooseButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = ".txt, .config, .xml, .ini|*.txt;*.config;*.xml;*.ini|.json|*.json" };
            if ((bool)saveFileDialog.ShowDialog())
            {
                if (saveFileDialog.FilterIndex == 2)
                {
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        string jsonText = textBox.Text.Trim();
                        if ((jsonText.StartsWith("{") && jsonText.EndsWith("}")) ||
                            (jsonText.StartsWith("[") && jsonText.EndsWith("]")))
                        {
                            try
                            {
                                var obj = JToken.Parse(textBox.Text);
                                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                                MessageBox.Show("File succesfully saved", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            catch (JsonReaderException)
                            {
                                MessageBox.Show("Invalid sintax", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid sintax", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid sintax", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                    MessageBox.Show("File succesfully saved", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                }
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

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextFile.Path.EndsWith(".json"))
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    if ((textBox.Text.Trim().StartsWith("{") && textBox.Text.Trim().EndsWith("}")) ||
                        (textBox.Text.Trim().StartsWith("[") && textBox.Text.Trim().EndsWith("]")))
                    {
                        try
                        {
                            var obj = JToken.Parse(textBox.Text);
                            File.WriteAllText(TextFile.Path, textBox.Text);
                            MessageBox.Show("File succesfully updated", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        catch (JsonReaderException)
                        {
                            MessageBox.Show("Invalid sintax", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid sintax", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                File.WriteAllText(TextFile.Path, textBox.Text);
                MessageBox.Show("File succesfully updated", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void IndentButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox.Text = JToken.Parse(textBox.Text).ToString(Formatting.Indented);
            }
            catch (JsonReaderException)
            {
                MessageBox.Show("Invalid sintax", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception) 
            {
                MessageBox.Show("Invalid sintax", "Notice", MessageBoxButton.OK, MessageBoxImage.Error);
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
    }
}
