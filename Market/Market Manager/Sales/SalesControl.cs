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
            Button button = frmIQuery.Controls.OfType<Button>().Where(btn =>  btn.Name == "btnNew").Single();
            button.Enabled = false;
            frmIQuery.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCQuery = new CustomerQuery();
            Button button = frmCQuery.Controls.OfType<Button>().Where(btn => btn.Name == "btnNew").Single();
            button.Enabled = false;
            frmCQuery.ShowDialog();
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
                btnItems.Enabled = true;
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

        private void btnBilling_Click(object sender, EventArgs e)
        {
            try
            {
                var id_customer = _cusotmer.id;
                var id_product = txtCode.Text;
                var quantity = int.Parse(txtQuantity.Text);
                if (quantity > 0 && quantity <= in_stock)
                    Product_Data.AddProduct(id_purshase, id_customer, id_product, quantity);
                else
                    MessageBox.Show("The amount must not be 0 or greater than " + in_stock.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var listProduct = Purshase.GetPurshase(id_purshase, id_product, id_customer);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvProducts);
                row.Cells[0].Value = listProduct.id_product;
                if (dgvProducts.Rows.Contains(row))
                {
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[4].Value = listProduct.quantity_desired.ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[5].Value = listProduct.amount.ToString();
                }
                else
                {
                    row.Cells[0].Value = listProduct.id_product;
                    row.Cells[1].Value = listProduct.product_name;
                    row.Cells[2].Value = listProduct.product_mark;
                    row.Cells[3].Value = listProduct.product_price.ToString();
                    row.Cells[4].Value = listProduct.quantity_desired.ToString();
                    row.Cells[5].Value = listProduct.amount.ToString();
                    dgvProducts.Rows.Add(row);
                }

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

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public override void Save()
        {
            try
            {
                var dialog = MessageBox.Show("Do you really want to process the order?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    Purshase.ProcessSaleOrder(this.id_purshase);
                    _cusotmer = new CustomerModel();
                    this.id_purshase = "SHP" + Security.Security.generateIdNumber();
                    txtCustomerName.Text = "";
                    txtCode.Text = "";
                    dgvProducts.Rows.Clear();

                }
                MessageBox.Show("Order Processed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                //The sale could not be completed

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }
        public override void Cancel()
        {
            try
            {
                var dialog = MessageBox.Show("Do you really want to cancel the order?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    Purshase.CancelSaleOrder(this.id_purshase);

                }
                MessageBox.Show("Order Cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("There was a problem cancelling de order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
