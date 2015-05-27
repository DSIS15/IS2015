namespace dll_reporteador.Presentacion
{
    partial class wfReportePaciente
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPaciente = new dll_reporteador.Presentacion.dsPaciente();
            this.dtPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPacienteTA = new dll_reporteador.Presentacion.dsPacienteTableAdapters.dtPacienteTA();
            ((System.ComponentModel.ISupportInitialize)(this.dsPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPaciente";
            reportDataSource1.Value = this.dtPacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dll_reporteador.Presentacion.rpPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(727, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPaciente
            // 
            this.dsPaciente.DataSetName = "dsPaciente";
            this.dsPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPacienteBindingSource
            // 
            this.dtPacienteBindingSource.DataMember = "dtPaciente";
            this.dtPacienteBindingSource.DataSource = this.dsPaciente;
            // 
            // dtPacienteTA
            // 
            this.dtPacienteTA.ClearBeforeFill = true;
            // 
            // wfReportePaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 343);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfReportePaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Paciente";
            this.Load += new System.EventHandler(this.wfReportePaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPacienteBindingSource;
        private dsPaciente dsPaciente;
        private dsPacienteTableAdapters.dtPacienteTA dtPacienteTA;
    }
}