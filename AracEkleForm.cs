using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar2023
{
    public partial class AracEkleForm : Form
    {
        public AracEkleForm()
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

        private void ekleBTN_Click(object sender, EventArgs e)
        {
            if(plakaText.Text == "" || markaText.Text == "" || modelText.Text == "" || yakitTuruCB.Text == "" || hasarText.Text == ""
                || renkText.Text == "" || kmText.Text =="" || koltukSayiCB.Text == "" || vitesCB.Text == "")

            {
                MessageBox.Show("Lütfen bilgileri tam olarak doldurunuz.");            
            }
        }
    }
}
