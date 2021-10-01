using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace Windows_Form_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ChooseFile(object sender, EventArgs e)
        {
            _ = fileChose.ShowDialog();
        }

        private void ShowPathFile(object sender, CancelEventArgs e)
        {
            pathBox.Text = fileChose.FileName;
            textBox.Text = File.ReadAllText(pathBox.Text);
            changeButton.Enabled = true;
            chooseButton.Enabled = false;
        }

        private void ChangeFile(object sender, EventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            fileChose.FileName = "";
            changeButton.Enabled = false;
            chooseButton.Enabled = true;
        }
    }
}
