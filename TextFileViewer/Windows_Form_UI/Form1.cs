using System.IO;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Windows;
using ClassLibrary;

namespace Windows_Form_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class TextFile
        {
            private static string path = "";

            public static string Path { get => path; set => path = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChooseFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Valid text extensions|*.txt;*.config;*.xml;*.json;*.ini" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                textBox.Enabled = true;
                changeButton.Enabled = true;
                chooseButton.Enabled = false;
                saveButton.Enabled = true;
                deleteButton.Enabled = true;
                updateButton.Enabled = true;
                indentButton.Enabled = true;
                resetButton.Enabled = true;
                TextFile.Path = openFileDialog.FileName;
            }
        }


        private void InstructionLabel_Click(object sender, EventArgs e)
        {

        }
        private void ResetClick(object sender, EventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            TextFile.Path = "";
            indentButton.Enabled = false;
            textBox.Enabled = false;
            changeButton.Enabled = false;
            chooseButton.Enabled = true;
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
            resetButton.Enabled = false;
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            MessageBoxResult confirm = System.Windows.MessageBox.Show("Are you sure to delete this file?", "Notice", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (confirm == MessageBoxResult.Yes)
            {
                File.Delete(TextFile.Path);
                System.Windows.MessageBox.Show("File succesfully deleted", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                textBox.Text = "";
                pathBox.Text = "";
                TextFile.Path = "";
                indentButton.Enabled = false;
                textBox.Enabled = false;
                changeButton.Enabled = false;
                chooseButton.Enabled = true;
                saveButton.Enabled = false;
                deleteButton.Enabled = false;
                updateButton.Enabled = false;
                resetButton.Enabled = false;
            }
        }

        private void ChangeFile(object sender, EventArgs e)
        {
            chooseButton.Enabled = true;
            chooseButton.PerformClick();
            chooseButton.Enabled = false;
        }
        private void SaveClick(object sender, EventArgs e) => ButtonFunctions.SaveFile(textBox.Text);

        private void UpdateClick(object sender, EventArgs e) => ButtonFunctions.UpdateFile(TextFile.Path, textBox.Text);

        private void IndentClick(object sender, EventArgs e) => textBox.Text = ButtonFunctions.IndentJSON(textBox.Text);
    }
}
