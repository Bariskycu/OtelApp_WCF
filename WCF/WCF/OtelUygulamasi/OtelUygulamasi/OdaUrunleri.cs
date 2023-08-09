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
    public partial class OdaUrunleri : Form
    {
        public OdaUrunleri()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OdaUrunleri_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MainClass oda = new MainClass();
            dataGridView1.DataSource = oda.odaUrunleri_Listele();

            cmbKategori.Items.Clear();
            oda.kategoriAl();
            for (int i = 0; i < oda.kategoriler.Count; i++)
            {
                cmbKategori.Items.Add(oda.kategoriler[i].ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dataGridView1.Rows[e.RowIndex].Cells["OdaUrunleriId"].Value.ToString();
            txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["urunAdi"].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
            txtUrunAdet.Text = dataGridView1.Rows[e.RowIndex].Cells["adet"].Value.ToString();
            txtUrunFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells["fiyat"].Value.ToString();
            txtfirmaAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["firma"].Value.ToString();
            dtGelisT.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["gelisTarihi"].Value);
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            OdaU o = new OdaU();
            o.UrunAdi = txtUrunAdi.Text;
            o.Kategori = cmbKategori.Text;
            o.Adet = txtUrunAdet.Text;
            o.Fiyat = txtUrunFiyat.Text;
            o.Firma = txtfirmaAdi.Text;
            o.GelisTarihi = Convert.ToDateTime(dtGelisT.Text);

            Service1Client service = new Service1Client();

            if (service.OdaUekle(o) == 1)
            {
                MessageBox.Show("Oda Ürünü Eklendi");
            }
        }

        private void btnUrunGoster_Click(object sender, EventArgs e)
        {
            MainClass oda = new MainClass();
            dataGridView1.DataSource = oda.odaUrunleri_Listele();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            OdaU o = new OdaU()
            {
                OdaUId = Convert.ToInt32(lblId.Text),
                UrunAdi = txtUrunAdi.Text,
                Kategori = cmbKategori.Text,
                Adet = txtUrunAdet.Text,
                Fiyat = txtUrunFiyat.Text,
                Firma = txtfirmaAdi.Text,
                GelisTarihi = Convert.ToDateTime(dtGelisT.Text)
            };

            Service1Client service = new Service1Client();
            if (service.UpdateOdaU(o) == 1)
            {
                MessageBox.Show("Bilgiler Güncellendi");
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            OdaU m = new OdaU()
            {
                OdaUId = Convert.ToInt32(lblId.Text)
            };
            Service1Client service = new Service1Client();

            if (service.DeleteOdaU(m) == 1)
            {
                MessageBox.Show("Ürün Silindi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtUrunAdet.Text = "";
            txtfirmaAdi.Text = "";
            cmbKategori.Text = "";
            txtUrunFiyat.Text = "";
            dtGelisT.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MainClass oda = new MainClass();

            dataGridView1.DataSource = oda.veriGetirOda(txtUrunAra.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Mutfak m = new Mutfak();
            m.Show();
            this.Hide();
        }

        private void btnOdaVer_Click(object sender, EventArgs e)
        {
            KullaniciKayit k = new KullaniciKayit();
            k.Show();
            this.Hide();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar o = new Odalar();
            o.Show();
            this.Hide();
        }

        private void btnMusteriBilgileri_Click(object sender, EventArgs e)
        {
            MusteriB m = new MusteriB();
            m.Show();
            this.Hide();
        }

        private void btnPersonelBilgileri_Click(object sender, EventArgs e)
        {
            PersonalB p = new PersonalB();
            p.Show();
            this.Hide();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            SosyalAglar rapor = new SosyalAglar();
            rapor.Show();
            this.Hide();
        }
    }
}
