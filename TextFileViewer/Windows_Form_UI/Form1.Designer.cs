
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
            this.chooseButton = new System.Windows.Forms.Button();
            this.fileChose = new System.Windows.Forms.OpenFileDialog();
            this.changeButton = new System.Windows.Forms.Button();
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
            this.instructionLabel.Size = new System.Drawing.Size(450, 22);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Choose a file to visualize (.txt, .config, .xml, .json, .ini)";
            // 
            // chooseButton
            // 
            this.chooseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseButton.Image = ((System.Drawing.Image)(resources.GetObject("chooseButton.Image")));
            this.chooseButton.Location = new System.Drawing.Point(37, 88);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(129, 33);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "Choose file";
            this.chooseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chooseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chooseButton.UseVisualStyleBackColor = false;
            this.chooseButton.Click += new System.EventHandler(this.ChooseFile);
            // 
            // fileChose
            // 
            this.fileChose.Filter = "Valid text file|*.txt;*.config;*.ini;*.xml;*.json";
            this.fileChose.FileOk += new System.ComponentModel.CancelEventHandler(this.ShowPathFile);
            // 
            // resetButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.changeButton.Location = new System.Drawing.Point(633, 435);
            this.changeButton.Name = "resetButton";
            this.changeButton.Size = new System.Drawing.Size(129, 33);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "Change File";
            this.changeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeFile);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 494);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.chooseButton);
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
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.OpenFileDialog fileChose;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox pathBox;
    }
}

