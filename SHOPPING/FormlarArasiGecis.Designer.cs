﻿namespace SHOPPING
{
    partial class FormlarArasiGecis
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 28);
            button1.Name = "button1";
            button1.Size = new Size(263, 23);
            button1.TabIndex = 0;
            button1.Text = "Yaşların Büyükten Küçüğe Sıralanması";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(77, 75);
            button2.Name = "button2";
            button2.Size = new Size(263, 23);
            button2.TabIndex = 1;
            button2.Text = "Müşterilerin Yaşlarının Ortalaması";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(77, 121);
            button3.Name = "button3";
            button3.Size = new Size(263, 23);
            button3.TabIndex = 2;
            button3.Text = "Müşterilerin En Çok Geldiği Şehir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(77, 169);
            button4.Name = "button4";
            button4.Size = new Size(263, 23);
            button4.TabIndex = 3;
            button4.Text = "İstanbul'da Yaşayan Müşteriler";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(77, 259);
            button5.Name = "button5";
            button5.Size = new Size(263, 23);
            button5.TabIndex = 4;
            button5.Text = "Stok Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(77, 215);
            button6.Name = "button6";
            button6.Size = new Size(263, 23);
            button6.TabIndex = 5;
            button6.Text = "Ürün Ekleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(419, 28);
            button7.Name = "button7";
            button7.Size = new Size(263, 23);
            button7.TabIndex = 6;
            button7.Text = "Ürün Stoklarını Listeleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(419, 75);
            button8.Name = "button8";
            button8.Size = new Size(263, 23);
            button8.TabIndex = 7;
            button8.Text = "Ürün ID si 10 dan küçük olan ürünleri listleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(419, 121);
            button9.Name = "button9";
            button9.Size = new Size(263, 43);
            button9.TabIndex = 8;
            button9.Text = "Ürünlerin marka ve stok adetlerini küçükten büyüğe sıralama";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // FormlarArasiGecis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormlarArasiGecis";
            Text = "Formlar Arası Geçiş";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}