namespace RentACar2023
{
    partial class musteriListeleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriListeleForm));
            musteriData = new DataGridView();
            kayitliMusteriLabel = new Label();
            anaMenuButton = new Button();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)musteriData).BeginInit();
            SuspendLayout();
            // 
            // musteriData
            // 
            musteriData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            musteriData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            musteriData.Location = new Point(12, 49);
            musteriData.Name = "musteriData";
            musteriData.RowHeadersWidth = 51;
            musteriData.RowTemplate.Height = 29;
            musteriData.Size = new Size(1102, 332);
            musteriData.TabIndex = 0;
            // 
            // kayitliMusteriLabel
            // 
            kayitliMusteriLabel.AutoSize = true;
            kayitliMusteriLabel.Location = new Point(12, 24);
            kayitliMusteriLabel.Name = "kayitliMusteriLabel";
            kayitliMusteriLabel.Size = new Size(75, 20);
            kayitliMusteriLabel.TabIndex = 1;
            kayitliMusteriLabel.Text = "Müşteriler";
            // 
            // anaMenuButton
            // 
            anaMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            anaMenuButton.ImageKey = "cikisyap.png";
            anaMenuButton.ImageList = ımageList1;
            anaMenuButton.Location = new Point(889, 442);
            anaMenuButton.Name = "anaMenuButton";
            anaMenuButton.Size = new Size(172, 58);
            anaMenuButton.TabIndex = 2;
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
            // musteriListeleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 570);
            Controls.Add(anaMenuButton);
            Controls.Add(kayitliMusteriLabel);
            Controls.Add(musteriData);
            Name = "musteriListeleForm";
            Text = "Müşteri Listele";
            FormClosing += musteriListeleForm_FormClosing;
            Load += musteriListeleForm_Load;
            ((System.ComponentModel.ISupportInitialize)musteriData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView musteriData;
        private Label kayitliMusteriLabel;
        private Button anaMenuButton;
        private ImageList ımageList1;
    }
}