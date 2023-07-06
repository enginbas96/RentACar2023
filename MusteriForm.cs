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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void musteriKaydetButton_Click(object sender, EventArgs e)
        {
            MusteriKayit form2 = new MusteriKayit();
            form2.Show();
            this.Hide();
        }

        private void musteriListeleButton_Click(object sender, EventArgs e)
        {
            musteriListeleForm form = new musteriListeleForm();
            form.Show();
            this.Hide();
        }

        private void MusteriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
            GirisSayfasi form = new GirisSayfasi();
            form.Show();
            this.Hide();
        }
    }
}
