namespace Operaciones
{
    partial class wfAmortDep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAmortDep));
            this.lblEstadoAmort = new System.Windows.Forms.Label();
            this.lblCodAmort = new System.Windows.Forms.Label();
            this.cboEstadoAmort = new System.Windows.Forms.ComboBox();
            this.txtEstadoAmortDep = new System.Windows.Forms.TextBox();
            this.txtCodAmortDep = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblInteresAmort = new System.Windows.Forms.Label();
            this.txtCuentaCta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInteresAmortDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodosAmortDep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorAmortDep = new System.Windows.Forms.TextBox();
            this.btnCalcularAmortDep = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlAmortDep = new System.Windows.Forms.Panel();
            this.dgvDetalleAmort = new System.Windows.Forms.DataGridView();
            this.pnlAmortDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAmort)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstadoAmort
            // 
            this.lblEstadoAmort.AutoSize = true;
            this.lblEstadoAmort.Location = new System.Drawing.Point(351, 131);
            this.lblEstadoAmort.Name = "lblEstadoAmort";
            this.lblEstadoAmort.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoAmort.TabIndex = 28;
            this.lblEstadoAmort.Text = "Estado";
            // 
            // lblCodAmort
            // 
            this.lblCodAmort.AutoSize = true;
            this.lblCodAmort.Location = new System.Drawing.Point(12, 71);
            this.lblCodAmort.Name = "lblCodAmort";
            this.lblCodAmort.Size = new System.Drawing.Size(52, 17);
            this.lblCodAmort.TabIndex = 26;
            this.lblCodAmort.Text = "Codigo";
            // 
            // cboEstadoAmort
            // 
            this.cboEstadoAmort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoAmort.FormattingEnabled = true;
            this.cboEstadoAmort.IntegralHeight = false;
            this.cboEstadoAmort.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstadoAmort.Location = new System.Drawing.Point(452, 128);
            this.cboEstadoAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstadoAmort.Name = "cboEstadoAmort";
            this.cboEstadoAmort.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoAmort.TabIndex = 19;
            this.cboEstadoAmort.SelectedIndexChanged += new System.EventHandler(this.cboEstado_amortizacion_SelectedIndexChanged);
            // 
            // txtEstadoAmortDep
            // 
            this.txtEstadoAmortDep.Location = new System.Drawing.Point(318, 128);
            this.txtEstadoAmortDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstadoAmortDep.MaxLength = 1;
            this.txtEstadoAmortDep.Name = "txtEstadoAmortDep";
            this.txtEstadoAmortDep.Size = new System.Drawing.Size(27, 22);
            this.txtEstadoAmortDep.TabIndex = 20;
            this.txtEstadoAmortDep.Tag = "estado_amortdep";
            this.txtEstadoAmortDep.Visible = false;
            this.txtEstadoAmortDep.EnabledChanged += new System.EventHandler(this.txtEstadoAmortDep_EnabledChanged);
            this.txtEstadoAmortDep.TextChanged += new System.EventHandler(this.txtEstado_amortizacion_TextChanged);
            // 
            // txtCodAmortDep
            // 
            this.txtCodAmortDep.Enabled = false;
            this.txtCodAmortDep.Location = new System.Drawing.Point(120, 68);
            this.txtCodAmortDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodAmortDep.MaxLength = 4;
            this.txtCodAmortDep.Name = "txtCodAmortDep";
            this.txtCodAmortDep.Size = new System.Drawing.Size(150, 22);
            this.txtCodAmortDep.TabIndex = 14;
            this.txtCodAmortDep.Tag = "cod_amortdep";
            this.txtCodAmortDep.EnabledChanged += new System.EventHandler(this.txtCod_amortizacion_EnabledChanged);
            this.txtCodAmortDep.TextChanged += new System.EventHandler(this.txtCodAmortDep_TextChanged);
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
            this.navegador1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navegador1.Size = new System.Drawing.Size(614, 55);
            this.navegador1.sNombreTabla = "tabm_amortdep";
            this.navegador1.TabIndex = 35;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterGuardar += new System.EventHandler(this.navegador1_btnAfterGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblInteresAmort
            // 
            this.lblInteresAmort.AutoSize = true;
            this.lblInteresAmort.Location = new System.Drawing.Point(351, 71);
            this.lblInteresAmort.Name = "lblInteresAmort";
            this.lblInteresAmort.Size = new System.Drawing.Size(52, 17);
            this.lblInteresAmort.TabIndex = 41;
            this.lblInteresAmort.Text = "Cuenta";
            // 
            // txtCuentaCta
            // 
            this.txtCuentaCta.Enabled = false;
            this.txtCuentaCta.Location = new System.Drawing.Point(452, 68);
            this.txtCuentaCta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCuentaCta.MaxLength = 4;
            this.txtCuentaCta.Name = "txtCuentaCta";
            this.txtCuentaCta.Size = new System.Drawing.Size(150, 22);
            this.txtCuentaCta.TabIndex = 15;
            this.txtCuentaCta.Tag = "cod_cta";
            this.txtCuentaCta.Enter += new System.EventHandler(this.txtCuentaCta_Enter);
            this.txtCuentaCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaCta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 91;
            this.label2.Tag = "interes_amortdep";
            this.label2.Text = "interés";
            // 
            // txtInteresAmortDep
            // 
            this.txtInteresAmortDep.Location = new System.Drawing.Point(120, 128);
            this.txtInteresAmortDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInteresAmortDep.MaxLength = 25;
            this.txtInteresAmortDep.Name = "txtInteresAmortDep";
            this.txtInteresAmortDep.Size = new System.Drawing.Size(150, 22);
            this.txtInteresAmortDep.TabIndex = 18;
            this.txtInteresAmortDep.Tag = "interes_amortdep";
            this.txtInteresAmortDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteresAmortDep_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "No. de períodos";
            // 
            // txtPeriodosAmortDep
            // 
            this.txtPeriodosAmortDep.Enabled = false;
            this.txtPeriodosAmortDep.Location = new System.Drawing.Point(120, 98);
            this.txtPeriodosAmortDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPeriodosAmortDep.MaxLength = 4;
            this.txtPeriodosAmortDep.Name = "txtPeriodosAmortDep";
            this.txtPeriodosAmortDep.Size = new System.Drawing.Size(150, 22);
            this.txtPeriodosAmortDep.TabIndex = 16;
            this.txtPeriodosAmortDep.Tag = "periodos_amortdep";
            this.txtPeriodosAmortDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodosAmortDep_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Valor principal";
            // 
            // txtValorAmortDep
            // 
            this.txtValorAmortDep.Enabled = false;
            this.txtValorAmortDep.Location = new System.Drawing.Point(452, 98);
            this.txtValorAmortDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorAmortDep.MaxLength = 4;
            this.txtValorAmortDep.Name = "txtValorAmortDep";
            this.txtValorAmortDep.Size = new System.Drawing.Size(150, 22);
            this.txtValorAmortDep.TabIndex = 17;
            this.txtValorAmortDep.Tag = "valorp_amortdep";
            this.txtValorAmortDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAmortDep_KeyPress);
            // 
            // btnCalcularAmortDep
            // 
            this.btnCalcularAmortDep.Location = new System.Drawing.Point(349, 5);
            this.btnCalcularAmortDep.Name = "btnCalcularAmortDep";
            this.btnCalcularAmortDep.Size = new System.Drawing.Size(119, 28);
            this.btnCalcularAmortDep.TabIndex = 20;
            this.btnCalcularAmortDep.Text = "Calcular";
            this.btnCalcularAmortDep.UseVisualStyleBackColor = true;
            this.btnCalcularAmortDep.Click += new System.EventHandler(this.btnCalcularAmortDep_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(474, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 28);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlAmortDep
            // 
            this.pnlAmortDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmortDep.Controls.Add(this.dgvDetalleAmort);
            this.pnlAmortDep.Controls.Add(this.btnEliminar);
            this.pnlAmortDep.Controls.Add(this.btnCalcularAmortDep);
            this.pnlAmortDep.Location = new System.Drawing.Point(8, 160);
            this.pnlAmortDep.Name = "pnlAmortDep";
            this.pnlAmortDep.Size = new System.Drawing.Size(599, 257);
            this.pnlAmortDep.TabIndex = 99;
            // 
            // dgvDetalleAmort
            // 
            this.dgvDetalleAmort.AllowUserToAddRows = false;
            this.dgvDetalleAmort.AllowUserToDeleteRows = false;
            this.dgvDetalleAmort.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDetalleAmort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleAmort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleAmort.Location = new System.Drawing.Point(6, 39);
            this.dgvDetalleAmort.Name = "dgvDetalleAmort";
            this.dgvDetalleAmort.ReadOnly = true;
            this.dgvDetalleAmort.RowHeadersVisible = false;
            this.dgvDetalleAmort.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleAmort.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleAmort.Size = new System.Drawing.Size(587, 212);
            this.dgvDetalleAmort.TabIndex = 93;
            // 
            // wfAmortDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 429);
            this.Controls.Add(this.pnlAmortDep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorAmortDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeriodosAmortDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInteresAmortDep);
            this.Controls.Add(this.lblInteresAmort);
            this.Controls.Add(this.txtCuentaCta);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblEstadoAmort);
            this.Controls.Add(this.lblCodAmort);
            this.Controls.Add(this.cboEstadoAmort);
            this.Controls.Add(this.txtEstadoAmortDep);
            this.Controls.Add(this.txtCodAmortDep);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfAmortDep";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amortizaciones - Depreciaciones";
            this.Load += new System.EventHandler(this.wfAmortizacion_Load);
            this.pnlAmortDep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAmort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstadoAmort;
        private System.Windows.Forms.Label lblCodAmort;
        private System.Windows.Forms.ComboBox cboEstadoAmort;
        private System.Windows.Forms.TextBox txtEstadoAmortDep;
        private System.Windows.Forms.TextBox txtCodAmortDep;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblInteresAmort;
        private System.Windows.Forms.TextBox txtCuentaCta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInteresAmortDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeriodosAmortDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorAmortDep;
        private System.Windows.Forms.Button btnCalcularAmortDep;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlAmortDep;
        private System.Windows.Forms.DataGridView dgvDetalleAmort;
    }
}