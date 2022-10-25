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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LoginApp
{
    public partial class KayitOlEkrani : Form
    {
        public KayitOlEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-39MGUSN\\MYSQLSERVER;Initial Catalog=C#Loginekrani;Integrated Security=True");

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (Box_KullaniciAdi.Text == "" || Box_KullaniciSifre.Text == "" || Box_KullaniciMail.Text == "" || Box_KullaniciTelNo.Text == "")
            {

                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }

            // ID VE PASS YABANCI KARAKTER BARINDIRIYOR.
            // MAIL @ BARINDIRMASADA KAYIT OLUNUYOR.
            // TEL NO KARAKTER BARINDIRIYOR.
            else
            {

                string kullaniciAdi = Box_KullaniciAdi.Text;
                string kullaniciSifre = Box_KullaniciSifre.Text;
                string kullaniciMail = Box_KullaniciMail.Text;
                string kullaniciTelNo = Box_KullaniciTelNo.Text;

                SqlCommand komut = new SqlCommand("SELECT * FROM kullanicilar WHERE kullaniciAdi = '" + kullaniciAdi + "' OR kullaniciMail = '" + kullaniciMail + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();


                if (oku.Read())
                {

                    MessageBox.Show("Bu kullanıcı adı veya mail kullanılıyor. Lütfen başka bir kullanıcı adı veya mail seçiniz.");
                }
                else
                {

                    oku.Close();

                    SqlCommand ekle = new SqlCommand("INSERT INTO kullanicilar(kullaniciAdi,kullaniciSifre,kullaniciMail,kullaniciTelNo) VALUES('" + kullaniciAdi + "' , '" + kullaniciSifre + "' , '" + kullaniciMail + "' , '" + kullaniciTelNo + "')", baglanti);
                    ekle.ExecuteNonQuery();

                    MessageBox.Show("Başarıyla kayıt oldunuz.");

                }
            }

            baglanti.Close();
        }

        private void anaEkranaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void KayitOlEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
