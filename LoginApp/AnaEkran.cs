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

namespace LoginApp
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();

            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-39MGUSN\\MYSQLSERVER;Initial Catalog=C#Loginekrani;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "" || txtBox2.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            else
            {

                baglanti.Open();

                string kullaniciAdi = txtBox1.Text;
                string kullaniciSifre = txtBox2.Text;

                SqlCommand komut = new SqlCommand(@"SELECT * FROM kullanicilar WHERE kullaniciAdi = '" + kullaniciAdi + "' AND kullaniciSifre = '" + kullaniciSifre + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    MessageBox.Show("Hoşgeldiniz " + kullaniciAdi + "");

                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.");
                }

                baglanti.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Gerçekten uygulamadan çıkmak istiyor musun?", "TrendiolAPP" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }

            }

        private void kayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            KayitOlEkrani kayitOlEkrani = new KayitOlEkrani();
            kayitOlEkrani.Show();
        }

        private void sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifremiUnuttumEkrani sifreUnuttumPaneli = new SifremiUnuttumEkrani();
            sifreUnuttumPaneli.Show();
        }
    }
}
