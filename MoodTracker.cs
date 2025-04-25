using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        private string connectionString = "server=localhost;database=thrive;user=root;password=;";

        // Method to log a mood
        public bool LogMood(int userId, string moodScore, DateTime date)
        {
            UserId = User.UserId; 
            MoodScore = moodScore;
            Date = date;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert mood entry into the database
                    string insertQuery = "INSERT INTO MoodTracker (UserId, MoodScore, Date) VALUES (@UserId, @MoodScore, @Date)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId);
                        command.Parameters.AddWithValue("@MoodScore", MoodScore);
                        command.Parameters.AddWithValue("@Date", Date);

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

        //Method to get mood history
        public DataTable GetMoodHistory(int userId)
        {
            userId= User.UserId;
            DataTable MHT = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //connection.Open();

                    // Retrieve mood history for the user
                    string selectQuery = "SELECT MoodScore,Date FROM moodtracker WHERE UserId = @UserId ORDER BY Date DESC ";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@UserId", userId);
                        adapter.Fill(MHT);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving mood history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return MHT;
        }

    }
}
