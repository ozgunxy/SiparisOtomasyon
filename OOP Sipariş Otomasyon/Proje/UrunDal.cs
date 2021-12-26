using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje
{
   
    class UrunDal : Urun
    {
         SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
         SqlCommand komut = new SqlCommand();
        public UrunDal()
        {
            ConnectUrun();
        }

        public void ConnectUrun()
        {
            komut.Connection = connection;
        }

        public List<Urun> Listele()
        {

            try
            {
                List<Urun> UrunleriListele = new List<Urun>();
                komut.CommandText = "Select * From Urunler";
                komut.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Urun urun = new Urun();

                    urun.Id = Convert.ToInt32(reader[0].ToString());
                    urun.Ad = reader[1].ToString();
                    urun.Tur= reader[2].ToString();
                    urun.Renk = reader[3].ToString();
                    urun.Fiyat =Convert.ToInt32(reader[4].ToString());
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
        public void Sil(Urun urun)
        {
            try
            {
                komut.CommandText = "Delete From Urunler Where uid=" + urun.Id + "";
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
        public void Guncelle(Urun eskiUrun, Urun yeniUrun)
        {
            try
            {
                
                komut.CommandText = "Update Urunler SET uad='" + yeniUrun.Ad + "',utur='" + yeniUrun.Tur + "',urenk='" + yeniUrun.Renk + "',ufiyat=" + yeniUrun.Fiyat + ",uagirlik=" + yeniUrun.Agirlik + " Where uid=" + eskiUrun.Id + "";
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
        public void Ekle(Urun urun)
        {
            try
            {
               
                komut.CommandText = "insert into Urunler (uad,utur,urenk,ufiyat,uagirlik) Values ('" + urun.Ad + "','" + urun.Tur + "','" + urun.Renk + "'," + urun.Fiyat + "," + urun.Agirlik + ")";             
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
