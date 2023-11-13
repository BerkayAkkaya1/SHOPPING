using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SHOPPING
{
    internal class DbManager
    {
        public void VerileriSirala(ListView listView)
        {
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
        public void CinsiyeteGoreYasOrtalama(TextBox textBox, bool cinsiyet)
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
        public void EnCokSehir(ListView listView)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT City, COUNT(*) AS NumberOfCustomer FROM Customers GROUP BY City ORDER BY NumberOfCustomer DESC",conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ListViewItem sehir = new ListViewItem();
                            sehir.Text = rdr["City"].ToString();
                            sehir.SubItems.Add(rdr["NumberOfCustomer"].ToString());
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void IstanbuldaYasam(ListView listView)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE City = 'İstanbul' AND Gender = 'K'", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ListViewItem goster = new ListViewItem();
                            goster.Text = rdr["ID"].ToString();
                            goster.SubItems.Add(rdr["Name"].ToString());
                            goster.SubItems.Add(rdr["City"].ToString());
                            goster.SubItems.Add(rdr["BirthDate"].ToString());
                            goster.SubItems.Add(rdr["Gender"].ToString());
                            goster.SubItems.Add(rdr["Country"].ToString());
                            goster.SubItems.Add(rdr["Age"].ToString());
                            listView.Items.Add(goster);
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void UrunStokListe(ListView listView, string maksStok)
        {
            listView.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Brand, Name, Stock FROM Product P INNER JOIN Stock S ON P.ProductId = S.ProductId Where Stock < @p1", conn))
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
        public void UrunIdListeleme(ListView listView, string kategori)
        {
            listView.Items.Clear();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Name, Price, Category FROM Product Where ProductId <10 And Category = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", kategori);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string Name = rdr["Name"].ToString();
                            decimal Price = (decimal)rdr["Price"];
                            string Category = rdr["Category"].ToString();

                            ListViewItem listViewItem = new ListViewItem(new string[] { Name, Price.ToString(), Category });
                            listView.Items.Add(listViewItem);
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
        public void UrunMarkaStokSiralama(ListView listView)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Brand, SUM(Stock) AS TotalStock FROM Product P INNER JOIN Stock S ON P.ProductId = S.ProductId GROUP BY P.Brand ORDER BY TotalStock ASC", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader()) 
                    { 
                        while(rdr.Read())
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
        public void Urunekle(string TxtBrand, string TxtName,string TxtCategory, string TxtImages,decimal TxtPrice) 
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True")) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Product(Brand,Name,Price,Category,Image) VALUES (@p1,@p2,@p3,@p4,@p5)",conn)) 
                {
                    cmd.Parameters.AddWithValue("@p1", TxtBrand);
                    cmd.Parameters.AddWithValue("@p2", TxtName);
                    cmd.Parameters.AddWithValue("@p3", TxtPrice);
                    cmd.Parameters.AddWithValue("@p4", TxtCategory);
                    cmd.Parameters.AddWithValue("@p5", TxtImages);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
