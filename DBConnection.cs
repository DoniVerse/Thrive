using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace thrive
{
    internal class DBConnection
    {
        private readonly string connectionString;

        public DBConnection()
        {
            // Replace with your actual connection string
            connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\xampp\\htdocs\\Thrive\\ThriveDB.mdf; Integrated Security = True";
        }

        //public string TestConnection()
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open(); // Attempt to open the connection
        //            return "Database connection successful!";
        //            // Connection worked
        //        }
        //        catch (Exception ex)
        //        {
        //            return $"Database connection failed: {ex.Message}";
        //        }
        //    }
        //    // Connection failed
        //}
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
        }
    

