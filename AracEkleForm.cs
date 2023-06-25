using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar2023
{
    public partial class AracEkleForm : Form
    {
        public AracEkleForm()
        {
            InitializeComponent();
        }
        public AracEkleForm(String kullaniciAdi)
        {
            InitializeComponent();
        }
        private void AracEkleForm_Load(object sender, EventArgs e)
        {
            aracEkleBTN.Enabled = false;
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
        private void ekleBTN_Click(object sender, EventArgs e)
        {       
            int aracID = 0;
            if (plakaText.Text == "" || markaText.Text == "" || modelText.Text == "" || yakitTuruCB.Text == "" || hasarText.Text == ""
                || renkText.Text == "" || kmText.Text == "" || koltukSayiCB.Text == "" || vitesCB.Text == "" || kmFiyat.Text == "" || gunlukFiyat.Text == "")

            {
                MessageBox.Show("Lütfen bilgileri tam olarak doldurunuz.");
            }
            else
            {
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM cars WHERE plaka= '" + plakaText.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read())
                {
                    MessageBox.Show("Bu plakaya ait bir araç zaten var.");
                    cnn.Close();
                }
                else
                {
                    int haftalik = 6 * (int.Parse(gunlukFiyat.Text));
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu1 = new MySqlCommand("INSERT INTO cars(plaka, marka, model, yakit_turu, renk, hasar_kaydi, km, vites, koltuk_sayisi, img_path, isRent) VALUES('" + plakaText.Text + "','" + markaText.Text + "','" + modelText.Text + "','" + yakitTuruCB.Text + "','" + renkText.Text + "','" + hasarText.Text + "','" + kmText.Text + "','" + vitesCB.Text + "','" + koltukSayiCB.Text + "','"+ resimYolu + "','0')", cnn);
                    sorgu1.ExecuteNonQuery();
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu2 = new MySqlCommand("SELECT * FROM cars WHERE plaka = '" + plakaText.Text + "'", cnn);
                    sorgu2.ExecuteNonQuery();
                    MySqlDataReader tara2 = sorgu.ExecuteReader();
                    while (tara2.Read())
                    {
                        aracID = tara2.GetInt32("id");
                    }
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu3 = new MySqlCommand("INSERT INTO prices(arac_id,daily_price,weekly_price,daily_km_limit) VALUES('" + aracID + "','" + gunlukFiyat.Text + "','" + haftalik.ToString() + "','" + kmFiyat.Text + "')", cnn);
                    sorgu3.ExecuteNonQuery();
                    MessageBox.Show("Yeni araba veritabanına eklendi.");
                    cnn.Close();
                }
            }
        }
        private void AracEkleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void plakaText_TextChanged(object sender, EventArgs e)
        {
            plakaText.Text = plakaText.Text.ToUpper();
            plakaText.SelectionStart = plakaText.Text.Length;
        }
        private void kmText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void markaText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(markaText.Text))
            {
                string text = markaText.Text;
                markaText.Text = char.ToUpper(text[0]) + text.Substring(1);
                markaText.SelectionStart = markaText.Text.Length;
            }
        }
        private void modelText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(modelText.Text))
            {
                string text = modelText.Text;
                modelText.Text = char.ToUpper(text[0]) + text.Substring(1);
                modelText.SelectionStart = modelText.Text.Length;
            }
        }
        private void hasarText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hasarText.Text))
            {
                string text = hasarText.Text;
                hasarText.Text = char.ToUpper(text[0]) + text.Substring(1);
                hasarText.SelectionStart = hasarText.Text.Length;
            }
        }
        private void renkText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(renkText.Text))
            {
                string text = renkText.Text;
                renkText.Text = char.ToUpper(text[0]) + text.Substring(1);
                renkText.SelectionStart = renkText.Text.Length;
            }
        }
        private void gunlukFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void kmFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        string resimYolu;
        private void resimSecBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim seç";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                aracResim.Image = Image.FromFile(openFileDialog1.FileName);
                resimYolu = "img/user/" + Path.GetFileName(openFileDialog1.FileName);
            }            
        }
    }

}
