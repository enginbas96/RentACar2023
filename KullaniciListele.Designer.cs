namespace RentACar2023
{
    partial class KullaniciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciListele));
            kullaniciData = new DataGridView();
            anaMenuButton = new Button();
            ımageList1 = new ImageList(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)kullaniciData).BeginInit();
            SuspendLayout();
            // 
            // kullaniciData
            // 
            kullaniciData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kullaniciData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kullaniciData.Location = new Point(12, 49);
            kullaniciData.Name = "kullaniciData";
            kullaniciData.RowHeadersWidth = 51;
            kullaniciData.RowTemplate.Height = 29;
            kullaniciData.Size = new Size(1036, 314);
            kullaniciData.TabIndex = 0;
            // 
            // anaMenuButton
            // 
            anaMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            anaMenuButton.ImageKey = "cikisyap.png";
            anaMenuButton.ImageList = ımageList1;
            anaMenuButton.Location = new Point(852, 428);
            anaMenuButton.Name = "anaMenuButton";
            anaMenuButton.Size = new Size(172, 58);
            anaMenuButton.TabIndex = 3;
            anaMenuButton.Text = "Ana Menüye Dön";
            anaMenuButton.TextAlign = ContentAlignment.MiddleRight;
            anaMenuButton.UseVisualStyleBackColor = true;
            anaMenuButton.Click += anaMenuButton_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikisyap.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcılar";
            // 
            // KullaniciListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 579);
            Controls.Add(label1);
            Controls.Add(anaMenuButton);
            Controls.Add(kullaniciData);
            Name = "KullaniciListele";
            Text = "KullaniciListele";
            Load += KullaniciListele_Load;
            ((System.ComponentModel.ISupportInitialize)kullaniciData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView kullaniciData;
        private Button anaMenuButton;
        private Label label1;
        private ImageList ımageList1;
    }
}