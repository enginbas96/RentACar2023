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
            veriGoruntuleyici = new DataGridView();
            label1 = new Label();
            plakaText = new TextBox();
            cikisBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)veriGoruntuleyici).BeginInit();
            SuspendLayout();
            // 
            // veriGoruntuleyici
            // 
            veriGoruntuleyici.AllowUserToAddRows = false;
            veriGoruntuleyici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            veriGoruntuleyici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veriGoruntuleyici.Location = new Point(12, 22);
            veriGoruntuleyici.Name = "veriGoruntuleyici";
            veriGoruntuleyici.RowHeadersWidth = 51;
            veriGoruntuleyici.RowTemplate.Height = 29;
            veriGoruntuleyici.Size = new Size(1093, 526);
            veriGoruntuleyici.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(605, 580);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 8;
            label1.Text = "Plaka : ";
            // 
            // plakaText
            // 
            plakaText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            plakaText.Location = new Point(699, 582);
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(157, 32);
            plakaText.TabIndex = 1;
            plakaText.TextChanged += textBox1_TextChanged;
            // 
            // cikisBTN
            // 
            cikisBTN.ImageAlign = ContentAlignment.MiddleLeft;
            cikisBTN.ImageKey = "(yok)";
            cikisBTN.Location = new Point(916, 578);
            cikisBTN.Name = "cikisBTN";
            cikisBTN.Size = new Size(157, 43);
            cikisBTN.TabIndex = 2;
            cikisBTN.Text = "Çıkış";
            cikisBTN.UseVisualStyleBackColor = true;
            cikisBTN.Click += cikisBTN_Click;
            // 
            // AracListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 653);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView veriGoruntuleyici;
        private Label label1;
        private TextBox plakaText;
        private Button cikisBTN;
    }
}