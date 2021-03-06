using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopCRUDApp
{
    static class CustomerDb
    {
        /// <summary>
        /// Gets all of the customers in the database and returns them
        /// in a list.
        /// </summary>
        public static List<Customer> GetAllCustomers()
        {
            using(GuitarShopContext context = new GuitarShopContext())
            {
                List<Customer> allCustomers =
                (from c in context.Customers
                 orderby c.LastName
                 select c).ToList();
                return allCustomers;
            }
        }

        /// <summary>
        /// Adds a customer to the Customers table.
        /// </summary>
        /// <param name="c">The customer to add to the database</param>
        public static void Add(Customer c)
        {
            using(GuitarShopContext context = new GuitarShopContext())
            {
                context.Customers.Add(c);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates a customer's information in the database.
        /// </summary>
        /// <param name="c">The customer with the new information</param>
        public static void Update(Customer c)
        {
            using(var context = new GuitarShopContext())
            {
                //context.Database.Log = Console.WriteLine;

                context.Entry(c).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a customer's information from the database
        /// </summary>
        /// <param name="c"></param>
        public static void Delete(Customer c)
        {
            using(var context = new GuitarShopContext())
            {
                // get list of addresses and orders
                // related to given customer
                List<Address> addressesToUpdate =
                    (from a in context.Addresses
                     where a.CustomerID == c.CustomerID
                     select a).ToList();

                List<Order> ordersToUpdate =
                    (from o in context.Orders
                     where o.CustomerID == c.CustomerID
                     select o).ToList();

                // remove references to the CustomerID
                // being deleted (set them to null)
                foreach (Address a in addressesToUpdate)
                {
                    a.CustomerID = null;
                }

                foreach (Order o in ordersToUpdate)
                {
                    o.CustomerID = null;
                }

                // delete the customer
                context.Entry(c).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
