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

        private List<string> soundtracks = new List<string>();
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        public SoundTrack()
        {
            InitializeComponent();
        }
        private void PlaySoundtrack(string filePath)
        {
            // Stop any currently playing audio
            waveOut?.Stop();
            waveOut?.Dispose();
            audioFileReader?.Dispose();

            // Play the selected soundtrack
            waveOut = new WaveOut();
            audioFileReader = new AudioFileReader(filePath);
            waveOut.Init(audioFileReader);
            waveOut.Play();
        }
        private void SoundTrack_Load(object sender, EventArgs e)
        {
           
        }

        private void rainlabel_Click(object sender, EventArgs e)
        {
             PlaySoundtrack("path_to_rain_fall.mp3");

        }
    }
}
