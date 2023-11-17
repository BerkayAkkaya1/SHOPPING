using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOPPING
{
    public partial class StokEkleme : Form
    {
        private DbManager dbManager;
        public StokEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ProductId = int.Parse(textBox1.Text);
            int Stock = int.Parse(textBox2.Text);
            dbManager.stokekle(ProductId, Stock);
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void StokEkleme_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }
    }
}
