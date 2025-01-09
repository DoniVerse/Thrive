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
    public partial class Mymp3player : Form
    {
        private mp3player mp3player = new mp3player();
        public Mymp3player()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3player.open(ofd.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp3player.play();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mp3player.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
