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
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
