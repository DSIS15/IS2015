namespace Reporteador_IS
{
    partial class wf_RepoCodigoBarras
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
            this.Tabm_produccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DT_CodigoBarras = new Reporteador_IS.DT_CodigoBarras();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tabm_produccionTableAdapter = new Reporteador_IS.DT_CodigoBarrasTableAdapters.Tabm_produccionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tabm_produccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_CodigoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabm_produccionBindingSource
            // 
            this.Tabm_produccionBindingSource.DataMember = "Tabm_produccion";
            this.Tabm_produccionBindingSource.DataSource = this.DT_CodigoBarras;
            // 
            // DT_CodigoBarras
            // 
            this.DT_CodigoBarras.DataSetName = "DT_CodigoBarras";
            this.DT_CodigoBarras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tabm_produccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporteador_IS.Rep_CodigoBarras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(963, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tabm_produccionTableAdapter
            // 
            this.Tabm_produccionTableAdapter.ClearBeforeFill = true;
            // 
            // wf_RepoCodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 513);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wf_RepoCodigoBarras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Codigo Barras | Reportes";
            this.Load += new System.EventHandler(this.wf_RepoCodigoBarras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabm_produccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_CodigoBarras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tabm_produccionBindingSource;
        private DT_CodigoBarras DT_CodigoBarras;
        private DT_CodigoBarrasTableAdapters.Tabm_produccionTableAdapter Tabm_produccionTableAdapter;
    }
}