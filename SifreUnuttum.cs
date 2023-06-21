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
        private void kaydetBTN_Click(object sender, EventArgs e)
        {
            if (kurtarmaKoduText.Text == "" || kullanıcıAdıText.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
            }
            else
            {
                string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" + kullanıcıAdıText.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read() && kurtarmaKoduText.Text == "kurtarbeni!")
                {
                    MessageBox.Show(kullanıcıAdıText.Text + " kullanıcı adına ait şifreniz : " + tara.GetString("sifre"));
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı ve kurtarma kodunuzu doğrulayıp tekrar deneyiniz.");
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
