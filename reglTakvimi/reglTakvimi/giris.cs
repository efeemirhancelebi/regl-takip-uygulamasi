using System.Data.SqlClient;

namespace reglTakvimi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        public static string mail;

        private void btnKayit_Click(object sender, EventArgs e)
        {
            kayit kayit = new kayit();
            kayit.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan verileri alma.
            mail = txtMail.Text.ToLower();
            string sifre = txtSifre.Text;

            // Verilerin veritabanında olup olmadığını sorgulama.
            string veritabani = "Server=localhost\\SQLEXPRESS;Database=reglTakvimi;Trusted_Connection=True;";

            string sorgu = "SELECT COUNT(*) FROM uyeBilgileri WHERE mail = @mail AND sifre = @sifre";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);

                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@sifre", sifre);
                try
                {
                    baglanti.Open();
                    int sonuc = (int)command.ExecuteScalar();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Giriş başarılı, uygulamaya aktarılıyorsunuz...");
                        uygulama uygulama = new uygulama();
                        uygulama.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("E-posta adresiniz veya şifreniz hatalı, lütfen kontrol edip tekrar giriş yapmayı deneyin.");
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

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
