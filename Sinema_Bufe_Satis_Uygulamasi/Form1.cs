using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, çay, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet=Convert.ToInt16(TxtBilet.Text);
            su= Convert.ToInt16(TxtSu.Text);
            çay=Convert.ToInt16(TxtCay.Text);

            toplam = misir * 4 + çay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + " TL ";


            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
        }
    }
}
