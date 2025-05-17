using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Login : Form
    {
        List<string> storeId = new List<string>();
        List<string> storeProductName = new List<string>();
        List<string> storePrice = new List<string>();
        List<string> storeQuantity = new List<string>();
        List<Image> storeImage = new List<Image>();
        public Login()
        {
            InitializeComponent();
        }
        public Login(List<string> storeId , List<string> storeProductName, List<string> storePrice, List<string> storeQuantity, List<Image> storeImage)
        {
            InitializeComponent();

            this.storeId = storeId;
            this.storeProductName = storeProductName;
            this.storePrice = storePrice;
            this.storeQuantity = storeQuantity;
            this.storeImage = storeImage;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (userName == "admin" && password == "admin123")
            {
                lblMessage.Visible = false; // Hide error label
                this.Hide();
                new Admin(storeId, storeProductName, storePrice, storeQuantity, storeImage).Show();
            }
            else if (userName == "user" && password == "user123")
            {
                lblMessage.Visible = false; // Hide error label

                List<string> cartId = new List<string>();
                List<string> cartProductName = new List<string>();
                List<string> cartPrice = new List<string>();
                List<string> cartQuantity = new List<string>();
                List<Image> cartImage = new List<Image>();
                List<string> cartTotal = new List<string>();

                this.Hide();
                new Sale(storeId, storeProductName, storePrice, storeQuantity, storeImage,
                         cartId, cartProductName, cartPrice, cartQuantity, cartImage, cartTotal).Show();
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;

                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }


        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
