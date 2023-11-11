using System;
using System.Data.SqlClient;

namespace SHOPPING
{
    public partial class YasSiralama : Form
    {
        private DbManager dbManager;
        public YasSiralama()
        {
            InitializeComponent();
        }

        private void verilerisirala()
        {
            dbManager.VerileriSirala(listView1);
            listView1.Refresh();
        }
        private void YasSiralama_Load(object sender, EventArgs e)
        {
            dbManager = new DbManager();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbManager.VerileriSirala(listView1);
        }
    }
}