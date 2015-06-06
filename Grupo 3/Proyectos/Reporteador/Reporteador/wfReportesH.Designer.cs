namespace Reporteador
{
    partial class wfReportesH
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
            this.rpReporteador = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsBaseDatosSCF = new Reporteador.dsBaseDatosSCF();
            this.dtUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtUsuariosTA = new Reporteador.dsBaseDatosSCFTableAdapters.dtUsuariosTA();
            this.dtCompraVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCompraVentaTA = new Reporteador.dsBaseDatosSCFTableAdapters.dtCompraVentaTA();
            ((System.ComponentModel.ISupportInitialize)(this.dsBaseDatosSCF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompraVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpReporteador
            // 
            this.rpReporteador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.ReportePrincipalH.rdlc";
            this.rpReporteador.Location = new System.Drawing.Point(0, 0);
            this.rpReporteador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rpReporteador.Name = "rpReporteador";
            this.rpReporteador.ShowBackButton = false;
            this.rpReporteador.ShowFindControls = false;
            this.rpReporteador.ShowParameterPrompts = false;
            this.rpReporteador.ShowPromptAreaButton = false;
            this.rpReporteador.Size = new System.Drawing.Size(734, 561);
            this.rpReporteador.TabIndex = 1;
            // 
            // dsBaseDatosSCF
            // 
            this.dsBaseDatosSCF.DataSetName = "dsBaseDatosSCF";
            this.dsBaseDatosSCF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtUsuariosBindingSource
            // 
            this.dtUsuariosBindingSource.DataMember = "dtUsuarios";
            this.dtUsuariosBindingSource.DataSource = this.dsBaseDatosSCF;
            // 
            // dtUsuariosTA
            // 
            this.dtUsuariosTA.ClearBeforeFill = true;
            // 
            // dtCompraVentaBindingSource
            // 
            this.dtCompraVentaBindingSource.DataMember = "dtCompraVenta";
            this.dtCompraVentaBindingSource.DataSource = this.dsBaseDatosSCF;
            // 
            // dtCompraVentaTA
            // 
            this.dtCompraVentaTA.ClearBeforeFill = true;
            // 
            // wfReportesH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.rpReporteador);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "wfReportesH";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wfReportesH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBaseDatosSCF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompraVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpReporteador;
        private System.Windows.Forms.BindingSource dtUsuariosBindingSource;
        private dsBaseDatosSCF dsBaseDatosSCF;
        private dsBaseDatosSCFTableAdapters.dtUsuariosTA dtUsuariosTA;
        private System.Windows.Forms.BindingSource dtCompraVentaBindingSource;
        private dsBaseDatosSCFTableAdapters.dtCompraVentaTA dtCompraVentaTA;
    }
}