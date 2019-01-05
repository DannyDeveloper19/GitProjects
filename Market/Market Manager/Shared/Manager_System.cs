using Market_Manager.Administration;
using Market_Manager.Models;
using System;
using System.Windows.Forms;

namespace Market_Manager
{
    public partial class Manager_System : Form
    {
        private int childFormNumber = 0;
        EmployerModel employer;
        Login _frmLogin;
        public Manager_System()
        {
            InitializeComponent();
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.ControlBox = false;
           
        }
        public Manager_System(EmployerModel employer, Login frmlogin)
        {
            InitializeComponent();
            this.employer = employer;
            _frmLogin = frmlogin;
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.ControlBox = false;
            MessageBox.Show(this.employer.employer_role + " "+ this.employer.employer_name);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCustomer = new CustomerQuery();
            frmCustomer.MdiParent = this;
            frmCustomer.StartPosition = FormStartPosition.CenterScreen;
            frmCustomer.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesControl frmSControl = new SalesControl();
            frmSControl.MdiParent = this;
            frmSControl.StartPosition = FormStartPosition.CenterScreen;
            frmSControl.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCQuery = new CustomerQuery();
            frmCQuery.MdiParent = this;
            frmCQuery.StartPosition = FormStartPosition.CenterScreen;
            frmCQuery.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemQuery frmIQuery = new ItemQuery();
            frmIQuery.MdiParent = this;
            frmIQuery.StartPosition = FormStartPosition.CenterScreen;
            frmIQuery.Show();
        }

        private void closeToolStripButton1_Click(object sender, EventArgs e)
        {
            employer = new EmployerModel();
            _frmLogin.Close();
            this.Close();
        }
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employer = new EmployerModel();
            _frmLogin.Close();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employer = new EmployerModel();
            _frmLogin.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployerQuery employerQuery = new EmployerQuery();
            employerQuery.StartPosition = FormStartPosition.CenterScreen;
            employerQuery.Show();
        }

        private void Manager_System_Load(object sender, EventArgs e)
        {
            switch (employer.employer_role)
            {
                case "employer":
                    toolStrip.Hide();
                    tsmManager.Enabled = false;
                    tsmReport.Enabled = false;
                    tsmQuery.Enabled = false;
                    break;
                
                default:
                    break;
            }
        }
    }
}
