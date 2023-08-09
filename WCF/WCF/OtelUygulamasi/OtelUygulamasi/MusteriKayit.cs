using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelUygulamasi
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        ArrayList odalar = new ArrayList();
        void koltukYazdir()
        {
            string oda = "";
            for (int i = 0; i < odalar.Count; i++)
            {
                oda += odalar[i].ToString() + ",";
            }
            if (odalar.Count >= 1)
            {
                oda = oda.Remove(oda.Length - 1, 1);
            }
            txtSeciliOda.Text = oda;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar o = new Odalar();
            o.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriKayit m = new MusteriKayit();
            m.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriB m = new MusteriB();
            m.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mutfak m = new Mutfak();
            m.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PersonalB p = new PersonalB();
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SosyalAglar s = new SosyalAglar();
            s.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            tmrKontrol.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public DateTime girisTarihi { get; set; }
        public DateTime cikisTarihi { get; set; }
        private void btnOdaVer_Click(object sender, EventArgs e)
        {
            girisTarihi = Convert.ToDateTime(dtGiris.Value);
            cikisTarihi = Convert.ToDateTime(dtCikis.Value);
            MainClass kayit = new MainClass();
            for (int i = 0; i < odalar.Count; i++)
            {
                string oda = odalar[i].ToString();
                kayit.kayitAl(txtAd.Text, txtSoyad.Text, cmbcinsiyet.Text, txtTelefon.Text, txtEmail.Text, txtTcKimlik.Text, oda, txtUcret.Text, girisTarihi, cikisTarihi);

            }
            tmrKontrol.Start();
        }

        private void odaTikla(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Green)
            {
                ((Button)sender).BackColor = Color.Orange;
                if (!odalar.Contains(((Button)sender).Text))
                {
                    odalar.Add(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else if (((Button)sender).BackColor == Color.Orange)
            {
                ((Button)sender).BackColor = Color.Green;
                if (odalar.Contains(((Button)sender).Text))
                {
                    odalar.Remove(((Button)sender).Text);
                }
                koltukYazdir();
            }
        }

        private void tmrKontrol_Tick(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand donustur = new SqlCommand("select * from odalar where durumu=@durum", db.baglanti);
                donustur.Parameters.AddWithValue("@durum", "Dolu");
                SqlDataReader donustur_Oku = donustur.ExecuteReader();
                while (donustur_Oku.Read())
                {
                    string butonAdi = donustur_Oku["butonAdi"].ToString();
                    string durumu = donustur_Oku["durumu"].ToString();
                    string alanKisi = donustur_Oku["odayiAlan"].ToString();
                    if (butonAdi == "oda1" && durumu == "Dolu")
                    {
                        btnOda1.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda2" && durumu == "Dolu")
                    {
                        btnOda2.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda3" && durumu == "Dolu")
                    {
                        btnOda3.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda4" && durumu == "Dolu")
                    {
                        btnOda4.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda5" && durumu == "Dolu")
                    {
                        btnOda5.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda6" && durumu == "Dolu")
                    {
                        btnOda6.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda7" && durumu == "Dolu")
                    {
                        btnOda7.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda8" && durumu == "Dolu")
                    {
                        btnOda8.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda9" && durumu == "Dolu")
                    {
                        btnOda9.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda10" && durumu == "Dolu")
                    {
                        btnOda10.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda11" && durumu == "Dolu")
                    {
                        btnOda11.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda12" && durumu == "Dolu")
                    {
                        btnOda12.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda13" && durumu == "Dolu")
                    {
                        btnOda13.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda14" && durumu == "Dolu")
                    {
                        btnOda14.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda15" && durumu == "Dolu")
                    {
                        btnOda15.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda16" && durumu == "Dolu")
                    {
                        btnOda16.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda17" && durumu == "Dolu")
                    {
                        btnOda17.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda18" && durumu == "Dolu")
                    {
                        btnOda18.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda19" && durumu == "Dolu")
                    {
                        btnOda19.BackColor = Color.Red;
                    }
                    if (butonAdi == "oda20" && durumu == "Dolu")
                    {
                        btnOda20.BackColor = Color.Red;
                    }

                }
                donustur.Dispose();
                donustur_Oku.Close();
                db.baglanti.Close();
                tmrKontrol.Stop();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
    
}
