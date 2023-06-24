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
            veriYukleyiciKiralanmis();
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
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
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
        void veriYukleyiciKiralanmis()
        {
            kiralanmısData.ReadOnly = true;
            kiralanmısData.AllowUserToDeleteRows = false;
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu1 = new MySqlCommand("SELECT users.TC, cars.plaka, car_status.start_time, car_status.end_time  FROM car_status INNER JOIN users ON car_status.musteri_id = users.id INNER JOIN cars ON car_status.arac_id = cars.id WHERE cars.isRent = 1", cnn);
            MySqlDataAdapter DA = new MySqlDataAdapter(sorgu1);
            DataTable DT = new DataTable();
            DT.Clear();
            DA.Fill(DT);
            kiralanmısData.DataSource = DT;
            cnn.Close();
            kiralanmısData.Columns[0].HeaderText = "TC kimlik numarası";
            kiralanmısData.Columns[1].HeaderText = "Arabanın Plakası";
            kiralanmısData.Columns[2].HeaderText = "Kiralanma Tarihi";
            kiralanmısData.Columns[3].HeaderText = "Teslim Tarihi";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            plakaText.Text = plakaText.Text.ToUpper();
            plakaText.SelectionStart = plakaText.Text.Length;
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
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

            /*-------------------------------------------------------------------------------------*/

            cnn.Open();
            MySqlCommand sorgu1 = new MySqlCommand("SELECT users.TC, cars.plaka, car_status.start_time, car_status.end_time  FROM car_status INNER JOIN users ON car_status.musteri_id = users.id INNER JOIN cars ON car_status.arac_id = cars.id WHERE cars.isRent = 1 AND cars.plaka LIKE '%" + plakaText.Text + "%'", cnn);
            MySqlDataAdapter DA1 = new MySqlDataAdapter(sorgu1);
            DataTable DT1 = new DataTable();
            DT1.Clear();
            DA1.Fill(DT1);
            kiralanmısData.DataSource = DT1;
            cnn.Close();
            kiralanmısData.Columns[0].HeaderText = "TC kimlik numarası";
            kiralanmısData.Columns[1].HeaderText = "Arabanın Plakası";
            kiralanmısData.Columns[2].HeaderText = "Kiralanma Tarihi";
            kiralanmısData.Columns[3].HeaderText = "Teslim Tarihi";
        }
        private void AracListe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void erkenTeslimBTN_Click(object sender, EventArgs e)
        {
            int aracID = 0;
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT *  FROM car_status INNER JOIN cars ON car_status.arac_id = cars.id WHERE cars.isRent = 1 AND cars.plaka = '" + plakaText.Text + "'", cnn);
            MySqlDataReader tara = sorgu.ExecuteReader();
            if (tara.Read())
            {
                aracID = tara.GetInt32("arac_id");
                cnn.Close();

                cnn.Open();
                MySqlCommand sorgu1 = new MySqlCommand("UPDATE cars SET isRent = '0' WHERE id ='" + aracID + "' ", cnn);
                sorgu1.ExecuteNonQuery();
                cnn.Close();

                cnn.Open();
                MySqlCommand sorgu2 = new MySqlCommand("DELETE FROM car_status WHERE arac_id ='" + aracID + "' ", cnn);
                sorgu2.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Araç başarıyla teslim alımıştır");
                plakaText.Clear();
            }
            else
            {
                MessageBox.Show("Böyle bir araç bulunamadı. Plakayı kontrol edip işleminizi tekrar gerçekleştiriniz.");
                cnn.Close();
            }
            veriYukleyici();
            veriYukleyiciKiralanmis();
        }
    }
}
