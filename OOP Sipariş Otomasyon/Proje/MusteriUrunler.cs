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
    public partial class MusteriUrunler : Form
    {
        public MusteriUrunler()
        {
            InitializeComponent();
        }
       
        
        int sayac = 0;
        
        public string KullaniciAdi;
        public void Listele()
        {
            UrunDal udal = new UrunDal();
            bunifuDataGridView1.DataSource = udal.Listele();
        }
        public void SepeteEkle()
        {
            SepetDal sdal = new SepetDal();
            Sepet sepet = new Sepet();
            kadiLbl.Text = Musteri.userName;
            sepet.urunId= Convert.ToInt32(uidLbl.Text);
           sdal.SepeteEkle(sepet);
            
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

        private void MusteriUrunler_Load(object sender, EventArgs e)
        {   
            Listele();
            
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labeleaktar();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
           panel1.Visible = true;
            timer1.Start();
            SepeteEkle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac >= 3)
            {
                panel1.Visible = false;
                sayac = 0;
                timer1.Stop();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MusteriMainMenu mmm = new MusteriMainMenu();
            mmm.Show();
            this.Hide();
                }
    }
}
