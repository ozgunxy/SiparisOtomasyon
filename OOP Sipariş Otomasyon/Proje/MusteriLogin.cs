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
    public partial class MusteriLogin : Form
    {
        public MusteriLogin()
        {
            
            InitializeComponent();
        }

        
        Musteri musteri = new Musteri();    
        AdminLogin al = new AdminLogin();       
       


        public void kontrol()
        {
             SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");

            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from Musteri where mkadi ='" + kadiTxt.Text.ToString() + "'and msifre ='" + ksifreTxt.Text.ToString() + "'", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {

                MusteriMainMenu mmm = new MusteriMainMenu();
                mmm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connection.Close();

        }

        
        private void listeleBtn_Click(object sender, EventArgs e)
        {        
            Musteri.userName = kadiTxt.Text;
            kontrol();  
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                al.Show();
                this.Hide();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MusteriKayit mk = new MusteriKayit();
            mk.Show();
            this.Hide();
        }
    }
}
