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
    public partial class EmployerQuery : Form
    {
        public EmployerQuery()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewEmployer newEmployer = new NewEmployer();
            newEmployer.ShowDialog();
        }

    }
}
