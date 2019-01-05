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
    public partial class SalesControl : Form
    {
        public SalesControl()
        {
            InitializeComponent();
            txtCount.Text = "0";
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ItemQuery frmIQuery = new ItemQuery();
            frmIQuery.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCQuery = new CustomerQuery();
            frmCQuery.ShowDialog();
        }
    }
}
