namespace dll_reporteador.Presentacion
{
    partial class wfReporteFactura
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
            this.dtFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFactura = new dll_reporteador.Presentacion.dsFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtFacturaTA = new dll_reporteador.Presentacion.dsFacturaTableAdapters.dtFacturaTA();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFacturaBindingSource
            // 
            this.dtFacturaBindingSource.DataMember = "dtFactura";
            this.dtFacturaBindingSource.DataSource = this.dsFactura;
            // 
            // dsFactura
            // 
            this.dsFactura.DataSetName = "dsFactura";
            this.dsFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsFactura";
            reportDataSource1.Value = this.dtFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dll_reporteador.Presentacion.rpFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtFacturaTA
            // 
            this.dtFacturaTA.ClearBeforeFill = true;
            // 
            // wfReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 403);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Factura";
            this.Load += new System.EventHandler(this.wfReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtFacturaBindingSource;
        private dsFactura dsFactura;
        private dsFacturaTableAdapters.dtFacturaTA dtFacturaTA;
    }
}