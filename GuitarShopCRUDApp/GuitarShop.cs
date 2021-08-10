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

            // pull all products out of the database: Query syntax
            List<Product> allProducts =
                (from product in context.Products // wrap with () to get list of products
                 orderby product.ProductName
                 select product).ToList();
        }
    }
}
