using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Manager.Shared
{
    public partial class CapturePicture : Form
    {
        public CapturePicture()
        {
            InitializeComponent();
        }

        public delegate void GetPictureCaptured(object sender);
        public GetPictureCaptured pictureCaptured;

        private void CapturePicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraControl1.Stop_Camera();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cameraControl1.ImageCaptured != null)
            {
                pictureCaptured(cameraControl1.ImageCaptured);
                this.Close();
            }
            else
            {
                cameraControl1.Stop_Camera();
                this.Close();
            }
        }
    }
}
