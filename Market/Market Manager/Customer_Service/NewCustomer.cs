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
                string id = "MBR"+Security.Security.generateIdNumber();
                string dni = txtDLN.Text;
                string name = txtName.Text;
                string lastname = txtLastname.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;

                string address = (txtApt.Text != "") 
                    ? txtStreet.Text + ", Apt. "+ txtApt.Text + "" + txtCity.Text + ", " + cmbState.Text + ", " + txtZipCode.Text : txtStreet.Text + ", " + txtCity.Text + ", " + cmbState.Text + ", " + txtZipCode.Text;
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
