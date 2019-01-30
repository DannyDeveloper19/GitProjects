using Connection;
using Market_Manager.Administration.Employer;
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
    public partial class Profile : Base
    {
        EmployerModel _employer;
        string mode = "";
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(EmployerModel employer)
        {
            InitializeComponent();
            this._employer = employer;
            btnStatement.Enabled = false;
            btnBenefits.Enabled = false;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txtId.Text = _employer.id_employer;
            txtName.Text = _employer.employer_name;
            txtLastname.Text = _employer.employer_lastname;
            txtPhone.Text = _employer.employer_phone;
            txtEmail.Text = _employer.employer_email;
            txtAddress.Text = _employer.employer_address;
            txtRole.Text = _employer.employer_role;
            Mode("info");
            
        }
        private void Mode( string mode)
        {
            switch (mode)
            {
                case "edit":
                    this.mode = mode;
                    foreach (var item in this.Controls.OfType<TextBox>())
                    {
                        if (item.Name != "txtId")
                        {
                            item.BackColor = this.BackColor;
                            item.ReadOnly = false;
                        }

                    }
                    foreach (var item in groupBox2.Controls.OfType<TextBox>())
                    {
                        item.BackColor = this.BackColor;
                        item.ReadOnly = false;
                    }
                    this.Text = "Edit Information";
                    break;
                default:
                    this.mode = mode;
                    foreach (var item in this.Controls.OfType<TextBox>())
                    {
                        item.ReadOnly = true;
                        item.BackColor = Color.Silver;
                    }

                    foreach (var item in groupBox2.Controls.OfType<TextBox>())
                    {
                        item.ReadOnly = true;
                        item.BackColor = Color.Silver;
                    }
                    
                    this.Text = "Employer Information";
                    break;
            }
        }
        private void btnEProfile_Click(object sender, EventArgs e)
        {
            Mode("edit");
            
        }
        public override void Save()
        {
            if (mode == "edit")
            {
                MessageBox.Show("Your changes have been saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode("info");
            }
        }

        public override void Cancel()
        {
            this.Close();
        }

        private void btnCPassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(_employer);
            changePassword.StartPosition = FormStartPosition.CenterScreen;
            changePassword.ShowDialog();
        }
    }
}
