namespace Midterm
{
    partial class ViewCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemoveCart = new System.Windows.Forms.Button();
            this.TotalAllProductsDollor = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView
            // 
            this.myDataGridView.AllowUserToAddRows = false;
            this.myDataGridView.AllowUserToDeleteRows = false;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.myDataGridView.Location = new System.Drawing.Point(12, 67);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.RowHeadersWidth = 51;
            this.myDataGridView.RowTemplate.Height = 64;
            this.myDataGridView.Size = new System.Drawing.Size(1262, 355);
            this.myDataGridView.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 190;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product Image";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 253;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(170, 645);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(197, 90);
            this.btnBuy.TabIndex = 17;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lobster", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "View Cart";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(845, 645);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(212, 90);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back to Sale";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveCart
            // 
            this.btnRemoveCart.Location = new System.Drawing.Point(483, 645);
            this.btnRemoveCart.Name = "btnRemoveCart";
            this.btnRemoveCart.Size = new System.Drawing.Size(233, 90);
            this.btnRemoveCart.TabIndex = 20;
            this.btnRemoveCart.Text = "Remove Item";
            this.btnRemoveCart.UseVisualStyleBackColor = true;
            this.btnRemoveCart.Click += new System.EventHandler(this.btnRemoveCart_Click);
            // 
            // TotalAllProductsDollor
            // 
            this.TotalAllProductsDollor.AutoSize = true;
            this.TotalAllProductsDollor.Location = new System.Drawing.Point(12, 441);
            this.TotalAllProductsDollor.Name = "TotalAllProductsDollor";
            this.TotalAllProductsDollor.Size = new System.Drawing.Size(274, 38);
            this.TotalAllProductsDollor.TabIndex = 21;
            this.TotalAllProductsDollor.Text = "Total All Product :";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Location = new System.Drawing.Point(728, 441);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(164, 38);
            this.payment.TabIndex = 22;
            this.payment.Text = "Payment :";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(898, 434);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(376, 45);
            this.txtPayment.TabIndex = 23;
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 747);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.TotalAllProductsDollor);
            this.Controls.Add(this.btnRemoveCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.myDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ViewCart";
            this.Text = "ViewCart";
            this.Load += new System.EventHandler(this.ViewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemoveCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label TotalAllProductsDollor;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.TextBox txtPayment;
    }
}