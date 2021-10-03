using System;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClassLibrary
{
    public class ButtonFunctions
    {
        public static void SaveFile(string content)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = ".txt, .config, .xml, .ini|*.txt;*.config;*.xml;*.ini|.json|*.json" };
            if ((bool)saveFileDialog.ShowDialog())
            {
                if (saveFileDialog.FilterIndex == 2)
                {
                    if (!string.IsNullOrWhiteSpace(content))
                    {
                        if ((content.Trim().StartsWith("{") && content.Trim().EndsWith("}")) ||
                            (content.Trim().StartsWith("[") && content.Trim().EndsWith("]")))
                        {
                            try
                            {
                                var obj = JToken.Parse(content);
                                File.WriteAllText(saveFileDialog.FileName, content);
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
                    File.WriteAllText(saveFileDialog.FileName, content);
                    MessageBox.Show("File succesfully saved", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
        public static void UpdateFile(string path, string content)
        {
            if (path.EndsWith(".json"))
            {
                if (!string.IsNullOrWhiteSpace(content))
                {
                    if ((content.Trim().StartsWith("{") && content.Trim().EndsWith("}")) ||
                        (content.Trim().StartsWith("[") && content.Trim().EndsWith("]")))
                    {
                        try
                        {
                            var obj = JToken.Parse(content);
                            File.WriteAllText(path, content);
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
                File.WriteAllText(path, content);
                MessageBox.Show("File succesfully updated", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public static string IndentJSON(string content) => JToken.Parse(content).ToString(Formatting.Indented);
    }
}
