﻿namespace SHOPPING
{
    partial class UrunEkleme
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtName = new TextBox();
            TxtCategory = new TextBox();
            TxtPrice = new TextBox();
            TxtImages = new TextBox();
            label2 = new Label();
            TxtBrand = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            urunEklemeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urunEklemeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SamsungOneUISCN 450", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 0;
            label1.Text = "Product Brand :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SamsungOneUISCN 450", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 97);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 2;
            label3.Text = "Product Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SamsungOneUISCN 450", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 136);
            label4.Name = "label4";
            label4.Size = new Size(140, 19);
            label4.TabIndex = 3;
            label4.Text = "Product Category :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SamsungOneUISCN 450", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 170);
            label5.Name = "label5";
            label5.Size = new Size(126, 19);
            label5.TabIndex = 4;
            label5.Text = "Product Picture :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(170, 58);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(161, 23);
            TxtName.TabIndex = 5;
            // 
            // TxtCategory
            // 
            TxtCategory.Location = new Point(170, 132);
            TxtCategory.Name = "TxtCategory";
            TxtCategory.Size = new Size(161, 23);
            TxtCategory.TabIndex = 6;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(170, 92);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(161, 23);
            TxtPrice.TabIndex = 7;
            // 
            // TxtImages
            // 
            TxtImages.Location = new Point(170, 166);
            TxtImages.Name = "TxtImages";
            TxtImages.Size = new Size(161, 23);
            TxtImages.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SamsungOneUISCN 450", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 1;
            label2.Text = "Product Name :";
            // 
            // TxtBrand
            // 
            TxtBrand.Location = new Point(170, 29);
            TxtBrand.Name = "TxtBrand";
            TxtBrand.Size = new Size(161, 23);
            TxtBrand.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(201, 219);
            button1.Name = "button1";
            button1.Size = new Size(96, 34);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(337, 166);
            button2.Name = "button2";
            button2.Size = new Size(26, 23);
            button2.TabIndex = 11;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(505, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // urunEklemeBindingSource
            // 
            urunEklemeBindingSource.DataSource = typeof(UrunEkleme);
            // 
            // UrunEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 527);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TxtBrand);
            Controls.Add(TxtImages);
            Controls.Add(TxtPrice);
            Controls.Add(TxtCategory);
            Controls.Add(TxtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunEkleme";
            Text = "UrunEkleme";
            Load += UrunEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)urunEklemeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtName;
        private TextBox TxtCategory;
        private TextBox TxtPrice;
        private TextBox TxtImages;
        private Label label2;
        private TextBox TxtBrand;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private BindingSource urunEklemeBindingSource;
    }
}