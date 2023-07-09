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
            dataGridView1 = new DataGridView();
            anaMenuButton = new Button();
            label1 = new Label();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1036, 314);
            dataGridView1.TabIndex = 0;
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
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikisyap.png");
            // 
            // KullaniciListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 579);
            Controls.Add(label1);
            Controls.Add(anaMenuButton);
            Controls.Add(dataGridView1);
            Name = "KullaniciListele";
            Text = "KullaniciListele";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button anaMenuButton;
        private Label label1;
        private ImageList ımageList1;
    }
}