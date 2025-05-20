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
            if (cartId.Count == 0)
            {
                MessageBox.Show("Cart is empty");
                return;
            }

            if (!double.TryParse(txtPayment.Text, out double payment) || payment <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount");
                return;
            }

            // Calculate total and update inventory
            double finalTotal = 0;
            StringBuilder receipt = new StringBuilder();

            // Format receipt header
            receipt.AppendLine("=== STORE RECEIPT ===".PadCenter(40));
            receipt.AppendLine($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm")}");
            receipt.AppendLine(new string('-', 40));
            receipt.AppendLine("ITEM".PadRight(20) + "QTY".PadLeft(5) + "PRICE".PadLeft(10) + "TOTAL".PadLeft(10));
            receipt.AppendLine(new string('-', 40));

            List<string> purchasedItems = new List<string>();

            foreach (DataGridViewRow row in myDataGridView.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                string id = row.Cells[0].Value.ToString();
                int storeIndex = storeId.IndexOf(id);

                if (storeIndex == -1)
                {
                    MessageBox.Show($"Product {id} not found in inventory");
                    return;
                }

                if (!double.TryParse(row.Cells[2].Value.ToString(), out double price) ||
                    !int.TryParse(row.Cells[3].Value.ToString(), out int qty))
                {
                    MessageBox.Show("Invalid price or quantity");
                    return;
                }

                double itemTotal = price * qty;
                finalTotal += itemTotal;

                // Format line items
                receipt.AppendLine(
                    row.Cells[1].Value.ToString().Truncate(18).PadRight(20) +
                    qty.ToString().PadLeft(5) +
                    price.ToString("C").PadLeft(10) +
                    itemTotal.ToString("C").PadLeft(10)
                );

                // Update inventory
                if (!int.TryParse(storeQuantity[storeIndex], out int currentStock))
                {
                    MessageBox.Show("Invalid stock quantity");
                    return;
                }

                if (qty > currentStock)
                {
                    MessageBox.Show($"Not enough stock for {row.Cells[1].Value}");
                    return;
                }

                storeQuantity[storeIndex] = (currentStock - qty).ToString();
                purchasedItems.Add(id);
            }

            // Process payment
            if (payment < finalTotal)
            {
                MessageBox.Show($"Insufficient payment. Total: {finalTotal:C}, Paid: {payment:C}");
                return;
            }

            double change = payment - finalTotal;

            // Format receipt footer
            receipt.AppendLine(new string('-', 40));
            receipt.AppendLine("SUBTOTAL:".PadLeft(35) + finalTotal.ToString("C").PadLeft(10));
            receipt.AppendLine("PAID:".PadLeft(35) + payment.ToString("C").PadLeft(10));
            receipt.AppendLine("CHANGE:".PadLeft(35) + change.ToString("C").PadLeft(10));
            receipt.AppendLine(new string('-', 40));
            receipt.AppendLine("THANK YOU FOR YOUR PURCHASE!".PadCenter(40));

            // Show receipt in new window
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.SetReceiptContent(receipt.ToString());
            receiptForm.ShowDialog();

            // Clear purchased items from cart
            foreach (string id in purchasedItems)
            {
                int index = cartId.IndexOf(id);
                if (index != -1)
                {
                    cartId.RemoveAt(index);
                    cartProductName.RemoveAt(index);
                    cartPrice.RemoveAt(index);
                    cartQuantity.RemoveAt(index);
                    cartImage.RemoveAt(index);
                    cartTotal.RemoveAt(index);
                }
            }

            // Refresh DataGridView
            myDataGridView.Rows.Clear();
            foreach (var item in cartId.Select((id, index) => new { id, index }))
            {
                myDataGridView.Rows.Add(
                    cartId[item.index],
                    cartProductName[item.index],
                    cartPrice[item.index],
                    cartQuantity[item.index],
                    cartImage[item.index],
                    cartTotal[item.index]
                );
            }

            UpdateTotalLabel();
            txtPayment.Clear();
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
