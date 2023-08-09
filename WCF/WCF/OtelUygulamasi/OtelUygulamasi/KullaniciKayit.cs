using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelUygulamasi.ServiceReference1;

namespace OtelUygulamasi
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();
            kg.Show();
            this.Hide();
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAd_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            picAd.BackgroundImage = Properties.Resources.move_to_next;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtAd.ForeColor = Color.FromArgb(78, 184, 206);

            picSoyad.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picTelefon.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picEmail.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picKullanicAdi.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picSifre.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picGiris.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
            picAd.BackgroundImage = Properties.Resources.move_to_next_white;
            panel1.BackColor = Color.WhiteSmoke;
            txtAd.ForeColor = Color.WhiteSmoke;

            textBox2.Clear();
            picSoyad.BackgroundImage = Properties.Resources.move_to_next;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            picTelefon.BackgroundImage = Properties.Resources.move_to_next_white;
            panel3.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picEmail.BackgroundImage = Properties.Resources.move_to_next_white;
            panel4.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picKullanicAdi.BackgroundImage = Properties.Resources.move_to_next_white;
            panel5.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picSifre.BackgroundImage = Properties.Resources.move_to_next_white;
            panel6.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picGiris.BackgroundImage = Properties.Resources.move_to_next_white;
            panel7.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            picAd.BackgroundImage = Properties.Resources.move_to_next_white;
            panel1.BackColor = Color.WhiteSmoke;
            txtAd.ForeColor = Color.WhiteSmoke;

            
            picSoyad.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            textBox3.Clear();
            picTelefon.BackgroundImage = Properties.Resources.move_to_next;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            picEmail.BackgroundImage = Properties.Resources.move_to_next_white;
            panel4.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picKullanicAdi.BackgroundImage = Properties.Resources.move_to_next_white;
            panel5.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picSifre.BackgroundImage = Properties.Resources.move_to_next_white;
            panel6.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picGiris.BackgroundImage = Properties.Resources.move_to_next_white;
            panel7.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            picAd.BackgroundImage = Properties.Resources.move_to_next_white;
            panel1.BackColor = Color.WhiteSmoke;
            txtAd.ForeColor = Color.WhiteSmoke;


            picSoyad.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            
            picTelefon.BackgroundImage = Properties.Resources.move_to_next_white;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            textBox4.Clear();
            picEmail.BackgroundImage = Properties.Resources.move_to_next;
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            textBox4.ForeColor = Color.FromArgb(78, 184, 206);

            picKullanicAdi.BackgroundImage = Properties.Resources.move_to_next_white;
            panel5.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picSifre.BackgroundImage = Properties.Resources.move_to_next_white;
            panel6.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picGiris.BackgroundImage = Properties.Resources.move_to_next_white;
            panel7.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            picAd.BackgroundImage = Properties.Resources.move_to_next_white;
            panel1.BackColor = Color.WhiteSmoke;
            txtAd.ForeColor = Color.WhiteSmoke;


            picSoyad.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;


            picTelefon.BackgroundImage = Properties.Resources.move_to_next_white;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            
            picEmail.BackgroundImage = Properties.Resources.move_to_next_white;
            panel4.BackColor = Color.WhiteSmoke;
            textBox4.ForeColor = Color.WhiteSmoke;

            textBox5.Clear();
            picKullanicAdi.BackgroundImage = Properties.Resources.move_to_next;
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            textBox5.ForeColor = Color.FromArgb(78, 184, 206);

            picSifre.BackgroundImage = Properties.Resources.move_to_next_white;
            panel6.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            picGiris.BackgroundImage = Properties.Resources.move_to_next_white;
            panel7.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            picAd.BackgroundImage = Properties.Resources.move_to_next_white;
            panel1.BackColor = Color.WhiteSmoke;
            txtAd.ForeColor = Color.WhiteSmoke;


            picSoyad.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;


            picTelefon.BackgroundImage = Properties.Resources.move_to_next_white;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;


            picEmail.BackgroundImage = Properties.Resources.move_to_next_white;
            panel4.BackColor = Color.WhiteSmoke;
            textBox4.ForeColor = Color.WhiteSmoke;

            
            picKullanicAdi.BackgroundImage = Properties.Resources.move_to_next_white;
            panel5.BackColor = Color.WhiteSmoke;
            textBox5.ForeColor = Color.WhiteSmoke;


            textBox6.Clear();
            picSifre.BackgroundImage = Properties.Resources.move_to_next;
            panel6.BackColor = Color.FromArgb(78, 184, 206);
            textBox6.ForeColor = Color.FromArgb(78, 184, 206);

            picGiris.BackgroundImage = Properties.Resources.move_to_next_white;
            panel7.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            picAd.BackgroundImage = Properties.Resources.move_to_next_white;
            panel1.BackColor = Color.WhiteSmoke;
            txtAd.ForeColor = Color.WhiteSmoke;


            picSoyad.BackgroundImage = Properties.Resources.move_to_next_white;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;


            picTelefon.BackgroundImage = Properties.Resources.move_to_next_white;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;


            picEmail.BackgroundImage = Properties.Resources.move_to_next_white;
            panel4.BackColor = Color.WhiteSmoke;
            textBox4.ForeColor = Color.WhiteSmoke;


            picKullanicAdi.BackgroundImage = Properties.Resources.move_to_next_white;
            panel5.BackColor = Color.WhiteSmoke;
            textBox5.ForeColor = Color.WhiteSmoke;


            
            picSifre.BackgroundImage = Properties.Resources.move_to_next_white;
            panel6.BackColor = Color.WhiteSmoke;
            textBox6.ForeColor = Color.WhiteSmoke;

            dateTimePicker1.Text="";
            picGiris.BackgroundImage = Properties.Resources.move_to_next;
            panel7.BackColor = Color.FromArgb(78, 184, 206);
            dateTimePicker1.ForeColor = Color.FromArgb(78, 184, 206);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            KullaniciKayitEt k = new KullaniciKayitEt();
            k.Ad = txtAd.Text;
            k.soyad = textBox2.Text;
            k.telefon = textBox3.Text;
            k.Mail = textBox4.Text;
            k.KullaniciAdi = textBox5.Text;
            k.KullaniciSifre = textBox6.Text;
            k.GirisTarihi = Convert.ToDateTime(dateTimePicker1.Text);

            Service1Client service = new Service1Client();

            if (service.KullaniciKayit(k)==1)
            {
                MessageBox.Show("Kullanıcı Oluşturuldu");
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
