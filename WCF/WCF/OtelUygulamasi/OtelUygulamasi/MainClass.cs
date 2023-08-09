using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelUygulamasi
{
    class MainClass
    {
        public ArrayList kategoriler = new ArrayList();
        Database db = new Database();
        public string kisininAdi_soyadi { get; set; }
        public string guncelleDurum { get; set; }
        public string silDurum { get; set; }
        public string kullaniciAdi_tut { get; set; }
        public string kullaniciSifre_tut { get; set; }

        public string girisDurumu { get; set; }


        public void girisYap(string kullaniciAdi, string kullaniciSifre, DateTime tarih)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand loginName = new SqlCommand("select kullaniciAdi from kullaniciBilgileri where kullaniciAdi=@kulAdi", db.baglanti);
                loginName.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                SqlDataReader kulAdi_Oku = loginName.ExecuteReader();
                if (kulAdi_Oku.Read())
                {
                    kullaniciAdi_tut = kulAdi_Oku["kullaniciAdi"].ToString();
                    SqlCommand loginPw = new SqlCommand("select kullanicisifre from kullaniciBilgileri where kullaniciSifre = @sifre", db.baglanti);
                    loginPw.Parameters.AddWithValue("@sifre", kullaniciSifre);
                    SqlDataReader logimPw_Oku = loginPw.ExecuteReader();
                    if (logimPw_Oku.Read())
                    {
                        kullaniciSifre_tut = logimPw_Oku["kullaniciSifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + kullaniciSifre_tut;
                        SqlCommand dateUpdate = new SqlCommand("update kullaniciBilgileri set girisTarihi=@tarih where kullaniciAdi = @kuladi AND kullaniciSifre = @kulsifre", db.baglanti);
                        dateUpdate.Parameters.AddWithValue("@tarih", tarih);
                        dateUpdate.Parameters.AddWithValue("@kuladi", kullaniciAdi_tut);
                        dateUpdate.Parameters.AddWithValue("@kulsifre", kullaniciSifre_tut);
                        dateUpdate.ExecuteNonQuery();
                        dateUpdate.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Şifrenizi Kontrol Ediniz", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    loginPw.Dispose();
                    logimPw_Oku.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adını Yanlış Girdin", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loginName.Dispose();
                kulAdi_Oku.Close();
                db.baglanti.Close();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable tablolar()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand veriAl = new SqlCommand("Select * from musteriler", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public DataTable musteriAra(string adi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand arama = new SqlCommand("select * from musteriler where adi like '%'+@adi+'%'", db.baglanti);
                arama.Parameters.AddWithValue("@adi", adi);
                SqlDataAdapter adaptor = new SqlDataAdapter(arama);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;

            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public static void odaGuncelle(string oda, string kisiAdSoyad)
        {
            Database db = new Database();
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update odalar set odayiAlan=@alanKisi, durumu=@durum where odaAdi = @odaAdi", db.baglanti);
                guncelle.Parameters.AddWithValue("@alanKisi", kisiAdSoyad);
                guncelle.Parameters.AddWithValue("@durum", "Dolu");
                guncelle.Parameters.AddWithValue("@odaAdi", oda);
                guncelle.ExecuteNonQuery();
                guncelle.Dispose();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void kayitAl(string adi, string soyadi, string cinsiyet, string telefonNo, string mail, string tcNo, string odaAdi, string ucret, DateTime giris, DateTime cikis)
        {

            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kayit_Al = new SqlCommand("insert into musteriler values(@adi,@soyadi,@cinsiyet,@telefon,@mail,@tc,@oda,@ucret,@giris,@cikis)", db.baglanti);
                kayit_Al.Parameters.AddWithValue("@adi", adi);
                kayit_Al.Parameters.AddWithValue("@soyadi", soyadi);
                kayit_Al.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                kayit_Al.Parameters.AddWithValue("@telefon", telefonNo);
                kayit_Al.Parameters.AddWithValue("@mail", mail);
                kayit_Al.Parameters.AddWithValue("@tc", tcNo);
                kayit_Al.Parameters.AddWithValue("@oda", odaAdi);
                kayit_Al.Parameters.AddWithValue("@ucret", ucret);
                kayit_Al.Parameters.AddWithValue("@giris", giris);
                kayit_Al.Parameters.AddWithValue("@cikis", cikis);
                kayit_Al.ExecuteNonQuery();
                MessageBox.Show("Müşteri kayıdı başarılı bir şekilde oluşmuştur :  " + odaAdi + " İsimli oda : " + adi + "  " + soyadi + " isimli kişiye verilmiştir. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayit_Al.Dispose();

                kisininAdi_soyadi = adi + " " + soyadi;
                odaGuncelle(odaAdi, kisininAdi_soyadi);
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }

        }

        public DataTable mutfakUrunleri_Listele()
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand mutfakAl = new SqlCommand("select * from MutfakUrunleri", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(mutfakAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public void kategroAl()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();

                kategoriler.Clear();
                SqlCommand mutfakKategori = new SqlCommand("select * from MutfakKategoriler", db.baglanti);
                SqlDataReader oku = mutfakKategori.ExecuteReader();
                while (oku.Read())
                {
                    string kategori = oku["kategoriAdi"].ToString();
                    kategoriler.Add(kategori);

                }
                oku.Close();
                mutfakKategori.Dispose();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }

        }

        public DataTable veriGetirMutfak(string urunAdi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from MutfakUrunleri where urunAdi like '%'+@adi+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@adi", urunAdi);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public DataTable odaUrunleri_Listele()
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand odaAl = new SqlCommand("select * from OdaUrunleri", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(odaAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public void kategoriAl()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();

                kategoriler.Clear();
                SqlCommand mutfakKategori = new SqlCommand("select * from OdaKategorileri", db.baglanti);
                SqlDataReader oku = mutfakKategori.ExecuteReader();
                while (oku.Read())
                {
                    string kategori = oku["kategoriAdi"].ToString();
                    kategoriler.Add(kategori);

                }
                oku.Close();
                mutfakKategori.Dispose();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }

        }

        public DataTable veriGetirOda(string urunAdi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from OdaUrunleri where urunAdi like '%'+@adi+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@adi", urunAdi);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public DataTable Ptablolar()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand veriAl = new SqlCommand("Select * from Personeller", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }

        public DataTable personelAra(string adi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand arama = new SqlCommand("select * from Personeller where adi like '%'+@adi+'%'", db.baglanti);
                arama.Parameters.AddWithValue("@adi", adi);
                SqlDataAdapter adaptor = new SqlDataAdapter(arama);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;

            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
