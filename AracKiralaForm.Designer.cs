namespace RentACar2023
{
    partial class AracKiralaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracKiralaForm));
            cikisBTN = new Button();
            ımageList1 = new ImageList(components);
            profilBTN = new Button();
            aracFiyatBTN = new Button();
            aracKiralamaBTN = new Button();
            crudBTN = new Button();
            aracEkleBTN = new Button();
            kiralaBTN = new Button();
            teslimTarihi = new DateTimePicker();
            kiralamaTarihi = new DateTimePicker();
            telefonText = new TextBox();
            soyadText = new TextBox();
            adText = new TextBox();
            tcText = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            plakaCB = new ComboBox();
            label19 = new Label();
            ımageList2 = new ImageList(components);
            SuspendLayout();
            // 
            // cikisBTN
            // 
            cikisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            cikisBTN.ImageKey = "cikisyap.png";
            cikisBTN.ImageList = ımageList1;
            cikisBTN.Location = new Point(991, 12);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(116, 51);
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
            profilBTN.Location = new Point(823, 12);
            profilBTN.Name = "profilBTN";
            profilBTN.Size = new Size(162, 51);
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
            aracFiyatBTN.Location = new Point(639, 12);
            aracFiyatBTN.Name = "aracFiyatBTN";
            aracFiyatBTN.Size = new Size(178, 51);
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
            aracKiralamaBTN.Location = new Point(423, 12);
            aracKiralamaBTN.Name = "aracKiralamaBTN";
            aracKiralamaBTN.Size = new Size(212, 51);
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
            crudBTN.Location = new Point(228, 12);
            crudBTN.Name = "crudBTN";
            crudBTN.Size = new Size(189, 51);
            crudBTN.TabIndex = 1;
            crudBTN.Text = "Araç CRUD İşlemleri";
            crudBTN.TextAlign = ContentAlignment.MiddleRight;
            crudBTN.UseVisualStyleBackColor = true;
            crudBTN.Click += crudBTN_Click;
            // 
            // aracEkleBTN
            // 
            aracEkleBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracEkleBTN.ImageKey = "araccrud.png";
            aracEkleBTN.ImageList = ımageList1;
            aracEkleBTN.Location = new Point(21, 12);
            aracEkleBTN.Name = "aracEkleBTN";
            aracEkleBTN.Size = new Size(201, 51);
            aracEkleBTN.TabIndex = 0;
            aracEkleBTN.Text = "Araç Ekleme İşlemleri";
            aracEkleBTN.TextAlign = ContentAlignment.MiddleRight;
            aracEkleBTN.UseVisualStyleBackColor = true;
            aracEkleBTN.Click += aracEkleBTN_Click;
            // 
            // kiralaBTN
            // 
            kiralaBTN.ImageAlign = ContentAlignment.MiddleLeft;
            kiralaBTN.ImageKey = "kaydet.png";
            kiralaBTN.ImageList = ımageList2;
            kiralaBTN.Location = new Point(228, 513);
            kiralaBTN.Margin = new Padding(3, 4, 3, 4);
            kiralaBTN.Name = "kiralaBTN";
            kiralaBTN.Size = new Size(150, 65);
            kiralaBTN.TabIndex = 13;
            kiralaBTN.Text = "KİRALA";
            kiralaBTN.TextAlign = ContentAlignment.MiddleRight;
            kiralaBTN.UseVisualStyleBackColor = true;
            kiralaBTN.Click += kiralaBTN_Click;
            // 
            // teslimTarihi
            // 
            teslimTarihi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teslimTarihi.Location = new Point(228, 441);
            teslimTarihi.Margin = new Padding(3, 4, 3, 4);
            teslimTarihi.Name = "teslimTarihi";
            teslimTarihi.Size = new Size(150, 32);
            teslimTarihi.TabIndex = 12;
            // 
            // kiralamaTarihi
            // 
            kiralamaTarihi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kiralamaTarihi.Location = new Point(228, 389);
            kiralamaTarihi.Margin = new Padding(3, 4, 3, 4);
            kiralamaTarihi.Name = "kiralamaTarihi";
            kiralamaTarihi.Size = new Size(150, 32);
            kiralamaTarihi.TabIndex = 11;
            // 
            // telefonText
            // 
            telefonText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            telefonText.Location = new Point(228, 340);
            telefonText.Margin = new Padding(3, 4, 3, 4);
            telefonText.MaxLength = 11;
            telefonText.Name = "telefonText";
            telefonText.PlaceholderText = "05XXxxxXXxx";
            telefonText.Size = new Size(150, 32);
            telefonText.TabIndex = 10;
            telefonText.KeyPress += telefonText_KeyPress;
            // 
            // soyadText
            // 
            soyadText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            soyadText.Location = new Point(228, 288);
            soyadText.Margin = new Padding(3, 4, 3, 4);
            soyadText.MaxLength = 50;
            soyadText.Name = "soyadText";
            soyadText.Size = new Size(150, 32);
            soyadText.TabIndex = 9;
            soyadText.TextChanged += soyadText_TextChanged;
            soyadText.KeyPress += soyadText_KeyPress;
            // 
            // adText
            // 
            adText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            adText.Location = new Point(228, 243);
            adText.Margin = new Padding(3, 4, 3, 4);
            adText.MaxLength = 50;
            adText.Name = "adText";
            adText.Size = new Size(150, 32);
            adText.TabIndex = 8;
            adText.TextChanged += adText_TextChanged;
            adText.KeyPress += adText_KeyPress;
            // 
            // tcText
            // 
            tcText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tcText.Location = new Point(228, 198);
            tcText.Margin = new Padding(3, 4, 3, 4);
            tcText.MaxLength = 11;
            tcText.Name = "tcText";
            tcText.Size = new Size(150, 32);
            tcText.TabIndex = 7;
            tcText.KeyPress += tcText_KeyPress;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(59, 441);
            label25.Name = "label25";
            label25.Size = new Size(163, 32);
            label25.TabIndex = 28;
            label25.Text = "Teslim Tarihi : ";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(35, 389);
            label24.Name = "label24";
            label24.Size = new Size(187, 32);
            label24.TabIndex = 27;
            label24.Text = "Kiralama Tarihi : ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(71, 340);
            label23.Name = "label23";
            label23.Size = new Size(151, 32);
            label23.TabIndex = 26;
            label23.Text = "Telefon No : ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(118, 288);
            label22.Name = "label22";
            label22.Size = new Size(104, 32);
            label22.TabIndex = 25;
            label22.Text = "Soyadı : ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(154, 243);
            label21.Name = "label21";
            label21.Size = new Size(68, 32);
            label21.TabIndex = 24;
            label21.Text = "Adı : ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(51, 198);
            label20.Name = "label20";
            label20.Size = new Size(171, 32);
            label20.TabIndex = 23;
            label20.Text = "TC Kimlik No : ";
            // 
            // plakaCB
            // 
            plakaCB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            plakaCB.FormattingEnabled = true;
            plakaCB.Location = new Point(228, 150);
            plakaCB.Name = "plakaCB";
            plakaCB.Size = new Size(150, 33);
            plakaCB.TabIndex = 6;
            plakaCB.SelectedIndexChanged += plakaCB_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(134, 150);
            label19.Name = "label19";
            label19.Size = new Size(88, 32);
            label19.TabIndex = 22;
            label19.Text = "Plaka : ";
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "kaydet.png");
            // 
            // AracKiralaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 653);
            Controls.Add(kiralaBTN);
            Controls.Add(teslimTarihi);
            Controls.Add(kiralamaTarihi);
            Controls.Add(telefonText);
            Controls.Add(soyadText);
            Controls.Add(adText);
            Controls.Add(tcText);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(plakaCB);
            Controls.Add(label19);
            Controls.Add(cikisBTN);
            Controls.Add(profilBTN);
            Controls.Add(aracKiralamaBTN);
            Controls.Add(aracFiyatBTN);
            Controls.Add(aracEkleBTN);
            Controls.Add(crudBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AracKiralaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AracKiralaForm";
            FormClosed += AracKiralaForm_FormClosed;
            Load += AracKiralaForm_Load;
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
        private Button kiralaBTN;
        private DateTimePicker teslimTarihi;
        private DateTimePicker kiralamaTarihi;
        private TextBox telefonText;
        private TextBox soyadText;
        private TextBox adText;
        private TextBox tcText;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private ComboBox plakaCB;
        private Label label19;
        private ImageList ımageList1;
        private ImageList ımageList2;
    }
}