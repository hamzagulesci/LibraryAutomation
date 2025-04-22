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
    public partial class EmanetVer : Form
    {
        public EmanetVer()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Kutuphane.mdb");
        DataTable tableMember = new DataTable();
        DataTable tableBook = new DataTable();
        DataView dataView = new DataView();

        void listeleMember()
        {
            try
            {
                if (baglanti == null) baglanti.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From Member", baglanti);
                da.Fill(dt);
                dgwMember.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        void listeleBook()
        {
            try
            {
                if (baglanti == null) baglanti.Open();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", baglanti);
                da.Fill(dt);
                dgwBook.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void EmanetVer_Load(object sender, EventArgs e)
        {
            dtpSubmissionDate.MinDate = DateTime.Today;
            baglanti.Open();

            // Üye tablosunu doldur ve DataGridView'e bağla
            tableMember.Clear();
            OleDbDataAdapter adrMember = new OleDbDataAdapter("SELECT * FROM member ORDER BY isim", baglanti);
            adrMember.Fill(tableMember);
            dgwMember.DataSource = tableMember;
            dgwMember.Columns["Kimlik"].HeaderText = "TC Kimlik No";
            dgwMember.Columns["isim"].HeaderText = "İsim";
            dgwMember.Columns["soyisim"].HeaderText = "Soyisim";

            // Kitap tablosunu doldur ve DataGridView'e bağla
            tableBook.Clear();
            OleDbDataAdapter adrBook = new OleDbDataAdapter("SELECT * FROM Kitaplar ORDER BY kitapAd", baglanti);
            adrBook.Fill(tableBook);
            dgwBook.DataSource = tableBook;
            dgwBook.Columns["Barkod"].HeaderText = "Barkod No";
            dgwBook.Columns["kitapAd"].HeaderText = "Kitap Adı";
            dgwBook.Columns["Yazar"].HeaderText = "Yazarı";
            dgwBook.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
            dgwBook.Columns["RafSayisi"].HeaderText = "Raf Sayısı";
            dgwBook.Columns["StokMiktari"].HeaderText = "Stok Sayısı";


            baglanti.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Seçilen kitabın stok miktarını kontrol et
                int stokMiktari = Convert.ToInt32(dgwBook.CurrentRow.Cells["StokMiktari"].Value);
                if (stokMiktari <= 0)
                {
                    MessageBox.Show("Seçilen kitap stokta kalmamıştır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Stok miktarı azalt
                stokMiktari--;

                // Kitap stok miktarını güncelle
                string barkod = dgwBook.CurrentRow.Cells["Barkod"].Value.ToString();
                OleDbCommand updateStokCommand = new OleDbCommand("UPDATE Kitaplar SET StokMiktari = @StokMiktari WHERE Barkod = @barkod", baglanti);
                updateStokCommand.Parameters.AddWithValue("@stokMiktari", stokMiktari);
                updateStokCommand.Parameters.AddWithValue("@barkod", barkod);
                updateStokCommand.ExecuteNonQuery();

                // Emanet verme işlemi
                OleDbCommand com = new OleDbCommand("INSERT INTO EmanetVer (Kimlik, isim, soyisim, Barkod, kitapAd, Yazar, SayfaSayisi, RafSayisi, VerilenTarih, TeslimTarihi)" +
                " VALUES (@Kimlik, @isim, @soyisim, @Barkod, @kitapAd, @Yazar, @SayfaSayisi, @RafSayisi, @VerilenTarih, @TeslimTarihi)", baglanti);

                com.Parameters.AddWithValue("@Kimlik", dgwMember.CurrentRow.Cells["Kimlik"].Value.ToString());
                com.Parameters.AddWithValue("@isim", dgwMember.CurrentRow.Cells["isim"].Value.ToString());
                com.Parameters.AddWithValue("@soyisim", dgwMember.CurrentRow.Cells["soyisim"].Value.ToString());

                com.Parameters.AddWithValue("@Barkod", dgwBook.CurrentRow.Cells["Barkod"].Value.ToString());
                com.Parameters.AddWithValue("@kitapAd", dgwBook.CurrentRow.Cells["kitapAd"].Value.ToString());
                com.Parameters.AddWithValue("@Yazar", dgwBook.CurrentRow.Cells["Yazar"].Value.ToString());
                com.Parameters.AddWithValue("@SayfaSayisi", dgwBook.CurrentRow.Cells["SayfaSayisi"].Value.ToString());
                com.Parameters.AddWithValue("@RafSayisi", dgwBook.CurrentRow.Cells["RafSayisi"].Value.ToString());
                com.Parameters.AddWithValue("@VerilenTarih", dtpIssueDate.Value.ToString());
                com.Parameters.AddWithValue("@TeslimTarihi", dtpSubmissionDate.Value.ToString());

                com.ExecuteNonQuery();
                MessageBox.Show("Kitap emanet işlemi başarılı bir şekilde gerçekleşti.");
                listeleBook();
                listeleMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgileri kontrol edin! Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void txtSearchIdNo_TextChanged(object sender, EventArgs e)
        {
            dataView = tableMember.DefaultView;
            dataView.RowFilter = "Kimlik LIKE '%" + txtSearchIdNo.Text + "%'";
            dgwMember.DataSource = dataView;
        }

        private void txtSearchBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            dataView = tableBook.DefaultView;
            dataView.RowFilter = "Barkod LIKE '%" + txtSearchBarcodeNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listeleBook();
            listeleMember();
        }
    }
}
