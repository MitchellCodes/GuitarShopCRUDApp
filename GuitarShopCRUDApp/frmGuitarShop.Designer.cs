
namespace GuitarShopCRUDApp
{
    partial class frmGuitarShop
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(200, 56);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(376, 33);
            this.cboCustomer.TabIndex = 2;
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(200, 125);
            this.cboProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(376, 33);
            this.cboProduct.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 199);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(196, 40);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(380, 199);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(196, 40);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(18, 271);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(196, 40);
            this.btnEditCustomer.TabIndex = 6;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(18, 340);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(196, 40);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // frmGuitarShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 418);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGuitarShop";
            this.Text = "Guitar Shop";
            this.Load += new System.EventHandler(this.GuitarShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}

