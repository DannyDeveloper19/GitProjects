using Connection;
using Market_Manager.Administration.Employer;
using Market_Manager.Models;
using Market_Manager.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            txtDLN.Text = _employer.employer_dln;
            if (_employer.picture != null)
            {
                MemoryStream ms = new MemoryStream(_employer.picture);
                ptPicture.BackgroundImage = Image.FromStream(ms);
            }
            Mode("info");
            
        }
        private void Mode( string mode)
        {
            switch (mode)
            {
                case "edit":
                    this.mode = mode;
                    btnCamera.Visible = true;
                    btnUpload.Visible = true;
                    btnAccept.Enabled = true;
                    btnEProfile.Text = "Cancel Edit";
                    groupBox2.Location = new Point(38, 245);
                    foreach (Button item in this.Controls.OfType<Button>())
                    {
                        item.Location = new Point(item.Location.X, item.Location.Y + 27);
                    }
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
                    btnCamera.Visible = false;
                    btnUpload.Visible = false;
                    btnAccept.Enabled = false;
                    if (ptPicture.Tag is bool == true) ptPicture.BackgroundImage = null;
                    btnEProfile.Text = "Edit Profile";
                    groupBox2.Location = new Point(38, 218);
                    foreach (Button item in this.Controls.OfType<Button>())
                    {
                        item.Location = new Point(item.Location.X,item.Location.Y - 27);
                    }
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
            if (mode == "info")
            {
                Mode("edit");
            }
            else Mode("info");
            
            
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ptPicture.BackgroundImage = Image.FromFile(base.UploadPicture());
            ptPicture.BackgroundImageLayout = ImageLayout.Stretch;
            ptPicture.Tag = true;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            CapturePicture capture = new CapturePicture();
            capture.pictureCaptured = new CapturePicture.GetPictureCaptured(PictureCaptureEventHandler);
            capture.StartPosition = FormStartPosition.CenterScreen;
            capture.ShowDialog();
        }

        private void PictureCaptureEventHandler(object sender)
        {
            try
            {
                ptPicture.BackgroundImage = (Image)sender;
                ptPicture.Tag = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
