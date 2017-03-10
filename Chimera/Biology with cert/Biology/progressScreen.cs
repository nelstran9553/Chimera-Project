using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
    public partial class progressScreen : Form
    {

        public progressScreen()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            nameLabel.Text = Globals.name + ", " + Globals.period;
            if (Globals.ecoPampHumulinMerged)
            {
                ecoAMPhumulinCheck.Text = "&✔ " + "EcoR1 - pAMP and Humulin";
                Globals.s8 = "EcoR1 - pAMP and Humulin";
            }
            if (Globals.ecoPampHumiraMerged)
            {
                ecoAMPhumiraCheck.Text = "&✔ " + "EcoR1 - pAMP and Humira";
                Globals.s1 = "EcoR1 - pAMP and Humira";
            }
            if (Globals.bamPampHumulinMerged)
            {
                bamAMPhumulinCheck.Text = "&✔ " + "BamR1 - pAMP and Humulin";
                Globals.s2 = "BamR1 - pAMP and Humulin";
            }
            if (Globals.bamPampHumiraMerged)
            {
                bamAMPhumiraCheck.Text = "&✔ " + "BamR1 - pAMP and Humira";
                Globals.s3 = "BamR1 - pAMP and Humira";
            }
            if (Globals.ecoPkanHumulinMerged)
            {
                ecoKANhumulinCheck.Text = "&✔ " + "EcoR1 - pKAN and Humulin";
                Globals.s4 = "EcoR1 - pKAN and Humulin";
            }
            if (Globals.ecoPkanHumiraMerged)
            {
                ecoKANhumulinCheck.Text = "&✔ " + "EcoR1 - pKAN and Humira";
                Globals.s5 = "EcoR1 - pKAN and Humira";
            }
            if (Globals.bamPkanHumulinMerged)
            {
                bamKANhumulinCheck.Text = "&✔ " + "BamR1 - pKAN and Humulin";
                Globals.s6 = "BamR1 - pKAN and Humulin";
            }
            if (Globals.bamPkanHumiraMerged)
            {
                bamKANhumiraCheck.Text = "&✔ " + "BamR1 - pKAN and Humira";
                Globals.s7 = "BamR1 - pKAN and Humira";
            }
            }

        private void backButton_Click(object sender, EventArgs e)
        {
            Globals.mergeScreen.Show();
            this.Hide();
        }

        private void progressScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            int printWidth = printDocument1.DefaultPageSettings.Bounds.Width;
            int printHeight = printDocument1.DefaultPageSettings.Bounds.Height;
            
            Globals.certificateScreen = new certificateDisplay();
            Globals.certificateScreen.Show();
            this.Hide();
        }



        

        private void progressScreen_Load(object sender, EventArgs e)
        {

        }

        private void ecoAMPhumulinCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
