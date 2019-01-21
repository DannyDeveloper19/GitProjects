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

namespace Market_Manager.Customer_Service
{
    public partial class ReturnDetails : Base
    {
        Purshase_Product _product;
        int count = 0;
        int quantity = 0;
        double quantity_amount = 0;
        double current_amount = 0; 
        public ReturnDetails(string id_purshase, Purshase_Product product)
        {
            InitializeComponent();
            this._product = product;
            txtOrder.Text = id_purshase;


        }

        public delegate void UpdateQuantity(object sender1, object sender2);
        public UpdateQuantity updateQuantity;

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(count < quantity)
            {
                count++;
                if (count == quantity)
                {
                    current_amount = this._product.total_amount - quantity_amount;
                }
                else
                {
                    current_amount = this._product.total_amount - (this._product.product_price * count);
                }
                txtCurrentAmount.Text = current_amount.ToString();
                txtQuantity.Text = count.ToString();
            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
           if (count > 0)
            {
                count--;
                if (count == 0)
                {
                    current_amount = this._product.total_amount; 
                    
                }
                else
                {
                    current_amount = this._product.total_amount - (this._product.product_price * count); 
                }
                txtCurrentAmount.Text = current_amount.ToString();
                txtQuantity.Text = count.ToString();
            }
            
        }

        public override void Save()
        {
            if (updateQuantity != null)
            {
                updateQuantity(int.Parse(txtQuantity.Text), cmbCondition.Text);
                this.Close();
            }
        }

        public override void Cancel()
        {
            this.Close();
        }

        private void ReturnDetails_Load(object sender, EventArgs e)
        {
            txtIdProduct.Text = this._product.id_product;
            txtName.Text = this._product.product_name;
            txtMark.Text = this._product.product_mark;
            quantity = this._product.quantity_desired;
            txtQuantity.Text = quantity.ToString();
            txtAmount.Text = this._product.amount.ToString();
            quantity_amount = this._product.amount;
            count = quantity;
            current_amount = this._product.total_amount - quantity_amount;
            txtCurrentAmount.Text = this.current_amount.ToString();
            foreach (var item in Enum.GetValues(typeof(Return_State)))
            {
                cmbCondition.Items.Add(item);
            }
            
        }
    }
}
