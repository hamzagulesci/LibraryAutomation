namespace Proje
{
    partial class KullaniciListesi
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBaglantiKontrol = new System.Windows.Forms.Button();
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtYetki = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuvenlikSorusu = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(342, 83);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(197, 32);
            this.btnSil.TabIndex = 81;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBaglantiKontrol
            // 
            this.btnBaglantiKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglantiKontrol.Location = new System.Drawing.Point(342, 159);
            this.btnBaglantiKontrol.Name = "btnBaglantiKontrol";
            this.btnBaglantiKontrol.Size = new System.Drawing.Size(197, 32);
            this.btnBaglantiKontrol.TabIndex = 80;
            this.btnBaglantiKontrol.Text = "Bağlantıyı Kontrol Et";
            this.btnBaglantiKontrol.UseVisualStyleBackColor = true;
            this.btnBaglantiKontrol.Click += new System.EventHandler(this.btnBaglantiKontrol_Click);
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewKullanicilar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(545, 0);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(711, 318);
            this.dataGridViewKullanicilar.TabIndex = 76;
            this.dataGridViewKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(342, 121);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(197, 32);
            this.btnGuncelle.TabIndex = 75;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(342, 45);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(197, 32);
            this.btnKaydet.TabIndex = 74;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(199, 160);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(137, 32);
            this.txtSifre.TabIndex = 85;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(199, 45);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(137, 32);
            this.txtKullaniciAdi.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(119, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 82;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(342, 6);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(197, 32);
            this.btnListele.TabIndex = 86;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtYetki
            // 
            this.txtYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetki.Location = new System.Drawing.Point(199, 198);
            this.txtYetki.Multiline = true;
            this.txtYetki.Name = "txtYetki";
            this.txtYetki.Size = new System.Drawing.Size(137, 32);
            this.txtYetki.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(116, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 87;
            this.label3.Text = "Yetki :";
            // 
            // txtKimlik
            // 
            this.txtKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKimlik.Location = new System.Drawing.Point(199, 6);
            this.txtKimlik.Multiline = true;
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Size = new System.Drawing.Size(137, 32);
            this.txtKimlik.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 89;
            this.label4.Text = "Kimlik :";
            // 
            // txtIsım
            // 
            this.txtIsım.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsım.Location = new System.Drawing.Point(199, 83);
            this.txtIsım.Multiline = true;
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(137, 32);
            this.txtIsım.TabIndex = 98;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(124, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 24);
            this.label19.TabIndex = 97;
            this.label19.Text = "İsim :";
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.Location = new System.Drawing.Point(199, 274);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(137, 32);
            this.txtCevap.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(97, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 95;
            this.label7.Text = "Cevabı :";
            // 
            // txtGuvenlikSorusu
            // 
            this.txtGuvenlikSorusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuvenlikSorusu.Location = new System.Drawing.Point(199, 236);
            this.txtGuvenlikSorusu.Multiline = true;
            this.txtGuvenlikSorusu.Name = "txtGuvenlikSorusu";
            this.txtGuvenlikSorusu.Size = new System.Drawing.Size(340, 32);
            this.txtGuvenlikSorusu.TabIndex = 94;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(199, 122);
            this.txtSoyisim.Multiline = true;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(137, 32);
            this.txtSoyisim.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 92;
            this.label8.Text = "Güvenlik Sorusu :";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label0.Location = new System.Drawing.Point(89, 122);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(94, 24);
            this.label0.TabIndex = 91;
            this.label0.Text = "Soyisim :";
            // 
            // KullaniciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1256, 318);
            this.Controls.Add(this.txtIsım);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGuvenlikSorusu);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYetki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBaglantiKontrol);
            this.Controls.Add(this.dataGridViewKullanicilar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullaniciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciListesi";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBaglantiKontrol;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtYetki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGuvenlikSorusu;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label0;
    }
}