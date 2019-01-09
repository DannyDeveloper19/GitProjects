using Connection;
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
    public partial class Profile : Form
    {
        EmployerModel _employer;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(EmployerModel employer)
        {
            InitializeComponent();
            this._employer = employer;
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
        }
    }
}
