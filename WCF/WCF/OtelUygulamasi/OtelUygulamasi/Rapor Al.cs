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
    public partial class SosyalAglar : Form
    {
        public SosyalAglar()
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

        private void SosyalAglar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OtelAutomationDataSet.kullaniciBilgileri' table. You can move, or remove it, as needed.
            this.kullaniciBilgileriTableAdapter.Fill(this.OtelAutomationDataSet.kullaniciBilgileri);

            this.reportViewer1.RefreshReport();
        }

        private void btnOdaVer_Click(object sender, EventArgs e)
        {
            KullaniciKayit ky = new KullaniciKayit();
            ky.Show();
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

        private void btnUrunleri_Click(object sender, EventArgs e)
        {
            Mutfak m = new Mutfak();
            m.Show();
            this.Hide();
        }

        private void btnPersonelBilgileri_Click(object sender, EventArgs e)
        {
            PersonalB b = new PersonalB();
            b.Show();
            this.Hide();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
