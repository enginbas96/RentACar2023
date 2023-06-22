namespace RentACar2023
{
    partial class MusteriKayit
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
            kaydetBTN = new Button();
            geriBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tcText = new TextBox();
            sifreText = new TextBox();
            adText = new TextBox();
            soyadText = new TextBox();
            telNoText = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // kaydetBTN
            // 
            kaydetBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kaydetBTN.Location = new Point(78, 359);
            kaydetBTN.Name = "kaydetBTN";
            kaydetBTN.Size = new Size(173, 41);
            kaydetBTN.TabIndex = 6;
            kaydetBTN.Text = "Kaydet";
            kaydetBTN.UseVisualStyleBackColor = true;
            kaydetBTN.Click += kaydetBTN_Click;
            // 
            // geriBTN
            // 
            geriBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            geriBTN.Location = new Point(360, 359);
            geriBTN.Name = "geriBTN";
            geriBTN.Size = new Size(173, 41);
            geriBTN.TabIndex = 7;
            geriBTN.Text = "Geri";
            geriBTN.UseVisualStyleBackColor = true;
            geriBTN.Click += geriBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(165, 80);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 2;
            label1.Text = "TC : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 128);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 3;
            label2.Text = "Şifre : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 176);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 4;
            label3.Text = "Ad : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(131, 224);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 5;
            label4.Text = "Soyad : ";
            // 
            // tcText
            // 
            tcText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tcText.Location = new Point(218, 80);
            tcText.MaxLength = 11;
            tcText.Name = "tcText";
            tcText.Size = new Size(173, 32);
            tcText.TabIndex = 1;
            tcText.KeyPress += tcText_KeyPress;
            // 
            // sifreText
            // 
            sifreText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sifreText.Location = new Point(218, 128);
            sifreText.Name = "sifreText";
            sifreText.Size = new Size(173, 32);
            sifreText.TabIndex = 2;
            sifreText.UseSystemPasswordChar = true;
            // 
            // adText
            // 
            adText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            adText.Location = new Point(218, 176);
            adText.Name = "adText";
            adText.Size = new Size(173, 32);
            adText.TabIndex = 3;
            adText.TextChanged += adText_TextChanged;
            adText.KeyPress += adText_KeyPress;
            // 
            // soyadText
            // 
            soyadText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            soyadText.Location = new Point(218, 224);
            soyadText.Name = "soyadText";
            soyadText.Size = new Size(173, 32);
            soyadText.TabIndex = 4;
            soyadText.TextChanged += soyadText_TextChanged;
            soyadText.KeyPress += soyadText_KeyPress;
            // 
            // telNoText
            // 
            telNoText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            telNoText.Location = new Point(218, 272);
            telNoText.MaxLength = 11;
            telNoText.Name = "telNoText";
            telNoText.PlaceholderText = "05XXxxxXXxx";
            telNoText.Size = new Size(173, 32);
            telNoText.TabIndex = 5;
            telNoText.KeyPress += telNoText_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(124, 272);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 8;
            label5.Text = "Telefon : ";
            // 
            // MusteriKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 426);
            Controls.Add(telNoText);
            Controls.Add(label5);
            Controls.Add(soyadText);
            Controls.Add(adText);
            Controls.Add(sifreText);
            Controls.Add(tcText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(geriBTN);
            Controls.Add(kaydetBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MusteriKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Kayıt";
            FormClosed += MusteriKayit_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kaydetBTN;
        private Button geriBTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tcText;
        private TextBox sifreText;
        private TextBox adText;
        private TextBox soyadText;
        private TextBox telNoText;
        private Label label5;
    }
}