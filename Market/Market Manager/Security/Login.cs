using System;
using System.Data;
using System.Windows.Forms;
using Connection;
using Market_Manager.DataConnection;
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
                var answer = Employer_Data.Login(txtIdNumber.Text.Trim(), txtPassword.Text.Trim());
                if (answer is Boolean)
                {
                    txtPassword.Text = "";
                    MessageBox.Show("Password incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    var employer = (answer is EmployerModel) ? answer : new EmployerModel();
                    Manager_System frmManager = new Manager_System((EmployerModel)employer, this);
                    this.Hide();
                    frmManager.Show();
                }
                
            }
            catch (Exception)
            {
                txtIdNumber.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Employer number wrong.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
