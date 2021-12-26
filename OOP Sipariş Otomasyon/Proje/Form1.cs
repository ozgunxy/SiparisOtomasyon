using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Musteri musteri = new Musteri();
        MusteriDal mdal = new MusteriDal();

        public void listele()
        {
            bunifuDataGridView1.DataSource = mdal.Listele();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void cikBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }
        public void txtyeaktar()
        {
            idTxt.Text = bunifuDataGridView1.CurrentRow.Cells[0].Value.ToString();
            adTxt.Text = bunifuDataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadTxt.Text = bunifuDataGridView1.CurrentRow.Cells[2].Value.ToString();
            kadiTxt.Text = bunifuDataGridView1.CurrentRow.Cells[3].Value.ToString();
            sifretxt.Text = bunifuDataGridView1.CurrentRow.Cells[4].Value.ToString();
           adresTxt.Text = bunifuDataGridView1.CurrentRow.Cells[5].Value.ToString();
            epostaTxt.Text = bunifuDataGridView1.CurrentRow.Cells[6].Value.ToString();
            telefonnoTxt.Text = bunifuDataGridView1.CurrentRow.Cells[7].Value.ToString();
           kartnoTxt.Text = bunifuDataGridView1.CurrentRow.Cells[8].Value.ToString();
            kartcvcTxt.Text = bunifuDataGridView1.CurrentRow.Cells[9].Value.ToString();
            sepetTxt.Text = bunifuDataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
        public void sil()
        {
           
            Musteri musteri= new Musteri();
            musteri = (Musteri)bunifuDataGridView1.CurrentRow.DataBoundItem;
            mdal.Sil(musteri);
            MessageBox.Show("Seçtiğiniz kayıt silinmiştir", " " ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtyeaktar();
        }
        public void ekle()
        {
            Musteri yenikisi= new Musteri();
            musteri.Ad = adTxt.Text;
            musteri.Soyad = soyadTxt.Text;
            musteri.KullaniciAdi = kadiTxt.Text;
            musteri.Sifre = sifretxt.Text;
            musteri.Adres = adresTxt.Text;
            musteri.Eposta = epostaTxt.Text;
            musteri.TelefonNo = telefonnoTxt.Text;
            musteri.KartNo = kartnoTxt.Text;
            musteri.CVC = kartcvcTxt.Text;
            musteri.Sepet = Convert.ToInt32(sepetTxt.Text);
            mdal.Ekle(yenikisi);
            MessageBox.Show("Kayıt Eklenmiştir"," ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            ekle();
        }
        public void guncelle()
        {
            Musteri eskiMusteri = new Musteri();
           eskiMusteri = (Musteri)bunifuDataGridView1.CurrentRow.DataBoundItem;
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.Ad = adTxt.Text;
            yeniMusteri.Soyad = soyadTxt.Text;
            yeniMusteri.KullaniciAdi= kadiTxt.Text;
            yeniMusteri.Sifre = sifretxt.Text;
            yeniMusteri.Adres = adresTxt.Text;
            yeniMusteri.Eposta = epostaTxt.Text;
            yeniMusteri.TelefonNo = telefonnoTxt.Text;
            yeniMusteri.KartNo = kartnoTxt.Text;
            yeniMusteri.CVC = kartcvcTxt.Text;
            mdal.Guncelle(eskiMusteri, yeniMusteri);
            MessageBox.Show("Kayıt Güncellenmiştir !", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void idTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(idTxt,e);
        }

        private void adTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadeceharf(adTxt ,e);
        }

        private void soyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadeceharf(soyadTxt, e);
        }

        private void telefonnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(telefonnoTxt, e);
        }

        private void kartnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(kartnoTxt, e);
        }

        private void kartcvcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(kartcvcTxt, e);
        }

        private void sepetTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(sepetTxt, e);
        }
    }
}
