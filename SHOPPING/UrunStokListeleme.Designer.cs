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
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            button1.Location = new Point(406, 83);
            button1.Name = "button1";
            button1.Size = new Size(159, 110);
            button1.TabIndex = 1;
            button1.Text = "Listeleyiniz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(406, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(159, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // UrunStokListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Text = "UrunStokListeleme";
            Load += UrunStokListeleme_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Brand;
        private ColumnHeader Name;
        private ColumnHeader Stock;
        private Button button1;
        private NumericUpDown numericUpDown1;
    }
}