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
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
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
            else
            {
                string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
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
                    MySqlCommand sorgu1 = new MySqlCommand("INSERT INTO users(TC, password, name, surname, tel_no, isBanned) VALUES('" + tcText.Text + "','" + sifreText.Text + "','" + adText.Text + "','" + soyadText.Text + "','" + telNoText.Text + "','0')", cnn);
                    sorgu1.ExecuteNonQuery();
                    MessageBox.Show("Müşteri kaydı başarıyla gerçekleşmiştir.");
                    cnn.Close();
                }
            }
        }
    }
}
