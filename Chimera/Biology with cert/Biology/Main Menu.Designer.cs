namespace Chimera
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.geneCutterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(86, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(28, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // periodComboBox
            // 
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "A 1-2",
            "A 3-4",
            "B 1-2",
            "B 3-4"});
            this.periodComboBox.Location = new System.Drawing.Point(86, 66);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(121, 21);
            this.periodComboBox.TabIndex = 7;
            this.periodComboBox.SelectedIndexChanged += new System.EventHandler(this.periodComboBox_SelectedIndexChanged);
            this.periodComboBox.TextChanged += new System.EventHandler(this.periodComboBox_SelectedIndexChanged);
            // 
            // periodLabel
            // 
            this.periodLabel.Location = new System.Drawing.Point(28, 65);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(51, 20);
            this.periodLabel.TabIndex = 8;
            this.periodLabel.Text = "Period:";
            this.periodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // geneCutterButton
            // 
            this.geneCutterButton.BackColor = System.Drawing.Color.Firebrick;
            this.geneCutterButton.Enabled = false;
            this.geneCutterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geneCutterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.geneCutterButton.Location = new System.Drawing.Point(21, 107);
            this.geneCutterButton.Name = "geneCutterButton";
            this.geneCutterButton.Size = new System.Drawing.Size(192, 48);
            this.geneCutterButton.TabIndex = 9;
            this.geneCutterButton.Text = "&Start";
            this.geneCutterButton.UseVisualStyleBackColor = false;
            this.geneCutterButton.Click += new System.EventHandler(this.geneCutterButton_Click_1);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 175);
            this.Controls.Add(this.geneCutterButton);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.periodComboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.MaximumSize = new System.Drawing.Size(251, 214);
            this.MinimumSize = new System.Drawing.Size(251, 214);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Button geneCutterButton;
    }
}

