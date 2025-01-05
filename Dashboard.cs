using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrive
{
    public partial class DashFr : Form
    {
       
        public DashFr()
        {
            InitializeComponent();
            
        }

        private void DashPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moodlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoodForm md = new MoodForm();
            md.FormClosed += (s, args) => this.Show();
            md.Show();
            this.Hide();
           
        }

        private void Journallb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Journal jr= new Journal();
            jr.Show();
            this.Hide();
           
        }
    }
}
