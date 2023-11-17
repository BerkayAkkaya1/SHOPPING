using System;
using System.Data.SqlClient;

namespace SHOPPING
{
    public partial class IstanbuldaYasayanlar : Form
    {
        private DbManager dbManager;
        public IstanbuldaYasayanlar()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz");
            }
            if (comboBox1.SelectedIndex == 0)
            {
                dbManager.IstanbuldaYasam(listView1,comboBox1,comboBox2);
            }
           
            dbManager.IstanbuldaYasam(listView1, comboBox1, comboBox2);
            dbManager.SehirGetir(comboBox2);
        }
        private void IstanbuldaYasayanlar_Load_1(object sender, EventArgs e)
        {
            dbManager = new DbManager();
            dbManager.SehirGetir(comboBox2);
            dbManager.IstanbuldaYasam(listView1, comboBox1, comboBox2);
        }
    }
}