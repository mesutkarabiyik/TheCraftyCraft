using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheCraftyCraft
{
    public partial class LoginSignup : System.Web.UI.Page
    {
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            {
                string usernam = username.Value;
                string passwor = password.Value;

                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc\\source\\repos\\TheCraftyCraft\\TheCraftyCraft\\App_Data\\CraftyCartDB.mdf;Integrated Security=True"; // Replace with your actual database connection string
                string query = "SELECT * FROM Users WHERE username = @username AND password = @password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernam);
                        command.Parameters.AddWithValue("@password", passwor);

                        try
                        {
                            connection.Open();

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                Response.Redirect("LoginSuccess.aspx");
                            }
                            else
                            {
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }

        protected void SignupButton_Click(object sender, EventArgs e)
        {
            string usernam = username.Value;
            string passwor = password.Value;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc\\source\\repos\\TheCraftyCraft\\TheCraftyCraft\\App_Data\\CraftyCartDB.mdf;Integrated Security=True";
            string query = "INSERT INTO Users (username, password) VALUES (@username, @password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", usernam);
                    command.Parameters.AddWithValue("@password", passwor);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        Response.Redirect("SignupSuccess.aspx");
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }


}