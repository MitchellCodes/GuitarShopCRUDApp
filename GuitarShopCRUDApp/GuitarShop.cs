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
    public partial class GuitarShop : Form
    {
        public GuitarShop()
        {
            InitializeComponent();
        }

        private void GuitarShop_Load(object sender, EventArgs e)
        {
            List<Product> allProducts = ProductDb.GetAllProducts();

            cboProduct.DataSource = allProducts;
            // without to string method: compiler gets the string reference of property
            cboProduct.DisplayMember = nameof(Product.ProductName);
        }
    }
}
