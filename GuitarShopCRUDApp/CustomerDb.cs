using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopCRUDApp
{
    static class CustomerDb
    {
        public static List<Customer> GetAllCustomers()
        {
            GuitarShopContext context = new GuitarShopContext();

            // log queries to output
            //context.Database.Log = Console.WriteLine;

            List<Customer> allCustomers =
                (from c in context.Customers
                 orderby c.LastName
                 select c).ToList();
            return allCustomers;
        }
    }
}
