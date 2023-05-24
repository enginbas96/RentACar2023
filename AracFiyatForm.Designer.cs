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
            cikisBTN = new Button();
            profilBTN = new Button();
            aracFiyatBTN = new Button();
            aracKiralamaBTN = new Button();
            crudBTN = new Button();
            aracEkleBTN = new Button();
            veriGoruntuleyici = new DataGridView();
            label19 = new Label();
            plakaText = new TextBox();
            anlikFiyatText = new TextBox();
            label1 = new Label();
            yeniFiyatText = new TextBox();
            label2 = new Label();
            guncelleBTN = new Button();
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
            // veriGoruntuleyici
            // 
            veriGoruntuleyici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veriGoruntuleyici.Location = new Point(12, 75);
            veriGoruntuleyici.Name = "veriGoruntuleyici";
            veriGoruntuleyici.RowHeadersWidth = 51;
            veriGoruntuleyici.RowTemplate.Height = 29;
            veriGoruntuleyici.Size = new Size(1093, 270);
            veriGoruntuleyici.TabIndex = 6;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(90, 405);
            label19.Name = "label19";
            label19.Size = new Size(88, 32);
            label19.TabIndex = 1009;
            label19.Text = "Plaka : ";
            // 
            // plakaText
            // 
            plakaText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            plakaText.Location = new Point(184, 407);
            plakaText.Margin = new Padding(3, 4, 3, 4);
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(150, 32);
            plakaText.TabIndex = 7;
            // 
            // anlikFiyatText
            // 
            anlikFiyatText.Enabled = false;
            anlikFiyatText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            anlikFiyatText.Location = new Point(184, 447);
            anlikFiyatText.Margin = new Padding(3, 4, 3, 4);
            anlikFiyatText.Name = "anlikFiyatText";
            anlikFiyatText.Size = new Size(150, 32);
            anlikFiyatText.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 445);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 1015;
            label1.Text = "Anlık Fiyatı : ";
            // 
            // yeniFiyatText
            // 
            yeniFiyatText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yeniFiyatText.Location = new Point(184, 487);
            yeniFiyatText.Margin = new Padding(3, 4, 3, 4);
            yeniFiyatText.Name = "yeniFiyatText";
            yeniFiyatText.Size = new Size(150, 32);
            yeniFiyatText.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 485);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 1017;
            label2.Text = "Yeni Fiyat : ";
            // 
            // guncelleBTN
            // 
            guncelleBTN.Location = new Point(44, 550);
            guncelleBTN.Name = "guncelleBTN";
            guncelleBTN.Size = new Size(290, 73);
            guncelleBTN.TabIndex = 10;
            guncelleBTN.Text = "Fiyatı Güncelle";
            guncelleBTN.UseVisualStyleBackColor = true;
            // 
            // AracFiyatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 653);
            Controls.Add(guncelleBTN);
            Controls.Add(yeniFiyatText);
            Controls.Add(label2);
            Controls.Add(anlikFiyatText);
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
        private TextBox anlikFiyatText;
        private Label label1;
        private TextBox yeniFiyatText;
        private Label label2;
        private Button guncelleBTN;
    }
}