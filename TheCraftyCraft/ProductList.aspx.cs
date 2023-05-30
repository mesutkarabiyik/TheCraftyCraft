using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheCraftyCraft
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc\\source\\repos\\TheCraftyCraft\\TheCraftyCraft\\App_Data\\CraftyCartDB.mdf;Integrated Security=True";
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                   

                    while (reader.Read())
                    {
                        Product product = new Product
                        {

                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToInt64(reader["Price"]),
                            StockAmount = Convert.ToInt32(reader["StockAmount"]),
                            ImageUrl = reader["ImageUrl"].ToString()

                        };

                        products.Add(product);
                    }

                    reader.Close();

                }
            }

            ListView1.DataSource = products;
            ListView1.DataBind();

        }
    }
}
