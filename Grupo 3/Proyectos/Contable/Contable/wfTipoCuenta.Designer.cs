namespace Contable
{
    partial class wfTipoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfTipoCuenta));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo_tcuenta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtEstadoTipoC = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstadoTipoC = new System.Windows.Forms.ComboBox();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 73);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo_tcuenta
            // 
            this.txtCodigo_tcuenta.Enabled = false;
            this.txtCodigo_tcuenta.Location = new System.Drawing.Point(97, 70);
            this.txtCodigo_tcuenta.Name = "txtCodigo_tcuenta";
            this.txtCodigo_tcuenta.Size = new System.Drawing.Size(150, 22);
            this.txtCodigo_tcuenta.TabIndex = 14;
            this.txtCodigo_tcuenta.Tag = "";
            this.txtCodigo_tcuenta.EnabledChanged += new System.EventHandler(this.txtCodigo_EnabledChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(455, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Tag = "";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(393, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 22);
            this.txtDescripcion.TabIndex = 16;
            this.txtDescripcion.Tag = "";
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 101);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 17);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtEstadoTipoC
            // 
            this.txtEstadoTipoC.Location = new System.Drawing.Point(362, 95);
            this.txtEstadoTipoC.Name = "txtEstadoTipoC";
            this.txtEstadoTipoC.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoTipoC.TabIndex = 7;
            this.txtEstadoTipoC.Visible = false;
            this.txtEstadoTipoC.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(393, 98);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstadoTipoC
            // 
            this.cboEstadoTipoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoTipoC.FormattingEnabled = true;
            this.cboEstadoTipoC.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoTipoC.Location = new System.Drawing.Point(455, 95);
            this.cboEstadoTipoC.Name = "cboEstadoTipoC";
            this.cboEstadoTipoC.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoTipoC.TabIndex = 17;
            this.cboEstadoTipoC.Tag = "";
            this.cboEstadoTipoC.SelectedIndexChanged += new System.EventHandler(this.cboEstadoTipoC_SelectedIndexChanged);
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
            this.navegador1.sNombreTabla = "";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "";
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // wfTipoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 130);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cboEstadoTipoC);
            this.Controls.Add(this.txtEstadoTipoC);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo_tcuenta);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoCuenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tipo de Cuenta";
            this.Load += new System.EventHandler(this.wfTipoCuenta_Load);
            this.EnabledChanged += new System.EventHandler(this.wfTipoCuenta_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo_tcuenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtEstadoTipoC;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstadoTipoC;
        private Navegador.Navegador navegador1;
    }
}