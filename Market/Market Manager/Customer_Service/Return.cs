using Market_Manager.Customer_Service;
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

namespace Market_Manager.Admission
{
    public partial class Return : Base
    {
        public Return()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtFindProduct.Enabled = false;
            txtIdPurshase.Focus();
        }

        private void Initialize()
        {
            txtCurrentAmount.Text = "";
            txtDate.Text = "";
            txtFindProduct.Text = "";
            txtIdCustomer.Text = "";
            txtIdPurshase.Text = "";
            txtName.Text = "";
            dgvProducts.Rows.Clear();
        }

        public override void Save()
        {
            if (ckbCancelOrder.Checked)
            {
                try
                {
                    Purshase.CancelSaleOrder(txtIdPurshase.Text);
                    MessageBox.Show("The order has been cancel.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var dialog = MessageBox.Show("Do you want to process a new order?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        Initialize();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string id_product = dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                string name = dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                string mark = dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                double price = double.Parse(dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[3].Value.ToString());
                int quantity = int.Parse(dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[4].Value.ToString());
                double amount = double.Parse(dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[5].Value.ToString());
                double total_amount = double.Parse(txtCurrentAmount.Text);
                var product = new Purshase_Product(id_product, name, mark, price, quantity, amount, total_amount);
                ReturnDetails returnDetails = new ReturnDetails(txtIdPurshase.Text, product);
                returnDetails.updateQuantity = new ReturnDetails.UpdateQuantity(UpdateQuantityEventHandler);
                returnDetails.ShowDialog();
            }
            
        }

        private void UpdateQuantityEventHandler(object sender, object sender2)
        {
            try
            {
                string id_product = dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                int quantity = int.Parse(dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex].Cells[4].Value.ToString());
                int count = int.Parse(sender.ToString());
                string condition = sender2.ToString();
                if (count > 0)
                {
                    Purshase.ReturnProduct(txtIdPurshase.Text, id_product,count,condition);
                    MessageBox.Show("Return success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                PurshaseInfo info = Purshase.GetPurshase(txtIdPurshase.Text);
                if (info.products != null)
                {
                    dgvProducts.Rows.Clear();
                    txtCurrentAmount.Text = info.products.First().total_amount.ToString();
                    foreach (var product in info.products)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvProducts);

                        row.Cells[0].Value = product.id_product;
                        row.Cells[1].Value = product.product_name;
                        row.Cells[2].Value = product.product_mark;
                        row.Cells[3].Value = product.product_price;
                        row.Cells[4].Value = product.quantity_desired;
                        row.Cells[5].Value = product.amount;

                        dgvProducts.Rows.Add(row);

                    }
                }
                else
                {
                    MessageBox.Show("The order has been cancel.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var dialog = MessageBox.Show("Do you want to process a new order?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        Initialize();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Cancel()
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var info = Purshase.GetPurshase(txtIdPurshase.Text);
                txtIdCustomer.Text = info.id_customer;
                txtName.Text = info.customer_name;
                txtDate.Text = info.date;
                txtCurrentAmount.Text = info.products.First().total_amount.ToString(); 

                foreach (var product in info.products)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProducts);

                    row.Cells[0].Value = product.id_product;
                    row.Cells[1].Value = product.product_name;
                    row.Cells[2].Value = product.product_mark;
                    row.Cells[3].Value = product.product_price;
                    row.Cells[4].Value = product.quantity_desired;
                    row.Cells[5].Value = product.amount;

                    dgvProducts.Rows.Add(row);

                }
                txtFindProduct.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
