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
        public ClassJournal() { }
        public ClassJournal(int JournalId, int CureentUserId, string content)
        {
            EntryId = JournalId;
            UserJournalId = CureentUserId;
            Content = content;
        }
        // Method to create a journal entry
        public bool CreateEntry(int journalId, int CureentUserId, string content)
        {
            EntryId = journalId;
            UserJournalId = User.UserId;
            Content = content;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO journal (entryId,UserJournal_Id, Cotent) VALUES (@entryId,@UserJournal_Id, @Cotent)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@entryId", EntryId);
                        cmd.Parameters.AddWithValue("@UserJournal_Id", UserJournalId);
                        cmd.Parameters.AddWithValue("@Cotent", Content);

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
        public List<ClassJournal> ViewEntries()
        {
            List<ClassJournal> entries = new List<ClassJournal>();
            UserJournalId = User.UserId;
            DataTable DT = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Cotent FROM journal WHERE UserJournal_Id = @UserJournal_Id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserJournal_Id", UserJournalId);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        // Fill the DataTable with the result set
                        adapter.Fill(DT);
                        //foreach (DataRow row in DT.Rows)
                        //{
                        //    entries.Add(row["Cotent"]);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return entries;


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
    }


