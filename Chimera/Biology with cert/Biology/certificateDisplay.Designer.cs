namespace Chimera
{
    partial class certificateDisplay
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
            this.certPicture = new System.Windows.Forms.PictureBox();
            this.printCert = new System.Windows.Forms.Button();
            this.printCert1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.certPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // certPicture
            // 
            this.certPicture.Location = new System.Drawing.Point(89, 69);
            this.certPicture.Name = "certPicture";
            this.certPicture.Size = new System.Drawing.Size(100, 50);
            this.certPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.certPicture.TabIndex = 0;
            this.certPicture.TabStop = false;
            // 
            // printCert
            // 
            this.printCert.Location = new System.Drawing.Point(216, 12);
            this.printCert.Name = "printCert";
            this.printCert.Size = new System.Drawing.Size(75, 23);
            this.printCert.TabIndex = 1;
            this.printCert.Text = "&Print";
            this.printCert.UseVisualStyleBackColor = true;
            this.printCert.Click += new System.EventHandler(this.printCert_Click);
            // 
            // printCert1
            // 
            this.printCert1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCert1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printCert1;
            this.printDialog1.UseEXDialog = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(27, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // certificateDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 261);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.printCert);
            this.Controls.Add(this.certPicture);
            this.Name = "certificateDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "certificateDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.certificateDisplay_FormClosed);
            this.Load += new System.EventHandler(this.certificateDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox certPicture;
        private System.Windows.Forms.Button printCert;
        private System.Drawing.Printing.PrintDocument printCert1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button backButton;
    }
}