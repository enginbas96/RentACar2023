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
        private void MusteriKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void msifreDegistirBTN_Click(object sender, EventArgs e)
        {
            if (sifreDegisTC.Text == "" || sifreDegisSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sifreDegisTC.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı eksiksiz bir şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Şifrenizi değiştirmek istediğinize emin misiniz?", "Şifre Değiştirme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
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
                        MySqlCommand sorgu1 = new MySqlCommand("UPDATE users SET password ='" + hashedPassword + "' WHERE TC ='" + sifreDegisTC.Text + "' ", cnn);
                        sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Şifreniz başarıyla değiştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir müşteri bulunamadı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cnn.Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }


        private void musteriOlusturBTN_Click(object sender, EventArgs e)
        {
            if (molusturTC.Text == "" || molusturSifre.Text == "" || molusturAd.Text == "" || molusturSoyad.Text == "" || molusturTelNo.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurup tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (molusturTC.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı eksiksiz bir şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (molusturTelNo.Text.Length != 11)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz bir şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Müşteri eklemek istediğinize emin misiniz?", "Müşteri Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                    MySqlConnection cnn = new MySqlConnection(myConnectionString);
                    cnn.Open();
                    MySqlCommand sorgu = new MySqlCommand("SELECT * FROM users WHERE TC= '" + molusturTC.Text + "'", cnn);
                    MySqlDataReader tara = sorgu.ExecuteReader();
                    if (tara.Read())
                    {
                        MessageBox.Show("Böyle bir müşteri zaten mevcut, şifresini unuttuysanız yan taraftan şifresini değiştirebilirsiniz veya müşteriyi kaldırabilirsiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cnn.Close();
                    }
                    else
                    {
                        cnn.Close();
                        cnn.Open();
                        string hashedPassword = HashPassword(molusturSifre.Text);
                        MySqlCommand sorgu1 = new MySqlCommand("INSERT INTO users(TC, password, name, surname, tel_no, isBanned) VALUES('" + molusturTC.Text + "', '" + hashedPassword + "', '" + molusturAd.Text + "','" + molusturSoyad.Text + "', '" + molusturTelNo.Text + "', '0')", cnn);
                        sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Yeni müşteri oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }

        private void musteriSilBTN_Click(object sender, EventArgs e)
        {
            if (deleteTC.Text == "")
            {
                MessageBox.Show("TC'yi giriniz.");
            }
            else if (deleteTC.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı eksiksiz bir şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Müşteri Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                    MySqlConnection cnn = new MySqlConnection(myConnectionString);
                    cnn.Open();
                    MySqlCommand sorgu = new MySqlCommand("SELECT * FROM users WHERE TC= '" + deleteTC.Text + "'", cnn);
                    MySqlDataReader tara = sorgu.ExecuteReader();
                    if (tara.Read())
                    {
                        cnn.Close();
                        cnn.Open();
                        MySqlCommand sorgu1 = new MySqlCommand("DELETE FROM users WHERE TC= '" + deleteTC.Text + "'", cnn);
                        MySqlDataReader tara1 = sorgu1.ExecuteReader();
                        MessageBox.Show("Müşteri başarı ile silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deleteTC.Clear();
                        cnn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir müşteri yok", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cnn.Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }
        private string HashPassword(string password)
        {
            string salt = BCryptNet.GenerateSalt();
            string hashedPassword = BCryptNet.HashPassword(password, salt);
            return hashedPassword;
        }
        void resetle()
        {
            mSilGB.Enabled = false;
            mSifreDegistirGB.Enabled = false;
            molusturGB.Enabled = false;
            deleteTC.Clear();
            sifreDegisTC.Clear();
            sifreDegisSifre.Clear();
            molusturTC.Clear();
            molusturSifre.Clear();
            molusturAd.Clear();
            molusturSoyad.Clear();
            molusturTelNo.Clear();
        }

        private void silRB_CheckedChanged(object sender, EventArgs e)
        {
            resetle();
            mSilGB.Enabled = true;
        }

        private void sifreDegistirRB_CheckedChanged(object sender, EventArgs e)
        {
            resetle();
            mSifreDegistirGB.Enabled = true;
        }

        private void olusturRB_CheckedChanged(object sender, EventArgs e)
        {
            resetle();
            molusturGB.Enabled = true;
        }

        private void molusturTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void molusturTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void molusturAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void molusturSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void molusturSoyad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(molusturSoyad.Text))
            {
                string text = molusturSoyad.Text;
                molusturSoyad.Text = char.ToUpper(text[0]) + text.Substring(1);
                molusturSoyad.SelectionStart = molusturSoyad.Text.Length;
            }
        }

        private void molusturAd_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(molusturAd.Text))
            {
                string text = molusturAd.Text;
                molusturAd.Text = char.ToUpper(text[0]) + text.Substring(1);
                molusturAd.SelectionStart = molusturAd.Text.Length;
            }
        }

        private void geriBTN_Click_1(object sender, EventArgs e)
        {
            MusteriForm girisSayfa = new MusteriForm();
            girisSayfa.Show();
            this.Hide();
        }
    }

}
