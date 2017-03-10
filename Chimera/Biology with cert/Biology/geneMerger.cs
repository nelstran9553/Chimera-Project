using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chimera
{
    public partial class geneMerger : Form
    {
        BasePair[] leftTop = null;
        BasePair[] leftBottom = null;
        BasePair[] rightTop = null;
        BasePair[] rightBottom = null;
        const int baseDisplaySize = 50;
        const string ecoCutSite = "GAATTC";
        const string bamCutSite = "GGATCC";
        string leftCutSite;
        string rightCutSite;
        string leftPlasmid;
        string rightPlasmid;
        int animationYoffset = 0;
        Font font = new Font("Arial", 12);
        public geneMerger()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            DoubleBuffered = true;
            this.Text = "Gene Merger | " + Globals.name + " - " + Globals.period;
            if (Globals.ecoAMPcut)
            {
                ecoAMPbutton1.Enabled = true;
                ecoAMPbutton2.Enabled = true;
            }
            if (Globals.ecoKANcut)
            {
                ecoKANbutton1.Enabled = true;
                ecoKANbutton2.Enabled = true;
            }
            if (Globals.ecoHumulinCut)
            {
                ecoHumulinButton1.Enabled = true;
                ecoHumulinButton2.Enabled = true;
            }
            if (Globals.ecoHumiraCut)
            {
                ecoHumiraButton1.Enabled = true;
                ecoHumiraButton2.Enabled = true;
            }
            if (Globals.bamAMPcut)
            {
                bamAMPbutton1.Enabled = true;
                bamAMPbutton2.Enabled = true;
            }
            if (Globals.bamKANcut)
            {
                bamKANbutton1.Enabled = true;
                bamKANbutton2.Enabled = true;
            }
            if (Globals.bamHumulinCut)
            {
                bamHumulinButton1.Enabled = true;
                bamHumulinButton2.Enabled = true;
            }
            if (Globals.bamHumiraCut)
            {
                bamHumiraButton1.Enabled = true;
                bamHumiraButton2.Enabled = true;
            }
        }

        private void insertGene(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Name.Contains("1"))
            {
                switch (clickedButton.Name.Substring(0, clickedButton.Name.Length - 1))
                {
                    case "ecoAMPbutton":
                        leftCutSite = ecoCutSite;
                        leftPlasmid = "ecoAMP";
                        leftTop = BasePair.createFromString(Globals.ecoAMPcutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.ecoAMPcutSite.Substring(3, Globals.ecoAMPcutSite.Length-3));
                        break;
                    case "bamAMPbutton":
                        leftCutSite = bamCutSite;
                        leftPlasmid = "bamAMP";
                        leftTop = BasePair.createFromString(Globals.bamAMPcutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.bamAMPcutSite.Substring(3, Globals.bamAMPcutSite.Length - 3));
                        break;
                    case "ecoKANbutton":
                        leftCutSite = ecoCutSite;
                        leftPlasmid = "ecoKAN";
                        leftTop = BasePair.createFromString(Globals.ecoKANcutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.ecoKANcutSite.Substring(3, Globals.ecoKANcutSite.Length - 3));
                        break;
                    case "bamKANbutton":
                        leftCutSite = bamCutSite;
                        leftPlasmid = "bamKAN";
                        leftTop = BasePair.createFromString(Globals.bamKANcutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.bamKANcutSite.Substring(3, Globals.bamKANcutSite.Length - 3));
                        break;
                    case "ecoHumiraButton":
                        leftPlasmid = "ecoHumira";
                        leftCutSite = ecoCutSite;
                        leftTop = BasePair.createFromString(Globals.ecoHumiraCutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.ecoHumiraCutSite.Substring(3, Globals.ecoHumiraCutSite.Length - 3));
                        break;
                    case "bamHumiraButton":
                        leftPlasmid = "bamHumira";
                        leftCutSite = bamCutSite;
                        leftTop = BasePair.createFromString(Globals.bamHumiraCutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.bamHumiraCutSite.Substring(3, Globals.bamHumiraCutSite.Length - 3));
                        break;
                    case "ecoHumulinButton":
                        leftPlasmid = "ecoHumulin";
                        leftCutSite = ecoCutSite;
                        leftTop = BasePair.createFromString(Globals.ecoHumulinCutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.ecoHumulinCutSite.Substring(3, Globals.ecoHumulinCutSite.Length - 3));
                        break;
                    case "bamHumulinButton":
                        leftPlasmid = "bamHumulin";
                        leftCutSite = bamCutSite;
                        leftTop = BasePair.createFromString(Globals.bamHumulinCutSite.Substring(0, 8));
                        leftBottom = BasePair.createFromString(Globals.bamHumulinCutSite.Substring(3, Globals.bamHumulinCutSite.Length - 3));
                        break;

                }
            }
            else if (clickedButton.Name.Contains("2"))
            {
                switch (clickedButton.Name.Substring(0, clickedButton.Name.Length - 1))
                {
                    case "ecoAMPbutton":
                        rightCutSite = ecoCutSite;
                        rightPlasmid = "ecoAMP";
                        rightTop = BasePair.createFromString(Globals.ecoAMPcutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.ecoAMPcutSite.Substring(3, Globals.ecoAMPcutSite.Length - 3));
                        break;
                    case "bamAMPbutton":
                        rightCutSite = bamCutSite;
                        rightPlasmid = "bamAMP";
                        rightTop = BasePair.createFromString(Globals.bamAMPcutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.bamAMPcutSite.Substring(3, Globals.bamAMPcutSite.Length - 3));
                        break;
                    case "ecoKANbutton":
                        rightCutSite = ecoCutSite;
                        rightPlasmid = "ecoKAN";
                        rightTop = BasePair.createFromString(Globals.ecoKANcutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.ecoKANcutSite.Substring(3, Globals.ecoKANcutSite.Length - 3));
                        break;
                    case "bamKANbutton":
                        rightCutSite = bamCutSite;
                        rightPlasmid = "bamKAN";
                        rightTop = BasePair.createFromString(Globals.bamKANcutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.bamKANcutSite.Substring(3, Globals.bamKANcutSite.Length - 3));
                        break;
                    case "ecoHumiraButton":
                        rightPlasmid = "ecoHumira";
                        rightCutSite = ecoCutSite;
                        rightTop = BasePair.createFromString(Globals.ecoHumiraCutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.ecoHumiraCutSite.Substring(3, Globals.ecoHumiraCutSite.Length - 3));
                        break;
                    case "bamHumiraButton":
                        rightPlasmid = "bamHumira";
                        rightCutSite = bamCutSite;
                        rightTop = BasePair.createFromString(Globals.bamHumiraCutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.bamHumiraCutSite.Substring(3, Globals.bamHumiraCutSite.Length - 3));
                        break;
                    case "ecoHumulinButton":
                        rightPlasmid = "ecoHumulin";
                        rightCutSite = ecoCutSite;
                        rightTop = BasePair.createFromString(Globals.ecoHumulinCutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.ecoHumulinCutSite.Substring(3, Globals.ecoHumulinCutSite.Length - 3));
                        break;
                    case "bamHumulinButton":
                        rightPlasmid = "bamHumulin";
                        rightCutSite = bamCutSite;
                        rightTop = BasePair.createFromString(Globals.bamHumulinCutSite.Substring(0, 8));
                        rightBottom = BasePair.createFromString(Globals.bamHumulinCutSite.Substring(3, Globals.bamHumulinCutSite.Length - 3));
                        break;

                }
            }
            combinePanel.Refresh();
            if (leftTop != null && leftBottom != null && rightTop != null && rightBottom != null)
                merge();
        }

        private void combinePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int xPosition = 0;
            int yPosition = 50;
            
            //leftTop
            if(leftTop != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    xPosition = i * baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                    graphics.DrawString(leftTop[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                    graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + 7 * (baseDisplaySize / 8), xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                    graphics.DrawString(leftTop[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                }
                for (int i = 4; i < 8; i++)
                {
                    xPosition = i * baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                    graphics.DrawString(leftTop[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                }
            }
            //leftBottom
            if (leftBottom != null)
            {
                yPosition = 250;
                for (int i = 0; i < 4; i++)
                {
                    xPosition = i * baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                    graphics.DrawString(leftBottom[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                    graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + 7 * (baseDisplaySize / 8), xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                    graphics.DrawString(leftBottom[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                }
                for (int i = 4; i < 8; i++)
                {
                    xPosition = i * baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + 7 * (baseDisplaySize / 8), xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                    graphics.DrawString(leftBottom[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                }
            }
            //rightTop
            xPosition = combinePanel.Width;
            yPosition = 75 - animationYoffset;
            if (rightTop != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    xPosition -= baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                    graphics.DrawString(rightTop[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                    graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + 7 * (baseDisplaySize / 8), xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                    graphics.DrawString(rightTop[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                }
                for (int i = 4; i < 8; i++)
                {
                    xPosition -= baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + 7 * (baseDisplaySize / 8), xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                    graphics.DrawString(rightTop[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                }
            }
            //rightBottom
            yPosition = 225 + animationYoffset;
            xPosition = combinePanel.Width;
            if (rightBottom != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    xPosition -= baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                    graphics.DrawString(rightBottom[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                    graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + 7 * (baseDisplaySize / 8), xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                    graphics.DrawString(rightBottom[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                }
                for (int i = 4; i < 8; i++)
                {
                    xPosition -= baseDisplaySize;
                    graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                    graphics.DrawString(rightBottom[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                }
            }
        }

        private void merge()
        {
            if(leftCutSite == rightCutSite)
            {
                animationTimer.Start();
                insertPanel1.Enabled = false;
                insertPanel2.Enabled = false;
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if(animationYoffset < 25)
            {
                animationYoffset += 1;
                combinePanel.Refresh();
            }
            else
            {
                animationTimer.Stop();
                animationYoffset = 0;
                insertPanel1.Enabled = true;
                insertPanel2.Enabled = true;
                switch (leftPlasmid)
                {
                    case "ecoAMP":
                        if (rightPlasmid == "ecoHumulin")
                            Globals.ecoPampHumulinMerged = true;
                        else if (rightPlasmid == "ecoHumira")
                            Globals.ecoPampHumiraMerged = true;
                        break;
                    case "bamAMP":
                        if (rightPlasmid == "bamHumulin")
                            Globals.bamPampHumulinMerged = true;
                        else if (rightPlasmid == "bamHumira")
                            Globals.bamPampHumiraMerged = true;
                        break;
                    case "ecoKAN":
                        if (rightPlasmid == "ecoHumulin")
                            Globals.ecoPkanHumulinMerged = true;
                        else if (rightPlasmid == "ecoHumira")
                            Globals.ecoPkanHumiraMerged = true;
                        break;
                    case "bamKAN":
                        if (rightPlasmid == "bamHumulin")
                            Globals.bamPkanHumulinMerged = true;
                        else if (rightPlasmid == "bamHumira")
                            Globals.bamPkanHumiraMerged = true;
                        break;
                    case "ecoHumulin":
                        if(rightPlasmid == "ecoAMP")
                            Globals.ecoPampHumulinMerged = true;
                        else if (rightPlasmid == "ecoKAN")
                            Globals.ecoPkanHumulinMerged = true;
                        break;
                    case "bamHumulin":
                        if (rightPlasmid == "bamAMP")
                            Globals.bamPampHumulinMerged = true;
                        else if (rightPlasmid == "bamKAN")
                            Globals.bamPkanHumulinMerged = true;
                        break;
                    case "ecoHumira":
                        if (rightPlasmid == "ecoAMP")
                            Globals.ecoPampHumiraMerged = true;
                        else if (rightPlasmid == "ecoKAN")
                            Globals.ecoPkanHumiraMerged = true;
                        break;
                    case "bamHumira":
                        if (rightPlasmid == "bamAMP")
                            Globals.bamPampHumiraMerged = true;
                        else if (rightPlasmid == "bamKAN")
                            Globals.bamPkanHumiraMerged = true;
                        break;
                }
                Console.WriteLine("Checkoff completed");
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            Globals.progress = new progressScreen();
            Globals.progress.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Globals.cutScreen.Show();
            this.Hide();
        }

        private void geneMerger_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
