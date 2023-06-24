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
    public partial class AracCrudForm : Form
    {
        public AracCrudForm()
        {
            InitializeComponent();
        }
        private void AracCrudForm_Load(object sender, EventArgs e)
        {
            crudBTN.Enabled = false;
            veriYukleyici();
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
        private void profilBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("profil");
        }
        private void aracFiyatBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("fiyatIslem");
        }
        private void aracEkleBTN_Click(object sender, EventArgs e)
        {
            SayfaYonlendir("aracEkle");
        }
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void islemBTN_Click(object sender, EventArgs e)
        {
            if (plakaText.Text == "" || markaText.Text == "" || modelText.Text == "" || yakitTuruCB.Text == "" || hasarText.Text == ""
                || renkText.Text == "" || kmText.Text == "" || koltukSayiCB.Text == "" || vitesCB.Text == "")

            {
                MessageBox.Show("Lütfen bilgileri tam olarak doldurunuz.");
            }
            else if (silRB.Checked == false && guncelleRB.Checked == false)
            {
                MessageBox.Show("Lütfen yapılacak işlemi seçiniz.");
            }
            else
            {
                if (guncelleRB.Checked)
                {
                    string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                    MySqlConnection cnn = new MySqlConnection(myConnectionString);
                    cnn.Open();
                    MySqlCommand sorgu = new MySqlCommand("SELECT * FROM cars WHERE plaka= '" + plakaText.Text + "'", cnn);
                    MySqlDataReader tara = sorgu.ExecuteReader();
                    if (tara.Read())
                    {
                        cnn.Close();
                        cnn.Open();
                        MySqlCommand sorgu1 = new MySqlCommand("UPDATE cars SET renk ='" + renkText.Text + "', km ='" + kmText.Text + "', hasar_kaydi = '" + hasarText.Text + "' WHERE plaka ='" + plakaText.Text + "' ", cnn);
                        sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Bilgiler Güncellendi");
                        cnn.Close();
                        temizle();
                        veriYukleyici();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Gerçekleştirilemedi.");
                        cnn.Close();
                    }
                }
                else if (silRB.Checked)
                {
                    string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
                    MySqlConnection cnn = new MySqlConnection(myConnectionString);
                    cnn.Open();
                    MySqlCommand sorgu = new MySqlCommand("SELECT * FROM cars WHERE plaka= '" + plakaText.Text + "'", cnn);
                    MySqlDataReader tara = sorgu.ExecuteReader();
                    if (tara.Read())
                    {
                        cnn.Close();
                        cnn.Open();
                        MySqlCommand sorgu1 = new MySqlCommand("DELETE FROM cars WHERE plaka= '" + plakaText.Text + "'", cnn);
                        MySqlDataReader tara1 = sorgu1.ExecuteReader();
                        MessageBox.Show("Araç başarı ile silindi.");
                        cnn.Close();
                        veriYukleyici();
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir araç yok");
                        cnn.Close();
                    }
                }
            }
        }
        void veriYukleyici()
        {
            veriGoruntuleyici.ReadOnly = true;
            veriGoruntuleyici.AllowUserToDeleteRows = false;
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT plaka, marka, model, yakit_turu, renk, hasar_kaydi, km, vites, koltuk_sayisi  FROM cars ", cnn);
            MySqlDataAdapter DA = new MySqlDataAdapter(sorgu);
            DataTable DT = new DataTable();
            DT.Clear();
            DA.Fill(DT);
            veriGoruntuleyici.DataSource = DT;
            cnn.Close();
            veriGoruntuleyici.Columns[0].HeaderText = "Plaka";
            veriGoruntuleyici.Columns[1].HeaderText = "Marka";
            veriGoruntuleyici.Columns[2].HeaderText = "Model";
            veriGoruntuleyici.Columns[3].HeaderText = "Yakıt Türü";
            veriGoruntuleyici.Columns[4].HeaderText = "Renk";
            veriGoruntuleyici.Columns[5].HeaderText = "Hasar Kaydı";
            veriGoruntuleyici.Columns[6].HeaderText = "KM";
            veriGoruntuleyici.Columns[7].HeaderText = "Vites";
            veriGoruntuleyici.Columns[8].HeaderText = "Koltuk Sayısı";
        }
        private void veriGoruntuleyici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = veriGoruntuleyici.Rows[e.RowIndex];
                plakaText.Text = row.Cells[0].Value.ToString();
                markaText.Text = row.Cells[1].Value.ToString();
                modelText.Text = row.Cells[2].Value.ToString();
                yakitTuruCB.Text = row.Cells[3].Value.ToString();
                renkText.Text = row.Cells[4].Value.ToString();
                hasarText.Text = row.Cells[5].Value.ToString();
                kmText.Text = row.Cells[6].Value.ToString();
                vitesCB.Text = row.Cells[7].Value.ToString();
                koltukSayiCB.Text = row.Cells[8].Value.ToString();
                silRB.Enabled = true;
                guncelleRB.Enabled = true;
            }
            catch { }
        }
        private void silRB_CheckedChanged(object sender, EventArgs e)
        {
            islemBTN.Text = "Aracı Sil";
        }
        private void guncelleRB_CheckedChanged(object sender, EventArgs e)
        {
            islemBTN.Text = "Aracı Güncelle";
        }
        void temizle()
        {
            plakaText.Clear();
            markaText.Clear();
            modelText.Clear();
            yakitTuruCB.Text = "";
            renkText.Clear();
            kmText.Clear();
            koltukSayiCB.Text = "";
            vitesCB.Text = "";
            hasarText.Clear();
            guncelleRB.Enabled = false;
            silRB.Enabled = false;
        }
        private void renkText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
        private void hasarText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hasarText.Text))
            {
                string text = hasarText.Text;
                hasarText.Text = char.ToUpper(text[0]) + text.Substring(1);
                hasarText.SelectionStart = hasarText.Text.Length;
            }

        }
        private void kmText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AracCrudForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

