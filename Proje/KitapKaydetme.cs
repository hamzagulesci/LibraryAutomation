using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Proje
{
    public partial class KitapKaydetme : Form
    {
        public KitapKaydetme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:kutuphane.mdb;");
        void listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", baglanti);
                da.Fill(dt);
                dataGridViewKitaplar.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }


        void txtSil()
        {
            txtBarkod.Clear();
            txtKitapAd.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
            txtRaf.Clear();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void ButtonListele_Click(object sender, EventArgs e)
        {
            listele();
            txtSil();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Gerekli alanların doldurulup doldurulmadığını kontrol ediyoruz.
                if (string.IsNullOrWhiteSpace(txtBarkod.Text) ||
                    string.IsNullOrWhiteSpace(txtKitapAd.Text) ||
                    string.IsNullOrWhiteSpace(txtYazar.Text) ||
                    string.IsNullOrWhiteSpace(txtSayfa.Text) ||
                    string.IsNullOrWhiteSpace(txtRaf.Text) ||
                    string.IsNullOrWhiteSpace(txtStok.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Barkodun veritabanında mevcut olup olmadığını kontrol ediyoruz.
                if (BarkodVarMi(txtBarkod.Text))
                {
                    MessageBox.Show("Bu barkod numarası zaten mevcut. Lütfen başka bir barkod numarası girin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eğer barkod mevcut değilse, bağlantıyı açıyoruz.
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Kitabı kaydediyoruz.
                OleDbCommand komut1 = new OleDbCommand("INSERT INTO Kitaplar (Barkod, KitapAd, Yazar, SayfaSayisi, RafSayisi, StokMiktari)" +
                    " VALUES (@1, @2, @3, @4, @5, @6)", baglanti);
                komut1.Parameters.AddWithValue("@1", txtBarkod.Text);
                komut1.Parameters.AddWithValue("@2", txtKitapAd.Text);
                komut1.Parameters.AddWithValue("@3", txtYazar.Text);
                komut1.Parameters.AddWithValue("@4", txtSayfa.Text);
                komut1.Parameters.AddWithValue("@5", txtRaf.Text);
                komut1.Parameters.AddWithValue("@6", txtRaf.Text);

                komut1.ExecuteNonQuery();

                // Kullanıcıya başarı mesajı gösteriyoruz.
                MessageBox.Show("Kitabınız sisteme kaydedilmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi güncelliyoruz ve metin kutularını temizliyoruz.
                listele();
                txtSil();
            }
            catch (Exception ex)
            {
                // Hata mesajı gösteriyoruz.
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz.
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewKitaplar.SelectedCells[0].RowIndex;

            txtBarkod.Text = dataGridViewKitaplar.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridViewKitaplar.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridViewKitaplar.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridViewKitaplar.Rows[secilen].Cells[3].Value.ToString();
            txtRaf.Text = dataGridViewKitaplar.Rows[secilen].Cells[4].Value.ToString();
            txtStok.Text = dataGridViewKitaplar.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBarkod.Clear();
            txtKitapAd.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
            txtRaf.Clear();
            txtStok.Clear();
        }


        private string GenerateRandomBarcode(int length)
        {
            // Rastgele sayı üretmek için bir Random nesnesi oluşturun.
            Random rand = new Random();
            // Oluşturulan barkodu depolamak için bir StringBuilder nesnesi oluşturun.
            StringBuilder result = new StringBuilder(length);

            // Belirtilen uzunlukta rastgele bir barkod oluşturun.
            for (int i = 0; i < length; i++)
            {
                result.Append(rand.Next(2)); // 0 veya 1 ekle
            }

            // Oluşturulan barkodu bir string olarak döndürün.
            return result.ToString();
        }


        // Veritabanında belirtilen barkodun mevcut olup olmadığını kontrol eden metod.
        private bool BarkodVarMi(string barkod)
        {
            // Veritabanında belirtilen barkodu aramak için sorguyu hazırlayın.
            string query = "SELECT COUNT(*) FROM Kitaplar WHERE Barkod = ?";

            // Parametrelerle birlikte sorguyu yürütün.
            using (OleDbCommand command = new OleDbCommand(query, baglanti))
            {
                command.Parameters.AddWithValue("?", barkod);
                try
                {
                    // Bağlantıyı açıyoruz.
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                    // Sorguyu yürütüyoruz ve sonuçları alıyoruz.
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Barkod varsa true, yoksa false döndürür.
                }
                catch (Exception ex)
                {
                    // Hata durumunda bir iletişim kutusuyla kullanıcıya bilgi verin.
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Hata durumunda false döndürür.
                }
                finally
                {   
                    // Bağlantıyı kapatın.
                    if (baglanti.State == ConnectionState.Open) baglanti.Close();
                }
            }
        }



        private void btnBarkod_Click(object sender, EventArgs e)
        {
            // Barkod uzunluğunu belirledik
            int length = 8;

            // Benzersiz bir barkod oluşturana kadar devam et
            string randomBarcode;
            do
            {
                randomBarcode = GenerateRandomBarcode(length);
            } while (BarkodVarMi(randomBarcode));

            // Oluşturulan benzersiz barkodu metin kutusuna yaz
            txtBarkod.Text = randomBarcode;
        }       
    }
}
