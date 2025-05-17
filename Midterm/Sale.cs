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
            string name = txtProductName.Text.Trim();
            int qty = Convert.ToInt32(txtQty.Text.Trim());

            double price = Convert.ToDouble(txtPrice.Text.Trim());
            double total = 0;
            for (int i = 0; i < storeId.Count; i++)
            {
                if(name == storeProductName[i])
                {
                    if (qty > Convert.ToInt32(storeQuantity[i]))
                    {
                        MessageBox.Show("Not enough quantity in stock.");
                        txtQty.Focus();
                        return;
                    }
                    else
                    {
                        total = price * qty;

                        if (cartId.Count > 0)
                        {
                            for (int j = 0; j < cartId.Count; j++)
                            {
                                if (txtID.Text.Trim() == cartId[j])
                                {
                                    if (Convert.ToInt32(cartQuantity[j]) + qty > Convert.ToInt32(storeQuantity[i]))
                                    {
                                        MessageBox.Show("Not enough quantity in stock.");
                                        txtQty.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        int cartQty = Convert.ToInt32(cartQuantity[j]);
                                        int newQty = cartQty + qty;                                        
                                        total = price * newQty;
                                        cartQuantity[j] = newQty.ToString();
                                        cartTotal[j] = total.ToString();
                                        if (myDataGridView.SelectedRows.Count > 0)
                                        {
                                            int selectedRowIndex = myDataGridView.SelectedRows[0].Index;

                                            cartId[selectedRowIndex] = txtID.Text.Trim();
                                            cartProductName[selectedRowIndex] = txtProductName.Text.Trim();
                                            cartPrice[selectedRowIndex] = txtPrice.Text.Trim();
                                            cartQuantity[selectedRowIndex] = newQty.ToString();
                                            cartImage[selectedRowIndex] = productImage.Image;
                                            cartTotal[selectedRowIndex] = total.ToString();
                                        }
                                        MessageBox.Show("Item Add to Cart Success.");
                                        txtID.Clear();
                                        txtProductName.Clear();
                                        txtPrice.Clear();
                                        txtQty.Clear();
                                        productImage.Image = Properties.Resources.images;
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            cartId.Add(txtID.Text.Trim());
            cartProductName.Add(txtProductName.Text.Trim());
            cartPrice.Add(txtPrice.Text.Trim());
            cartQuantity.Add(txtQty.Text.Trim());
            cartImage.Add(productImage.Image);
            cartTotal.Add(total.ToString());
            MessageBox.Show("Item Add to Cart Success.");

            txtID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            productImage.Image = Properties.Resources.images;
            return;
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
    }
}
