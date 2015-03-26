namespace Contable
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDescripCta = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodTCta = new System.Windows.Forms.TextBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtCodCta = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCuentaCta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
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
            this.navegador1.Size = new System.Drawing.Size(614, 55);
            this.navegador1.sNombreTabla = "tabm_cuenta";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "";
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // cboEstadoCta
            // 
            this.cboEstadoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCta.FormattingEnabled = true;
            this.cboEstadoCta.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoCta.Location = new System.Drawing.Point(452, 126);
            this.cboEstadoCta.Name = "cboEstadoCta";
            this.cboEstadoCta.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoCta.TabIndex = 18;
            this.cboEstadoCta.Tag = "";
            this.cboEstadoCta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCta_SelectedIndexChanged);
            // 
            // txtEstadoCta
            // 
            this.txtEstadoCta.Location = new System.Drawing.Point(359, 126);
            this.txtEstadoCta.MaxLength = 1;
            this.txtEstadoCta.Name = "txtEstadoCta";
            this.txtEstadoCta.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoCta.TabIndex = 19;
            this.txtEstadoCta.Tag = "estado_cta";
            this.txtEstadoCta.Visible = false;
            this.txtEstadoCta.EnabledChanged += new System.EventHandler(this.txtEstadoCta_EnabledChanged);
            this.txtEstadoCta.TextChanged += new System.EventHandler(this.txtEstadoCta_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(390, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // txtDescripCta
            // 
            this.txtDescripCta.Location = new System.Drawing.Point(97, 126);
            this.txtDescripCta.MaxLength = 100;
            this.txtDescripCta.Name = "txtDescripCta";
            this.txtDescripCta.Size = new System.Drawing.Size(150, 22);
            this.txtDescripCta.TabIndex = 17;
            this.txtDescripCta.Tag = "descrip_cta";
            this.txtDescripCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescrip_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 17);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtCodTCta
            // 
            this.txtCodTCta.Location = new System.Drawing.Point(97, 98);
            this.txtCodTCta.MaxLength = 7;
            this.txtCodTCta.Name = "txtCodTCta";
            this.txtCodTCta.Size = new System.Drawing.Size(150, 22);
            this.txtCodTCta.TabIndex = 15;
            this.txtCodTCta.Tag = "cod_tcta";
            this.txtCodTCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodTCta_KeyPress);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(12, 101);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(79, 17);
            this.lblTipoCuenta.TabIndex = 7;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // txtCodCta
            // 
            this.txtCodCta.Location = new System.Drawing.Point(97, 70);
            this.txtCodCta.MaxLength = 7;
            this.txtCodCta.Name = "txtCodCta";
            this.txtCodCta.Size = new System.Drawing.Size(150, 22);
            this.txtCodCta.TabIndex = 14;
            this.txtCodCta.Tag = "cod_cta";
            this.txtCodCta.EnabledChanged += new System.EventHandler(this.txtCodCta_EnabledChanged);
            this.txtCodCta.TextChanged += new System.EventHandler(this.txtCodCta_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 73);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCuentaCta
            // 
            this.txtCuentaCta.Location = new System.Drawing.Point(452, 98);
            this.txtCuentaCta.MaxLength = 25;
            this.txtCuentaCta.Name = "txtCuentaCta";
            this.txtCuentaCta.Size = new System.Drawing.Size(150, 22);
            this.txtCuentaCta.TabIndex = 16;
            this.txtCuentaCta.Tag = "cuenta_cta";
            this.txtCuentaCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuenta_KeyPress);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(390, 101);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(52, 17);
            this.lblCuenta.TabIndex = 8;
            this.lblCuenta.Text = "Cuenta";
            // 
            // wfCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 161);
            this.Controls.Add(this.txtCuentaCta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.cboEstadoCta);
            this.Controls.Add(this.txtEstadoCta);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtDescripCta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtCodTCta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.txtCodCta);
            this.Controls.Add(this.lblCodigo);
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
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDescripCta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodTCta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.TextBox txtCodCta;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCuentaCta;
        private System.Windows.Forms.Label lblCuenta;
    }
}