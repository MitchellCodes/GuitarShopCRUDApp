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
    public partial class frmEditCustomer : Form
    {
        private Customer CurrentCustomer { get; set; }

        public frmEditCustomer(Customer c)
        {
            InitializeComponent();
            CurrentCustomer = c;
            txtEmailAddress.Text = CurrentCustomer.EmailAddress;
            txtFirstName.Text = CurrentCustomer.FirstName;
            txtLastName.Text = CurrentCustomer.LastName;
        }

        /// <summary>
        /// Updates the information of the customer that was passed into
        /// this form's constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            Customer updatedCustomer = CurrentCustomer;
            updatedCustomer.EmailAddress = txtEmailAddress.Text;
            updatedCustomer.FirstName = txtFirstName.Text;
            updatedCustomer.LastName = txtLastName.Text;

            // update password if textbox is not empty
            if (txtPassword.Text != "")
            {
                byte[] salt = CustomerHelper.GenerateSalt();
                updatedCustomer.Password = CustomerHelper.HashPassword(salt, txtPassword.Text);
                updatedCustomer.Salt = Convert.ToBase64String(salt);
            }

            CustomerDb.Update(updatedCustomer);
        }

        /// <summary>
        /// Closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
