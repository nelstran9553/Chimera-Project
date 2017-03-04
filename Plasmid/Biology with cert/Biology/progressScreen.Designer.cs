namespace BTSimulation
{
    partial class progressScreen
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.ecoAMPhumulinCheck = new System.Windows.Forms.CheckBox();
            this.ecoAMPhumiraCheck = new System.Windows.Forms.CheckBox();
            this.ecoKANhumulinCheck = new System.Windows.Forms.CheckBox();
            this.ecoKANhumiraCheck = new System.Windows.Forms.CheckBox();
            this.bamKANhumiraCheck = new System.Windows.Forms.CheckBox();
            this.bamKANhumulinCheck = new System.Windows.Forms.CheckBox();
            this.bamAMPhumiraCheck = new System.Windows.Forms.CheckBox();
            this.bamAMPhumulinCheck = new System.Windows.Forms.CheckBox();
            this.backButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(592, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Bob McDonald, 1-2 A";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ecoAMPhumulinCheck
            // 
            this.ecoAMPhumulinCheck.AutoCheck = false;
            this.ecoAMPhumulinCheck.AutoSize = true;
            this.ecoAMPhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoAMPhumulinCheck.Location = new System.Drawing.Point(54, 64);
            this.ecoAMPhumulinCheck.Name = "ecoAMPhumulinCheck";
            this.ecoAMPhumulinCheck.Size = new System.Drawing.Size(222, 24);
            this.ecoAMPhumulinCheck.TabIndex = 1;
            this.ecoAMPhumulinCheck.Text = "EcoRI - pAMP and Humulin";
            this.ecoAMPhumulinCheck.UseVisualStyleBackColor = true;
            this.ecoAMPhumulinCheck.CheckedChanged += new System.EventHandler(this.ecoAMPhumulinCheck_CheckedChanged);
            // 
            // ecoAMPhumiraCheck
            // 
            this.ecoAMPhumiraCheck.AutoCheck = false;
            this.ecoAMPhumiraCheck.AutoSize = true;
            this.ecoAMPhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoAMPhumiraCheck.Location = new System.Drawing.Point(54, 110);
            this.ecoAMPhumiraCheck.Name = "ecoAMPhumiraCheck";
            this.ecoAMPhumiraCheck.Size = new System.Drawing.Size(215, 24);
            this.ecoAMPhumiraCheck.TabIndex = 2;
            this.ecoAMPhumiraCheck.Text = "EcoRI - pAMP and Humira";
            this.ecoAMPhumiraCheck.UseVisualStyleBackColor = true;
            // 
            // ecoKANhumulinCheck
            // 
            this.ecoKANhumulinCheck.AutoCheck = false;
            this.ecoKANhumulinCheck.AutoSize = true;
            this.ecoKANhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoKANhumulinCheck.Location = new System.Drawing.Point(54, 156);
            this.ecoKANhumulinCheck.Name = "ecoKANhumulinCheck";
            this.ecoKANhumulinCheck.Size = new System.Drawing.Size(220, 24);
            this.ecoKANhumulinCheck.TabIndex = 3;
            this.ecoKANhumulinCheck.Text = "EcoRI - pKAN and Humulin";
            this.ecoKANhumulinCheck.UseVisualStyleBackColor = true;
            // 
            // ecoKANhumiraCheck
            // 
            this.ecoKANhumiraCheck.AutoCheck = false;
            this.ecoKANhumiraCheck.AutoSize = true;
            this.ecoKANhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoKANhumiraCheck.Location = new System.Drawing.Point(54, 202);
            this.ecoKANhumiraCheck.Name = "ecoKANhumiraCheck";
            this.ecoKANhumiraCheck.Size = new System.Drawing.Size(213, 24);
            this.ecoKANhumiraCheck.TabIndex = 4;
            this.ecoKANhumiraCheck.Text = "EcoRI - pKAN and Humira";
            this.ecoKANhumiraCheck.UseVisualStyleBackColor = true;
            // 
            // bamKANhumiraCheck
            // 
            this.bamKANhumiraCheck.AutoCheck = false;
            this.bamKANhumiraCheck.AutoSize = true;
            this.bamKANhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamKANhumiraCheck.Location = new System.Drawing.Point(312, 202);
            this.bamKANhumiraCheck.Name = "bamKANhumiraCheck";
            this.bamKANhumiraCheck.Size = new System.Drawing.Size(218, 24);
            this.bamKANhumiraCheck.TabIndex = 8;
            this.bamKANhumiraCheck.Text = "BamHI - pKAN and Humira";
            this.bamKANhumiraCheck.UseVisualStyleBackColor = true;
            // 
            // bamKANhumulinCheck
            // 
            this.bamKANhumulinCheck.AutoCheck = false;
            this.bamKANhumulinCheck.AutoSize = true;
            this.bamKANhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamKANhumulinCheck.Location = new System.Drawing.Point(312, 156);
            this.bamKANhumulinCheck.Name = "bamKANhumulinCheck";
            this.bamKANhumulinCheck.Size = new System.Drawing.Size(225, 24);
            this.bamKANhumulinCheck.TabIndex = 7;
            this.bamKANhumulinCheck.Text = "BamHI - pKAN and Humulin";
            this.bamKANhumulinCheck.UseVisualStyleBackColor = true;
            // 
            // bamAMPhumiraCheck
            // 
            this.bamAMPhumiraCheck.AutoCheck = false;
            this.bamAMPhumiraCheck.AutoSize = true;
            this.bamAMPhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamAMPhumiraCheck.Location = new System.Drawing.Point(312, 110);
            this.bamAMPhumiraCheck.Name = "bamAMPhumiraCheck";
            this.bamAMPhumiraCheck.Size = new System.Drawing.Size(220, 24);
            this.bamAMPhumiraCheck.TabIndex = 6;
            this.bamAMPhumiraCheck.Text = "BamHI - pAMP and Humira";
            this.bamAMPhumiraCheck.UseVisualStyleBackColor = true;
            // 
            // bamAMPhumulinCheck
            // 
            this.bamAMPhumulinCheck.AutoCheck = false;
            this.bamAMPhumulinCheck.AutoSize = true;
            this.bamAMPhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamAMPhumulinCheck.Location = new System.Drawing.Point(312, 64);
            this.bamAMPhumulinCheck.Name = "bamAMPhumulinCheck";
            this.bamAMPhumulinCheck.Size = new System.Drawing.Size(227, 24);
            this.bamAMPhumulinCheck.TabIndex = 5;
            this.bamAMPhumulinCheck.Text = "BamHI - pAMP and Humulin";
            this.bamAMPhumulinCheck.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(10, 241);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(506, 241);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 10;
            this.display.Text = "&Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // progressScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 281);
            this.Controls.Add(this.display);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bamKANhumiraCheck);
            this.Controls.Add(this.bamKANhumulinCheck);
            this.Controls.Add(this.bamAMPhumiraCheck);
            this.Controls.Add(this.bamAMPhumulinCheck);
            this.Controls.Add(this.ecoKANhumiraCheck);
            this.Controls.Add(this.ecoKANhumulinCheck);
            this.Controls.Add(this.ecoAMPhumiraCheck);
            this.Controls.Add(this.ecoAMPhumulinCheck);
            this.Controls.Add(this.nameLabel);
            this.MaximumSize = new System.Drawing.Size(608, 320);
            this.MinimumSize = new System.Drawing.Size(608, 320);
            this.Name = "progressScreen";
            this.Text = "Progress";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.progressScreen_FormClosed);
            this.Load += new System.EventHandler(this.progressScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox ecoAMPhumulinCheck;
        private System.Windows.Forms.CheckBox ecoAMPhumiraCheck;
        private System.Windows.Forms.CheckBox ecoKANhumulinCheck;
        private System.Windows.Forms.CheckBox ecoKANhumiraCheck;
        private System.Windows.Forms.CheckBox bamKANhumiraCheck;
        private System.Windows.Forms.CheckBox bamKANhumulinCheck;
        private System.Windows.Forms.CheckBox bamAMPhumiraCheck;
        private System.Windows.Forms.CheckBox bamAMPhumulinCheck;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}