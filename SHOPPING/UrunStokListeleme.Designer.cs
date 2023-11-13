namespace SHOPPING
{
    partial class UrunStokListeleme
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
            Brand = new ColumnHeader();
            Name = new ColumnHeader();
            Stock = new ColumnHeader();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Brand, Name, Stock });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(294, 382);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Brand
            // 
            Brand.Text = "Brand";
            // 
            // Name
            // 
            Name.Text = "UrunStokListeleme";
            Name.Width = 80;
            // 
            // Stock
            // 
            Stock.Text = "Stock";
            // 
            // button1
            // 
            button1.Location = new Point(437, 143);
            button1.Name = "button1";
            button1.Size = new Size(121, 110);
            button1.TabIndex = 1;
            button1.Text = "Listeleyiniz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "15", "25" });
            comboBox1.Location = new Point(437, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // UrunStokListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listView1);

            Text = "UrunStokListeleme";
            Load += UrunStokListeleme_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Brand;
        private ColumnHeader Name;
        private ColumnHeader Stock;
        private Button button1;
        private ComboBox comboBox1;
    }
}