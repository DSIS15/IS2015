namespace Financiero
{
    partial class wfEstadoCuentaBanco
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
            this.navegador1 = new Navegador.Navegador();
            this.lblCodEstcta = new System.Windows.Forms.Label();
            this.lblCodctabco = new System.Windows.Forms.Label();
            this.lblMesEstcta = new System.Windows.Forms.Label();
            this.lblAnioEstcta = new System.Windows.Forms.Label();
            this.lblUbicEstcta = new System.Windows.Forms.Label();
            this.lblEstadoEstcta = new System.Windows.Forms.Label();
            this.txtCodEstcta = new System.Windows.Forms.TextBox();
            this.txtCodctabco = new System.Windows.Forms.TextBox();
            this.txtMesEstcta = new System.Windows.Forms.TextBox();
            this.txtAnioEstcta = new System.Windows.Forms.TextBox();
            this.txtUbicEstcta = new System.Windows.Forms.TextBox();
            this.txtEstadoEstcta = new System.Windows.Forms.TextBox();
            this.cboEstadoEstcta = new System.Windows.Forms.ComboBox();
            this.ofdUbic = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = null;
            this.navegador1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(614, 55);
            this.navegador1.sNombreTabla = "tabm_estadocuenta";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblCodEstcta
            // 
            this.lblCodEstcta.AutoSize = true;
            this.lblCodEstcta.Location = new System.Drawing.Point(12, 73);
            this.lblCodEstcta.Name = "lblCodEstcta";
            this.lblCodEstcta.Size = new System.Drawing.Size(52, 17);
            this.lblCodEstcta.TabIndex = 1;
            this.lblCodEstcta.Text = "Codigo";
            // 
            // lblCodctabco
            // 
            this.lblCodctabco.AutoSize = true;
            this.lblCodctabco.Location = new System.Drawing.Point(394, 73);
            this.lblCodctabco.Name = "lblCodctabco";
            this.lblCodctabco.Size = new System.Drawing.Size(52, 17);
            this.lblCodctabco.TabIndex = 2;
            this.lblCodctabco.Text = "Cuenta";
            // 
            // lblMesEstcta
            // 
            this.lblMesEstcta.AutoSize = true;
            this.lblMesEstcta.Location = new System.Drawing.Point(12, 101);
            this.lblMesEstcta.Name = "lblMesEstcta";
            this.lblMesEstcta.Size = new System.Drawing.Size(32, 17);
            this.lblMesEstcta.TabIndex = 3;
            this.lblMesEstcta.Text = "Mes";
            // 
            // lblAnioEstcta
            // 
            this.lblAnioEstcta.AutoSize = true;
            this.lblAnioEstcta.Location = new System.Drawing.Point(394, 101);
            this.lblAnioEstcta.Name = "lblAnioEstcta";
            this.lblAnioEstcta.Size = new System.Drawing.Size(32, 17);
            this.lblAnioEstcta.TabIndex = 4;
            this.lblAnioEstcta.Text = "Año";
            // 
            // lblUbicEstcta
            // 
            this.lblUbicEstcta.AutoSize = true;
            this.lblUbicEstcta.Location = new System.Drawing.Point(12, 129);
            this.lblUbicEstcta.Name = "lblUbicEstcta";
            this.lblUbicEstcta.Size = new System.Drawing.Size(69, 17);
            this.lblUbicEstcta.TabIndex = 5;
            this.lblUbicEstcta.Text = "Ubicacion";
            // 
            // lblEstadoEstcta
            // 
            this.lblEstadoEstcta.AutoSize = true;
            this.lblEstadoEstcta.Location = new System.Drawing.Point(394, 129);
            this.lblEstadoEstcta.Name = "lblEstadoEstcta";
            this.lblEstadoEstcta.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoEstcta.TabIndex = 6;
            this.lblEstadoEstcta.Text = "Estado";
            // 
            // txtCodEstcta
            // 
            this.txtCodEstcta.Location = new System.Drawing.Point(87, 70);
            this.txtCodEstcta.MaxLength = 7;
            this.txtCodEstcta.Name = "txtCodEstcta";
            this.txtCodEstcta.Size = new System.Drawing.Size(150, 22);
            this.txtCodEstcta.TabIndex = 14;
            this.txtCodEstcta.Tag = "cod_estcta";
            this.txtCodEstcta.EnabledChanged += new System.EventHandler(this.txtCodEstcta_EnabledChanged);
            this.txtCodEstcta.TextChanged += new System.EventHandler(this.txtCodEstcta_TextChanged);
            // 
            // txtCodctabco
            // 
            this.txtCodctabco.Location = new System.Drawing.Point(452, 70);
            this.txtCodctabco.MaxLength = 7;
            this.txtCodctabco.Name = "txtCodctabco";
            this.txtCodctabco.Size = new System.Drawing.Size(150, 22);
            this.txtCodctabco.TabIndex = 15;
            this.txtCodctabco.Tag = "cod_ctabco";
            this.txtCodctabco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodctabco_KeyPress);
            // 
            // txtMesEstcta
            // 
            this.txtMesEstcta.Location = new System.Drawing.Point(87, 98);
            this.txtMesEstcta.MaxLength = 25;
            this.txtMesEstcta.Name = "txtMesEstcta";
            this.txtMesEstcta.Size = new System.Drawing.Size(150, 22);
            this.txtMesEstcta.TabIndex = 16;
            this.txtMesEstcta.Tag = "mes_estcta";
            this.txtMesEstcta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesEstcta_KeyPress);
            // 
            // txtAnioEstcta
            // 
            this.txtAnioEstcta.Location = new System.Drawing.Point(452, 98);
            this.txtAnioEstcta.MaxLength = 25;
            this.txtAnioEstcta.Name = "txtAnioEstcta";
            this.txtAnioEstcta.Size = new System.Drawing.Size(150, 22);
            this.txtAnioEstcta.TabIndex = 17;
            this.txtAnioEstcta.Tag = "anio_estcta";
            this.txtAnioEstcta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioEstcta_KeyPress);
            // 
            // txtUbicEstcta
            // 
            this.txtUbicEstcta.Location = new System.Drawing.Point(87, 126);
            this.txtUbicEstcta.MaxLength = 300;
            this.txtUbicEstcta.Name = "txtUbicEstcta";
            this.txtUbicEstcta.Size = new System.Drawing.Size(250, 22);
            this.txtUbicEstcta.TabIndex = 18;
            this.txtUbicEstcta.Tag = "ubic_estcta";
            this.txtUbicEstcta.Enter += new System.EventHandler(this.txtUbicEstcta_Enter);
            // 
            // txtEstadoEstcta
            // 
            this.txtEstadoEstcta.Location = new System.Drawing.Point(366, 126);
            this.txtEstadoEstcta.MaxLength = 1;
            this.txtEstadoEstcta.Name = "txtEstadoEstcta";
            this.txtEstadoEstcta.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoEstcta.TabIndex = 20;
            this.txtEstadoEstcta.Tag = "estado_estcta";
            this.txtEstadoEstcta.Visible = false;
            this.txtEstadoEstcta.EnabledChanged += new System.EventHandler(this.txtEstadoEstcta_EnabledChanged);
            this.txtEstadoEstcta.TextChanged += new System.EventHandler(this.txtEstadoEstcta_TextChanged);
            // 
            // cboEstadoEstcta
            // 
            this.cboEstadoEstcta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoEstcta.FormattingEnabled = true;
            this.cboEstadoEstcta.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoEstcta.Location = new System.Drawing.Point(452, 126);
            this.cboEstadoEstcta.Name = "cboEstadoEstcta";
            this.cboEstadoEstcta.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoEstcta.TabIndex = 19;
            this.cboEstadoEstcta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoEstcta_SelectedIndexChanged);
            // 
            // wfEstadoCuentaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 161);
            this.Controls.Add(this.cboEstadoEstcta);
            this.Controls.Add(this.txtEstadoEstcta);
            this.Controls.Add(this.txtUbicEstcta);
            this.Controls.Add(this.txtAnioEstcta);
            this.Controls.Add(this.txtMesEstcta);
            this.Controls.Add(this.txtCodctabco);
            this.Controls.Add(this.txtCodEstcta);
            this.Controls.Add(this.lblEstadoEstcta);
            this.Controls.Add(this.lblUbicEstcta);
            this.Controls.Add(this.lblAnioEstcta);
            this.Controls.Add(this.lblMesEstcta);
            this.Controls.Add(this.lblCodctabco);
            this.Controls.Add(this.lblCodEstcta);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEstadoCuentaBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Estados de Cuenta";
            this.Load += new System.EventHandler(this.wfEstadoCuentaBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodEstcta;
        private System.Windows.Forms.Label lblCodctabco;
        private System.Windows.Forms.Label lblMesEstcta;
        private System.Windows.Forms.Label lblAnioEstcta;
        private System.Windows.Forms.Label lblUbicEstcta;
        private System.Windows.Forms.Label lblEstadoEstcta;
        private System.Windows.Forms.TextBox txtCodEstcta;
        private System.Windows.Forms.TextBox txtCodctabco;
        private System.Windows.Forms.TextBox txtMesEstcta;
        private System.Windows.Forms.TextBox txtAnioEstcta;
        private System.Windows.Forms.TextBox txtUbicEstcta;
        private System.Windows.Forms.TextBox txtEstadoEstcta;
        private System.Windows.Forms.ComboBox cboEstadoEstcta;
        private System.Windows.Forms.OpenFileDialog ofdUbic;
    }
}