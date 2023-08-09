using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{

    public class Service1 : IService1
    {

        public Service1()
        {
            ConnectToDb();
        }


        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "CASPER_NIRVANA\\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "OtelAutomation";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }


        public int UpdateMusteriB(MusteriBilgileri b)
        {
            try
            {
                comm.CommandText = "UPDATE musteriler SET adi=@adi, soyadi=@soyadi, cinsyet=@cinsyet, telefon=@telefon, mail=@mail, tcNo=@tcNo, odaNo=@odaNo, ucret=@ucret, girisTarihi=@girisTarihi, cikisTarihi=@cikisTarihi WHERE musterilerId=@musterilerId";
                comm.Parameters.AddWithValue("musterilerId", b.MusteriId);
                comm.Parameters.AddWithValue("adi", b.Adi);
                comm.Parameters.AddWithValue("soyadi", b.Soyadi);
                comm.Parameters.AddWithValue("cinsyet", b.Cinsiyet);
                comm.Parameters.AddWithValue("telefon", b.Telefon);
                comm.Parameters.AddWithValue("mail", b.Mail);
                comm.Parameters.AddWithValue("tcNo", b.TcNo);
                comm.Parameters.AddWithValue("odaNo", b.OdaNo);
                comm.Parameters.AddWithValue("ucret", b.Ucret);
                comm.Parameters.AddWithValue("girisTarihi", b.GirisTarihi);
                comm.Parameters.AddWithValue("cikisTarihi", b.CikisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }

        
        
        
        public int DeleteMusteriB(MusteriBilgileri b)
        {
            try
            {
                comm.CommandText = "delete musteriler where musterilerId = @musterilerId";
                comm.Parameters.AddWithValue("musterilerId",b.MusteriId);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        
      
        public int KullaniciKayit(KullaniciKayitEt k)
        {
            try
            {
                comm.CommandText = "INSERT INTO kullaniciBilgileri VALUES(@Adi,@Soyadi,@Telefon,@Mail,@KullaniciAdi,@Sifre,@Giris)";
                comm.Parameters.AddWithValue("@Adi", k.Ad);
                comm.Parameters.AddWithValue("@Soyadi", k.soyad);
                comm.Parameters.AddWithValue("@Telefon", k.telefon);
                comm.Parameters.AddWithValue("@Mail", k.Mail);
                comm.Parameters.AddWithValue("@KullaniciAdi", k.KullaniciAdi);
                comm.Parameters.AddWithValue("@Sifre", k.KullaniciSifre);
                comm.Parameters.AddWithValue("@Giris", k.GirisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
                
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        
        public int Personelekle(PersonelBilgileri p)
        {
            try
            {
                comm.CommandText = "insert into Personeller values(@Adi, @Soyadi, @Bolum, @Cinsiyet, @Telefon, @Mail, @TcNo, @Maas, @Giris, @Cikis)";
                comm.Parameters.AddWithValue("@Adi", p.Ad);
                comm.Parameters.AddWithValue("@Soyadi", p.Soyad);
                comm.Parameters.AddWithValue("@Bolum", p.Bolum);
                comm.Parameters.AddWithValue("@Cinsiyet", p.Cinsiyet);
                comm.Parameters.AddWithValue("@Telefon", p.Telefon);
                comm.Parameters.AddWithValue("@Mail", p.Mail);
                comm.Parameters.AddWithValue("@TcNo", p.TcNo);
                comm.Parameters.AddWithValue("@Maas", p.Maas);
                comm.Parameters.AddWithValue("@Giris", p.GirisTarihi);
                comm.Parameters.AddWithValue("@Cikis", p.CikisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int DeletePersonelB(PersonelBilgileri p)
        {
            try
            {
                comm.CommandText = "delete Personeller where PersonellerId=@PersonellerId";
                comm.Parameters.AddWithValue("PersonellerId", p.PersonelId);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int UpdatePersonelB(PersonelBilgileri p)
        {
            try
            {
                comm.CommandText = "UPDATE Personeller SET Adi=@Adi, Soyadi=@Soyadi, Bolum=@Bolum, Cinsyet=@Cinsyet, Telefon=Telefon, Mail=@Mail, TcNo=@TcNo, Maas=@Maas, GirisTarihi=@GirisTarihi, CikisTarihi=@CikisTarihi WHERE PersonellerId=@PersonellerId";
                comm.Parameters.AddWithValue("PersonellerId", p.PersonelId);
                comm.Parameters.AddWithValue("Adi", p.Ad);
                comm.Parameters.AddWithValue("Soyadi", p.Soyad);
                comm.Parameters.AddWithValue("Bolum", p.Bolum);
                comm.Parameters.AddWithValue("Cinsyet", p.Cinsiyet);
                comm.Parameters.AddWithValue("Telefon", p.Telefon);
                comm.Parameters.AddWithValue("Mail", p.Mail);
                comm.Parameters.AddWithValue("TcNo", p.TcNo);
                comm.Parameters.AddWithValue("Maas", p.Maas);
                comm.Parameters.AddWithValue("GirisTarihi", p.GirisTarihi);
                comm.Parameters.AddWithValue("CikisTarihi", p.CikisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int MutfakUekle(MutfakU m)
        {
            try
            {
                comm.CommandText = "INSERT INTO MutfakUrunleri VALUES(@UrunAdi,@Kategori,@Adet,@Fiyat,@Firma,@GelisTarihi)";
                comm.Parameters.AddWithValue("@UrunAdi", m.UrunAdi);
                comm.Parameters.AddWithValue("@Kategori", m.Kategori);
                comm.Parameters.AddWithValue("@Adet", m.Adet);
                comm.Parameters.AddWithValue("@Fiyat", m.Fiyat);
                comm.Parameters.AddWithValue("@Firma", m.Firma);
                comm.Parameters.AddWithValue("@GelisTarihi", m.GelisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int UpdateMutfakU(MutfakU m)
        {
            try
            {
                comm.CommandText = "UPDATE MutfakUrunleri SET urunAdi=@urunAdi, kategori=@kategori, adet=@adet, fiyat=@fiyat, firma=@firma, gelisTarihi=@gelisTarihi WHERE MutfakUrunleriId=@MutfakUrunleriId";
                comm.Parameters.AddWithValue("MutfakUrunleriId", m.MutfakUId);
                comm.Parameters.AddWithValue("urunAdi", m.UrunAdi);
                comm.Parameters.AddWithValue("kategori", m.Kategori);
                comm.Parameters.AddWithValue("adet", m.Adet);
                comm.Parameters.AddWithValue("fiyat", m.Fiyat);
                comm.Parameters.AddWithValue("firma", m.Firma);
                comm.Parameters.AddWithValue("gelisTarihi", m.GelisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int DeleteMutfakU(MutfakU m)
        {
            try
            {
                comm.CommandText = "delete MutfakUrunleri where MutfakUrunleriId=@MutfakUrunleriId";
                comm.Parameters.AddWithValue("MutfakUrunleriId", m.MutfakUId);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int OdaUekle(OdaU o)
        {
            try
            {
                comm.CommandText = "INSERT INTO OdaUrunleri VALUES(@UrunAdi,@Kategori,@Adet,@Fiyat,@Firma,@GelisTarihi)";
                comm.Parameters.AddWithValue("@UrunAdi", o.UrunAdi);
                comm.Parameters.AddWithValue("@Kategori", o.Kategori);
                comm.Parameters.AddWithValue("@Adet", o.Adet);
                comm.Parameters.AddWithValue("@Fiyat", o.Fiyat);
                comm.Parameters.AddWithValue("@Firma", o.Firma);
                comm.Parameters.AddWithValue("@GelisTarihi", o.GelisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int UpdateOdaU(OdaU o)
        {
            try
            {
                comm.CommandText = "UPDATE OdaUrunleri SET urunAdi=@urunAdi, kategori=@kategori, adet=@adet, fiyat=@fiyat, firma=@firma, gelisTarihi=@gelisTarihi WHERE OdaUrunleriId=@OdaUrunleriId";
                comm.Parameters.AddWithValue("OdaUrunleriId", o.OdaUId);
                comm.Parameters.AddWithValue("urunAdi", o.UrunAdi);
                comm.Parameters.AddWithValue("kategori", o.Kategori);
                comm.Parameters.AddWithValue("adet", o.Adet);
                comm.Parameters.AddWithValue("fiyat", o.Fiyat);
                comm.Parameters.AddWithValue("firma", o.Firma);
                comm.Parameters.AddWithValue("gelisTarihi", o.GelisTarihi);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int DeleteOdaU(OdaU o)
        {
            try
            {
                comm.CommandText = "delete OdaUrunleri where OdaUrunleriId=@OdaUrunleriId";
                comm.Parameters.AddWithValue("OdaUrunleriId", o.OdaUId);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
