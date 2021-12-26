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
using System.Data;

namespace Proje
{
    public partial class AdminUrunler : Form
    {
        public AdminUrunler()
        {
            InitializeComponent();
        }
        UrunDal udal = new UrunDal();

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            AdminMainMenu amm = new AdminMainMenu();
            amm.Show();
            this.Hide();
        }

        private void cikBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Listele()
        {

            bunifuDataGridView1.DataSource = udal.Listele();
        }
        private void listeleBtn_Click(object sender, EventArgs e)
        {
            Listele();
        }
        public void sil()
        {
            Urun urun = new Urun();
            urun = (Urun)bunifuDataGridView1.CurrentRow.DataBoundItem;
            udal.Sil(urun);
            MessageBox.Show("Seçtiğiniz kayıt silinmiştir", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            sil();
        }
        public void guncelle()
        {
            Urun eskiurun = new Urun();
             eskiurun = (Urun)bunifuDataGridView1.CurrentRow.DataBoundItem;
            Urun yeniUrun = new Urun();
            yeniUrun.Ad = adTxt.Text;
            yeniUrun.Tur = turTxt.Text;
            yeniUrun.Renk = renkTxt.Text;
            yeniUrun.Fiyat = Convert.ToInt32(fiyatTxt.Text);
            yeniUrun.Agirlik = Convert.ToInt32(agirlikTxt.Text);
            udal.Guncelle(eskiurun,yeniUrun);
            MessageBox.Show("Kayıt Güncellenmiştir !", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }


        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            guncelle();
        }
        public void clear()
        {
            idTxt.Text = "";
            adTxt.Text = "";
            turTxt.Text = "";
            renkTxt.Text = "";
            fiyatTxt.Text = "";
            agirlikTxt.Text = "";
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void verileritxtyeaktar()
        {
            idTxt.Text = bunifuDataGridView1.CurrentRow.Cells[0].Value.ToString();
            adTxt.Text = bunifuDataGridView1.CurrentRow.Cells[1].Value.ToString();
            turTxt.Text = bunifuDataGridView1.CurrentRow.Cells[2].Value.ToString();
            renkTxt.Text = bunifuDataGridView1.CurrentRow.Cells[3].Value.ToString();
            fiyatTxt.Text = bunifuDataGridView1.CurrentRow.Cells[4].Value.ToString();
            agirlikTxt.Text = bunifuDataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           verileritxtyeaktar();
        }

        private void güncelleBtn_Click_1(object sender, EventArgs e)
        {
            guncelle();
        }

        private void idTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(idTxt, e);
        }

        private void adTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadeceharf(adTxt, e);
        }

        private void soyadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadeceharf(adTxt, e);
        }

        private void telefonnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            textboxKontrol.sadecesayi(idTxt, e);
        }

        private void silBtn_Click_1(object sender, EventArgs e)
        {
            sil();
        }
       

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            clear();
        }
        public void ekle()
        {
            Urun urun = new Urun();
            
            urun.Ad = adTxt.Text;
            urun.Tur = turTxt.Text;
            urun.Renk = renkTxt.Text;
            urun.Fiyat = Convert.ToDouble(fiyatTxt.Text);
            urun.Agirlik = Convert.ToDouble(agirlikTxt.Text);
            udal.Ekle(urun);
            MessageBox.Show("Kayıt Eklenmiştir", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            ekle();
        }
    }
}
