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

            String kullaniciAdi = GirisYapKullaniciAdiTextBox.Text;
            String sifre = GirisYapSifreTextBox.Text;   
            MySqlCommand sorgu = new MySqlCommand("SELECT * FROM employees WHERE kullanici_adi= '" +kullaniciAdi+ "' AND sifre ='"+ sifre+"'",cnn );
            MySqlDataReader tara = sorgu.ExecuteReader();
            if (tara.Read())
            {
                AracEkleForm aracEkle = new AracEkleForm();
                aracEkle.Show();
                cnn.Close();
                this.Close();
            }
        }

    }
}
