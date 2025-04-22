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
    public partial class KitapSilme : Form
    {
        public KitapSilme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:kutuphane.mdb;");
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
        void txtSil()
        {
            txtKitapİd.Clear();
            txtKitapAd.Clear();
            txtKitapYazar.Clear();
            txtKitapTur.Clear();
            txtKitapSayfa.Clear();
        }

        private void KitapSilme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void ButtonListele_Click(object sender, EventArgs e)
        {
            listele();
            txtSil();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewKitaplar.SelectedCells[0].RowIndex;

            txtKitapİd.Text = dataGridViewKitaplar.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridViewKitaplar.Rows[secilen].Cells[1].Value.ToString();
            txtKitapYazar.Text = dataGridViewKitaplar.Rows[secilen].Cells[2].Value.ToString();
            txtKitapTur.Text = dataGridViewKitaplar.Rows[secilen].Cells[3].Value.ToString();
            txtKitapSayfa.Text = dataGridViewKitaplar.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Silinecek kitabın kimliğini alın
            string kitapId = txtKitapİd.Text;

            // Eğer kitap kimliği boşsa, silme işlemini gerçekleştirmeyin
            if (string.IsNullOrEmpty(kitapId))
            {
                MessageBox.Show("Lütfen bir kitap seçin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kitabı silme işlemini gerçekleştir
            try
            {
                // Veritabanı bağlantısını açın
                baglanti.Open();

                // Silme sorgusunu hazırlayın
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Kitaplar WHERE Barkod = @KitapId", baglanti);
                cmd.Parameters.AddWithValue("@KitapId", kitapId);

                // Komutu yürütün
                int affectedRows = cmd.ExecuteNonQuery();

                // Etkilenen satır sayısına göre başarılı bir silme işlemi gerçekleştirildiğini kontrol edin
                if (affectedRows > 0)
                {
                    // Başarılı bir şekilde silindiğini bildirin
                    MessageBox.Show("Kitap başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Silme işleminden sonra listeyi güncelle
                    listele();
                    txtSil();
                }
                else
                {
                    // Eğer hiç satır etkilenmediyse, bu kitap zaten silinmiş olabilir veya belirtilen bir kimliğe sahip kitap bulunamamış olabilir
                    MessageBox.Show("Belirtilen kimliğe sahip kitap bulunamadı veya zaten silinmiş olabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıyı bilgilendirin
                MessageBox.Show("Kitap silinirken bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Veritabanı bağlantısını kapatın
                baglanti.Close();
            }
        }
    }
}
