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
        CustomerModel _cusotmer { get; set; }
        int in_stock = 0;
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
            id_purshase = "SHP" + Security.Security.generateIdNumber();
            foreach (var item in Controls.OfType<Button>())
            {
                item.Enabled = false;
            }
            btnCustomer.Enabled = true;
            btnCancel.Enabled = true;
            
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
                var id_customer = _cusotmer.id;
                var id_product = txtCode.Text;
                var quantity = int.Parse(txtQuantity.Text);
                if(quantity > 0 && quantity <= in_stock)
                    Product_Data.AddProduct(id_purshase, id_customer, id_product, quantity);
                else
                    MessageBox.Show("The amount must not be 0 or greater than "+in_stock.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var listProduct = Purshase.GetPurshase(id_purshase, id_product,id_customer);
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
                count = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (count < in_stock)
            {
                count++;
                txtQuantity.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("There are no more of this product in stock.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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
                this.in_stock = product.quantity;
                txtQuantity.Enabled = true;
                btnSum.Enabled = true;
                btnMinus.Enabled = true;
                txtQuantity.Text = count.ToString();
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
            
        }
    }
}
