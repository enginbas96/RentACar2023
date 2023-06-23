namespace RentACar2023
{
    partial class KullaniciIslemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciIslemForm));
            cikisBTN = new Button();
            ımageList1 = new ImageList(components);
            profilBTN = new Button();
            aracFiyatBTN = new Button();
            aracKiralamaBTN = new Button();
            crudBTN = new Button();
            aracEkleBTN = new Button();
            silGB = new GroupBox();
            deleteKullaniciAdi = new TextBox();
            label1 = new Label();
            kullaniciSilBTN = new Button();
            sifreDegistirGB = new GroupBox();
            sifreDegisSifre = new TextBox();
            label3 = new Label();
            sifreDegisKullaniciAdi = new TextBox();
            label2 = new Label();
            sifreDegistirBTN = new Button();
            olusturGB = new GroupBox();
            olusturSoyad = new TextBox();
            label7 = new Label();
            olusturAd = new TextBox();
            label6 = new Label();
            olusturSifre = new TextBox();
            label4 = new Label();
            olusturKullaniciAdi = new TextBox();
            label5 = new Label();
            kullaniciOlusturBTN = new Button();
            silRB = new RadioButton();
            sifreDegistirRB = new RadioButton();
            olusturRB = new RadioButton();
            ımageList2 = new ImageList(components);
            silGB.SuspendLayout();
            sifreDegistirGB.SuspendLayout();
            olusturGB.SuspendLayout();
            SuspendLayout();
            // 
            // cikisBTN
            // 
            cikisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            cikisBTN.ImageKey = "cikisyap.png";
            cikisBTN.ImageList = ımageList1;
            cikisBTN.Location = new Point(985, 12);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(122, 52);
            cikisBTN.TabIndex = 5;
            cikisBTN.Text = "Çıkış Yap";
            cikisBTN.TextAlign = ContentAlignment.MiddleRight;
            cikisBTN.UseVisualStyleBackColor = true;
            cikisBTN.Click += cikisBTN_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "araccrud.png");
            ımageList1.Images.SetKeyName(1, "aracekle.png");
            ımageList1.Images.SetKeyName(2, "aracfiyat.png");
            ımageList1.Images.SetKeyName(3, "arackiralama.png");
            ımageList1.Images.SetKeyName(4, "cikisyap.png");
            ımageList1.Images.SetKeyName(5, "kullanıcıicon.png");
            // 
            // profilBTN
            // 
            profilBTN.ImageAlign = ContentAlignment.MiddleLeft;
            profilBTN.ImageKey = "kullanıcıicon.png";
            profilBTN.ImageList = ımageList1;
            profilBTN.Location = new Point(811, 12);
            profilBTN.Name = "profilBTN";
            profilBTN.Size = new Size(166, 52);
            profilBTN.TabIndex = 4;
            profilBTN.Text = "Kullanıcı İşlemleri";
            profilBTN.TextAlign = ContentAlignment.MiddleRight;
            profilBTN.UseVisualStyleBackColor = true;
            profilBTN.Click += profilBTN_Click;
            // 
            // aracFiyatBTN
            // 
            aracFiyatBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracFiyatBTN.ImageKey = "aracfiyat.png";
            aracFiyatBTN.ImageList = ımageList1;
            aracFiyatBTN.Location = new Point(628, 12);
            aracFiyatBTN.Name = "aracFiyatBTN";
            aracFiyatBTN.Size = new Size(177, 52);
            aracFiyatBTN.TabIndex = 3;
            aracFiyatBTN.Text = "Araç Fiyat İşlemleri";
            aracFiyatBTN.TextAlign = ContentAlignment.MiddleRight;
            aracFiyatBTN.UseVisualStyleBackColor = true;
            aracFiyatBTN.Click += aracFiyatBTN_Click;
            // 
            // aracKiralamaBTN
            // 
            aracKiralamaBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracKiralamaBTN.ImageKey = "arackiralama.png";
            aracKiralamaBTN.ImageList = ımageList1;
            aracKiralamaBTN.Location = new Point(415, 12);
            aracKiralamaBTN.Name = "aracKiralamaBTN";
            aracKiralamaBTN.Size = new Size(207, 52);
            aracKiralamaBTN.TabIndex = 2;
            aracKiralamaBTN.Text = "Araç Kiralama İşlemleri";
            aracKiralamaBTN.TextAlign = ContentAlignment.MiddleRight;
            aracKiralamaBTN.UseVisualStyleBackColor = true;
            aracKiralamaBTN.Click += aracKiralamaBTN_Click;
            // 
            // crudBTN
            // 
            crudBTN.ImageAlign = ContentAlignment.MiddleLeft;
            crudBTN.ImageKey = "araccrud.png";
            crudBTN.ImageList = ımageList1;
            crudBTN.Location = new Point(221, 12);
            crudBTN.Name = "crudBTN";
            crudBTN.Size = new Size(188, 52);
            crudBTN.TabIndex = 1;
            crudBTN.Text = "Araç CRUD İşlemleri";
            crudBTN.TextAlign = ContentAlignment.MiddleRight;
            crudBTN.UseVisualStyleBackColor = true;
            crudBTN.Click += crudBTN_Click;
            // 
            // aracEkleBTN
            // 
            aracEkleBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracEkleBTN.ImageKey = "aracekle.png";
            aracEkleBTN.ImageList = ımageList1;
            aracEkleBTN.Location = new Point(12, 12);
            aracEkleBTN.Name = "aracEkleBTN";
            aracEkleBTN.Size = new Size(203, 52);
            aracEkleBTN.TabIndex = 0;
            aracEkleBTN.Text = "Araç Ekleme İşlemleri";
            aracEkleBTN.TextAlign = ContentAlignment.MiddleRight;
            aracEkleBTN.UseVisualStyleBackColor = true;
            aracEkleBTN.Click += aracEkleBTN_Click;
            // 
            // silGB
            // 
            silGB.Controls.Add(deleteKullaniciAdi);
            silGB.Controls.Add(label1);
            silGB.Controls.Add(kullaniciSilBTN);
            silGB.Location = new Point(24, 155);
            silGB.Name = "silGB";
            silGB.Size = new Size(338, 399);
            silGB.TabIndex = 12;
            silGB.TabStop = false;
            silGB.Text = "Kullanıcı Sil";
            // 
            // deleteKullaniciAdi
            // 
            deleteKullaniciAdi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            deleteKullaniciAdi.Location = new Point(60, 186);
            deleteKullaniciAdi.MaxLength = 30;
            deleteKullaniciAdi.Name = "deleteKullaniciAdi";
            deleteKullaniciAdi.Size = new Size(211, 32);
            deleteKullaniciAdi.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 150);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // kullaniciSilBTN
            // 
            kullaniciSilBTN.ImageAlign = ContentAlignment.MiddleLeft;
            kullaniciSilBTN.ImageKey = "kullanicisil.png";
            kullaniciSilBTN.ImageList = ımageList2;
            kullaniciSilBTN.Location = new Point(87, 338);
            kullaniciSilBTN.Name = "kullaniciSilBTN";
            kullaniciSilBTN.Size = new Size(145, 52);
            kullaniciSilBTN.TabIndex = 7;
            kullaniciSilBTN.Text = "Kullanıcıyı Sil";
            kullaniciSilBTN.TextAlign = ContentAlignment.MiddleRight;
            kullaniciSilBTN.UseVisualStyleBackColor = true;
            kullaniciSilBTN.Click += kullaniciSilBTN_Click;
            // 
            // sifreDegistirGB
            // 
            sifreDegistirGB.Controls.Add(sifreDegisSifre);
            sifreDegistirGB.Controls.Add(label3);
            sifreDegistirGB.Controls.Add(sifreDegisKullaniciAdi);
            sifreDegistirGB.Controls.Add(label2);
            sifreDegistirGB.Controls.Add(sifreDegistirBTN);
            sifreDegistirGB.Location = new Point(390, 155);
            sifreDegistirGB.Name = "sifreDegistirGB";
            sifreDegistirGB.Size = new Size(338, 399);
            sifreDegistirGB.TabIndex = 13;
            sifreDegistirGB.TabStop = false;
            sifreDegistirGB.Text = "Şifre Değiştir";
            // 
            // sifreDegisSifre
            // 
            sifreDegisSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sifreDegisSifre.Location = new Point(60, 218);
            sifreDegisSifre.MaxLength = 30;
            sifreDegisSifre.Name = "sifreDegisSifre";
            sifreDegisSifre.Size = new Size(211, 32);
            sifreDegisSifre.TabIndex = 9;
            sifreDegisSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 184);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 3;
            label3.Text = "Yeni Şifre";
            // 
            // sifreDegisKullaniciAdi
            // 
            sifreDegisKullaniciAdi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sifreDegisKullaniciAdi.Location = new Point(60, 136);
            sifreDegisKullaniciAdi.MaxLength = 30;
            sifreDegisKullaniciAdi.Name = "sifreDegisKullaniciAdi";
            sifreDegisKullaniciAdi.Size = new Size(211, 32);
            sifreDegisKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 102);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // sifreDegistirBTN
            // 
            sifreDegistirBTN.ImageAlign = ContentAlignment.MiddleLeft;
            sifreDegistirBTN.ImageKey = "aracıguncelle.png";
            sifreDegistirBTN.ImageList = ımageList2;
            sifreDegistirBTN.Location = new Point(83, 338);
            sifreDegistirBTN.Name = "sifreDegistirBTN";
            sifreDegistirBTN.Size = new Size(158, 52);
            sifreDegistirBTN.TabIndex = 10;
            sifreDegistirBTN.Text = "Şifre Değiştir";
            sifreDegistirBTN.TextAlign = ContentAlignment.MiddleRight;
            sifreDegistirBTN.UseVisualStyleBackColor = true;
            sifreDegistirBTN.Click += sifreDegistirBTN_Click;
            // 
            // olusturGB
            // 
            olusturGB.Controls.Add(olusturSoyad);
            olusturGB.Controls.Add(label7);
            olusturGB.Controls.Add(olusturAd);
            olusturGB.Controls.Add(label6);
            olusturGB.Controls.Add(olusturSifre);
            olusturGB.Controls.Add(label4);
            olusturGB.Controls.Add(olusturKullaniciAdi);
            olusturGB.Controls.Add(label5);
            olusturGB.Controls.Add(kullaniciOlusturBTN);
            olusturGB.Location = new Point(756, 155);
            olusturGB.Name = "olusturGB";
            olusturGB.Size = new Size(338, 399);
            olusturGB.TabIndex = 14;
            olusturGB.TabStop = false;
            olusturGB.Text = "Kullanıcı Oluştur";
            // 
            // olusturSoyad
            // 
            olusturSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            olusturSoyad.Location = new Point(62, 286);
            olusturSoyad.MaxLength = 30;
            olusturSoyad.Name = "olusturSoyad";
            olusturSoyad.Size = new Size(211, 32);
            olusturSoyad.TabIndex = 17;
            olusturSoyad.TextChanged += olusturSoyad_TextChanged;
            olusturSoyad.KeyPress += olusturSoyad_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 251);
            label7.Name = "label7";
            label7.Size = new Size(79, 32);
            label7.TabIndex = 16;
            label7.Text = "Soyad";
            // 
            // olusturAd
            // 
            olusturAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            olusturAd.Location = new Point(62, 211);
            olusturAd.MaxLength = 30;
            olusturAd.Name = "olusturAd";
            olusturAd.Size = new Size(211, 32);
            olusturAd.TabIndex = 15;
            olusturAd.TextChanged += olusturAd_TextChanged;
            olusturAd.KeyPress += olusturAd_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 176);
            label6.Name = "label6";
            label6.Size = new Size(43, 32);
            label6.TabIndex = 14;
            label6.Text = "Ad";
            // 
            // olusturSifre
            // 
            olusturSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            olusturSifre.Location = new Point(62, 136);
            olusturSifre.MaxLength = 30;
            olusturSifre.Name = "olusturSifre";
            olusturSifre.Size = new Size(211, 32);
            olusturSifre.TabIndex = 12;
            olusturSifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 101);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            // 
            // olusturKullaniciAdi
            // 
            olusturKullaniciAdi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            olusturKullaniciAdi.Location = new Point(62, 61);
            olusturKullaniciAdi.MaxLength = 30;
            olusturKullaniciAdi.Name = "olusturKullaniciAdi";
            olusturKullaniciAdi.Size = new Size(211, 32);
            olusturKullaniciAdi.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 26);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 1;
            label5.Text = "Kullanıcı Adı";
            // 
            // kullaniciOlusturBTN
            // 
            kullaniciOlusturBTN.ImageAlign = ContentAlignment.MiddleLeft;
            kullaniciOlusturBTN.ImageKey = "kullaniciolustur.png";
            kullaniciOlusturBTN.ImageList = ımageList2;
            kullaniciOlusturBTN.Location = new Point(84, 338);
            kullaniciOlusturBTN.Name = "kullaniciOlusturBTN";
            kullaniciOlusturBTN.Size = new Size(166, 52);
            kullaniciOlusturBTN.TabIndex = 13;
            kullaniciOlusturBTN.Text = "Kullanıcı Oluştur";
            kullaniciOlusturBTN.TextAlign = ContentAlignment.MiddleRight;
            kullaniciOlusturBTN.UseVisualStyleBackColor = true;
            kullaniciOlusturBTN.Click += kullaniciOlusturBTN_Click;
            // 
            // silRB
            // 
            silRB.AutoSize = true;
            silRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            silRB.Location = new Point(24, 96);
            silRB.Name = "silRB";
            silRB.Size = new Size(132, 32);
            silRB.TabIndex = 15;
            silRB.TabStop = true;
            silRB.Text = "Kullanıcı Sil";
            silRB.UseVisualStyleBackColor = true;
            silRB.CheckedChanged += silRB_CheckedChanged;
            // 
            // sifreDegistirRB
            // 
            sifreDegistirRB.AutoSize = true;
            sifreDegistirRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sifreDegistirRB.Location = new Point(390, 96);
            sifreDegistirRB.Name = "sifreDegistirRB";
            sifreDegistirRB.Size = new Size(145, 32);
            sifreDegistirRB.TabIndex = 16;
            sifreDegistirRB.TabStop = true;
            sifreDegistirRB.Text = "Şifre Değiştir";
            sifreDegistirRB.UseVisualStyleBackColor = true;
            sifreDegistirRB.CheckedChanged += sifreDegistirRB_CheckedChanged;
            // 
            // olusturRB
            // 
            olusturRB.AutoSize = true;
            olusturRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            olusturRB.Location = new Point(756, 96);
            olusturRB.Name = "olusturRB";
            olusturRB.Size = new Size(175, 32);
            olusturRB.TabIndex = 17;
            olusturRB.TabStop = true;
            olusturRB.Text = "Kullanıcı Oluştur";
            olusturRB.UseVisualStyleBackColor = true;
            olusturRB.CheckedChanged += olusturRB_CheckedChanged;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "aracıguncelle.png");
            ımageList2.Images.SetKeyName(1, "kullaniciolustur.png");
            ımageList2.Images.SetKeyName(2, "kullanicisil.png");
            // 
            // KullaniciIslemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 653);
            Controls.Add(olusturRB);
            Controls.Add(sifreDegistirRB);
            Controls.Add(silRB);
            Controls.Add(olusturGB);
            Controls.Add(sifreDegistirGB);
            Controls.Add(silGB);
            Controls.Add(cikisBTN);
            Controls.Add(profilBTN);
            Controls.Add(aracFiyatBTN);
            Controls.Add(aracKiralamaBTN);
            Controls.Add(crudBTN);
            Controls.Add(aracEkleBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KullaniciIslemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı İşlem Formu";
            FormClosed += KullaniciIslemForm_FormClosed;
            Load += KullaniciIslemForm_Load;
            silGB.ResumeLayout(false);
            silGB.PerformLayout();
            sifreDegistirGB.ResumeLayout(false);
            sifreDegistirGB.PerformLayout();
            olusturGB.ResumeLayout(false);
            olusturGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cikisBTN;
        private Button profilBTN;
        private Button aracFiyatBTN;
        private Button aracKiralamaBTN;
        private Button crudBTN;
        private Button aracEkleBTN;
        private GroupBox silGB;
        private Button kullaniciSilBTN;
        private Label label1;
        private TextBox deleteKullaniciAdi;
        private GroupBox sifreDegistirGB;
        private TextBox sifreDegisSifre;
        private Label label3;
        private TextBox sifreDegisKullaniciAdi;
        private Label label2;
        private Button sifreDegistirBTN;
        private GroupBox olusturGB;
        private TextBox olusturSifre;
        private Label label4;
        private TextBox olusturKullaniciAdi;
        private Label label5;
        private Button kullaniciOlusturBTN;
        private ImageList ımageList1;
        private TextBox olusturSoyad;
        private Label label7;
        private TextBox olusturAd;
        private Label label6;
        private RadioButton silRB;
        private RadioButton sifreDegistirRB;
        private RadioButton olusturRB;
        private ImageList ımageList2;
    }
}