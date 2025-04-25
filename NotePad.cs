using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrive
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Reopen the Dashboard form when Exercise form is closed
            DashFr dashboard = new DashFr();
            dashboard.Show();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {

            string content = NoteTxtBx.Text;

            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please enter some content for the journal entry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create an instance of the Journal class

            ClassJournal journal = new ClassJournal();
            int CurrentuserId = journal.UserJournalId;
            int JournalId = journal.EntryId;
            //string ?cotent = journal.Content;
            // Call the CreateEntry method to save the entry

            bool success = journal.CreateEntry(JournalId, CurrentuserId, content);

            // Clear the text area if the entry was saved successfully
            if (success)
            {
                MessageBox.Show("Journal added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                NoteTxtBx.Text = ""; // Clear the text area

            }

        }

        private void BackJourBut_Click(object sender, EventArgs e)
        {
           
            ClassJournal cs = new ClassJournal();
            dataGridView1.DataSource = cs.ViewEntries();

        }

        private void NoteTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotePad_Load(object sender, EventArgs e)
        {

          

        }
    }
}
