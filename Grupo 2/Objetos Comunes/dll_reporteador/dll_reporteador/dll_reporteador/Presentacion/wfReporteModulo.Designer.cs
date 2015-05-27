namespace dll_reporteador.Presentacion
{
    partial class wfReporteModulo
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
            this.dtModuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsModulo = new dll_reporteador.Presentacion.dsModulo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtModuloTA = new dll_reporteador.Presentacion.dsModuloTableAdapters.dtModuloTA();
            ((System.ComponentModel.ISupportInitialize)(this.dtModuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtModuloBindingSource
            // 
            this.dtModuloBindingSource.DataMember = "dtModulo";
            this.dtModuloBindingSource.DataSource = this.dsModulo;
            // 
            // dsModulo
            // 
            this.dsModulo.DataSetName = "dsModulo";
            this.dsModulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsModulo";
            reportDataSource1.Value = this.dtModuloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dll_reporteador.Presentacion.rpModulo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(815, 425);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtModuloTA
            // 
            this.dtModuloTA.ClearBeforeFill = true;
            // 
            // wfReporteModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 425);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfReporteModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Modulo";
            this.Load += new System.EventHandler(this.wfReporteModulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtModuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtModuloBindingSource;
        private dsModulo dsModulo;
        private dsModuloTableAdapters.dtModuloTA dtModuloTA;
    }
}