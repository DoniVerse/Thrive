using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace thrive
{
    public partial class MediaPlayer : Form
    {
        private List<string> musicFiles;
        private Dictionary<string, Image> musicImages; // Dictionary to store music-image mapping
        private string currentsong;
        private bool isPaused;
        private bool isChangingPosition;

        public MediaPlayer()
        {
            InitializeComponent();
            musicFiles = new List<string>();
            musicImages = new Dictionary<string, Image>(); // Initialize the dictionary
            isPaused = false;
            isChangingPosition = false;

            listBox1.DrawMode = DrawMode.OwnerDrawFixed; // Enable custom drawing
            listBox1.DrawItem += ListBox1_DrawItem; // Subscribe to DrawItem event
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
            string musicFolderPath = @"C:\Users\HP\source\Thrive\Soundtracks"; // Change this to the full path of your folder
            LoadMusicFilesFromFolder(musicFolderPath);

            // Populate the ListBox with music file names
            foreach (var file in musicFiles)
            {
                listBox1.Items.Add(Path.GetFileName(file)); // Add file names to ListBox
            }

            // Enable the start button if there are music files
            btnSart.Enabled = musicFiles.Count > 0;
        }

        private void LoadMusicFilesFromFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*.mp3"); // Load all MP3 files
                musicFiles.AddRange(files); // Add all music files to the list

                // Load corresponding images
                foreach (var file in files)
                {
                    string imagePath = Path.ChangeExtension(file, ".jpg"); // Adjust if necessary
                    if (File.Exists(imagePath))
                    {
                        musicImages[Path.GetFileName(file)] = Image.FromFile(imagePath); // Store image
                    }
                }
            }
            else
            {
                MessageBox.Show("Music folder not found.");
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
            if (!isPaused)
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
            // Optionally handle selection change
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index < 0) return;

            // Get the music file name
            string musicFileName = listBox1.Items[e.Index].ToString();

            // Draw the image if it exists
            if (musicImages.TryGetValue(musicFileName, out Image albumArt))
            {
                e.Graphics.DrawImage(albumArt, e.Bounds.X, e.Bounds.Y, 50, 50); // Draw image
            }

            // Draw the text next to the image
            e.Graphics.DrawString(musicFileName, e.Font, Brushes.Black, e.Bounds.X + 60, e.Bounds.Y);

            e.DrawFocusRectangle();
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
                // Update any playback information
            }
        }

        private void musicPlayer_Enter(object sender, EventArgs e)
        {
            // Handle player enter event if needed
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