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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYapForm));
            GirisYapButton = new Button();
            KullaniciAdiLabel = new Label();
            SifreLabel = new Label();
            GirisYapKullaniciAdiTextBox = new TextBox();
            GirisYapSifreTextBox = new TextBox();
            SifreUnuttumLinkLabel = new LinkLabel();
            KullaniciPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)KullaniciPictureBox).BeginInit();
            SuspendLayout();
            // 
            // GirisYapButton
            // 
            GirisYapButton.Location = new Point(308, 326);
            GirisYapButton.Name = "GirisYapButton";
            GirisYapButton.Size = new Size(192, 41);
            GirisYapButton.TabIndex = 0;
            GirisYapButton.Text = "Giriş Yap";
            GirisYapButton.UseVisualStyleBackColor = true;
            // 
            // KullaniciAdiLabel
            // 
            KullaniciAdiLabel.AutoSize = true;
            KullaniciAdiLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciAdiLabel.Location = new Point(129, 196);
            KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            KullaniciAdiLabel.Size = new Size(152, 31);
            KullaniciAdiLabel.TabIndex = 1;
            KullaniciAdiLabel.Text = "Kullanıcı Adı: ";
            // 
            // SifreLabel
            // 
            SifreLabel.AutoSize = true;
            SifreLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SifreLabel.Location = new Point(211, 257);
            SifreLabel.Name = "SifreLabel";
            SifreLabel.Size = new Size(70, 31);
            SifreLabel.TabIndex = 2;
            SifreLabel.Text = "Şifre: ";
            SifreLabel.Click += label2_Click;
            // 
            // GirisYapKullaniciAdiTextBox
            // 
            GirisYapKullaniciAdiTextBox.Location = new Point(308, 202);
            GirisYapKullaniciAdiTextBox.Name = "GirisYapKullaniciAdiTextBox";
            GirisYapKullaniciAdiTextBox.Size = new Size(192, 27);
            GirisYapKullaniciAdiTextBox.TabIndex = 3;
            // 
            // GirisYapSifreTextBox
            // 
            GirisYapSifreTextBox.Location = new Point(308, 263);
            GirisYapSifreTextBox.Name = "GirisYapSifreTextBox";
            GirisYapSifreTextBox.Size = new Size(192, 27);
            GirisYapSifreTextBox.TabIndex = 4;
            // 
            // SifreUnuttumLinkLabel
            // 
            SifreUnuttumLinkLabel.AutoSize = true;
            SifreUnuttumLinkLabel.Location = new Point(324, 386);
            SifreUnuttumLinkLabel.Name = "SifreUnuttumLinkLabel";
            SifreUnuttumLinkLabel.Size = new Size(165, 20);
            SifreUnuttumLinkLabel.TabIndex = 5;
            SifreUnuttumLinkLabel.TabStop = true;
            SifreUnuttumLinkLabel.Text = "Şifrenizi Mi Unuttunuz? ";
            // 
            // KullaniciPictureBox
            // 
            KullaniciPictureBox.Image = (Image)resources.GetObject("KullaniciPictureBox.Image");
            KullaniciPictureBox.Location = new Point(308, 36);
            KullaniciPictureBox.Name = "KullaniciPictureBox";
            KullaniciPictureBox.Size = new Size(192, 131);
            KullaniciPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            KullaniciPictureBox.TabIndex = 6;
            KullaniciPictureBox.TabStop = false;
            // 
            // GirisYapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KullaniciPictureBox);
            Controls.Add(SifreUnuttumLinkLabel);
            Controls.Add(GirisYapSifreTextBox);
            Controls.Add(GirisYapKullaniciAdiTextBox);
            Controls.Add(SifreLabel);
            Controls.Add(KullaniciAdiLabel);
            Controls.Add(GirisYapButton);
            Name = "GirisYapForm";
            Text = "Giriş Yap";
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
        private PictureBox KullaniciPictureBox;
    }
}