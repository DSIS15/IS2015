namespace Seguridad
{
    partial class wfEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEmpresas));
            this.txtCodEmpsa = new System.Windows.Forms.TextBox();
            this.lblCodEmpsa = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.txtRazsocial = new System.Windows.Forms.TextBox();
            this.lblDireEmpsa = new System.Windows.Forms.Label();
            this.lblRazsocialEmpsa = new System.Windows.Forms.Label();
            this.txtNit_empsa = new System.Windows.Forms.TextBox();
            this.txtNomcomercial_empsa = new System.Windows.Forms.TextBox();
            this.lblNitEmpsa = new System.Windows.Forms.Label();
            this.lblNomComercialEmpsa = new System.Windows.Forms.Label();
            this.txtEstadoEmpsa = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstadoEmpsa = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // txtCodEmpsa
            // 
            this.txtCodEmpsa.Enabled = false;
            this.txtCodEmpsa.Location = new System.Drawing.Point(96, 70);
            this.txtCodEmpsa.MaxLength = 7;
            this.txtCodEmpsa.Name = "txtCodEmpsa";
            this.txtCodEmpsa.Size = new System.Drawing.Size(150, 22);
            this.txtCodEmpsa.TabIndex = 14;
            this.txtCodEmpsa.Tag = "cod_empsa";
            this.txtCodEmpsa.EnabledChanged += new System.EventHandler(this.txtCodEmpsa_EnabledChanged);
            this.txtCodEmpsa.TextChanged += new System.EventHandler(this.txtCodEmpsa_TextChanged);
            // 
            // lblCodEmpsa
            // 
            this.lblCodEmpsa.AutoSize = true;
            this.lblCodEmpsa.Location = new System.Drawing.Point(12, 73);
            this.lblCodEmpsa.Name = "lblCodEmpsa";
            this.lblCodEmpsa.Size = new System.Drawing.Size(52, 17);
            this.lblCodEmpsa.TabIndex = 13;
            this.lblCodEmpsa.Text = "Codigo";
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(96, 125);
            this.txtDire.MaxLength = 50;
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(150, 22);
            this.txtDire.TabIndex = 17;
            this.txtDire.Tag = "dire_empsa";
            this.txtDire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDire_empsa_KeyPress);
            // 
            // txtRazsocial
            // 
            this.txtRazsocial.Location = new System.Drawing.Point(96, 98);
            this.txtRazsocial.MaxLength = 50;
            this.txtRazsocial.Name = "txtRazsocial";
            this.txtRazsocial.Size = new System.Drawing.Size(150, 22);
            this.txtRazsocial.TabIndex = 15;
            this.txtRazsocial.Tag = "rznsocial_empsa";
            this.txtRazsocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazsocial_empsa_KeyPress);
            // 
            // lblDireEmpsa
            // 
            this.lblDireEmpsa.AutoSize = true;
            this.lblDireEmpsa.Location = new System.Drawing.Point(12, 128);
            this.lblDireEmpsa.Name = "lblDireEmpsa";
            this.lblDireEmpsa.Size = new System.Drawing.Size(66, 17);
            this.lblDireEmpsa.TabIndex = 18;
            this.lblDireEmpsa.Text = "Dirección";
            // 
            // lblRazsocialEmpsa
            // 
            this.lblRazsocialEmpsa.AutoSize = true;
            this.lblRazsocialEmpsa.Location = new System.Drawing.Point(12, 101);
            this.lblRazsocialEmpsa.Name = "lblRazsocialEmpsa";
            this.lblRazsocialEmpsa.Size = new System.Drawing.Size(81, 17);
            this.lblRazsocialEmpsa.TabIndex = 17;
            this.lblRazsocialEmpsa.Text = "Razón social";
            // 
            // txtNit_empsa
            // 
            this.txtNit_empsa.Location = new System.Drawing.Point(452, 126);
            this.txtNit_empsa.MaxLength = 25;
            this.txtNit_empsa.Name = "txtNit_empsa";
            this.txtNit_empsa.Size = new System.Drawing.Size(150, 22);
            this.txtNit_empsa.TabIndex = 18;
            this.txtNit_empsa.Tag = "nit_empsa";
            this.txtNit_empsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_empsa_KeyPress);
            // 
            // txtNomcomercial_empsa
            // 
            this.txtNomcomercial_empsa.Location = new System.Drawing.Point(452, 98);
            this.txtNomcomercial_empsa.MaxLength = 50;
            this.txtNomcomercial_empsa.Name = "txtNomcomercial_empsa";
            this.txtNomcomercial_empsa.Size = new System.Drawing.Size(150, 22);
            this.txtNomcomercial_empsa.TabIndex = 16;
            this.txtNomcomercial_empsa.Tag = "nomcomercial_empsa";
            this.txtNomcomercial_empsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomcomercial_empsa_KeyPress);
            // 
            // lblNitEmpsa
            // 
            this.lblNitEmpsa.AutoSize = true;
            this.lblNitEmpsa.Location = new System.Drawing.Point(328, 129);
            this.lblNitEmpsa.Name = "lblNitEmpsa";
            this.lblNitEmpsa.Size = new System.Drawing.Size(25, 17);
            this.lblNitEmpsa.TabIndex = 22;
            this.lblNitEmpsa.Text = "NIT";
            // 
            // lblNomComercialEmpsa
            // 
            this.lblNomComercialEmpsa.AutoSize = true;
            this.lblNomComercialEmpsa.Location = new System.Drawing.Point(328, 101);
            this.lblNomComercialEmpsa.Name = "lblNomComercialEmpsa";
            this.lblNomComercialEmpsa.Size = new System.Drawing.Size(120, 17);
            this.lblNomComercialEmpsa.TabIndex = 21;
            this.lblNomComercialEmpsa.Text = "Nombre comercial";
            // 
            // txtEstadoEmpsa
            // 
            this.txtEstadoEmpsa.Location = new System.Drawing.Point(252, 153);
            this.txtEstadoEmpsa.MaxLength = 1;
            this.txtEstadoEmpsa.Name = "txtEstadoEmpsa";
            this.txtEstadoEmpsa.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoEmpsa.TabIndex = 27;
            this.txtEstadoEmpsa.Tag = "estado_empsa";
            this.txtEstadoEmpsa.Visible = false;
            this.txtEstadoEmpsa.EnabledChanged += new System.EventHandler(this.txtEstadoEmpsa_EnabledChanged);
            this.txtEstadoEmpsa.TextChanged += new System.EventHandler(this.txtEstadoEmpsa_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(96, 153);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(150, 25);
            this.cboEstado.TabIndex = 19;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstadoEmpsa_SelectedIndexChanged);
            // 
            // lblEstadoEmpsa
            // 
            this.lblEstadoEmpsa.AutoSize = true;
            this.lblEstadoEmpsa.Location = new System.Drawing.Point(12, 156);
            this.lblEstadoEmpsa.Name = "lblEstadoEmpsa";
            this.lblEstadoEmpsa.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoEmpsa.TabIndex = 25;
            this.lblEstadoEmpsa.Text = "Estado";
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
            this.navegador1.sNombreTabla = "tabm_empresa";
            this.navegador1.TabIndex = 28;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // wfEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 186);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstadoEmpsa);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstadoEmpsa);
            this.Controls.Add(this.txtNit_empsa);
            this.Controls.Add(this.txtNomcomercial_empsa);
            this.Controls.Add(this.lblNitEmpsa);
            this.Controls.Add(this.lblNomComercialEmpsa);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.txtRazsocial);
            this.Controls.Add(this.lblDireEmpsa);
            this.Controls.Add(this.lblRazsocialEmpsa);
            this.Controls.Add(this.txtCodEmpsa);
            this.Controls.Add(this.lblCodEmpsa);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEmpresas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.wfEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodEmpsa;
        private System.Windows.Forms.Label lblCodEmpsa;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.TextBox txtRazsocial;
        private System.Windows.Forms.Label lblDireEmpsa;
        private System.Windows.Forms.Label lblRazsocialEmpsa;
        private System.Windows.Forms.TextBox txtNit_empsa;
        private System.Windows.Forms.TextBox txtNomcomercial_empsa;
        private System.Windows.Forms.Label lblNitEmpsa;
        private System.Windows.Forms.Label lblNomComercialEmpsa;
        private System.Windows.Forms.TextBox txtEstadoEmpsa;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstadoEmpsa;
        private Navegador.Navegador navegador1;
    }
}