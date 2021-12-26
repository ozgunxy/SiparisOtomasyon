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
    public partial class AcilisEkrani : Form
    {
        List<Color> colors = new List<Color>();
        int currentcolor = 0;
        int a = 0;
        MusteriLogin musteriLogin = new MusteriLogin();

        public AcilisEkrani()
        {
            InitializeComponent();
            colors.Add(Color.FromArgb(3, 169, 244));
            colors.Add(Color.FromArgb(33, 150, 243));
            colors.Add(Color.FromArgb(0, 150, 136));
            colors.Add(Color.FromArgb(103, 58, 183));
            colors.Add(Color.FromArgb(156, 39, 176));
            colors.Add(Color.FromArgb(255, 87, 34));
            colors.Add(Color.FromArgb(225, 193, 7));
            colors.Add(Color.FromArgb(205, 220, 57));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(currentcolor < colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colors[currentcolor], colors[currentcolor + 1]);
                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentcolor++;
                }
                timer1.Enabled = true;
            }
        }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
               
                musteriLogin.Show();
                this.Hide();
                 timer2.Stop();
            timer2.Enabled = false;
            
        }
    }
}
