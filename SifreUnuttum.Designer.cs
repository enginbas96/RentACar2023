namespace RentACar2023
{
    partial class FormSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSifremiUnuttum));
            KullaniciPictureBox = new PictureBox();
            kurtarmaKoduText = new TextBox();
            kullanıcıAdıText = new TextBox();
            SifreLabel = new Label();
            KullaniciAdiLabel = new Label();
            geriBTN = new Button();
            ımageList1 = new ImageList(components);
            kaydetBTN = new Button();
            yeniSifre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)KullaniciPictureBox).BeginInit();
            SuspendLayout();
            // 
            // KullaniciPictureBox
            // 
            KullaniciPictureBox.Image = (Image)resources.GetObject("KullaniciPictureBox.Image");
            KullaniciPictureBox.Location = new Point(210, 24);
            KullaniciPictureBox.Name = "KullaniciPictureBox";
            KullaniciPictureBox.Size = new Size(173, 153);
            KullaniciPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            KullaniciPictureBox.TabIndex = 111115;
            KullaniciPictureBox.TabStop = false;
            // 
            // kurtarmaKoduText
            // 
            kurtarmaKoduText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kurtarmaKoduText.Location = new Point(210, 245);
            kurtarmaKoduText.Name = "kurtarmaKoduText";
            kurtarmaKoduText.Size = new Size(173, 32);
            kurtarmaKoduText.TabIndex = 2;
            kurtarmaKoduText.UseSystemPasswordChar = true;
            // 
            // kullanıcıAdıText
            // 
            kullanıcıAdıText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kullanıcıAdıText.Location = new Point(210, 193);
            kullanıcıAdıText.Name = "kullanıcıAdıText";
            kullanıcıAdıText.Size = new Size(173, 32);
            kullanıcıAdıText.TabIndex = 1;
            // 
            // SifreLabel
            // 
            SifreLabel.AutoSize = true;
            SifreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SifreLabel.Location = new Point(45, 245);
            SifreLabel.Name = "SifreLabel";
            SifreLabel.Size = new Size(159, 28);
            SifreLabel.TabIndex = 111117;
            SifreLabel.Text = "Kurtarma Kodu : ";
            // 
            // KullaniciAdiLabel
            // 
            KullaniciAdiLabel.AutoSize = true;
            KullaniciAdiLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciAdiLabel.Location = new Point(70, 193);
            KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            KullaniciAdiLabel.Size = new Size(134, 28);
            KullaniciAdiLabel.TabIndex = 111116;
            KullaniciAdiLabel.Text = "Kullanıcı Adı : ";
            // 
            // geriBTN
            // 
            geriBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            geriBTN.ImageAlign = ContentAlignment.MiddleLeft;
            geriBTN.ImageKey = "geridon.png";
            geriBTN.ImageList = ımageList1;
            geriBTN.Location = new Point(333, 357);
            geriBTN.Name = "geriBTN";
            geriBTN.Size = new Size(162, 51);
            geriBTN.TabIndex = 5;
            geriBTN.Text = "Geri";
            geriBTN.UseVisualStyleBackColor = true;
            geriBTN.Click += geriBTN_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "sifremikurtar.png");
            ımageList1.Images.SetKeyName(1, "geridon.png");
            // 
            // kaydetBTN
            // 
            kaydetBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kaydetBTN.ImageAlign = ContentAlignment.MiddleLeft;
            kaydetBTN.ImageKey = "sifremikurtar.png";
            kaydetBTN.ImageList = ımageList1;
            kaydetBTN.Location = new Point(51, 357);
            kaydetBTN.Name = "kaydetBTN";
            kaydetBTN.Size = new Size(186, 51);
            kaydetBTN.TabIndex = 4;
            kaydetBTN.Text = "Şifremi Kurtar";
            kaydetBTN.TextAlign = ContentAlignment.MiddleRight;
            kaydetBTN.UseVisualStyleBackColor = true;
            kaydetBTN.Click += kaydetBTN_Click;
            // 
            // yeniSifre
            // 
            yeniSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yeniSifre.Location = new Point(210, 298);
            yeniSifre.Name = "yeniSifre";
            yeniSifre.Size = new Size(173, 32);
            yeniSifre.TabIndex = 3;
            yeniSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 298);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 111121;
            label1.Text = "Yeni Şifre : ";
            // 
            // FormSifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(568, 426);
            Controls.Add(yeniSifre);
            Controls.Add(label1);
            Controls.Add(geriBTN);
            Controls.Add(kaydetBTN);
            Controls.Add(KullaniciPictureBox);
            Controls.Add(kurtarmaKoduText);
            Controls.Add(kullanıcıAdıText);
            Controls.Add(SifreLabel);
            Controls.Add(KullaniciAdiLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            FormClosed += FormSifremiUnuttum_FormClosed_1;
            ((System.ComponentModel.ISupportInitialize)KullaniciPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox KullaniciPictureBox;
        private TextBox kurtarmaKoduText;
        private TextBox kullanıcıAdıText;
        private Label SifreLabel;
        private Label KullaniciAdiLabel;
        private Button geriBTN;
        private Button kaydetBTN;
        private ImageList ımageList1;
        private TextBox yeniSifre;
        private Label label1;
    }
}