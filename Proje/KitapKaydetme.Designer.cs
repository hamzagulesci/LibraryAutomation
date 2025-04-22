namespace Proje
{
    partial class KitapKaydetme
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
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.ButtonKaydet = new System.Windows.Forms.Button();
            this.ButtonListele = new System.Windows.Forms.Button();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblShelfNo = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBarcodeNo = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBarkod = new System.Windows.Forms.Button();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewKitaplar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(511, 0);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(755, 361);
            this.dataGridViewKitaplar.TabIndex = 65;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // ButtonKaydet
            // 
            this.ButtonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKaydet.Location = new System.Drawing.Point(12, 272);
            this.ButtonKaydet.Name = "ButtonKaydet";
            this.ButtonKaydet.Size = new System.Drawing.Size(235, 33);
            this.ButtonKaydet.TabIndex = 63;
            this.ButtonKaydet.Text = "Kaydet";
            this.ButtonKaydet.UseVisualStyleBackColor = true;
            this.ButtonKaydet.Click += new System.EventHandler(this.ButtonKaydet_Click);
            // 
            // ButtonListele
            // 
            this.ButtonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonListele.Location = new System.Drawing.Point(12, 311);
            this.ButtonListele.Name = "ButtonListele";
            this.ButtonListele.Size = new System.Drawing.Size(235, 33);
            this.ButtonListele.TabIndex = 62;
            this.ButtonListele.Text = "Listele";
            this.ButtonListele.UseVisualStyleBackColor = true;
            this.ButtonListele.Click += new System.EventHandler(this.ButtonListele_Click);
            // 
            // txtRaf
            // 
            this.txtRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRaf.Location = new System.Drawing.Point(116, 204);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(123, 24);
            this.txtRaf.TabIndex = 85;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfa.Location = new System.Drawing.Point(116, 169);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(123, 24);
            this.txtSayfa.TabIndex = 84;
            // 
            // txtYazar
            // 
            this.txtYazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazar.Location = new System.Drawing.Point(116, 133);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(365, 24);
            this.txtYazar.TabIndex = 83;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(116, 46);
            this.txtKitapAd.Multiline = true;
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(365, 73);
            this.txtKitapAd.TabIndex = 82;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(116, 12);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(365, 24);
            this.txtBarkod.TabIndex = 81;
            // 
            // lblShelfNo
            // 
            this.lblShelfNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShelfNo.AutoSize = true;
            this.lblShelfNo.BackColor = System.Drawing.Color.Transparent;
            this.lblShelfNo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShelfNo.Location = new System.Drawing.Point(8, 206);
            this.lblShelfNo.Name = "lblShelfNo";
            this.lblShelfNo.Size = new System.Drawing.Size(67, 22);
            this.lblShelfNo.TabIndex = 80;
            this.lblShelfNo.Text = "Raf No";
            // 
            // lblPageCount
            // 
            this.lblPageCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPageCount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageCount.Location = new System.Drawing.Point(8, 171);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(109, 22);
            this.lblPageCount.TabIndex = 79;
            this.lblPageCount.Text = "Sayfa Sayısı";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(8, 135);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(64, 22);
            this.lblAuthor.TabIndex = 78;
            this.lblAuthor.Text = "Yazarı";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(8, 48);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(90, 22);
            this.lblBookTitle.TabIndex = 77;
            this.lblBookTitle.Text = "Kitap Adı";
            // 
            // lblBarcodeNo
            // 
            this.lblBarcodeNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarcodeNo.AutoSize = true;
            this.lblBarcodeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcodeNo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarcodeNo.Location = new System.Drawing.Point(8, 14);
            this.lblBarcodeNo.Name = "lblBarcodeNo";
            this.lblBarcodeNo.Size = new System.Drawing.Size(102, 22);
            this.lblBarcodeNo.TabIndex = 76;
            this.lblBarcodeNo.Text = "Barkod No";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(253, 272);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(235, 33);
            this.btnTemizle.TabIndex = 86;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBarkod
            // 
            this.btnBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarkod.Location = new System.Drawing.Point(253, 311);
            this.btnBarkod.Name = "btnBarkod";
            this.btnBarkod.Size = new System.Drawing.Size(235, 33);
            this.btnBarkod.TabIndex = 87;
            this.btnBarkod.Text = "Barkod Oluştur";
            this.btnBarkod.UseVisualStyleBackColor = true;
            this.btnBarkod.Click += new System.EventHandler(this.btnBarkod_Click);
            // 
            // txtStok
            // 
            this.txtStok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.Location = new System.Drawing.Point(132, 236);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(123, 24);
            this.txtStok.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 88;
            this.label1.Text = "Stok Miktarı";
            // 
            // KitapKaydetme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1266, 361);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBarkod);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblShelfNo);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblBarcodeNo);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.Controls.Add(this.ButtonKaydet);
            this.Controls.Add(this.ButtonListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KitapKaydetme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapKaydetme";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Button ButtonKaydet;
        private System.Windows.Forms.Button ButtonListele;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblShelfNo;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBarcodeNo;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnBarkod;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label1;
    }
}