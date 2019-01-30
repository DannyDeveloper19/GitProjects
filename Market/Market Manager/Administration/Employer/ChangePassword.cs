using Market_Manager.DataConnection;
using Market_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Market_Manager.Administration.Employer
{
    public partial class ChangePassword : Market_Manager.Base
    {
        EmployerModel _employer;
        public ChangePassword(EmployerModel employer)
        {
            InitializeComponent();
            this._employer = employer;
        }

        public override void Save()
        {
            if (!Security.Validating.validateFields(this))
            {
                if (txtNewPassword.CompareWith(txtConfirmPassword.Text))
                {
                    try
                    {
                        var newpassword = Security.Security.Encrypt(txtNewPassword.Text.Trim());
                        bool answer = Employer_Data.ChangePassword(_employer.id_employer,txtCurentPassword.Text, newpassword);
                        if (!answer)
                        {
                            MessageBox.Show("The current password is wrong.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Password changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public override void Cancel()
        {
            this.Close();
        }
    }
}
