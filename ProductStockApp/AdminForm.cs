using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStockApp
{
    public partial class AdminForm : Form
    {
        private List<Product> products = new List<Product>();

        public AdminForm()
        {
            InitializeComponent();
        }

        // Admin Control
        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            RefreshGrid();

        }

        private void RefreshGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
            dgvProducts.Columns["PicturePath"].HeaderText = "Image Path";

            // Optional: hide PicturePath if you don't want to show it
            // dgvProducts.Columns["PicturePath"].Visible = false;
        }


        

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult result = of.ShowDialog();
            if(result == DialogResult.OK)
            {
                Image im = Image.FromFile(of.FileName);
                pbProductImage.Image = im;
            }
        }

        // Clear field
        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            pbProductImage.Image = null;
            pbProductImage.Tag = null;
        }

        // Add product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                if (products.Any(p => p.Id == id))
                {
                    MessageBox.Show("Product ID already exists.");
                    return;
                }

                products.Add(new Product
                {
                    Id = id,
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Qty = int.Parse(txtQty.Text),
                    PicturePath = pbProductImage.Tag?.ToString()
                });

                RefreshGrid();
                ClearFields();
            }
            catch
            {
                MessageBox.Show("Please fill all fields correctly.");
            }
        }

        // Update Product
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            try
            {
                int id = int.Parse(txtId.Text);
                Product product = products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    product.Name = txtName.Text;
                    product.Price = decimal.Parse(txtPrice.Text);
                    product.Qty = int.Parse(txtQty.Text);
                    product.PicturePath = pbProductImage.Tag?.ToString();

                    RefreshGrid();
                    ClearFields();
                }
            }
            catch
            {
                MessageBox.Show("Update failed. Check inputs.");
            }
        }

        // Delete Product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
            products.RemoveAll(p => p.Id == id);
            RefreshGrid();
            ClearFields();
        }

        // This method is not use
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            txtId.Text = dgvProducts.CurrentRow.Cells["Id"].Value.ToString();
            txtName.Text = dgvProducts.CurrentRow.Cells["Name"].Value.ToString();
            txtPrice.Text = dgvProducts.CurrentRow.Cells["Price"].Value.ToString();
            txtQty.Text = dgvProducts.CurrentRow.Cells["Qty"].Value.ToString();

            string imagePath = dgvProducts.CurrentRow.Cells["PicturePath"].Value?.ToString();
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pbProductImage.Image = Image.FromFile(imagePath);
                pbProductImage.Tag = imagePath;
            }
            else
            {
                pbProductImage.Image = null;
                pbProductImage.Tag = null;
            }

            //if(!string.IsNullOrEmpty(imagePath) &&File
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
