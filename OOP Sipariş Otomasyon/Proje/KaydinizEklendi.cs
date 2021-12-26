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
    public partial class KaydinizEklendi : Form
    {
        public KaydinizEklendi()
        {
            InitializeComponent();
        }

        private void KaydinizEklendi_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            MusteriLogin ml = new MusteriLogin();
            ml.Show();
            this.Hide();
        }
    }
}
