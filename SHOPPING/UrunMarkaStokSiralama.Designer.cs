namespace SHOPPING
{
    partial class UrunMarkaStokSiralama
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
            TotalStock = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Brand, TotalStock });
            listView1.Location = new Point(293, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(171, 308);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Brand
            // 
            Brand.Text = "Brand";
            Brand.Width = 70;
            // 
            // TotalStock
            // 
            TotalStock.Text = "Total Stock";
            TotalStock.Width = 70;
            // 
            // button1
            // 
            button1.Location = new Point(293, 346);
            button1.Name = "button1";
            button1.Size = new Size(171, 56);
            button1.TabIndex = 1;
            button1.Text = "Ürünleri Sırala";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UrunMarkaStokSiralama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "UrunMarkaStokSiralama";
            Text = "UrunMarkaStokSiralama";
            Load += UrunMarkaStokSiralama_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ColumnHeader Brand;
        private ColumnHeader TotalStock;
    }
}