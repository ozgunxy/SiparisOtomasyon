using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje
{
    class SepetDal : Sepet
    {
        SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        public SepetDal()
        {
            ConnectSepet();
        }
        public void ConnectSepet()
        {
            komut.Connection = connection;
        }

        public void SepeteEkle(Sepet sepet)
        {
            try
            {
                komut.CommandText = "insert into Sepet (mkullaniciAdi,urunid) Values ('" + Musteri.userName + "'," + sepet.urunId + ")";
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

        public List<Urun> Listele()
        {

            try
            {
                List<Urun> UrunleriListele = new List<Urun>();
                komut.CommandText = "SELECT Urunler.* FROM Sepet INNER JOIN Urunler ON Sepet.urunid=Urunler.uid AND Sepet.mkullaniciAdi='" + Musteri.userName+ "'";
                komut.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Urun urun = new Urun();

                    urun.Id = Convert.ToInt32(reader[0].ToString());
                    urun.Ad = reader[1].ToString();
                    urun.Tur = reader[2].ToString();
                    urun.Renk = reader[3].ToString();
                    urun.Fiyat = Convert.ToInt32(reader[4].ToString());
                    urun.Agirlik = Convert.ToInt32(reader[5].ToString());

                    UrunleriListele.Add(urun);
                }

                return UrunleriListele;
            }
            catch
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
        public void Sil(Sepet sepet)
        {
            try
            {
                komut.CommandText = "Delete From Sepet Where mkullaniciAdi='" + Musteri.userName + "'";
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
