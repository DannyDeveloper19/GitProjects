using Market_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Manager
{
    public partial class Customer : Base
    {
        CustomerModel _customer;
       public Customer(CustomerModel customer)
        {
            InitializeComponent();
            this._customer = customer;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCustQuery = new CustomerQuery();
            frmCustQuery.ShowDialog();
        }
    }
}
