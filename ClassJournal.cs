﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrive
{
    internal class ClassJournal
    {
        public int EntryId { get; set; }
        public int UserJournalId { get; set; }
        public string? Content { get; set; }
        private string connectionString = "server=localhost;database=thrive;user=root;password=;";
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
        public DataTable ViewEntries()
        {
            int UserJournalId =  User.UserId;
           
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            MySqlCommand cmd = new MySqlCommand("SELECT cotent FROM  journal WHERE UserJournal_Id = @UserJournal_Id", conn);
            cmd.Parameters.AddWithValue("@UserJournal_Id", UserJournalId);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
          
            return dt;
        }


    }
}


