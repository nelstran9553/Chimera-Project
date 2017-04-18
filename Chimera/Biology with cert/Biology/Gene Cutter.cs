using System;
using System.Drawing;

using System.Windows.Forms;

namespace Chimera
{
    public partial class geneCutter : Form
    {
        const string pAMP_DNA = "AGACGTAGCATGCTAGAATTCGATGCTGATCGATCGATCGATGCAGGATCCGTCGAGCTGCTGCAT";
        const string pKAN_DNA = "CCCTAGCTATGCAGTTTCGACAGAATTCTGCATGTCGTAGCGGATCCGTCAGCGTGTGACGAGCTA";
        const string humulin_DNA = "GGCTAGCTGCATGCGTACGAATTCTGTCAGTCGGATCCGTCAGTCGGTATGCTA";
        const string humira_DNA = "TCAGTCGTACGTAGTCAGTACGTGCGATCGGATCCAAGTGTACCGAATTCAGTGG";
        const string EcoRI_cutSite = "GAATTC";
        const string BamHI_cutSite = "GGATCC";
        bool completeLoop = true;
        string chosenGene;
        string chosenCutSite;
        bool successfullyCut;
        BasePair[] plasmid;
        Random startPicker = new Random();
        int DNA_Index = 0;
        int baseDisplaySize = 50;
        Font font = new Font("Arial", 12);
        int cutBeginning = -1;
        int cutEnd = -1;
        
        public geneCutter()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.Text = "Gene Merger | " + Globals.name + " - " + Globals.period;
            plasmid = BasePair.createFromString(pAMP_DNA);
            enzymeCombo.SelectedIndex = 0;
            //DNA_Index = startPicker.Next(plasmid.Length);
            DNA_Index = 0;
            newDNAcombo.SelectedIndex = 0;
            chosenGene = "pAMP";
            ecoAMPcheck.Checked = Globals.ecoAMPcut;
            bamAMPcheck.Checked = Globals.bamAMPcut;
            ecoKANcheck.Checked = Globals.ecoKANcut;
            bamKANcheck.Checked = Globals.bamKANcut;
            ecoHumulinCheck.Checked = Globals.ecoHumulinCut;
            bamHumulinCheck.Checked = Globals.bamHumulinCut;
            ecoHumiraCheck.Checked = Globals.ecoHumiraCut;
            bamHumiraCheck.Checked = Globals.bamHumiraCut;
            resetButton.Enabled = false;
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen selectionPen = new Pen(Color.Green, 3);
            Pen endPen = new Pen(Color.Blue, 3);
            Panel panel = (Panel)sender;
            int i = DNA_Index;
            int xPosition = 50;
            int yPosition = 5;
            //int yOffset = 0;

            //Top Row

            for (int z = 0; z < displayPanel.Width / baseDisplaySize - 2; z++)
            {
                xPosition = z * baseDisplaySize + 50;
                if (!successfullyCut)
                {
                    graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                    graphics.DrawString(plasmid[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                    graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                    graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize - baseDisplaySize / 8, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                    graphics.DrawString(plasmid[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                    if(i == cutEnd || i == cutBeginning)
                    {
                        graphics.DrawRectangle(new Pen(Color.Green, 2), xPosition, yPosition, baseDisplaySize, baseDisplaySize);
                    }
                }
                else
                {
                    if(z > 6)
                    {
                        graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize*3, xPosition + baseDisplaySize, yPosition + baseDisplaySize*3);
                        graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize * 3, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8 + baseDisplaySize * 3);
                        graphics.DrawString(plasmid[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8 + baseDisplaySize * 3);
                        graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize*4, xPosition + baseDisplaySize, yPosition + baseDisplaySize*4);
                        graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize*4 - baseDisplaySize / 8, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize*4);
                        graphics.DrawString(plasmid[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2 + baseDisplaySize * 3);
                    }
                    else if(z > 2 && z < 7)
                    {
                        graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                        graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                        graphics.DrawString(plasmid[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                        graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize * 4, xPosition + baseDisplaySize, yPosition + baseDisplaySize * 4);
                        graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize * 4 - baseDisplaySize / 8, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize * 4);
                        graphics.DrawString(plasmid[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2 + baseDisplaySize * 3);
                    }
                    else
                    {
                        graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                        graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                        graphics.DrawString(plasmid[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 8);
                        graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                        graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize - baseDisplaySize / 8, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize);
                        graphics.DrawString(plasmid[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2 - 8, yPosition + baseDisplaySize / 2);
                    }
                }
                i++;
                if (i >= plasmid.Length)
                {
                    i = 0;
                }
            }

            //Right Column
            xPosition += baseDisplaySize;
            for (int z = 0; z < displayPanel.Height / baseDisplaySize - 2; z++)
            {
                if(!successfullyCut)
                {
                    yPosition = z * baseDisplaySize + 60;
                    if (i == cutEnd || i == cutBeginning)
                    {
                        graphics.DrawRectangle(new Pen(Color.Green, 2), xPosition, yPosition - baseDisplaySize/2, baseDisplaySize, baseDisplaySize);
                    }
                }
                else
                    yPosition = z * baseDisplaySize + 55 + baseDisplaySize*3;
                graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition, yPosition + baseDisplaySize);
                graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize, yPosition, xPosition + baseDisplaySize - baseDisplaySize / 8, yPosition);
                graphics.TranslateTransform(panel.Width, 0);
                graphics.RotateTransform(90);
                graphics.DrawString(plasmid[i].getTop(), font, Brushes.Black, yPosition - 6, baseDisplaySize / 8 + 10);
                graphics.DrawString(plasmid[i].getBottom(), font, Brushes.Black, yPosition - 6, 5 * (baseDisplaySize / 8));
                graphics.ResetTransform();
                graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize, yPosition, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize / 8, yPosition + baseDisplaySize);
                i++;
                if (i >= plasmid.Length)
                {
                    i = 0;
                }
            }

            //Bottom Row
            if (!successfullyCut)
                yPosition += baseDisplaySize;
            else
                yPosition -= baseDisplaySize*2;
            for (int z = 0; z < displayPanel.Width / baseDisplaySize - 2; z++)
            {
                xPosition = z * baseDisplaySize + 50;
                graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition + baseDisplaySize, yPosition);
                graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize / 8);
                graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize / 2, yPosition + baseDisplaySize, xPosition + baseDisplaySize / 2, yPosition - baseDisplaySize / 8 + baseDisplaySize);
                graphics.TranslateTransform(panel.Width, panel.Height);
                graphics.RotateTransform(180);
                if (i == cutEnd || i == cutBeginning)
                {
                    graphics.DrawRectangle(new Pen(Color.Green, 2), xPosition + 8, baseDisplaySize / 8 - 5, baseDisplaySize, baseDisplaySize);
                }
                graphics.DrawString(plasmid[i].getBottom(), font, Brushes.Black, xPosition + baseDisplaySize / 2, (panel.Height - yPosition - 16) - baseDisplaySize / 8);
                graphics.DrawString(plasmid[i].getTop(), font, Brushes.Black, xPosition + baseDisplaySize / 2, baseDisplaySize / 8 + 8);
                graphics.ResetTransform();
                i++;
                if (i >= plasmid.Length)
                {
                    i = 0;
                }
            }
            //Left Column
            if (!completeLoop)
            {
                cornerBox1.Visible = false;
                cornerBox4.Visible = false;
                return;
            }
            xPosition = 5;
            for (int z = 0; z < displayPanel.Height / baseDisplaySize - 2; z++)
            {
                yPosition = z * baseDisplaySize + 55;
                graphics.DrawLine(Pens.Black, xPosition, yPosition, xPosition, yPosition + baseDisplaySize);
                graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize, yPosition, xPosition + baseDisplaySize - baseDisplaySize / 8, yPosition);
                graphics.TranslateTransform(0, panel.Height);
                graphics.RotateTransform(270);
                if (i == cutEnd || i == cutBeginning)
                {
                    graphics.DrawRectangle(new Pen(Color.Green, 2), yPosition - baseDisplaySize / 2, baseDisplaySize/8, baseDisplaySize, baseDisplaySize);
                }
                graphics.DrawString(plasmid[i].getTop(), font, Brushes.Black, yPosition - 6, baseDisplaySize / 8 + 8);
                graphics.DrawString(plasmid[i].getBottom(), font, Brushes.Black, yPosition - 6, 5 * (baseDisplaySize / 8));
                graphics.ResetTransform();
                graphics.DrawLine(Pens.Black, xPosition + baseDisplaySize, yPosition, xPosition + baseDisplaySize, yPosition + baseDisplaySize);
                graphics.DrawLine(Pens.Black, xPosition, yPosition + baseDisplaySize, xPosition + baseDisplaySize / 8, yPosition + baseDisplaySize);
                i++;
                if (i >= plasmid.Length)
                {
                    i = 0;
                }
            }
        }

        private void pushClockwiseButton_Click(object sender, EventArgs e)
        {
            DNA_Index--;
            if (DNA_Index < 0)
            {
                DNA_Index = plasmid.Length - 1;
            }
            displayPanel.Refresh();
        }

        private void pushCounterclockwiseButton_Click(object sender, EventArgs e)
        {
            DNA_Index++;
            if(DNA_Index >= plasmid.Length)
            {
                DNA_Index = 0;
            }
            displayPanel.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setEnzymeLabel();
        }

        private void setEnzymeLabel()
        {
            if (enzymeCombo.Text == "EcoRI")
            {
                chosenCutSite = EcoRI_cutSite;
                cutSiteLabel.Text = EcoRI_cutSite;
            }
            else if (enzymeCombo.Text == "BamHI")
            {
                chosenCutSite = BamHI_cutSite;
                cutSiteLabel.Text = BamHI_cutSite;
            }
        }

        private void cutBeginningButton_Click(object sender, EventArgs e)
        {
            cutBeginning = DNA_Index + 2;
            if(cutEnd != -1)
            {
                checkCut(findSelectedCutSite());
            }

            displayPanel.Refresh();
        }

        private void cutEndButton_Click(object sender, EventArgs e)
        {
            cutEnd = DNA_Index + 7;
            if (cutBeginning != -1)
            {
                checkCut(findSelectedCutSite());
            }
            displayPanel.Refresh();
            
        }

        private string findSelectedCutSite()
        {
            try
            {
                string returnValue = "";
                for (int i = cutBeginning; i <= cutEnd; i++)
                {
                    returnValue += plasmid[i].getTop();
                }
                Console.WriteLine(returnValue);
                return returnValue;
            }catch(IndexOutOfRangeException e)
            {
                return null;
            }
        }

        private void checkCut(string testCutSite)
        {
            if(testCutSite == chosenCutSite || testCutSite == ReverseText(chosenCutSite))
            {
                Console.WriteLine("succesful cut");
                successfullyCut = true;
                //enzymeCombo.Enabled = false;
                cutSiteLabel.Visible = false;
                pushClockwiseButton.Enabled = false;
                pushCounterclockwiseButton.Enabled = false;
                cutBeginningButton.Enabled = false;
                cutEndButton.Enabled = false;
                checkOffList();
                cornerBox3.Visible = false;
                cornerBox2.Top += baseDisplaySize * 3;

                context.Visible = false;
                helpLabel.Visible = false;
                instructionLabel.Visible = false;
                stepOne.Visible = false;
                stepTwo.Visible = false;
                stepThree.Visible = false;
                stepFour.Visible = false;
                showStepOne.Visible = false;
                showStepTwo.Visible = false;
                showStepThree.Visible = false;
                showStepFour.Visible = false;
                stepOneGif.Visible = false;
                stepTwoGif.Visible = false;
                stepThreeGif.Visible = false;
                stepFourGif.Visible = false;

                displayPanel.Refresh();
            }
            else
            {
                //you messed up
            }
        }

        private void checkOffList()
        {
            switch (chosenGene)
            {
                case "pAMP":
                    if(chosenCutSite == EcoRI_cutSite)
                    {
                        ecoAMPcheck.Checked = true;
                        Globals.ecoAMPcut = true;
                        resetButton.Enabled = true;
                        Globals.ecoAMPcutSite = pAMP_DNA.Substring(cutBeginning-3, (cutEnd - cutBeginning) + 7);
                    }
                    else if(chosenCutSite == BamHI_cutSite)
                    {
                        bamAMPcheck.Checked = true;
                        Globals.bamAMPcut = true;
                        resetButton.Enabled = true;
                        Globals.bamAMPcutSite = pAMP_DNA.Substring(cutBeginning - 3, (cutEnd - cutBeginning) + 7);
                    }
                    break;
                case "pKAN":
                    if (chosenCutSite == EcoRI_cutSite)
                    {
                        ecoKANcheck.Checked = true;
                        Globals.ecoKANcut = true;
                        resetButton.Enabled = true;
                        Globals.ecoKANcutSite = pKAN_DNA.Substring(cutBeginning - 3, (cutEnd - cutBeginning) + 7);
                    }
                    else if (chosenCutSite == BamHI_cutSite)
                    {
                        bamKANcheck.Checked = true;
                        Globals.bamKANcut = true;
                        resetButton.Enabled = true;
                        Globals.bamKANcutSite = pKAN_DNA.Substring(cutBeginning - 3, (cutEnd - cutBeginning) + 7);
                    }
                    break;
                case "Humulin":
                    if (chosenCutSite == EcoRI_cutSite)
                    {
                        ecoHumulinCheck.Checked = true;
                        Globals.ecoHumulinCut = true;
                        resetButton.Enabled = true;
                        Globals.ecoHumulinCutSite = humulin_DNA.Substring(cutBeginning - 3, (cutEnd - cutBeginning) + 7);
                    }
                    else if (chosenCutSite == BamHI_cutSite)
                    {
                        bamHumulinCheck.Checked = true;
                        Globals.bamHumulinCut = true;
                        resetButton.Enabled = true;
                        Globals.bamHumulinCutSite = humulin_DNA.Substring(cutBeginning - 3, (cutEnd - cutBeginning) + 7);
                    }
                    break;
                case "Humira":
                    if (chosenCutSite == EcoRI_cutSite)
                    {
                        ecoHumiraCheck.Checked = true;
                        Globals.ecoHumiraCut = true;
                        resetButton.Enabled = true;
                        Globals.ecoHumiraCutSite = humira_DNA.Substring(cutBeginning - 3, (cutEnd - cutBeginning) + 7);
                    }
                    else if (chosenCutSite == BamHI_cutSite)
                    {
                        bamHumiraCheck.Checked = true;
                        Globals.bamHumiraCut = true;
                        resetButton.Enabled = true;
                        Globals.bamHumiraCutSite = humira_DNA.Substring(cutBeginning - 3, (cutEnd - cutBeginning) + 7);
                    }
                    break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetButton.Enabled = false;
            context.Visible = true;
            helpLabel.Visible = true;
            successfullyCut = false;
            enzymeCombo.Enabled = true;
            cutSiteLabel.Visible = true;
            pushClockwiseButton.Enabled = true;
            pushCounterclockwiseButton.Enabled = true;
            cutBeginningButton.Enabled = true;
            cutEndButton.Enabled = true;
            cornerBox2.Top -= baseDisplaySize * 3;
            cornerBox1.Visible = true;
            cornerBox3.Visible = true;
            cornerBox4.Visible = true;
            string newDNA;
            switch (newDNAcombo.SelectedIndex)
            {
                case 0:
                    newDNA = pAMP_DNA;
                    break;
                case 1:
                    newDNA = pKAN_DNA;
                    break;
                case 2:
                    newDNA = humira_DNA;
                    break;
                case 3:
                    newDNA = humulin_DNA;
                    break;
                default:
                    newDNA = pAMP_DNA;
                    break;
            }
            plasmid = BasePair.createFromString(newDNA);
            //DNA_Index = startPicker.Next(plasmid.Length);
            DNA_Index = 0;
            chosenGene = newDNAcombo.Text;
            if (chosenGene == "Humira" || chosenGene == "Humulin")
                completeLoop = false;
            if (chosenGene == "pKAN" || chosenGene == "pAMP")
                completeLoop = true;
            cutBeginning = -1;
            cutEnd = -1;
            displayPanel.Refresh();
        }

        public string ReverseText(string text)
        {
            string reverse = "";
            for (int i = text.Length - 1; i > -1; i--)
            {
                reverse += text[i];
            }
            return reverse;
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {

            Globals.mergeScreen = new geneMerger();
            Globals.mergeScreen.Show();
            this.Hide();
        }

        private void geneCutter_Shown(object sender, EventArgs e)
        {
            setEnzymeLabel();
        }

        private void geneCutter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            helpLabel.Visible = false;
            instructionLabel.Visible = true;
            stepOne.Visible = true;
            showStepOne.Visible = true;
            showStepOne.BringToFront();
            stepTwo.Visible = true;
            showStepTwo.Visible = true;
            showStepTwo.BringToFront();
            stepThree.Visible = true;
            showStepThree.Visible = true;
            showStepThree.BringToFront();
            stepFour.Visible = true;
            showStepFour.Visible = true;
            showStepFour.BringToFront();
        }

        private void showStepOne_Click(object sender, EventArgs e)
        {
            if (showStepOne.Text != "Hide")
            {
                showStepOne.Text = "Hide";
                stepOneGif.Visible = true;
                showStepTwo.Text = "Show";
                stepTwoGif.Visible = false;
                showStepThree.Text = "Show";
                stepThreeGif.Visible = false;
                showStepFour.Text = "Show";
                stepFourGif.Visible = false;
            }
            else
            {
                showStepOne.Text = "Show";
                stepOneGif.Visible = false;
            }

        }

        private void showStepTwo_Click(object sender, EventArgs e)
        {
            if (showStepTwo.Text != "Hide")
            {
                showStepTwo.Text = "Hide";
                stepTwoGif.Visible = true;
                showStepOne.Text = "Show";
                stepOneGif.Visible = false;
                showStepThree.Text = "Show";
                stepThreeGif.Visible = false;
                showStepFour.Text = "Show";
                stepFourGif.Visible = false;
            }
            else
            {
                showStepTwo.Text = "Show";
                stepTwoGif.Visible = false;
            }
        }

        private void showStepThree_Click(object sender, EventArgs e)
        {
            if (showStepThree.Text != "Hide")
            {
                showStepThree.Text = "Hide";
                stepThreeGif.Visible = true;
                showStepTwo.Text = "Show";
                stepTwoGif.Visible = false;
                showStepOne.Text = "Show";
                stepOneGif.Visible = false;
                showStepFour.Text = "Show";
                stepFourGif.Visible = false;
            }
            else
            {
                showStepThree.Text = "Show";
                stepThreeGif.Visible = false;
            }
        }

        private void showStepFour_Click(object sender, EventArgs e)
        {
            if (showStepFour.Text != "Hide")
            {
                showStepFour.Text = "Hide";
                stepFourGif.Visible = true;
                showStepTwo.Text = "Show";
                stepTwoGif.Visible = false;
                showStepOne.Text = "Show";
                stepOneGif.Visible = false;
                showStepThree.Text = "Show";
                stepThreeGif.Visible = false;

            }
            else
            {
                showStepFour.Text = "Show";
                stepFourGif.Visible = false;
            }
        }

        private void ecoAMPcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ecoAMPcheck.Checked == true && ecoHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (ecoAMPcheck.Checked == true && ecoHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void ecoKANcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ecoKANcheck.Checked == true && ecoHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (ecoKANcheck.Checked == true && ecoHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void ecoHumiraCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ecoAMPcheck.Checked == true && ecoHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (ecoKANcheck.Checked == true && ecoHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void ecoHumulinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ecoAMPcheck.Checked == true && ecoHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (ecoKANcheck.Checked == true && ecoHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void bamAMPcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bamAMPcheck.Checked == true && bamHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (bamAMPcheck.Checked == true && bamHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void bamKANcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bamKANcheck.Checked == true && bamHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (bamKANcheck.Checked == true && bamHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void bamHumiraCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bamAMPcheck.Checked == true && bamHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (bamKANcheck.Checked == true && bamHumiraCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void bamHumulinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bamAMPcheck.Checked == true && bamHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
            if (bamKANcheck.Checked == true && bamHumulinCheck.Checked == true)
            {
                mergeButton.Enabled = true;
            }
        }

        private void newDNAcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenGene = newDNAcombo.Text;
        }
    }
}