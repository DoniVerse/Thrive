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
        //protected override void OnFormClosed(FormClosedEventArgs e)
        //{
        //    base.OnFormClosed(e);
        //    LoginForm lg = new LoginForm();
        //    lg.Show();
        //    this.Close();
        //}
        private void DashPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moodlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoodForm md = new MoodForm();
            //md.FormClosed += (s, args) => this.Show();
            md.Show();
            this.Close();


        }

        private void Journallb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            NotePad note = new NotePad();

            note.Show();
            this.Close();
            //note.FormClosed+= (s, args) => this.Show();



            //Journal jr = new Journal();
            //jr.FormClosed += (s, args) => this.Show();  
            //jr.Show();
            //this.Hide();

        }

        private void Excericselb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Exercise ex = new Exercise();

            ex.Show();
            this.Close();
        }

        private void soundlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SoundTrack sd = new SoundTrack();

            sd.Show();
            this.Close();



        }

        private void LogoutLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User us = new User();
            us.Logout();
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void DashFr_Load(object sender, EventArgs e)
        {
            //User us = new User();
            //us.Logout();
            //this.Close();
            //LoginForm lg = new LoginForm();
            //lg.Show();

        }
    }
}
