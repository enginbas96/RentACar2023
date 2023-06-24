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
    public partial class KullaniciIslemForm : Form
    {
        public KullaniciIslemForm()
        {
            InitializeComponent();
            resetle();
        }
        private void KullaniciIslemForm_Load(object sender, EventArgs e)
        {
            profilBTN.Enabled = false;
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
        private void kullaniciSilBTN_Click(object sender, EventArgs e)
        {
            if (deleteKullaniciAdi.Text == "")
            {
                MessageBox.Show("Kullanıcı adını doldurunuz.");
            }
            else
            {
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" + deleteKullaniciAdi.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read())
                {
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu1 = new MySqlCommand("DELETE FROM employees WHERE kullanici_adi= '" + deleteKullaniciAdi.Text + "'", cnn);
                    MySqlDataReader tara1 = sorgu1.ExecuteReader();
                    MessageBox.Show("Kullanıcı başarı ile silindi.");
                    deleteKullaniciAdi.Clear();
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı yok");
                    cnn.Close();
                }
            }
        }
        private void sifreDegistirBTN_Click(object sender, EventArgs e)
        {
            if (sifreDegisKullaniciAdi.Text == "" || sifreDegisSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            else
            {
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" + sifreDegisKullaniciAdi.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read())
                {
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu1 = new MySqlCommand("UPDATE employees SET sifre ='" + sifreDegisSifre.Text + "' WHERE kullanici_adi ='" + sifreDegisKullaniciAdi.Text + "' ", cnn);
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
        private void kullaniciOlusturBTN_Click(object sender, EventArgs e)
        {
            if (olusturKullaniciAdi.Text == "" || olusturSifre.Text == "" || olusturAd.Text == "" || olusturSoyad.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurup tekrar deneyiniz.");
            }
            else
            {
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" + olusturKullaniciAdi.Text + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                if (tara.Read())
                {
                    MessageBox.Show("Böyle bir kullanıcı zaten mevcut, şifresini unuttuysanız yan taraftan şifresini değiştirebilirsiniz veya kullanıcıyı kaldırabilirsiniz.");
                    cnn.Close();
                }
                else
                {
                    cnn.Close();
                    cnn.Open();
                    MySqlCommand sorgu1 = new MySqlCommand("INSERT INTO employees(name, surname, kullanici_adi, sifre, isAdmin) VALUES('" + olusturAd.Text + "','" + olusturSoyad.Text + "','" + olusturKullaniciAdi.Text + "','" + olusturSifre.Text + "','1')", cnn);
                    sorgu1.ExecuteNonQuery();
                    MessageBox.Show("Yeni kullanıcı oluşturuldu.");
                    cnn.Close();
                }
            }
        }
        void resetle()
        {
            silGB.Enabled = false;
            sifreDegistirGB.Enabled = false;
            olusturGB.Enabled = false;
            deleteKullaniciAdi.Clear();
            sifreDegisKullaniciAdi.Clear();
            sifreDegisSifre.Clear();
            olusturKullaniciAdi.Clear();
            olusturSifre.Clear();
            olusturAd.Clear();
            olusturSoyad.Clear();
        }
        private void KullaniciIslemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void silRB_CheckedChanged(object sender, EventArgs e)
        {
            resetle();
            silGB.Enabled = true;
        }
        private void sifreDegistirRB_CheckedChanged(object sender, EventArgs e)
        {
            resetle();
            sifreDegistirGB.Enabled = true;
        }
        private void olusturRB_CheckedChanged(object sender, EventArgs e)
        {
            resetle();
            olusturGB.Enabled = true;
        }
        private void olusturAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void olusturSoyad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(olusturSoyad.Text))
            {
                string text = olusturSoyad.Text;
                olusturSoyad.Text = char.ToUpper(text[0]) + text.Substring(1);
                olusturSoyad.SelectionStart = olusturSoyad.Text.Length;
            }
        }
        private void olusturSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void olusturAd_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(olusturAd.Text))
            {
                string text = olusturAd.Text;
                olusturAd.Text = char.ToUpper(text[0]) + text.Substring(1);
                olusturAd.SelectionStart = olusturAd.Text.Length;
            }
        }
    }
}
