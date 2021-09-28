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
            pathBox.Text = fileChose.FileName;
            pathBox.Visible = true;
            textBox.Visible = true;
            textBox.Text = File.ReadAllText(pathBox.Text);
            pathButton.Visible = false;
            resetButton.Visible = true;
            resetButton.Enabled = true;            
        }

        private void ClearText(object sender, EventArgs e)
        {
            pathButton.Visible = true;
            textBox.Visible = false;
            textBox.Text = "";
            pathBox.Visible = false;
            pathBox.Text = "";
            fileChose.FileName = "";
            resetButton.Visible = false;
            resetButton.Enabled = false;
        }
    }
}
