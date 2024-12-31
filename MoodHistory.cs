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
        private int userId;
        public MoodHistory()
        {
            InitializeComponent();
            this.userId = userId;
            LoadMoodHistory();
        }
        private void LoadMoodHistory()
        {
            // Retrieve mood history
            MoodTracker mT = new MoodTracker();
            List<MoodTracker> moodHistory = mT.GetMoodHistory(userId);

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
