namespace Operaciones
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
            this.txtCodTcta = new System.Windows.Forms.TextBox();
            this.txtNombreTcta = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripTcta = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtEstadoTcta = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstadoTcta = new System.Windows.Forms.ComboBox();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 73);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodTcta
            // 
            this.txtCodTcta.Enabled = false;
            this.txtCodTcta.Location = new System.Drawing.Point(74, 70);
            this.txtCodTcta.MaxLength = 7;
            this.txtCodTcta.Name = "txtCodTcta";
            this.txtCodTcta.Size = new System.Drawing.Size(150, 22);
            this.txtCodTcta.TabIndex = 1;
            this.txtCodTcta.Tag = "cod_tcta";
            this.txtCodTcta.EnabledChanged += new System.EventHandler(this.txtCodTcta_EnabledChanged);
            this.txtCodTcta.TextChanged += new System.EventHandler(this.txtCodTcta_TextChanged);
            // 
            // txtNombreTcta
            // 
            this.txtNombreTcta.Location = new System.Drawing.Point(74, 98);
            this.txtNombreTcta.MaxLength = 25;
            this.txtNombreTcta.Name = "txtNombreTcta";
            this.txtNombreTcta.Size = new System.Drawing.Size(150, 22);
            this.txtNombreTcta.TabIndex = 2;
            this.txtNombreTcta.Tag = "nombre_tcta";
            this.txtNombreTcta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDescripTcta
            // 
            this.txtDescripTcta.Location = new System.Drawing.Point(452, 98);
            this.txtDescripTcta.MaxLength = 100;
            this.txtDescripTcta.Name = "txtDescripTcta";
            this.txtDescripTcta.Size = new System.Drawing.Size(150, 22);
            this.txtDescripTcta.TabIndex = 3;
            this.txtDescripTcta.Tag = "descrip_tcta";
            this.txtDescripTcta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(367, 101);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 17);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtEstadoTcta
            // 
            this.txtEstadoTcta.Location = new System.Drawing.Point(230, 126);
            this.txtEstadoTcta.MaxLength = 1;
            this.txtEstadoTcta.Name = "txtEstadoTcta";
            this.txtEstadoTcta.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoTcta.TabIndex = 18;
            this.txtEstadoTcta.Tag = "estado_tcta";
            this.txtEstadoTcta.Visible = false;
            this.txtEstadoTcta.EnabledChanged += new System.EventHandler(this.txtEstadoTcta_EnabledChanged);
            this.txtEstadoTcta.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstadoTcta
            // 
            this.cboEstadoTcta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoTcta.FormattingEnabled = true;
            this.cboEstadoTcta.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoTcta.Location = new System.Drawing.Point(74, 126);
            this.cboEstadoTcta.Name = "cboEstadoTcta";
            this.cboEstadoTcta.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoTcta.TabIndex = 4;
            this.cboEstadoTcta.Tag = "";
            this.cboEstadoTcta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoTipoC_SelectedIndexChanged);
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
            this.navegador1.sNombreTabla = "tabm_tcuenta";
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
            this.ClientSize = new System.Drawing.Size(614, 161);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cboEstadoTcta);
            this.Controls.Add(this.txtEstadoTcta);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtDescripTcta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombreTcta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodTcta);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoCuenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tipos de Cuentas";
            this.Load += new System.EventHandler(this.wfTipoCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodTcta;
        private System.Windows.Forms.TextBox txtNombreTcta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripTcta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtEstadoTcta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstadoTcta;
        private Navegador.Navegador navegador1;
    }
}