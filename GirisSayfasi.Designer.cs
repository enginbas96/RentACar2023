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
            aracListeBTN = new Button();
            ımageList1 = new ImageList(components);
            girisBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            musteriKayitBTN = new Button();
            SuspendLayout();
            // 
            // aracListeBTN
            // 
            aracListeBTN.BackgroundImageLayout = ImageLayout.None;
            aracListeBTN.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            aracListeBTN.ImageAlign = ContentAlignment.MiddleLeft;
            aracListeBTN.ImageKey = "araclistele.png";
            aracListeBTN.ImageList = ımageList1;
            aracListeBTN.Location = new Point(152, 235);
            aracListeBTN.Name = "aracListeBTN";
            aracListeBTN.Size = new Size(235, 75);
            aracListeBTN.TabIndex = 2;
            aracListeBTN.Text = "Araçları Listele";
            aracListeBTN.TextAlign = ContentAlignment.MiddleRight;
            aracListeBTN.UseVisualStyleBackColor = true;
            aracListeBTN.Click += aracListeBTN_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "araclistele.png");
            ımageList1.Images.SetKeyName(1, "kullanıcıicon.png");
            ımageList1.Images.SetKeyName(2, "musteriicon.png");
            // 
            // girisBTN
            // 
            girisBTN.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            girisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            girisBTN.ImageKey = "kullanıcıicon.png";
            girisBTN.ImageList = ımageList1;
            girisBTN.Location = new Point(152, 154);
            girisBTN.Name = "girisBTN";
            girisBTN.Size = new Size(235, 75);
            girisBTN.TabIndex = 1;
            girisBTN.Text = "Kullanıcı Girişi";
            girisBTN.TextAlign = ContentAlignment.MiddleRight;
            girisBTN.UseVisualStyleBackColor = true;
            girisBTN.Click += girisBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 42);
            label1.Name = "label1";
            label1.Size = new Size(471, 30);
            label1.TabIndex = 111;
            label1.Text = "OTO KİRALAMA PROGRAMIMIZA HOŞGELDİNİZ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(93, 91);
            label2.Name = "label2";
            label2.Size = new Size(365, 30);
            label2.TabIndex = 11112;
            label2.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçin";
            // 
            // musteriKayitBTN
            // 
            musteriKayitBTN.BackgroundImageLayout = ImageLayout.None;
            musteriKayitBTN.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            musteriKayitBTN.ImageAlign = ContentAlignment.MiddleLeft;
            musteriKayitBTN.ImageKey = "musteriicon.png";
            musteriKayitBTN.ImageList = ımageList1;
            musteriKayitBTN.Location = new Point(152, 316);
            musteriKayitBTN.Name = "musteriKayitBTN";
            musteriKayitBTN.Size = new Size(235, 75);
            musteriKayitBTN.TabIndex = 3;
            musteriKayitBTN.Text = "Müşteri";
            musteriKayitBTN.UseVisualStyleBackColor = true;
            musteriKayitBTN.Click += musteriKayitBTN_Click;
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(568, 426);
            Controls.Add(musteriKayitBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(girisBTN);
            Controls.Add(aracListeBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GirisSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Sayfası";
            FormClosed += GirisSayfasi_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button aracListeBTN;
        private Button girisBTN;
        private Label label1;
        private Label label2;
        private Button musteriKayitBTN;
        private ImageList ımageList1;
    }
}