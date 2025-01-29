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
    public partial class Journal : Form
    {
        //private int currentUserId;
        //public Journal(int UserId)
        //{
        //    InitializeComponent();
        //    currentUserId = UserId;
        //    LoadEntries();
        //}
        private void LoadEntries()
        {
            //ClassJournal journal = new ClassJournal();
            //List<Journal> entries = journal.ViewEntries(currentUserId);

            // Clear the list view before populating

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            NotePad note = new NotePad();
            note.Show();
            this.Close();
        }
        private void DelBut_Click(object sender, EventArgs e)
        {

        }

        private void Journal_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ClassJournal cj = new ClassJournal();
            journalGrid.DataSource = cj.ViewEntries();
            journalGrid.AutoGenerateColumns = true;

        }
    }
}

