namespace SHOPPING
{
    partial class EnCokSehir
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
            listView1 = new ListView();
            City = new ColumnHeader();
            NumberOfCustomer = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 90);
            button1.Name = "button1";
            button1.Size = new Size(140, 53);
            button1.TabIndex = 1;
            button1.Text = "İli Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { City, NumberOfCustomer });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(200, 61);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // City
            // 
            City.Text = "City";
            // 
            // NumberOfCustomer
            // 
            NumberOfCustomer.Text = "Number Of Customer";
            NumberOfCustomer.Width = 127;
            // 
            // EnCokSehir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 540);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "EnCokSehir";
            Text = "EnCokSehir";
            Load += EnCokSehir_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListView listView1;
        private ColumnHeader City;
        private ColumnHeader NumberOfCustomer;
    }
}