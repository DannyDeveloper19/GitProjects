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
            
            Graphics graphics = Graphics.FromImage(image);
            using (Pen pen = new Pen(Color.Green, 7))
            {
                //Top, left
                graphics.DrawLine(pen, 80, 28, 100, 28);
                graphics.DrawLine(pen, 80, 28, 80, 48);
                //Top, right
                graphics.DrawLine(pen, 80 + 146, 28, 80 + 126, 28);
                graphics.DrawLine(pen, 80 + 146, 28, 80 + 146, 48);
                //Bottom, left
                graphics.DrawLine(pen, 80, 35 + 171, 100, 35 + 171);
                graphics.DrawLine(pen, 80, 35 + 171, 80, 35 + 151);
                //Bottom, right
                graphics.DrawLine(pen, 80 + 146, 35 + 171, 80 + 126, 35 + 171);
                graphics.DrawLine(pen, 80 + 146, 35 + 171, 80 + 146, 35 + 151);
                //Middle left size
                graphics.DrawLine(pen, 80, 113, 80, 113 + 20);
                //Middle right size
                graphics.DrawLine(pen, 80 + 146, 113, 80 + 146, 113 + 20);
                //Middle top size
                graphics.DrawLine(pen, 146, 28, 166, 28);
                //Middle botom size
                graphics.DrawLine(pen, 146, 35 + 171, 166, 35 + 171);
                //graphics.DrawRectangle(pen, rectangle);
            }
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
                ImageCaptured = cropImage(ptbImage.Image);
            }
            else
                MessageBox.Show("You must select a device!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static System.Drawing.Image cropImage(System.Drawing.Image img)
        {
            Rectangle rectangle = new Rectangle(87, 35, 136, 164);
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(rectangle,
            bmpImage.PixelFormat);
            return (System.Drawing.Image)(bmpCrop);
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
