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
using System.Data.SqlClient;

namespace Proje
{
    public partial class MusteriSepetPaneli : Form
    {
        public MusteriSepetPaneli()
        {
            InitializeComponent();
        }
        Urun urun = new Urun();
        SepetDal sepetDal = new SepetDal();



        private void MusteriSepetPaneli_Load(object sender, EventArgs e)
        {
            
            bunifuDataGridView1.DataSource = sepetDal.Listele();
            toplamFiyat();
            toplamAgirlik();
            toplamsatirSayisi();

        }
        public void toplamFiyat()
        {
            int toplam = 0;
            for (int i = 0; i < bunifuDataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(bunifuDataGridView1.Rows[i].Cells[4].Value);
            }
            toplamLbl.Text = toplam.ToString();
            Sepet.toplamFiyat = toplamLbl.Text;
        }
        public void toplamAgirlik()
        {
            int toplamagirlik = 0;
            for (int i = 0; i < bunifuDataGridView1.Rows.Count; ++i)
            {
                toplamagirlik += Convert.ToInt32(bunifuDataGridView1.Rows[i].Cells[5].Value);
            }
            toplamAgirlikLbl.Text = toplamagirlik.ToString();
            Sepet.toplamAgirlik = toplamAgirlikLbl.Text.ToString();

        }
        public void toplamsatirSayisi()
        {
           

            for (int i = 0; i < bunifuDataGridView1.Rows.Count; i++)
            {

              Siparis.datagridsatir= (bunifuDataGridView1.RowCount);

            }

            toplamSatirlbl.Text = Siparis.datagridsatir.ToString();
           

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MusteriUrunler mu = new MusteriUrunler();
            mu.Show();
            this.Hide();
        }

        private void bunifuSeparator3_Click(object sender, EventArgs e)
        {

        }
        public void labeleaktar()
        {
            uidLbl.Text = bunifuDataGridView1.CurrentRow.Cells[0].Value.ToString();
            uadLbl.Text = bunifuDataGridView1.CurrentRow.Cells[1].Value.ToString();
            uturLbl.Text = bunifuDataGridView1.CurrentRow.Cells[2].Value.ToString();
            urenkLbl.Text = bunifuDataGridView1.CurrentRow.Cells[3].Value.ToString();
            urunfiyatLbl.Text = bunifuDataGridView1.CurrentRow.Cells[4].Value.ToString();
            urunagirlikLbl.Text = bunifuDataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labeleaktar();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {

            if (Sepet.toplamFiyat == "0") {
                MessageBox.Show("Ödeme Yapmadan Önce Sepetinize Ürün Eklemelisiniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            OdemeSayfasi os = new OdemeSayfasi();
           
            os.Show();
            this.Hide();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        public void sepetitemizle()
        {
            MusteriMainMenu musteriMainMenu = new MusteriMainMenu();
            sepetDal.Sil(sepetDal);
            MessageBox.Show("Sepetiniz Temizlendi");
            musteriMainMenu.Show();
            this.Hide();
          
        }
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            sepetitemizle();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MusteriUrunler mu = new MusteriUrunler();
            mu.Show();
            this.Hide();
        }
    }
}
