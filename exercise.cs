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
    public partial class Exercise : Form
    {
        public Exercise()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Reopen the Dashboard form when Exercise form is closed
            DashFr dashboard = new DashFr();
            dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayVideo(4);
        }

        private void Exercise_Load(object sender, EventArgs e)
        {

        }
        private void PlayVideo(int exerciseId)
        {
            Excerise exercise = new Excerise().GetExercise(exerciseId);
            if (exercise != null)
            {
                WatchFr playerForm = new WatchFr(exercise.Link);
                playerForm.Show();
            }
            else
            {
                MessageBox.Show("Video not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void YogaWatchBut_Click(object sender, EventArgs e)
        {
            PlayVideo(2);
        }

        private void BreathBut_Click(object sender, EventArgs e)
        {
            PlayVideo(5);
        }

        private void PilatesBut_Click(object sender, EventArgs e)
        {
            PlayVideo(3);
        }

        private void TaiBut_Click(object sender, EventArgs e)
        {
            PlayVideo(1);
        }
    }
}
