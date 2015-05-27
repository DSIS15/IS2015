namespace dll_reporteador.Presentacion
{
    partial class wfReporteReceta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReceta = new dll_reporteador.Presentacion.dsReceta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtRecetaTA = new dll_reporteador.Presentacion.dsRecetaTableAdapters.dtRecetaTA();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRecetaBindingSource
            // 
            this.dtRecetaBindingSource.DataMember = "dtReceta";
            this.dtRecetaBindingSource.DataSource = this.dsReceta;
            // 
            // dsReceta
            // 
            this.dsReceta.DataSetName = "dsReceta";
            this.dsReceta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsReceta";
            reportDataSource2.Value = this.dtRecetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dll_reporteador.Presentacion.rpReceta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(785, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtRecetaTA
            // 
            this.dtRecetaTA.ClearBeforeFill = true;
            // 
            // wfReporteReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 395);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfReporteReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Receta";
            this.Load += new System.EventHandler(this.wfReporteReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRecetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtRecetaBindingSource;
        private dsReceta dsReceta;
        private dsRecetaTableAdapters.dtRecetaTA dtRecetaTA;
    }
}