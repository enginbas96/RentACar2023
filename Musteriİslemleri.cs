using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BCryptNet = BCrypt.Net.BCrypt;

namespace RentACar2023
{
    public partial class Musteriİslemleri : Form
    {
        public Musteriİslemleri()
        {
            InitializeComponent();
            resetle();
        }
        private void geriBTN_Click(object sender, EventArgs e)
        {
            GirisSayfasi girisSayfa = new GirisSayfasi();
            girisSayfa.Show();
            this.Hide();
        }
        private void MusteriKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void kaydetBTN_Click(object sender, EventArgs e)
        {
            if (tcText.Text == "" || sifreText.Text == "" || adText.Text == "" || soyadText.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurup tekrar deneyiniz.");
            }
            else if (tcText.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı eksiksiz bir şekilde giriniz.");
            }
            else if (telNoText.Text.Length != 11)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz bir şekilde giriniz.");
            }
            else
            {
                string hashedPassword = HashPassword(sifreText.Text);
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM users WHERE TC= '" + tcText.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read())
                {
                    MessageBox.Show("Bu TC kimlik numarasına ait bir kullanıcı zaten var.");
                    cnn.Close();
                }
                else
                {
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu1 = new MySqlCommand("INSERT INTO users(TC, password, name, surname, tel_no, isBanned) VALUES('" + tcText.Text + "','" + hashedPassword + "','" + adText.Text + "','" + soyadText.Text + "','" + telNoText.Text + "','0')", cnn);
                    sorgu1.ExecuteNonQuery();
                    MessageBox.Show("Müşteri kaydı başarıyla gerçekleşmiştir.");
                    cnn.Close();
                }
            }
        }
        private string HashPassword(string password)
        {
            string salt = BCryptNet.GenerateSalt();
            string hashedPassword = BCryptNet.HashPassword(password, salt);
            return hashedPassword;
        }
        private void tcText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void telNoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void adText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void soyadText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void adText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(adText.Text))
            {
                string text = adText.Text;
                adText.Text = char.ToUpper(text[0]) + text.Substring(1);
                adText.SelectionStart = adText.Text.Length;
            }
        }
        private void soyadText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(soyadText.Text))
            {
                string text = soyadText.Text;
                soyadText.Text = char.ToUpper(text[0]) + text.Substring(1);
                soyadText.SelectionStart = soyadText.Text.Length;
            }
        }

        private void kullaniciOlusturBTN_Click(object sender, EventArgs e)
        {

        }

        private void msifreDegistirBTN_Click(object sender, EventArgs e)
        {
            if (sifreDegisTC.Text == "" || sifreDegisSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            else
            {
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM users WHERE TC= '" + sifreDegisTC.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read())
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(sifreDegisSifre.Text);
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu1 = new MySqlCommand("UPDATE users SET sifre ='" + hashedPassword + "' WHERE TC ='" + sifreDegisTC.Text + "' ", cnn);
                    sorgu1.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz başarıyla değiştirildi");
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
                    cnn.Close();
                }
            }
        }
        private void msifreDegistirRB_CheckedChanged(object sender, EventArgs e)
        {
            resetle();
            sifreDegistirGB.Enabled = true;
        }
    }

}
