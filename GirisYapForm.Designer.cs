namespace RentACar2023
{
    partial class GirisYapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYapForm));
            GirisYapButton = new Button();
            KullaniciAdiLabel = new Label();
            SifreLabel = new Label();
            GirisYapKullaniciAdiTextBox = new TextBox();
            GirisYapSifreTextBox = new TextBox();
            SifreUnuttumLinkLabel = new LinkLabel();
            ımageList1 = new ImageList(components);
            KullaniciPictureBox = new PictureBox();
            girisSayfasiLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)KullaniciPictureBox).BeginInit();
            SuspendLayout();
            // 
            // GirisYapButton
            // 
            GirisYapButton.ImageAlign = ContentAlignment.MiddleLeft;
            GirisYapButton.ImageKey = "(yok)";
            GirisYapButton.Location = new Point(200, 323);
            GirisYapButton.Name = "GirisYapButton";
            GirisYapButton.Size = new Size(173, 41);
            GirisYapButton.TabIndex = 3;
            GirisYapButton.Text = "Giriş Yap";
            GirisYapButton.UseVisualStyleBackColor = true;
            GirisYapButton.Click += GirisYapButton_Click;
            // 
            // KullaniciAdiLabel
            // 
            KullaniciAdiLabel.AutoSize = true;
            KullaniciAdiLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciAdiLabel.Location = new Point(60, 213);
            KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            KullaniciAdiLabel.Size = new Size(134, 28);
            KullaniciAdiLabel.TabIndex = 11111;
            KullaniciAdiLabel.Text = "Kullanıcı Adı : ";
            // 
            // SifreLabel
            // 
            SifreLabel.AutoSize = true;
            SifreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SifreLabel.Location = new Point(129, 261);
            SifreLabel.Name = "SifreLabel";
            SifreLabel.Size = new Size(65, 28);
            SifreLabel.TabIndex = 111112;
            SifreLabel.Text = "Şifre : ";
            // 
            // GirisYapKullaniciAdiTextBox
            // 
            GirisYapKullaniciAdiTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            GirisYapKullaniciAdiTextBox.Location = new Point(200, 213);
            GirisYapKullaniciAdiTextBox.Name = "GirisYapKullaniciAdiTextBox";
            GirisYapKullaniciAdiTextBox.Size = new Size(173, 32);
            GirisYapKullaniciAdiTextBox.TabIndex = 1;
            // 
            // GirisYapSifreTextBox
            // 
            GirisYapSifreTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            GirisYapSifreTextBox.Location = new Point(200, 261);
            GirisYapSifreTextBox.Name = "GirisYapSifreTextBox";
            GirisYapSifreTextBox.Size = new Size(173, 32);
            GirisYapSifreTextBox.TabIndex = 2;
            GirisYapSifreTextBox.UseSystemPasswordChar = true;
            // 
            // SifreUnuttumLinkLabel
            // 
            SifreUnuttumLinkLabel.AutoSize = true;
            SifreUnuttumLinkLabel.Location = new Point(202, 386);
            SifreUnuttumLinkLabel.Name = "SifreUnuttumLinkLabel";
            SifreUnuttumLinkLabel.Size = new Size(165, 20);
            SifreUnuttumLinkLabel.TabIndex = 4;
            SifreUnuttumLinkLabel.TabStop = true;
            SifreUnuttumLinkLabel.Text = "Şifrenizi Mi Unuttunuz? ";
            SifreUnuttumLinkLabel.LinkClicked += SifreUnuttumLinkLabel_LinkClicked;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikisyap.png");
            // 
            // KullaniciPictureBox
            // 
            KullaniciPictureBox.Image = (Image)resources.GetObject("KullaniciPictureBox.Image");
            KullaniciPictureBox.Location = new Point(200, 27);
            KullaniciPictureBox.Name = "KullaniciPictureBox";
            KullaniciPictureBox.Size = new Size(173, 153);
            KullaniciPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            KullaniciPictureBox.TabIndex = 6;
            KullaniciPictureBox.TabStop = false;
            // 
            // girisSayfasiLink
            // 
            girisSayfasiLink.AutoSize = true;
            girisSayfasiLink.Location = new Point(12, 9);
            girisSayfasiLink.Name = "girisSayfasiLink";
            girisSayfasiLink.Size = new Size(29, 20);
            girisSayfasiLink.TabIndex = 111113;
            girisSayfasiLink.TabStop = true;
            girisSayfasiLink.Text = "<<";
            girisSayfasiLink.LinkClicked += girisSayfasiLink_LinkClicked;
            // 
            // GirisYapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(568, 426);
            Controls.Add(girisSayfasiLink);
            Controls.Add(KullaniciPictureBox);
            Controls.Add(SifreUnuttumLinkLabel);
            Controls.Add(GirisYapSifreTextBox);
            Controls.Add(GirisYapKullaniciAdiTextBox);
            Controls.Add(SifreLabel);
            Controls.Add(KullaniciAdiLabel);
            Controls.Add(GirisYapButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GirisYapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            FormClosed += GirisYapForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)KullaniciPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GirisYapButton;
        private Label KullaniciAdiLabel;
        private Label SifreLabel;
        private TextBox GirisYapKullaniciAdiTextBox;
        private TextBox GirisYapSifreTextBox;
        private LinkLabel SifreUnuttumLinkLabel;
        private ImageList ımageList1;
        private PictureBox KullaniciPictureBox;
        private LinkLabel girisSayfasiLink;
    }
}