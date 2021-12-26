using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class MusteriMainMenu : Form
    {
        public MusteriMainMenu()
        {
            InitializeComponent();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            MusteriSepetPaneli musteriSepetiPaneli = new MusteriSepetPaneli();
            musteriSepetiPaneli.Show();
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            MusteriUrunler musteriUrunler = new MusteriUrunler();
            musteriUrunler.Show();
            this.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            MusteriSiparisPaneli msp = new MusteriSiparisPaneli();
            msp.Show();
            this.Hide();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            MusteriBilgilerim musteriBilgilerim = new MusteriBilgilerim();
            musteriBilgilerim.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
