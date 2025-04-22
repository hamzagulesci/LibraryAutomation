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
    public partial class KitapGuncelleme : Form
    {
        public KitapGuncelleme()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:Kutuphane.mdb;");

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
            txtKitapAd.Clear();
            txtKitapSayfa.Clear();
            txtStok.Clear();
            txtKitapYazar.Clear();
            txtBarkod.Clear();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitapAd.Text) || string.IsNullOrWhiteSpace(txtKitapSayfa.Text)
                || string.IsNullOrWhiteSpace(txtStok.Text) || string.IsNullOrWhiteSpace(txtKitapYazar.Text)
                || string.IsNullOrWhiteSpace(txtBarkod.Text) || string.IsNullOrWhiteSpace(txtRaf.Text)
                || string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Lütfen boş kutu bırakmadan yazınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Kitaplar set Barkod=@p1,KitapAd=@p2,Yazar=@p3,SayfaSayisi=@p4,RafSayisi=@5,StokMiktari=@6 where Barkod=@p1"
                , baglanti);
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
            komut.Parameters.AddWithValue("@p2", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p3", txtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p4", txtKitapSayfa.Text);
            komut.Parameters.AddWithValue("@p5", txtRaf.Text);     
            komut.Parameters.AddWithValue("@p6", txtStok.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtSil();
        }

        private void KitapGuncelleme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewKitaplar.SelectedCells[0].RowIndex;

            txtBarkod.Text = dataGridViewKitaplar.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridViewKitaplar.Rows[secilen].Cells[1].Value.ToString();
            txtKitapYazar.Text = dataGridViewKitaplar.Rows[secilen].Cells[2].Value.ToString();
            txtKitapSayfa.Text = dataGridViewKitaplar.Rows[secilen].Cells[3].Value.ToString();
            txtRaf.Text = dataGridViewKitaplar.Rows[secilen].Cells[4].Value.ToString();
            txtStok.Text = dataGridViewKitaplar.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
