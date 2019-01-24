using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        public override void Save()
        {
            if (!Security.Validating.validateFields(this))
            {

            }
        }

        public override void Cancel()
        {
            this.Close();
        }
    }
}
