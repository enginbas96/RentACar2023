namespace RentACar2023
{
    partial class AracFiyatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracFiyatForm));
            cikisBTN = new Button();
            ımageList1 = new ImageList(components);
            profilBTN = new Button();
            aracFiyatBTN = new Button();
            aracKiralamaBTN = new Button();
            crudBTN = new Button();
            aracEkleBTN = new Button();
            veriGoruntuleyici = new DataGridView();
            label19 = new Label();
            plakaText = new TextBox();
            gunlukFiyatText = new TextBox();
            label1 = new Label();
            yeniFiyatText = new TextBox();
            label2 = new Label();
            guncelleBTN = new Button();
            ımageList2 = new ImageList(components);
            haftalikFiyatText = new TextBox();
            label3 = new Label();
            kmBasinaText = new TextBox();
            label4 = new Label();
            gunlukDegisimRB = new RadioButton();
            kmBasinaDegisimRB = new RadioButton();
            kullaniciAdi = new Label();
            ((System.ComponentModel.ISupportInitialize)veriGoruntuleyici).BeginInit();
            SuspendLayout();
            // 
            // cikisBTN
            // 
            cikisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            cikisBTN.ImageKey = "cikisyap.png";
            cikisBTN.ImageList = ımageList1;
            cikisBTN.Location = new Point(994, 12);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(113, 62);
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
            profilBTN.Location = new Point(819, 12);
            profilBTN.Name = "profilBTN";
            profilBTN.Size = new Size(169, 62);
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
            aracFiyatBTN.Location = new Point(636, 12);
            aracFiyatBTN.Name = "aracFiyatBTN";
            aracFiyatBTN.Size = new Size(177, 62);
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
            aracKiralamaBTN.Location = new Point(410, 12);
            aracKiralamaBTN.Name = "aracKiralamaBTN";
            aracKiralamaBTN.Size = new Size(220, 62);
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
            crudBTN.Location = new Point(218, 12);
            crudBTN.Name = "crudBTN";
            crudBTN.Size = new Size(186, 62);
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
            aracEkleBTN.Size = new Size(200, 62);
            aracEkleBTN.TabIndex = 0;
            aracEkleBTN.Text = "Araç Ekleme İşlemleri";
            aracEkleBTN.TextAlign = ContentAlignment.MiddleRight;
            aracEkleBTN.UseVisualStyleBackColor = true;
            aracEkleBTN.Click += aracEkleBTN_Click;
            // 
            // veriGoruntuleyici
            // 
            veriGoruntuleyici.AllowUserToAddRows = false;
            veriGoruntuleyici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veriGoruntuleyici.Location = new Point(14, 80);
            veriGoruntuleyici.Name = "veriGoruntuleyici";
            veriGoruntuleyici.RowHeadersWidth = 51;
            veriGoruntuleyici.RowTemplate.Height = 29;
            veriGoruntuleyici.RowTemplate.Resizable = DataGridViewTriState.False;
            veriGoruntuleyici.Size = new Size(1093, 270);
            veriGoruntuleyici.TabIndex = 6;
            veriGoruntuleyici.CellClick += veriGoruntuleyici_CellClick;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(221, 372);
            label19.Name = "label19";
            label19.Size = new Size(88, 32);
            label19.TabIndex = 1009;
            label19.Text = "Plaka : ";
            // 
            // plakaText
            // 
            plakaText.Enabled = false;
            plakaText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            plakaText.Location = new Point(315, 374);
            plakaText.Margin = new Padding(3, 4, 3, 4);
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(150, 32);
            plakaText.TabIndex = 7;
            // 
            // gunlukFiyatText
            // 
            gunlukFiyatText.Enabled = false;
            gunlukFiyatText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gunlukFiyatText.Location = new Point(315, 414);
            gunlukFiyatText.Margin = new Padding(3, 4, 3, 4);
            gunlukFiyatText.Name = "gunlukFiyatText";
            gunlukFiyatText.Size = new Size(150, 32);
            gunlukFiyatText.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 412);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 1015;
            label1.Text = "Günlük Fiyat : ";
            // 
            // yeniFiyatText
            // 
            yeniFiyatText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yeniFiyatText.Location = new Point(513, 541);
            yeniFiyatText.Margin = new Padding(3, 4, 3, 4);
            yeniFiyatText.Name = "yeniFiyatText";
            yeniFiyatText.Size = new Size(150, 32);
            yeniFiyatText.TabIndex = 9;
            yeniFiyatText.KeyPress += yeniFiyatText_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(373, 539);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 1017;
            label2.Text = "Yeni Fiyat : ";
            // 
            // guncelleBTN
            // 
            guncelleBTN.ImageAlign = ContentAlignment.MiddleLeft;
            guncelleBTN.ImageKey = "aracıguncelle.png";
            guncelleBTN.ImageList = ımageList2;
            guncelleBTN.Location = new Point(463, 585);
            guncelleBTN.Name = "guncelleBTN";
            guncelleBTN.Size = new Size(160, 56);
            guncelleBTN.TabIndex = 10;
            guncelleBTN.Text = "Fiyatı Güncelle";
            guncelleBTN.TextAlign = ContentAlignment.MiddleRight;
            guncelleBTN.UseVisualStyleBackColor = true;
            guncelleBTN.Click += guncelleBTN_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "aracıguncelle.png");
            // 
            // haftalikFiyatText
            // 
            haftalikFiyatText.Enabled = false;
            haftalikFiyatText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            haftalikFiyatText.Location = new Point(765, 374);
            haftalikFiyatText.Margin = new Padding(3, 4, 3, 4);
            haftalikFiyatText.Name = "haftalikFiyatText";
            haftalikFiyatText.Size = new Size(150, 32);
            haftalikFiyatText.TabIndex = 1018;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(588, 372);
            label3.Name = "label3";
            label3.Size = new Size(171, 32);
            label3.TabIndex = 1019;
            label3.Text = "Haftalık Fiyat : ";
            // 
            // kmBasinaText
            // 
            kmBasinaText.Enabled = false;
            kmBasinaText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kmBasinaText.Location = new Point(765, 414);
            kmBasinaText.Margin = new Padding(3, 4, 3, 4);
            kmBasinaText.Name = "kmBasinaText";
            kmBasinaText.Size = new Size(150, 32);
            kmBasinaText.TabIndex = 1020;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(491, 412);
            label4.Name = "label4";
            label4.Size = new Size(268, 32);
            label4.TabIndex = 1021;
            label4.Text = "Kilometre Başına Fiyat : ";
            // 
            // gunlukDegisimRB
            // 
            gunlukDegisimRB.AutoSize = true;
            gunlukDegisimRB.Enabled = false;
            gunlukDegisimRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunlukDegisimRB.Location = new Point(315, 483);
            gunlukDegisimRB.Name = "gunlukDegisimRB";
            gunlukDegisimRB.Size = new Size(215, 32);
            gunlukDegisimRB.TabIndex = 1022;
            gunlukDegisimRB.TabStop = true;
            gunlukDegisimRB.Text = "Günlük Fiyat Değiştir";
            gunlukDegisimRB.UseVisualStyleBackColor = true;
            // 
            // kmBasinaDegisimRB
            // 
            kmBasinaDegisimRB.AutoSize = true;
            kmBasinaDegisimRB.Enabled = false;
            kmBasinaDegisimRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kmBasinaDegisimRB.Location = new Point(536, 483);
            kmBasinaDegisimRB.Name = "kmBasinaDegisimRB";
            kmBasinaDegisimRB.Size = new Size(183, 32);
            kmBasinaDegisimRB.TabIndex = 1023;
            kmBasinaDegisimRB.TabStop = true;
            kmBasinaDegisimRB.Text = "KM Fiyat Değiştir";
            kmBasinaDegisimRB.UseVisualStyleBackColor = true;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.AutoSize = true;
            kullaniciAdi.Location = new Point(34, 612);
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Size = new Size(0, 20);
            kullaniciAdi.TabIndex = 1024;
            // 
            // AracFiyatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 653);
            Controls.Add(kullaniciAdi);
            Controls.Add(kmBasinaDegisimRB);
            Controls.Add(gunlukDegisimRB);
            Controls.Add(kmBasinaText);
            Controls.Add(label4);
            Controls.Add(haftalikFiyatText);
            Controls.Add(label3);
            Controls.Add(guncelleBTN);
            Controls.Add(yeniFiyatText);
            Controls.Add(label2);
            Controls.Add(gunlukFiyatText);
            Controls.Add(label1);
            Controls.Add(plakaText);
            Controls.Add(label19);
            Controls.Add(veriGoruntuleyici);
            Controls.Add(cikisBTN);
            Controls.Add(profilBTN);
            Controls.Add(aracFiyatBTN);
            Controls.Add(aracKiralamaBTN);
            Controls.Add(crudBTN);
            Controls.Add(aracEkleBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AracFiyatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AracFiyatForm";
            FormClosed += AracFiyatForm_FormClosed;
            Load += AracFiyatForm_Load;
            ((System.ComponentModel.ISupportInitialize)veriGoruntuleyici).EndInit();
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
        private DataGridView veriGoruntuleyici;
        private Label label19;
        private TextBox plakaText;
        private TextBox gunlukFiyatText;
        private Label label1;
        private TextBox yeniFiyatText;
        private Label label2;
        private Button guncelleBTN;
        private TextBox haftalikFiyatText;
        private Label label3;
        private TextBox kmBasinaText;
        private Label label4;
        private RadioButton gunlukDegisimRB;
        private RadioButton kmBasinaDegisimRB;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private Label kullaniciAdi;
    }
}