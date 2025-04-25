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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
            //db = new DBConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ButLog_Click(object sender, EventArgs e)
        {


            string username = UsrTxtBx.Text.Trim();
            string email = EmailTxtBx.Text.Trim();
            string? password = PwdTxtBx.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Userid cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assuming you fetch the UserId based on the username or email
            User usr = new User
            {
                UserName = username,
                Email = email,
                Password = password
            };

            // Simulate fetching the UserId from the database
            User.UserId = int.Parse(username); // This should be retrieved from your user management logic
            bool succ = usr.login(User.UserId, password);

            if (succ)
            {
                DashFr dashboard = new DashFr(); // Open dashboard form
                dashboard.Show();
                this.Hide();
                // Hide the login form
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void SignLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //RegForm rg = new RegForm();
            //rg.Show();
            //this.Close();

        }

        private void UsrLbl_Click(object sender, EventArgs e)
        {

        }

        private void RegLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm rg = new RegForm();
            rg.FormClosed += (s, args) => this.Show();
            rg.Show();
            this.Hide();
        }
    }
}