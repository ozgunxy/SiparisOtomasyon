using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class Sepet
    {
        public static string toplamFiyat { get; set; }
        public static string toplamAgirlik{ get; set; }

        int urunid;
        public int urunId
        {
            get { return urunid; }
            set { urunid = value; }
        }


        string kullaniciadi;
        public string KullaniciAdi
        {
            get { return kullaniciadi; }
            set { kullaniciadi = value; }
        }
    }
}
