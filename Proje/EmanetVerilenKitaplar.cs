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
    public partial class EmanetVerilenKitaplar : Form
    {
        public EmanetVerilenKitaplar()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Kutuphane.mdb");
        DataTable table = new DataTable();
        DataView dataView = new DataView();

        private void EmanetVerilenKitaplar_Load(object sender, EventArgs e)
        {
            cmboxSelection.SelectedIndex = 0;
            baglanti.Open();
            table.Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM EmanetVer ORDER BY isim", baglanti);
            adapter.Fill(table);
            dgwBook.DataSource = table;
            dgwBook.Columns["Kimlik"].HeaderText = "Kimlik";
            dgwBook.Columns["isim"].HeaderText = "İsim";
            dgwBook.Columns["soyisim"].HeaderText = "Soyisim";
            dgwBook.Columns["Barkod"].HeaderText = "Barkod No";
            dgwBook.Columns["KitapAd"].HeaderText = "Kitap Ad";
            dgwBook.Columns["Yazar"].HeaderText = "Yazarı";
            dgwBook.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
            dgwBook.Columns["RafSayisi"].HeaderText = "Raf Sayısı";
           // dgwBook.Columns["VerilenTarih"].HeaderText = "Verilme Tarihi";
           // dgwBook.Columns["TeslimTarihi"].HeaderText = "Teslim Tarihi";
            dgwBook.Columns["VerilenTarih"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgwBook.Columns["TeslimTarihi"].DefaultCellStyle.Format = "dd/MM/yyyy";

            ((DataGridViewTextBoxColumn)dgwBook.Columns["VerilenTarih"]).ValueType = typeof(DateTime);
            ((DataGridViewTextBoxColumn)dgwBook.Columns["TeslimTarihi"]).ValueType = typeof(DateTime);

            baglanti.Close();

        }

        private void txtSearchBookTitle_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "KitapAd LIKE '%" + txtSearchBookTitle.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "isim LIKE '%" + txtSearchName.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void cmboxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            table.Clear();
            if (cmboxSelection.SelectedIndex == 0)
            {
                // Tüm kitapları listele
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM EmanetVer ORDER BY KitapAd", baglanti);
                adapter.Fill(table);
                dgwBook.DataSource = table;
            }
            else if (cmboxSelection.SelectedIndex == 1)
            {
                // Geciken kitapları listele
                string query = "SELECT * FROM EmanetVer WHERE TeslimTarihi < Date() ORDER BY KitapAd";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, baglanti);
                adapter.Fill(table);
                dgwBook.DataSource = table;
            }
            else if (cmboxSelection.SelectedIndex == 2)
            {
                // Gecikmeyen kitapları listele
                string query = "SELECT * FROM EmanetVer WHERE TeslimTarihi >= Date() ORDER BY KitapAd";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, baglanti);
                adapter.Fill(table);
                dgwBook.DataSource = table;
            }
        }
    }
}
