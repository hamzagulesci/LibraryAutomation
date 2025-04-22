namespace Proje
{
    partial class KitapGuncelleme
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
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.txtKitapSayfa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewKitaplar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(332, 0);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(744, 357);
            this.dataGridViewKitaplar.TabIndex = 77;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelleme.Location = new System.Drawing.Point(12, 294);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(299, 33);
            this.btnGuncelleme.TabIndex = 76;
            this.btnGuncelleme.Text = "Güncelle";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // txtKitapSayfa
            // 
            this.txtKitapSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapSayfa.Location = new System.Drawing.Point(174, 150);
            this.txtKitapSayfa.Multiline = true;
            this.txtKitapSayfa.Name = "txtKitapSayfa";
            this.txtKitapSayfa.Size = new System.Drawing.Size(137, 32);
            this.txtKitapSayfa.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 74;
            this.label5.Text = "Stok Miktarı :";
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.Location = new System.Drawing.Point(174, 243);
            this.txtStok.Multiline = true;
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(137, 32);
            this.txtStok.TabIndex = 73;
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazar.Location = new System.Drawing.Point(174, 102);
            this.txtKitapYazar.Multiline = true;
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(137, 32);
            this.txtKitapYazar.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Kitabın Sayfası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Kitabın Yazarı :";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(174, 55);
            this.txtKitapAd.Multiline = true;
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(137, 32);
            this.txtKitapAd.TabIndex = 69;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(174, 6);
            this.txtBarkod.Multiline = true;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(137, 32);
            this.txtBarkod.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Kitap Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Barkod :";
            // 
            // txtRaf
            // 
            this.txtRaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRaf.Location = new System.Drawing.Point(173, 197);
            this.txtRaf.Multiline = true;
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(137, 32);
            this.txtRaf.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 78;
            this.label6.Text = "Raf Sayısı :";
            // 
            // KitapGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1076, 357);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.txtKitapSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KitapGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapGuncelleme";
            this.Load += new System.EventHandler(this.KitapGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.TextBox txtKitapSayfa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.Label label6;
    }
}