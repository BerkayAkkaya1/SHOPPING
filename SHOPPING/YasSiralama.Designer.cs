namespace SHOPPING
{
    partial class YasSiralama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            header = new ColumnHeader();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Name, City, BirthDate, Gender, Country, Age });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(509, 582);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 40;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 90;
            // 
            // City
            // 
            City.Text = "City";
            // 
            // BirthDate
            // 
            BirthDate.Text = "BirthDate";
            BirthDate.Width = 70;
            // 
            // Gender
            // 
            Gender.Text = "Gender";
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
            // header
            // 
            header.Text = "YasSiralama";
            // 
            // button2
            // 
            button2.Location = new Point(783, 234);
            button2.Name = "button2";
            button2.Size = new Size(103, 145);
            button2.TabIndex = 3;
            button2.Text = "Sıralayınız";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // YasSiralama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 606);
            Controls.Add(button2);
            Controls.Add(listView1);
            Text = "Müşteri Yaşlarını Büyükten Küçüğe Sıralama";
            Load += YasSiralama_Load;
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
        private ColumnHeader header;
        private Button button2;
    }
}