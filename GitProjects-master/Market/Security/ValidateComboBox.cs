using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class ValidateComboBox : ComboBox
    {
        public static ErrorProvider error = new ErrorProvider();
        public static ToolTip tltMessage = new ToolTip();

        public ValidateComboBox()
        {
            InitializeComponent();
            Initialize();
        }

        public bool isValidated()
        {
            error.SetError(this, "");
            if (this.Validate)
            {
                if (string.IsNullOrEmpty(this.Text.Trim()))
                {

                    error.SetError(this, "this field can't be empty.");
                    tltMessage.SetToolTip(this, "this field can't be empty.");
                    return true;
                }
                
            }
            return false;
        }

        public bool Validate { get; set; }

        private static Icon ResizeIcon(Icon icon)
        {
            Bitmap bitmap = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(icon.ToBitmap(), new Rectangle(Point.Empty, bitmap.Size));
            }
            return Icon.FromHandle(bitmap.GetHicon());
        }

        private void Initialize()
        {
            //errorProvider
            error = new ErrorProvider();
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            error.Icon = ResizeIcon(new Icon("C:/GitProjects/Market/Security/Resourses/Error.ico"));
        }
    }
}
