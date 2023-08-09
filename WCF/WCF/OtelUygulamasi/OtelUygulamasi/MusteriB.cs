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
    public partial class MusteriB : Form
    {
        public MusteriB()
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void MusteriB_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

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
            
            MusteriB b = new MusteriB();
            b.Show();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dtGiris.Value);
            DateTime cikisTarihi = Convert.ToDateTime(dtCikis.Value);
            MusteriBilgileri b = new MusteriBilgileri()
            {
                MusteriId = Convert.ToInt32(lblID.Text),
                Adi = txtAd.Text,
                Soyadi = txtSoyad.Text,
                Cinsiyet = cmbcinsiyet.Text,
                Telefon = txtTelefon.Text,
                Mail = txtEmail.Text,
                TcNo = txtTcNo.Text,
                OdaNo = txtAldigiOda.Text,
                Ucret = txtUcret.Text,
                GirisTarihi = girisTarihi,
                CikisTarihi = cikisTarihi
            };

            Service1Client service = new Service1Client();
            if (service.UpdateMusteriB(b) == 1)
            {
                MessageBox.Show("Bilgiler Güncellendi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriBilgileri b = new MusteriBilgileri()
            {
                MusteriId = Convert.ToInt32(lblID.Text)
            };
            Service1Client service = new Service1Client();
            if (service.DeleteMusteriB(b)==1)
            {
                MessageBox.Show("Bilgiler Silindi");
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            MainClass me = new MainClass();
            dataGridView1.DataSource = me.tablolar();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAldigiOda.Text = "";
            cmbcinsiyet.Text = "";
            txtUcret.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            txtTcNo.Text = "";
            dtGiris.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            dtCikis.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MainClass me = new MainClass();
            dataGridView1.DataSource = me.musteriAra(txtAra.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["musterilerId"].Value);
            txtAd.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["adi"].Value);
            txtSoyad.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value);
            cmbcinsiyet.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["cinsyet"].Value);
            txtTelefon.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["telefon"].Value);
            txtEmail.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["mail"].Value);
            txtTcNo.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["tcNo"].Value);
            txtAldigiOda.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["odaNo"].Value);
            txtUcret.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ucret"].Value);
            dtGiris.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["girisTarihi"].Value);
            dtCikis.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cikisTarihi"].Value);
        }
    }
}
