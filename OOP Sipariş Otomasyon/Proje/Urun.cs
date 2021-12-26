using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje
{
    class Urun
    {
        int uid;
        string uad;
        string utur;
        string urenk;
        double ufiyat;
        double maglirlik;
        

        public int Id
        {
            get { return uid; }
            set { uid = value; }
        }


        
        public string Ad
        {
            get { return uad; }
            set { uad = value; }
        }


        
        public string Tur
        {
            get { return utur; }
            set { utur= value; }
        }


        
        public string Renk
        {
            get { return urenk; }
            set {urenk = value; }
        }

      
        public double Fiyat
        {
            get { return ufiyat; }
            set { ufiyat = value; }
        }

        
        public double Agirlik
        {
            get { return maglirlik; }
            set { maglirlik = value; }
        }
       
    }
}
