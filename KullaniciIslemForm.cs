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
                this.Close();
            }
            else if (sayfa == "crudIslem")
            {
                AracCrudForm form = new AracCrudForm();
                form.Show();
                this.Close();
            }
            else if (sayfa == "fiyatIslem")
            {
                AracFiyatForm form = new AracFiyatForm();
                form.Show();
                this.Close();
            }
            else if (sayfa == "kiralama")
            {
                AracKiralaForm form = new AracKiralaForm();
                form.Show();
                this.Close();
            }
            else if (sayfa == "profil")
            {
                KullaniciIslemForm form = new KullaniciIslemForm();
                form.Show();
                this.Close();
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
            if (kadiDelete.Text == "")
            {
                MessageBox.Show("Kullanıcı adını doldurunuz.");
            }
            else
            {
                string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();

                String kullaniciAdi = kadiDelete.Text;
                MySqlCommand sorgu = new MySqlCommand("DELETE FROM employees WHERE kullanici_adi= '" + kullaniciAdi + "'", cnn);
                MySqlDataReader tara = sorgu.ExecuteReader();
                MessageBox.Show("Kullanıcı silindi.");
                kadiDelete.Text = "";
                cnn.Close();
                /*if (tara.Read())
                {
                    
                    cnn.Close();
                }*/
            }
        }

        private void sifreDegistirBTN_Click(object sender, EventArgs e)
        {
            if (kadiSifre.Text == "" || yeniSifre.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            else 
            {
                string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();

                MySqlCommand sorgu = new MySqlCommand("UPDATE employees SET sifre ='"+yeniSifre.Text +"' WHERE kullanici_adi ='"+kadiSifre.Text+"' ", cnn);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Şifre Değiştirildi");
                cnn.Close();



            }
        }

        private void kullaniciOlusturBTN_Click(object sender, EventArgs e)
        {
            if (kadiCreate.Text == "" || sifre.Text == "" || adTXT.Text =="" || soyadTXT.Text == "")
            {
                MessageBox.Show("Boş alanları doldurup tekrar deneyiniz.");

            }
            else
            {
                string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();

                MySqlCommand sorgu = new MySqlCommand("INSERT INTO employees(name, surname, kullanici_adi, sifre, isAdmin) VALUES('"+adTXT.Text+"','"+soyadTXT.Text+"','"+kadiCreate.Text+"','"+sifre.Text+"','1')", cnn);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Oluşturuldu.");
                cnn.Close();
            }
        }
    }
}
