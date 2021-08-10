using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopCRUDApp
{
    static class ProductDb
    {
        public static List<Product> GetAllProducts()
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
            return allProducts;
        }
    }
}
