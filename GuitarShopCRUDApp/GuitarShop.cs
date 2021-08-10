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
            // instance of database context class to talk to database
            GuitarShopContext context = new GuitarShopContext();

            // output console: check query execution
            context.Database.Log = Console.WriteLine;

            // pull all products out of the database: Query syntax
            List<Product> allProducts =
                (from product in context.Products // wrap with () to get list of products
                 orderby product.ProductName
                 select product).ToList();

            //// put into combo box
            //foreach (Product product in allProducts)
            //{
            //    // populate list in the combo box for products
            //    cboProduct.Items.Add(product);
            //}

            cboProduct.DataSource = allProducts;
            // without to string method: compiler gets the string reference of property
            cboProduct.DisplayMember = nameof(Product.ProductName); 
        }
    }
}
