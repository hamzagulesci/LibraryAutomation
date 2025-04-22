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
    public partial class EmanetAl : Form
    {
        public EmanetAl()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Kutuphane.mdb");
        DataTable table = new DataTable();
        DataView dataView = new DataView();

        void listele()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From EmanetVer", baglanti);
                da.Fill(dt);
                dgwBook.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }


        private void EmanetAl_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                table.Clear();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM EmanetVer ORDER BY isim", baglanti);
                adapter.Fill(table);
                dgwBook.DataSource = table;
                dgwBook.Columns["Kimlik"].HeaderText = "TC Kimlik No";
                dgwBook.Columns["isim"].HeaderText = "İsim";
                dgwBook.Columns["soyisim"].HeaderText = "Soyisim";
                dgwBook.Columns["Barkod"].HeaderText = "Barkod No";
                dgwBook.Columns["Yazar"].HeaderText = "Yazarı";
                dgwBook.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
                dgwBook.Columns["RafSayisi"].HeaderText = "Raf Sayısı";
                dgwBook.Columns["VerilenTarih"].HeaderText = "Verilme Tarihi";
                dgwBook.Columns["TeslimTarihi"].HeaderText = "Teslim Tarihi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                // Emanet verilen kitabın bilgilerini veritabanından sil
                OleDbCommand com = new OleDbCommand("DELETE FROM EmanetVer WHERE Kimlik=@Kimlik AND Barkod=@Barkod", baglanti);
                com.Parameters.AddWithValue("@Kimlik", dgwBook.CurrentRow.Cells["Kimlik"].Value.ToString());
                com.Parameters.AddWithValue("@Barkod", dgwBook.CurrentRow.Cells["Barkod"].Value.ToString());
                com.ExecuteNonQuery();

                // Kitap stok miktarını artır
                OleDbCommand updateCommand = new OleDbCommand("UPDATE Kitaplar SET StokMiktari = StokMiktari + 1 WHERE Barkod = @Barkod", baglanti);
                updateCommand.Parameters.AddWithValue("@Barkod", dgwBook.CurrentRow.Cells["Barkod"].Value.ToString());
                updateCommand.ExecuteNonQuery();

                // Veritabanından kitap listesini güncelle
                table.Clear();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM EmanetVer ORDER BY isim", baglanti);
                adapter.Fill(table);
                dgwBook.DataSource = table;
                MessageBox.Show("Kitap iadesi başarılı bir şekilde gerçekleşti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgileri kontrol edin! Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                listele();
            }

        }

        private void txtSearchBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "Barkod LIKE '%" + txtSearchBarcodeNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void txtSearchIdNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "Kimlik LIKE '%" + txtSearchIdNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
