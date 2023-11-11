using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace SHOPPING
{
    internal class DbManager
    {
       public void VerileriSirala(ListView listView)
       {
            using(SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
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

        public void CinsiyeteGoreYasOrtalama(TextBox textBox,bool cinsiyet)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT AVG(Age) AS AvgAge FROM Customers WHERE Gender = @p1", conn))
                {
                    if(cinsiyet)
                    {
                        cmd.Parameters.AddWithValue("@p1","E");
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

        public void EnCokSehir(TextBox textBox)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N5JHVVH;Initial Catalog=SHOPPING;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 City, COUNT(*) AS NumberOfCustomer FROM Customers GROUP BY City ORDER BY NumberOfCustomer DESC", conn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            textBox.Text = rdr["NumberOfCustomer"].ToString();
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
                            ListViewItem göster = new ListViewItem();
                            göster.Text = rdr["ID"].ToString();
                            göster.SubItems.Add(rdr["Name"].ToString());
                            göster.SubItems.Add(rdr["City"].ToString());
                            göster.SubItems.Add(rdr["BirthDate"].ToString());
                            göster.SubItems.Add(rdr["Gender"].ToString());
                            göster.SubItems.Add(rdr["Country"].ToString());
                            göster.SubItems.Add(rdr["Age"].ToString());
                            listView.Items.Add(göster);

                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
        }
    }
}
