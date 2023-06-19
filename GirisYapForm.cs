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
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }


        private void GirisYapForm_Load(object sender, EventArgs e)
        {
            
        }
        private void GirisYapButton_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=db4free.net;database=rentacar;uid=keremcan;pwd=kutluhanengin23;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" + GirisYapKullaniciAdiTextBox.Text + "' AND sifre ='"+ GirisYapSifreTextBox.Text + "'",cnn );
            MySqlDataReader tara = sorgu.ExecuteReader();
            if (tara.Read())
            {
                AracEkleForm aracEkle = new AracEkleForm(GirisYapKullaniciAdiTextBox.Text);
                aracEkle.Show();
                cnn.Close();
                this.Hide();
            }
        }

    }
}
