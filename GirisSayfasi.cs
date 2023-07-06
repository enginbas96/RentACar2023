namespace RentACar2023
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }
        private void musteriKayitBTN_Click(object sender, EventArgs e)
        {
            MusteriForm form2 = new MusteriForm();
            form2.Show();
            this.Hide();
        }
        private void aracListeBTN_Click(object sender, EventArgs e)
        {
            AracListe form2 = new AracListe();
            form2.Show();
            this.Hide();
        }
        private void girisBTN_Click(object sender, EventArgs e)
        {
            GirisYapForm form = new GirisYapForm();
            form.Show();
            this.Hide();
        }
        private void GirisSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}