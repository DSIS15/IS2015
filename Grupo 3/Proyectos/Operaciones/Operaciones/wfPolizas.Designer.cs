namespace Operaciones
{
    partial class wfPolizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPolizas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navegador1 = new Navegador.Navegador();
            this.txtDetallePlz = new System.Windows.Forms.TextBox();
            this.lblFechEmisPza = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtEstadoPlz = new System.Windows.Forms.TextBox();
            this.txtNumPlz = new System.Windows.Forms.TextBox();
            this.lblNumPza = new System.Windows.Forms.Label();
            this.txtCodEmpsa = new System.Windows.Forms.TextBox();
            this.lblCodEmpsa = new System.Windows.Forms.Label();
            this.txtCodigoPlz = new System.Windows.Forms.TextBox();
            this.lblCodigoPza = new System.Windows.Forms.Label();
            this.lblDetallePza = new System.Windows.Forms.Label();
            this.dtpFechemiPlz = new System.Windows.Forms.DateTimePicker();
            this.txtFechemiPlz = new System.Windows.Forms.TextBox();
            this.lblEstadoPlz = new System.Windows.Forms.Label();
            this.cboEstadoPlz = new System.Windows.Forms.ComboBox();
            this.txtEstadoDplz = new System.Windows.Forms.TextBox();
            this.txtCorrDplz = new System.Windows.Forms.TextBox();
            this.lblCorrDplz = new System.Windows.Forms.Label();
            this.btnTotalPlz = new System.Windows.Forms.Button();
            this.btnAgregarDplz = new System.Windows.Forms.Button();
            this.txtAbonoDplz = new System.Windows.Forms.TextBox();
            this.lblAbonoDplz = new System.Windows.Forms.Label();
            this.txtCargoDplz = new System.Windows.Forms.TextBox();
            this.lblCargoDplz = new System.Windows.Forms.Label();
            this.txtAbonos = new System.Windows.Forms.TextBox();
            this.txtCargos = new System.Windows.Forms.TextBox();
            this.dgvDplz = new System.Windows.Forms.DataGridView();
            this.DgvCorrDplz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvNomencDplz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCuentaDplz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCargoDplz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvAbonoDplz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvEstadoDplz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboEstadoDplz = new System.Windows.Forms.ComboBox();
            this.lblEstadoDplz = new System.Windows.Forms.Label();
            this.txtCuentaDplz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDplz)).BeginInit();
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
            this.navegador1.sNombreTabla = "tabm_poliza";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            // 
            // txtDetallePlz
            // 
            this.txtDetallePlz.Location = new System.Drawing.Point(97, 145);
            this.txtDetallePlz.Name = "txtDetallePlz";
            this.txtDetallePlz.Size = new System.Drawing.Size(150, 22);
            this.txtDetallePlz.TabIndex = 6;
            this.txtDetallePlz.Tag = "descrip_plz";
            // 
            // lblFechEmisPza
            // 
            this.lblFechEmisPza.AutoSize = true;
            this.lblFechEmisPza.Location = new System.Drawing.Point(355, 122);
            this.lblFechEmisPza.Name = "lblFechEmisPza";
            this.lblFechEmisPza.Size = new System.Drawing.Size(91, 17);
            this.lblFechEmisPza.TabIndex = 6;
            this.lblFechEmisPza.Text = "Fecha Emisión";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(452, 89);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(150, 22);
            this.txtMoneda.TabIndex = 3;
            this.txtMoneda.Tag = "cod_mda";
            this.txtMoneda.Enter += new System.EventHandler(this.txtMoneda_Enter);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(355, 92);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(58, 17);
            this.lblMoneda.TabIndex = 3;
            this.lblMoneda.Text = "Moneda";
            // 
            // txtEstadoPlz
            // 
            this.txtEstadoPlz.Location = new System.Drawing.Point(324, 145);
            this.txtEstadoPlz.Name = "txtEstadoPlz";
            this.txtEstadoPlz.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoPlz.TabIndex = 35;
            this.txtEstadoPlz.Tag = "estado_plz";
            this.txtEstadoPlz.Visible = false;
            this.txtEstadoPlz.TextChanged += new System.EventHandler(this.txtEstadoPza_TextChanged);
            // 
            // txtNumPlz
            // 
            this.txtNumPlz.Location = new System.Drawing.Point(97, 117);
            this.txtNumPlz.Name = "txtNumPlz";
            this.txtNumPlz.Size = new System.Drawing.Size(150, 22);
            this.txtNumPlz.TabIndex = 4;
            this.txtNumPlz.Tag = "num_plz";
            // 
            // lblNumPza
            // 
            this.lblNumPza.AutoSize = true;
            this.lblNumPza.Location = new System.Drawing.Point(12, 120);
            this.lblNumPza.Name = "lblNumPza";
            this.lblNumPza.Size = new System.Drawing.Size(55, 17);
            this.lblNumPza.TabIndex = 4;
            this.lblNumPza.Text = "Número";
            // 
            // txtCodEmpsa
            // 
            this.txtCodEmpsa.Location = new System.Drawing.Point(97, 89);
            this.txtCodEmpsa.Name = "txtCodEmpsa";
            this.txtCodEmpsa.Size = new System.Drawing.Size(150, 22);
            this.txtCodEmpsa.TabIndex = 2;
            this.txtCodEmpsa.Tag = "cod_empsa";
            this.txtCodEmpsa.Enter += new System.EventHandler(this.txtCodEmpsa_Enter);
            // 
            // lblCodEmpsa
            // 
            this.lblCodEmpsa.AutoSize = true;
            this.lblCodEmpsa.Location = new System.Drawing.Point(12, 92);
            this.lblCodEmpsa.Name = "lblCodEmpsa";
            this.lblCodEmpsa.Size = new System.Drawing.Size(58, 17);
            this.lblCodEmpsa.TabIndex = 2;
            this.lblCodEmpsa.Text = "Empresa";
            // 
            // txtCodigoPlz
            // 
            this.txtCodigoPlz.Location = new System.Drawing.Point(97, 61);
            this.txtCodigoPlz.Name = "txtCodigoPlz";
            this.txtCodigoPlz.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoPlz.TabIndex = 1;
            this.txtCodigoPlz.Tag = "cod_plz";
            this.txtCodigoPlz.TextChanged += new System.EventHandler(this.txtCodigoPlz_TextChanged);
            // 
            // lblCodigoPza
            // 
            this.lblCodigoPza.AutoSize = true;
            this.lblCodigoPza.Location = new System.Drawing.Point(12, 64);
            this.lblCodigoPza.Name = "lblCodigoPza";
            this.lblCodigoPza.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoPza.TabIndex = 1;
            this.lblCodigoPza.Text = "Código";
            // 
            // lblDetallePza
            // 
            this.lblDetallePza.AutoSize = true;
            this.lblDetallePza.Location = new System.Drawing.Point(12, 148);
            this.lblDetallePza.Name = "lblDetallePza";
            this.lblDetallePza.Size = new System.Drawing.Size(79, 17);
            this.lblDetallePza.TabIndex = 7;
            this.lblDetallePza.Text = "Descripción";
            // 
            // dtpFechemiPlz
            // 
            this.dtpFechemiPlz.Location = new System.Drawing.Point(452, 117);
            this.dtpFechemiPlz.Name = "dtpFechemiPlz";
            this.dtpFechemiPlz.Size = new System.Drawing.Size(150, 22);
            this.dtpFechemiPlz.TabIndex = 40;
            this.dtpFechemiPlz.ValueChanged += new System.EventHandler(this.dtpFechemiPlz_ValueChanged);
            // 
            // txtFechemiPlz
            // 
            this.txtFechemiPlz.Location = new System.Drawing.Point(324, 117);
            this.txtFechemiPlz.Name = "txtFechemiPlz";
            this.txtFechemiPlz.Size = new System.Drawing.Size(25, 22);
            this.txtFechemiPlz.TabIndex = 41;
            this.txtFechemiPlz.Tag = "fechemi_plz";
            this.txtFechemiPlz.Visible = false;
            this.txtFechemiPlz.TextChanged += new System.EventHandler(this.txtFechemiPlz_TextChanged);
            // 
            // lblEstadoPlz
            // 
            this.lblEstadoPlz.AutoSize = true;
            this.lblEstadoPlz.Location = new System.Drawing.Point(355, 148);
            this.lblEstadoPlz.Name = "lblEstadoPlz";
            this.lblEstadoPlz.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoPlz.TabIndex = 65;
            this.lblEstadoPlz.Tag = "10";
            this.lblEstadoPlz.Text = "Estado";
            // 
            // cboEstadoPlz
            // 
            this.cboEstadoPlz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPlz.FormattingEnabled = true;
            this.cboEstadoPlz.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoPlz.Location = new System.Drawing.Point(452, 145);
            this.cboEstadoPlz.Name = "cboEstadoPlz";
            this.cboEstadoPlz.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoPlz.TabIndex = 64;
            this.cboEstadoPlz.Tag = "";
            this.cboEstadoPlz.SelectedIndexChanged += new System.EventHandler(this.cboEstadoPlz_SelectedIndexChanged);
            // 
            // txtEstadoDplz
            // 
            this.txtEstadoDplz.Location = new System.Drawing.Point(324, 232);
            this.txtEstadoDplz.Name = "txtEstadoDplz";
            this.txtEstadoDplz.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoDplz.TabIndex = 79;
            this.txtEstadoDplz.Tag = "estado_dplz";
            this.txtEstadoDplz.Visible = false;
            this.txtEstadoDplz.TextChanged += new System.EventHandler(this.txtEstadoDplz_TextChanged);
            // 
            // txtCorrDplz
            // 
            this.txtCorrDplz.Location = new System.Drawing.Point(97, 204);
            this.txtCorrDplz.Name = "txtCorrDplz";
            this.txtCorrDplz.Size = new System.Drawing.Size(150, 22);
            this.txtCorrDplz.TabIndex = 78;
            this.txtCorrDplz.Tag = "corr_dplz";
            // 
            // lblCorrDplz
            // 
            this.lblCorrDplz.AutoSize = true;
            this.lblCorrDplz.Location = new System.Drawing.Point(12, 207);
            this.lblCorrDplz.Name = "lblCorrDplz";
            this.lblCorrDplz.Size = new System.Drawing.Size(76, 17);
            this.lblCorrDplz.TabIndex = 77;
            this.lblCorrDplz.Text = "Correlativo";
            // 
            // btnTotalPlz
            // 
            this.btnTotalPlz.Location = new System.Drawing.Point(18, 458);
            this.btnTotalPlz.Name = "btnTotalPlz";
            this.btnTotalPlz.Size = new System.Drawing.Size(150, 28);
            this.btnTotalPlz.TabIndex = 76;
            this.btnTotalPlz.Text = "Totalizar";
            this.btnTotalPlz.UseVisualStyleBackColor = true;
            this.btnTotalPlz.Click += new System.EventHandler(this.btnTotalPlz_Click);
            // 
            // btnAgregarDplz
            // 
            this.btnAgregarDplz.Location = new System.Drawing.Point(556, 263);
            this.btnAgregarDplz.Name = "btnAgregarDplz";
            this.btnAgregarDplz.Size = new System.Drawing.Size(46, 28);
            this.btnAgregarDplz.TabIndex = 75;
            this.btnAgregarDplz.Text = "<-";
            this.btnAgregarDplz.UseVisualStyleBackColor = true;
            this.btnAgregarDplz.Click += new System.EventHandler(this.btnAgregarDplz_Click);
            // 
            // txtAbonoDplz
            // 
            this.txtAbonoDplz.Location = new System.Drawing.Point(97, 232);
            this.txtAbonoDplz.Name = "txtAbonoDplz";
            this.txtAbonoDplz.Size = new System.Drawing.Size(150, 22);
            this.txtAbonoDplz.TabIndex = 74;
            this.txtAbonoDplz.Tag = "";
            // 
            // lblAbonoDplz
            // 
            this.lblAbonoDplz.AutoSize = true;
            this.lblAbonoDplz.Location = new System.Drawing.Point(12, 235);
            this.lblAbonoDplz.Name = "lblAbonoDplz";
            this.lblAbonoDplz.Size = new System.Drawing.Size(48, 17);
            this.lblAbonoDplz.TabIndex = 73;
            this.lblAbonoDplz.Text = "Abono";
            // 
            // txtCargoDplz
            // 
            this.txtCargoDplz.Location = new System.Drawing.Point(452, 204);
            this.txtCargoDplz.Name = "txtCargoDplz";
            this.txtCargoDplz.Size = new System.Drawing.Size(150, 22);
            this.txtCargoDplz.TabIndex = 72;
            this.txtCargoDplz.Tag = "";
            // 
            // lblCargoDplz
            // 
            this.lblCargoDplz.AutoSize = true;
            this.lblCargoDplz.Location = new System.Drawing.Point(355, 207);
            this.lblCargoDplz.Name = "lblCargoDplz";
            this.lblCargoDplz.Size = new System.Drawing.Size(45, 17);
            this.lblCargoDplz.TabIndex = 71;
            this.lblCargoDplz.Text = "Cargo";
            // 
            // txtAbonos
            // 
            this.txtAbonos.Location = new System.Drawing.Point(406, 458);
            this.txtAbonos.Name = "txtAbonos";
            this.txtAbonos.Size = new System.Drawing.Size(80, 22);
            this.txtAbonos.TabIndex = 70;
            this.txtAbonos.Tag = "";
            // 
            // txtCargos
            // 
            this.txtCargos.Location = new System.Drawing.Point(320, 458);
            this.txtCargos.Name = "txtCargos";
            this.txtCargos.Size = new System.Drawing.Size(80, 22);
            this.txtCargos.TabIndex = 69;
            this.txtCargos.Tag = "";
            // 
            // dgvDplz
            // 
            this.dgvDplz.AllowUserToDeleteRows = false;
            this.dgvDplz.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDplz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDplz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCorrDplz,
            this.DgvNomencDplz,
            this.DgvCuentaDplz,
            this.DgvCargoDplz,
            this.DgvAbonoDplz,
            this.DgvEstadoDplz});
            this.dgvDplz.Location = new System.Drawing.Point(18, 263);
            this.dgvDplz.Name = "dgvDplz";
            this.dgvDplz.ReadOnly = true;
            this.dgvDplz.Size = new System.Drawing.Size(532, 189);
            this.dgvDplz.TabIndex = 68;
            this.dgvDplz.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDplz_CellEnter);
            // 
            // DgvCorrDplz
            // 
            this.DgvCorrDplz.HeaderText = "Corr.";
            this.DgvCorrDplz.Name = "DgvCorrDplz";
            this.DgvCorrDplz.ReadOnly = true;
            this.DgvCorrDplz.Width = 45;
            // 
            // DgvNomencDplz
            // 
            this.DgvNomencDplz.HeaderText = "Nomen.";
            this.DgvNomencDplz.Name = "DgvNomencDplz";
            this.DgvNomencDplz.ReadOnly = true;
            this.DgvNomencDplz.Width = 65;
            // 
            // DgvCuentaDplz
            // 
            this.DgvCuentaDplz.HeaderText = "Cuenta";
            this.DgvCuentaDplz.Name = "DgvCuentaDplz";
            this.DgvCuentaDplz.ReadOnly = true;
            this.DgvCuentaDplz.Width = 150;
            // 
            // DgvCargoDplz
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.DgvCargoDplz.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCargoDplz.HeaderText = "Cargo";
            this.DgvCargoDplz.Name = "DgvCargoDplz";
            this.DgvCargoDplz.ReadOnly = true;
            this.DgvCargoDplz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCargoDplz.Width = 80;
            // 
            // DgvAbonoDplz
            // 
            this.DgvAbonoDplz.HeaderText = "Abono";
            this.DgvAbonoDplz.Name = "DgvAbonoDplz";
            this.DgvAbonoDplz.ReadOnly = true;
            this.DgvAbonoDplz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAbonoDplz.Width = 80;
            // 
            // DgvEstadoDplz
            // 
            this.DgvEstadoDplz.HeaderText = "Estado";
            this.DgvEstadoDplz.Name = "DgvEstadoDplz";
            this.DgvEstadoDplz.ReadOnly = true;
            this.DgvEstadoDplz.Width = 68;
            // 
            // cboEstadoDplz
            // 
            this.cboEstadoDplz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoDplz.FormattingEnabled = true;
            this.cboEstadoDplz.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoDplz.Location = new System.Drawing.Point(452, 232);
            this.cboEstadoDplz.Name = "cboEstadoDplz";
            this.cboEstadoDplz.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoDplz.TabIndex = 66;
            this.cboEstadoDplz.Tag = "";
            this.cboEstadoDplz.SelectedIndexChanged += new System.EventHandler(this.cboEstadoDplz_SelectedIndexChanged_1);
            // 
            // lblEstadoDplz
            // 
            this.lblEstadoDplz.AutoSize = true;
            this.lblEstadoDplz.Location = new System.Drawing.Point(355, 235);
            this.lblEstadoDplz.Name = "lblEstadoDplz";
            this.lblEstadoDplz.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoDplz.TabIndex = 67;
            this.lblEstadoDplz.Tag = "10";
            this.lblEstadoDplz.Text = "Estado";
            // 
            // txtCuentaDplz
            // 
            this.txtCuentaDplz.Location = new System.Drawing.Point(556, 297);
            this.txtCuentaDplz.Name = "txtCuentaDplz";
            this.txtCuentaDplz.Size = new System.Drawing.Size(25, 22);
            this.txtCuentaDplz.TabIndex = 80;
            this.txtCuentaDplz.Tag = "cod_cta";
            // 
            // wfPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 492);
            this.Controls.Add(this.txtCuentaDplz);
            this.Controls.Add(this.txtEstadoDplz);
            this.Controls.Add(this.txtCorrDplz);
            this.Controls.Add(this.lblCorrDplz);
            this.Controls.Add(this.btnTotalPlz);
            this.Controls.Add(this.btnAgregarDplz);
            this.Controls.Add(this.txtAbonoDplz);
            this.Controls.Add(this.lblAbonoDplz);
            this.Controls.Add(this.txtCargoDplz);
            this.Controls.Add(this.lblCargoDplz);
            this.Controls.Add(this.txtAbonos);
            this.Controls.Add(this.txtCargos);
            this.Controls.Add(this.dgvDplz);
            this.Controls.Add(this.cboEstadoDplz);
            this.Controls.Add(this.lblEstadoDplz);
            this.Controls.Add(this.cboEstadoPlz);
            this.Controls.Add(this.lblEstadoPlz);
            this.Controls.Add(this.txtFechemiPlz);
            this.Controls.Add(this.dtpFechemiPlz);
            this.Controls.Add(this.lblDetallePza);
            this.Controls.Add(this.txtDetallePlz);
            this.Controls.Add(this.lblFechEmisPza);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.txtEstadoPlz);
            this.Controls.Add(this.txtNumPlz);
            this.Controls.Add(this.lblNumPza);
            this.Controls.Add(this.txtCodEmpsa);
            this.Controls.Add(this.lblCodEmpsa);
            this.Controls.Add(this.txtCodigoPlz);
            this.Controls.Add(this.lblCodigoPza);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfPolizas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Polizas";
            this.Load += new System.EventHandler(this.wfPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDplz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtDetallePlz;
        private System.Windows.Forms.Label lblFechEmisPza;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtEstadoPlz;
        private System.Windows.Forms.TextBox txtNumPlz;
        private System.Windows.Forms.Label lblNumPza;
        private System.Windows.Forms.TextBox txtCodEmpsa;
        private System.Windows.Forms.Label lblCodEmpsa;
        private System.Windows.Forms.TextBox txtCodigoPlz;
        private System.Windows.Forms.Label lblCodigoPza;
        private System.Windows.Forms.Label lblDetallePza;
        private System.Windows.Forms.DateTimePicker dtpFechemiPlz;
        private System.Windows.Forms.TextBox txtFechemiPlz;
        private System.Windows.Forms.Label lblEstadoPlz;
        private System.Windows.Forms.ComboBox cboEstadoPlz;
        private System.Windows.Forms.TextBox txtEstadoDplz;
        private System.Windows.Forms.TextBox txtCorrDplz;
        private System.Windows.Forms.Label lblCorrDplz;
        private System.Windows.Forms.Button btnTotalPlz;
        private System.Windows.Forms.Button btnAgregarDplz;
        private System.Windows.Forms.TextBox txtAbonoDplz;
        private System.Windows.Forms.Label lblAbonoDplz;
        private System.Windows.Forms.TextBox txtCargoDplz;
        private System.Windows.Forms.Label lblCargoDplz;
        private System.Windows.Forms.TextBox txtAbonos;
        private System.Windows.Forms.TextBox txtCargos;
        private System.Windows.Forms.DataGridView dgvDplz;
        private System.Windows.Forms.ComboBox cboEstadoDplz;
        private System.Windows.Forms.Label lblEstadoDplz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCorrDplz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvNomencDplz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCuentaDplz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCargoDplz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAbonoDplz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvEstadoDplz;
        private System.Windows.Forms.TextBox txtCuentaDplz;
       
    }
}