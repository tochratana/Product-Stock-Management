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
    public partial class ReceiptForm : Form
    {

        // Add this constant for base font size
        private const int BaseFontSize = 18; // You can adjust this number

        public ReceiptForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(620, 500); // Larger window size
        }

        public void SetReceiptContent(string receiptText)
        {
            // Set larger font with bold for better readability
            rtbReceipt.Font = new Font("Consolas", BaseFontSize, FontStyle.Bold);
            rtbReceipt.Text = receiptText;

            // Optional: Make the header even bigger
            int headerEnd = receiptText.IndexOf("\n", receiptText.IndexOf("\n") + 1);
            if (headerEnd > 0)
            {
                rtbReceipt.Select(0, headerEnd);
                rtbReceipt.SelectionFont = new Font("Consolas", BaseFontSize + 4, FontStyle.Bold);
            }
        }

        // close 
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}