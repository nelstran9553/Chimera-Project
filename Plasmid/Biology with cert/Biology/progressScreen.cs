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

namespace BTSimulation
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
                ecoAMPhumulinCheck.Checked = true;
                Globals.s8 = ecoAMPhumulinCheck.Text;
            }
            if (Globals.ecoPampHumiraMerged)
            {
                ecoAMPhumiraCheck.Checked = true;
                Globals.s1 = ecoAMPhumiraCheck.Text;
            }
            if (Globals.bamPampHumulinMerged)
            {
                bamAMPhumulinCheck.Checked = true;
                Globals.s2 = bamAMPhumulinCheck.Text;
            }
            if (Globals.bamPampHumiraMerged)
            {
                bamAMPhumiraCheck.Checked = true;
                Globals.s3 = bamAMPhumiraCheck.Text;
            }
            if (Globals.ecoPkanHumulinMerged)
            {
                ecoKANhumulinCheck.Checked = true;
                Globals.s4 = ecoKANhumulinCheck.Text;
            }
            if (Globals.ecoPkanHumiraMerged)
            {
                ecoKANhumiraCheck.Checked = true;
                Globals.s5 = ecoKANhumiraCheck.Text;
            }
            if (Globals.bamPkanHumulinMerged)
            {
                bamKANhumulinCheck.Checked = true;
                Globals.s6 = ecoAMPhumiraCheck.Text;
            }
            if (Globals.bamPkanHumiraMerged)
            {
                bamKANhumiraCheck.Checked = true;
                Globals.s7 = ecoAMPhumiraCheck.Text;
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



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string completedLeft = "";
            if (Globals.ecoPampHumulinMerged)
                completedLeft += ecoAMPhumulinCheck.Text;
            completedLeft += "\n";
            if (Globals.ecoPampHumiraMerged)
                completedLeft += ecoAMPhumiraCheck.Text;
            completedLeft += "\n";
            if (Globals.bamPampHumulinMerged)
                completedLeft += bamAMPhumulinCheck.Text;
            completedLeft += "\n";
            if (Globals.bamPampHumiraMerged)
                completedLeft += bamAMPhumiraCheck.Text;
            string completedRight = "";
            if (Globals.ecoPkanHumulinMerged)
                completedRight += ecoKANhumulinCheck.Text;
            completedRight += "\n";
            if (Globals.ecoPkanHumiraMerged)
                completedRight += ecoKANhumiraCheck.Text;
            completedRight += "\n";
            if (Globals.bamPkanHumulinMerged)
                completedRight += bamKANhumulinCheck.Text;
            completedRight += "\n";
            if (Globals.bamPkanHumiraMerged)
                completedRight += bamKANhumiraCheck.Text;
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawImage(new Bitmap(BTSimulation.Properties.Resources.certificate), 0, 0, 1100, 850);
            e.Graphics.DrawString(Globals.name,
            new Font("Bell MT", 40, FontStyle.Regular), Brushes.Black, 550, 390, format);
            e.Graphics.DrawString(completedLeft,
            new Font("Bell MT", 16, FontStyle.Regular), Brushes.Black, 300, 500);
            e.Graphics.DrawString(completedRight,
            new Font("Bell MT", 16, FontStyle.Regular), Brushes.Black, 650, 500);
            e.Graphics.DrawString(DateTime.Now.ToString(" d MMMM yyyy\r\n h:mm tt"),
            new Font("Microsoft Sans Serif", 16, FontStyle.Regular), Brushes.Gray, 745, 665);

        }

        private void progressScreen_Load(object sender, EventArgs e)
        {

        }

        private void ecoAMPhumulinCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
