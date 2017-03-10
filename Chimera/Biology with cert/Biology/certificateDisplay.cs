using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
    public partial class certificateDisplay : Form
    {
        public certificateDisplay()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            Height = Chimera.Properties.Resources.certificate.Height / 2 + 50;
            Width = Chimera.Properties.Resources.certificate.Width / 2 + 25;
            certPicture.Height = Chimera.Properties.Resources.certificate.Height / 2;
            certPicture.Width = Chimera.Properties.Resources.certificate.Width / 2;
            certPicture.Location = new Point(0, 25);
            certPicture.Image = Chimera.Properties.Resources.certificate;
            certPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.certPicture_Paint);
            printCert.Location = new Point(Width-125 , 12);

        }


        private void certificateDisplay_Load(object sender, EventArgs e)
        {

        }

        private void certificateDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void certPicture_Paint(object sender, System.Windows.Forms.PaintEventArgs g)
        {
            Graphics e = g.Graphics;
            string completedLeft = "";
            if (Globals.ecoPampHumulinMerged)
                completedLeft += Globals.s8;
            completedLeft += "\n";
            if (Globals.ecoPampHumiraMerged)
                completedLeft += Globals.s1;
            completedLeft += "\n";
            if (Globals.bamPampHumulinMerged)
                completedLeft += Globals.s2;
            completedLeft += "\n";
            if (Globals.bamPampHumiraMerged)
                completedLeft += Globals.s3;
            string completedRight = "";
            if (Globals.ecoPkanHumulinMerged)
                completedRight += Globals.s4;
            completedRight += "\n";
            if (Globals.ecoPkanHumiraMerged)
                completedRight += Globals.s5;
            completedRight += "\n";
            if (Globals.bamPkanHumulinMerged)
                completedRight += Globals.s6;
            completedRight += "\n";
            if (Globals.bamPkanHumiraMerged)
                completedRight += Globals.s7;
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            e.DrawImage(new Bitmap(Chimera.Properties.Resources.certificate), 0, 0, 1100, 850);
            e.DrawString(Globals.name,
            new Font("Bell MT", 40, FontStyle.Regular), Brushes.Black, 550, 390, format);
            e.DrawString(completedLeft,
            new Font("Bell MT", 16, FontStyle.Regular), Brushes.Black, 300, 500);
            e.DrawString(completedRight,
            new Font("Bell MT", 16, FontStyle.Regular), Brushes.Black, 650, 500);
            e.DrawString(DateTime.Now.ToString(" d MMMM, yyyy\r\n h:mm tt     " + Globals.period),
            new Font("Microsoft Sans Serif", 16, FontStyle.Regular), Brushes.Gray, 745, 665);

        }

        private void printCert1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string completedLeft = "";
            if (Globals.ecoPampHumulinMerged)
                completedLeft += Globals.s8;
            completedLeft += "\n";
            if (Globals.ecoPampHumiraMerged)
                completedLeft += Globals.s1;
            completedLeft += "\n";
            if (Globals.bamPampHumulinMerged)
                completedLeft += Globals.s2;
            completedLeft += "\n";
            if (Globals.bamPampHumiraMerged)
                completedLeft += Globals.s3;
            string completedRight = "";
            if (Globals.ecoPkanHumulinMerged)
                completedRight += Globals.s4;
            completedRight += "\n";
            if (Globals.ecoPkanHumiraMerged)
                completedRight += Globals.s5;
            completedRight += "\n";
            if (Globals.bamPkanHumulinMerged)
                completedRight += Globals.s6;
            completedRight += "\n";
            if (Globals.bamPkanHumiraMerged)
                completedRight += Globals.s7;
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawImage(new Bitmap(Chimera.Properties.Resources.certificate), 0, 0, 1100, 850);
            e.Graphics.DrawString(Globals.name,
            new Font("Bell MT", 40, FontStyle.Regular), Brushes.Black, 550, 390, format);
            e.Graphics.DrawString(completedLeft,
            new Font("Bell MT", 16, FontStyle.Regular), Brushes.Black, 300, 500);
            e.Graphics.DrawString(completedRight,
            new Font("Bell MT", 16, FontStyle.Regular), Brushes.Black, 650, 500);
            e.Graphics.DrawString(DateTime.Now.ToString(" d MMMM yyyy\r\n h:mm tt"),
            new Font("Microsoft Sans Serif", 16, FontStyle.Regular), Brushes.Gray, 745, 665);

        }

        private void printCert_Click(object sender, EventArgs e)
        {
            printCert1.DefaultPageSettings.Landscape = true;
            int printWidth = printCert1.DefaultPageSettings.Bounds.Width;
            int printHeight = printCert1.DefaultPageSettings.Bounds.Height;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printCert1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Globals.progress.Show();
            this.Hide();
        
    }
    }
}
