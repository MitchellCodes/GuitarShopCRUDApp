using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static Product Add(Product p)
        {
            using (GuitarShopContext context = new GuitarShopContext())
            {
                context.Products.Add(p);
                context.SaveChanges();

                return p;
            }
        }

        public static Product Update(Product p)
        {
            using (var context = new GuitarShopContext())
            {
                context.Entry(p).State = EntityState.Modified;
                context.SaveChanges();

                return p;
            }
        }

        public static void Delete(Product p)
        {
            using (var context = new GuitarShopContext())
            {
                context.Entry(p).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}