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
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }
        Musteri musteri = new Musteri();
        readonly MusteriDal mdal = new MusteriDal();
        KaydinizEklendi ke = new KaydinizEklendi();
        textboxKontrol txtCheck = new textboxKontrol();


       
        public void ekle()
        {     
            musteri.Ad = adTxt.Text;
            musteri.Soyad = soyadTxt.Text;
            musteri.KullaniciAdi = kullaniciAditxt.Text;
            musteri.Sifre = sifreTxt.Text;
            musteri.Adres = adresTxt.Text;
            musteri.Eposta = epostaTxt.Text;
            musteri.TelefonNo = telnoTxt.Text;
            musteri.KartNo = kartnoTxt.Text;
            musteri.CVC = cvcTxt.Text;
            mdal.Ekle(musteri);
            ke.Show();
            this.Hide();
        }
        private void listeleBtn_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void adTxt_TextChanged(object sender, EventArgs e)
        {
            label10.Text = adTxt.Text;
        }

        private void adTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
          textboxKontrol.sadeceharf(adTxt,e);
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {

        }

        private void soyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadeceharf(soyadTxt, e);
        }

        private void telnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(telnoTxt, e);
        }

        private void kartnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(kartnoTxt, e);
        }

        private void cvcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(cvcTxt, e);
        }

        private void kartnoTxt_TextChanged(object sender, EventArgs e)
        {
            kartnoLbl.Text= kartnoTxt.Text  ;
        }

        private void soyadTxt_TextChanged(object sender, EventArgs e)
        {
            label9.Text = soyadTxt.Text;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var ml = new MusteriLogin();
            ml.Show();
            this.Hide();
        }
    }
}
