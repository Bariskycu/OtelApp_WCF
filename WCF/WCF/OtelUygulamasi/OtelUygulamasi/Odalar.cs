using System;
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
    public partial class Odalar : Form
    {
        public Odalar()
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

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriKayit m = new MusteriKayit();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Odalar o = new Odalar();
            o.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriB u = new MusteriB();
            u.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
            SosyalAglar a = new SosyalAglar();
            a.Show();
            this.Hide();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            tmrKontrol.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    string alaKisi = donustur_Oku["odayiAlan"].ToString();
                    if (butonAdi == "oda1" && durumu == "Dolu")
                    {
                        btnOda1.BackColor = Color.Red;
                        btnOda1.Text = alaKisi;
                    }
                    if (butonAdi == "oda2" && durumu == "Dolu")
                    {
                        btnOda2.BackColor = Color.Red;
                        btnOda2.Text = alaKisi;
                    }
                    if (butonAdi == "oda3" && durumu == "Dolu")
                    {
                        btnOda3.BackColor = Color.Red;
                        btnOda3.Text = alaKisi;
                    }
                    if (butonAdi == "oda4" && durumu == "Dolu")
                    {
                        btnOda4.BackColor = Color.Red;
                        btnOda4.Text = alaKisi;
                    }
                    if (butonAdi == "oda5" && durumu == "Dolu")
                    {
                        btnOda5.BackColor = Color.Red;
                        btnOda5.Text = alaKisi;
                    }
                    if (butonAdi == "oda6" && durumu == "Dolu")
                    {
                        btnOda6.BackColor = Color.Red;
                        btnOda6.Text = alaKisi;
                    }
                    if (butonAdi == "oda7" && durumu == "Dolu")
                    {
                        btnOda7.BackColor = Color.Red;
                        btnOda7.Text = alaKisi;
                    }
                    if (butonAdi == "oda8" && durumu == "Dolu")
                    {
                        btnOda8.BackColor = Color.Red;
                        btnOda8.Text = alaKisi;
                    }
                    if (butonAdi == "oda9" && durumu == "Dolu")
                    {
                        btnOda9.BackColor = Color.Red;
                        btnOda9.Text = alaKisi;
                    }
                    if (butonAdi == "oda10" && durumu == "Dolu")
                    {
                        btnOda10.BackColor = Color.Red;
                        btnOda10.Text = alaKisi;
                    }
                    if (butonAdi == "oda11" && durumu == "Dolu")
                    {
                        btnOda11.BackColor = Color.Red;
                        btnOda11.Text = alaKisi;
                    }
                    if (butonAdi == "oda12" && durumu == "Dolu")
                    {
                        btnOda12.BackColor = Color.Red;
                        btnOda12.Text = alaKisi;
                    }
                    if (butonAdi == "oda13" && durumu == "Dolu")
                    {
                        btnOda13.BackColor = Color.Red;
                        btnOda13.Text = alaKisi;
                    }
                    if (butonAdi == "oda14" && durumu == "Dolu")
                    {
                        btnOda14.BackColor = Color.Red;
                        btnOda14.Text = alaKisi;
                    }
                    if (butonAdi == "oda15" && durumu == "Dolu")
                    {
                        btnOda15.BackColor = Color.Red;
                        btnOda15.Text = alaKisi;
                    }
                    if (butonAdi == "oda16" && durumu == "Dolu")
                    {
                        btnoda16.BackColor = Color.Red;
                        btnoda16.Text = alaKisi;
                    }
                    if (butonAdi == "oda17" && durumu == "Dolu")
                    {
                        btnOda17.BackColor = Color.Red;
                        btnOda17.Text = alaKisi;
                    }
                    if (butonAdi == "oda18" && durumu == "Dolu")
                    {
                        btnOda18.BackColor = Color.Red;
                        btnOda18.Text = alaKisi;
                    }
                    if (butonAdi == "oda19" && durumu == "Dolu")
                    {
                        btnOda19.BackColor = Color.Red;
                        btnOda19.Text = alaKisi;
                    }
                    if (butonAdi == "oda20" && durumu == "Dolu")
                    {
                        btnOda20.BackColor = Color.Red;
                        btnOda20.Text = alaKisi;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
