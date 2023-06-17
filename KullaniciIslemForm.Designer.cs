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
            groupBox1 = new GroupBox();
            kadiDelete = new TextBox();
            label1 = new Label();
            kullaniciSilBTN = new Button();
            groupBox2 = new GroupBox();
            yeniSifre = new TextBox();
            label3 = new Label();
            kadiSifre = new TextBox();
            label2 = new Label();
            sifreDegistirBTN = new Button();
            groupBox3 = new GroupBox();
            sifre = new TextBox();
            label4 = new Label();
            kadiCreate = new TextBox();
            label5 = new Label();
            kullaniciOlusturBTN = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cikisBTN
            // 
            cikisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            cikisBTN.ImageKey = "cikisyap.png";
            cikisBTN.ImageList = ımageList1;
            cikisBTN.Location = new Point(966, 12);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(122, 47);
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
            ımageList1.Images.SetKeyName(0, "kullanici.png");
            ımageList1.Images.SetKeyName(1, "add-group (1).png");
            ımageList1.Images.SetKeyName(2, "cikisyap.png");
            ımageList1.Images.SetKeyName(3, "icon-rent-car.jpg");
            ımageList1.Images.SetKeyName(4, "pngegg (1).png");
            ımageList1.Images.SetKeyName(5, "pngegg (2).png");
            ımageList1.Images.SetKeyName(6, "pngegg (4).png");
            ımageList1.Images.SetKeyName(7, "pngegg.png");
            ımageList1.Images.SetKeyName(8, "pngegg (7).png");
            ımageList1.Images.SetKeyName(9, "kullanicisil.png");
            // 
            // profilBTN
            // 
            profilBTN.ImageAlign = ContentAlignment.MiddleLeft;
            profilBTN.ImageKey = "kullanici.png";
            profilBTN.ImageList = ımageList1;
            profilBTN.Location = new Point(794, 12);
            profilBTN.Name = "profilBTN";
            profilBTN.Size = new Size(166, 47);
            profilBTN.TabIndex = 4;
            profilBTN.Text = "Kullanıcı İşlemleri";
            profilBTN.TextAlign = ContentAlignment.MiddleRight;
            profilBTN.UseVisualStyleBackColor = true;
            profilBTN.Click += profilBTN_Click;
            // 
            // aracFiyatBTN
            // 
            aracFiyatBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracFiyatBTN.ImageKey = "pngegg (4).png";
            aracFiyatBTN.ImageList = ımageList1;
            aracFiyatBTN.Location = new Point(611, 12);
            aracFiyatBTN.Name = "aracFiyatBTN";
            aracFiyatBTN.Size = new Size(177, 47);
            aracFiyatBTN.TabIndex = 3;
            aracFiyatBTN.Text = "Araç Fiyat İşlemleri";
            aracFiyatBTN.TextAlign = ContentAlignment.MiddleRight;
            aracFiyatBTN.UseVisualStyleBackColor = true;
            aracFiyatBTN.Click += aracFiyatBTN_Click;
            // 
            // aracKiralamaBTN
            // 
            aracKiralamaBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracKiralamaBTN.ImageKey = "icon-rent-car.jpg";
            aracKiralamaBTN.ImageList = ımageList1;
            aracKiralamaBTN.Location = new Point(404, 12);
            aracKiralamaBTN.Name = "aracKiralamaBTN";
            aracKiralamaBTN.Size = new Size(201, 47);
            aracKiralamaBTN.TabIndex = 2;
            aracKiralamaBTN.Text = "Araç Kiralama İşlemleri";
            aracKiralamaBTN.TextAlign = ContentAlignment.MiddleRight;
            aracKiralamaBTN.UseVisualStyleBackColor = true;
            aracKiralamaBTN.Click += aracKiralamaBTN_Click;
            // 
            // crudBTN
            // 
            crudBTN.ImageAlign = ContentAlignment.MiddleLeft;
            crudBTN.ImageKey = "pngegg (2).png";
            crudBTN.ImageList = ımageList1;
            crudBTN.Location = new Point(210, 12);
            crudBTN.Name = "crudBTN";
            crudBTN.Size = new Size(188, 47);
            crudBTN.TabIndex = 1;
            crudBTN.Text = "Araç CRUD İşlemleri";
            crudBTN.TextAlign = ContentAlignment.MiddleRight;
            crudBTN.UseVisualStyleBackColor = true;
            crudBTN.Click += crudBTN_Click;
            // 
            // aracEkleBTN
            // 
            aracEkleBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracEkleBTN.ImageKey = "pngegg (1).png";
            aracEkleBTN.ImageList = ımageList1;
            aracEkleBTN.Location = new Point(12, 12);
            aracEkleBTN.Name = "aracEkleBTN";
            aracEkleBTN.Size = new Size(192, 47);
            aracEkleBTN.TabIndex = 0;
            aracEkleBTN.Text = "Araç Ekleme İşlemleri";
            aracEkleBTN.TextAlign = ContentAlignment.MiddleRight;
            aracEkleBTN.UseVisualStyleBackColor = true;
            aracEkleBTN.Click += aracEkleBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(kadiDelete);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(kullaniciSilBTN);
            groupBox1.Location = new Point(24, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 336);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Sil";
            // 
            // kadiDelete
            // 
            kadiDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kadiDelete.Location = new Point(35, 86);
            kadiDelete.Name = "kadiDelete";
            kadiDelete.Size = new Size(211, 32);
            kadiDelete.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 51);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // kullaniciSilBTN
            // 
            kullaniciSilBTN.ImageAlign = ContentAlignment.MiddleLeft;
            kullaniciSilBTN.ImageKey = "kullanicisil.png";
            kullaniciSilBTN.ImageList = ımageList1;
            kullaniciSilBTN.Location = new Point(64, 233);
            kullaniciSilBTN.Name = "kullaniciSilBTN";
            kullaniciSilBTN.Size = new Size(145, 52);
            kullaniciSilBTN.TabIndex = 7;
            kullaniciSilBTN.Text = "Kullanıcıyı Sil";
            kullaniciSilBTN.TextAlign = ContentAlignment.MiddleRight;
            kullaniciSilBTN.UseVisualStyleBackColor = true;
            kullaniciSilBTN.Click += kullaniciSilBTN_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(yeniSifre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(kadiSifre);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(sifreDegistirBTN);
            groupBox2.Location = new Point(390, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 336);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şifre Değiştir";
            // 
            // yeniSifre
            // 
            yeniSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yeniSifre.Location = new Point(38, 168);
            yeniSifre.Name = "yeniSifre";
            yeniSifre.Size = new Size(211, 32);
            yeniSifre.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 134);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 3;
            label3.Text = "Yeni Şifre";
            // 
            // kadiSifre
            // 
            kadiSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kadiSifre.Location = new Point(38, 86);
            kadiSifre.Name = "kadiSifre";
            kadiSifre.Size = new Size(211, 32);
            kadiSifre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 52);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // sifreDegistirBTN
            // 
            sifreDegistirBTN.ImageAlign = ContentAlignment.MiddleLeft;
            sifreDegistirBTN.ImageKey = "pngegg (7).png";
            sifreDegistirBTN.ImageList = ımageList1;
            sifreDegistirBTN.Location = new Point(65, 233);
            sifreDegistirBTN.Name = "sifreDegistirBTN";
            sifreDegistirBTN.Size = new Size(150, 52);
            sifreDegistirBTN.TabIndex = 10;
            sifreDegistirBTN.Text = "Şifre Değiştir";
            sifreDegistirBTN.TextAlign = ContentAlignment.MiddleRight;
            sifreDegistirBTN.UseVisualStyleBackColor = true;
            sifreDegistirBTN.Click += sifreDegistirBTN_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(sifre);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(kadiCreate);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(kullaniciOlusturBTN);
            groupBox3.Location = new Point(756, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(338, 336);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kullanıcı Oluştur";
            // 
            // sifre
            // 
            sifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sifre.Location = new Point(38, 168);
            sifre.Name = "sifre";
            sifre.Size = new Size(211, 32);
            sifre.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 134);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            // 
            // kadiCreate
            // 
            kadiCreate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kadiCreate.Location = new Point(38, 86);
            kadiCreate.Name = "kadiCreate";
            kadiCreate.Size = new Size(211, 32);
            kadiCreate.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 52);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 1;
            label5.Text = "Kullanıcı Adı";
            // 
            // kullaniciOlusturBTN
            // 
            kullaniciOlusturBTN.ImageAlign = ContentAlignment.MiddleLeft;
            kullaniciOlusturBTN.ImageKey = "pngegg.png";
            kullaniciOlusturBTN.ImageList = ımageList1;
            kullaniciOlusturBTN.Location = new Point(61, 233);
            kullaniciOlusturBTN.Name = "kullaniciOlusturBTN";
            kullaniciOlusturBTN.Size = new Size(166, 52);
            kullaniciOlusturBTN.TabIndex = 13;
            kullaniciOlusturBTN.Text = "Kullanıcı Oluştur";
            kullaniciOlusturBTN.TextAlign = ContentAlignment.MiddleRight;
            kullaniciOlusturBTN.UseVisualStyleBackColor = true;
            kullaniciOlusturBTN.Click += kullaniciOlusturBTN_Click;
            // 
            // KullaniciIslemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 653);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            Load += KullaniciIslemForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cikisBTN;
        private Button profilBTN;
        private Button aracFiyatBTN;
        private Button aracKiralamaBTN;
        private Button crudBTN;
        private Button aracEkleBTN;
        private GroupBox groupBox1;
        private Button kullaniciSilBTN;
        private Label label1;
        private TextBox kadiDelete;
        private GroupBox groupBox2;
        private TextBox yeniSifre;
        private Label label3;
        private TextBox kadiSifre;
        private Label label2;
        private Button sifreDegistirBTN;
        private GroupBox groupBox3;
        private TextBox sifre;
        private Label label4;
        private TextBox kadiCreate;
        private Label label5;
        private Button kullaniciOlusturBTN;
        private ImageList ımageList1;
    }
}