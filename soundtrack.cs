using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace thrive
{
    public partial class SoundTrack : Form
    {

       
        public SoundTrack()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            DashFr dashboard = new DashFr();
            dashboard.Show();
        }
        private void Play(int SoundId)
        {
            Sound Sd = new Sound().PLaySound(SoundId);
            if (Sd != null)
            {
                WatchFr playerForm = new WatchFr(Sd.SoundFile);
                playerForm.Show();
            }
            else
            {
                MessageBox.Show("sound not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SoundTrack_Load(object sender, EventArgs e)
        {

        }

        //private void rainlabel_Click(object sender, EventArgs e)
        //{

        //}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Play(3);
        }

        private void RainLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Play(1);

        }

        private void NatureLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Play(2);
        }

        private void NFLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Play(4);
        }

        private void CozyLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Play(5);

        }
    }
}
