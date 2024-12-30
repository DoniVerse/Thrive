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
            db = new DBConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ButLog_Click(object sender, EventArgs e)
        {
            //RegForm reg= new RegForm();
            //reg.Show();
            //string v = db.TestConnection();
            //string message = v;// Call the TestConnection method
            //MessageBox.Show(message, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //try
            //{
            //    User user = new User
            //    {
            //        UserName = UsrTxtBx.Text.Trim(),
            //        Password = PwdTxtBx.Text.Trim()
            //    };

            //    if (user.Login())
            //    {
            //        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        // Redirect to dashboard form
            //        this.Hide();
            //        DashFr dashboardForm = new DashFr();
            //        dashboardForm.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}