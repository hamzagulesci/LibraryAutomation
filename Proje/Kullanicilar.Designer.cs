namespace Proje
{
    partial class Kullanicilar
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
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnBaglantiKontrol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsım
            // 
            this.txtIsım.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsım.Location = new System.Drawing.Point(154, 44);
            this.txtIsım.Multiline = true;
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(137, 32);
            this.txtIsım.TabIndex = 108;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(79, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 24);
            this.label19.TabIndex = 107;
            this.label19.Text = "İsim :";
            // 
            // txtKimlik
            // 
            this.txtKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKimlik.Location = new System.Drawing.Point(154, 6);
            this.txtKimlik.Multiline = true;
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Size = new System.Drawing.Size(137, 32);
            this.txtKimlik.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 105;
            this.label4.Text = "Kimlik :";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(308, 5);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(197, 33);
            this.btnListele.TabIndex = 104;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(154, 83);
            this.txtSoyisim.Multiline = true;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(137, 32);
            this.txtSoyisim.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "Soyisim :";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(308, 44);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(197, 32);
            this.btnSil.TabIndex = 101;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKullanicilar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(0, 121);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(518, 459);
            this.dataGridViewKullanicilar.TabIndex = 100;
            this.dataGridViewKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellClick);
            // 
            // btnBaglantiKontrol
            // 
            this.btnBaglantiKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglantiKontrol.Location = new System.Drawing.Point(308, 83);
            this.btnBaglantiKontrol.Name = "btnBaglantiKontrol";
            this.btnBaglantiKontrol.Size = new System.Drawing.Size(197, 32);
            this.btnBaglantiKontrol.TabIndex = 110;
            this.btnBaglantiKontrol.Text = "Bağlantıyı Kontrol Et";
            this.btnBaglantiKontrol.UseVisualStyleBackColor = true;
            this.btnBaglantiKontrol.Click += new System.EventHandler(this.btnBaglantiKontrol_Click);
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 580);
            this.Controls.Add(this.btnBaglantiKontrol);
            this.Controls.Add(this.txtIsım);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridViewKullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private System.Windows.Forms.Button btnBaglantiKontrol;
    }
}