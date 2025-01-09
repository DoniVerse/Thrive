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
    public partial class MediaPlayer : Form
    {
        private List<string> musicFiles;
        private string currentsong;
        private bool isPaused;
        private bool isChangingPosition;

        public MediaPlayer()
        {
            InitializeComponent();
            musicFiles = new List<string>();
            isPaused = false;
            isChangingPosition = false;
        }

        private void siticoneFilledIconButton1_Click(object sender, EventArgs e)
        {

        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Multiselect = true;
            OpenFileDialog.Filter = "MP3 Files | *.mp3";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OpenFileDialog.FileNames)
                {
                    musicFiles.Add(file);
                    listBox1.Items.Add(Path.GetFileName(file));


                }
                if (musicFiles.Count > 0)
                {
                    btnSart.Enabled = true;

                }
            }

        }

        private void btnSart_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                if (isPaused)
                {
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;

                }
                else
                {
                    currentsong = musicFiles[listBox1.SelectedIndex];
                    musicPlayer.URL = currentsong;
                    musicPlayer.Ctlcontrols.play();

                }
                timerplayback.Enabled = true;
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
            isPaused = false;
            timerplayback.Enabled = false;

        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                musicPlayer.Ctlcontrols.pause();
                isPaused = true;
            }
            else
            {
                musicPlayer.Ctlcontrols.play();
                isPaused = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string formatTime(double seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");

        }

        private void timerplayback_Tick(object sender, EventArgs e)
        {
            if (!isChangingPosition)
            {

            }
        }

        private void musicPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                int nextIndex = listBox1.SelectedIndex + 1;
                if (nextIndex < musicFiles.Count)
                {
                    listBox1.SelectedIndex = nextIndex;
                    currentsong = musicFiles[nextIndex];
                    musicPlayer.URL = currentsong;
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;
                }
                else
                {
                    musicPlayer.Ctlcontrols.pause();
                    isPaused = false;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            musicPlayer.settings.volume = trackBar1.Value;
        }
    }
}
