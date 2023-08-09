namespace OtelUygulamasi
{
    partial class SosyalAglar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SosyalAglar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.kullaniciBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OtelAutomationDataSet = new OtelUygulamasi.OtelAutomationDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.btnPersonelBilgileri = new System.Windows.Forms.Button();
            this.btnUrunleri = new System.Windows.Forms.Button();
            this.btnMusteriBilgileri = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnOdaVer = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kullaniciBilgileriTableAdapter = new OtelUygulamasi.OtelAutomationDataSetTableAdapters.kullaniciBilgileriTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtelAutomationDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciBilgileriBindingSource
            // 
            this.kullaniciBilgileriBindingSource.DataMember = "kullaniciBilgileri";
            this.kullaniciBilgileriBindingSource.DataSource = this.OtelAutomationDataSet;
            // 
            // OtelAutomationDataSet
            // 
            this.OtelAutomationDataSet.DataSetName = "OtelAutomationDataSet";
            this.OtelAutomationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-4, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 59);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1226, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.panelleft);
            this.panel1.Controls.Add(this.btnRaporAl);
            this.panel1.Controls.Add(this.btnPersonelBilgileri);
            this.panel1.Controls.Add(this.btnUrunleri);
            this.panel1.Controls.Add(this.btnMusteriBilgileri);
            this.panel1.Controls.Add(this.btnOdalar);
            this.panel1.Controls.Add(this.btnOdaVer);
            this.panel1.Location = new System.Drawing.Point(4, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 758);
            this.panel1.TabIndex = 6;
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelleft.Location = new System.Drawing.Point(0, 455);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(7, 59);
            this.panelleft.TabIndex = 112;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.FlatAppearance.BorderSize = 0;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporAl.ForeColor = System.Drawing.Color.White;
            this.btnRaporAl.Image = global::OtelUygulamasi.Properties.Resources.reportAs;
            this.btnRaporAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaporAl.Location = new System.Drawing.Point(3, 455);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(236, 59);
            this.btnRaporAl.TabIndex = 3;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // btnPersonelBilgileri
            // 
            this.btnPersonelBilgileri.FlatAppearance.BorderSize = 0;
            this.btnPersonelBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelBilgileri.ForeColor = System.Drawing.Color.White;
            this.btnPersonelBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelBilgileri.Image")));
            this.btnPersonelBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelBilgileri.Location = new System.Drawing.Point(3, 390);
            this.btnPersonelBilgileri.Name = "btnPersonelBilgileri";
            this.btnPersonelBilgileri.Size = new System.Drawing.Size(236, 59);
            this.btnPersonelBilgileri.TabIndex = 3;
            this.btnPersonelBilgileri.Text = "Personel Bilgileri";
            this.btnPersonelBilgileri.UseVisualStyleBackColor = true;
            this.btnPersonelBilgileri.Click += new System.EventHandler(this.btnPersonelBilgileri_Click);
            // 
            // btnUrunleri
            // 
            this.btnUrunleri.FlatAppearance.BorderSize = 0;
            this.btnUrunleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunleri.ForeColor = System.Drawing.Color.White;
            this.btnUrunleri.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunleri.Image")));
            this.btnUrunleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunleri.Location = new System.Drawing.Point(3, 325);
            this.btnUrunleri.Name = "btnUrunleri";
            this.btnUrunleri.Size = new System.Drawing.Size(236, 59);
            this.btnUrunleri.TabIndex = 3;
            this.btnUrunleri.Text = "Ürünler";
            this.btnUrunleri.UseVisualStyleBackColor = true;
            this.btnUrunleri.Click += new System.EventHandler(this.btnUrunleri_Click);
            // 
            // btnMusteriBilgileri
            // 
            this.btnMusteriBilgileri.FlatAppearance.BorderSize = 0;
            this.btnMusteriBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriBilgileri.ForeColor = System.Drawing.Color.White;
            this.btnMusteriBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriBilgileri.Image")));
            this.btnMusteriBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriBilgileri.Location = new System.Drawing.Point(3, 260);
            this.btnMusteriBilgileri.Name = "btnMusteriBilgileri";
            this.btnMusteriBilgileri.Size = new System.Drawing.Size(236, 59);
            this.btnMusteriBilgileri.TabIndex = 3;
            this.btnMusteriBilgileri.Text = "Müşteri Bilgileri";
            this.btnMusteriBilgileri.UseVisualStyleBackColor = true;
            this.btnMusteriBilgileri.Click += new System.EventHandler(this.btnMusteriBilgileri_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.FlatAppearance.BorderSize = 0;
            this.btnOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdalar.ForeColor = System.Drawing.Color.White;
            this.btnOdalar.Image = ((System.Drawing.Image)(resources.GetObject("btnOdalar.Image")));
            this.btnOdalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdalar.Location = new System.Drawing.Point(3, 195);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(236, 59);
            this.btnOdalar.TabIndex = 3;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btnOdaVer
            // 
            this.btnOdaVer.FlatAppearance.BorderSize = 0;
            this.btnOdaVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaVer.ForeColor = System.Drawing.Color.White;
            this.btnOdaVer.Image = ((System.Drawing.Image)(resources.GetObject("btnOdaVer.Image")));
            this.btnOdaVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdaVer.Location = new System.Drawing.Point(3, 130);
            this.btnOdaVer.Name = "btnOdaVer";
            this.btnOdaVer.Size = new System.Drawing.Size(236, 59);
            this.btnOdaVer.TabIndex = 3;
            this.btnOdaVer.Text = "Oda Ver";
            this.btnOdaVer.UseVisualStyleBackColor = true;
            this.btnOdaVer.Click += new System.EventHandler(this.btnOdaVer_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reportViewer1.ForeColor = System.Drawing.Color.White;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.kullaniciBilgileriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelUygulamasi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(255, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1027, 630);
            this.reportViewer1.TabIndex = 7;
            // 
            // kullaniciBilgileriTableAdapter
            // 
            this.kullaniciBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(261, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "BU HAFTA SİSTEME GİRENLER";
            // 
            // SosyalAglar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1283, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SosyalAglar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.SosyalAglar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtelAutomationDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.Button btnPersonelBilgileri;
        private System.Windows.Forms.Button btnUrunleri;
        private System.Windows.Forms.Button btnMusteriBilgileri;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnOdaVer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource kullaniciBilgileriBindingSource;
        private OtelAutomationDataSet OtelAutomationDataSet;
        private OtelAutomationDataSetTableAdapters.kullaniciBilgileriTableAdapter kullaniciBilgileriTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}