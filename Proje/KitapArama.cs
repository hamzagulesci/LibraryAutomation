using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class KitapArama : Form
    {
        public KitapArama()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.mdb;");

        void listele()
        {
            try
            {
                if (baglanti == null) baglanti.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", baglanti);
                da.Fill(dt);
                dataGridViewKitaplar.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void KitapArama_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void AramaYap(string barkod, string kitapAd)
        {
            string query = "SELECT * FROM Kitaplar WHERE 1=1";
            if (!string.IsNullOrEmpty(barkod.Trim()))
            {
                query += " AND Trim(Barkod) LIKE ?";
            }
            if (!string.IsNullOrEmpty(kitapAd.Trim()))
            {
                query += " AND Trim(KitapAd) LIKE ?";
            }

            using (OleDbCommand command = new OleDbCommand(query, baglanti))
            {
                if (!string.IsNullOrEmpty(barkod.Trim()))
                {
                    command.Parameters.AddWithValue("?", "%" + barkod.Trim() + "%");
                }
                if (!string.IsNullOrEmpty(kitapAd.Trim()))
                {
                    command.Parameters.AddWithValue("?", "%" + kitapAd.Trim() + "%");
                }

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    baglanti.Open();
                    da.Fill(dt);
                    dataGridViewKitaplar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void txtKitapID_TextChanged(object sender, EventArgs e)
        {
            AramaYap(txtKitapBarkod.Text, txtKitapAd.Text);
        }
      
        private void txtKitapAd_TextChanged_1(object sender, EventArgs e)
        {
            AramaYap(txtKitapBarkod.Text, txtKitapAd.Text);
        }
        private void Temizle()
        {
            txtKitapBarkod.Clear();
            txtKitapAd.Clear();
            dataGridViewKitaplar.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Temizle();
            listele();
        }
    }
}
