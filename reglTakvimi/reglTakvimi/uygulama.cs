using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reglTakvimi
{
    public partial class uygulama : Form
    {
        // Kullanıcı kontrolü için veritabanından veri çekmemiz gerekecek. Bu yüzden kullanıcının giriş yaptığı mail adresini Giriş formundan çekmeye yarıyor.
        private string mail = giris.mail;

        public uygulama()
        {
            InitializeComponent();
            reglYukle();
        }

        private void reglYukle()
        {
            cboxRegl.Items.Clear();

            string veritabani = "Server=localhost\\SQLEXPRESS;Database=reglTakvimi;Trusted_Connection=True;";
            string sorgu = "SELECT tarih FROM reglBilgileri WHERE mail = @mail";
            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@mail", mail);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cboxRegl.Items.Add(reader["tarih"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                    return;
                }
            }
        }

        private bool isDefaultText = true;

        private void clistSemptom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReglGir_Click(object sender, EventArgs e)
        {
            // Değişkenleri atıyorum.
            calendar.MaxSelectionCount = 1;
            DateTime date = calendar.SelectionStart.Date;
            string tarih = date.ToShortDateString();
            if (date.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Gelecek bir dönem için regl girişi yapamazsınız.");
                return;
            }
            else if (date.Date.AddMonths(1) < DateTime.Now.Date)
            {
                MessageBox.Show("En fazla 1 ay önceki süre kadarıyla regl girişi yapabilirsiniz.");
                return;
            }
            string semptomlar = string.Join(", ", clistSemptom.CheckedItems.Cast<string>().ToArray());
            string not = rtxtNotEkle.Text;

            // Veritabanı işlemleri.
            string veritabani = "Server=localhost\\SQLEXPRESS;Database=reglTakvimi;Trusted_Connection=True;";

            // Kullanıcı aynı tarihte regl girişi yapmışmı sorgulama işlemi.

            string sorgu0 = "SELECT COUNT(*) FROM reglBilgileri WHERE mail = @mail AND tarih = @tarih";

            using (SqlConnection baglanti0 = new SqlConnection(veritabani))
            {
                SqlCommand command0 = new SqlCommand(sorgu0, baglanti0);

                command0.Parameters.AddWithValue("@mail", mail);
                command0.Parameters.AddWithValue("@tarih", tarih);
                try
                {
                    baglanti0.Open();
                    int sonuc0 = (int)command0.ExecuteScalar();
                    if (sonuc0 > 0)
                    {
                        MessageBox.Show("Aynı tarihte regl girişiniz bulunmaktadır.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata meydana geldi: " + ex.Message);
                    return;
                }
            }

            // Eğer kullanıcı aynı tarihte regl girişi yapmamış ise girişi veritabanına işleme.
            string sorgu1 = "INSERT INTO reglBilgileri (mail, tarih, reglNot, semptomlar) VALUES (@mail, @tarih, @reglNot, @semptomlar)";

            using (SqlConnection baglanti1 = new SqlConnection(veritabani))
            {
                SqlCommand command1 = new SqlCommand(sorgu1, baglanti1);

                command1.Parameters.AddWithValue("@mail", mail);
                command1.Parameters.AddWithValue("@tarih", tarih);
                command1.Parameters.AddWithValue("@reglNot", not);
                command1.Parameters.AddWithValue("@semptomlar", semptomlar);
                try
                {
                    baglanti1.Open();
                    int sonuc1 = command1.ExecuteNonQuery();
                    if (sonuc1 > 0)
                    {
                        MessageBox.Show("Regl girişi başarıyla oluşturuldu!");
                        reglYukle();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Regl girişi başarısız oldu, lütfen tekrar deneyin.");
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

        private void rtxtNotEkle_TextChanged_1(object sender, EventArgs e)
        {
            if (isDefaultText)
            {
                if (!string.IsNullOrEmpty(rtxtNotEkle.Text) && rtxtNotEkle.Text != "Not ekle (opsiyonel):")
                {
                    rtxtNotEkle.Text = rtxtNotEkle.Text.Substring(rtxtNotEkle.Text.Length - 1);
                    isDefaultText = false;
                    rtxtNotEkle.SelectionStart = rtxtNotEkle.Text.Length;
                }
            }
        }

        private void btnReglGor_Click(object sender, EventArgs e)
        {
            string tarih = cboxRegl.SelectedItem.ToString();
            rtxtSemptomlar.Text = "";
            rtxtNot.Text = "";

            string veritabani = "Server=localhost\\SQLEXPRESS;Database=reglTakvimi;Trusted_Connection=True;";
            string sorgu = "SELECT reglNot, semptomlar FROM reglBilgileri WHERE mail = @mail AND tarih = @tarih";
            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@tarih", tarih);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rtxtNot.Text = reader["reglNot"].ToString();
                        rtxtSemptomlar.Text = reader["semptomlar"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                    return;
                }
            }
        }

        private void uygulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}