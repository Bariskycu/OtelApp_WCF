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
    public partial class Mutfak : Form
    {
        public Mutfak()
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
            MusteriB m = new MusteriB();
            m.Show();
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
            SosyalAglar s = new SosyalAglar();
            s.Show();
            this.Hide();
        }

        private void Mutfak_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            MutfakU m = new MutfakU();
            m.UrunAdi = txtUrunAdi.Text;
            m.Kategori = cmbKategori.Text;
            m.Adet = txtUrunAdet.Text;
            m.Fiyat = txtUrunFiyat.Text;
            m.Firma = txtfirmaAdi.Text;
            m.GelisTarihi = Convert.ToDateTime(dtGelisT.Text);

            Service1Client service = new Service1Client();

            if (service.MutfakUekle(m) == 1)
            {
                MessageBox.Show("Mutfak Ürünü Eklendi");
            }
        }

        private void btnUrunGoster_Click(object sender, EventArgs e)
        {
            MainClass mutfak = new MainClass();
            dataGridView1.DataSource = mutfak.mutfakUrunleri_Listele();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            MutfakU m = new MutfakU()
            {
                MutfakUId = Convert.ToInt32(lblId.Text),
                UrunAdi = txtUrunAdi.Text,
                Kategori = cmbKategori.Text,
                Adet = txtUrunAdet.Text,
                Fiyat = txtUrunFiyat.Text,
                Firma = txtfirmaAdi.Text,
                GelisTarihi = Convert.ToDateTime(dtGelisT.Text)
                
            };

            Service1Client service = new Service1Client();
            if (service.UpdateMutfakU(m) == 1)
            {
                MessageBox.Show("Bilgiler Güncellendi");
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            MutfakU m = new MutfakU()
            {
                MutfakUId = Convert.ToInt32(lblId.Text)
            };
            Service1Client service = new Service1Client();

            if (service.DeleteMutfakU(m) == 1)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MainClass mutfak = new MainClass();
            dataGridView1.DataSource = mutfak.mutfakUrunleri_Listele();

            cmbKategori.Items.Clear();
            mutfak.kategroAl();
            for (int i = 0; i < mutfak.kategoriler.Count; i++)
            {
                cmbKategori.Items.Add(mutfak.kategoriler[i].ToString());
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MainClass mutfak = new MainClass();

            dataGridView1.DataSource = mutfak.veriGetirMutfak(txtUrunAra.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dataGridView1.Rows[e.RowIndex].Cells["MutfakUrunleriId"].Value.ToString();
            txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["urunAdi"].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
            txtUrunAdet.Text = dataGridView1.Rows[e.RowIndex].Cells["adet"].Value.ToString();
            txtUrunFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells["fiyat"].Value.ToString();
            txtfirmaAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["firma"].Value.ToString();
            dtGelisT.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["gelisTarihi"].Value);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OdaUrunleri o = new OdaUrunleri();
            o.Show();
            this.Hide();

        }
    }
}
