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
    public partial class FormSifremiUnuttum : Form
    {
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void girisSayfaBTN_Click(object sender, EventArgs e)
        {
            GirisYapForm form = new GirisYapForm();
            form.Show();
            this.Hide();
        }

        private void sifreGetirBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
