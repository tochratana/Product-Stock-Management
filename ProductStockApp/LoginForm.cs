using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStockApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        // login
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                // Admin login
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "user" && password == "user123")
            {
                // User login
                UserBuyForm userForm = new UserBuyForm();
                userForm.Show();
                this.Hide();
            }
            else
            {
                lblStatus.Text = "Invalid username or password.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
