namespace RentACar2023
{
    partial class Musteriİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriİslemleri));
            ımageList1 = new ImageList(components);
            kullaniciAdi = new Label();
            olusturRB = new RadioButton();
            sifreDegistirRB = new RadioButton();
            silRB = new RadioButton();
            molusturGB = new GroupBox();
            molusturTelNo = new TextBox();
            label8 = new Label();
            molusturSoyad = new TextBox();
            label7 = new Label();
            molusturAd = new TextBox();
            label6 = new Label();
            molusturSifre = new TextBox();
            label4 = new Label();
            molusturTC = new TextBox();
            label5 = new Label();
            musteriOlusturBTN = new Button();
            mSifreDegistirGB = new GroupBox();
            sifreDegisSifre = new TextBox();
            label3 = new Label();
            sifreDegisTC = new TextBox();
            label2 = new Label();
            msifreDegistirBTN = new Button();
            mSilGB = new GroupBox();
            deleteTC = new TextBox();
            label1 = new Label();
            musteriSilBTN = new Button();
            geriBTN = new Button();
            molusturGB.SuspendLayout();
            mSifreDegistirGB.SuspendLayout();
            mSilGB.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "geridon.png");
            ımageList1.Images.SetKeyName(1, "aracıguncelle.png");
            ımageList1.Images.SetKeyName(2, "kullaniciolustur.png");
            ımageList1.Images.SetKeyName(3, "kullanicisil.png");
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.AutoSize = true;
            kullaniciAdi.Location = new Point(-3, 581);
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Size = new Size(0, 20);
            kullaniciAdi.TabIndex = 25;
            // 
            // olusturRB
            // 
            olusturRB.AutoSize = true;
            olusturRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            olusturRB.Location = new Point(733, 64);
            olusturRB.Name = "olusturRB";
            olusturRB.Size = new Size(168, 32);
            olusturRB.TabIndex = 24;
            olusturRB.TabStop = true;
            olusturRB.Text = "Müşteri Oluştur";
            olusturRB.UseVisualStyleBackColor = true;
            olusturRB.CheckedChanged += olusturRB_CheckedChanged;
            // 
            // sifreDegistirRB
            // 
            sifreDegistirRB.AutoSize = true;
            sifreDegistirRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sifreDegistirRB.Location = new Point(367, 64);
            sifreDegistirRB.Name = "sifreDegistirRB";
            sifreDegistirRB.Size = new Size(145, 32);
            sifreDegistirRB.TabIndex = 23;
            sifreDegistirRB.TabStop = true;
            sifreDegistirRB.Text = "Şifre Değiştir";
            sifreDegistirRB.UseVisualStyleBackColor = true;
            sifreDegistirRB.CheckedChanged += sifreDegistirRB_CheckedChanged;
            // 
            // silRB
            // 
            silRB.AutoSize = true;
            silRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            silRB.Location = new Point(1, 64);
            silRB.Name = "silRB";
            silRB.Size = new Size(125, 32);
            silRB.TabIndex = 22;
            silRB.TabStop = true;
            silRB.Text = "Müşteri Sil";
            silRB.UseVisualStyleBackColor = true;
            silRB.CheckedChanged += silRB_CheckedChanged;
            // 
            // molusturGB
            // 
            molusturGB.Controls.Add(molusturTelNo);
            molusturGB.Controls.Add(label8);
            molusturGB.Controls.Add(molusturSoyad);
            molusturGB.Controls.Add(label7);
            molusturGB.Controls.Add(molusturAd);
            molusturGB.Controls.Add(label6);
            molusturGB.Controls.Add(molusturSifre);
            molusturGB.Controls.Add(label4);
            molusturGB.Controls.Add(molusturTC);
            molusturGB.Controls.Add(label5);
            molusturGB.Controls.Add(musteriOlusturBTN);
            molusturGB.Location = new Point(733, 123);
            molusturGB.Name = "molusturGB";
            molusturGB.Size = new Size(338, 484);
            molusturGB.TabIndex = 21;
            molusturGB.TabStop = false;
            molusturGB.Text = "Müşteri Oluştur";
            // 
            // molusturTelNo
            // 
            molusturTelNo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            molusturTelNo.Location = new Point(62, 373);
            molusturTelNo.MaxLength = 11;
            molusturTelNo.Name = "molusturTelNo";
            molusturTelNo.Size = new Size(211, 32);
            molusturTelNo.TabIndex = 19;
            molusturTelNo.KeyPress += molusturTelNo_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(55, 338);
            label8.Name = "label8";
            label8.Size = new Size(201, 32);
            label8.TabIndex = 18;
            label8.Text = "Telefon Numarası";
            // 
            // molusturSoyad
            // 
            molusturSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            molusturSoyad.Location = new Point(62, 286);
            molusturSoyad.MaxLength = 30;
            molusturSoyad.Name = "molusturSoyad";
            molusturSoyad.Size = new Size(211, 32);
            molusturSoyad.TabIndex = 17;
            molusturSoyad.TextChanged += molusturSoyad_TextChanged;
            molusturSoyad.KeyPress += molusturSoyad_KeyPress;
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
            // molusturAd
            // 
            molusturAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            molusturAd.Location = new Point(62, 211);
            molusturAd.MaxLength = 30;
            molusturAd.Name = "molusturAd";
            molusturAd.Size = new Size(211, 32);
            molusturAd.TabIndex = 15;
            molusturAd.TextChanged += molusturAd_TextChanged;
            molusturAd.KeyPress += molusturAd_KeyPress;
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
            // molusturSifre
            // 
            molusturSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            molusturSifre.Location = new Point(62, 136);
            molusturSifre.MaxLength = 11;
            molusturSifre.Name = "molusturSifre";
            molusturSifre.Size = new Size(211, 32);
            molusturSifre.TabIndex = 12;
            molusturSifre.UseSystemPasswordChar = true;
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
            // molusturTC
            // 
            molusturTC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            molusturTC.Location = new Point(62, 61);
            molusturTC.MaxLength = 11;
            molusturTC.Name = "molusturTC";
            molusturTC.Size = new Size(211, 32);
            molusturTC.TabIndex = 11;
            molusturTC.KeyPress += molusturTC_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 26);
            label5.Name = "label5";
            label5.Size = new Size(41, 32);
            label5.TabIndex = 1;
            label5.Text = "TC";
            // 
            // musteriOlusturBTN
            // 
            musteriOlusturBTN.ImageAlign = ContentAlignment.MiddleLeft;
            musteriOlusturBTN.ImageKey = "kullaniciolustur.png";
            musteriOlusturBTN.ImageList = ımageList1;
            musteriOlusturBTN.Location = new Point(90, 419);
            musteriOlusturBTN.Name = "musteriOlusturBTN";
            musteriOlusturBTN.Size = new Size(166, 52);
            musteriOlusturBTN.TabIndex = 13;
            musteriOlusturBTN.Text = "Müşteri Oluştur";
            musteriOlusturBTN.TextAlign = ContentAlignment.MiddleRight;
            musteriOlusturBTN.UseVisualStyleBackColor = true;
            musteriOlusturBTN.Click += musteriOlusturBTN_Click;
            // 
            // mSifreDegistirGB
            // 
            mSifreDegistirGB.Controls.Add(sifreDegisSifre);
            mSifreDegistirGB.Controls.Add(label3);
            mSifreDegistirGB.Controls.Add(sifreDegisTC);
            mSifreDegistirGB.Controls.Add(label2);
            mSifreDegistirGB.Controls.Add(msifreDegistirBTN);
            mSifreDegistirGB.Location = new Point(367, 123);
            mSifreDegistirGB.Name = "mSifreDegistirGB";
            mSifreDegistirGB.Size = new Size(338, 484);
            mSifreDegistirGB.TabIndex = 20;
            mSifreDegistirGB.TabStop = false;
            mSifreDegistirGB.Text = "Şifre Değiştir";
            // 
            // sifreDegisSifre
            // 
            sifreDegisSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sifreDegisSifre.Location = new Point(60, 218);
            sifreDegisSifre.MaxLength = 11;
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
            // sifreDegisTC
            // 
            sifreDegisTC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sifreDegisTC.Location = new Point(60, 136);
            sifreDegisTC.MaxLength = 11;
            sifreDegisTC.Name = "sifreDegisTC";
            sifreDegisTC.Size = new Size(211, 32);
            sifreDegisTC.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 102);
            label2.Name = "label2";
            label2.Size = new Size(41, 32);
            label2.TabIndex = 1;
            label2.Text = "TC";
            // 
            // msifreDegistirBTN
            // 
            msifreDegistirBTN.ImageAlign = ContentAlignment.MiddleLeft;
            msifreDegistirBTN.ImageKey = "aracıguncelle.png";
            msifreDegistirBTN.ImageList = ımageList1;
            msifreDegistirBTN.Location = new Point(83, 338);
            msifreDegistirBTN.Name = "msifreDegistirBTN";
            msifreDegistirBTN.Size = new Size(158, 52);
            msifreDegistirBTN.TabIndex = 10;
            msifreDegistirBTN.Text = "Şifre Değiştir";
            msifreDegistirBTN.TextAlign = ContentAlignment.MiddleRight;
            msifreDegistirBTN.UseVisualStyleBackColor = true;
            msifreDegistirBTN.Click += msifreDegistirBTN_Click;
            // 
            // mSilGB
            // 
            mSilGB.Controls.Add(deleteTC);
            mSilGB.Controls.Add(label1);
            mSilGB.Controls.Add(musteriSilBTN);
            mSilGB.Location = new Point(1, 123);
            mSilGB.Name = "mSilGB";
            mSilGB.Size = new Size(338, 484);
            mSilGB.TabIndex = 19;
            mSilGB.TabStop = false;
            mSilGB.Text = "Müşteri Sil";
            // 
            // deleteTC
            // 
            deleteTC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            deleteTC.Location = new Point(60, 186);
            deleteTC.MaxLength = 11;
            deleteTC.Name = "deleteTC";
            deleteTC.Size = new Size(211, 32);
            deleteTC.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 150);
            label1.Name = "label1";
            label1.Size = new Size(41, 32);
            label1.TabIndex = 1;
            label1.Text = "TC";
            // 
            // musteriSilBTN
            // 
            musteriSilBTN.ImageAlign = ContentAlignment.MiddleLeft;
            musteriSilBTN.ImageKey = "kullanicisil.png";
            musteriSilBTN.ImageList = ımageList1;
            musteriSilBTN.Location = new Point(87, 338);
            musteriSilBTN.Name = "musteriSilBTN";
            musteriSilBTN.Size = new Size(145, 52);
            musteriSilBTN.TabIndex = 7;
            musteriSilBTN.Text = "Müşteriyi Sil";
            musteriSilBTN.TextAlign = ContentAlignment.MiddleRight;
            musteriSilBTN.UseVisualStyleBackColor = true;
            musteriSilBTN.Click += musteriSilBTN_Click;
            // 
            // geriBTN
            // 
            geriBTN.Location = new Point(461, 623);
            geriBTN.Name = "geriBTN";
            geriBTN.Size = new Size(130, 29);
            geriBTN.TabIndex = 26;
            geriBTN.Text = "Geri Dön";
            geriBTN.UseVisualStyleBackColor = true;
            geriBTN.Click += geriBTN_Click_1;
            // 
            // Musteriİslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 664);
            Controls.Add(geriBTN);
            Controls.Add(kullaniciAdi);
            Controls.Add(olusturRB);
            Controls.Add(sifreDegistirRB);
            Controls.Add(silRB);
            Controls.Add(molusturGB);
            Controls.Add(mSifreDegistirGB);
            Controls.Add(mSilGB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Musteriİslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri İşlemleri";
            FormClosed += MusteriKayit_FormClosed;
            molusturGB.ResumeLayout(false);
            molusturGB.PerformLayout();
            mSifreDegistirGB.ResumeLayout(false);
            mSifreDegistirGB.PerformLayout();
            mSilGB.ResumeLayout(false);
            mSilGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList ımageList1;
        private Label kullaniciAdi;
        private RadioButton olusturRB;
        private RadioButton sifreDegistirRB;
        private RadioButton silRB;
        private GroupBox molusturGB;
        private TextBox molusturTelNo;
        private Label label8;
        private TextBox molusturSoyad;
        private Label label7;
        private TextBox molusturAd;
        private Label label6;
        private TextBox molusturSifre;
        private Label label4;
        private TextBox molusturTC;
        private Label label5;
        private Button musteriOlusturBTN;
        private GroupBox mSifreDegistirGB;
        private TextBox sifreDegisSifre;
        private Label label3;
        private TextBox sifreDegisTC;
        private Label label2;
        private Button msifreDegistirBTN;
        private GroupBox mSilGB;
        private TextBox deleteTC;
        private Label label1;
        private Button musteriSilBTN;
        private Button geriBTN;
    }
}