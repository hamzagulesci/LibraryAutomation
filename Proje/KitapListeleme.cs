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
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
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
        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void ButtonListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
