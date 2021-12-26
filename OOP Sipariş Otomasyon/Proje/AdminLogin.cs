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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        
        
        SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        public void AdminGirisKontrol()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from Admin where adminID ='" + adminidTxt.Text+ "'and adminPW ='" + adminpwTxt.Text + "'", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();


            if (dr.Read())
            {
                AdminMainMenu amm = new AdminMainMenu();
                amm.Show();
                this.Hide();
            }
            else
            MessageBox.Show("Hatalı Kullanıcı Adı veya Parola !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connection.Close();
        }
        private void listeleBtn_Click(object sender, EventArgs e)
        {
            AdminGirisKontrol();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MusteriLogin ml = new MusteriLogin();
            ml.Show();
            this.Hide();
        }
    }
}
