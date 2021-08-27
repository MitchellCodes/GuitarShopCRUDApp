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

            byte[] customerSalt = CustomerHelper.GenerateSalt();

            customerToAdd.Password = CustomerHelper.HashPassword(customerSalt, txtPassword.Text);
            customerToAdd.Salt = Convert.ToBase64String(customerSalt);

            CustomerDb.Add(customerToAdd);
            MessageBox.Show("Customer added"); // add a check to display appropriate message
            this.Close();
        }
    }
}
