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
    public partial class frmGuitarShop : Form
    {
        public frmGuitarShop()
        {
            InitializeComponent();
        }

        private void GuitarShop_Load(object sender, EventArgs e)
        {
            List<Product> allProducts = ProductDb.GetAllProducts();

            cboProduct.DataSource = allProducts;
            // without to string method: compiler gets the string reference of property
            cboProduct.DisplayMember = nameof(Product.ProductName);


            // get all customers from database
            List<Customer> allCustomers = CustomerDb.GetAllCustomers();
            // display all customers in the customer combo box on frmGuitarShop
            cboCustomer.DataSource = allCustomers;
            cboCustomer.DisplayMember = nameof(Customer.FullCustomerName);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // create instance of frmAddProduct
            frmAddProduct addForm = new frmAddProduct();
            addForm.ShowDialog();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            // create instance of frmAddCustomer and show it
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            addCustomerForm.ShowDialog();
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            // create an instance of frmEditCustomer, pass in the
            // selected customer, and show the form
            Customer currentCustomer = (Customer)cboCustomer.SelectedItem;
            frmEditCustomer editCustomerForm = new frmEditCustomer(currentCustomer);
            editCustomerForm.ShowDialog();
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // ask the user if they want to delete the selected customer
            // and if they confirm then delete them from database
            Customer currCustomer = (Customer)cboCustomer.SelectedItem;

            DialogResult result = MessageBox.Show(
                            text: $"Are you sure you want to delete {currCustomer.FirstName} {currCustomer.LastName}?",
                            caption: "Delete Customer Confirmation",
                            buttons: MessageBoxButtons.YesNo,
                            icon: MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CustomerDb.Delete(currCustomer);
                MessageBox.Show("Customer deleted"); // add a check to display appropriate message
            }
        }
    }
}
