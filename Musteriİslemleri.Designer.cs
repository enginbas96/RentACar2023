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
            olusturGB = new GroupBox();
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
            sifreDegistirGB = new GroupBox();
            sifreDegisSifre = new TextBox();
            label3 = new Label();
            sifreDegisTC = new TextBox();
            label2 = new Label();
            msifreDegistirBTN = new Button();
            silGB = new GroupBox();
            deleteTC = new TextBox();
            label1 = new Label();
            musteriSilBTN = new Button();
            olusturGB.SuspendLayout();
            sifreDegistirGB.SuspendLayout();
            silGB.SuspendLayout();
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
            // 
            // olusturGB
            // 
            olusturGB.Controls.Add(molusturTelNo);
            olusturGB.Controls.Add(label8);
            olusturGB.Controls.Add(molusturSoyad);
            olusturGB.Controls.Add(label7);
            olusturGB.Controls.Add(molusturAd);
            olusturGB.Controls.Add(label6);
            olusturGB.Controls.Add(molusturSifre);
            olusturGB.Controls.Add(label4);
            olusturGB.Controls.Add(molusturTC);
            olusturGB.Controls.Add(label5);
            olusturGB.Controls.Add(musteriOlusturBTN);
            olusturGB.Location = new Point(733, 123);
            olusturGB.Name = "olusturGB";
            olusturGB.Size = new Size(338, 484);
            olusturGB.TabIndex = 21;
            olusturGB.TabStop = false;
            olusturGB.Text = "Müşteri Oluştur";
            // 
            // molusturTelNo
            // 
            molusturTelNo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            molusturTelNo.Location = new Point(62, 373);
            molusturTelNo.MaxLength = 30;
            molusturTelNo.Name = "molusturTelNo";
            molusturTelNo.Size = new Size(211, 32);
            molusturTelNo.TabIndex = 19;
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
            molusturSifre.MaxLength = 30;
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
            molusturTC.MaxLength = 30;
            molusturTC.Name = "molusturTC";
            molusturTC.Size = new Size(211, 32);
            molusturTC.TabIndex = 11;
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
            musteriOlusturBTN.Click += kullaniciOlusturBTN_Click;
            // 
            // sifreDegistirGB
            // 
            sifreDegistirGB.Controls.Add(sifreDegisSifre);
            sifreDegistirGB.Controls.Add(label3);
            sifreDegistirGB.Controls.Add(sifreDegisTC);
            sifreDegistirGB.Controls.Add(label2);
            sifreDegistirGB.Controls.Add(msifreDegistirBTN);
            sifreDegistirGB.Location = new Point(367, 123);
            sifreDegistirGB.Name = "sifreDegistirGB";
            sifreDegistirGB.Size = new Size(338, 484);
            sifreDegistirGB.TabIndex = 20;
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
            // sifreDegisTC
            // 
            sifreDegisTC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sifreDegisTC.Location = new Point(60, 136);
            sifreDegisTC.MaxLength = 30;
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
            // 
            // silGB
            // 
            silGB.Controls.Add(deleteTC);
            silGB.Controls.Add(label1);
            silGB.Controls.Add(musteriSilBTN);
            silGB.Location = new Point(1, 123);
            silGB.Name = "silGB";
            silGB.Size = new Size(338, 484);
            silGB.TabIndex = 19;
            silGB.TabStop = false;
            silGB.Text = "Müşteri Sil";
            // 
            // deleteTC
            // 
            deleteTC.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            deleteTC.Location = new Point(60, 186);
            deleteTC.MaxLength = 30;
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
            // 
            // Musteriİslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 664);
            Controls.Add(kullaniciAdi);
            Controls.Add(olusturRB);
            Controls.Add(sifreDegistirRB);
            Controls.Add(silRB);
            Controls.Add(olusturGB);
            Controls.Add(sifreDegistirGB);
            Controls.Add(silGB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Musteriİslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri İşlemleri";
            FormClosed += MusteriKayit_FormClosed;
            olusturGB.ResumeLayout(false);
            olusturGB.PerformLayout();
            sifreDegistirGB.ResumeLayout(false);
            sifreDegistirGB.PerformLayout();
            silGB.ResumeLayout(false);
            silGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList ımageList1;
        private Label kullaniciAdi;
        private RadioButton olusturRB;
        private RadioButton sifreDegistirRB;
        private RadioButton silRB;
        private GroupBox olusturGB;
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
        private GroupBox sifreDegistirGB;
        private TextBox sifreDegisSifre;
        private Label label3;
        private TextBox sifreDegisTC;
        private Label label2;
        private Button msifreDegistirBTN;
        private GroupBox silGB;
        private TextBox deleteTC;
        private Label label1;
        private Button musteriSilBTN;
    }
}