using Connection;
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
using Microsoft.Reporting.WinForms;

namespace Market_Manager.Sales
{
    public partial class Billing : Form
    {
        string id_purshase;
       public Billing( string id_purshase )
        {
            InitializeComponent();
            this.id_purshase = id_purshase;
        }
        public Billing()
        {
            InitializeComponent();
            this.id_purshase = "SHP63684013651";
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            try
            {                
                string cmd = string.Format("EXEC GetPurshaseProcessed '{0}'", id_purshase);
                DataSet data = Utilities.execute(cmd);
                getPurshaseProcessedTableAdapter1.Fill(invoice.GetPurshaseProcessed,this.id_purshase);

                //this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources[0].Value = invoice.GetPurshaseProcessed;
                this.reportViewer.LocalReport.EnableExternalImages = true;
                string path = Security.Security.GenerateBarcode(this.id_purshase);
                ReportParameter parameter = new ReportParameter("ImagePath", string.Format("File://{0}",path));
                this.reportViewer.LocalReport.SetParameters(parameter);
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            this.reportViewer.RefreshReport();
        }
    }
}
