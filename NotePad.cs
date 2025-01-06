using Microsoft.VisualBasic.ApplicationServices;
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
            int CurrentuserId =journal.UserJournalId;
            int JournalId = journal.EntryId;
            // Call the CreateEntry method to save the entry
            bool success = journal.CreateEntry(JournalId,CurrentuserId, content);

            // Clear the text area if the entry was saved successfully
            if (success)
            {
                NoteTxtBx.Text = ""; // Clear the text area
            }

        }

        private void BackJourBut_Click(object sender, EventArgs e)
        {
            DashFr dash=new DashFr();
            dash.Show();
            this.Close();
        }

        private void NoteTxtBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
