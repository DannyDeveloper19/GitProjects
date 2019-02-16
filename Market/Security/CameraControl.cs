using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace Security
{
    public partial class CameraControl : UserControl
    {
        VideoCaptureDevice video = null;
        FilterInfoCollection devices;
        BrightnessCorrection brightness;
        ContrastCorrection contrast;
        GammaCorrection gamma;
        public System.Drawing.Image ImageCaptured { get; private set; }

        public CameraControl()
        {           
            InitializeComponent();
            
        }

        private void CmbDevices_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbDevices.Text))
            {
                cmbDevices.Text = "Select one devices....";
                cmbDevices.ForeColor = Color.Gray;
            }

        }

        private void CmbDevices_GotFocus(object sender, EventArgs e)
        {
            cmbDevices.ForeColor = Color.Black;
            cmbDevices.Text = "";
        }

        private void CameraControl_Load(object sender, EventArgs e)
        {
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cmbDevices.Text = "Select one devices....";
            cmbDevices.ForeColor = Color.Gray;
            cmbDevices.GotFocus += CmbDevices_GotFocus;
            cmbDevices.LostFocus += CmbDevices_LostFocus;
            foreach (FilterInfo item in devices)
            {
                cmbDevices.Items.Add(item.Name);
            }
            trbBrightness.Value = 0;
            trbContrast.Value = 10;
            trbGamma.Value = (int)1;
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            video = new VideoCaptureDevice(devices[cmbDevices.SelectedIndex].MonikerString);
            video.VideoResolution = video.VideoCapabilities[1];
            video.NewFrame += Video_NewFrame;
            video.Start();
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            brightness = new BrightnessCorrection(trbBrightness.Value);
            contrast = new ContrastCorrection(trbContrast.Value);
            gamma = new GammaCorrection(trbGamma.Value);
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            ptbImage.Image = brightness.Apply(gamma.Apply(contrast.Apply(image)));
            //ptbImage.Image = image;
            lblBrightness.Text = trbBrightness.Value.ToString();
            lblContrast.Text = trbContrast.Value.ToString();
            lblGamma.Text = trbGamma.Value.ToString();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (video != null && video.IsRunning == true)
            {
                Stop_Camera();
                ImageCaptured = ptbImage.Image;
            }
            else
                MessageBox.Show("You must select a device!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Stop_Camera()
        {
            video.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ptbImage.Image = null;
            Stop_Camera();
            video.Start();
        }
    }
}
