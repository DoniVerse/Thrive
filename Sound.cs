using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrive
{
    internal class Sound
    {
        public int SoundId { get; set; }
        public string? SoundFile { get; set; }
        private string connectionString = "server=localhost;database=thrive;user=root;password=;";

        public Sound PLaySound(int SoundId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SoundId,SoundFile  FROM sound WHERE SoundId= @SoundId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SoundId", SoundId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Sound
                            {
                                SoundId = reader.GetInt32("SoundId"),
                                SoundFile = reader.GetString("SoundFile")
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
