namespace Operaciones
{
    partial class wfCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCuentas));
            this.navegador1 = new Navegador.Navegador();
            this.cboEstadoCta = new System.Windows.Forms.ComboBox();
            this.txtEstadoCta = new System.Windows.Forms.TextBox();
            this.lblEstadoCta = new System.Windows.Forms.Label();
            this.txtNombreCta = new System.Windows.Forms.TextBox();
            this.lblNombreCta = new System.Windows.Forms.Label();
            this.txtCodigoCta = new System.Windows.Forms.TextBox();
            this.lblCodigoCta = new System.Windows.Forms.Label();
            this.txtNomencCta = new System.Windows.Forms.TextBox();
            this.lblNomencCta = new System.Windows.Forms.Label();
            this.lblClasificacionCta = new System.Windows.Forms.Label();
            this.txtCodigoClf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(617, 55);
            this.navegador1.sNombreTabla = "tabm_cuenta";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "";
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            // 
            // cboEstadoCta
            // 
            this.cboEstadoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCta.FormattingEnabled = true;
            this.cboEstadoCta.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoCta.Location = new System.Drawing.Point(455, 126);
            this.cboEstadoCta.Name = "cboEstadoCta";
            this.cboEstadoCta.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoCta.TabIndex = 5;
            this.cboEstadoCta.Tag = "";
            this.cboEstadoCta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCuenta_SelectedIndexChanged);
            // 
            // txtEstadoCta
            // 
            this.txtEstadoCta.Location = new System.Drawing.Point(362, 126);
            this.txtEstadoCta.Name = "txtEstadoCta";
            this.txtEstadoCta.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoCta.TabIndex = 16;
            this.txtEstadoCta.Tag = "estado_cta";
            this.txtEstadoCta.Visible = false;
            this.txtEstadoCta.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstadoCta
            // 
            this.lblEstadoCta.AutoSize = true;
            this.lblEstadoCta.Location = new System.Drawing.Point(393, 129);
            this.lblEstadoCta.Name = "lblEstadoCta";
            this.lblEstadoCta.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoCta.TabIndex = 5;
            this.lblEstadoCta.Text = "Estado";
            // 
            // txtNombreCta
            // 
            this.txtNombreCta.Location = new System.Drawing.Point(455, 98);
            this.txtNombreCta.Name = "txtNombreCta";
            this.txtNombreCta.Size = new System.Drawing.Size(150, 22);
            this.txtNombreCta.TabIndex = 3;
            this.txtNombreCta.Tag = "nombre_cta";
            this.txtNombreCta.TextChanged += new System.EventHandler(this.txtNombreCta_TextChanged);
            // 
            // lblNombreCta
            // 
            this.lblNombreCta.AutoSize = true;
            this.lblNombreCta.Location = new System.Drawing.Point(393, 101);
            this.lblNombreCta.Name = "lblNombreCta";
            this.lblNombreCta.Size = new System.Drawing.Size(56, 17);
            this.lblNombreCta.TabIndex = 3;
            this.lblNombreCta.Text = "Nombre";
            // 
            // txtCodigoCta
            // 
            this.txtCodigoCta.Location = new System.Drawing.Point(112, 70);
            this.txtCodigoCta.Name = "txtCodigoCta";
            this.txtCodigoCta.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoCta.TabIndex = 1;
            this.txtCodigoCta.Tag = "cod_cta";
            this.txtCodigoCta.TextChanged += new System.EventHandler(this.txtCodigoCta_TextChanged);
            // 
            // lblCodigoCta
            // 
            this.lblCodigoCta.AutoSize = true;
            this.lblCodigoCta.Location = new System.Drawing.Point(12, 73);
            this.lblCodigoCta.Name = "lblCodigoCta";
            this.lblCodigoCta.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoCta.TabIndex = 1;
            this.lblCodigoCta.Text = "Código";
            // 
            // txtNomencCta
            // 
            this.txtNomencCta.Location = new System.Drawing.Point(112, 126);
            this.txtNomencCta.Name = "txtNomencCta";
            this.txtNomencCta.Size = new System.Drawing.Size(150, 22);
            this.txtNomencCta.TabIndex = 4;
            this.txtNomencCta.Tag = "nomenc_cta";
            this.txtNomencCta.TextChanged += new System.EventHandler(this.txtNomencCta_TextChanged);
            // 
            // lblNomencCta
            // 
            this.lblNomencCta.AutoSize = true;
            this.lblNomencCta.Location = new System.Drawing.Point(12, 129);
            this.lblNomencCta.Name = "lblNomencCta";
            this.lblNomencCta.Size = new System.Drawing.Size(94, 17);
            this.lblNomencCta.TabIndex = 4;
            this.lblNomencCta.Text = "Nomenclatura";
            // 
            // lblClasificacionCta
            // 
            this.lblClasificacionCta.AutoSize = true;
            this.lblClasificacionCta.Location = new System.Drawing.Point(12, 101);
            this.lblClasificacionCta.Name = "lblClasificacionCta";
            this.lblClasificacionCta.Size = new System.Drawing.Size(85, 17);
            this.lblClasificacionCta.TabIndex = 2;
            this.lblClasificacionCta.Text = "Clasificación";
            // 
            // txtCodigoClf
            // 
            this.txtCodigoClf.Location = new System.Drawing.Point(112, 98);
            this.txtCodigoClf.Name = "txtCodigoClf";
            this.txtCodigoClf.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoClf.TabIndex = 2;
            this.txtCodigoClf.Tag = "cod_clf";
            this.txtCodigoClf.Enter += new System.EventHandler(this.txtCodigoClf_Enter);
            // 
            // wfCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 158);
            this.Controls.Add(this.txtCodigoClf);
            this.Controls.Add(this.lblClasificacionCta);
            this.Controls.Add(this.txtNomencCta);
            this.Controls.Add(this.lblNomencCta);
            this.Controls.Add(this.cboEstadoCta);
            this.Controls.Add(this.txtEstadoCta);
            this.Controls.Add(this.lblEstadoCta);
            this.Controls.Add(this.txtNombreCta);
            this.Controls.Add(this.lblNombreCta);
            this.Controls.Add(this.txtCodigoCta);
            this.Controls.Add(this.lblCodigoCta);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCuentas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.wfCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cboEstadoCta;
        private System.Windows.Forms.TextBox txtEstadoCta;
        private System.Windows.Forms.Label lblEstadoCta;
        private System.Windows.Forms.TextBox txtNombreCta;
        private System.Windows.Forms.Label lblNombreCta;
        private System.Windows.Forms.TextBox txtCodigoCta;
        private System.Windows.Forms.Label lblCodigoCta;
        private System.Windows.Forms.TextBox txtNomencCta;
        private System.Windows.Forms.Label lblNomencCta;
        private System.Windows.Forms.Label lblClasificacionCta;
        private System.Windows.Forms.TextBox txtCodigoClf;
    }
}