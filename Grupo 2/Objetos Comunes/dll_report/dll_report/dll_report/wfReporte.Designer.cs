namespace dll_report
{
    partial class wfReporte
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
            this.rpReporteador = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsHospital = new dll_report.dsHospital();
            this.dtUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtUsuarioTA = new dll_report.dsHospitalTableAdapters.dtUsuarioTA();
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpReporteador
            // 
            this.rpReporteador.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsUsuario";
            reportDataSource1.Value = this.dtUsuarioBindingSource;
            this.rpReporteador.LocalReport.DataSources.Add(reportDataSource1);
            this.rpReporteador.LocalReport.ReportEmbeddedResource = "dll_report.rpReportePrincipal.rdlc";
            this.rpReporteador.Location = new System.Drawing.Point(0, 0);
            this.rpReporteador.Name = "rpReporteador";
            this.rpReporteador.Size = new System.Drawing.Size(826, 492);
            this.rpReporteador.TabIndex = 0;
            // 
            // dsHospital
            // 
            this.dsHospital.DataSetName = "dsHospital";
            this.dsHospital.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtUsuarioBindingSource
            // 
            this.dtUsuarioBindingSource.DataMember = "dtUsuario";
            this.dtUsuarioBindingSource.DataSource = this.dsHospital;
            // 
            // dtUsuarioTA
            // 
            this.dtUsuarioTA.ClearBeforeFill = true;
            // 
            // wfReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 492);
            this.Controls.Add(this.rpReporteador);
            this.Name = "wfReporte";
            this.Text = "wfReporte";
            this.Load += new System.EventHandler(this.wfReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpReporteador;
        private System.Windows.Forms.BindingSource dtUsuarioBindingSource;
        private dsHospital dsHospital;
        private dsHospitalTableAdapters.dtUsuarioTA dtUsuarioTA;
    }
}