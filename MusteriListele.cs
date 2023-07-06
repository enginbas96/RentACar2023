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
    public partial class musteriListeleForm : Form
    {
        public musteriListeleForm()
        {
            InitializeComponent();
        }

        private void musteriListeleForm_Load(object sender, EventArgs e)
        {
            musteriVeri();
        }

        private void cikisBTN_Click(object sender, EventArgs e)
        {
            GirisSayfasi geriDon = new GirisSayfasi();
            geriDon.Show();
            this.Hide();
        }
        void musteriVeri()
        {
            musteriData.ReadOnly = true;
            musteriData.AllowUserToDeleteRows = false;
            string myConnectionString = "server=7xz.h.filess.io;database=rentacar_wastesugar;uid=rentacar_wastesugar;pwd=d150c35368dc92fa3cc2c09bde449b384fb6b4c3;port=3307;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT TC, name, surname, tel_no FROM users ", cnn);
            MySqlDataAdapter DA = new MySqlDataAdapter(sorgu);
            DataTable DT = new DataTable();
            DT.Clear();
            DA.Fill(DT);
            musteriData.DataSource = DT;
            cnn.Close();
            musteriData.Columns[0].HeaderText = "TC";
            musteriData.Columns[1].HeaderText = "Ad";
            musteriData.Columns[2].HeaderText = "Soyad";
            musteriData.Columns[3].HeaderText = "Telefon Numarası";
        }
        private void anaMenuButton_Click(object sender, EventArgs e)
        {
            GirisSayfasi form2 = new GirisSayfasi();
            form2.Show();
            this.Hide();
        }

        private void musteriListeleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
