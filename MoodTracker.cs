using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrive
{
    internal class MoodTracker
    {
        public int MoodId { get; set; }
        public int UserId { get; set; }
        public string? MoodScore { get; set; } 
        public DateTime Date { get; set; }

        private string connectionString = "server=localhost;database=Thrive;user=root;password=;";

        // Method to log a mood
        public bool LogMood(int userId, string moodScore, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert mood entry into the database
                    string insertQuery = "INSERT INTO MoodTracker (UserId, MoodScore, Date) VALUES (@UserId, @MoodScore, @Date)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@MoodScore", moodScore);
                        command.Parameters.AddWithValue("@Date", date);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Mood logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging mood: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to get mood history
        public List<MoodTracker> GetMoodHistory(int userId)
        {
            List<MoodTracker> moodHistory = new List<MoodTracker>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve mood history for the user
                    string selectQuery = "SELECT MoodId, UserId, MoodScore, Date FROM MoodTracker WHERE UserId = @UserId ORDER BY Date DESC";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MoodTracker mood = new MoodTracker
                                {
                                    MoodId = reader.GetInt32("MoodId"),
                                    UserId = reader.GetInt32("UserId"),
                                    MoodScore = reader.GetString("MoodScore"),
                                    Date = reader.GetDateTime("Date")
                                };

                                moodHistory.Add(mood);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving mood history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return moodHistory;
        }
    
}
}
