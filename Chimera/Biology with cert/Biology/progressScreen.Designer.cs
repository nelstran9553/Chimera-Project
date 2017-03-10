namespace Chimera
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
            this.backButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ecoAMPhumulinCheck = new System.Windows.Forms.Label();
            this.ecoAMPhumiraCheck = new System.Windows.Forms.Label();
            this.ecoKANhumulinCheck = new System.Windows.Forms.Label();
            this.ecoKANhumiraCheck = new System.Windows.Forms.Label();
            this.bamKANhumiraCheck = new System.Windows.Forms.Label();
            this.bamKANhumulinCheck = new System.Windows.Forms.Label();
            this.bamAMPhumiraCheck = new System.Windows.Forms.Label();
            this.bamAMPhumulinCheck = new System.Windows.Forms.Label();
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
            // ecoAMPhumulinCheck
            // 
            this.ecoAMPhumulinCheck.AutoSize = true;
            this.ecoAMPhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecoAMPhumulinCheck.Location = new System.Drawing.Point(54, 64);
            this.ecoAMPhumulinCheck.Name = "ecoAMPhumulinCheck";
            this.ecoAMPhumulinCheck.Size = new System.Drawing.Size(222, 20);
            this.ecoAMPhumulinCheck.TabIndex = 11;
            this.ecoAMPhumulinCheck.Text = "&X EcoR1 - pAMP and Humulin";
            // 
            // ecoAMPhumiraCheck
            // 
            this.ecoAMPhumiraCheck.AutoSize = true;
            this.ecoAMPhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecoAMPhumiraCheck.Location = new System.Drawing.Point(54, 110);
            this.ecoAMPhumiraCheck.Name = "ecoAMPhumiraCheck";
            this.ecoAMPhumiraCheck.Size = new System.Drawing.Size(215, 20);
            this.ecoAMPhumiraCheck.TabIndex = 12;
            this.ecoAMPhumiraCheck.Text = "&X EcoR1 - pAMP and Humira";
            // 
            // ecoKANhumulinCheck
            // 
            this.ecoKANhumulinCheck.AutoSize = true;
            this.ecoKANhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecoKANhumulinCheck.Location = new System.Drawing.Point(54, 156);
            this.ecoKANhumulinCheck.Name = "ecoKANhumulinCheck";
            this.ecoKANhumulinCheck.Size = new System.Drawing.Size(220, 20);
            this.ecoKANhumulinCheck.TabIndex = 13;
            this.ecoKANhumulinCheck.Text = "&X EcoR1 - pKAN and Humulin";
            // 
            // ecoKANhumiraCheck
            // 
            this.ecoKANhumiraCheck.AutoSize = true;
            this.ecoKANhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecoKANhumiraCheck.Location = new System.Drawing.Point(54, 202);
            this.ecoKANhumiraCheck.Name = "ecoKANhumiraCheck";
            this.ecoKANhumiraCheck.Size = new System.Drawing.Size(213, 20);
            this.ecoKANhumiraCheck.TabIndex = 14;
            this.ecoKANhumiraCheck.Text = "&X EcoR1 - pKAN and Humira";
            // 
            // bamKANhumiraCheck
            // 
            this.bamKANhumiraCheck.AutoSize = true;
            this.bamKANhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bamKANhumiraCheck.Location = new System.Drawing.Point(312, 202);
            this.bamKANhumiraCheck.Name = "bamKANhumiraCheck";
            this.bamKANhumiraCheck.Size = new System.Drawing.Size(218, 20);
            this.bamKANhumiraCheck.TabIndex = 18;
            this.bamKANhumiraCheck.Text = "&X BamH1 - pKAN and Humira";
            // 
            // bamKANhumulinCheck
            // 
            this.bamKANhumulinCheck.AutoSize = true;
            this.bamKANhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bamKANhumulinCheck.Location = new System.Drawing.Point(312, 156);
            this.bamKANhumulinCheck.Name = "bamKANhumulinCheck";
            this.bamKANhumulinCheck.Size = new System.Drawing.Size(225, 20);
            this.bamKANhumulinCheck.TabIndex = 17;
            this.bamKANhumulinCheck.Text = "&X BamH1 - pKAN and Humulin";
            // 
            // bamAMPhumiraCheck
            // 
            this.bamAMPhumiraCheck.AutoSize = true;
            this.bamAMPhumiraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bamAMPhumiraCheck.Location = new System.Drawing.Point(312, 110);
            this.bamAMPhumiraCheck.Name = "bamAMPhumiraCheck";
            this.bamAMPhumiraCheck.Size = new System.Drawing.Size(220, 20);
            this.bamAMPhumiraCheck.TabIndex = 16;
            this.bamAMPhumiraCheck.Text = "&X BamH1 - pAMP and Humira";
            // 
            // bamAMPhumulinCheck
            // 
            this.bamAMPhumulinCheck.AutoSize = true;
            this.bamAMPhumulinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bamAMPhumulinCheck.Location = new System.Drawing.Point(312, 64);
            this.bamAMPhumulinCheck.Name = "bamAMPhumulinCheck";
            this.bamAMPhumulinCheck.Size = new System.Drawing.Size(227, 20);
            this.bamAMPhumulinCheck.TabIndex = 15;
            this.bamAMPhumulinCheck.Text = "&X BamH1 - pAMP and Humulin";
            // 
            // progressScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 281);
            this.Controls.Add(this.bamKANhumiraCheck);
            this.Controls.Add(this.bamKANhumulinCheck);
            this.Controls.Add(this.bamAMPhumiraCheck);
            this.Controls.Add(this.bamAMPhumulinCheck);
            this.Controls.Add(this.ecoKANhumiraCheck);
            this.Controls.Add(this.ecoKANhumulinCheck);
            this.Controls.Add(this.ecoAMPhumiraCheck);
            this.Controls.Add(this.ecoAMPhumulinCheck);
            this.Controls.Add(this.display);
            this.Controls.Add(this.backButton);
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label ecoAMPhumulinCheck;
        private System.Windows.Forms.Label ecoAMPhumiraCheck;
        private System.Windows.Forms.Label ecoKANhumulinCheck;
        private System.Windows.Forms.Label ecoKANhumiraCheck;
        private System.Windows.Forms.Label bamKANhumiraCheck;
        private System.Windows.Forms.Label bamKANhumulinCheck;
        private System.Windows.Forms.Label bamAMPhumiraCheck;
        private System.Windows.Forms.Label bamAMPhumulinCheck;
    }
}