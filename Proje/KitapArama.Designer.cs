namespace Proje
{
    partial class KitapArama
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
            this.txtKitapBarkod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitapBarkod
            // 
            this.txtKitapBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapBarkod.Location = new System.Drawing.Point(47, 39);
            this.txtKitapBarkod.Multiline = true;
            this.txtKitapBarkod.Name = "txtKitapBarkod";
            this.txtKitapBarkod.Size = new System.Drawing.Size(198, 32);
            this.txtKitapBarkod.TabIndex = 92;
            this.txtKitapBarkod.TextChanged += new System.EventHandler(this.txtKitapID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 24);
            this.label6.TabIndex = 91;
            this.label6.Text = "Kitabın Barkod\'una Göre Ara";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(0, 94);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(945, 483);
            this.dataGridViewKitaplar.TabIndex = 90;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(335, 39);
            this.txtKitapAd.Multiline = true;
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(198, 32);
            this.txtKitapAd.TabIndex = 95;
            this.txtKitapAd.TextChanged += new System.EventHandler(this.txtKitapAd_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(314, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 94;
            this.label1.Text = "Kitabın İsmine Göre Ara";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(565, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 59);
            this.button3.TabIndex = 100;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KitapArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(945, 577);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapBarkod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KitapArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapArama";
            this.Load += new System.EventHandler(this.KitapArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKitapBarkod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}