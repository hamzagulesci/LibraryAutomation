using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proje
{
    public partial class KullaniciListesi : Form
    {
        public KullaniciListesi()
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
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kullanicilar", baglanti);
                da.Fill(dt);
                dataGridViewKullanicilar.DataSource = dt;
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
            txtKimlik.Clear();
            txtKullaniciAdi.Clear();
            txtIsım.Clear();
            txtSoyisim.Clear();
            txtSifre.Clear();
            txtYetki.Clear();
            txtGuvenlikSorusu.Clear();
            txtCevap.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnBaglantiKontrol_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
                MessageBox.Show("Bağlantı var", "BAĞLANTI");
            else
                MessageBox.Show("Bağlantı yok", "BAĞLANTI");
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Silinecek kullanıcının kimliğini alın
                string Kimlik = txtKimlik.Text;

                // Eğer kullanıcı kimliği boşsa, silme işlemini gerçekleştirmeyin
                if (string.IsNullOrEmpty(Kimlik))
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcı silme işlemini gerçekleştir
                try
                {
                    // Veritabanı bağlantısını açın
                    baglanti.Open();

                    // "Kullanicilar" tablosundan silme işlemi
                    OleDbCommand cmdKullanicilar = new OleDbCommand("DELETE FROM Kullanicilar WHERE Kimlik = @Kimlik", baglanti);
                    cmdKullanicilar.Parameters.AddWithValue("@Kimlik", Kimlik);
                    int affectedRowsKullanicilar = cmdKullanicilar.ExecuteNonQuery();

                    // "member" tablosundan silme işlemi
                    OleDbCommand cmdMember = new OleDbCommand("DELETE FROM member WHERE Kimlik = @Kimlik", baglanti);
                    cmdMember.Parameters.AddWithValue("@Kimlik", Kimlik);
                    int affectedRowsMember = cmdMember.ExecuteNonQuery();

                    // Etkilenen satır sayısına göre başarılı bir silme işlemi gerçekleştirildiğini kontrol edin
                    if (affectedRowsKullanicilar > 0 || affectedRowsMember > 0)
                    {
                        // Başarılı bir şekilde silindiğini bildirin
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Silme işleminden sonra listeyi güncelle
                        listele();
                        txtSil();
                    }
                    else
                    {
                        // Eğer hiç satır etkilenmediyse, belirtilen bir kimliğe sahip kullanıcı bulunamadı veya zaten silinmiş olabilir
                        MessageBox.Show("Belirtilen kimliğe sahip kullanıcı bulunamadı veya zaten silinmiş olabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıyı bilgilendirin
                    MessageBox.Show("Kullanıcı silinirken bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Veritabanı bağlantısını kapatın
                    baglanti.Close();
                }
            }
            catch
            {

            }
        }

        private void dataGridViewKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen hücrenin satır indexini al
            int secilen = dataGridViewKullanicilar.SelectedCells[0].RowIndex;

            // Seçilen satırın hücre değerlerini TextBox'lara ata
            txtKimlik.Text = dataGridViewKullanicilar.Rows[secilen].Cells[0].Value.ToString();
            txtKullaniciAdi.Text = dataGridViewKullanicilar.Rows[secilen].Cells[1].Value.ToString();
            txtIsım.Text = dataGridViewKullanicilar.Rows[secilen].Cells[2].Value.ToString();
            txtSoyisim.Text = dataGridViewKullanicilar.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGridViewKullanicilar.Rows[secilen].Cells[4].Value.ToString();
            txtYetki.Text = dataGridViewKullanicilar.Rows[secilen].Cells[5].Value.ToString();
            txtGuvenlikSorusu.Text = dataGridViewKullanicilar.Rows[secilen].Cells[6].Value.ToString();
            txtCevap.Text = dataGridViewKullanicilar.Rows[secilen].Cells[7].Value.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYetki.Text) || string.IsNullOrWhiteSpace(txtKimlik.Text)
                || string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen boş kutu bırakmadan yazınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Kullanicilar set kimlik=@p1,kullaniciadi=@p2,isim=@p3,soyisim=@p4,sifre=@p5,yetki=@p6", baglanti);
            komut.Parameters.AddWithValue("@1", txtKimlik.Text);
            komut.Parameters.AddWithValue("@2", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@3", txtIsım.Text);
            komut.Parameters.AddWithValue("@4", txtSoyisim.Text);
            komut.Parameters.AddWithValue("@5", txtSifre.Text);
            komut.Parameters.AddWithValue("@6", txtYetki.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcının bilgileri başarıyla güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtSil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("insert into Kullanicilar (Kimlik,Kullaniciadi,isim,soyisim,Sifre,Yetki) values(@1,@2,@3,@4,@5,@6)", baglanti);
                komut1.Parameters.AddWithValue("@1", txtKimlik.Text);
                komut1.Parameters.AddWithValue("@2", txtKullaniciAdi.Text);
                komut1.Parameters.AddWithValue("@3", txtIsım.Text);
                komut1.Parameters.AddWithValue("@4", txtSoyisim.Text);
                komut1.Parameters.AddWithValue("@5", txtSifre.Text);
                komut1.Parameters.AddWithValue("@6", txtYetki.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı sisteme kaydedilmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                txtSil();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu" + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
    }
}
