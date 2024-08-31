using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;

namespace reglTakvimi
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            // Değişkenleri tanımladım.
            string ad = txtAd.Text.ToLower();
            string soyad = txtSoyad.Text.ToLower();
            string mail = txtMail.Text.ToLower();
            string sifre = txtSifre.Text;
            int yas = 0;
            string cinsiyet = "";
            if (radioErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (radioKadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            else if (radioNull.Checked)
            {
                cinsiyet = "Belirsiz";
            }
            else
            {
                MessageBox.Show("Cinsiyet seçeneği boş bırakılamaz. Lütfen bir seçim yapın.");
            }

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(sifre) || yas == 0 || cinsiyet == "")
            {
                MessageBox.Show("Kutucuklar boş bırakılamaz. Lütfen tüm kutucukları doldurun.");
                return;
            }

            if (mail.Length > 32)
            {
                MessageBox.Show("E-posta adresiniz 32 karakterden daha uzun olamaz.");
                return;
            }
            else if (mail.Length <= 3)
            {
                MessageBox.Show("E-posta adresiniz 4 karakterden daha kısa olamaz.");
                return;
            }

            if (sifre.Length > 32)
            {
                MessageBox.Show("Şifreniz 32 karakterden daha uzun olamaz.");
                return;
            }
            else if (sifre.Length <= 6)
            {
                MessageBox.Show("Şifreniz 6 karakterden daha kısa olamaz.");
                return;
            }
            DateTime dogumTarihi = dateDogum.Value.Date;
            yas = DateTime.Now.Year - dogumTarihi.Year;
            if (yas < 0)
            {
                MessageBox.Show("Geçersiz bir doğum tarihi girdiniz. Lütfen tekrar deneyin.");
                return;
            }
            else if (yas < 10)
            {
                MessageBox.Show("10 Yaşından küçük olduğunuz için uygulamayı kullanamazsınız. Uygulamadan çıkış yapılıyor...");
                Application.Exit();
            }

            if (DateTime.Now.Date < dogumTarihi.AddYears(yas))
            {
                yas--;
            }

            // Kullanıcı mail adresinin veritabanında olup olmadığını sorgulama işlemi.
            string veritabani = "Server=localhost\\SQLEXPRESS;Database=reglTakvimi;Trusted_Connection=True;";

            string sorgu0 = "SELECT COUNT(*) FROM uyeBilgileri WHERE mail = @mail";

            using (SqlConnection baglanti0 = new SqlConnection(veritabani))
            {
                SqlCommand command0 = new SqlCommand(sorgu0, baglanti0);

                command0.Parameters.AddWithValue("@mail", mail);
                try
                {
                    baglanti0.Open();
                    int sonuc0 = (int)command0.ExecuteScalar();
                    if (sonuc0 > 0)
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kayıtlı, lütfen başka bir e-posta adresi deneyin.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata meydana geldi: " + ex.Message);
                    return;
                }
            }

            // Eğer kullanıcı maili veritabanında yok ise kullanıcının verilerini veritabanına ekleme işlemi.
            string sorgu1 = "INSERT INTO uyeBilgileri (ad, soyad, mail, cinsiyet, yas, sifre) VALUES (@ad, @soyad, @mail, @cinsiyet, @yas, @sifre)";

            using (SqlConnection baglanti1 = new SqlConnection(veritabani))
            {
                SqlCommand command1 = new SqlCommand(sorgu1, baglanti1);

                command1.Parameters.AddWithValue("@ad", ad);
                command1.Parameters.AddWithValue("@soyad", soyad);
                command1.Parameters.AddWithValue("@mail", mail);
                command1.Parameters.AddWithValue("@yas", yas);
                command1.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                command1.Parameters.AddWithValue("@sifre", sifre);
                try
                {
                    baglanti1.Open();
                    int sonuc1 = command1.ExecuteNonQuery();
                    if (sonuc1 > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla tamamlandı, giriş sayfasına yönlendiriliyorsunuz.");
                        giris giris = new giris();
                        giris.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi sırasında bir sorunla karşılaşıldı. Lütfen tekrar kayıt olmayı deneyin.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata meydana geldi: " + ex.Message);
                    return;
                }
            }
        }

        private void kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
