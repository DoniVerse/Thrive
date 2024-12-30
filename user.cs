using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
namespace thrive
{
    internal class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
       private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\xampp\\htdocs\\Thrive\\ThriveDB.mdf;Integrated Security=True";
       
        public bool Register()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM User WHERE UserName = @UserName OR Email = @Email";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserName", UserName);
                        checkCommand.Parameters.AddWithValue("@Email", Email);

                        int userCount = (int)checkCommand.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("User with this username or email already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; 
                        }
                    }


                    // Insert the new user
                    string insertQuery = "INSERT INTO User (UserName, Email, Password) VALUES (@UserName, @Email, @Password); SELECT SCOPE_IDENTITY();"; //Get the last inserted ID
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserName", UserName);
                        insertCommand.Parameters.AddWithValue("@Email", Email);
                        insertCommand.Parameters.AddWithValue("@Password", Password); // In real apps, HASH the password

                        UserId = Convert.ToInt32(insertCommand.ExecuteScalar()); //Get the inserted ID
                    }

                    return true; // Registration successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

        }
        //public bool Login()
        //{
        //    try
        //    {
        //        // Establish the connection
        //        SqlConnection conn = GetConnection();
        //        conn.Open();

        //        // Log: Debugging database connection
        //        Console.WriteLine("Database connection opened successfully.");

        //        // Query to retrieve the user's hashed password
        //        string query = "SELECT Password FROM Users WHERE Email = @Email";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@Email", Email);

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        // Log: Debugging query execution
        //        Console.WriteLine("SQL query executed.");

        //        if (reader.Read())
        //        {
        //            string? storedPassword = reader["Password"].ToString();

        //            // Verify the password
        //            if (BCrypt.Net.BCrypt.Verify(Password, storedPassword))
        //            {
        //                Console.WriteLine("Login successful.");
        //                conn.Close();
        //                return true;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid password.");
        //                conn.Close();
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("User not found.");
        //            conn.Close();
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the error to identify the issue
        //        Console.WriteLine($"Error during login: {ex.Message}");
        //        return false;
        //    }
        //}
    }
}
