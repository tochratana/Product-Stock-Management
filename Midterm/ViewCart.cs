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
    public partial class ViewCart : Form
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

        double finalTotalDollor  = 0;        

        public ViewCart()
        {
            InitializeComponent();
        }
        public ViewCart(List<string> storeId, List<string> storeProductName, List<string> storePrice, List<string> storeQuantity, List<Image> storeImage , List<string> cartId , List<string> cartProductName , List<string> cartPrice , List<string> cartQuantity , List<Image> cartImage , List<string> cartTotal)
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

            for (int i = 0; i < cartId.Count; i++)
            {
                myDataGridView.Rows.Add(cartId[i], cartProductName[i], cartPrice[i], cartQuantity[i], cartImage[i], cartTotal[i]);
            }
        }        
        private void btnBuy_Click(object sender, EventArgs e)
        {
            double finalTotal = 0;
            double total = 0;
            string message = "";

            string paymentMethod = txtPayment.Text.Trim();
            double payment = Convert.ToDouble(paymentMethod);
            double change = 0;

            for (int i = 0; i < storeId.Count; i++)
            {
                if (i < cartProductName.Count && i < cartQuantity.Count && i < cartPrice.Count)
                {
                    if (cartProductName[i] == storeProductName[i])
                    {
                        int qty = Convert.ToInt32(cartQuantity[i]);
                        double price = Convert.ToDouble(cartPrice[i]);

                        int stock = Convert.ToInt32(storeQuantity[i]);

                        int cutStock = stock - qty;
                        storeQuantity[i] = cutStock.ToString();
                        total = price * qty;
                        message += $"{cartProductName[i]}({cartQuantity[i]}) : = ${total}\n";
                        finalTotal += total;
                    }
                }
            }
            if(payment > finalTotal)
            {
                MessageBox.Show($"{message}\nTotal = ${finalTotal}\nRecived ${paymentMethod} from customer.\nChange = ${ change = Convert.ToDouble(paymentMethod) - finalTotal}");               
                myDataGridView.Rows.Clear();
                TotalAllProductsDollor.Text = $"Change = ${change}";
                txtPayment.Clear();
            }
            else
            {
                MessageBox.Show("Not Enough Money To Buy");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sale(storeId, storeProductName, storePrice, storeQuantity, storeImage , cartId , cartProductName , cartPrice , cartQuantity , cartImage , cartTotal).Show();
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            if (myDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = myDataGridView.SelectedRows[0].Index;

                MessageBox.Show("Are you sure you want to remove item from cart?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                cartId.RemoveAt(rowIndex);
                cartProductName.RemoveAt(rowIndex);
                cartPrice.RemoveAt(rowIndex);
                cartQuantity.RemoveAt(rowIndex);
                cartImage.RemoveAt(rowIndex);
                cartTotal.RemoveAt(rowIndex);

                myDataGridView.Rows.RemoveAt(rowIndex);
                UpdateTotalLabel();
            }
            
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            double total = 0;
            for (int i = 0; i < cartTotal.Count; i++)
            {
                if (double.TryParse(cartTotal[i], out double itemTotal))
                {
                    total += itemTotal;
                }
            }
            TotalAllProductsDollor.Text = $"Total All Products In USD: ${total}";
        }
    }
}
