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

        }
    }
}
