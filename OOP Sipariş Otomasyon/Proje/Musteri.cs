using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje
{
    class Musteri
    {
        public static string userName {get; set;}

        int mid;
        public int Id
        {
            get { return mid; }
            set { mid = value; }
        }


        string mad;
        public string Ad
        {
            get { return mad; }
            set { mad = value; }
        }


        string msoyad;
        public string Soyad
        {
            get { return msoyad; }
            set { msoyad = value; }
        }


        string mkadi;
        public string KullaniciAdi
        {
            get { return mkadi; }
            set { mkadi = value; }
        }

        string msifre;
        public string Sifre
        {
            get { return msifre; }
            set { msifre = value; }
        }

        string madres;
        public string Adres
        {
            get { return madres; }
            set { madres = value; }
        }
        string meposta;
        public string Eposta
        {
            get { return meposta; }
            set { meposta = value; }
        }
        string mtelno;
        public string TelefonNo
        {
            get { return mtelno ; }
            set { mtelno = value; }
        }

        string mkartno;
        public string KartNo
        {
            get { return mkartno; }
            set { mkartno = value; }
        }
        string mcvc;
        public string CVC
        {
            get { return mcvc; }
            set { mcvc = value; }
        }

        int msepet;
        public int Sepet
        {
            get { return msepet; }
            set { msepet = value; }
        }

    }
}
