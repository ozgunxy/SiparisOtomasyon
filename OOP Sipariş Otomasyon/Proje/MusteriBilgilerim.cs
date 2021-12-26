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
    public partial class MusteriBilgilerim : Form
    {
        public MusteriBilgilerim()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
        MusteriMainMenu mmm = new MusteriMainMenu();
        //MusteriDal musteriDal = new MusteriDal();
        private void listeleBtn_Click(object sender, EventArgs e)
        {
            mmm.Show();
            this.Hide();
        }
        public void bilgilericek()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from Musteri where mkadi='" + Musteri.userName + "'", connection);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
              lblkadi.Text= dr["mkadi"].ToString();
                adLbl.Text = dr["mad"].ToString();
                soyadLbl.Text = dr["msoyad"].ToString();
                adresLbl.Text = dr["madres"].ToString();
                adsoyadLbl.Text = adLbl.Text;
                epostaLbl.Text= dr["meposta"].ToString();
                kartnoLbl.Text = dr["mkartno"].ToString();
                telnoLbl.Text = dr["mtelno"].ToString();
                soyadkartLbl.Text = soyadLbl.Text;
            }
            connection.Close();
        }
        private void MusteriBilgilerim_Load(object sender, EventArgs e)
        {
            bilgilericek();

        }
    }
}
