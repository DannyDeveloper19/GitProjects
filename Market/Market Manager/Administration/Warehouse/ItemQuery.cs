using Market_Manager.DataConnection;
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
    public partial class ItemQuery : Base
    {
        public ItemQuery()
        {
            InitializeComponent();
        }


        private void ItemQuery_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Product_Data.getAllProducts())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProducts);

                    row.Cells[0].Value = item.id;
                    row.Cells[1].Value = item.name;
                    row.Cells[2].Value = item.mark;
                    row.Cells[3].Value = item.price;
                    row.Cells[4].Value = item.quantity;
                    dgvProducts.Rows.Add(row);

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
    }
}
