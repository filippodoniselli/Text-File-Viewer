using System.IO;
using System.Windows.Forms;
using System;
using System.Windows;
using ClassLibrary;
using System.Windows.Media;
using System.Drawing;
using SystemColors = System.Drawing.SystemColors;

namespace Windows_Form_UI
{
    public partial class Form1 : Form
    {
        public static string Path { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}

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
                Path = openFileDialog.FileName;
            }
        }


        private void InstructionLabel_Click(object sender, EventArgs e)
        {

        }
        private void ResetClick(object sender, EventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            Path = "";
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
                File.Delete(Path);
                System.Windows.MessageBox.Show("File succesfully deleted", "Notice", MessageBoxButton.OK, MessageBoxImage.Information);
                textBox.Text = "";
                pathBox.Text = "";
                Path = "";
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
        private void SaveClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = ".txt, .config, .xml, .ini|*.txt;*.config;*.xml;*.ini|.json|*.json" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool result = ButtonFunctions.SaveFile(saveFileDialog.FileName, textBox.Text);
                System.Windows.MessageBox.Show(result ? "File succesfully saved" : "Invalid sintax", "Notice", MessageBoxButton.OK, result ? MessageBoxImage.Information : MessageBoxImage.Error);
            }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            bool result = ButtonFunctions.UpdateFile(Path, textBox.Text);
            System.Windows.MessageBox.Show(result ? "File succesfully updated" : "Invalid sintax", "Notice", MessageBoxButton.OK, result ? MessageBoxImage.Information : MessageBoxImage.Error);
        }

        private void IndentClick(object sender, EventArgs e) => textBox.Text = ButtonFunctions.IndentJSON(textBox.Text);

        private void ButtonStyle(object sender, EventArgs e)
        {
            if (textBox.Enabled)
            {
                chooseButton.BackColor = SystemColors.Control;
                chooseButton.ForeColor = SystemColors.ControlDarkDark;
                changeButton.BackColor = SystemColors.GradientActiveCaption;
                changeButton.ForeColor = SystemColors.ControlText;
                indentButton.BackColor = SystemColors.GradientActiveCaption;
                indentButton.ForeColor = SystemColors.ControlText;
                saveButton.BackColor = SystemColors.GradientActiveCaption;
                saveButton.ForeColor = SystemColors.ControlText;
                deleteButton.BackColor = SystemColors.GradientActiveCaption;
                deleteButton.ForeColor = SystemColors.ControlText;
                updateButton.BackColor = SystemColors.GradientActiveCaption;
                updateButton.ForeColor = SystemColors.ControlText;
                resetButton.BackColor = SystemColors.GradientActiveCaption;
                resetButton.ForeColor = SystemColors.ControlText;
            }
            else
            {
                chooseButton.BackColor = SystemColors.GradientActiveCaption;
                chooseButton.ForeColor = SystemColors.ControlText;
                changeButton.BackColor = SystemColors.Control;
                changeButton.ForeColor = SystemColors.ControlDarkDark;
                indentButton.BackColor = SystemColors.Control;
                indentButton.ForeColor = SystemColors.ControlDarkDark;
                saveButton.BackColor = SystemColors.Control;
                saveButton.ForeColor = SystemColors.ControlDarkDark;
                deleteButton.BackColor = SystemColors.Control;
                deleteButton.ForeColor = SystemColors.ControlDarkDark;
                updateButton.BackColor = SystemColors.Control;
                updateButton.ForeColor = SystemColors.ControlDarkDark;
                resetButton.BackColor = SystemColors.Control;
                resetButton.ForeColor = SystemColors.ControlDarkDark;
            }
        }
    }
}
