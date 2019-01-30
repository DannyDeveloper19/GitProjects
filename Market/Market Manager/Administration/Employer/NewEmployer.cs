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

namespace Market_Manager.Administration
{
    public partial class NewEmployer : Base
    {
        public NewEmployer()
        {
            InitializeComponent();
            cmbRole.Items.Add("manager");
            cmbRole.Items.Add("employer");
            cmbRole.Items.Add("supervisor");
        }

        public override void Save()
        {
            if (!Security.Validating.validateFields(this))
            {
                try
                {
                    string id = "E"+new Random().Next(10000,99999).ToString();
                    string name = txtName.Text;
                    string lastname = txtLastname.Text;
                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;
                    string address = (txtApt.Text != "")? txtStreet.Text +" Apt#" +txtApt.Text + ", "+txtCity.Text +", "+cmbState.Text+", "+txtZipcode.Text : txtStreet.Text + ", " + txtCity.Text + ", " + cmbState.Text + ", " + txtZipcode.Text;
                    string role = cmbRole.Text;
                    string dln = txtDLN.Text;

                    EmployerModel employer = new EmployerModel(id, name, lastname, address, phone, email, dln, role);
                    Employer_Data.NewEmployer(employer);
                    MessageBox.Show("New employer added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: "+ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        public override void Cancel()
        {
            this.Close();
        }
    }
}
