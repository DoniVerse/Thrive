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
    public partial class MoodForm : Form
    {
        public MoodForm()
        {
            InitializeComponent();
        }

        private void LogMoodBut_Click(object sender, EventArgs e)
        {
            List<string> selectedMoods = new List<string>();
            if (SadCheckBx.Checked) selectedMoods.Add("Sadness");
            if (JoyCheckBx.Checked) selectedMoods.Add("Joy");
            if (JoyCheckBx.Checked) selectedMoods.Add("Anger");
            if (FearCheckBx.Checked) selectedMoods.Add("Fear");
            if (AnxiCheckBx.Checked) selectedMoods.Add("Anxiety");
            if (DisCheckBx.Checked) selectedMoods.Add("Disgusted");

            if (selectedMoods.Count == 0)
            {
                MessageBox.Show("Please select at least one mood.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Concatenate selected moods into a single string
            string moodScore = string.Join("you are feeling, ", selectedMoods);

            // Get the date
            DateTime selectedDate = MoodDate.Value;

            // Log the mood
            MoodTracker moodTracker = new MoodTracker();
            int userId = moodTracker.UserId;
            moodTracker.LogMood(userId, moodScore, selectedDate);
        }

        private void AnxiCheckBx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MoodHisBut_Click(object sender, EventArgs e)
        {
            MoodHistory mh = new MoodHistory();
            mh.Show();
        }
    }
}
