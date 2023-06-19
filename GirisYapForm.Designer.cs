﻿namespace RentACar2023
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
            ımageList1 = new ImageList(components);
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
            GirisYapButton.ImageAlign = ContentAlignment.MiddleLeft;
            GirisYapButton.ImageKey = "cikisyap.png";
            GirisYapButton.ImageList = ımageList1;
            GirisYapButton.Location = new Point(341, 342);
            GirisYapButton.Name = "GirisYapButton";
            GirisYapButton.Size = new Size(124, 41);
            GirisYapButton.TabIndex = 0;
            GirisYapButton.Text = "Giriş Yap";
            GirisYapButton.TextAlign = ContentAlignment.MiddleRight;
            GirisYapButton.UseVisualStyleBackColor = true;
            GirisYapButton.Click += GirisYapButton_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikisyap.png");
            // 
            // KullaniciAdiLabel
            // 
            KullaniciAdiLabel.AutoSize = true;
            KullaniciAdiLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciAdiLabel.Location = new Point(129, 228);
            KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            KullaniciAdiLabel.Size = new Size(152, 31);
            KullaniciAdiLabel.TabIndex = 1;
            KullaniciAdiLabel.Text = "Kullanıcı Adı: ";
            // 
            // SifreLabel
            // 
            SifreLabel.AutoSize = true;
            SifreLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SifreLabel.Location = new Point(211, 283);
            SifreLabel.Name = "SifreLabel";
            SifreLabel.Size = new Size(70, 31);
            SifreLabel.TabIndex = 2;
            SifreLabel.Text = "Şifre: ";
            // 
            // GirisYapKullaniciAdiTextBox
            // 
            GirisYapKullaniciAdiTextBox.Location = new Point(308, 228);
            GirisYapKullaniciAdiTextBox.Name = "GirisYapKullaniciAdiTextBox";
            GirisYapKullaniciAdiTextBox.Size = new Size(192, 27);
            GirisYapKullaniciAdiTextBox.TabIndex = 3;
            // 
            // GirisYapSifreTextBox
            // 
            GirisYapSifreTextBox.Location = new Point(308, 289);
            GirisYapSifreTextBox.Name = "GirisYapSifreTextBox";
            GirisYapSifreTextBox.Size = new Size(192, 27);
            GirisYapSifreTextBox.TabIndex = 4;
            // 
            // SifreUnuttumLinkLabel
            // 
            SifreUnuttumLinkLabel.AutoSize = true;
            SifreUnuttumLinkLabel.Location = new Point(324, 405);
            SifreUnuttumLinkLabel.Name = "SifreUnuttumLinkLabel";
            SifreUnuttumLinkLabel.Size = new Size(165, 20);
            SifreUnuttumLinkLabel.TabIndex = 5;
            SifreUnuttumLinkLabel.TabStop = true;
            SifreUnuttumLinkLabel.Text = "Şifrenizi Mi Unuttunuz? ";
            SifreUnuttumLinkLabel.LinkClicked += SifreUnuttumLinkLabel_LinkClicked;
            // 
            // KullaniciPictureBox
            // 
            KullaniciPictureBox.Image = (Image)resources.GetObject("KullaniciPictureBox.Image");
            KullaniciPictureBox.Location = new Point(308, 36);
            KullaniciPictureBox.Name = "KullaniciPictureBox";
            KullaniciPictureBox.Size = new Size(181, 110);
            KullaniciPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            KullaniciPictureBox.TabIndex = 6;
            KullaniciPictureBox.TabStop = false;
            // 
            // GirisYapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
            Load += GirisYapForm_Load;
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
        private ImageList ımageList1;
    }
}