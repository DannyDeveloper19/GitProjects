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
            DataSet data = Utilities.execute(string.Format("Select * from Employers where id_employer = '{0}'", _employer.id_employer));
            txtId.Text = data.Tables[0].Rows[0]["id_employer"].ToString();
            txtName.Text = data.Tables[0].Rows[0]["employer_name"].ToString();
            txtLastname.Text = data.Tables[0].Rows[0]["employer_lastname"].ToString();
            txtPhone.Text = data.Tables[0].Rows[0]["employer_phone"].ToString();
            txtEmail.Text = data.Tables[0].Rows[0]["employer_email"].ToString();
            txtAddress.Text = data.Tables[0].Rows[0]["employer_address"].ToString();
            data = Utilities.execute(string.Format("Select role_name from Roles inner join Employer_Role on Employer_Role.id_role = Roles.id_role where Employer_Role.id_employer = '{0}'", _employer.id_employer));
            txtRole.Text = data.Tables[0].Rows[0]["role_name"].ToString();
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                MessageBox.Show("Your changes have been saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode("info");                
            }
        }

        private void btnCPassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.StartPosition = FormStartPosition.CenterScreen;
            changePassword.ShowDialog();
        }
    }
}
