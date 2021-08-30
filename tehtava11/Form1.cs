using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava11
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void heita_button_Click(object sender, EventArgs e)
        {
            piiraNoppa(noppa1_pictureBox);
            piiraNoppa(noppa2_pictureBox);
            piiraNoppa(noppa3_pictureBox);
            piiraNoppa(noppa4_pictureBox);
        }
        private void piiraNoppa(PictureBox Noppat)
        {
            Random heita = new Random();
            int noppa = heita.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    Noppat.Image = Properties.Resources._1;
                    break;
                case 2:
                    Noppat.Image = Properties.Resources._2;
                    break;
                case 3:
                    Noppat.Image = Properties.Resources._3;
                    break;
                case 4:
                    Noppat.Image = Properties.Resources._4;
                    break;
                case 5:
                    Noppat.Image = Properties.Resources._5;
                    break;
                case 6:
                    Noppat.Image = Properties.Resources._6;
                    break;
            }
        }












    }
}
