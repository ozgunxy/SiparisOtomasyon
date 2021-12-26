using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje
{
    class MusteriDal : Musteri
    {
         SqlConnection connection = new SqlConnection("Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True");
        private readonly SqlCommand komut = new SqlCommand();

        public MusteriDal()
        {
           ConnectMusteri();
        }

        public MusteriDal(SqlConnection connection)
        {
            ConnectMusteri();
        }

    
        public void ConnectMusteri()
        {
            
            komut.Connection = connection;
        }

        public List<Musteri> Listele()
        {

            try
            {
                List<Musteri> MusterileriListele = new List<Musteri>();
                komut.CommandText = "Select *From Musteri";
                komut.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Musteri musteri = new Musteri();

                    musteri.Id = Convert.ToInt32(reader[0].ToString());
                    musteri.Ad = reader[1].ToString();
                    musteri.Soyad = reader[2].ToString();
                    musteri.KullaniciAdi = reader[3].ToString();
                    musteri.Sifre = reader[4].ToString();
                    musteri.Adres = reader[5].ToString();
                    musteri.Eposta = reader[6].ToString();
                    musteri.TelefonNo = reader[7].ToString();
                    musteri.KartNo = reader[8].ToString();
                    musteri.CVC = reader[9].ToString();
                    musteri.Sepet = Convert.ToInt32(reader[10].ToString());


                    MusterileriListele.Add(musteri);
                }

                return MusterileriListele;
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
        public void Sil(Musteri musteri)
        {
            try
            {
                komut.CommandText = "Delete From Musteri Where mid=" + musteri.Id + "";
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
        public void Ekle(Musteri musteri)
        {
            try
            {
                komut.CommandText = "insert into Musteri (mad,msoyad,mkadi,msifre,madres,meposta,mtelno,mkartno,mcvc,msepet) Values ('" + musteri.Ad + "','" + musteri.Soyad + "','" + musteri.KullaniciAdi + "','" + musteri.Sifre + "','" + musteri.Adres + "','" + musteri.Eposta + "','" + musteri.TelefonNo.ToString() + "','" + musteri.KartNo.ToString() + "','" + musteri.CVC.ToString() + "'," + musteri.Sepet + ")";
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

        public void Guncelle(Musteri eskiMusteri, Musteri yeniMusteri)
        {
            try
            {
                komut.CommandText = "Update Musteri SET mad='" + yeniMusteri.Ad + "',msoyad='" + yeniMusteri.Soyad + "',mkadi='" + yeniMusteri.KullaniciAdi + "',msifre='" + yeniMusteri.Sifre + "',madres='" + yeniMusteri.Adres + "',meposta='" + yeniMusteri.Eposta + "',mtelno='" + yeniMusteri.TelefonNo + "',mkartno='" + yeniMusteri.KartNo.ToString() + "',mcvc='" + yeniMusteri.CVC.ToString() + "',msepet=" + yeniMusteri.Sepet + " Where mid=" + eskiMusteri.Id + "";
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
