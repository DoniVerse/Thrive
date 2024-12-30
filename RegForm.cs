using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace thrive
{
    public partial class RegForm : Form
    {
      

        public RegForm()
        {
            InitializeComponent();
            
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void ButSign_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect user input
                string username = txtBxUsr.Text.Trim();
                string email = EmailTxtBx.Text.Trim();
                string password = txtBxPwd.Text.Trim();
                string confirmPassword = txtBxCpwd.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new user object
                User usr = new User
                {
                    UserName = username,
                    Email = email,
                    Password = password
                };

                // Attempt registration
                if (usr.Register())
                {
                    MessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to login form
                    this.Close();
                    LoginForm lgFr = new LoginForm();
                    lgFr.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

