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
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.lblTipoCuentaCta = new System.Windows.Forms.Label();
            this.txtCodigoCta = new System.Windows.Forms.TextBox();
            this.lblCodigoCta = new System.Windows.Forms.Label();
            this.txtDescripcionCta = new System.Windows.Forms.TextBox();
            this.lblDescripcionCta = new System.Windows.Forms.Label();
            this.txtCuentaCta = new System.Windows.Forms.TextBox();
            this.lblCuentaCta = new System.Windows.Forms.Label();
            this.lblClasificacionCta = new System.Windows.Forms.Label();
            this.cboClasificionCta = new System.Windows.Forms.ComboBox();
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
            this.txtEstadoCta.Location = new System.Drawing.Point(366, 126);
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
            this.lblEstadoCta.Location = new System.Drawing.Point(397, 129);
            this.lblEstadoCta.Name = "lblEstadoCta";
            this.lblEstadoCta.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoCta.TabIndex = 10;
            this.lblEstadoCta.Text = "Estado";
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.Location = new System.Drawing.Point(97, 98);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Size = new System.Drawing.Size(150, 22);
            this.txtTipoCuenta.TabIndex = 2;
            this.txtTipoCuenta.Tag = "cod_tcta";
            this.txtTipoCuenta.Enter += new System.EventHandler(this.txtTipoCuenta_Enter);
            // 
            // lblTipoCuentaCta
            // 
            this.lblTipoCuentaCta.AutoSize = true;
            this.lblTipoCuentaCta.Location = new System.Drawing.Point(12, 101);
            this.lblTipoCuentaCta.Name = "lblTipoCuentaCta";
            this.lblTipoCuentaCta.Size = new System.Drawing.Size(79, 17);
            this.lblTipoCuentaCta.TabIndex = 2;
            this.lblTipoCuentaCta.Text = "Tipo Cuenta";
            // 
            // txtCodigoCta
            // 
            this.txtCodigoCta.Location = new System.Drawing.Point(97, 70);
            this.txtCodigoCta.Name = "txtCodigoCta";
            this.txtCodigoCta.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoCta.TabIndex = 1;
            this.txtCodigoCta.Tag = "cod_cta";
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
            // txtDescripcionCta
            // 
            this.txtDescripcionCta.Location = new System.Drawing.Point(97, 126);
            this.txtDescripcionCta.Name = "txtDescripcionCta";
            this.txtDescripcionCta.Size = new System.Drawing.Size(150, 22);
            this.txtDescripcionCta.TabIndex = 4;
            this.txtDescripcionCta.Tag = "descrip_cta";
            // 
            // lblDescripcionCta
            // 
            this.lblDescripcionCta.AutoSize = true;
            this.lblDescripcionCta.Location = new System.Drawing.Point(12, 129);
            this.lblDescripcionCta.Name = "lblDescripcionCta";
            this.lblDescripcionCta.Size = new System.Drawing.Size(79, 17);
            this.lblDescripcionCta.TabIndex = 31;
            this.lblDescripcionCta.Text = "Descripción";
            // 
            // txtCuentaCta
            // 
            this.txtCuentaCta.Location = new System.Drawing.Point(455, 98);
            this.txtCuentaCta.Name = "txtCuentaCta";
            this.txtCuentaCta.Size = new System.Drawing.Size(150, 22);
            this.txtCuentaCta.TabIndex = 3;
            this.txtCuentaCta.Tag = "cuenta_cta";
            // 
            // lblCuentaCta
            // 
            this.lblCuentaCta.AutoSize = true;
            this.lblCuentaCta.Location = new System.Drawing.Point(364, 101);
            this.lblCuentaCta.Name = "lblCuentaCta";
            this.lblCuentaCta.Size = new System.Drawing.Size(52, 17);
            this.lblCuentaCta.TabIndex = 33;
            this.lblCuentaCta.Text = "Cuenta";
            // 
            // lblClasificacionCta
            // 
            this.lblClasificacionCta.AutoSize = true;
            this.lblClasificacionCta.Location = new System.Drawing.Point(364, 73);
            this.lblClasificacionCta.Name = "lblClasificacionCta";
            this.lblClasificacionCta.Size = new System.Drawing.Size(85, 17);
            this.lblClasificacionCta.TabIndex = 35;
            this.lblClasificacionCta.Text = "Clasificación";
            // 
            // cboClasificionCta
            // 
            this.cboClasificionCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificionCta.FormattingEnabled = true;
            this.cboClasificionCta.Items.AddRange(new object[] {
            "Activo",
            "Pasivo"});
            this.cboClasificionCta.Location = new System.Drawing.Point(455, 70);
            this.cboClasificionCta.Name = "cboClasificionCta";
            this.cboClasificionCta.Size = new System.Drawing.Size(150, 25);
            this.cboClasificionCta.TabIndex = 36;
            this.cboClasificionCta.Tag = "";
            // 
            // wfCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 158);
            this.Controls.Add(this.cboClasificionCta);
            this.Controls.Add(this.lblClasificacionCta);
            this.Controls.Add(this.txtCuentaCta);
            this.Controls.Add(this.lblCuentaCta);
            this.Controls.Add(this.txtDescripcionCta);
            this.Controls.Add(this.lblDescripcionCta);
            this.Controls.Add(this.cboEstadoCta);
            this.Controls.Add(this.txtEstadoCta);
            this.Controls.Add(this.lblEstadoCta);
            this.Controls.Add(this.txtTipoCuenta);
            this.Controls.Add(this.lblTipoCuentaCta);
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
        private System.Windows.Forms.TextBox txtTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuentaCta;
        private System.Windows.Forms.TextBox txtCodigoCta;
        private System.Windows.Forms.Label lblCodigoCta;
        private System.Windows.Forms.TextBox txtDescripcionCta;
        private System.Windows.Forms.Label lblDescripcionCta;
        private System.Windows.Forms.TextBox txtCuentaCta;
        private System.Windows.Forms.Label lblCuentaCta;
        private System.Windows.Forms.Label lblClasificacionCta;
        private System.Windows.Forms.ComboBox cboClasificionCta;
    }
}