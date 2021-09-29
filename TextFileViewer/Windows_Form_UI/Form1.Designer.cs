
namespace Windows_Form_UI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.pathButton = new System.Windows.Forms.Button();
            this.fileChose = new System.Windows.Forms.OpenFileDialog();
            this.resetButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.instructionLabel.Location = new System.Drawing.Point(33, 32);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(425, 22);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Choose a file to visualize (txt, config, xml, json, ini)";
            // 
            // pathButton
            // 
            this.pathButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathButton.Location = new System.Drawing.Point(37, 88);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(129, 33);
            this.pathButton.TabIndex = 1;
            this.pathButton.Text = "Choose file";
            this.pathButton.UseVisualStyleBackColor = false;
            this.pathButton.Click += new System.EventHandler(this.ChooseFilePath);
            // 
            // fileChose
            // 
            this.fileChose.Filter = "Valid text file|*.txt;*.config;*.ini;*.xml;*.json";
            this.fileChose.FileOk += new System.ComponentModel.CancelEventHandler(this.ShowPathFile);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetButton.Location = new System.Drawing.Point(37, 88);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(129, 33);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.ClearText);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(37, 144);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(725, 267);
            this.textBox.TabIndex = 7;
            this.textBox.Visible = false;
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pathBox.Location = new System.Drawing.Point(200, 88);
            this.pathBox.Multiline = true;
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(562, 33);
            this.pathBox.TabIndex = 8;
            this.pathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pathBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.instructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.OpenFileDialog fileChose;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox pathBox;
    }
}

