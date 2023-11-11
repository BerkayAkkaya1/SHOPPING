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
using System.Data.SqlClient;

namespace SHOPPING
{
    public partial class EnCokSehir : Form
    {
        DbManager dbManager;
        public EnCokSehir()
        {
            InitializeComponent();
        }

        private void EnCokSehirden()
        {
            dbManager.EnCokSehir(textBox1);
            textBox1.Refresh();

        }
        private void EnCokSehir_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dbManager.EnCokSehir(textBox1);
        }
    }
}
