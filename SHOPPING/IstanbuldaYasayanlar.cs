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

        private void istanbuldayasam()
        {
            dbManager.IstanbuldaYasam(listView1);
            listView1.Refresh();
        }

        private void IstanbuldaYasayanlar_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbManager.IstanbuldaYasam(listView1);
        }
    }
}
