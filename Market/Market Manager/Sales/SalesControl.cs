using Market_Manager.DataConnection;
using Market_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Manager
{
    public partial class SalesControl : Base
    {
        int count = 0;
        EmployerModel _employer;
        CustomerModel _cusotmer;
        double current_amount = 0;
        string id_purshase;
        public SalesControl(EmployerModel employer)
        {
            InitializeComponent();
            this._employer = employer;
            txtEmployer.Text = employer.employer_name;
            txtCurrentAmount.Text = "0";
            btnFind.Enabled = false;
            txtQuantity.Enabled = false;
            btnSum.Enabled = false;
            btnMinus.Enabled = false;
            this.id_purshase = "";
            foreach (var item in Controls.OfType<Button>())
            {
                if (item.Name != "btnSearch" || item.Name != "btnCancel")
                {
                    item.Enabled = false;
                }
            }
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ItemQuery frmIQuery = new ItemQuery();
            frmIQuery.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCQuery = new CustomerQuery();
            frmCQuery.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.id_purshase == "")
                    this.id_purshase = "SHP" + Security.Security.generateIdNumber();
                var id_customer = _cusotmer.id;
                var id_product = txtCode.Text;
                var quantity = int.Parse(txtQuantity.Text);
                if(quantity > 0)
                    Product_Data.AddProduct(this.id_purshase, id_customer, id_product, quantity);
                else
                    MessageBox.Show("You must add the desired quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var listProduct = Purshase.GetPurshase(this.id_purshase, id_product);
                this.current_amount += listProduct.amount;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvProducts);
                row.Cells[0].Value = listProduct.id_product;
                row.Cells[1].Value = listProduct.product_name;
                row.Cells[2].Value = listProduct.product_mark;
                row.Cells[3].Value = listProduct.product_price.ToString();
                row.Cells[4].Value = listProduct.quantity_desired.ToString();
                row.Cells[5].Value = listProduct.amount.ToString();
                dgvProducts.Rows.Add(row);

                txtCurrentAmount.Text = listProduct.total_amount.ToString();
                txtCode.Text = "";
                txtNameProduct.Text = "";
                txtMark.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "0";
            }
            catch (Exception)
            {

                MessageBox.Show("There was a problem adding the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            count++;
            txtQuantity.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                txtQuantity.Text = count.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = Customer_Data.getCustomer(txtCustomerId.Text);
                _cusotmer = customer;
                txtCustomerName.Text = customer.name + " " + customer.lastname;
                btnFind.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("There was a problem looking for the customer, try with Customer action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                var product = Product_Data.getProduct(txtCode.Text);
                txtNameProduct.Text = product.name;
                txtMark.Text = product.mark;
                txtPrice.Text = product.price.ToString();
                txtQuantity.Text = product.quantity.ToString();
                txtQuantity.Enabled = true;
                btnSum.Enabled = true;
                btnMinus.Enabled = true;
                foreach (var item in Controls.OfType<Button>())
                {
                    if (!item.Enabled)
                        item.Enabled = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There was a problem looking for the product, try with Products action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.id_purshase = "";
            this.current_amount = 0;
        }
    }
}
