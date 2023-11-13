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
    public partial class UrunIdListeleme : Form
    {
        private DbManager dbManager;
        public UrunIdListeleme()
        {
            InitializeComponent();
        }
        private void UrunIdListeleme_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty || comboBox1.Text == null)
            {
                dbManager.UrunIdListeleme(listView1, int.MaxValue.ToString());
            }
            else
            {

                dbManager.UrunIdListeleme(listView1, comboBox1.Text);
            }
        }
    }
}
