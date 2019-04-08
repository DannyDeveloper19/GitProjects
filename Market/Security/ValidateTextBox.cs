using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Security
{
    public partial class ValidateTextBox : TextBox
    {
        public static ErrorProvider error;
        public static ToolTip tltMessage = new ToolTip();
        public ValidateTextBox()
        {            
            InitializeComponent();
            Initialize();
        }

        public bool Validate { get; set; }
        public bool Numbers { get; set; }
        public bool Email { get; set; }
        public bool Letters { get; set; }
        public bool Password { get; set; }

        public bool CompareWith(string text)
        {
            return this.Text.Equals(text);
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
            if (this.Numbers)
            {
                Regex reg = new Regex(@"^[0-9]+$");
                if (!reg.IsMatch(this.Text.Trim()))
                {
                    error.SetError(this, "This field must be numbers.");
                    return true;
                }
            }
            if (this.Email)
            {
                Regex reg = new Regex(@"^[a-zA-Z0-9._]+@[a-z0-9._]+.[a-z]{2,3}$");
                if (!reg.IsMatch(this.Text.Trim()))
                {
                    error.SetError(this, "This field is for email");
                    return true;
                }
            }
            if (this.Password)
            {
                Regex reg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,15}$");
                if (!reg.IsMatch(this.Text.Trim()))
                {
                    error.SetError(this, "No less than 8 and no more than 15 characters,\nAt least one capital letter,\nAt least one lowercase letter,\nAt least none special character($@$!%*?&),\nNo whitespace.");
                    return true;
                }
            }

            return false;
        }

        private void ValidateTxtBox_TextChanged(object sender, EventArgs e)
        {
            error.SetError(this, "");
            if (this.Validate)
            {
                if (string.IsNullOrEmpty(this.Text.Trim()))
                {
                    this.BackColor = Color.LightSalmon;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
            if (this.Numbers)
            {
                tltMessage.SetToolTip(this, "This field is for numbers");
                int cont = 0;
                foreach (var digit in this.Text.Trim())
                {
                    if (!char.IsNumber(digit))
                    {
                        cont++;
                    }
                }
                if (cont != 0)
                {
                    this.BackColor = Color.LightSalmon;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
            if (this.Email)
            {
                tltMessage.SetToolTip(this, "This field is for email");
                Regex reg = new Regex(@"^[a-zA-Z0-9._]+@[a-z0-9._]+.[a-z]{2,3}$");
                if (!reg.IsMatch(this.Text.Trim()))
                {
                    this.BackColor = Color.LightSalmon;
                }
                else
                {
                    this.BackColor = Color.White;
                }

            }
            if (this.Letters)
            {
                Regex regex = new Regex(@"^[A-Za-zá-úñÑ\s]+$");
                if (!regex.IsMatch(this.Text.Trim()))
                {
                    this.BackColor = Color.LightSalmon;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
            if (this.Password)
            {
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,15}$");
                if (!regex.IsMatch(this.Text.Trim()))
                {
                    this.BackColor = Color.LightSalmon;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
        }
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
            //TextBox
            this.TextChanged += ValidateTxtBox_TextChanged;

            //errorProvider
            error = new ErrorProvider();
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            error.Icon = ResizeIcon(new Icon("C:/GitProjects/Market/Security/Resourses/Error.ico"));
        }
    }



}
