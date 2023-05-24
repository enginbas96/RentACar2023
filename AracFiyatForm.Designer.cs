namespace RentACar2023
{
    partial class AracFiyatForm
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(953, 31);
            button6.Name = "button6";
            button6.Size = new Size(177, 47);
            button6.TabIndex = 6;
            button6.Text = "Çıkış Yap";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(770, 31);
            button5.Name = "button5";
            button5.Size = new Size(177, 47);
            button5.TabIndex = 4;
            button5.Text = "Kullanıcı İşlemleri";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(587, 31);
            button4.Name = "button4";
            button4.Size = new Size(177, 47);
            button4.TabIndex = 3;
            button4.Text = "Araç Fiyat İşlemleri";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(404, 31);
            button3.Name = "button3";
            button3.Size = new Size(177, 47);
            button3.TabIndex = 2;
            button3.Text = "Araç Kiralama İşlemleri";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(221, 31);
            button2.Name = "button2";
            button2.Size = new Size(177, 47);
            button2.TabIndex = 1;
            button2.Text = "Araç CRUD İşlemleri";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(37, 31);
            button1.Name = "button1";
            button1.Size = new Size(177, 47);
            button1.TabIndex = 0;
            button1.Text = "Araç Ekleme İşlemleri";
            button1.UseVisualStyleBackColor = true;
            // 
            // AracFiyatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 700);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AracFiyatForm";
            Text = "AracFiyatForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}