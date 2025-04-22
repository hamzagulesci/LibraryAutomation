namespace Proje
{
    partial class KitapListeleme
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
            this.ButtonListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(749, 390);
            this.dataGridViewKitaplar.TabIndex = 86;
            // 
            // ButtonListele
            // 
            this.ButtonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonListele.Location = new System.Drawing.Point(267, 12);
            this.ButtonListele.Name = "ButtonListele";
            this.ButtonListele.Size = new System.Drawing.Size(197, 32);
            this.ButtonListele.TabIndex = 83;
            this.ButtonListele.Text = "Listele";
            this.ButtonListele.UseVisualStyleBackColor = true;
            this.ButtonListele.Click += new System.EventHandler(this.ButtonListele_Click);
            // 
            // KitapListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(749, 452);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.Controls.Add(this.ButtonListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KitapListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listeleme";
            this.Load += new System.EventHandler(this.KitapListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Button ButtonListele;
    }
}