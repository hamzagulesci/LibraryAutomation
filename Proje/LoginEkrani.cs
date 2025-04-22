using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Proje
{
    public partial class LoginEkrani : Form
    {
        public LoginEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string yetki;

        private void lblHesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                HesapOlusturma ekle = new HesapOlusturma();
                ekle.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu" + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");
                return;
            }

            string kullaniciadi = txtUserName.Text;
            string sifre = txtPassword.Text;

            // Veri tabanımızı bağladık
            using (OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.mdb;"))
            {
                try
                {
                    // Bağlantıyı aç
                    baglanti.Open();

                    // Access sorgusu ile kullanıcıyı veritabanından kontrol et
                    using (OleDbCommand giris = new OleDbCommand("SELECT * FROM Kullanicilar WHERE kullaniciadi=@kullaniciadi AND sifre=@sifre", baglanti))
                    {
                        giris.Parameters.AddWithValue("kullaniciadi", kullaniciadi);
                        giris.Parameters.AddWithValue("sifre", sifre);

                        // Sorguyu çalıştır ve sonuçları oku
                        using (OleDbDataReader oku = giris.ExecuteReader())
                        {
                            if (oku.Read())
                            {
                                // Kullanıcı bulundu, yetkiyi kontrol et
                                string kullaniciAdi = oku["kullaniciadi"].ToString();
                                string yetki = oku["yetki"].ToString(); // Yetki değerini veritabanından al

                                if (yetki == "2")
                                {
                                    // Yetki 2 ise admin paneline yönlendir
                                    AdminPaneli form3 = new AdminPaneli();
                                    form3.Show();
                                    this.Hide();
                                    MessageBox.Show($"Hoşgeldiniz, {kullaniciAdi}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    // Değilse anaforma yönlendir
                                    AnaSayfa ekle = new AnaSayfa();
                                    ekle.Show();
                                    this.Hide();
                                    MessageBox.Show($"Hoşgeldiniz, {kullaniciAdi}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                // Kullanıcı bulunamadı, giriş başarısız
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Kullanıcı adı")
                txtUserName.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Şifre")
                txtPassword.Text = "";
        }
       
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Caps Lock tuşu açıksa ve kullanıcı büyük harf girmeye başlarsa uyarı ver
            if ((Control.IsKeyLocked(Keys.CapsLock)) && ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)))
            {
                MessageBox.Show("Caps Lock tuşu açık. Büyük harf kullanıyorsunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void CheckCapsLock()
        {
            // Caps Lock durumunu kontrol et
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                // Caps Lock açıksa
                MessageBox.Show("Caps Lock açık!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }    

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            // Caps Lock durumunu kontrol et
            CheckCapsLock();
        }
    }
}
