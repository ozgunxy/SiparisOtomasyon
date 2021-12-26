using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje

{
    class SiparisDal : Siparis
    {
        SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
         SqlCommand komut = new SqlCommand();
        public SiparisDal()
        {
            ConnectSiparis();
            
        }

        public void ConnectSiparis()
        {
            komut.Connection = connection;
        }
        public void SiparisEkle(Siparis siparis)
        {
            try
            {
                komut.CommandText = "insert into Siparis (sagirlik,stoplamfiyat,skisisi,sdurumu,sverilenurun) Values (" +Siparis.sagirlik+","+Sepet.toplamFiyat+",'"+Musteri.userName+"','"+Siparis.sdurumu+"',"+Siparis.datagridsatir +")";
                komut.CommandType = CommandType.Text;
                connection.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

 
        



    }
}
