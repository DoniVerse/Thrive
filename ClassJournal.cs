using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrive
{
    internal class ClassJournal
    {
        public int EntryId { get; set; }
        public int UserJournalId { get; set; }
        public string? Content { get; set; }
        private string connectionString = "server=localhost;database=Thrive;user=root;password=;";

        // Method to create a journal entry
        public bool CreateEntry(int journalId,int CureentUserId, string content)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string userCheckQuery = "SELECT COUNT(*) FROM user WHERE UserId = @UserId";
                    using (MySqlCommand userCheckCmd = new MySqlCommand(userCheckQuery, connection))
                    {
                        userCheckCmd.Parameters.AddWithValue("@UserId",CureentUserId);
                        using (MySqlDataReader reader = userCheckCmd.ExecuteReader())
                        {
                            if (!reader.HasRows) // Check if any rows are returned
                            {
                                MessageBox.Show("User ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }

                    string query = "INSERT INTO Journal (entryId,UserJournal_Id, Cotent) VALUES (@entryId,@UserJournal_Id, @Cotent)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@entryId", journalId);
                        cmd.Parameters.AddWithValue("@UserJournal_Id", CureentUserId);
                        cmd.Parameters.AddWithValue("@Cotent", content);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Journal entry created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452) // MySQL error code for foreign key constraint failure
                {
                    MessageBox.Show("Foreign key constraint failed. Ensure the User ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //public List<Journal> ViewEntries(int userId)
        //{
        //    List<Journal> entries = new List<Journal>();

        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            string query = "SELECT EntryId, UserId, Content, CreatedAt FROM Journal WHERE UserId = @UserId ORDER BY CreatedAt DESC";
        //            using (MySqlCommand cmd = new MySqlCommand(query, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@UserId", userId);

        //                using (MySqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        entries.Add(new Journal
        //                        {
        //                            EntryId = reader.GetInt32("EntryId"),
        //                            UserId = reader.GetInt32("UserId"),
        //                            Content = reader.GetString("Content")
        //                        });
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

            //return entries;

        
        //public bool DeleteEntry(int entryId)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            string query = "DELETE FROM Journal WHERE EntryId = @EntryId";
        //            using (MySqlCommand cmd = new MySqlCommand(query, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@EntryId", entryId);
        //                cmd.ExecuteNonQuery();
        //            }

        //            MessageBox.Show("Journal entry deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}

    }
}

