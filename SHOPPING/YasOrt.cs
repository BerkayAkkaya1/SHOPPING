using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOPPING
{
    public partial class YasOrt : Form
    {
        private DbManager dbManager;
        public YasOrt()
        {
            InitializeComponent();
        }

        private void YasOrt_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz!");
                return;
            }


            if (comboBox1.SelectedIndex == 0)
            {
                dbManager.CinsiyeteGoreYasOrtalama(textBox1, false);
            }
            else
            {
                dbManager.CinsiyeteGoreYasOrtalama(textBox1, true);

            }
        }

    }
}
