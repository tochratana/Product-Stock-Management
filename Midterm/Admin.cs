using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Admin : Form
    {
        List<string> storeId = new List<string>();
        List<string> storeProductName = new List<string>();
        List<string> storePrice = new List<string>();
        List<string> storeQuantity = new List<string>();
        List<Image> storeImage = new List<Image>();
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(List<string> storeId , List<string> storeProductName , List<string> storePrice , List<string> storeQuantity , List<Image> storeImage)
        {
            InitializeComponent();
            this.storeId = storeId;
            this.storeProductName = storeProductName;
            this.storePrice = storePrice;
            this.storeQuantity = storeQuantity;
            this.storeImage = storeImage;

            for(int i = 0; i < storeId.Count; i++)
            {
                myDataGridView.Rows.Add(storeId[i] ,  storeProductName[i] , storePrice[i] , storeQuantity[i] , storeImage[i]);
            }

        }


        //btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string price = txtPrice.Text.Trim();
            string quantity = txtQty.Text.Trim();
            Image im = productImage.Image;

            if(storeId.Contains(id))
            {
                MessageBox.Show("ID is already exist.");
                txtID.Focus();
                return;
                
            }
            else if(storeProductName.Contains(productName))
            {
                MessageBox.Show("Product Name is already exist.");
                txtProductName.Focus();
                return;
            }
            else
            {
                storeId.Add(id);
                storeProductName.Add(productName);
                storePrice.Add(price);
                storeQuantity.Add(quantity);
                storeImage.Add(im);
            }

            myDataGridView.Rows.Add(id , productName , price , quantity , im);

            txtID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            productImage.Image = Properties.Resources.images;

            txtID.Focus();
        }

        //btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(myDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = myDataGridView.SelectedRows[0].Index;

                MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                storeId.RemoveAt(rowIndex);
                storeProductName.RemoveAt(rowIndex);
                storePrice.RemoveAt(rowIndex);
                storeQuantity.RemoveAt(rowIndex);
                storeImage.RemoveAt(rowIndex);

                myDataGridView.Rows.RemoveAt(rowIndex);
            }
            txtID.Focus();
        }

        //btnEdit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Update";

                txtID.Enabled = false;

                if (myDataGridView.SelectedRows.Count > 0)
                {
                    int rowIndex = myDataGridView.SelectedRows[0].Index;

                    txtID.Text = myDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                    txtProductName.Text = myDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                    txtPrice.Text = myDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                    txtQty.Text = myDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
                    productImage.Image = (Image)myDataGridView.Rows[rowIndex].Cells[4].Value;

                }
            }
            else
            {
                btnEdit.Text = "Edit";
                txtID.Enabled = true;
                if (myDataGridView.SelectedRows.Count > 0)
                {
                    int rowIndex = myDataGridView.SelectedRows[0].Index;

                    storeId[rowIndex] = txtID.Text.Trim();
                    storeProductName[rowIndex] = txtProductName.Text.Trim();
                    storePrice[rowIndex] = txtPrice.Text.Trim();
                    storeQuantity[rowIndex] = txtQty.Text.Trim();
                    storeImage[rowIndex] = productImage.Image;

                    myDataGridView.Rows[rowIndex].Cells[0].Value = txtID.Text.Trim();
                    myDataGridView.Rows[rowIndex].Cells[1].Value = txtProductName.Text.Trim();
                    myDataGridView.Rows[rowIndex].Cells[2].Value = txtPrice.Text.Trim();
                    myDataGridView.Rows[rowIndex].Cells[3].Value = txtQty.Text.Trim();
                    myDataGridView.Rows[rowIndex].Cells[4].Value = productImage.Image;

                    txtID.Clear();
                    txtProductName.Clear();
                    txtPrice.Clear();
                    txtQty.Clear();
                    productImage.Image = Properties.Resources.images;
                }  
                txtID.Focus();
            }
        }
            
        //ProductImage 
        private void productImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult result = of.ShowDialog();
            if(result == DialogResult.OK)
            {
                Image im = Image.FromFile(of.FileName);
                productImage.Image = im;
            }
        }

        //KeyDownEvent Event
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrice.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out Success.");
            this.Hide();
            new Login(storeId , storeProductName , storePrice , storeQuantity , storeImage).Show();
        }
    }
}
