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
    public partial class KullaniciListele : Form
    {
        public KullaniciListele()
        {
            InitializeComponent();
        }
        private void KullaniciListele_Load(object sender, EventArgs e)
        {
            kullaniciVeri();
        }
        void kullaniciVeri()
        {
            kullaniciData.ReadOnly = true;
            kullaniciData.AllowUserToDeleteRows = false;
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT name, surname, kullanici_adi FROM employees ", cnn);
            MySqlDataAdapter DA = new MySqlDataAdapter(sorgu);
            DataTable DT = new DataTable();
            DT.Clear();
            DA.Fill(DT);
            kullaniciData.DataSource = DT;
            cnn.Close();
            kullaniciData.Columns[0].HeaderText = "Ad";
            kullaniciData.Columns[1].HeaderText = "Soyad";
            kullaniciData.Columns[2].HeaderText = "Kullanıcı Adı";
        }
        private void anaMenuButton_Click(object sender, EventArgs e)
        {
            KullaniciIslemForm form2 = new KullaniciIslemForm();
            form2.Show();
            this.Hide();
        }
        private void kullaniciListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
