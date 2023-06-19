namespace RentACar2023
{
    partial class GirisSayfasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            AraclariListeleButton = new Button();
            ımageList1 = new ImageList(components);
            KullaniciGirisButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // AraclariListeleButton
            // 
            AraclariListeleButton.BackgroundImageLayout = ImageLayout.None;
            AraclariListeleButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AraclariListeleButton.ImageAlign = ContentAlignment.MiddleLeft;
            AraclariListeleButton.ImageKey = "(yok)";
            AraclariListeleButton.ImageList = ımageList1;
            AraclariListeleButton.Location = new Point(402, 286);
            AraclariListeleButton.Name = "AraclariListeleButton";
            AraclariListeleButton.Size = new Size(272, 134);
            AraclariListeleButton.TabIndex = 2;
            AraclariListeleButton.Text = "Araçları Listele";
            AraclariListeleButton.UseVisualStyleBackColor = true;
            AraclariListeleButton.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "pngegg.png");
            ımageList1.Images.SetKeyName(1, "pngegg (1).png");
            // 
            // KullaniciGirisButton
            // 
            KullaniciGirisButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciGirisButton.ImageAlign = ContentAlignment.MiddleLeft;
            KullaniciGirisButton.ImageKey = "(yok)";
            KullaniciGirisButton.ImageList = ımageList1;
            KullaniciGirisButton.Location = new Point(106, 286);
            KullaniciGirisButton.Name = "KullaniciGirisButton";
            KullaniciGirisButton.Size = new Size(271, 136);
            KullaniciGirisButton.TabIndex = 1;
            KullaniciGirisButton.Text = "Kullanıcı Girişi";
            KullaniciGirisButton.UseVisualStyleBackColor = true;
            KullaniciGirisButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 80);
            label1.Name = "label1";
            label1.Size = new Size(616, 38);
            label1.TabIndex = 5;
            label1.Text = "OTO KİRALAMA PROGRAMIMIZA HOŞGELDİNİZ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 157);
            label2.Name = "label2";
            label2.Size = new Size(485, 38);
            label2.TabIndex = 6;
            label2.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçin";
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KullaniciGirisButton);
            Controls.Add(AraclariListeleButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GirisSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Sayfası";
            Load += GirisSayfasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AraclariListeleButton;
        private Button KullaniciGirisButton;
        private ImageList ımageList1;
        private Label label1;
        private Label label2;
    }
}