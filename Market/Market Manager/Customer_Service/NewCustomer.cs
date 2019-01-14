using Market_Manager.DataConnection;
using Market_Manager.Models;
using System;
using System.Windows.Forms;

namespace Market_Manager.Admission
{
    public partial class NewCustomer : Base
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        public override void Save()
        {
            try
            {
                string id = "MBR"+Security.Security.generateIdNumber().Trim();
                string dni = txtDLN.Text.Trim();
                string name = txtName.Text.Trim();
                string lastname = txtLastname.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();

                string address = (txtApt.Text != "") 
                    ? txtStreet.Text.Trim() + ", Apt. "+ txtApt.Text.Trim() + ", " + txtCity.Text.Trim() + ", " + cmbState.Text.Trim() + ", " + txtZipCode.Text.Trim() : txtStreet.Text.Trim() + ", " + txtCity.Text.Trim() + ", " + cmbState.Text.Trim() + ", " + txtZipCode.Text.Trim();
                var newCustomer = new CustomerModel(id, name, lastname, phone, address, email, dni);
                Customer_Data.newCustomer(newCustomer);

                MessageBox.Show("New Customer added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                MessageBox.Show("There were an error trying to add this user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
