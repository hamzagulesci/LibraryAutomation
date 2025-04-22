namespace Proje
{
    partial class KitapSilme
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
            this.btnSil = new System.Windows.Forms.Button();
            this.ButtonListele = new System.Windows.Forms.Button();
            this.txtKitapSayfa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapTur = new System.Windows.Forms.TextBox();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtKitapİd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(334, 0);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(744, 359);
            this.dataGridViewKitaplar.TabIndex = 78;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(12, 269);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(299, 33);
            this.btnSil.TabIndex = 77;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ButtonListele
            // 
            this.ButtonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonListele.Location = new System.Drawing.Point(12, 311);
            this.ButtonListele.Name = "ButtonListele";
            this.ButtonListele.Size = new System.Drawing.Size(299, 33);
            this.ButtonListele.TabIndex = 76;
            this.ButtonListele.Text = "Listele";
            this.ButtonListele.UseVisualStyleBackColor = true;
            this.ButtonListele.Click += new System.EventHandler(this.ButtonListele_Click);
            // 
            // txtKitapSayfa
            // 
            this.txtKitapSayfa.Enabled = false;
            this.txtKitapSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapSayfa.Location = new System.Drawing.Point(174, 216);
            this.txtKitapSayfa.Multiline = true;
            this.txtKitapSayfa.Name = "txtKitapSayfa";
            this.txtKitapSayfa.Size = new System.Drawing.Size(137, 32);
            this.txtKitapSayfa.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 74;
            this.label5.Text = "Kitabın Tür :";
            // 
            // txtKitapTur
            // 
            this.txtKitapTur.Enabled = false;
            this.txtKitapTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapTur.Location = new System.Drawing.Point(174, 162);
            this.txtKitapTur.Multiline = true;
            this.txtKitapTur.Name = "txtKitapTur";
            this.txtKitapTur.Size = new System.Drawing.Size(137, 32);
            this.txtKitapTur.TabIndex = 73;
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Enabled = false;
            this.txtKitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazar.Location = new System.Drawing.Point(174, 110);
            this.txtKitapYazar.Multiline = true;
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(137, 32);
            this.txtKitapYazar.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Kitabın Sayfası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Kitabın Yazarı :";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Enabled = false;
            this.txtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(174, 55);
            this.txtKitapAd.Multiline = true;
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(137, 32);
            this.txtKitapAd.TabIndex = 69;
            // 
            // txtKitapİd
            // 
            this.txtKitapİd.Enabled = false;
            this.txtKitapİd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapİd.Location = new System.Drawing.Point(174, 6);
            this.txtKitapİd.Multiline = true;
            this.txtKitapİd.Name = "txtKitapİd";
            this.txtKitapİd.Size = new System.Drawing.Size(137, 32);
            this.txtKitapİd.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Kitap Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Barkod :";
            // 
            // KitapSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1078, 359);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.ButtonListele);
            this.Controls.Add(this.txtKitapSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKitapTur);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.txtKitapİd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KitapSilme";
            this.Text = "KitapSilme";
            this.Load += new System.EventHandler(this.KitapSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button ButtonListele;
        private System.Windows.Forms.TextBox txtKitapSayfa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapTur;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtKitapİd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}