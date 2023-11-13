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
    public partial class FormlarArasiGecis : Form
    {
        public FormlarArasiGecis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YasSiralama yasSiralama = new YasSiralama();
            yasSiralama.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YasOrt yasOrt = new YasOrt();
            yasOrt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnCokSehir enCokSehir = new EnCokSehir();
            enCokSehir.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IstanbuldaYasayanlar istanbuldaYasayanlar = new IstanbuldaYasayanlar();
            istanbuldaYasayanlar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UrunEkleme urunEkleme = new UrunEkleme();
            urunEkleme.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StokEkleme stokEkleme = new StokEkleme();
            stokEkleme.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UrunStokListeleme urunStokListeleme = new UrunStokListeleme();
            urunStokListeleme.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UrunIdListeleme urunIdListeleme = new UrunIdListeleme();
            urunIdListeleme.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UrunMarkaStokSiralama urunMarkaStokSiralama = new UrunMarkaStokSiralama();
            urunMarkaStokSiralama.ShowDialog();
        }
    }
}
