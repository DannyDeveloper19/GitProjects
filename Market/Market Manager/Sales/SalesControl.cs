using Connection;
using Market_Manager.DataConnection;
using Market_Manager.Models;
using Market_Manager.Sales;
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
        string id_purshase = "";

        public SalesControl(EmployerModel employer)
        {
            InitializeComponent();
            this._employer = employer;
            txtEmployer.Text = employer.employer_name;
            InitializeSale();            
        }

        private void InitializeSale()
        {
            txtCustomerId.Focus();
            _cusotmer = new CustomerModel();
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtCode.Text = "";
            dgvProducts.Rows.Clear();
            txtCurrentAmount.Text = "0";
            txtNameProduct.Text = "";
            txtMark.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            btnSearch.Enabled = true;
            btnFind.Enabled = false;
            txtQuantity.Enabled = false;
            btnSum.Enabled = false;
            btnMinus.Enabled = false;
            this.id_purshase = "";
            foreach (var item in Controls.OfType<Button>().Where(btn => btn.Name != "btnCustomer" && btn.Name != "btnCancel"))
            {
                item.Enabled = false;
            }
        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            ItemQuery frmIQuery = new ItemQuery();
            frmIQuery.itemSelected = new ItemQuery.UpdateItem(UpdateProductEventHandler);
            Button button = frmIQuery.Controls.OfType<Button>().Where(btn =>  btn.Name == "btnNew").Single();
            button.Enabled = false;
            Button btnAccept = frmIQuery.Controls.OfType<Button>().Where(btn => btn.Name == "btnAccept").Single();
            btnAccept.Text = "Select";
            frmIQuery.ShowDialog();
        }

        private void UpdateProductEventHandler(object sender)
        {
            try
            {
                txtCode.Text = sender.ToString();
                var product = Product_Data.getProduct(sender.ToString());
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

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerQuery frmCQuery = new CustomerQuery();
            frmCQuery.customerSelected = new CustomerQuery.UpdateCustomer(UpdateCustomerEventHandler);
            Button btnNew = frmCQuery.Controls.OfType<Button>().Where(btn => btn.Name == "btnNew").Single();
            Button btnAccept = frmCQuery.Controls.OfType<Button>().Where(btn => btn.Name == "btnAccept").Single();
            btnAccept.Text = "Select";
            btnNew.Enabled = false;
            frmCQuery.ShowDialog();
        }

        private void UpdateCustomerEventHandler(object sender)
        {
            try
            {
                txtCustomerId.Text = sender.ToString();
                var customer = Customer_Data.getCustomer(sender.ToString());
                _cusotmer = customer;
                txtCustomerName.Text = customer.name + " " + customer.lastname;
                btnFind.Enabled = true;
                btnItems.Enabled = true;
                btnSearch.Enabled = false;
                this.id_purshase = "SHP" + Security.Security.generateIdNumber();

            }
            catch (Exception)
            {

                MessageBox.Show("There was a problem looking for the customer, try with Customer action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnItems.Enabled = true;
                btnSearch.Enabled = false;
                this.id_purshase = "SHP" + Security.Security.generateIdNumber();
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
         
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var id_customer = _cusotmer.id;
                var id_product = txtCode.Text;
                var quantity = int.Parse(txtQuantity.Text);
                if (quantity > 0 && quantity <= in_stock)
                    Purshase.AddProduct(id_purshase, id_customer, id_product, quantity,_employer.id_employer);
                else
                    MessageBox.Show("The amount must not be 0 or greater than " + in_stock.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var listProduct = Purshase.GetProductSelected(id_purshase, id_product, id_customer);

                bool exists = false;
                for (int i = 0; i < dgvProducts.Rows.Count; i++)
                {
                    var row = dgvProducts.Rows[i];
                    if (row.Cells[0].Value.ToString() == listProduct.id_product)
                    {
                        row.Cells[4].Value = listProduct.quantity_desired.ToString();
                        row.Cells[5].Value = listProduct.amount.ToString();
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProducts);
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
                btnFind.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Save()
        {
            if (dgvProducts.Rows.Count != 0)
            {
                var dialog = MessageBox.Show("Do you really want to process the order?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    try
                    {
                        Purshase.ProcessSaleOrder(this.id_purshase);
                        Billing bill = new Billing(this.id_purshase);
                        bill.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        //The sale could not be completed

                        MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    
                }
                dialog = MessageBox.Show("Do you want to process a new order?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    InitializeSale();
                }
                else
                {
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("We can't process this purshase without products.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public override void Cancel()
        {
            if (this.id_purshase != "")
            {
                try
                {
                    var dialog = MessageBox.Show("Do you really want to cancel the order?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        Purshase.CancelSaleOrder(this.id_purshase);
                        //MessageBox.Show("Order Cancelled!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();

                    }


                }
                catch (Exception)
                {

                    MessageBox.Show("There was a problem cancelling de order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.Rows[dgvProducts.CurrentRow.Index].Selected)
            {
                //Develop this action
                var id_item = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[0].Value.ToString();
                Purshase.RemoveProduct(this.id_purshase, id_item);
                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("You must select the product to remove.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Do you really want to cancel this order and begin a new one?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                Purshase.CancelSaleOrder(this.id_purshase);
                InitializeSale();
            }
        }
    }
}
