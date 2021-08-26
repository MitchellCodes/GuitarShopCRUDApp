using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShopCRUDApp
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adds a new customer to the Customers table in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) // need validation
        {
            Customer customerToAdd = new Customer();

            customerToAdd.EmailAddress = txtEmailAddress.Text;
            customerToAdd.FirstName = txtFirstName.Text;
            customerToAdd.LastName = txtLastName.Text;

            byte[] customerSalt = GenerateSalt();

            customerToAdd.Password = HashPassword(customerSalt);
            customerToAdd.Salt = Convert.ToBase64String(customerSalt);

            CustomerDb.Add(customerToAdd);
            MessageBox.Show("Customer added"); // add a check to display appropriate message
            this.Close();
        }



        // BELOW ARE HELPER METHODS

        /// <summary>
        /// Generates a random 128-bit salt as a byte array containing
        /// a random sequence of nonzero values.
        /// </summary>
        private byte[] GenerateSalt()
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
        private string HashPassword(byte[] salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: txtPassword.Text,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 1000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
