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
    public partial class PersonalB : Form
    {
        public PersonalB()
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
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar o = new Odalar();
            o.Show();
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

        private void PersonalB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelBilgileri p = new PersonelBilgileri();
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.Bolum = cmbbolum.Text;
            p.Cinsiyet = cmbCinsiyet.Text;
            p.Telefon = txtTelefon.Text;
            p.Mail = txtEmail.Text;
            p.TcNo = txtTcKimlik.Text;
            p.Maas = txtMaas.Text;
            p.GirisTarihi = Convert.ToDateTime(dtGiris.Text);
            p.CikisTarihi = Convert.ToDateTime(dtCikis.Text);

            Service1Client service = new Service1Client();

            if (service.Personelekle(p)==1)
            {
                MessageBox.Show("Personel Eklendi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dtGiris.Value);
            DateTime cikisTarihi = Convert.ToDateTime(dtCikis.Value);
            PersonelBilgileri p = new PersonelBilgileri()
            {
                PersonelId = Convert.ToInt32(lblID.Text),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = cmbbolum.Text,
                Cinsiyet = cmbCinsiyet.Text,
                Telefon = txtTelefon.Text,
                Mail = txtEmail.Text,
                TcNo = txtTcKimlik.Text,
                Maas = txtMaas.Text,
                GirisTarihi = girisTarihi,
                CikisTarihi = cikisTarihi
            };

            Service1Client service = new Service1Client();
            if (service.UpdatePersonelB(p) == 1)
            {
                MessageBox.Show("Bilgiler Güncellendi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PersonelBilgileri z = new PersonelBilgileri()
            {
                PersonelId = Convert.ToInt32(lblID.Text)
            };
            Service1Client service = new Service1Client();
            if (service.DeletePersonelB(z) == 1)
            {
                MessageBox.Show("Personel Silindi");
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            MainClass pe = new MainClass();
            dataGridView1.DataSource = pe.Ptablolar();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbbolum.Text = "";
            cmbCinsiyet.Text = "";
            txtMaas.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            txtTcKimlik.Text = "";
            dtGiris.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            dtCikis.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MainClass pe = new MainClass();
            dataGridView1.DataSource = pe.personelAra(txtara.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["PersonellerId"].Value);
            txtAd.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Adi"].Value);
            txtSoyad.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Soyadi"].Value);
            cmbbolum.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Bolum"].Value);
            cmbCinsiyet.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Cinsyet"].Value);
            txtTelefon.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value);
            txtEmail.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Mail"].Value);
            txtTcKimlik.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["TcNo"].Value);
            txtMaas.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Maas"].Value);
            dtGiris.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["GirisTarihi"].Value);
            dtCikis.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["CikisTarihi"].Value);
        }
    }
}
