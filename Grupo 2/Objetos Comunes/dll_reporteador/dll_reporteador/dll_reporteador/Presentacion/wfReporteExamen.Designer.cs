namespace dll_reporteador.Presentacion
{
    partial class wfReporteExamen
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
            this.dtExamenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExamen = new dll_reporteador.Presentacion.dsExamen();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtExamenTA = new dll_reporteador.Presentacion.dsExamenTableAdapters.dtExamenTA();
            ((System.ComponentModel.ISupportInitialize)(this.dtExamenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // dtExamenBindingSource
            // 
            this.dtExamenBindingSource.DataMember = "dtExamen";
            this.dtExamenBindingSource.DataSource = this.dsExamen;
            // 
            // dsExamen
            // 
            this.dsExamen.DataSetName = "dsExamen";
            this.dsExamen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsExamen";
            reportDataSource1.Value = this.dtExamenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dll_reporteador.Presentacion.rpExamen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(867, 470);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtExamenTA
            // 
            this.dtExamenTA.ClearBeforeFill = true;
            // 
            // wfReporteExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 470);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfReporteExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Examen";
            this.Load += new System.EventHandler(this.wfReporteExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtExamenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExamen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtExamenBindingSource;
        private dsExamen dsExamen;
        private dsExamenTableAdapters.dtExamenTA dtExamenTA;
    }
}