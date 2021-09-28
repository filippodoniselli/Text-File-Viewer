using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ChooseFilePath(object sender, EventArgs e)
        {
            _ = fileChose.ShowDialog();
        }

        private void ShowPathFile(object sender, CancelEventArgs e)
        {
            pathLabel.Text = fileChose.FileName;
            showButton.Enabled = true;
        }

        private void ShowText(object sender, EventArgs e)
        {
            textBox.Visible = true;
            textBox.Text = File.ReadAllText(pathLabel.Text);
            clearButton.Enabled = true;
        }

        private void ClearText(object sender, EventArgs e)
        {
            textBox.Visible = false;
            textBox.Text = "";
            pathLabel.Text = "";
            fileChose.FileName = "";
            showButton.Enabled = false;
            clearButton.Enabled = false;
        }
    }
}
