namespace Midterm
{
    partial class Sale
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
            this.label1 = new System.Windows.Forms.Label();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lobster", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products For Sale";
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
            this.Column5});
            this.myDataGridView.Location = new System.Drawing.Point(12, 405);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.RowHeadersWidth = 51;
            this.myDataGridView.RowTemplate.Height = 64;
            this.myDataGridView.Size = new System.Drawing.Size(1262, 330);
            this.myDataGridView.TabIndex = 14;
            this.myDataGridView.SelectionChanged += new System.EventHandler(this.myDataGridView_SelectionChanged);
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
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 215;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 215;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product Image";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 265;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product List";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(1026, 78);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(197, 90);
            this.btnAddCart.TabIndex = 16;
            this.btnAddCart.Text = "Add Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(1005, 9);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(269, 55);
            this.btnViewCart.TabIndex = 17;
            this.btnViewCart.Text = "View Your Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // productImage
            // 
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Image = global::Midterm.Properties.Resources.images;
            this.productImage.Location = new System.Drawing.Point(709, 78);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(226, 264);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 26;
            this.productImage.TabStop = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(258, 297);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(376, 45);
            this.txtQty.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 38);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantity :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(258, 149);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(376, 45);
            this.txtProductName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 38);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Name :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(258, 222);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(376, 45);
            this.txtPrice.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Price :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(258, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(376, 45);
            this.txtID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID :";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1026, 252);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(197, 90);
            this.btnLogOut.TabIndex = 27;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 747);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Sale";
            this.Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut;
    }
}