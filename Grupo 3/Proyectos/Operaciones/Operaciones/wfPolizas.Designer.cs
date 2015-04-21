namespace Contable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPolizas));
            this.navegador1 = new Navegador.Navegador();
            this.txtDetallePza = new System.Windows.Forms.TextBox();
            this.txtFechEmisPza = new System.Windows.Forms.TextBox();
            this.lblFechEmisPza = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cboEstadoPza = new System.Windows.Forms.ComboBox();
            this.txtEstadoPza = new System.Windows.Forms.TextBox();
            this.lblEstadoPza = new System.Windows.Forms.Label();
            this.txtNumPza = new System.Windows.Forms.TextBox();
            this.lblNumPza = new System.Windows.Forms.Label();
            this.txtCodEmpsa = new System.Windows.Forms.TextBox();
            this.lblCodEmpsa = new System.Windows.Forms.Label();
            this.txtCodigoPza = new System.Windows.Forms.TextBox();
            this.lblCodigoPza = new System.Windows.Forms.Label();
            this.lblDetallePza = new System.Windows.Forms.Label();
            this.txtCargos = new System.Windows.Forms.TextBox();
            this.txtAbonos = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsDatos = new Operaciones.dsDatos();
            this.dtPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtaPoliza = new Operaciones.dsDatosTableAdapters.dtaPoliza();
            this.Nomenclatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPolizaBindingSource)).BeginInit();
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
            this.navegador1.sNombreTabla = "";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            // 
            // txtDetallePza
            // 
            this.txtDetallePza.Location = new System.Drawing.Point(451, 117);
            this.txtDetallePza.Name = "txtDetallePza";
            this.txtDetallePza.Size = new System.Drawing.Size(150, 22);
            this.txtDetallePza.TabIndex = 7;
            this.txtDetallePza.Tag = "descrip_plz";
            // 
            // txtFechEmisPza
            // 
            this.txtFechEmisPza.Location = new System.Drawing.Point(109, 117);
            this.txtFechEmisPza.Name = "txtFechEmisPza";
            this.txtFechEmisPza.Size = new System.Drawing.Size(150, 22);
            this.txtFechEmisPza.TabIndex = 6;
            this.txtFechEmisPza.Tag = "fechemi_plz";
            // 
            // lblFechEmisPza
            // 
            this.lblFechEmisPza.AutoSize = true;
            this.lblFechEmisPza.Location = new System.Drawing.Point(12, 120);
            this.lblFechEmisPza.Name = "lblFechEmisPza";
            this.lblFechEmisPza.Size = new System.Drawing.Size(91, 17);
            this.lblFechEmisPza.TabIndex = 6;
            this.lblFechEmisPza.Text = "Fecha Emisión";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(109, 89);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(150, 22);
            this.txtMoneda.TabIndex = 3;
            this.txtMoneda.Tag = "cod_mda";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(12, 92);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(58, 17);
            this.lblMoneda.TabIndex = 3;
            this.lblMoneda.Text = "Moneda";
            // 
            // cboEstadoPza
            // 
            this.cboEstadoPza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPza.FormattingEnabled = true;
            this.cboEstadoPza.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoPza.Location = new System.Drawing.Point(452, 145);
            this.cboEstadoPza.Name = "cboEstadoPza";
            this.cboEstadoPza.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoPza.TabIndex = 10;
            this.cboEstadoPza.Tag = "";
            this.cboEstadoPza.SelectedIndexChanged += new System.EventHandler(this.cboEstadoPza_SelectedIndexChanged);
            // 
            // txtEstadoPza
            // 
            this.txtEstadoPza.Location = new System.Drawing.Point(357, 145);
            this.txtEstadoPza.Name = "txtEstadoPza";
            this.txtEstadoPza.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoPza.TabIndex = 35;
            this.txtEstadoPza.Tag = "estado_plz";
            this.txtEstadoPza.Visible = false;
            this.txtEstadoPza.TextChanged += new System.EventHandler(this.txtEstadoPza_TextChanged);
            // 
            // lblEstadoPza
            // 
            this.lblEstadoPza.AutoSize = true;
            this.lblEstadoPza.Location = new System.Drawing.Point(388, 148);
            this.lblEstadoPza.Name = "lblEstadoPza";
            this.lblEstadoPza.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoPza.TabIndex = 34;
            this.lblEstadoPza.Tag = "10";
            this.lblEstadoPza.Text = "Estado";
            // 
            // txtNumPza
            // 
            this.txtNumPza.Location = new System.Drawing.Point(452, 89);
            this.txtNumPza.Name = "txtNumPza";
            this.txtNumPza.Size = new System.Drawing.Size(150, 22);
            this.txtNumPza.TabIndex = 4;
            this.txtNumPza.Tag = "num_plz";
            // 
            // lblNumPza
            // 
            this.lblNumPza.AutoSize = true;
            this.lblNumPza.Location = new System.Drawing.Point(388, 92);
            this.lblNumPza.Name = "lblNumPza";
            this.lblNumPza.Size = new System.Drawing.Size(55, 17);
            this.lblNumPza.TabIndex = 4;
            this.lblNumPza.Text = "Número";
            // 
            // txtCodEmpsa
            // 
            this.txtCodEmpsa.Location = new System.Drawing.Point(452, 61);
            this.txtCodEmpsa.Name = "txtCodEmpsa";
            this.txtCodEmpsa.Size = new System.Drawing.Size(150, 22);
            this.txtCodEmpsa.TabIndex = 2;
            this.txtCodEmpsa.Tag = "cod_empsa";
            // 
            // lblCodEmpsa
            // 
            this.lblCodEmpsa.AutoSize = true;
            this.lblCodEmpsa.Location = new System.Drawing.Point(388, 64);
            this.lblCodEmpsa.Name = "lblCodEmpsa";
            this.lblCodEmpsa.Size = new System.Drawing.Size(58, 17);
            this.lblCodEmpsa.TabIndex = 2;
            this.lblCodEmpsa.Text = "Empresa";
            // 
            // txtCodigoPza
            // 
            this.txtCodigoPza.Location = new System.Drawing.Point(109, 61);
            this.txtCodigoPza.Name = "txtCodigoPza";
            this.txtCodigoPza.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoPza.TabIndex = 1;
            this.txtCodigoPza.Tag = "cod_plz";
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
            this.lblDetallePza.Location = new System.Drawing.Point(388, 120);
            this.lblDetallePza.Name = "lblDetallePza";
            this.lblDetallePza.Size = new System.Drawing.Size(52, 17);
            this.lblDetallePza.TabIndex = 7;
            this.lblDetallePza.Text = "Detalle";
            // 
            // txtCargos
            // 
            this.txtCargos.Location = new System.Drawing.Point(357, 367);
            this.txtCargos.Name = "txtCargos";
            this.txtCargos.Size = new System.Drawing.Size(120, 22);
            this.txtCargos.TabIndex = 37;
            this.txtCargos.Tag = "";
            // 
            // txtAbonos
            // 
            this.txtAbonos.Location = new System.Drawing.Point(481, 367);
            this.txtAbonos.Name = "txtAbonos";
            this.txtAbonos.Size = new System.Drawing.Size(120, 22);
            this.txtAbonos.TabIndex = 39;
            this.txtAbonos.Tag = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomenclatura,
            this.Cuenta,
            this.Cargo,
            this.Abono});
            this.dataGridView1.DataSource = this.dtPolizaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(589, 176);
            this.dataGridView1.TabIndex = 36;
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "dsDatos";
            this.dsDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtaPoliza
            // 
            this.dtaPoliza.ClearBeforeFill = true;
            // 
            // Nomenclatura
            // 
            this.Nomenclatura.HeaderText = "Nomenc.";
            this.Nomenclatura.Name = "Nomenclatura";
            this.Nomenclatura.ReadOnly = true;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Width = 205;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 120;
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.Name = "Abono";
            this.Abono.ReadOnly = true;
            this.Abono.Width = 120;
            // 
            // wfPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 404);
            this.Controls.Add(this.txtAbonos);
            this.Controls.Add(this.txtCargos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDetallePza);
            this.Controls.Add(this.txtDetallePza);
            this.Controls.Add(this.txtFechEmisPza);
            this.Controls.Add(this.lblFechEmisPza);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.cboEstadoPza);
            this.Controls.Add(this.txtEstadoPza);
            this.Controls.Add(this.lblEstadoPza);
            this.Controls.Add(this.txtNumPza);
            this.Controls.Add(this.lblNumPza);
            this.Controls.Add(this.txtCodEmpsa);
            this.Controls.Add(this.lblCodEmpsa);
            this.Controls.Add(this.txtCodigoPza);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPolizaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtDetallePza;
        private System.Windows.Forms.TextBox txtFechEmisPza;
        private System.Windows.Forms.Label lblFechEmisPza;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cboEstadoPza;
        private System.Windows.Forms.TextBox txtEstadoPza;
        private System.Windows.Forms.Label lblEstadoPza;
        private System.Windows.Forms.TextBox txtNumPza;
        private System.Windows.Forms.Label lblNumPza;
        private System.Windows.Forms.TextBox txtCodEmpsa;
        private System.Windows.Forms.Label lblCodEmpsa;
        private System.Windows.Forms.TextBox txtCodigoPza;
        private System.Windows.Forms.Label lblCodigoPza;
        private System.Windows.Forms.Label lblDetallePza;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCargos;
        private System.Windows.Forms.TextBox txtAbonos;
        private Operaciones.dsDatos dsDatos;
        private System.Windows.Forms.BindingSource dtPolizaBindingSource;
        private Operaciones.dsDatosTableAdapters.dtaPoliza dtaPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomenclatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
       
    }
}