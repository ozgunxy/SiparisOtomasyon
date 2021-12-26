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
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            AdminUrunler au = new AdminUrunler();
            au.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }
    }
}
