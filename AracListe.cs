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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar2023
{
    public partial class AracListe : Form
    {
        public AracListe()
        {
            InitializeComponent();
        }
        private void AracListe_Load(object sender, EventArgs e)
        {
            veriYukleyici();
            plakaText.Focus();
        }
        private void cikisBTN_Click(object sender, EventArgs e)
        {
            GirisSayfasi geriDon = new GirisSayfasi();
            geriDon.Show();
            this.Hide();
        }
        void veriYukleyici()
        {
            veriGoruntuleyici.ReadOnly = true;
            veriGoruntuleyici.AllowUserToDeleteRows = false;
            string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT plaka, marka, model, yakit_turu, renk, hasar_kaydi, km, vites, koltuk_sayisi  FROM cars WHERE isRent = '0' ", cnn);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            plakaText.Text = plakaText.Text.ToUpper();
            plakaText.SelectionStart = plakaText.Text.Length;

            veriGoruntuleyici.ReadOnly = true;
            veriGoruntuleyici.AllowUserToDeleteRows = false;
            string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT plaka, marka, model, yakit_turu, renk, hasar_kaydi, km, vites, koltuk_sayisi  FROM cars WHERE plaka LIKE '%" + plakaText.Text + "%' AND isRent = '0' ", cnn);
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
        private void AracListe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
