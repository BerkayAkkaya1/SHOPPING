﻿namespace SHOPPING
{
    partial class IstanbuldaYasayanlar
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
            listView1 = new ListView();
            ID = new ColumnHeader();
            Name = new ColumnHeader();
            City = new ColumnHeader();
            BirthDate = new ColumnHeader();
            Gender = new ColumnHeader();
            Country = new ColumnHeader();
            Age = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Name, City, BirthDate, Gender, Country, Age });
            listView1.Location = new Point(3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(485, 406);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 30;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.TextAlign = HorizontalAlignment.Center;
            Name.Width = 100;
            // 
            // City
            // 
            City.Text = "City";
            // 
            // BirthDate
            // 
            BirthDate.Text = "BirthDate";
            BirthDate.TextAlign = HorizontalAlignment.Center;
            BirthDate.Width = 140;
            // 
            // Gender
            // 
            Gender.Text = "Gender";
            Gender.Width = 50;
            // 
            // Country
            // 
            Country.Text = "Country";
            // 
            // Age
            // 
            Age.Text = "Age";
            Age.Width = 40;
            // 
            // button1
            // 
            button1.Location = new Point(562, 147);
            button1.Name = "button1";
            button1.Size = new Size(130, 123);
            button1.TabIndex = 1;
            button1.Text = "Gösteriniz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IstanbuldaYasayanlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Text = "IstanbuldaYasayanlar";
            Load += IstanbuldaYasayanlar_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Name;
        private ColumnHeader City;
        private ColumnHeader BirthDate;
        private ColumnHeader Gender;
        private ColumnHeader Country;
        private ColumnHeader Age;
        private Button button1;
    }
}