using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        private void kullanıcıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciListesi ekle = new KullaniciListesi();
            ekle.MdiParent = this;
            ekle.Show();
        }
        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                KitapKaydetme ekle = new KitapKaydetme();
                ekle.MdiParent = this;
                ekle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu" + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapArama ekle = new KitapArama();
            ekle.MdiParent = this;
            ekle.Show();
        }
        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                KitapListeleme ekle = new KitapListeleme();
                ekle.MdiParent = this;
                ekle.Show();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu" + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void güncelllemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapGuncelleme ekle = new KitapGuncelleme();
            ekle.MdiParent = this;
            ekle.Show();
        }
        private void silmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapSilme ekle = new KitapSilme();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void emanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetAl ekle = new EmanetAl();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void emanetVerilenKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetVerilenKitaplar ekle = new EmanetVerilenKitaplar();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void emanetVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetVer ekle = new EmanetVer();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanicilar ekle = new Kullanicilar();
            ekle.MdiParent = this;
            ekle.Show();
        }
    }
}
