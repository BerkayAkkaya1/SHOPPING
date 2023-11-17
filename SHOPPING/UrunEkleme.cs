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
    public partial class UrunEkleme : Form
    {
        OpenFileDialog file = new OpenFileDialog();
        private DbManager dbManager;
        public UrunEkleme()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
            TxtImages.Text = file.FileName;
        }
        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtBrand = TxtBrand.Text;
            string txtName = TxtName.Text;
            string txtCategory = TxtCategory.Text;
            string txtImages = TxtImages.Text;
            decimal txtPrice = Convert.ToDecimal(TxtPrice.Text);
          //  dbManager.Urunekle(txtBrand, txtName, txtCategory, txtImages, txtPrice);
            MessageBox.Show("Kayıt Eklendi.");
        }
    }
}
