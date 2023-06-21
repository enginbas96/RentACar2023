﻿namespace RentACar2023
{
    partial class FormSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSifremiUnuttum));
            KullaniciPictureBox = new PictureBox();
            kurtarmaKoduText = new TextBox();
            kullanıcıAdıText = new TextBox();
            SifreLabel = new Label();
            KullaniciAdiLabel = new Label();
            geriBTN = new Button();
            kaydetBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)KullaniciPictureBox).BeginInit();
            SuspendLayout();
            // 
            // KullaniciPictureBox
            // 
            KullaniciPictureBox.Image = (Image)resources.GetObject("KullaniciPictureBox.Image");
            KullaniciPictureBox.Location = new Point(210, 37);
            KullaniciPictureBox.Name = "KullaniciPictureBox";
            KullaniciPictureBox.Size = new Size(173, 153);
            KullaniciPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            KullaniciPictureBox.TabIndex = 111115;
            KullaniciPictureBox.TabStop = false;
            // 
            // kurtarmaKoduText
            // 
            kurtarmaKoduText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kurtarmaKoduText.Location = new Point(210, 281);
            kurtarmaKoduText.Name = "kurtarmaKoduText";
            kurtarmaKoduText.Size = new Size(173, 32);
            kurtarmaKoduText.TabIndex = 111114;
            // 
            // kullanıcıAdıText
            // 
            kullanıcıAdıText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kullanıcıAdıText.Location = new Point(210, 229);
            kullanıcıAdıText.Name = "kullanıcıAdıText";
            kullanıcıAdıText.Size = new Size(173, 32);
            kullanıcıAdıText.TabIndex = 111113;
            // 
            // SifreLabel
            // 
            SifreLabel.AutoSize = true;
            SifreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SifreLabel.Location = new Point(45, 281);
            SifreLabel.Name = "SifreLabel";
            SifreLabel.Size = new Size(159, 28);
            SifreLabel.TabIndex = 111117;
            SifreLabel.Text = "Kurtarma Kodu : ";
            // 
            // KullaniciAdiLabel
            // 
            KullaniciAdiLabel.AutoSize = true;
            KullaniciAdiLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KullaniciAdiLabel.Location = new Point(70, 229);
            KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            KullaniciAdiLabel.Size = new Size(134, 28);
            KullaniciAdiLabel.TabIndex = 111116;
            KullaniciAdiLabel.Text = "Kullanıcı Adı : ";
            // 
            // geriBTN
            // 
            geriBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            geriBTN.Location = new Point(333, 364);
            geriBTN.Name = "geriBTN";
            geriBTN.Size = new Size(173, 41);
            geriBTN.TabIndex = 111119;
            geriBTN.Text = "Geri";
            geriBTN.UseVisualStyleBackColor = true;
            geriBTN.Click += geriBTN_Click;
            // 
            // kaydetBTN
            // 
            kaydetBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kaydetBTN.Location = new Point(51, 364);
            kaydetBTN.Name = "kaydetBTN";
            kaydetBTN.Size = new Size(173, 41);
            kaydetBTN.TabIndex = 111118;
            kaydetBTN.Text = "Şifremi Kurtar";
            kaydetBTN.UseVisualStyleBackColor = true;
            kaydetBTN.Click += kaydetBTN_Click;
            // 
            // FormSifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(568, 426);
            Controls.Add(geriBTN);
            Controls.Add(kaydetBTN);
            Controls.Add(KullaniciPictureBox);
            Controls.Add(kurtarmaKoduText);
            Controls.Add(kullanıcıAdıText);
            Controls.Add(SifreLabel);
            Controls.Add(KullaniciAdiLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            FormClosed += FormSifremiUnuttum_FormClosed_1;
            ((System.ComponentModel.ISupportInitialize)KullaniciPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox KullaniciPictureBox;
        private TextBox kurtarmaKoduText;
        private TextBox kullanıcıAdıText;
        private Label SifreLabel;
        private Label KullaniciAdiLabel;
        private Button geriBTN;
        private Button kaydetBTN;
    }
}