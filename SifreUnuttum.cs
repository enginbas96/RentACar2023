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
    public partial class FormSifremiUnuttum : Form
    {
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }
        private void girisSayfaBTN_Click(object sender, EventArgs e)
        {
            GirisYapForm form = new GirisYapForm();
            form.Show();
            this.Hide();
        }
        private void FormSifremiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private string HashPassword(string password)
        {
            string salt = BCryptNet.GenerateSalt();
            string hashedPassword = BCryptNet.HashPassword(password, salt);
            return hashedPassword;
        }
        private void kaydetBTN_Click(object sender, EventArgs e)
        {
            if (kurtarmaKoduText.Text == "" || kullanıcıAdıText.Text == "" || yeniSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Şifreyi değiştirmek istediğinize emin misiniz?", "Şifre Değiştirme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(yeniSifre.Text);
                    string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                    MySqlConnection cnn = new MySqlConnection(myConnectionString);
                    cnn.Open();
                    MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" + kullanıcıAdıText.Text + "'", cnn);
                    MySqlDataReader tara = sorgu.ExecuteReader();
                    if (tara.Read() && kurtarmaKoduText.Text == "kurtarbeni!")
                    {
                        cnn.Close();
                        cnn.Open();
                        MySqlCommand sorgu1 = new MySqlCommand("UPDATE employees SET sifre ='" + hashedPassword + "' WHERE kullanici_adi ='" + kullanıcıAdıText.Text + "' ", cnn);
                        sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Şifreniz başarıyla değiştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adınızı ve kurtarma kodunuzu doğrulayıp tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }
        private void geriBTN_Click(object sender, EventArgs e)
        {
            GirisYapForm girisYapForm = new GirisYapForm();
            girisYapForm.Show();
            this.Hide();
        }
        private void FormSifremiUnuttum_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
