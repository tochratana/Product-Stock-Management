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
    public partial class Sale : Form
    {
        List<string> storeId = new List<string>();
        List<string> storeProductName = new List<string>();
        List<string> storePrice = new List<string>();
        List<string> storeQuantity = new List<string>();
        List<Image> storeImage = new List<Image>();

        List<string> cartId = new List<string>();
        List<string> cartProductName = new List<string>();
        List<string> cartPrice = new List<string>();
        List<string> cartQuantity = new List<string>();
        List<Image> cartImage = new List<Image>();
        List<string> cartTotal = new List<string>();


        private void ClearProductFields()
        {
            txtID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            productImage.Image = Properties.Resources.images;
            txtQty.Focus();
        }

        public Sale()
        {
            InitializeComponent();
        }

        public Sale(List<string> storeId, List<string> storeProductName, List<string> storePrice, List<string> storeQuantity, List<Image> storeImage , List<string> cartId , List<string> cartProductName , List<string> cartPrice , List<string> cartQuantity , List<Image> cartImage , List<string> cartTotal)
        {
            InitializeComponent();

            this.storeId = storeId;
            this.storeProductName = storeProductName;
            this.storePrice = storePrice;
            this.storeQuantity = storeQuantity;
            this.storeImage = storeImage;

            this.cartId = cartId;
            this.cartProductName = cartProductName;
            this.cartPrice = cartPrice;
            this.cartQuantity = cartQuantity;
            this.cartImage = cartImage;
            this.cartTotal = cartTotal;

            for (int i = 0; i < storeId.Count; i++)
            {
                myDataGridView.Rows.Add(storeId[i], storeProductName[i], storePrice[i], storeQuantity[i], storeImage[i]);
            }
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Please select a product and enter quantity");
                return;
            }

            string id = txtID.Text.Trim();
            string name = txtProductName.Text.Trim();

            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            // Find the product in store inventory
            int storeIndex = storeId.IndexOf(id);
            if (storeIndex == -1)
            {
                MessageBox.Show("Product not found in inventory");
                return;
            }

            // Check stock availability
            if (!int.TryParse(storeQuantity[storeIndex], out int availableQty))
            {
                MessageBox.Show("Invalid stock quantity");
                return;
            }

            if (qty > availableQty)
            {
                MessageBox.Show($"Not enough stock. Only {availableQty} available.");
                return;
            }

            double price = Convert.ToDouble(txtPrice.Text);
            double total = price * qty;

            // Check if item already exists in cart
            int cartIndex = cartId.IndexOf(id);
            if (cartIndex != -1)
            {
                // Update existing cart item
                int currentCartQty = int.Parse(cartQuantity[cartIndex]);
                int newQty = currentCartQty + qty;

                if (newQty > availableQty)
                {
                    MessageBox.Show($"Cannot add more than available stock ({availableQty})");
                    return;
                }

                cartQuantity[cartIndex] = newQty.ToString();
                cartTotal[cartIndex] = (price * newQty).ToString();
            }
            else
            {
                // Add new item to cart
                cartId.Add(id);
                cartProductName.Add(name);
                cartPrice.Add(price.ToString());
                cartQuantity.Add(qty.ToString());
                cartImage.Add(productImage.Image);
                cartTotal.Add(total.ToString());
            }

            MessageBox.Show("Item added to cart successfully");
            ClearProductFields();
        }

        private void myDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (myDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = myDataGridView.SelectedRows[0].Index;

                txtID.Text = myDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();
                txtProductName.Text = myDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                txtPrice.Text = myDataGridView.Rows[selectedRowIndex].Cells[2].Value.ToString();
                txtQty.Text = "1";
                productImage.Image = (Image)myDataGridView.Rows[selectedRowIndex].Cells[4].Value;

                txtID.Enabled = false;
                txtProductName.Enabled = false;
                txtPrice.Enabled = false;
                productImage.Enabled = false;                
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewCart(storeId , storeProductName, storePrice, storeQuantity, storeImage, cartId, cartProductName, cartPrice, cartQuantity, cartImage,cartTotal).Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login(storeId, storeProductName, storePrice, storeQuantity, storeImage).Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
