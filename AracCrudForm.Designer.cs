namespace RentACar2023
{
    partial class AracCrudForm
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
            cikisBTN = new Button();
            profilBTN = new Button();
            aracFiyatBTN = new Button();
            aracKiralamaBTN = new Button();
            crudBTN = new Button();
            aracEkleBTN = new Button();
            islemBTN = new Button();
            guncelleRB = new RadioButton();
            silRB = new RadioButton();
            vitesCB = new ComboBox();
            koltukSayiCB = new ComboBox();
            yakitTuruCB = new ComboBox();
            veriGoruntuleyici = new DataGridView();
            hasarText = new RichTextBox();
            kmText = new TextBox();
            renkText = new TextBox();
            modelText = new TextBox();
            markaText = new TextBox();
            plakaText = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)veriGoruntuleyici).BeginInit();
            SuspendLayout();
            // 
            // cikisBTN
            // 
            cikisBTN.Location = new Point(928, 12);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(177, 47);
            cikisBTN.TabIndex = 5;
            cikisBTN.Text = "Çıkış Yap";
            cikisBTN.UseVisualStyleBackColor = true;
            // 
            // profilBTN
            // 
            profilBTN.Location = new Point(745, 12);
            profilBTN.Name = "profilBTN";
            profilBTN.Size = new Size(177, 47);
            profilBTN.TabIndex = 4;
            profilBTN.Text = "Kullanıcı İşlemleri";
            profilBTN.UseVisualStyleBackColor = true;
            // 
            // aracFiyatBTN
            // 
            aracFiyatBTN.Location = new Point(562, 12);
            aracFiyatBTN.Name = "aracFiyatBTN";
            aracFiyatBTN.Size = new Size(177, 47);
            aracFiyatBTN.TabIndex = 3;
            aracFiyatBTN.Text = "Araç Fiyat İşlemleri";
            aracFiyatBTN.UseVisualStyleBackColor = true;
            // 
            // aracKiralamaBTN
            // 
            aracKiralamaBTN.Location = new Point(379, 12);
            aracKiralamaBTN.Name = "aracKiralamaBTN";
            aracKiralamaBTN.Size = new Size(177, 47);
            aracKiralamaBTN.TabIndex = 2;
            aracKiralamaBTN.Text = "Araç Kiralama İşlemleri";
            aracKiralamaBTN.UseVisualStyleBackColor = true;
            // 
            // crudBTN
            // 
            crudBTN.Location = new Point(196, 12);
            crudBTN.Name = "crudBTN";
            crudBTN.Size = new Size(177, 47);
            crudBTN.TabIndex = 1;
            crudBTN.Text = "Araç CRUD İşlemleri";
            crudBTN.UseVisualStyleBackColor = true;
            // 
            // aracEkleBTN
            // 
            aracEkleBTN.Location = new Point(12, 12);
            aracEkleBTN.Name = "aracEkleBTN";
            aracEkleBTN.Size = new Size(177, 47);
            aracEkleBTN.TabIndex = 0;
            aracEkleBTN.Text = "Araç Ekleme İşlemleri";
            aracEkleBTN.UseVisualStyleBackColor = true;
            // 
            // islemBTN
            // 
            islemBTN.Location = new Point(900, 580);
            islemBTN.Name = "islemBTN";
            islemBTN.Size = new Size(175, 61);
            islemBTN.TabIndex = 18;
            islemBTN.Text = "Yapılacak İşlemi Seçiniz";
            islemBTN.UseVisualStyleBackColor = true;
            // 
            // guncelleRB
            // 
            guncelleRB.AutoSize = true;
            guncelleRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guncelleRB.Location = new Point(920, 531);
            guncelleRB.Name = "guncelleRB";
            guncelleRB.Size = new Size(157, 32);
            guncelleRB.TabIndex = 17;
            guncelleRB.TabStop = true;
            guncelleRB.Text = "Aracı Güncelle";
            guncelleRB.UseVisualStyleBackColor = true;
            // 
            // silRB
            // 
            silRB.AutoSize = true;
            silRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            silRB.Location = new Point(793, 531);
            silRB.Name = "silRB";
            silRB.Size = new Size(103, 32);
            silRB.TabIndex = 16;
            silRB.TabStop = true;
            silRB.Text = "Aracı Sil";
            silRB.UseVisualStyleBackColor = true;
            // 
            // vitesCB
            // 
            vitesCB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            vitesCB.FormattingEnabled = true;
            vitesCB.Location = new Point(551, 488);
            vitesCB.Name = "vitesCB";
            vitesCB.Size = new Size(150, 33);
            vitesCB.TabIndex = 14;
            // 
            // koltukSayiCB
            // 
            koltukSayiCB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            koltukSayiCB.FormattingEnabled = true;
            koltukSayiCB.Location = new Point(551, 446);
            koltukSayiCB.Name = "koltukSayiCB";
            koltukSayiCB.Size = new Size(150, 33);
            koltukSayiCB.TabIndex = 13;
            // 
            // yakitTuruCB
            // 
            yakitTuruCB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yakitTuruCB.FormattingEnabled = true;
            yakitTuruCB.Location = new Point(162, 490);
            yakitTuruCB.Name = "yakitTuruCB";
            yakitTuruCB.Size = new Size(150, 33);
            yakitTuruCB.TabIndex = 10;
            // 
            // veriGoruntuleyici
            // 
            veriGoruntuleyici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veriGoruntuleyici.Location = new Point(16, 74);
            veriGoruntuleyici.Name = "veriGoruntuleyici";
            veriGoruntuleyici.RowHeadersWidth = 51;
            veriGoruntuleyici.RowTemplate.Height = 29;
            veriGoruntuleyici.Size = new Size(1093, 270);
            veriGoruntuleyici.TabIndex = 6;
            // 
            // hasarText
            // 
            hasarText.Location = new Point(902, 366);
            hasarText.Name = "hasarText";
            hasarText.Size = new Size(175, 128);
            hasarText.TabIndex = 15;
            hasarText.Text = "";
            // 
            // kmText
            // 
            kmText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kmText.Location = new Point(551, 402);
            kmText.Name = "kmText";
            kmText.Size = new Size(150, 34);
            kmText.TabIndex = 12;
            // 
            // renkText
            // 
            renkText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            renkText.Location = new Point(551, 360);
            renkText.Name = "renkText";
            renkText.Size = new Size(150, 34);
            renkText.TabIndex = 11;
            // 
            // modelText
            // 
            modelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelText.Location = new Point(162, 444);
            modelText.Name = "modelText";
            modelText.Size = new Size(150, 34);
            modelText.TabIndex = 9;
            // 
            // markaText
            // 
            markaText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            markaText.Location = new Point(162, 402);
            markaText.Name = "markaText";
            markaText.Size = new Size(150, 34);
            markaText.TabIndex = 8;
            // 
            // plakaText
            // 
            plakaText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            plakaText.Location = new Point(162, 360);
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(150, 34);
            plakaText.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(739, 360);
            label18.Name = "label18";
            label18.Size = new Size(157, 32);
            label18.TabIndex = 1016;
            label18.Text = "Hasar Kaydı : ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(404, 486);
            label17.Name = "label17";
            label17.Size = new Size(141, 32);
            label17.TabIndex = 1015;
            label17.Text = "Vites Türü : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(379, 444);
            label16.Name = "label16";
            label16.Size = new Size(166, 32);
            label16.TabIndex = 1014;
            label16.Text = "Koltuk Sayısı : ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(476, 402);
            label15.Name = "label15";
            label15.Size = new Size(69, 32);
            label15.TabIndex = 1013;
            label15.Text = "KM : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(460, 360);
            label14.Name = "label14";
            label14.Size = new Size(85, 32);
            label14.TabIndex = 1012;
            label14.Text = "Renk : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(18, 487);
            label13.Name = "label13";
            label13.Size = new Size(138, 32);
            label13.TabIndex = 1011;
            label13.Text = "Yakıt Türü : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(54, 444);
            label12.Name = "label12";
            label12.Size = new Size(102, 32);
            label12.TabIndex = 1010;
            label12.Text = "Model : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(57, 403);
            label10.Name = "label10";
            label10.Size = new Size(99, 32);
            label10.TabIndex = 1009;
            label10.Text = "Marka : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(68, 362);
            label11.Name = "label11";
            label11.Size = new Size(88, 32);
            label11.TabIndex = 1008;
            label11.Text = "Plaka : ";
            // 
            // AracCrudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 653);
            Controls.Add(islemBTN);
            Controls.Add(guncelleRB);
            Controls.Add(silRB);
            Controls.Add(vitesCB);
            Controls.Add(koltukSayiCB);
            Controls.Add(yakitTuruCB);
            Controls.Add(veriGoruntuleyici);
            Controls.Add(hasarText);
            Controls.Add(kmText);
            Controls.Add(renkText);
            Controls.Add(modelText);
            Controls.Add(markaText);
            Controls.Add(plakaText);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(cikisBTN);
            Controls.Add(profilBTN);
            Controls.Add(aracFiyatBTN);
            Controls.Add(aracKiralamaBTN);
            Controls.Add(crudBTN);
            Controls.Add(aracEkleBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AracCrudForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD İşlemleri";
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
        private Button islemBTN;
        private RadioButton guncelleRB;
        private RadioButton silRB;
        private ComboBox vitesCB;
        private ComboBox koltukSayiCB;
        private ComboBox yakitTuruCB;
        private DataGridView veriGoruntuleyici;
        private RichTextBox hasarText;
        private TextBox kmText;
        private TextBox renkText;
        private TextBox modelText;
        private TextBox markaText;
        private TextBox plakaText;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label11;
    }
}