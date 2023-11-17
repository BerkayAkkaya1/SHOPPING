using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOPPING
{
    internal class DbManager
    {
        public void VerileriSirala(System.Windows.Forms.ListView listView)
        {
            listView.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers ORDER BY Age DESC;", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ListViewItem sirala = new ListViewItem();
                            sirala.Text = rdr["ID"].ToString();
                            sirala.SubItems.Add(rdr["Name"].ToString());
                            sirala.SubItems.Add(rdr["City"].ToString());
                            sirala.SubItems.Add(rdr["BirthDate"].ToString());
                            sirala.SubItems.Add(rdr["Gender"].ToString());
                            sirala.SubItems.Add(rdr["Country"].ToString());
                            sirala.SubItems.Add(rdr["Age"].ToString());
                            listView.Items.Add(sirala);

                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void CinsiyeteGoreYasOrtalama(System.Windows.Forms.TextBox textBox, bool cinsiyet)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT AVG(Age) AS AvgAge FROM Customers WHERE Gender = @p1", conn))
                {
                    if (cinsiyet)
                    {
                        cmd.Parameters.AddWithValue("@p1", "E");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p1", "K");
                    }
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            textBox.Text = rdr["AvgAge"].ToString();
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void EnCokSehir(System.Windows.Forms.ListView listView)
        {
            listView.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Top 1 City, COUNT(*) AS NumberOfCustomer FROM Customers GROUP BY City ORDER BY NumberOfCustomer DESC", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ListViewItem sehir = new ListViewItem();
                            sehir.Text = rdr["City"].ToString();
                            sehir.SubItems.Add(rdr["NumberOfCustomer"].ToString());
                            listView.Items.Add(sehir);
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void SehirGetir(System.Windows.Forms.ComboBox comboBox2)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Hepsi");
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT City FROM Customers", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            comboBox2.Items.Add(rdr["City"].ToString());
                        }
                        comboBox2.SelectedIndex = 0;
                    }
                }
                conn.Close();
            }
        }
        public void IstanbuldaYasam(System.Windows.Forms.ListView listView, System.Windows.Forms.ComboBox comboBox1, System.Windows.Forms.ComboBox comboBox2)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE City = @p1 AND Gender = @p2", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", comboBox2.SelectedValue != null ? comboBox2.SelectedValue.ToString() : "");
                    cmd.Parameters.AddWithValue("@p2", comboBox1.SelectedValue != null ? comboBox1.SelectedValue.ToString() : "");
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ListViewItem siralama = new ListViewItem();
                            siralama.Text = rdr["ID"].ToString();
                            siralama.SubItems.Add(rdr["Name"].ToString());
                            siralama.SubItems.Add(rdr["City"].ToString());
                            siralama.SubItems.Add(rdr["BirthDate"].ToString());
                            siralama.SubItems.Add(rdr["Gender"].ToString());
                            siralama.SubItems.Add(rdr["Country"].ToString());
                            siralama.SubItems.Add(rdr["Age"].ToString());
                            listView.Items.Add(siralama);
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void UrunStokListe(System.Windows.Forms.ListView listView, string maksStok)
        {
            listView.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Brand, Name, Stock FROM Product P INNER JOIN Stock S ON P.ProductId = S.ProductId Where Stock <= @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", maksStok);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string Brand = rdr["Brand"].ToString();
                            string Name = rdr["Name"].ToString();
                            int Stock = Convert.ToInt32(rdr["Stock"]);

                            ListViewItem listViewItem = new ListViewItem(new string[] { Brand, Name, Stock.ToString() });
                            listView.Items.Add(listViewItem);

                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void UrunKategoriGetir(System.Windows.Forms.ComboBox comboBox1)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Hepsi");

                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Category FROM Product", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            comboBox1.Items.Add(rdr["Category"].ToString());
                        }
                        comboBox1.SelectedIndex = 0;

                    }
                }
                conn.Close();

            }
        }
        public void UrunIdListeleme(System.Windows.Forms.ListView listView, System.Windows.Forms.ComboBox comboBox1)
        {
            listView.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                string commandText = "";
                if(comboBox1.Text!="Hepsi")
                {
                    commandText = "SELECT Name, Price, Category FROM Product Where ProductId < 10 and Category=@p1";
                }
                else
                {
                    commandText = "SELECT Name, Price, Category FROM Product Where ProductId < 10";
                }

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    if (comboBox1.SelectedText != "Hepsi")
                    {
                        cmd.Parameters.AddWithValue("@p1",comboBox1.Text);
                    }
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = rdr["Name"].ToString();
                            item.SubItems.Add(rdr["Price"].ToString());
                            item.SubItems.Add(rdr["Category"].ToString());
                            listView.Items.Add(item);
                        }
                        rdr.Close();
                    }
                }
                conn.Close();  
            }
        }
        public void UrunMarkaStokSiralama(System.Windows.Forms.ListView listView)
        {
            listView.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Brand, SUM(Stock) AS TotalStock FROM Product P INNER JOIN Stock S ON P.ProductId = S.ProductId GROUP BY P.Brand ORDER BY TotalStock ASC", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ListViewItem siralama = new ListViewItem();
                            siralama.Text = rdr["Brand"].ToString();
                            siralama.SubItems.Add(rdr["TotalStock"].ToString());
                            listView.Items.Add(siralama);
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void stokekle(int textBox1, int textBox2)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Stock(ProductId,Stock) VALUES(@p1,@p2)", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", textBox1);
                    cmd.Parameters.AddWithValue("@p2", textBox2);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
