using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentACar2023
{
    public partial class AracFiyatForm : Form
    {
        public AracFiyatForm()
        {
            InitializeComponent();
        }
        public static string kadi;

        public AracFiyatForm(string kullaniciAdi)
        {
            InitializeComponent();
            kadi = kullaniciAdi;
        }
        private void AracFiyatForm_Load(object sender, EventArgs e)
        {
            veriYukleyici();
            kullaniciAdi.Text = kadi;
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
        private void guncelleBTN_Click(object sender, EventArgs e)
        {
            if (plakaText.Text == "")
            {
                MessageBox.Show("Lütfen aracınızı seçiniz.");
            }
            else if (yeniFiyatText.Text == "")
            {
                MessageBox.Show("Lütfen yeni fiyat alanını doldurunuz.");
            }
            else
            {
                string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                MySqlConnection cnn = new MySqlConnection(myConnectionString);
                cnn.Open();
                if (gunlukDegisimRB.Checked == true)
                {
                    float haftalikFiyat = float.Parse(yeniFiyatText.Text) * 6;
                    MySqlCommand sorgu = new MySqlCommand("UPDATE prices JOIN cars ON prices.arac_id = cars.id SET prices.daily_price ='" + yeniFiyatText.Text + "',prices.weekly_price ='" + haftalikFiyat + "' WHERE cars.plaka ='" + plakaText.Text + "'", cnn);
                    sorgu.ExecuteNonQuery();
                    MessageBox.Show("Günlük fiyatınız başarıyla değiştirildi.");
                    cnn.Close();
                    veriYukleyici();
                    veriTemizle();
                }
                else if (kmBasinaDegisimRB.Checked == true)
                {
                    float haftalikFiyat = float.Parse(yeniFiyatText.Text) * 6;
                    MySqlCommand sorgu = new MySqlCommand("UPDATE prices JOIN cars ON prices.arac_id = cars.id SET prices.daily_km_limit ='" + yeniFiyatText.Text + "',prices.weekly_price ='" + haftalikFiyat + "' WHERE cars.plaka ='" + plakaText.Text + "'", cnn);
                    sorgu.ExecuteNonQuery();
                    MessageBox.Show("Kilometre başına fiyatınız başarıyla değiştirildi.");
                    cnn.Close();
                    veriYukleyici();
                    veriTemizle();
                }
                else
                {
                    MessageBox.Show("Lütfen önce yapmak istediğiniz işlemi seçiniz");
                    cnn.Close();
                }
            }
        }
        public void veriGoruntuleyici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = veriGoruntuleyici.Rows[e.RowIndex];
                plakaText.Text = row.Cells[0].Value.ToString();
                gunlukFiyatText.Text = row.Cells[1].Value.ToString();
                haftalikFiyatText.Text = row.Cells[2].Value.ToString();
                kmBasinaText.Text = row.Cells[3].Value.ToString();
                gunlukDegisimRB.Enabled = true;
                kmBasinaDegisimRB.Enabled = true;
            }
            catch
            {
            }
        }
        void veriYukleyici()
        {
            aracFiyatBTN.Enabled = false;
            veriGoruntuleyici.ReadOnly = true;
            veriGoruntuleyici.AllowUserToDeleteRows = false;
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT cars.plaka, prices.daily_price, prices.weekly_price, prices.daily_km_limit  FROM prices INNER JOIN cars ON cars.id = prices.arac_id  ", cnn);
            MySqlDataAdapter DA = new MySqlDataAdapter(sorgu);
            DataTable DT = new DataTable();
            DT.Clear();
            DA.Fill(DT);
            veriGoruntuleyici.DataSource = DT;
            cnn.Close();
            veriGoruntuleyici.Columns[0].HeaderText = "Arac Plakası";
            veriGoruntuleyici.Columns[1].HeaderText = "Günlük fiyat";
            veriGoruntuleyici.Columns[2].HeaderText = "Haftalık Fiyat";
            veriGoruntuleyici.Columns[3].HeaderText = "Aşımda KM Başına Fiyat";
            veriGoruntuleyici.Columns[0].Width = 273;
            veriGoruntuleyici.Columns[1].Width = 273;
            veriGoruntuleyici.Columns[2].Width = 273;
            veriGoruntuleyici.Columns[3].Width = 220;
        }
        void veriTemizle()
        {
            plakaText.Clear();
            haftalikFiyatText.Clear();
            gunlukFiyatText.Clear();
            kmBasinaText.Clear();
            yeniFiyatText.Clear();
            gunlukDegisimRB.Checked = false;
            kmBasinaDegisimRB.Checked = false;
            gunlukDegisimRB.Enabled = false;
            kmBasinaDegisimRB.Enabled = false;
        }
        private void AracFiyatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void yeniFiyatText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
