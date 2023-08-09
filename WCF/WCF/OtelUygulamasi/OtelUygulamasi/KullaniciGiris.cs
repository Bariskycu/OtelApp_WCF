using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelUygulamasi
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
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

        SifremiUnuttum frm2 = new SifremiUnuttum();

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            pic1.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtKullaniciAdi.ForeColor = Color.FromArgb(78, 184, 206);

            picpass.BackgroundImage = Properties.Resources.padlock2;
            panel2.BackColor = Color.WhiteSmoke;
            txtSifre.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
            txtSifre.PasswordChar = '●';
            picpass.BackgroundImage = Properties.Resources.padlockAsil2;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtKullaniciAdi.ForeColor = Color.FromArgb(78, 184, 206);

            pic1.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.WhiteSmoke;
            txtKullaniciAdi.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label3.Text = frm2.Left.ToString();
            frm2.Left += 10;
            if (frm2.Left >= 970)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //label3.Text = frm2.Left.ToString();
            frm2.Left -= 10;
            if (frm2.Left <= 795)
            {
                timer2.Stop();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciKayit kk = new KullaniciKayit();
            kk.Show();
            this.Hide();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainClass grs = new MainClass();
            MusteriKayit main = new MusteriKayit();
            if (txtKullaniciAdi.Text == string.Empty || txtSifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Kullanıcı Adını ve Şifreni gir.", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grs.girisYap(txtKullaniciAdi.Text, txtSifre.Text, DateTime.Now);
                string bilgiTut = txtKullaniciAdi.Text + " " + txtSifre.Text.ToString();
                if (grs.girisDurumu == bilgiTut)
                {
                    main.Show();
                    this.Hide();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
