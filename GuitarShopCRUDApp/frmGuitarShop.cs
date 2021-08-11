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


            List<Customer> allCustomers = CustomerDb.GetAllCustomers();

            cboCustomer.DataSource = allCustomers;
            cboCustomer.DisplayMember = nameof(Customer.FullCustomerName);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // create instance of frmAddProduct
            frmAddProduct addForm = new frmAddProduct();
            addForm.ShowDialog();
        }
    }
}
