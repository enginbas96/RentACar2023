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
    public partial class AracKiralaForm : Form
    {
        public AracKiralaForm()
        {
            InitializeComponent();
        }
        private void AracKiralaForm_Load(object sender, EventArgs e)
        {
            aracKiralamaBTN.Enabled = false;
            plakacek();
        }
        void plakacek()
        {
            string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT * FROM cars WHERE isRent = '0'", cnn);
            MySqlDataReader tara = sorgu.ExecuteReader();
            while (tara.Read())
            {
                plakaCB.Items.Add(tara["plaka"]);
            }
            cnn.Close();
        }
        void kirala()
        {
            int musteriID = 0;
            DateTime baslangic = kiralamaTarihi.Value;
            DateTime bitis = teslimTarihi.Value;
            string baslangicTarihi = baslangic.ToString("yyyy-MM-dd HH:mm:ss");
            string bitisTarihi = bitis.ToString("yyyy-MM-dd HH:mm:ss");
            string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT * FROM users WHERE TC= '" + tcText.Text + "'", cnn);
            MySqlDataReader tara = sorgu.ExecuteReader();
            if (tara.Read())
            {
                musteriID = tara.GetInt32("id");
                if (musteriID != 0)
                {
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu1 = new MySqlCommand("INSERT INTO car_status(arac_id, musteri_id, start_time, end_time) VALUES('" + plaka_id + "','" + musteriID + "', '" + baslangicTarihi + "','" + bitisTarihi + "')", cnn);
                    sorgu1.ExecuteNonQuery();
                    MessageBox.Show("Araba kiralama işlemi başarıyla tamamlandı.");
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu2 = new MySqlCommand("UPDATE cars SET isRent = '1' WHERE id = '" + plaka_id + "'", cnn);
                    sorgu2.ExecuteNonQuery();
                    cnn.Close();
                }
            }
            else
            {
                MessageBox.Show("Bu TC kimlik numarasına ait kullanıcı bulunamadı. Kullanıcı kaydını yapıp tekrar deneyiniz.");
            }
            cnn.Close();
        }
        private void SayfaYonlendir(String sayfa)
        {
            if (sayfa == "aracEkle")
            {
                AracEkleForm form = new AracEkleForm();
                form.Show();
                this.Hide();
            }
            else if (sayfa == "crudIslem")
            {
                AracCrudForm form = new AracCrudForm();
                form.Show();
                this.Hide();
            }
            else if (sayfa == "fiyatIslem")
            {
                AracFiyatForm form = new AracFiyatForm();
                form.Show();
                this.Hide();
            }
            else if (sayfa == "kiralama")
            {
                AracKiralaForm form = new AracKiralaForm();
                form.Show();
                this.Hide();
            }
            else if (sayfa == "profil")
            {
                KullaniciIslemForm form = new KullaniciIslemForm();
                form.Show();
                this.Hide();
            }
        }
        private void crudBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("crudIslem");
        }
        private void aracKiralamaBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("kiralama");
        }
        private void aracFiyatBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("fiyatIslem");
        }
        private void profilBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("profil");
        }
        private void aracEkleBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("aracEkle");
        }
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void kiralaBTN_Click(object sender, EventArgs e)
        {
            if (plakaCB.Text == "" || tcText.Text == "" || adText.Text == "" || soyadText.Text == "" || telefonText.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri tam olarak doldurunuz.");
            }
            else if (kiralamaTarihi.Value >= teslimTarihi.Value)
            {
                MessageBox.Show("Tarihler arasında tutarsızlık var");
            }
            else
            {
                kirala();
            }
        }
        int plaka_id;
        private void plakaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT * FROM cars WHERE plaka = '" + plakaCB.Text + "'", cnn);
            MySqlDataReader tara = sorgu.ExecuteReader();
            while (tara.Read())
            {
                plaka_id = tara.GetInt32("id");
            }
            cnn.Close();
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
        private void tcText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void telefonText_KeyPress(object sender, KeyPressEventArgs e)
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
        private void AracKiralaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
