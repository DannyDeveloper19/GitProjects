using Market_Manager.DataConnection;
using Market_Manager.Models;
using Market_Manager.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            ptPicture.Tag = false;
        }

        public override void Save()
        {
            if (!Security.Validating.validateFields(this))
            {
                try
                {
                    string id = "E"+new Random().Next(10000,99999).ToString();
                    string name = txtName.Text.Trim();
                    string lastname = txtLastname.Text.Trim();
                    string phone = txtPhone.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string address = (txtApt.Text != "")? txtStreet.Text.Trim() + " Apt#" +txtApt.Text.Trim() + ", "+txtCity.Text.Trim() + ", "+cmbState.Text.Trim() + ", "+txtZipcode.Text.Trim() : txtStreet.Text.Trim() + ", " + txtCity.Text.Trim() + ", " + cmbState.Text.Trim() + ", " + txtZipcode.Text.Trim();
                    string role = cmbRole.Text.Trim();
                    string dln = txtDLN.Text.Trim();
                    byte[] picture = null;
                    if ((bool)ptPicture.Tag == true)
                    {
                        MemoryStream stream = new MemoryStream();
                        ptPicture.BackgroundImage.Save(stream,ImageFormat.Jpeg);
                        picture = stream.ToArray();

                    }

                    EmployerModel employer = (picture != null )? new EmployerModel(id, name, lastname, address, phone, email, dln, role,"",picture) : new EmployerModel(id, name, lastname, address, phone, email, dln, role);
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ptPicture.BackgroundImage = Image.FromFile(base.UploadPicture());
            ptPicture.BackgroundImageLayout = ImageLayout.Stretch;
            ptPicture.Tag = true;
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
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
