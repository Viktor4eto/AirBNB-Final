using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace AirBNB
{
    public class authenticate
    {
        public class User
        {
            public int id { get; set; }
            public string Username { get; set; } // User's username property
            public string Email { get; set; }
            public string Phone { get; set; }

        }

        /* The DatabaseManager class is responsible for handling database operations, including user authentication. 
        * This is a good practice in software design, as it allows for better organization and maintainability. */
        public class DatabaseManager
        {
            // Method to authenticate user
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            /*The RetrieveUserInformation method encapsulates the logic for querying the database and retrieving user information based on the provided username and password. 
            * This method is private, meaning it is intended to be used only within the DatabaseManager class. */
            private static User RetrieveUserInformation(string username, string password)
            {
                // Using statement ensures proper disposal of resources
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\local; Initial Catalog=AirBNB; Integrated Security=True;"))
                {
                    sqlCon.Open(); // Open SQL connection

                    string loginQuery = "SELECT COUNT(1) FROM Users Where username=@Username AND password=@Password";
                    string imgQuery = "SELECT user_id, email, phone_number FROM Users WHERE username=@Username AND password=@Password";


                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        using (SqlCommand imgCmd = new SqlCommand(imgQuery, sqlCon))
                        {
                            loginCmd.CommandType = CommandType.Text;
                            imgCmd.CommandType = CommandType.Text;

                            loginCmd.Parameters.AddWithValue("@Username", username);
                            loginCmd.Parameters.AddWithValue("@Password", password);
                            imgCmd.Parameters.AddWithValue("@Username", username);
                            imgCmd.Parameters.AddWithValue("@Password", password);

                            int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                            if (count == 1)
                            {
                                using (SqlDataReader reader = imgCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string email = reader["email"] as string;
                                        string phone = reader["phone_number"] as string;
                                        int id_ = Convert.ToInt32(reader["user_id"]);

                                        return new User {id = id_, Username = username, Email = email, Phone = phone };
                                    }
                                }
                            }

                            return null; // Return null if no user is found with the specified username and password

                        }
                    }
                }
            }
        }
    }
}
