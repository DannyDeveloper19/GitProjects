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
            if (!Security.Validating.validateFields(this))
            {
                try
                {
                    string id = "MBR" + Security.Security.generateIdNumber();
                    string dni = txtDLN.Text.Trim();
                    string name = txtName.Text.Trim();
                    string lastname = txtLastname.Text.Trim();
                    string phone = txtPhone.Text.Trim();
                    string email = txtEmail.Text.Trim();

                    string address = (txtApt.Text != "")
                        ? txtStreet.Text.Trim() + ", Apt# " + txtApt.Text.Trim() + ", " + txtCity.Text.Trim() + ", " + cmbState.Text.Trim() + ", " + txtZipcode.Text.Trim() : txtStreet.Text.Trim() + ", " + txtCity.Text.Trim() + ", " + cmbState.Text.Trim() + ", " + txtZipcode.Text.Trim();
                    var newCustomer = new CustomerModel(id, name, lastname, phone, address, email, dni);
                    Customer_Data.newCustomer(newCustomer);

                    MessageBox.Show("New Customer added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("There were an error trying to add this user", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Cancel()
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text);
            txtName.SelectionStart = txtName.Text.Length;
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            txtLastname.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastname.Text);
            txtLastname.SelectionStart = txtLastname.Text.Length;
        }
    }
}
