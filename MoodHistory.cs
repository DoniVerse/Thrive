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
    public partial class MoodHistory : Form
    {
        MoodTracker mT = new MoodTracker();
        private int userIdentifier;
        public MoodHistory()
        {
            InitializeComponent();
            this.userIdentifier = mT.UserId;
            LoadMoodHistory();
        }
        //private void InitializeListView()
        //{
        //    MoodListView.View = View.Details;
        //    MoodListView.Columns.Add("Date", 100);
        //    MoodListView.Columns.Add("Mood(s)", 200);
        //}
        private void LoadMoodHistory()
        {
            // Retrieve mood history


        }

        private void MoodHisDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MoodTracker mt = new MoodTracker();
            int id = User.UserId;
            MoodListView.DataSource = mt.GetMoodHistory(id);
            MoodListView.AutoGenerateColumns = true;

        }

        private void MoodListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MoodListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void MoodHisBackBut_Click(object sender, EventArgs e)
        {
            MoodForm mf = new MoodForm();
            this.Close();
            mf.Show();
        }
    }
}
