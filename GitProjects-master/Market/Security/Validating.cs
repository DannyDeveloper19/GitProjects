using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public class Validating
    {
       
        public static bool validateFields(Control control)
        {
           bool errors = false;
            foreach (var item in control.Controls)
            {
                if (item is ValidateTextBox)
                {
                    ValidateTextBox field = (ValidateTextBox)item;

                    if (field.isValidated())
                    {
                            errors = field.isValidated();

                    }
                    
                }
                else if (item is ValidateComboBox)
                {
                    ValidateComboBox field = (ValidateComboBox)item;
                    if (field.isValidated())
                    {
                        errors = field.isValidated();
                    }

                }
                else if (item is GroupBox)
                {
                    GroupBox group= (GroupBox)item;
                    foreach (var elem in group.Controls)
                    {
                        if (elem is ValidateTextBox)
                        {
                            ValidateTextBox field = (ValidateTextBox)elem;

                            if (field.isValidated())
                            {
                                errors = field.isValidated();

                            }

                        }
                        else if (elem is ValidateComboBox)
                        {
                            ValidateComboBox field = (ValidateComboBox)elem;
                            if (field.isValidated())
                            {
                                errors = field.isValidated();
                            }

                        }
                    }
                }
            }

            return errors;
        }

        
    }
}
