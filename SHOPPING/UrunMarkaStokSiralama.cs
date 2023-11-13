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
    public partial class UrunMarkaStokSiralama : Form
    {
        private DbManager dbManager;
        public UrunMarkaStokSiralama()
        {
            InitializeComponent();
        }

        private void UrunMarkaStokSiralama_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbManager.UrunMarkaStokSiralama(listView1);
        }
    }
}
