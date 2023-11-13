using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SHOPPING
{
    public partial class UrunStokListeleme : Form
    {
        private DbManager dbManager;
        public UrunStokListeleme()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty || comboBox1.Text == null)
            {
                dbManager.UrunStokListe(listView1, int.MaxValue.ToString());
            }
            else
            {
                dbManager.UrunStokListe(listView1, comboBox1.Text);
            }
        }
        private void UrunStokListeleme_Load_1(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }
    }
}
