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
            this.navegador1 = new Navegador.Navegador();
            this.txtDetallePlz = new System.Windows.Forms.TextBox();
            this.lblFechEmisPza = new System.Windows.Forms.Label();
            this.txtEstadoPlz = new System.Windows.Forms.TextBox();
            this.txtNumPlz = new System.Windows.Forms.TextBox();
            this.lblNumPza = new System.Windows.Forms.Label();
            this.txtCodigoPlz = new System.Windows.Forms.TextBox();
            this.lblCodigoPza = new System.Windows.Forms.Label();
            this.lblDetallePza = new System.Windows.Forms.Label();
            this.dtpFechemiPlz = new System.Windows.Forms.DateTimePicker();
            this.txtFechemiPlz = new System.Windows.Forms.TextBox();
            this.lblEstadoPlz = new System.Windows.Forms.Label();
            this.cboEstadoPlz = new System.Windows.Forms.ComboBox();
            this.pnlDetallePlz = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboCuentaDplz = new System.Windows.Forms.ComboBox();
            this.cboClasificacionDplz = new System.Windows.Forms.ComboBox();
            this.lblCuentaDplz = new System.Windows.Forms.Label();
            this.btnAgregarDplz = new System.Windows.Forms.Button();
            this.txtSaldoDplz = new System.Windows.Forms.TextBox();
            this.lblSaldoDplz = new System.Windows.Forms.Label();
            this.txtAbonos = new System.Windows.Forms.TextBox();
            this.txtCargos = new System.Windows.Forms.TextBox();
            this.dgvDplz = new System.Windows.Forms.DataGridView();
            this.pnlDetallePlz.SuspendLayout();
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
            this.navegador1.btnAfterGuardar += new System.EventHandler(this.navegador1_btnAfterGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // txtDetallePlz
            // 
            this.txtDetallePlz.Location = new System.Drawing.Point(97, 126);
            this.txtDetallePlz.Name = "txtDetallePlz";
            this.txtDetallePlz.Size = new System.Drawing.Size(150, 22);
            this.txtDetallePlz.TabIndex = 17;
            this.txtDetallePlz.Tag = "descrip_plz";
            this.txtDetallePlz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetallePlz_KeyPress);
            // 
            // lblFechEmisPza
            // 
            this.lblFechEmisPza.AutoSize = true;
            this.lblFechEmisPza.Location = new System.Drawing.Point(355, 101);
            this.lblFechEmisPza.Name = "lblFechEmisPza";
            this.lblFechEmisPza.Size = new System.Drawing.Size(91, 17);
            this.lblFechEmisPza.TabIndex = 6;
            this.lblFechEmisPza.Text = "Fecha Emisión";
            // 
            // txtEstadoPlz
            // 
            this.txtEstadoPlz.Location = new System.Drawing.Point(324, 126);
            this.txtEstadoPlz.Name = "txtEstadoPlz";
            this.txtEstadoPlz.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoPlz.TabIndex = 35;
            this.txtEstadoPlz.Tag = "estado_plz";
            this.txtEstadoPlz.Visible = false;
            this.txtEstadoPlz.EnabledChanged += new System.EventHandler(this.txtEstadoPlz_EnabledChanged);
            this.txtEstadoPlz.TextChanged += new System.EventHandler(this.txtEstadoPlz_TextChanged);
            // 
            // txtNumPlz
            // 
            this.txtNumPlz.Location = new System.Drawing.Point(97, 98);
            this.txtNumPlz.Name = "txtNumPlz";
            this.txtNumPlz.Size = new System.Drawing.Size(150, 22);
            this.txtNumPlz.TabIndex = 15;
            this.txtNumPlz.Tag = "num_plz";
            this.txtNumPlz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPlz_KeyPress);
            // 
            // lblNumPza
            // 
            this.lblNumPza.AutoSize = true;
            this.lblNumPza.Location = new System.Drawing.Point(12, 101);
            this.lblNumPza.Name = "lblNumPza";
            this.lblNumPza.Size = new System.Drawing.Size(55, 17);
            this.lblNumPza.TabIndex = 4;
            this.lblNumPza.Text = "Número";
            // 
            // txtCodigoPlz
            // 
            this.txtCodigoPlz.Enabled = false;
            this.txtCodigoPlz.Location = new System.Drawing.Point(97, 70);
            this.txtCodigoPlz.Name = "txtCodigoPlz";
            this.txtCodigoPlz.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoPlz.TabIndex = 14;
            this.txtCodigoPlz.Tag = "cod_plz";
            this.txtCodigoPlz.EnabledChanged += new System.EventHandler(this.txtCodigoPlz_EnabledChanged);
            this.txtCodigoPlz.TextChanged += new System.EventHandler(this.txtCodigoPlz_TextChanged);
            // 
            // lblCodigoPza
            // 
            this.lblCodigoPza.AutoSize = true;
            this.lblCodigoPza.Enabled = false;
            this.lblCodigoPza.Location = new System.Drawing.Point(12, 73);
            this.lblCodigoPza.Name = "lblCodigoPza";
            this.lblCodigoPza.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoPza.TabIndex = 1;
            this.lblCodigoPza.Text = "Código";
            // 
            // lblDetallePza
            // 
            this.lblDetallePza.AutoSize = true;
            this.lblDetallePza.Location = new System.Drawing.Point(12, 129);
            this.lblDetallePza.Name = "lblDetallePza";
            this.lblDetallePza.Size = new System.Drawing.Size(79, 17);
            this.lblDetallePza.TabIndex = 7;
            this.lblDetallePza.Text = "Descripción";
            // 
            // dtpFechemiPlz
            // 
            this.dtpFechemiPlz.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtpFechemiPlz.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechemiPlz.Location = new System.Drawing.Point(452, 96);
            this.dtpFechemiPlz.Name = "dtpFechemiPlz";
            this.dtpFechemiPlz.ShowUpDown = true;
            this.dtpFechemiPlz.Size = new System.Drawing.Size(150, 22);
            this.dtpFechemiPlz.TabIndex = 16;
            this.dtpFechemiPlz.ValueChanged += new System.EventHandler(this.dtpFechemiPlz_ValueChanged);
            // 
            // txtFechemiPlz
            // 
            this.txtFechemiPlz.Location = new System.Drawing.Point(324, 96);
            this.txtFechemiPlz.Name = "txtFechemiPlz";
            this.txtFechemiPlz.Size = new System.Drawing.Size(25, 22);
            this.txtFechemiPlz.TabIndex = 17;
            this.txtFechemiPlz.Tag = "fechemi_plz";
            this.txtFechemiPlz.Visible = false;
            this.txtFechemiPlz.EnabledChanged += new System.EventHandler(this.txtFechemiPlz_EnabledChanged);
            this.txtFechemiPlz.TextChanged += new System.EventHandler(this.txtFechemiPlz_TextChanged);
            // 
            // lblEstadoPlz
            // 
            this.lblEstadoPlz.AutoSize = true;
            this.lblEstadoPlz.Location = new System.Drawing.Point(355, 129);
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
            this.cboEstadoPlz.Location = new System.Drawing.Point(452, 124);
            this.cboEstadoPlz.Name = "cboEstadoPlz";
            this.cboEstadoPlz.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoPlz.TabIndex = 18;
            this.cboEstadoPlz.Tag = "";
            this.cboEstadoPlz.SelectedIndexChanged += new System.EventHandler(this.cboEstadoPlz_SelectedIndexChanged);
            // 
            // pnlDetallePlz
            // 
            this.pnlDetallePlz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetallePlz.Controls.Add(this.lblTipo);
            this.pnlDetallePlz.Controls.Add(this.btnEliminar);
            this.pnlDetallePlz.Controls.Add(this.cboCuentaDplz);
            this.pnlDetallePlz.Controls.Add(this.cboClasificacionDplz);
            this.pnlDetallePlz.Controls.Add(this.lblCuentaDplz);
            this.pnlDetallePlz.Controls.Add(this.btnAgregarDplz);
            this.pnlDetallePlz.Controls.Add(this.txtSaldoDplz);
            this.pnlDetallePlz.Controls.Add(this.lblSaldoDplz);
            this.pnlDetallePlz.Controls.Add(this.txtAbonos);
            this.pnlDetallePlz.Controls.Add(this.txtCargos);
            this.pnlDetallePlz.Controls.Add(this.dgvDplz);
            this.pnlDetallePlz.Location = new System.Drawing.Point(8, 154);
            this.pnlDetallePlz.Name = "pnlDetallePlz";
            this.pnlDetallePlz.Size = new System.Drawing.Size(599, 316);
            this.pnlDetallePlz.TabIndex = 85;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(4, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 17);
            this.lblTipo.TabIndex = 94;
            this.lblTipo.Text = "Tipo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(475, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 28);
            this.btnEliminar.TabIndex = 93;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cboCuentaDplz
            // 
            this.cboCuentaDplz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaDplz.FormattingEnabled = true;
            this.cboCuentaDplz.Location = new System.Drawing.Point(89, 9);
            this.cboCuentaDplz.Name = "cboCuentaDplz";
            this.cboCuentaDplz.Size = new System.Drawing.Size(150, 25);
            this.cboCuentaDplz.TabIndex = 19;
            this.cboCuentaDplz.Tag = "";
            this.cboCuentaDplz.SelectedIndexChanged += new System.EventHandler(this.cboCuentaDplz_SelectedIndexChanged);
            // 
            // cboClasificacionDplz
            // 
            this.cboClasificacionDplz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacionDplz.FormattingEnabled = true;
            this.cboClasificacionDplz.Items.AddRange(new object[] {
            "Cargo",
            "Abono"});
            this.cboClasificacionDplz.Location = new System.Drawing.Point(89, 40);
            this.cboClasificacionDplz.Name = "cboClasificacionDplz";
            this.cboClasificacionDplz.Size = new System.Drawing.Size(150, 25);
            this.cboClasificacionDplz.TabIndex = 21;
            this.cboClasificacionDplz.Tag = "";
            // 
            // lblCuentaDplz
            // 
            this.lblCuentaDplz.AutoSize = true;
            this.lblCuentaDplz.Location = new System.Drawing.Point(4, 9);
            this.lblCuentaDplz.Name = "lblCuentaDplz";
            this.lblCuentaDplz.Size = new System.Drawing.Size(52, 17);
            this.lblCuentaDplz.TabIndex = 92;
            this.lblCuentaDplz.Text = "Cuenta";
            // 
            // btnAgregarDplz
            // 
            this.btnAgregarDplz.Location = new System.Drawing.Point(350, 34);
            this.btnAgregarDplz.Name = "btnAgregarDplz";
            this.btnAgregarDplz.Size = new System.Drawing.Size(119, 28);
            this.btnAgregarDplz.TabIndex = 22;
            this.btnAgregarDplz.Text = "Agregar";
            this.btnAgregarDplz.UseVisualStyleBackColor = true;
            this.btnAgregarDplz.Click += new System.EventHandler(this.btnAgregarDplz_Click);
            // 
            // txtSaldoDplz
            // 
            this.txtSaldoDplz.Location = new System.Drawing.Point(444, 6);
            this.txtSaldoDplz.Name = "txtSaldoDplz";
            this.txtSaldoDplz.Size = new System.Drawing.Size(150, 22);
            this.txtSaldoDplz.TabIndex = 20;
            this.txtSaldoDplz.Tag = "";
            this.txtSaldoDplz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoDplz_KeyPress);
            // 
            // lblSaldoDplz
            // 
            this.lblSaldoDplz.AutoSize = true;
            this.lblSaldoDplz.Location = new System.Drawing.Point(347, 9);
            this.lblSaldoDplz.Name = "lblSaldoDplz";
            this.lblSaldoDplz.Size = new System.Drawing.Size(42, 17);
            this.lblSaldoDplz.TabIndex = 91;
            this.lblSaldoDplz.Text = "Saldo";
            // 
            // txtAbonos
            // 
            this.txtAbonos.Enabled = false;
            this.txtAbonos.Location = new System.Drawing.Point(497, 286);
            this.txtAbonos.Name = "txtAbonos";
            this.txtAbonos.Size = new System.Drawing.Size(95, 22);
            this.txtAbonos.TabIndex = 90;
            this.txtAbonos.Tag = "";
            // 
            // txtCargos
            // 
            this.txtCargos.Enabled = false;
            this.txtCargos.Location = new System.Drawing.Point(396, 286);
            this.txtCargos.Name = "txtCargos";
            this.txtCargos.Size = new System.Drawing.Size(95, 22);
            this.txtCargos.TabIndex = 89;
            this.txtCargos.Tag = "";
            // 
            // dgvDplz
            // 
            this.dgvDplz.AllowUserToAddRows = false;
            this.dgvDplz.AllowUserToDeleteRows = false;
            this.dgvDplz.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDplz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDplz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDplz.Location = new System.Drawing.Point(5, 68);
            this.dgvDplz.Name = "dgvDplz";
            this.dgvDplz.ReadOnly = true;
            this.dgvDplz.RowHeadersVisible = false;
            this.dgvDplz.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDplz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDplz.Size = new System.Drawing.Size(587, 212);
            this.dgvDplz.TabIndex = 88;
            // 
            // wfPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 472);
            this.Controls.Add(this.pnlDetallePlz);
            this.Controls.Add(this.cboEstadoPlz);
            this.Controls.Add(this.lblEstadoPlz);
            this.Controls.Add(this.txtFechemiPlz);
            this.Controls.Add(this.dtpFechemiPlz);
            this.Controls.Add(this.lblDetallePza);
            this.Controls.Add(this.txtDetallePlz);
            this.Controls.Add(this.lblFechEmisPza);
            this.Controls.Add(this.txtEstadoPlz);
            this.Controls.Add(this.txtNumPlz);
            this.Controls.Add(this.lblNumPza);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polizas";
            this.Load += new System.EventHandler(this.wfPolizas_Load);
            this.pnlDetallePlz.ResumeLayout(false);
            this.pnlDetallePlz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDplz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtDetallePlz;
        private System.Windows.Forms.Label lblFechEmisPza;
        private System.Windows.Forms.TextBox txtEstadoPlz;
        private System.Windows.Forms.TextBox txtNumPlz;
        private System.Windows.Forms.Label lblNumPza;
        private System.Windows.Forms.TextBox txtCodigoPlz;
        private System.Windows.Forms.Label lblCodigoPza;
        private System.Windows.Forms.Label lblDetallePza;
        private System.Windows.Forms.DateTimePicker dtpFechemiPlz;
        private System.Windows.Forms.TextBox txtFechemiPlz;
        private System.Windows.Forms.Label lblEstadoPlz;
        private System.Windows.Forms.ComboBox cboEstadoPlz;
        private System.Windows.Forms.Panel pnlDetallePlz;
        private System.Windows.Forms.ComboBox cboCuentaDplz;
        private System.Windows.Forms.ComboBox cboClasificacionDplz;
        private System.Windows.Forms.Label lblCuentaDplz;
        private System.Windows.Forms.Button btnAgregarDplz;
        private System.Windows.Forms.TextBox txtSaldoDplz;
        private System.Windows.Forms.Label lblSaldoDplz;
        private System.Windows.Forms.TextBox txtAbonos;
        private System.Windows.Forms.TextBox txtCargos;
        private System.Windows.Forms.DataGridView dgvDplz;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTipo;
       
    }
}