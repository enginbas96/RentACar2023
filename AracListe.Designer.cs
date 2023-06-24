namespace RentACar2023
{
    partial class AracListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListe));
            veriGoruntuleyici = new DataGridView();
            label1 = new Label();
            plakaText = new TextBox();
            cikisBTN = new Button();
            ımageList1 = new ImageList(components);
            kiralanmısData = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            erkenTeslimBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)veriGoruntuleyici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kiralanmısData).BeginInit();
            SuspendLayout();
            // 
            // veriGoruntuleyici
            // 
            veriGoruntuleyici.AllowUserToAddRows = false;
            veriGoruntuleyici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            veriGoruntuleyici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veriGoruntuleyici.Location = new Point(12, 52);
            veriGoruntuleyici.Name = "veriGoruntuleyici";
            veriGoruntuleyici.RowHeadersWidth = 51;
            veriGoruntuleyici.RowTemplate.Height = 29;
            veriGoruntuleyici.Size = new Size(1093, 230);
            veriGoruntuleyici.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(378, 589);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 8;
            label1.Text = "Plaka : ";
            // 
            // plakaText
            // 
            plakaText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            plakaText.Location = new Point(472, 591);
            plakaText.MaxLength = 10;
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(157, 32);
            plakaText.TabIndex = 1;
            plakaText.TextChanged += textBox1_TextChanged;
            // 
            // cikisBTN
            // 
            cikisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            cikisBTN.ImageKey = "cikisyap.png";
            cikisBTN.ImageList = ımageList1;
            cikisBTN.Location = new Point(924, 587);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(104, 43);
            cikisBTN.TabIndex = 2;
            cikisBTN.Text = "Çıkış";
            cikisBTN.TextAlign = ContentAlignment.MiddleRight;
            cikisBTN.UseVisualStyleBackColor = true;
            cikisBTN.Click += cikisBTN_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "cikisyap.png");
            // 
            // kiralanmısData
            // 
            kiralanmısData.AllowUserToAddRows = false;
            kiralanmısData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kiralanmısData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kiralanmısData.Location = new Point(12, 328);
            kiralanmısData.Name = "kiralanmısData";
            kiralanmısData.RowHeadersWidth = 51;
            kiralanmısData.RowTemplate.Height = 29;
            kiralanmısData.Size = new Size(1093, 230);
            kiralanmısData.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 10;
            label2.Text = "Kiralanmamış Araçların Listesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 300);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 11;
            label3.Text = "Kiralanmış Araçların Listesi";
            // 
            // erkenTeslimBTN
            // 
            erkenTeslimBTN.Location = new Point(715, 591);
            erkenTeslimBTN.Name = "erkenTeslimBTN";
            erkenTeslimBTN.Size = new Size(177, 39);
            erkenTeslimBTN.TabIndex = 12;
            erkenTeslimBTN.Text = "Araç Teslim Alındı";
            erkenTeslimBTN.UseVisualStyleBackColor = true;
            erkenTeslimBTN.Click += erkenTeslimBTN_Click;
            // 
            // AracListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 653);
            Controls.Add(erkenTeslimBTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(kiralanmısData);
            Controls.Add(cikisBTN);
            Controls.Add(plakaText);
            Controls.Add(label1);
            Controls.Add(veriGoruntuleyici);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AracListe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AracListe";
            FormClosed += AracListe_FormClosed;
            Load += AracListe_Load;
            ((System.ComponentModel.ISupportInitialize)veriGoruntuleyici).EndInit();
            ((System.ComponentModel.ISupportInitialize)kiralanmısData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView veriGoruntuleyici;
        private Label label1;
        private TextBox plakaText;
        private Button cikisBTN;
        private ImageList ımageList1;
        private DataGridView kiralanmısData;
        private Label label2;
        private Label label3;
        private Button erkenTeslimBTN;
    }
}