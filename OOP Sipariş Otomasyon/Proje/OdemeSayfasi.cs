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
    public partial class OdemeSayfasi : Form
    {
        public OdemeSayfasi()
        {
            InitializeComponent();
        }
        Siparis siparis = new Siparis();
        Musteri musteri = new Musteri();
        Sepet sepet = new Sepet();
        SiparisDal sdal = new SiparisDal();
        SepetDal sepetdal = new SepetDal();
        MusteriSiparisPaneli msp = new MusteriSiparisPaneli();
        SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void OdemeSayfasi_Load(object sender, EventArgs e)
        {
            double kdv=0.18,toplam,kdvlitoplam;
            kdvsizsumLbl.Text = Sepet.toplamFiyat.ToString();

            toplam = (kdv * Convert.ToInt32(Sepet.toplamFiyat));
            kdvlitoplam = toplam + Convert.ToInt32(kdvsizsumLbl.Text);
                label13.Text = Sepet.toplamAgirlik.ToString();
            label16.Text = Siparis.datagridsatir.ToString();
            kdvlisumLbl.Text = kdvlitoplam.ToString();

        }
        public void CheckCard()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from Musteri where mkartno ='" + kartnoTxt.Text.ToString() + "'and mcvc='" + kartcvcTxt.Text.ToString()+ "' and mad='"+kartisimTxt.Text+"' and mkadi='"+Musteri.userName+"'", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (bunifuCheckBox1.Checked == true)
                {
                siparisekle();
                    sepetitemizle();
                msp.Show();
                this.Hide();
                }
                else
                {
                    MessageBox.Show("Sözleşmeyi Kabul Etmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                MessageBox.Show("Hatalı Kart Bilgisi !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connection.Close();

        }


        public void siparisekle()
        {

            if (bunifuCheckBox1.Checked == true) { 
            Siparis.sagirlik = Convert.ToDouble(Sepet.toplamAgirlik);
            Siparis.stoplamfiyat = Convert.ToDouble(Sepet.toplamFiyat);
            Siparis.skisisi = Musteri.userName;
            Siparis.sdurumu = "Kargoya verildi";
            Siparis.sverilenurun = Siparis.datagridsatir;
            sdal.SiparisEkle(siparis);
            MessageBox.Show("Siparişiniz İşleme Alınmıştır"," ",MessageBoxButtons.OK,MessageBoxIcon.Information);}
           
            
        }
        public void sepetitemizle()
        {
            sepetdal.Sil(sepetdal);
        }
        private void listeleBtn_Click(object sender, EventArgs e)
        {
            CheckCard();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
