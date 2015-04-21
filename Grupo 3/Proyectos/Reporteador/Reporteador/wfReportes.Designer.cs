namespace Reporteador
{
    partial class wfReportes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rpReporteador = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsBaseDatosSCF = new Reporteador.dsBaseDatosSCF();
            this.dtUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtUsuariosTA = new Reporteador.dsBaseDatosSCFTableAdapters.dtUsuariosTA();
            this.dtPerfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPerfilesTA = new Reporteador.dsBaseDatosSCFTableAdapters.dtPerfilesTA();
            ((System.ComponentModel.ISupportInitialize)(this.dsBaseDatosSCF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPerfilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpReporteador
            // 
            this.rpReporteador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.ReportePrincipal.rdlc";
            this.rpReporteador.Location = new System.Drawing.Point(0, 0);
            this.rpReporteador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rpReporteador.Name = "rpReporteador";
            this.rpReporteador.ShowBackButton = false;
            this.rpReporteador.ShowContextMenu = false;
            this.rpReporteador.ShowCredentialPrompts = false;
            this.rpReporteador.ShowDocumentMapButton = false;
            this.rpReporteador.ShowExportButton = false;
            this.rpReporteador.ShowFindControls = false;
            this.rpReporteador.ShowParameterPrompts = false;
            this.rpReporteador.ShowPromptAreaButton = false;
            this.rpReporteador.ShowStopButton = false;
            this.rpReporteador.Size = new System.Drawing.Size(734, 561);
            this.rpReporteador.TabIndex = 0;
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
            // dtPerfilesBindingSource
            // 
            this.dtPerfilesBindingSource.DataMember = "dtPerfiles";
            this.dtPerfilesBindingSource.DataSource = this.dsBaseDatosSCF;
            // 
            // dtPerfilesTA
            // 
            this.dtPerfilesTA.ClearBeforeFill = true;
            // 
            // wfReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.rpReporteador);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "wfReportes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBaseDatosSCF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPerfilesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpReporteador;
        private System.Windows.Forms.BindingSource dtUsuariosBindingSource;
        private dsBaseDatosSCF dsBaseDatosSCF;
        private dsBaseDatosSCFTableAdapters.dtUsuariosTA dtUsuariosTA;
        private System.Windows.Forms.BindingSource dtPerfilesBindingSource;
        private dsBaseDatosSCFTableAdapters.dtPerfilesTA dtPerfilesTA;
    }
}

