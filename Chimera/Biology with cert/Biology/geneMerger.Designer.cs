namespace Chimera
{
    partial class geneMerger
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
            this.components = new System.ComponentModel.Container();
            this.combinePanel = new System.Windows.Forms.Panel();
            this.ecoAMPbutton1 = new System.Windows.Forms.Button();
            this.ecoKANbutton1 = new System.Windows.Forms.Button();
            this.ecoHumiraButton1 = new System.Windows.Forms.Button();
            this.ecoHumulinButton1 = new System.Windows.Forms.Button();
            this.EcoRILabel1 = new System.Windows.Forms.Label();
            this.bamAMPbutton1 = new System.Windows.Forms.Button();
            this.bamKANbutton1 = new System.Windows.Forms.Button();
            this.bamHumiraButton1 = new System.Windows.Forms.Button();
            this.bamHumulinButton1 = new System.Windows.Forms.Button();
            this.BamHILabel1 = new System.Windows.Forms.Label();
            this.insertPanel1 = new System.Windows.Forms.Panel();
            this.insertPanel2 = new System.Windows.Forms.Panel();
            this.BamHILabel2 = new System.Windows.Forms.Label();
            this.bamHumulinButton2 = new System.Windows.Forms.Button();
            this.bamHumiraButton2 = new System.Windows.Forms.Button();
            this.bamKANbutton2 = new System.Windows.Forms.Button();
            this.bamAMPbutton2 = new System.Windows.Forms.Button();
            this.EcoRILabel2 = new System.Windows.Forms.Label();
            this.ecoHumulinButton2 = new System.Windows.Forms.Button();
            this.ecoHumiraButton2 = new System.Windows.Forms.Button();
            this.ecoKANbutton2 = new System.Windows.Forms.Button();
            this.ecoAMPbutton2 = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.finishButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.insertPanel1.SuspendLayout();
            this.insertPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combinePanel
            // 
            this.combinePanel.Location = new System.Drawing.Point(75, 0);
            this.combinePanel.Name = "combinePanel";
            this.combinePanel.Size = new System.Drawing.Size(600, 347);
            this.combinePanel.TabIndex = 0;
            this.combinePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.combinePanel_Paint);
            // 
            // ecoAMPbutton1
            // 
            this.ecoAMPbutton1.Enabled = false;
            this.ecoAMPbutton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoAMPbutton1.Location = new System.Drawing.Point(3, 25);
            this.ecoAMPbutton1.Name = "ecoAMPbutton1";
            this.ecoAMPbutton1.Size = new System.Drawing.Size(66, 30);
            this.ecoAMPbutton1.TabIndex = 0;
            this.ecoAMPbutton1.Tag = "ecoAMP";
            this.ecoAMPbutton1.Text = "pAMP";
            this.ecoAMPbutton1.UseVisualStyleBackColor = true;
            this.ecoAMPbutton1.Click += new System.EventHandler(this.insertGene);
            // 
            // ecoKANbutton1
            // 
            this.ecoKANbutton1.Enabled = false;
            this.ecoKANbutton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoKANbutton1.Location = new System.Drawing.Point(3, 61);
            this.ecoKANbutton1.Name = "ecoKANbutton1";
            this.ecoKANbutton1.Size = new System.Drawing.Size(66, 30);
            this.ecoKANbutton1.TabIndex = 1;
            this.ecoKANbutton1.Tag = "ecoKAN";
            this.ecoKANbutton1.Text = "pKAN";
            this.ecoKANbutton1.UseVisualStyleBackColor = true;
            this.ecoKANbutton1.Click += new System.EventHandler(this.insertGene);
            // 
            // ecoHumiraButton1
            // 
            this.ecoHumiraButton1.Enabled = false;
            this.ecoHumiraButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoHumiraButton1.Location = new System.Drawing.Point(3, 97);
            this.ecoHumiraButton1.Name = "ecoHumiraButton1";
            this.ecoHumiraButton1.Size = new System.Drawing.Size(66, 30);
            this.ecoHumiraButton1.TabIndex = 2;
            this.ecoHumiraButton1.Tag = "ecoHumira";
            this.ecoHumiraButton1.Text = "Humira";
            this.ecoHumiraButton1.UseVisualStyleBackColor = true;
            this.ecoHumiraButton1.Click += new System.EventHandler(this.insertGene);
            // 
            // ecoHumulinButton1
            // 
            this.ecoHumulinButton1.Enabled = false;
            this.ecoHumulinButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoHumulinButton1.Location = new System.Drawing.Point(3, 133);
            this.ecoHumulinButton1.Name = "ecoHumulinButton1";
            this.ecoHumulinButton1.Size = new System.Drawing.Size(66, 30);
            this.ecoHumulinButton1.TabIndex = 3;
            this.ecoHumulinButton1.Tag = "ecoHumulin";
            this.ecoHumulinButton1.Text = "Humulin";
            this.ecoHumulinButton1.UseVisualStyleBackColor = true;
            this.ecoHumulinButton1.Click += new System.EventHandler(this.insertGene);
            // 
            // EcoRILabel1
            // 
            this.EcoRILabel1.AutoSize = true;
            this.EcoRILabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcoRILabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EcoRILabel1.Location = new System.Drawing.Point(12, 9);
            this.EcoRILabel1.Name = "EcoRILabel1";
            this.EcoRILabel1.Size = new System.Drawing.Size(42, 13);
            this.EcoRILabel1.TabIndex = 4;
            this.EcoRILabel1.Text = "EcoRI";
            // 
            // bamAMPbutton1
            // 
            this.bamAMPbutton1.Enabled = false;
            this.bamAMPbutton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamAMPbutton1.Location = new System.Drawing.Point(3, 191);
            this.bamAMPbutton1.Name = "bamAMPbutton1";
            this.bamAMPbutton1.Size = new System.Drawing.Size(66, 30);
            this.bamAMPbutton1.TabIndex = 5;
            this.bamAMPbutton1.Tag = "bamAMP";
            this.bamAMPbutton1.Text = "pAMP";
            this.bamAMPbutton1.UseVisualStyleBackColor = true;
            this.bamAMPbutton1.Click += new System.EventHandler(this.insertGene);
            // 
            // bamKANbutton1
            // 
            this.bamKANbutton1.Enabled = false;
            this.bamKANbutton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamKANbutton1.Location = new System.Drawing.Point(3, 227);
            this.bamKANbutton1.Name = "bamKANbutton1";
            this.bamKANbutton1.Size = new System.Drawing.Size(66, 30);
            this.bamKANbutton1.TabIndex = 6;
            this.bamKANbutton1.Tag = "bamKAN";
            this.bamKANbutton1.Text = "pKAN";
            this.bamKANbutton1.UseVisualStyleBackColor = true;
            this.bamKANbutton1.Click += new System.EventHandler(this.insertGene);
            // 
            // bamHumiraButton1
            // 
            this.bamHumiraButton1.Enabled = false;
            this.bamHumiraButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamHumiraButton1.Location = new System.Drawing.Point(3, 263);
            this.bamHumiraButton1.Name = "bamHumiraButton1";
            this.bamHumiraButton1.Size = new System.Drawing.Size(66, 30);
            this.bamHumiraButton1.TabIndex = 7;
            this.bamHumiraButton1.Tag = "bamHumira";
            this.bamHumiraButton1.Text = "Humira";
            this.bamHumiraButton1.UseVisualStyleBackColor = true;
            this.bamHumiraButton1.Click += new System.EventHandler(this.insertGene);
            // 
            // bamHumulinButton1
            // 
            this.bamHumulinButton1.Enabled = false;
            this.bamHumulinButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamHumulinButton1.Location = new System.Drawing.Point(3, 299);
            this.bamHumulinButton1.Name = "bamHumulinButton1";
            this.bamHumulinButton1.Size = new System.Drawing.Size(66, 30);
            this.bamHumulinButton1.TabIndex = 8;
            this.bamHumulinButton1.Tag = "bamHumulin";
            this.bamHumulinButton1.Text = "Humulin";
            this.bamHumulinButton1.UseVisualStyleBackColor = true;
            this.bamHumulinButton1.Click += new System.EventHandler(this.insertGene);
            // 
            // BamHILabel1
            // 
            this.BamHILabel1.AutoSize = true;
            this.BamHILabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BamHILabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BamHILabel1.Location = new System.Drawing.Point(12, 175);
            this.BamHILabel1.Name = "BamHILabel1";
            this.BamHILabel1.Size = new System.Drawing.Size(44, 13);
            this.BamHILabel1.TabIndex = 9;
            this.BamHILabel1.Text = "BamHI";
            // 
            // insertPanel1
            // 
            this.insertPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.insertPanel1.Controls.Add(this.BamHILabel1);
            this.insertPanel1.Controls.Add(this.bamHumulinButton1);
            this.insertPanel1.Controls.Add(this.bamHumiraButton1);
            this.insertPanel1.Controls.Add(this.bamKANbutton1);
            this.insertPanel1.Controls.Add(this.bamAMPbutton1);
            this.insertPanel1.Controls.Add(this.EcoRILabel1);
            this.insertPanel1.Controls.Add(this.ecoHumulinButton1);
            this.insertPanel1.Controls.Add(this.ecoHumiraButton1);
            this.insertPanel1.Controls.Add(this.ecoKANbutton1);
            this.insertPanel1.Controls.Add(this.ecoAMPbutton1);
            this.insertPanel1.Location = new System.Drawing.Point(0, 0);
            this.insertPanel1.Name = "insertPanel1";
            this.insertPanel1.Size = new System.Drawing.Size(75, 347);
            this.insertPanel1.TabIndex = 0;
            // 
            // insertPanel2
            // 
            this.insertPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.insertPanel2.Controls.Add(this.BamHILabel2);
            this.insertPanel2.Controls.Add(this.bamHumulinButton2);
            this.insertPanel2.Controls.Add(this.bamHumiraButton2);
            this.insertPanel2.Controls.Add(this.bamKANbutton2);
            this.insertPanel2.Controls.Add(this.bamAMPbutton2);
            this.insertPanel2.Controls.Add(this.EcoRILabel2);
            this.insertPanel2.Controls.Add(this.ecoHumulinButton2);
            this.insertPanel2.Controls.Add(this.ecoHumiraButton2);
            this.insertPanel2.Controls.Add(this.ecoKANbutton2);
            this.insertPanel2.Controls.Add(this.ecoAMPbutton2);
            this.insertPanel2.Location = new System.Drawing.Point(675, 0);
            this.insertPanel2.Name = "insertPanel2";
            this.insertPanel2.Size = new System.Drawing.Size(75, 347);
            this.insertPanel2.TabIndex = 2;
            // 
            // BamHILabel2
            // 
            this.BamHILabel2.AutoSize = true;
            this.BamHILabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BamHILabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BamHILabel2.Location = new System.Drawing.Point(12, 175);
            this.BamHILabel2.Name = "BamHILabel2";
            this.BamHILabel2.Size = new System.Drawing.Size(44, 13);
            this.BamHILabel2.TabIndex = 9;
            this.BamHILabel2.Text = "BamHI";
            // 
            // bamHumulinButton2
            // 
            this.bamHumulinButton2.Enabled = false;
            this.bamHumulinButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamHumulinButton2.Location = new System.Drawing.Point(3, 299);
            this.bamHumulinButton2.Name = "bamHumulinButton2";
            this.bamHumulinButton2.Size = new System.Drawing.Size(66, 30);
            this.bamHumulinButton2.TabIndex = 8;
            this.bamHumulinButton2.Tag = "bamHumulin";
            this.bamHumulinButton2.Text = "Humulin";
            this.bamHumulinButton2.UseVisualStyleBackColor = true;
            this.bamHumulinButton2.Click += new System.EventHandler(this.insertGene);
            // 
            // bamHumiraButton2
            // 
            this.bamHumiraButton2.Enabled = false;
            this.bamHumiraButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamHumiraButton2.Location = new System.Drawing.Point(3, 263);
            this.bamHumiraButton2.Name = "bamHumiraButton2";
            this.bamHumiraButton2.Size = new System.Drawing.Size(66, 30);
            this.bamHumiraButton2.TabIndex = 7;
            this.bamHumiraButton2.Tag = "bamHumira";
            this.bamHumiraButton2.Text = "Humira";
            this.bamHumiraButton2.UseVisualStyleBackColor = true;
            this.bamHumiraButton2.Click += new System.EventHandler(this.insertGene);
            // 
            // bamKANbutton2
            // 
            this.bamKANbutton2.Enabled = false;
            this.bamKANbutton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamKANbutton2.Location = new System.Drawing.Point(3, 227);
            this.bamKANbutton2.Name = "bamKANbutton2";
            this.bamKANbutton2.Size = new System.Drawing.Size(66, 30);
            this.bamKANbutton2.TabIndex = 6;
            this.bamKANbutton2.Tag = "bamKAN";
            this.bamKANbutton2.Text = "pKAN";
            this.bamKANbutton2.UseVisualStyleBackColor = true;
            this.bamKANbutton2.Click += new System.EventHandler(this.insertGene);
            // 
            // bamAMPbutton2
            // 
            this.bamAMPbutton2.Enabled = false;
            this.bamAMPbutton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamAMPbutton2.Location = new System.Drawing.Point(3, 191);
            this.bamAMPbutton2.Name = "bamAMPbutton2";
            this.bamAMPbutton2.Size = new System.Drawing.Size(66, 30);
            this.bamAMPbutton2.TabIndex = 5;
            this.bamAMPbutton2.Tag = "bamAMP";
            this.bamAMPbutton2.Text = "pAMP";
            this.bamAMPbutton2.UseVisualStyleBackColor = true;
            this.bamAMPbutton2.Click += new System.EventHandler(this.insertGene);
            // 
            // EcoRILabel2
            // 
            this.EcoRILabel2.AutoSize = true;
            this.EcoRILabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcoRILabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EcoRILabel2.Location = new System.Drawing.Point(12, 9);
            this.EcoRILabel2.Name = "EcoRILabel2";
            this.EcoRILabel2.Size = new System.Drawing.Size(42, 13);
            this.EcoRILabel2.TabIndex = 4;
            this.EcoRILabel2.Text = "EcoRI";
            // 
            // ecoHumulinButton2
            // 
            this.ecoHumulinButton2.Enabled = false;
            this.ecoHumulinButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoHumulinButton2.Location = new System.Drawing.Point(3, 133);
            this.ecoHumulinButton2.Name = "ecoHumulinButton2";
            this.ecoHumulinButton2.Size = new System.Drawing.Size(66, 30);
            this.ecoHumulinButton2.TabIndex = 3;
            this.ecoHumulinButton2.Tag = "ecoHumulin";
            this.ecoHumulinButton2.Text = "Humulin";
            this.ecoHumulinButton2.UseVisualStyleBackColor = true;
            this.ecoHumulinButton2.Click += new System.EventHandler(this.insertGene);
            // 
            // ecoHumiraButton2
            // 
            this.ecoHumiraButton2.Enabled = false;
            this.ecoHumiraButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoHumiraButton2.Location = new System.Drawing.Point(3, 97);
            this.ecoHumiraButton2.Name = "ecoHumiraButton2";
            this.ecoHumiraButton2.Size = new System.Drawing.Size(66, 30);
            this.ecoHumiraButton2.TabIndex = 2;
            this.ecoHumiraButton2.Tag = "ecoHumira";
            this.ecoHumiraButton2.Text = "Humira";
            this.ecoHumiraButton2.UseVisualStyleBackColor = true;
            this.ecoHumiraButton2.Click += new System.EventHandler(this.insertGene);
            // 
            // ecoKANbutton2
            // 
            this.ecoKANbutton2.Enabled = false;
            this.ecoKANbutton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoKANbutton2.Location = new System.Drawing.Point(3, 61);
            this.ecoKANbutton2.Name = "ecoKANbutton2";
            this.ecoKANbutton2.Size = new System.Drawing.Size(66, 30);
            this.ecoKANbutton2.TabIndex = 1;
            this.ecoKANbutton2.Tag = "ecoKAN";
            this.ecoKANbutton2.Text = "pKAN";
            this.ecoKANbutton2.UseVisualStyleBackColor = true;
            this.ecoKANbutton2.Click += new System.EventHandler(this.insertGene);
            // 
            // ecoAMPbutton2
            // 
            this.ecoAMPbutton2.Enabled = false;
            this.ecoAMPbutton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoAMPbutton2.Location = new System.Drawing.Point(3, 25);
            this.ecoAMPbutton2.Name = "ecoAMPbutton2";
            this.ecoAMPbutton2.Size = new System.Drawing.Size(66, 30);
            this.ecoAMPbutton2.TabIndex = 0;
            this.ecoAMPbutton2.Tag = "ecoAMP";
            this.ecoAMPbutton2.Text = "pAMP";
            this.ecoAMPbutton2.UseVisualStyleBackColor = true;
            this.ecoAMPbutton2.Click += new System.EventHandler(this.insertGene);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 20;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(633, 353);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 3;
            this.finishButton.Text = "&Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(15, 353);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // geneMerger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 388);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.insertPanel2);
            this.Controls.Add(this.combinePanel);
            this.Controls.Add(this.insertPanel1);
            this.MaximumSize = new System.Drawing.Size(767, 427);
            this.MinimumSize = new System.Drawing.Size(767, 427);
            this.Name = "geneMerger";
            this.Text = "Gene Merger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.geneMerger_FormClosed);
            this.insertPanel1.ResumeLayout(false);
            this.insertPanel1.PerformLayout();
            this.insertPanel2.ResumeLayout(false);
            this.insertPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel combinePanel;
        private System.Windows.Forms.Button ecoAMPbutton1;
        private System.Windows.Forms.Button ecoKANbutton1;
        private System.Windows.Forms.Button ecoHumiraButton1;
        private System.Windows.Forms.Button ecoHumulinButton1;
        private System.Windows.Forms.Label EcoRILabel1;
        private System.Windows.Forms.Button bamAMPbutton1;
        private System.Windows.Forms.Button bamKANbutton1;
        private System.Windows.Forms.Button bamHumiraButton1;
        private System.Windows.Forms.Button bamHumulinButton1;
        private System.Windows.Forms.Label BamHILabel1;
        private System.Windows.Forms.Panel insertPanel1;
        private System.Windows.Forms.Panel insertPanel2;
        private System.Windows.Forms.Label BamHILabel2;
        private System.Windows.Forms.Button bamHumulinButton2;
        private System.Windows.Forms.Button bamHumiraButton2;
        private System.Windows.Forms.Button bamKANbutton2;
        private System.Windows.Forms.Button bamAMPbutton2;
        private System.Windows.Forms.Label EcoRILabel2;
        private System.Windows.Forms.Button ecoHumulinButton2;
        private System.Windows.Forms.Button ecoHumiraButton2;
        private System.Windows.Forms.Button ecoKANbutton2;
        private System.Windows.Forms.Button ecoAMPbutton2;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button backButton;
    }
}