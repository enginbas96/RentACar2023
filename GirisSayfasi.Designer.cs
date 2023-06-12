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
            HosgeldinizText = new Label();
            İslemTextBox = new TextBox();
            AraclariListeleButton = new Button();
            KullaniciGirisButton = new Button();
            ımageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // HosgeldinizText
            // 
            HosgeldinizText.AutoSize = true;
            HosgeldinizText.BackColor = SystemColors.Window;
            HosgeldinizText.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            HosgeldinizText.Location = new Point(89, 101);
            HosgeldinizText.Name = "HosgeldinizText";
            HosgeldinizText.Size = new Size(616, 38);
            HosgeldinizText.TabIndex = 1;
            HosgeldinizText.Text = "OTO KİRALAMA PROGRAMIMIZA HOŞGELDİNİZ ";
            HosgeldinizText.Click += label1_Click;
            // 
            // İslemTextBox
            // 
            İslemTextBox.BorderStyle = BorderStyle.None;
            İslemTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            İslemTextBox.Location = new Point(238, 332);
            İslemTextBox.Name = "İslemTextBox";
            İslemTextBox.Size = new Size(308, 24);
            İslemTextBox.TabIndex = 2;
            İslemTextBox.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçin";
            İslemTextBox.TextChanged += İslemTextBox_TextChanged;
            // 
            // AraclariListeleButton
            // 
            AraclariListeleButton.BackgroundImageLayout = ImageLayout.None;
            AraclariListeleButton.ImageAlign = ContentAlignment.MiddleLeft;
            AraclariListeleButton.ImageKey = "pngegg (1).png";
            AraclariListeleButton.ImageList = ımageList1;
            AraclariListeleButton.Location = new Point(484, 369);
            AraclariListeleButton.Name = "AraclariListeleButton";
            AraclariListeleButton.Size = new Size(157, 61);
            AraclariListeleButton.TabIndex = 3;
            AraclariListeleButton.Text = "Araçları Listele";
            AraclariListeleButton.TextAlign = ContentAlignment.MiddleRight;
            AraclariListeleButton.UseVisualStyleBackColor = true;
            AraclariListeleButton.Click += button1_Click;
            // 
            // KullaniciGirisButton
            // 
            KullaniciGirisButton.ImageAlign = ContentAlignment.MiddleLeft;
            KullaniciGirisButton.ImageKey = "pngegg.png";
            KullaniciGirisButton.ImageList = ımageList1;
            KullaniciGirisButton.Location = new Point(188, 369);
            KullaniciGirisButton.Name = "KullaniciGirisButton";
            KullaniciGirisButton.Size = new Size(156, 63);
            KullaniciGirisButton.TabIndex = 4;
            KullaniciGirisButton.Text = "Kullanıcı Girişi";
            KullaniciGirisButton.TextAlign = ContentAlignment.MiddleRight;
            KullaniciGirisButton.UseVisualStyleBackColor = true;
            KullaniciGirisButton.Click += button2_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "pngegg.png");
            ımageList1.Images.SetKeyName(1, "pngegg (1).png");
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(KullaniciGirisButton);
            Controls.Add(AraclariListeleButton);
            Controls.Add(İslemTextBox);
            Controls.Add(HosgeldinizText);
            Name = "GirisSayfasi";
            Text = "Giriş Sayfası";
            Load += GirisSayfasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label HosgeldinizText;
        private TextBox İslemTextBox;
        private Button AraclariListeleButton;
        private Button KullaniciGirisButton;
        private ImageList ımageList1;
    }
}