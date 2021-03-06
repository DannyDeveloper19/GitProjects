﻿using Market_Manager.Administration;
using Market_Manager.Administration.Warehouse;
using Market_Manager.Admission;
using Market_Manager.DataConnection;
using Market_Manager.Models;
using Market_Manager.Sales;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
        }
        public Manager_System(EmployerModel employer, Login frmlogin)
        {
            InitializeComponent();
            this.employer = employer;
            _frmLogin = frmlogin;
            tmrInactive.Start();
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.FormClosed += Manager_System_Close;
        }

        private void Manager_System_Close(object sender, FormClosedEventArgs e)
        {
            Employer_Data.LogOut(employer.id_employer, employer.id_logged);
            employer = new EmployerModel();
        }

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public static uint GetIdleTime()
        {
            LASTINPUTINFO lastInput = new LASTINPUTINFO();
            lastInput.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInput);
            GetLastInputInfo(ref lastInput);
            return ((uint)Environment.TickCount - lastInput.dwTime);
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

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesControl frmSControl = new SalesControl(employer)
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            frmSControl.Show();
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
            _frmLogin.Close();
            this.Close();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    /*Employer_Data.LogOut(employer.id_employer, employer.id_logged);
                    employer = new EmployerModel();*/
                    _frmLogin.Close();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" +ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to log out?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    /*Employer_Data.LogOut(employer.id_employer, employer.id_logged);
                    employer = new EmployerModel();*/
                    _frmLogin.Show();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }            
        }

        private void Manager_System_Load(object sender, EventArgs e)
        {
            switch (employer.employer_role)
            {
                case "employer":
                    tsmManager.Visible = false;
                    tsmReport.Visible = false;
                    break;
                
                default:
                    break;
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(this.employer);
            profile.StartPosition = FormStartPosition.CenterScreen;
            profile.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.MdiParent = this;
            newCustomer.StartPosition = FormStartPosition.CenterScreen;
            newCustomer.Show();
        }

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCustomer = new CustomerQuery();
            frmCustomer.MdiParent = this;
            frmCustomer.StartPosition = FormStartPosition.CenterScreen;
            frmCustomer.Show();
        }

        private void listEmployerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployerQuery employerQuery = new EmployerQuery();
            employerQuery.MdiParent = this;
            employerQuery.StartPosition = FormStartPosition.CenterScreen;
            employerQuery.Show();
        }

        private void newEmployerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmployer newEmployer = new NewEmployer();
            newEmployer.MdiParent = this;
            newEmployer.StartPosition = FormStartPosition.CenterScreen;
            newEmployer.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Item new_Item = new New_Item();
            new_Item.MdiParent = this;
            new_Item.StartPosition = FormStartPosition.CenterScreen;
            new_Item.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemQuery itemQuery = new ItemQuery();
            itemQuery.StartPosition = FormStartPosition.CenterScreen;
            itemQuery.MdiParent = this;
            itemQuery.Show();
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return frmReturn = new Return();
            frmReturn.MdiParent = this;
            frmReturn.StartPosition = FormStartPosition.CenterScreen;
            frmReturn.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing frmDetails = new Billing();
            frmDetails.MdiParent = this;
            frmDetails.StartPosition = FormStartPosition.CenterScreen;
            frmDetails.Show();
        }

        private void tmrInactive_Tick(object sender, EventArgs e)
        {
            if (GetIdleTime() >1000*5*60)
            {
                /*Employer_Data.LogOut(employer.id_employer, employer.id_logged);
                employer = new EmployerModel();*/
                _frmLogin.Show();
                this.Close();
            }
        }
    }
}
