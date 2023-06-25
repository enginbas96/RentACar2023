using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCryptNet = BCrypt.Net.BCrypt;
using MySql.Data.MySqlClient;
using BCrypt.Net;


namespace RentACar2023
{
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }
        private void GirisYapButton_Click(object sender, EventArgs e)
        {
            if (GirisYapKullaniciAdiTextBox.Text == "" || GirisYapSifreTextBox.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurup tekrar deneyiniz.");
            }
            else 
            {
                string gelenSifre = GirisYapSifreTextBox.Text;
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" + GirisYapKullaniciAdiTextBox.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read())
                {
                    string hashedPasswordFromDB = tara["sifre"].ToString();
                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(gelenSifre, hashedPasswordFromDB);
                    if (isPasswordCorrect)
                    {
                        AracEkleForm aracEkle = new AracEkleForm(GirisYapKullaniciAdiTextBox.Text);
                        aracEkle.Show();
                        cnn.Close();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı, lütfen kontrol edip tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı, lütfen kontrol edip tekrar deneyiniz.");
                    cnn.Close();
                }
            }
        }
        private string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCryptNet.HashPassword(password, salt);
            return hashedPassword;
        }
        private void SifreUnuttumLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSifremiUnuttum sifreUnut = new FormSifremiUnuttum();
            sifreUnut.Show();
            this.Hide();
        }
        private void GirisYapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void girisSayfasiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisSayfasi giris = new GirisSayfasi();
            giris.Show();
            this.Hide();
        }
    }
}
