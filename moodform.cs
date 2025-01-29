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
    public partial class MoodForm : Form
    {
        public MoodForm()
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
            string moodScore = string.Join("feeling: ", selectedMoods);

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

            int UserId = User.UserId;
            string connectionString = "server=localhost;database=thrive;user=root;password=123;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT MoodScore FROM  moodtracker WHERE UserId = @UserId", conn);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void MoodForm_Load(object sender, EventArgs e)
        {

        }

        private void MoodPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
