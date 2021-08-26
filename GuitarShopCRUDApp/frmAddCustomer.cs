﻿using System;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customerToAdd = new Customer();

            customerToAdd.EmailAddress = txtEmailAddress.Text;
            customerToAdd.Password = txtPassword.Text; // NEED TO REFACTOR AND NOT STORE AS PLAIN TEXT
            customerToAdd.FirstName = txtFirstName.Text;
            customerToAdd.LastName = txtLastName.Text;
        }

        /// <summary>
        /// Generates a random 128-bit salt
        /// </summary>
        private string GenerateSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }
    }
}
