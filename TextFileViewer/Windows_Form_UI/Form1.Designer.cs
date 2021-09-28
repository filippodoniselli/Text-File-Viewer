
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.fileChose = new System.Windows.Forms.OpenFileDialog();
            this.showButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.instructionLabel.Location = new System.Drawing.Point(33, 32);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(393, 21);
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
            this.pathButton.Text = "Path File";
            this.pathButton.UseVisualStyleBackColor = false;
            this.pathButton.Click += new System.EventHandler(this.ChooseFilePath);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(201, 94);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pathLabel.Size = new System.Drawing.Size(10, 20);
            this.pathLabel.TabIndex = 2;
            // 
            // fileChose
            // 
            this.fileChose.Filter = "Valid text file|*.txt;*.config;*.ini;*.xml;*.json";
            this.fileChose.FileOk += new System.ComponentModel.CancelEventHandler(this.ShowPathFile);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.showButton.Enabled = false;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showButton.Location = new System.Drawing.Point(37, 147);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(129, 33);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show file\'s text";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.ShowText);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearButton.Enabled = false;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearButton.Location = new System.Drawing.Point(205, 147);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 33);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear text";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearText);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(37, 205);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(725, 185);
            this.textBox.TabIndex = 7;
            this.textBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TextViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.OpenFileDialog fileChose;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBox;
    }
}

