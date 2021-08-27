﻿using System;
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

        public static void Update(Customer c)
        {
            using(var context = new GuitarShopContext())
            {
                //context.Database.Log = Console.WriteLine;

                context.Entry(c).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
