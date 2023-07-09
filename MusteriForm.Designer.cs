namespace RentACar2023
{
    partial class MusteriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriForm));
            musteriKaydetButton = new Button();
            ımageList1 = new ImageList(components);
            musteriListeleButton = new Button();
            label2 = new Label();
            anaSayfaBtn = new Button();
            SuspendLayout();
            // 
            // musteriKaydetButton
            // 
            musteriKaydetButton.ImageAlign = ContentAlignment.MiddleLeft;
            musteriKaydetButton.ImageKey = "kullaniciolustur.png";
            musteriKaydetButton.ImageList = ımageList1;
            musteriKaydetButton.Location = new Point(189, 204);
            musteriKaydetButton.Name = "musteriKaydetButton";
            musteriKaydetButton.Size = new Size(164, 62);
            musteriKaydetButton.TabIndex = 0;
            musteriKaydetButton.Text = "Müşteri İşlemleri";
            musteriKaydetButton.TextAlign = ContentAlignment.MiddleRight;
            musteriKaydetButton.UseVisualStyleBackColor = true;
            musteriKaydetButton.Click += musteriKaydetButton_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "kullaniciolustur.png");
            ımageList1.Images.SetKeyName(1, "araclistele.png");
            ımageList1.Images.SetKeyName(2, "liste.png");
            ımageList1.Images.SetKeyName(3, "cikisyap.png");
            // 
            // musteriListeleButton
            // 
            musteriListeleButton.ImageAlign = ContentAlignment.MiddleLeft;
            musteriListeleButton.ImageKey = "araclistele.png";
            musteriListeleButton.ImageList = ımageList1;
            musteriListeleButton.Location = new Point(419, 204);
            musteriListeleButton.Name = "musteriListeleButton";
            musteriListeleButton.Size = new Size(165, 61);
            musteriListeleButton.TabIndex = 1;
            musteriListeleButton.Text = "Müşteri Listele";
            musteriListeleButton.TextAlign = ContentAlignment.MiddleRight;
            musteriListeleButton.UseVisualStyleBackColor = true;
            musteriListeleButton.Click += musteriListeleButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(219, 118);
            label2.Name = "label2";
            label2.Size = new Size(365, 30);
            label2.TabIndex = 11113;
            label2.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçin";
            // 
            // anaSayfaBtn
            // 
            anaSayfaBtn.ImageAlign = ContentAlignment.MiddleLeft;
            anaSayfaBtn.ImageKey = "cikisyap.png";
            anaSayfaBtn.ImageList = ımageList1;
            anaSayfaBtn.Location = new Point(296, 321);
            anaSayfaBtn.Name = "anaSayfaBtn";
            anaSayfaBtn.Size = new Size(181, 58);
            anaSayfaBtn.TabIndex = 11115;
            anaSayfaBtn.Text = "Ana Sayfaya Dön";
            anaSayfaBtn.TextAlign = ContentAlignment.MiddleRight;
            anaSayfaBtn.UseVisualStyleBackColor = true;
            anaSayfaBtn.Click += anaSayfaBtn_Click;
            // 
            // MusteriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(anaSayfaBtn);
            Controls.Add(label2);
            Controls.Add(musteriListeleButton);
            Controls.Add(musteriKaydetButton);
            Name = "MusteriForm";
            Text = "MusteriForm";
            FormClosing += MusteriForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button musteriKaydetButton;
        private Button musteriListeleButton;
        private ImageList ımageList1;
        private Label label2;
        private Button anaSayfaBtn;
    }
}