using AxWMPLib;
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
    public partial class WatchFr : Form
    {
        public WatchFr()
        {
            InitializeComponent();
        }
        public WatchFr(string videoUrl)
        {
            InitializeComponent();
            WatchMediaPlayer.URL = videoUrl; // Set the video URL
            WatchMediaPlayer.Ctlcontrols.play(); // Start playback
        }

        private void WatchMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void WatchFrBut_Click(object sender, EventArgs e)
        {
            DashFr ds = new DashFr();
            ds.Show();
            this.Close();
        }

        private void WatchFr_Load(object sender, EventArgs e)
        {

        }
    }
}
