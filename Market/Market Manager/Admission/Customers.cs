using Market_Manager.Admission;
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
    public partial class CustomerQuery : Form
    {
        public CustomerQuery()
        {
            InitializeComponent();
        }

        private void CustomerQuery_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var customer = new CustomerModel();
            Customer frmCustomer = new Customer(customer);
            frmCustomer.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.ShowDialog();
        }
    }
}
