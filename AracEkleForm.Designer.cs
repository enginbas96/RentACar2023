namespace RentACar2023
{
    partial class AracEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkleForm));
            aracEkleBTN = new Button();
            ımageList1 = new ImageList(components);
            crudBTN = new Button();
            aracKiralamaBTN = new Button();
            aracFiyatBTN = new Button();
            profilBTN = new Button();
            cikisBTN = new Button();
            ekleBTN = new Button();
            vitesCB = new ComboBox();
            kmText = new TextBox();
            renkText = new TextBox();
            hasarText = new TextBox();
            yakitTuruCB = new ComboBox();
            modelText = new TextBox();
            markaText = new TextBox();
            plakaText = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            koltukSayiCB = new ComboBox();
            SuspendLayout();
            // 
            // aracEkleBTN
            // 
            aracEkleBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracEkleBTN.ImageKey = "(yok)";
            aracEkleBTN.ImageList = ımageList1;
            aracEkleBTN.Location = new Point(17, 12);
            aracEkleBTN.Name = "aracEkleBTN";
            aracEkleBTN.Size = new Size(190, 47);
            aracEkleBTN.TabIndex = 0;
            aracEkleBTN.Text = "Araç Ekleme İşlemleri";
            aracEkleBTN.UseVisualStyleBackColor = true;
            aracEkleBTN.Click += aracEkleBTN_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikisyap.png");
            ımageList1.Images.SetKeyName(1, "icon-rent-car.jpg");
            ımageList1.Images.SetKeyName(2, "kullanici.png");
            ımageList1.Images.SetKeyName(3, "pngegg (1).png");
            ımageList1.Images.SetKeyName(4, "pngegg (2).png");
            ımageList1.Images.SetKeyName(5, "pngegg (4).png");
            ımageList1.Images.SetKeyName(6, "icon-rent-car.jpg");
            ımageList1.Images.SetKeyName(7, "aracekle.png");
            // 
            // crudBTN
            // 
            crudBTN.ImageAlign = ContentAlignment.MiddleLeft;
            crudBTN.ImageKey = "(yok)";
            crudBTN.ImageList = ımageList1;
            crudBTN.Location = new Point(213, 12);
            crudBTN.Name = "crudBTN";
            crudBTN.Size = new Size(186, 47);
            crudBTN.TabIndex = 1;
            crudBTN.Text = "Araç CRUD İşlemleri";
            crudBTN.UseVisualStyleBackColor = true;
            crudBTN.Click += crudBTN_Click;
            // 
            // aracKiralamaBTN
            // 
            aracKiralamaBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracKiralamaBTN.ImageKey = "(yok)";
            aracKiralamaBTN.ImageList = ımageList1;
            aracKiralamaBTN.Location = new Point(405, 12);
            aracKiralamaBTN.Name = "aracKiralamaBTN";
            aracKiralamaBTN.Size = new Size(204, 47);
            aracKiralamaBTN.TabIndex = 2;
            aracKiralamaBTN.Text = "Araç Kiralama İşlemleri";
            aracKiralamaBTN.UseVisualStyleBackColor = true;
            aracKiralamaBTN.Click += aracKiralamaBTN_Click;
            // 
            // aracFiyatBTN
            // 
            aracFiyatBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracFiyatBTN.ImageKey = "(yok)";
            aracFiyatBTN.ImageList = ımageList1;
            aracFiyatBTN.Location = new Point(615, 12);
            aracFiyatBTN.Name = "aracFiyatBTN";
            aracFiyatBTN.Size = new Size(177, 47);
            aracFiyatBTN.TabIndex = 3;
            aracFiyatBTN.Text = "Araç Fiyat İşlemleri";
            aracFiyatBTN.UseVisualStyleBackColor = true;
            aracFiyatBTN.Click += aracFiyatBTN_Click;
            // 
            // profilBTN
            // 
            profilBTN.ImageAlign = ContentAlignment.MiddleLeft;
            profilBTN.ImageKey = "(yok)";
            profilBTN.ImageList = ımageList1;
            profilBTN.Location = new Point(798, 12);
            profilBTN.Name = "profilBTN";
            profilBTN.Size = new Size(166, 47);
            profilBTN.TabIndex = 4;
            profilBTN.Text = "Kullanıcı İşlemleri";
            profilBTN.UseVisualStyleBackColor = true;
            profilBTN.Click += profilBTN_Click;
            // 
            // cikisBTN
            // 
            cikisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            cikisBTN.ImageKey = "(yok)";
            cikisBTN.ImageList = ımageList1;
            cikisBTN.Location = new Point(970, 12);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(120, 47);
            cikisBTN.TabIndex = 5;
            cikisBTN.Text = "Çıkış Yap";
            cikisBTN.UseVisualStyleBackColor = true;
            cikisBTN.Click += cikisBTN_Click;
            // 
            // ekleBTN
            // 
            ekleBTN.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ekleBTN.ImageAlign = ContentAlignment.MiddleLeft;
            ekleBTN.ImageKey = "(yok)";
            ekleBTN.ImageList = ımageList1;
            ekleBTN.Location = new Point(417, 550);
            ekleBTN.Name = "ekleBTN";
            ekleBTN.Size = new Size(285, 72);
            ekleBTN.TabIndex = 15;
            ekleBTN.Text = "Aracı Ekle";
            ekleBTN.UseVisualStyleBackColor = true;
            ekleBTN.Click += ekleBTN_Click;
            // 
            // vitesCB
            // 
            vitesCB.DropDownStyle = ComboBoxStyle.DropDownList;
            vitesCB.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            vitesCB.FormattingEnabled = true;
            vitesCB.Items.AddRange(new object[] { "Otomatik", "Yarı Otomatik", "Manuel" });
            vitesCB.Location = new Point(784, 307);
            vitesCB.Name = "vitesCB";
            vitesCB.Size = new Size(217, 46);
            vitesCB.TabIndex = 14;
            // 
            // kmText
            // 
            kmText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kmText.Location = new Point(784, 192);
            kmText.Name = "kmText";
            kmText.Size = new Size(217, 47);
            kmText.TabIndex = 12;
            // 
            // renkText
            // 
            renkText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            renkText.Location = new Point(784, 136);
            renkText.Name = "renkText";
            renkText.Size = new Size(216, 47);
            renkText.TabIndex = 11;
            // 
            // hasarText
            // 
            hasarText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            hasarText.Location = new Point(263, 360);
            hasarText.Name = "hasarText";
            hasarText.Size = new Size(216, 47);
            hasarText.TabIndex = 10;
            // 
            // yakitTuruCB
            // 
            yakitTuruCB.DropDownStyle = ComboBoxStyle.DropDownList;
            yakitTuruCB.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            yakitTuruCB.FormattingEnabled = true;
            yakitTuruCB.Items.AddRange(new object[] { "Benzin", "Dizel", "Elektirikli", "Hibrit" });
            yakitTuruCB.Location = new Point(263, 306);
            yakitTuruCB.Name = "yakitTuruCB";
            yakitTuruCB.Size = new Size(216, 46);
            yakitTuruCB.TabIndex = 9;
            // 
            // modelText
            // 
            modelText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            modelText.Location = new Point(263, 248);
            modelText.Name = "modelText";
            modelText.Size = new Size(216, 47);
            modelText.TabIndex = 8;
            // 
            // markaText
            // 
            markaText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            markaText.Location = new Point(263, 191);
            markaText.Name = "markaText";
            markaText.Size = new Size(216, 47);
            markaText.TabIndex = 7;
            // 
            // plakaText
            // 
            plakaText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plakaText.Location = new Point(263, 135);
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(216, 47);
            plakaText.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(583, 305);
            label9.Name = "label9";
            label9.Size = new Size(195, 46);
            label9.TabIndex = 27;
            label9.Text = "Vites Türü : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(548, 249);
            label8.Name = "label8";
            label8.Size = new Size(230, 46);
            label8.TabIndex = 26;
            label8.Text = "Koltuk Sayısı : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(682, 192);
            label7.Name = "label7";
            label7.Size = new Size(96, 46);
            label7.TabIndex = 25;
            label7.Text = "KM : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(660, 136);
            label6.Name = "label6";
            label6.Size = new Size(118, 46);
            label6.TabIndex = 24;
            label6.Text = "Renk : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 360);
            label5.Name = "label5";
            label5.Size = new Size(219, 46);
            label5.TabIndex = 23;
            label5.Text = "Hasar Kaydı : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 304);
            label4.Name = "label4";
            label4.Size = new Size(192, 46);
            label4.TabIndex = 22;
            label4.Text = "Yakıt Türü : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(115, 248);
            label3.Name = "label3";
            label3.Size = new Size(142, 46);
            label3.TabIndex = 21;
            label3.Text = "Model : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 191);
            label2.Name = "label2";
            label2.Size = new Size(139, 46);
            label2.TabIndex = 20;
            label2.Text = "Marka : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 135);
            label1.Name = "label1";
            label1.Size = new Size(123, 46);
            label1.TabIndex = 19;
            label1.Text = "Plaka : ";
            // 
            // koltukSayiCB
            // 
            koltukSayiCB.DropDownStyle = ComboBoxStyle.DropDownList;
            koltukSayiCB.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            koltukSayiCB.FormattingEnabled = true;
            koltukSayiCB.Items.AddRange(new object[] { "2", "4", "5" });
            koltukSayiCB.Location = new Point(784, 251);
            koltukSayiCB.Name = "koltukSayiCB";
            koltukSayiCB.Size = new Size(216, 46);
            koltukSayiCB.TabIndex = 13;
            // 
            // AracEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 653);
            Controls.Add(koltukSayiCB);
            Controls.Add(ekleBTN);
            Controls.Add(vitesCB);
            Controls.Add(kmText);
            Controls.Add(renkText);
            Controls.Add(hasarText);
            Controls.Add(yakitTuruCB);
            Controls.Add(modelText);
            Controls.Add(markaText);
            Controls.Add(plakaText);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cikisBTN);
            Controls.Add(profilBTN);
            Controls.Add(aracFiyatBTN);
            Controls.Add(aracKiralamaBTN);
            Controls.Add(crudBTN);
            Controls.Add(aracEkleBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AracEkleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Ekleme Formu";
            FormClosed += AracEkleForm_FormClosed;
            Load += AracEkleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button aracEkleBTN;
        private Button crudBTN;
        private Button aracKiralamaBTN;
        private Button aracFiyatBTN;
        private Button profilBTN;
        private Button cikisBTN;
        private Button ekleBTN;
        private ComboBox vitesCB;
        private TextBox kmText;
        private TextBox renkText;
        private TextBox hasarText;
        private ComboBox yakitTuruCB;
        private TextBox modelText;
        private TextBox markaText;
        private TextBox plakaText;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox koltukSayiCB;
        private ImageList ımageList1;
    }
}