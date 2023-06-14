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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSifremiUnuttum));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            kullaniciaditextbox = new TextBox();
            Kurtarmakodutextbox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(380, 311);
            button1.Name = "button1";
            button1.Size = new Size(126, 57);
            button1.TabIndex = 0;
            button1.Text = "Şifremi Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 311);
            button2.Name = "button2";
            button2.Size = new Size(123, 57);
            button2.TabIndex = 1;
            button2.Text = "Giriş Sayfasına Dön";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(154, 171);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(130, 232);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 3;
            label2.Text = "Kurtarma Kodu:";
            // 
            // kullaniciaditextbox
            // 
            kullaniciaditextbox.Location = new Point(328, 168);
            kullaniciaditextbox.Name = "kullaniciaditextbox";
            kullaniciaditextbox.Size = new Size(199, 27);
            kullaniciaditextbox.TabIndex = 4;
            // 
            // Kurtarmakodutextbox
            // 
            Kurtarmakodutextbox.Location = new Point(328, 229);
            Kurtarmakodutextbox.Name = "Kurtarmakodutextbox";
            Kurtarmakodutextbox.Size = new Size(199, 27);
            Kurtarmakodutextbox.TabIndex = 5;
            // 
            // FormSifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Kurtarmakodutextbox);
            Controls.Add(kullaniciaditextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormSifremiUnuttum";
            Text = "Şifremi Unuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox kullaniciaditextbox;
        private TextBox Kurtarmakodutextbox;
    }
}