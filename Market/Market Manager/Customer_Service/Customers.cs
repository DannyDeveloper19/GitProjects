using Market_Manager.Admission;
using Market_Manager.DataConnection;
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
    public partial class CustomerQuery : Base
    {
        SalesControl _sales;
        public CustomerQuery()
        {
            InitializeComponent();
        }
        public CustomerQuery(SalesControl sales)
        {
            this._sales = sales;
        }

        private void CustomerQuery_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Customer_Data.getAllCustomers())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvCustomers);

                    row.Cells[0].Value = item.id;
                    row.Cells[1].Value = item.name;
                    row.Cells[2].Value = item.lastname;
                    row.Cells[3].Value = item.address;
                    row.Cells[4].Value = item.phone;
                    row.Cells[5].Value = item.email;
                    row.Cells[6].Value = item.dni;
                    dgvCustomers.Rows.Add(row);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
