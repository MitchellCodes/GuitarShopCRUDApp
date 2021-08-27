using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            GuitarShopContext context = new GuitarShopContext();

            // log queries to output
            //context.Database.Log = Console.WriteLine;

            List<Customer> allCustomers =
                (from c in context.Customers
                 orderby c.LastName
                 select c).ToList();
            return allCustomers;
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
        /// Generates a random 128-bit salt as a byte array containing
        /// a random sequence of nonzero values.
        /// </summary>
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }
            return salt;
        }

        /// <summary>
        /// Salts and hashes the user's password using SHA256 hashing to store in the database.
        /// </summary>
        /// <param name="salt">The customer's salt</param>
        /// <param name="password">The plain-text of the password entered by the user</param>
        /// <returns></returns>
        public static string HashPassword(byte[] salt, string password)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 1000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
