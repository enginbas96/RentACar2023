namespace RentACar2023
{
    partial class GirisSayfasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            pictureBox1 = new PictureBox();
            HosgeldinizText = new Label();
            İslemTextBox = new TextBox();
            AraclariListeleButton = new Button();
            KullaniciGirisButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // HosgeldinizText
            // 
            HosgeldinizText.AutoSize = true;
            HosgeldinizText.BackColor = SystemColors.Window;
            HosgeldinizText.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            HosgeldinizText.Location = new Point(99, 207);
            HosgeldinizText.Name = "HosgeldinizText";
            HosgeldinizText.Size = new Size(616, 38);
            HosgeldinizText.TabIndex = 1;
            HosgeldinizText.Text = "OTO KİRALAMA PROGRAMIMIZA HOŞGELDİNİZ ";
            HosgeldinizText.Click += label1_Click;
            // 
            // İslemTextBox
            // 
            İslemTextBox.BorderStyle = BorderStyle.None;
            İslemTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            İslemTextBox.Location = new Point(240, 290);
            İslemTextBox.Name = "İslemTextBox";
            İslemTextBox.Size = new Size(308, 24);
            İslemTextBox.TabIndex = 2;
            İslemTextBox.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçin";
            İslemTextBox.TextChanged += İslemTextBox_TextChanged;
            // 
            // AraclariListeleButton
            // 
            AraclariListeleButton.BackgroundImageLayout = ImageLayout.None;
            AraclariListeleButton.Location = new Point(484, 338);
            AraclariListeleButton.Name = "AraclariListeleButton";
            AraclariListeleButton.Size = new Size(144, 76);
            AraclariListeleButton.TabIndex = 3;
            AraclariListeleButton.Text = "Araçları Listele";
            AraclariListeleButton.UseVisualStyleBackColor = true;
            AraclariListeleButton.Click += button1_Click;
            // 
            // KullaniciGirisButton
            // 
            KullaniciGirisButton.Location = new Point(189, 338);
            KullaniciGirisButton.Name = "KullaniciGirisButton";
            KullaniciGirisButton.Size = new Size(150, 76);
            KullaniciGirisButton.TabIndex = 4;
            KullaniciGirisButton.Text = "Kullanıcı Girişi";
            KullaniciGirisButton.UseVisualStyleBackColor = true;
            KullaniciGirisButton.Click += button2_Click;
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KullaniciGirisButton);
            Controls.Add(AraclariListeleButton);
            Controls.Add(İslemTextBox);
            Controls.Add(HosgeldinizText);
            Controls.Add(pictureBox1);
            Name = "GirisSayfasi";
            Text = "Giriş Sayfası";
            Load += GirisSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label HosgeldinizText;
        private TextBox İslemTextBox;
        private Button AraclariListeleButton;
        private Button KullaniciGirisButton;
    }
}