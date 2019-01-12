using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Manager.Administration.Warehouse
{
    public partial class New_Item : Base
    {
        int count = 0;
        public New_Item()
        {
            InitializeComponent();
        }

        private void New_Item_Load(object sender, EventArgs e)
        {
            txtQuantity.Text = count.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            count++;
            txtQuantity.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (count > 0 )
            {
                count--;
                txtQuantity.Text = count.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
