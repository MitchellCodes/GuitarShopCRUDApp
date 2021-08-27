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
        public frmEditCustomer(Customer c)
        {
            InitializeComponent();
            txtEmailAddress.Text = c.EmailAddress;
            txtFirstName.Text = c.FirstName;
            txtLastName.Text = c.LastName;
        }

        /// <summary>
        /// Updates the information of the customer that was passed into
        /// this form's constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
