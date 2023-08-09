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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
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

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();
            kg.Show();
            this.Hide();
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
            
            pic1.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.WhiteSmoke;
            txtKullaniciAdi.ForeColor = Color.WhiteSmoke;

            txtSifre.Clear();
            picpass.BackgroundImage = Properties.Resources.padlockAsil2;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtSifre.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.baglanti.Open();
            SqlCommand cmd = db.baglanti.CreateCommand();
            cmd.CommandText = @"UPDATE [dbo].[kullaniciBilgileri]SET[kullaniciSifre] ='" + txtSifre.Text + "'WHERE kullaniciAdi='" + txtKullaniciAdi.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarılı.");
            KullaniciGiris f1 = new KullaniciGiris();
            f1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
