using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market_Manager.DataConnection;

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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            

        }

        public override void Save()
        {
            try
            {
                var id = "PRT" + Security.Security.generateIdNumber();
                var name = txtName.Text;
                var mark = txtBrand.Text;
                var price = double.Parse(txtPrice.Text);
                var quantity = int.Parse(txtQuantity.Text);
                Product_Data.updateProduct(new Models.Product(id, name, mark, price, quantity));
                MessageBox.Show("New Product added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                MessageBox.Show("There were an error trying to add the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
