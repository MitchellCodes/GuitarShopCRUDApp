using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShopCRUDApp
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // show message box to confirm cancel
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to cancel?",
                    "Cancel Product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else 
            {
                Close();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // if boxes are null: do not add to database need validation.
            Product newProduct = new Product();
            newProduct.ProductCode = txtProductCode.Text;
            newProduct.ProductName = txtProductName.Text;
            newProduct.Description = txtDescription.Text;
            newProduct.ListPrice = Convert.ToDecimal(txtListPrice.Text);
            newProduct.DiscountPercent = Convert.ToDecimal(txtDiscPercent.Text);

            DialogResult result =
               MessageBox.Show(
                   $"Add {newProduct.ProductName}?",
                   "Add Product",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProductDb.Add(newProduct);
                MessageBox.Show($"{newProduct.ProductName} was successfully added!");
                // clear current box of data
            }
            else
            {
                return;
            }
        }
    }
}
