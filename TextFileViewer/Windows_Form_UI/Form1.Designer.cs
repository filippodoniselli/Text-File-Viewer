
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
            this.resetButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.indentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.instructionLabel.Location = new System.Drawing.Point(20, 33);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(888, 22);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Choose a file to visualize (.txt, .config, .xml, .json, .ini). Then you can save " +
    "as new, update or delete it. Enjoy!";
            this.instructionLabel.Click += new System.EventHandler(this.InstructionLabel_Click);
            // 
            // chooseButton
            // 
            this.chooseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chooseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseButton.Image = ((System.Drawing.Image)(resources.GetObject("chooseButton.Image")));
            this.chooseButton.Location = new System.Drawing.Point(24, 87);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(150, 33);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "Choose file";
            this.chooseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chooseButton.UseVisualStyleBackColor = false;
            this.chooseButton.Click += new System.EventHandler(this.ChooseFile);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.resetButton.Location = new System.Drawing.Point(774, 551);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 33);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetClick);
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(24, 144);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(900, 359);
            this.textBox.TabIndex = 2;
            this.textBox.EnabledChanged += new System.EventHandler(this.ButtonStyle);
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pathBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pathBox.Location = new System.Drawing.Point(200, 87);
            this.pathBox.Multiline = true;
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(724, 33);
            this.pathBox.TabIndex = 78;
            this.pathBox.TabStop = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.Control;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changeButton.Image = ((System.Drawing.Image)(resources.GetObject("changeButton.Image")));
            this.changeButton.Location = new System.Drawing.Point(586, 551);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(150, 33);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Change File";
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeFile);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(399, 551);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 33);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteClick);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.Control;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(211, 551);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 33);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateClick);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(24, 551);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 33);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save as new";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveClick);
            // 
            // indentButton
            // 
            this.indentButton.BackColor = System.Drawing.SystemColors.Control;
            this.indentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indentButton.Enabled = false;
            this.indentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indentButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.indentButton.Image = ((System.Drawing.Image)(resources.GetObject("indentButton.Image")));
            this.indentButton.Location = new System.Drawing.Point(806, 509);
            this.indentButton.Name = "indentButton";
            this.indentButton.Size = new System.Drawing.Size(118, 23);
            this.indentButton.TabIndex = 3;
            this.indentButton.Text = "Indent as .json";
            this.indentButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.indentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.indentButton.UseVisualStyleBackColor = false;
            this.indentButton.Click += new System.EventHandler(this.IndentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 621);
            this.Controls.Add(this.indentButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.instructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button indentButton;
    }
}

