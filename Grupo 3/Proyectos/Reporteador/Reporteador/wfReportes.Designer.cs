namespace Reporteador
{
    partial class wfReportes
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
            this.dtDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBaseDatos = new Reporteador.dsBaseDatos();
            this.dtAmbientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCatProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtReservacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientesTA = new Reporteador.dsBaseDatosTableAdapters.dtClientesTA();
            this.dtReservacionesTA = new Reporteador.dsBaseDatosTableAdapters.dtReservacionesTA();
            this.dtCatProductosTA = new Reporteador.dsBaseDatosTableAdapters.dtCatProductosTA();
            this.dtAmbientesTA = new Reporteador.dsBaseDatosTableAdapters.dtAmbientesTA();
            this.dtServiciosTA = new Reporteador.dsBaseDatosTableAdapters.dtServiciosTA();
            this.dtDocumentosTA = new Reporteador.dsBaseDatosTableAdapters.dsDocumentosTA();
            this.dtFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtFacturasTA = new Reporteador.dsBaseDatosTableAdapters.dtFacturasTA();
            this.rvReporteador = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBaseDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAmbientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCatProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReservacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDocumentosBindingSource
            // 
            this.dtDocumentosBindingSource.DataMember = "dsDocumentos";
            this.dtDocumentosBindingSource.DataSource = this.dsBaseDatos;
            // 
            // dsBaseDatos
            // 
            this.dsBaseDatos.DataSetName = "dsBaseDatos";
            this.dsBaseDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtAmbientesBindingSource
            // 
            this.dtAmbientesBindingSource.DataMember = "dtAmbientes";
            this.dtAmbientesBindingSource.DataSource = this.dsBaseDatos;
            // 
            // dtServiciosBindingSource
            // 
            this.dtServiciosBindingSource.DataMember = "dtServicios";
            this.dtServiciosBindingSource.DataSource = this.dsBaseDatos;
            // 
            // dtCatProductosBindingSource
            // 
            this.dtCatProductosBindingSource.DataMember = "dtCatProductos";
            this.dtCatProductosBindingSource.DataSource = this.dsBaseDatos;
            // 
            // dtReservacionesBindingSource
            // 
            this.dtReservacionesBindingSource.DataMember = "dtReservaciones";
            this.dtReservacionesBindingSource.DataSource = this.dsBaseDatos;
            // 
            // dtClientesBindingSource
            // 
            this.dtClientesBindingSource.DataMember = "dtClientes";
            this.dtClientesBindingSource.DataSource = this.dsBaseDatos;
            // 
            // dtClientesTA
            // 
            this.dtClientesTA.ClearBeforeFill = true;
            // 
            // dtReservacionesTA
            // 
            this.dtReservacionesTA.ClearBeforeFill = true;
            // 
            // dtCatProductosTA
            // 
            this.dtCatProductosTA.ClearBeforeFill = true;
            // 
            // dtAmbientesTA
            // 
            this.dtAmbientesTA.ClearBeforeFill = true;
            // 
            // dtServiciosTA
            // 
            this.dtServiciosTA.ClearBeforeFill = true;
            // 
            // dtDocumentosTA
            // 
            this.dtDocumentosTA.ClearBeforeFill = true;
            // 
            // dtFacturasBindingSource
            // 
            this.dtFacturasBindingSource.DataMember = "dtFacturas";
            this.dtFacturasBindingSource.DataSource = this.dsBaseDatos;
            // 
            // dtFacturasTA
            // 
            this.dtFacturasTA.ClearBeforeFill = true;
            // 
            // rvReporteador
            // 
            this.rvReporteador.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDocumentos";
            reportDataSource1.Value = this.dtDocumentosBindingSource;
            this.rvReporteador.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpDocumentos.rdlc";
            this.rvReporteador.Location = new System.Drawing.Point(0, 0);
            this.rvReporteador.Name = "rvReporteador";
            this.rvReporteador.ShowBackButton = false;
            this.rvReporteador.ShowFindControls = false;
            this.rvReporteador.Size = new System.Drawing.Size(784, 561);
            this.rvReporteador.TabIndex = 4;
            // 
            // wfReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rvReporteador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "wfReportes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wfReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBaseDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAmbientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCatProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReservacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dtClientesBindingSource;
        private dsBaseDatos dsBaseDatos;
        private dsBaseDatosTableAdapters.dtClientesTA dtClientesTA;
        private System.Windows.Forms.BindingSource dtReservacionesBindingSource;
        private dsBaseDatosTableAdapters.dtReservacionesTA dtReservacionesTA;
        private System.Windows.Forms.BindingSource dtCatProductosBindingSource;
        private dsBaseDatosTableAdapters.dtCatProductosTA dtCatProductosTA;
        private System.Windows.Forms.BindingSource dtAmbientesBindingSource;
        private dsBaseDatosTableAdapters.dtAmbientesTA dtAmbientesTA;
        private System.Windows.Forms.BindingSource dtServiciosBindingSource;
        private dsBaseDatosTableAdapters.dtServiciosTA dtServiciosTA;
        private System.Windows.Forms.BindingSource dtDocumentosBindingSource;
        private dsBaseDatosTableAdapters.dsDocumentosTA dtDocumentosTA;
        private System.Windows.Forms.BindingSource dtFacturasBindingSource;
        private dsBaseDatosTableAdapters.dtFacturasTA dtFacturasTA;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporteador;
    }
}