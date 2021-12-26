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
    public partial class MusteriSiparisPaneli : Form
    {
        public MusteriSiparisPaneli()
        {
            InitializeComponent();
        }

        SiparisDal sdal = new SiparisDal();
        SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
        SqlDataAdapter da;

        private void cikBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            MusteriMainMenu mmm = new MusteriMainMenu();
            mmm.Show();
            this.Hide();
            
        }
        public void SiparisListele()
        {

           
            da = new SqlDataAdapter("Select * From Siparis where skisisi='"+Musteri.userName+"'",connection);
            DataSet ds = new DataSet();
            connection.Open();
            da.Fill(ds, "Siparis");
            bunifuDataGridView1.DataSource = ds.Tables["Siparis"];
            connection.Close();
        }

        private void MusteriSiparisPaneli_Load(object sender, EventArgs e)
        {

            SiparisListele();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            SiparisListele();
        }
    }
}
