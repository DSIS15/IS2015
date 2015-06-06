namespace ConciliacionBancaria
{
    partial class wfCuentasBancarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCuentasBancarias));
            this.navegador1 = new Navegador.Navegador();
            this.lblCodEmpsa = new System.Windows.Forms.Label();
            this.lblCodMda = new System.Windows.Forms.Label();
            this.lblCodCtabco = new System.Windows.Forms.Label();
            this.lblNumctaCtabco = new System.Windows.Forms.Label();
            this.lblNombrectaCtabco = new System.Windows.Forms.Label();
            this.lblBancoctaCtabco = new System.Windows.Forms.Label();
            this.lblSaldoctaCtabco = new System.Windows.Forms.Label();
            this.lblEstadoctaCtabco = new System.Windows.Forms.Label();
            this.txtCodCtabco = new System.Windows.Forms.TextBox();
            this.txtCodEmpsa = new System.Windows.Forms.TextBox();
            this.txtCodMda = new System.Windows.Forms.TextBox();
            this.txtNumctaCtabco = new System.Windows.Forms.TextBox();
            this.txtNombreCtabco = new System.Windows.Forms.TextBox();
            this.txtBancoCtabco = new System.Windows.Forms.TextBox();
            this.txtSaldoCtabco = new System.Windows.Forms.TextBox();
            this.txtEstadoCtabco = new System.Windows.Forms.TextBox();
            this.cboEstadoCtabco = new System.Windows.Forms.ComboBox();
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
            this.navegador1.sNombreTabla = "tabm_ctabco";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblCodEmpsa
            // 
            this.lblCodEmpsa.AutoSize = true;
            this.lblCodEmpsa.Location = new System.Drawing.Point(388, 73);
            this.lblCodEmpsa.Name = "lblCodEmpsa";
            this.lblCodEmpsa.Size = new System.Drawing.Size(58, 17);
            this.lblCodEmpsa.TabIndex = 1;
            this.lblCodEmpsa.Text = "Empresa";
            // 
            // lblCodMda
            // 
            this.lblCodMda.AutoSize = true;
            this.lblCodMda.Location = new System.Drawing.Point(12, 101);
            this.lblCodMda.Name = "lblCodMda";
            this.lblCodMda.Size = new System.Drawing.Size(58, 17);
            this.lblCodMda.TabIndex = 2;
            this.lblCodMda.Text = "Moneda";
            // 
            // lblCodCtabco
            // 
            this.lblCodCtabco.AutoSize = true;
            this.lblCodCtabco.Location = new System.Drawing.Point(12, 73);
            this.lblCodCtabco.Name = "lblCodCtabco";
            this.lblCodCtabco.Size = new System.Drawing.Size(52, 17);
            this.lblCodCtabco.TabIndex = 3;
            this.lblCodCtabco.Text = "Codigo";
            // 
            // lblNumctaCtabco
            // 
            this.lblNumctaCtabco.AutoSize = true;
            this.lblNumctaCtabco.Location = new System.Drawing.Point(12, 129);
            this.lblNumctaCtabco.Name = "lblNumctaCtabco";
            this.lblNumctaCtabco.Size = new System.Drawing.Size(75, 17);
            this.lblNumctaCtabco.TabIndex = 4;
            this.lblNumctaCtabco.Text = "No. Cuenta";
            // 
            // lblNombrectaCtabco
            // 
            this.lblNombrectaCtabco.AutoSize = true;
            this.lblNombrectaCtabco.Location = new System.Drawing.Point(388, 129);
            this.lblNombrectaCtabco.Name = "lblNombrectaCtabco";
            this.lblNombrectaCtabco.Size = new System.Drawing.Size(56, 17);
            this.lblNombrectaCtabco.TabIndex = 5;
            this.lblNombrectaCtabco.Text = "Nombre";
            // 
            // lblBancoctaCtabco
            // 
            this.lblBancoctaCtabco.AutoSize = true;
            this.lblBancoctaCtabco.Location = new System.Drawing.Point(12, 157);
            this.lblBancoctaCtabco.Name = "lblBancoctaCtabco";
            this.lblBancoctaCtabco.Size = new System.Drawing.Size(46, 17);
            this.lblBancoctaCtabco.TabIndex = 6;
            this.lblBancoctaCtabco.Text = "Banco";
            // 
            // lblSaldoctaCtabco
            // 
            this.lblSaldoctaCtabco.AutoSize = true;
            this.lblSaldoctaCtabco.Location = new System.Drawing.Point(388, 157);
            this.lblSaldoctaCtabco.Name = "lblSaldoctaCtabco";
            this.lblSaldoctaCtabco.Size = new System.Drawing.Size(42, 17);
            this.lblSaldoctaCtabco.TabIndex = 7;
            this.lblSaldoctaCtabco.Text = "Saldo";
            // 
            // lblEstadoctaCtabco
            // 
            this.lblEstadoctaCtabco.AutoSize = true;
            this.lblEstadoctaCtabco.Location = new System.Drawing.Point(12, 185);
            this.lblEstadoctaCtabco.Name = "lblEstadoctaCtabco";
            this.lblEstadoctaCtabco.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoctaCtabco.TabIndex = 8;
            this.lblEstadoctaCtabco.Text = "Estado";
            // 
            // txtCodCtabco
            // 
            this.txtCodCtabco.Location = new System.Drawing.Point(93, 70);
            this.txtCodCtabco.MaxLength = 7;
            this.txtCodCtabco.Name = "txtCodCtabco";
            this.txtCodCtabco.Size = new System.Drawing.Size(150, 22);
            this.txtCodCtabco.TabIndex = 14;
            this.txtCodCtabco.Tag = "cod_ctabco";
            this.txtCodCtabco.EnabledChanged += new System.EventHandler(this.txtCodCtabco_EnabledChanged);
            this.txtCodCtabco.TextChanged += new System.EventHandler(this.txtCodCtabco_TextChanged);
            // 
            // txtCodEmpsa
            // 
            this.txtCodEmpsa.Location = new System.Drawing.Point(452, 70);
            this.txtCodEmpsa.MaxLength = 7;
            this.txtCodEmpsa.Name = "txtCodEmpsa";
            this.txtCodEmpsa.Size = new System.Drawing.Size(150, 22);
            this.txtCodEmpsa.TabIndex = 15;
            this.txtCodEmpsa.Tag = "cod_empsa";
            this.txtCodEmpsa.EnabledChanged += new System.EventHandler(this.txtCodEmpsa_EnabledChanged);
            // 
            // txtCodMda
            // 
            this.txtCodMda.Location = new System.Drawing.Point(93, 98);
            this.txtCodMda.MaxLength = 7;
            this.txtCodMda.Name = "txtCodMda";
            this.txtCodMda.Size = new System.Drawing.Size(150, 22);
            this.txtCodMda.TabIndex = 16;
            this.txtCodMda.Tag = "cod_mda";
            this.txtCodMda.EnabledChanged += new System.EventHandler(this.txtCodMda_EnabledChanged);
            // 
            // txtNumctaCtabco
            // 
            this.txtNumctaCtabco.Location = new System.Drawing.Point(93, 126);
            this.txtNumctaCtabco.MaxLength = 25;
            this.txtNumctaCtabco.Name = "txtNumctaCtabco";
            this.txtNumctaCtabco.Size = new System.Drawing.Size(150, 22);
            this.txtNumctaCtabco.TabIndex = 17;
            this.txtNumctaCtabco.Tag = "numcta_ctabco";
            this.txtNumctaCtabco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumctaCtabco_KeyPress);
            // 
            // txtNombreCtabco
            // 
            this.txtNombreCtabco.Location = new System.Drawing.Point(452, 126);
            this.txtNombreCtabco.MaxLength = 50;
            this.txtNombreCtabco.Name = "txtNombreCtabco";
            this.txtNombreCtabco.Size = new System.Drawing.Size(150, 22);
            this.txtNombreCtabco.TabIndex = 18;
            this.txtNombreCtabco.Tag = "nombre_ctabco";
            this.txtNombreCtabco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCtabco_KeyPress);
            // 
            // txtBancoCtabco
            // 
            this.txtBancoCtabco.Location = new System.Drawing.Point(93, 154);
            this.txtBancoCtabco.MaxLength = 50;
            this.txtBancoCtabco.Name = "txtBancoCtabco";
            this.txtBancoCtabco.Size = new System.Drawing.Size(150, 22);
            this.txtBancoCtabco.TabIndex = 19;
            this.txtBancoCtabco.Tag = "banco_ctabco";
            this.txtBancoCtabco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBancoCtabco_KeyPress);
            // 
            // txtSaldoCtabco
            // 
            this.txtSaldoCtabco.Location = new System.Drawing.Point(452, 154);
            this.txtSaldoCtabco.MaxLength = 25;
            this.txtSaldoCtabco.Name = "txtSaldoCtabco";
            this.txtSaldoCtabco.Size = new System.Drawing.Size(150, 22);
            this.txtSaldoCtabco.TabIndex = 20;
            this.txtSaldoCtabco.Tag = "saldo_ctabco";
            this.txtSaldoCtabco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoCtabco_KeyPress);
            // 
            // txtEstadoCtabco
            // 
            this.txtEstadoCtabco.Location = new System.Drawing.Point(249, 182);
            this.txtEstadoCtabco.MaxLength = 1;
            this.txtEstadoCtabco.Name = "txtEstadoCtabco";
            this.txtEstadoCtabco.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoCtabco.TabIndex = 22;
            this.txtEstadoCtabco.Tag = "estado_ctabco";
            this.txtEstadoCtabco.Visible = false;
            this.txtEstadoCtabco.EnabledChanged += new System.EventHandler(this.txtEstadoCtabco_EnabledChanged);
            this.txtEstadoCtabco.TextChanged += new System.EventHandler(this.txtEstadoCtabco_TextChanged);
            // 
            // cboEstadoCtabco
            // 
            this.cboEstadoCtabco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCtabco.FormattingEnabled = true;
            this.cboEstadoCtabco.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoCtabco.Location = new System.Drawing.Point(93, 182);
            this.cboEstadoCtabco.Name = "cboEstadoCtabco";
            this.cboEstadoCtabco.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoCtabco.TabIndex = 21;
            this.cboEstadoCtabco.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCtabco_SelectedIndexChanged);
            // 
            // wfCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 216);
            this.Controls.Add(this.cboEstadoCtabco);
            this.Controls.Add(this.txtEstadoCtabco);
            this.Controls.Add(this.txtSaldoCtabco);
            this.Controls.Add(this.txtBancoCtabco);
            this.Controls.Add(this.txtNombreCtabco);
            this.Controls.Add(this.txtNumctaCtabco);
            this.Controls.Add(this.txtCodMda);
            this.Controls.Add(this.txtCodEmpsa);
            this.Controls.Add(this.txtCodCtabco);
            this.Controls.Add(this.lblEstadoctaCtabco);
            this.Controls.Add(this.lblSaldoctaCtabco);
            this.Controls.Add(this.lblBancoctaCtabco);
            this.Controls.Add(this.lblNombrectaCtabco);
            this.Controls.Add(this.lblNumctaCtabco);
            this.Controls.Add(this.lblCodCtabco);
            this.Controls.Add(this.lblCodMda);
            this.Controls.Add(this.lblCodEmpsa);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCuentasBancarias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas Bancarias";
            this.Load += new System.EventHandler(this.wfCuentasBancarias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodEmpsa;
        private System.Windows.Forms.Label lblCodMda;
        private System.Windows.Forms.Label lblCodCtabco;
        private System.Windows.Forms.Label lblNumctaCtabco;
        private System.Windows.Forms.Label lblNombrectaCtabco;
        private System.Windows.Forms.Label lblBancoctaCtabco;
        private System.Windows.Forms.Label lblSaldoctaCtabco;
        private System.Windows.Forms.Label lblEstadoctaCtabco;
        private System.Windows.Forms.TextBox txtCodCtabco;
        private System.Windows.Forms.TextBox txtCodEmpsa;
        private System.Windows.Forms.TextBox txtCodMda;
        private System.Windows.Forms.TextBox txtNumctaCtabco;
        private System.Windows.Forms.TextBox txtNombreCtabco;
        private System.Windows.Forms.TextBox txtBancoCtabco;
        private System.Windows.Forms.TextBox txtSaldoCtabco;
        private System.Windows.Forms.TextBox txtEstadoCtabco;
        private System.Windows.Forms.ComboBox cboEstadoCtabco;
    }
}