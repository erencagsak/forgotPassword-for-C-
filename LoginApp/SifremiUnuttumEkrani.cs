using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace LoginApp
{
    public partial class SifremiUnuttumEkrani : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-39MGUSN\\MYSQLSERVER;Initial Catalog=C#Loginekrani;Integrated Security=True");

        public SifremiUnuttumEkrani()
        {
            InitializeComponent();
        }
        private void anaEkranaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void radioBox_TelNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioBox_TelNo.Checked == true)
            {
                radioBox_TelNo.ForeColor = Color.Red;
            }
            else
            {
                radioBox_TelNo.ForeColor = Color.Black;
            }
        }

        private void anaEkranaDon_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void btn_sifreGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM kullanicilar", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            if(oku.Read())
            {
                String gonderilecekKullaniciAdi = oku["kullaniciAdi"].ToString();
                String gonderilecekMail = oku["kullaniciMail"].ToString();
                String pass = oku["kullaniciSifre"].ToString();

                if (girilenMail.Text == gonderilecekMail && girilenKullaniciAdi.Text == gonderilecekKullaniciAdi)
                {
                    MailMessage mail = new MailMessage("trendiolapp@gmail.com", gonderilecekMail);

                    mail.Subject = "TrendiolApp | Şifremi Unuttum";
                    mail.Body = "Şifreniz : " + pass;

                    SmtpClient server = new SmtpClient();
                    server.Host = "smtp.gmail.com";
                    server.Port = 587;
                    server.Credentials = new System.Net.NetworkCredential("trendiolapp@gmail.com", "oapzpwirvwdqzwhx");
                    server.EnableSsl = true;
                    server.Send(mail);
                    object userState = true;

                    MessageBox.Show("Şifreniz başarıyla gönderildi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya mail adresiniz yanlış.\nLütfen kontrol ediniz.");
                }
            }

            baglanti.Close();
        }

        private void radioBox_Mail_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioBox_Mail.Checked == true)
            {
                radioBox_Mail.ForeColor = Color.Red;
            }
            else
            {
                radioBox_Mail.ForeColor = Color.Black;
            }
        }
    }
}