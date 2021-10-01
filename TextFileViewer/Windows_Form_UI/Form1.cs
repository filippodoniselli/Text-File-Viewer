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
            textBox.Text = File.ReadAllText(pathBox.Text);
            resetButton.Enabled = true;
            chooseButton.Enabled = false;
        }

        private void ClearText(object sender, EventArgs e)
        {
            textBox.Text = "";
            pathBox.Text = "";
            fileChose.FileName = "";
            resetButton.Enabled = false;
            chooseButton.Enabled = true;
        }
    }
}
