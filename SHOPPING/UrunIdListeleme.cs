using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOPPING
{
    public partial class UrunIdListeleme : Form
    {
        private DbManager dbManager;
        public UrunIdListeleme()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dbManager.UrunIdListeleme(listView1, comboBox1);
        }
        private void UrunIdListeleme_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
            dbManager.UrunKategoriGetir(comboBox1);
            dbManager.UrunIdListeleme(listView1, comboBox1);
        }
    }
}
