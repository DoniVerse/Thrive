using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrive
{
    internal class Excerise
    {
        public int ExerciseId { get; set; }
        public string ?Link { get; set; }
        private string connectionString = "server=localhost;database=thrive;user=root;password=;";

        public Excerise GetExercise(int exerciseId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ExceriseId, Link FROM excerise WHERE ExceriseId= @ExceriseId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExceriseId", exerciseId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Excerise
                            {
                                ExerciseId = reader.GetInt32("ExceriseId"),
                                Link = reader.GetString("Link")
                            };
                        }
                    }
                }
            }
            return null;
        }
    }

}
