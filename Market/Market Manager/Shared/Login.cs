using System;
using System.Data;
using System.Windows.Forms;
using Connection;
using Market_Manager.Models;

namespace Market_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtIdNumber.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_query = string.Format("Select * from Employers where id_employer = '{0}'",txtIdNumber.Text.Trim());
                DataSet dataSet = Utilities.execute(sql_query);

                string password = dataSet.Tables[0].Rows[0]["employer_password"].ToString().Trim();
                if (password != txtPassword.Text.Trim())
                {
                    MessageBox.Show("Password incorrect");
                }
                else
                {
                    string id = dataSet.Tables[0].Rows[0]["id_employer"].ToString().Trim();
                    string name = dataSet.Tables[0].Rows[0]["employer_name"].ToString() + " " + dataSet.Tables[0].Rows[0]["employer_lastname"].ToString();
                    sql_query = string.Format("Select role_name from Roles inner join Employer_Role on Employer_Role.id_role = Roles.id_role where Employer_Role.id_employer = '{0}'",id);
                    dataSet = Utilities.execute(sql_query);
                    string role = dataSet.Tables[0].Rows[0]["role_name"].ToString();
                    var employer = new EmployerModel(id, name,role);
                    Manager_System frmManager = new Manager_System(employer, this);
                    this.Hide();
                    frmManager.Show();
                }
                
            }
            catch (Exception err)
            {

                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
