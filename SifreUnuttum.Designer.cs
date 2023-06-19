namespace RentACar2023
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
            sifreGetirBTN = new Button();
            girisSayfaBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            kullaniciaditextbox = new TextBox();
            Kurtarmakodutextbox = new TextBox();
            SuspendLayout();
            // 
            // sifreGetirBTN
            // 
            sifreGetirBTN.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sifreGetirBTN.Location = new Point(256, 312);
            sifreGetirBTN.Name = "sifreGetirBTN";
            sifreGetirBTN.Size = new Size(318, 73);
            sifreGetirBTN.TabIndex = 0;
            sifreGetirBTN.Text = "Şifremi Getir";
            sifreGetirBTN.UseVisualStyleBackColor = true;
            sifreGetirBTN.Click += sifreGetirBTN_Click;
            // 
            // girisSayfaBTN
            // 
            girisSayfaBTN.Location = new Point(632, 12);
            girisSayfaBTN.Name = "girisSayfaBTN";
            girisSayfaBTN.Size = new Size(156, 45);
            girisSayfaBTN.TabIndex = 1;
            girisSayfaBTN.Text = "Giriş Sayfasına Dön";
            girisSayfaBTN.UseVisualStyleBackColor = true;
            girisSayfaBTN.Click += girisSayfaBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(216, 159);
            label1.Name = "label1";
            label1.Size = new Size(185, 41);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 222);
            label2.Name = "label2";
            label2.Size = new Size(222, 41);
            label2.TabIndex = 3;
            label2.Text = "Kurtarma Kodu:";
            // 
            // kullaniciaditextbox
            // 
            kullaniciaditextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciaditextbox.Location = new Point(407, 159);
            kullaniciaditextbox.Name = "kullaniciaditextbox";
            kullaniciaditextbox.Size = new Size(199, 43);
            kullaniciaditextbox.TabIndex = 4;
            // 
            // Kurtarmakodutextbox
            // 
            Kurtarmakodutextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Kurtarmakodutextbox.Location = new Point(407, 222);
            Kurtarmakodutextbox.Name = "Kurtarmakodutextbox";
            Kurtarmakodutextbox.Size = new Size(199, 43);
            Kurtarmakodutextbox.TabIndex = 5;
            // 
            // FormSifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Kurtarmakodutextbox);
            Controls.Add(kullaniciaditextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(girisSayfaBTN);
            Controls.Add(sifreGetirBTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sifreGetirBTN;
        private Button girisSayfaBTN;
        private Label label1;
        private Label label2;
        private TextBox kullaniciaditextbox;
        private TextBox Kurtarmakodutextbox;
    }
}