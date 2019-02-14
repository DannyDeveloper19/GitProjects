namespace Market_Manager.Sales
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.GetPurshaseProcessedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice = new Market_Manager.Reports.Invoice();
            this.getPurshaseProcessedTableAdapter1 = new Market_Manager.Reports.InvoiceTableAdapters.GetPurshaseProcessedTableAdapter();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GetPurshaseProcessedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // GetPurshaseProcessedBindingSource
            // 
            this.GetPurshaseProcessedBindingSource.DataMember = "GetPurshaseProcessed";
            this.GetPurshaseProcessedBindingSource.DataSource = this.invoice;
            // 
            // invoice
            // 
            this.invoice.DataSetName = "Invoice";
            this.invoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPurshaseProcessedTableAdapter1
            // 
            this.getPurshaseProcessedTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetPurshaseProcessedBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Market_Manager.Reports.Invoice.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(709, 511);
            this.reportViewer.TabIndex = 0;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 511);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(725, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 550);
            this.Name = "Billing";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetPurshaseProcessedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Reports.InvoiceTableAdapters.GetPurshaseProcessedTableAdapter getPurshaseProcessedTableAdapter1;
        private Reports.Invoice invoice;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource GetPurshaseProcessedBindingSource;
    }
}