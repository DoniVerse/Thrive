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
         
            List<MoodTracker> moodHistory = mT.GetMoodHistory(mT.UserId);

            // Display in a list view or grid view
            foreach (var mood in moodHistory)
            {
                ListViewItem item = new ListViewItem(mood.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(mood.MoodScore);
                MoodListView.Items.Add(item);
                
            }
        }

        private void MoodHisDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
