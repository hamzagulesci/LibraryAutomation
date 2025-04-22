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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class HesapOlusturma : Form
    {
        public HesapOlusturma()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Kutuphane.mdb");


        void txtSil()
        {
            txtKullaniciAdi.Text = "";
            txtCevap.Text = "";
            txtSifre.Text = "";
            txtTekrarSifre.Text = "";
        }


        // Rastgele bir 11 haneli sayı oluşturmak için kullanılacak rastgele sayı oluşturucusu
        Random random = new Random();
        // Ve rastgele 11 haneli sayı oluşturma fonksiyonu
        private string GenerateRandomNumber()
        {
            string randomNumber = random.Next(1000000, 9999999).ToString() + random.Next(0, 9999).ToString("D4");
            return randomNumber;
        }


        // Veritabanında belirtilen kimlik numarasının mevcut olup olmadığını kontrol eden fonksiyon
        private bool CheckIdentityExists(string identity)
        {
            try
            {
                baglanti.Open();
                OleDbCommand com = new OleDbCommand("SELECT COUNT(*) FROM Kullanicilar WHERE kimlik = @identity", baglanti);
                com.Parameters.AddWithValue("@identity", identity);
                int count = Convert.ToInt32(com.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                // Hata yönetimi burada ele alınabilir
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }


        public int checkUsername(string username)
        {
            int result = 0;
            try
            {
                baglanti.Open();
                OleDbCommand com = new OleDbCommand("SELECT COUNT(Username) FROM Kullanicilar WHERE kullanciadi = @username", baglanti);
                com.Parameters.AddWithValue("@username", username);
                result = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                // Hata yönetimi burada ele alınabilir
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            return result;
        }
        private void lblOturumAc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginEkrani form1 = new LoginEkrani();
            form1.Show();
            this.Hide();
        }

        private bool IsPasswordStrong(string password)
        {
            // Şifre güçlülüğünü kontrol etmek için gerekli kriterler
            int minLength = 8;
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            // Şifrenin uzunluğunu kontrol et
            if (password.Length < minLength)
            {
                return false;
            }

            // Şifrede büyük harf, küçük harf ve rakam olup olmadığını kontrol et
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }

            // Tüm kriterlerin karşılandığını kontrol et
            return hasUpperCase && hasLowerCase && hasDigit;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsPasswordStrong(txtSifre.Text))
                {
                    MessageBox.Show("Şifre güçlü değil. En az 8 karakter uzunluğunda olmalı ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtSifre.Text != txtTekrarSifre.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) ||
                    string.IsNullOrWhiteSpace(txtCevap.Text) || cmboxQuestion.SelectedIndex == 0 ||
                    string.IsNullOrWhiteSpace(txtİsim.Text) || string.IsNullOrWhiteSpace(txtSoyisim.Text))
                {
                    MessageBox.Show("Lütfen boş alan bırakmadığınızdan ve güvenlik sorusu seçtiğinizden emin olun!");
                }
                else
                {

                    // Rastgele bir kimlik oluşturun ve var olmadığından emin olun
                    string kimlik;
                    do
                    {
                        kimlik = GenerateRandomNumber();
                    } while (CheckIdentityExists(kimlik));

                    // Kullanıcı adının veritabanında mevcut olup olmadığını kontrol edin
                    if (checkUsername(txtKullaniciAdi.Text) != 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı başkası tarafından kullanılıyor!");
                    }
                    else
                    {
                        // Güvenlik sorusunu seçtiklerini kontrol et
                        if (string.IsNullOrWhiteSpace(txtCevap.Text) || cmboxQuestion.SelectedIndex == -1)
                        {
                            MessageBox.Show("Lütfen bir güvenlik sorusu seçip cevaplayın!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Yeni kullanıcı bilgilerini veritabanına ekleyin
                        baglanti.Open();
                        OleDbCommand kmt = new OleDbCommand();
                        kmt.Connection = baglanti;
                        kmt.CommandText = "INSERT INTO Kullanicilar (kimlik, kullaniciadi, isim, soyisim, sifre, yetki, guvenliksorusu, guvenlikcevabi) " +
                                          "VALUES (@kimlik, @username, @isim, @soyisim, @sifre, @yetki, @soru, @cevap)";
                        kmt.Parameters.AddWithValue("@kimlik", kimlik);
                        kmt.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
                        kmt.Parameters.AddWithValue("@isim", txtİsim.Text);
                        kmt.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                        kmt.Parameters.AddWithValue("@sifre", txtSifre.Text);
                        kmt.Parameters.AddWithValue("@yetki", "standart");
                        kmt.Parameters.AddWithValue("@soru", cmboxQuestion.SelectedItem.ToString());
                        kmt.Parameters.AddWithValue("@cevap", txtCevap.Text);
                        kmt.ExecuteNonQuery();
                        baglanti.Close();

                        // Yeni üye bilgilerini "member" tablosuna da ekleyin
                        baglanti.Open();
                        OleDbCommand kmtMember = new OleDbCommand();
                        kmtMember.Connection = baglanti;
                        kmtMember.CommandText = "INSERT INTO member (kimlik, isim, soyisim) VALUES (@kimlik, @isim, @soyisim)";
                        kmtMember.Parameters.AddWithValue("@kimlik", kimlik);
                        kmtMember.Parameters.AddWithValue("@isim", txtİsim.Text);
                        kmtMember.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                        kmtMember.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Hesabınız başarıyla oluşturuldu, istediğiniz bir kitapla yetkili birinin yanına gidiniz.","BİLGİ", MessageBoxButtons.OK,MessageBoxIcon.Information);

                        LoginEkrani ekle = new LoginEkrani();
                        ekle.Show();
                        this.Hide();

                        // Formdaki giriş alanlarını temizleyin
                        txtSil();
                        cmboxQuestion.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesap oluşturulurken bir hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HesapOlusturma_Load(object sender, EventArgs e)
        {
            cmboxQuestion.SelectedIndex=0;
            lblCapsLock.Visible = false;
        }

        private void CheckPasswordStrength(string password)
        {
            int score = 0;

            // Şifre uzunluğunu kontrol et
            if (password.Length >= 8)
            {
                score++;
            }

            // Büyük harf kontrolü
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                score++;
            }

            // Küçük harf kontrolü
            if (Regex.IsMatch(password, "[a-z]"))
            {
                score++;
            }

            // Rakam kontrolü
            if (Regex.IsMatch(password, "[0-9]"))
            {
                score++;
            }

            // Özel karakter kontrolü
            if (Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                score++;
            }

            // Şifre güçlülüğünü belirle ve label'e yaz
            switch (score)
            {
                case 0:
                case 1:
                case 2:
                    
                case 3:
                    lblPasswordStrength.Text = "Zayıf";
                    lblPasswordStrength.ForeColor = Color.Red;
                    break;
                case 4:
                    lblPasswordStrength.Text = "Orta";
                    lblPasswordStrength.ForeColor = Color.Orange;
                    break;
                case 5:
                    lblPasswordStrength.Text = "Güçlü";
                    lblPasswordStrength.ForeColor = Color.Green;
                    break;
            }

        }
        private void CheckCapsLock()
        {
            // Caps Lock durumunu kontrol et
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                // Caps Lock açıksa
                lblCapsLock.Visible = true;
            }
            else
            {
                lblCapsLock.Visible = false;
            }
        }


        private void txtSifre_OnValueChanged(object sender, EventArgs e)
        {
            CheckPasswordStrength(txtSifre.Text);
            CheckCapsLock();
        }

        private void txtTekrarSifre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            // Caps Lock tuşu açıksa ve kullanıcı büyük harf girmeye başlarsa uyarı ver
            if ((Control.IsKeyLocked(Keys.CapsLock)) && ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)))
            {
                MessageBox.Show("Caps Lock tuşu açık. Büyük harf kullanıyorsunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Caps Lock durumunu kontrol et
            CheckCapsLock();

        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
                txtSifre.Text = "";

            // Caps Lock durumunu kontrol et
            CheckCapsLock();
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            CheckCapsLock();
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            lblCapsLock.Visible = false;
        }
    }
}