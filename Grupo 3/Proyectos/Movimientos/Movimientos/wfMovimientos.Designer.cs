namespace Movimientos
{
    partial class wfMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMovimientos));
            this.navegador1 = new Navegador.Navegador();
            this.lblCodMov = new System.Windows.Forms.Label();
            this.lblCodTmov = new System.Windows.Forms.Label();
            this.lblCodCtabco = new System.Windows.Forms.Label();
            this.lblFechmovMov = new System.Windows.Forms.Label();
            this.lblCorrelativoMov = new System.Windows.Forms.Label();
            this.lblDescripMov = new System.Windows.Forms.Label();
            this.lblDebitoMov = new System.Windows.Forms.Label();
            this.lblCreditoMov = new System.Windows.Forms.Label();
            this.lblEstadoMov = new System.Windows.Forms.Label();
            this.txtCodMov = new System.Windows.Forms.TextBox();
            this.txtCodTmov = new System.Windows.Forms.TextBox();
            this.txtCodCtabco = new System.Windows.Forms.TextBox();
            this.txtFechmovMov = new System.Windows.Forms.TextBox();
            this.txtCorrelativoMov = new System.Windows.Forms.TextBox();
            this.txtDescripMov = new System.Windows.Forms.TextBox();
            this.txtDebitoMov = new System.Windows.Forms.TextBox();
            this.txtCreditoMov = new System.Windows.Forms.TextBox();
            this.txtEstadoMov = new System.Windows.Forms.TextBox();
            this.cboEstadoMov = new System.Windows.Forms.ComboBox();
            this.dtpFechMov = new System.Windows.Forms.DateTimePicker();
            this.txtCod_Emp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod_Mon = new System.Windows.Forms.TextBox();
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
            this.navegador1.sNombreTabla = "tabm_movimiento";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterGuardar += new System.EventHandler(this.navegador1_btnAfterGuardar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblCodMov
            // 
            this.lblCodMov.AutoSize = true;
            this.lblCodMov.Location = new System.Drawing.Point(12, 75);
            this.lblCodMov.Name = "lblCodMov";
            this.lblCodMov.Size = new System.Drawing.Size(52, 17);
            this.lblCodMov.TabIndex = 1;
            this.lblCodMov.Text = "Codigo";
            // 
            // lblCodTmov
            // 
            this.lblCodTmov.AutoSize = true;
            this.lblCodTmov.Location = new System.Drawing.Point(339, 101);
            this.lblCodTmov.Name = "lblCodTmov";
            this.lblCodTmov.Size = new System.Drawing.Size(107, 17);
            this.lblCodTmov.TabIndex = 2;
            this.lblCodTmov.Text = "Tipo Movimiento";
            // 
            // lblCodCtabco
            // 
            this.lblCodCtabco.AutoSize = true;
            this.lblCodCtabco.Location = new System.Drawing.Point(12, 131);
            this.lblCodCtabco.Name = "lblCodCtabco";
            this.lblCodCtabco.Size = new System.Drawing.Size(52, 17);
            this.lblCodCtabco.TabIndex = 3;
            this.lblCodCtabco.Text = "Cuenta";
            // 
            // lblFechmovMov
            // 
            this.lblFechmovMov.AutoSize = true;
            this.lblFechmovMov.Location = new System.Drawing.Point(12, 161);
            this.lblFechmovMov.Name = "lblFechmovMov";
            this.lblFechmovMov.Size = new System.Drawing.Size(45, 17);
            this.lblFechmovMov.TabIndex = 4;
            this.lblFechmovMov.Text = "Fecha";
            // 
            // lblCorrelativoMov
            // 
            this.lblCorrelativoMov.AutoSize = true;
            this.lblCorrelativoMov.Location = new System.Drawing.Point(339, 159);
            this.lblCorrelativoMov.Name = "lblCorrelativoMov";
            this.lblCorrelativoMov.Size = new System.Drawing.Size(76, 17);
            this.lblCorrelativoMov.TabIndex = 5;
            this.lblCorrelativoMov.Text = "Correlativo";
            // 
            // lblDescripMov
            // 
            this.lblDescripMov.AutoSize = true;
            this.lblDescripMov.Location = new System.Drawing.Point(12, 187);
            this.lblDescripMov.Name = "lblDescripMov";
            this.lblDescripMov.Size = new System.Drawing.Size(79, 17);
            this.lblDescripMov.TabIndex = 6;
            this.lblDescripMov.Text = "Descripcion";
            // 
            // lblDebitoMov
            // 
            this.lblDebitoMov.AutoSize = true;
            this.lblDebitoMov.Location = new System.Drawing.Point(11, 215);
            this.lblDebitoMov.Name = "lblDebitoMov";
            this.lblDebitoMov.Size = new System.Drawing.Size(49, 17);
            this.lblDebitoMov.TabIndex = 7;
            this.lblDebitoMov.Text = "Debito";
            // 
            // lblCreditoMov
            // 
            this.lblCreditoMov.AutoSize = true;
            this.lblCreditoMov.Location = new System.Drawing.Point(339, 211);
            this.lblCreditoMov.Name = "lblCreditoMov";
            this.lblCreditoMov.Size = new System.Drawing.Size(53, 17);
            this.lblCreditoMov.TabIndex = 8;
            this.lblCreditoMov.Text = "Credito";
            // 
            // lblEstadoMov
            // 
            this.lblEstadoMov.AutoSize = true;
            this.lblEstadoMov.Location = new System.Drawing.Point(11, 243);
            this.lblEstadoMov.Name = "lblEstadoMov";
            this.lblEstadoMov.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoMov.TabIndex = 10;
            this.lblEstadoMov.Text = "Estado";
            // 
            // txtCodMov
            // 
            this.txtCodMov.Location = new System.Drawing.Point(125, 70);
            this.txtCodMov.MaxLength = 7;
            this.txtCodMov.Name = "txtCodMov";
            this.txtCodMov.Size = new System.Drawing.Size(150, 22);
            this.txtCodMov.TabIndex = 14;
            this.txtCodMov.Tag = "cod_mov";
            this.txtCodMov.EnabledChanged += new System.EventHandler(this.txtCodMov_EnabledChanged);
            this.txtCodMov.TextChanged += new System.EventHandler(this.txtCodMov_TextChanged);
            // 
            // txtCodTmov
            // 
            this.txtCodTmov.Location = new System.Drawing.Point(452, 98);
            this.txtCodTmov.MaxLength = 7;
            this.txtCodTmov.Name = "txtCodTmov";
            this.txtCodTmov.Size = new System.Drawing.Size(150, 22);
            this.txtCodTmov.TabIndex = 17;
            this.txtCodTmov.Tag = "cod_tmov";
            this.txtCodTmov.Enter += new System.EventHandler(this.txtCodTmov_Enter);
            this.txtCodTmov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodTmov_KeyPress);
            // 
            // txtCodCtabco
            // 
            this.txtCodCtabco.Location = new System.Drawing.Point(125, 128);
            this.txtCodCtabco.MaxLength = 7;
            this.txtCodCtabco.Name = "txtCodCtabco";
            this.txtCodCtabco.Size = new System.Drawing.Size(150, 22);
            this.txtCodCtabco.TabIndex = 18;
            this.txtCodCtabco.Tag = "cod_ctabco";
            this.txtCodCtabco.Enter += new System.EventHandler(this.txtCodCtabco_Enter);
            this.txtCodCtabco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCtabco_KeyPress);
            // 
            // txtFechmovMov
            // 
            this.txtFechmovMov.Location = new System.Drawing.Point(281, 158);
            this.txtFechmovMov.MaxLength = 25;
            this.txtFechmovMov.Name = "txtFechmovMov";
            this.txtFechmovMov.Size = new System.Drawing.Size(22, 22);
            this.txtFechmovMov.TabIndex = 20;
            this.txtFechmovMov.Tag = "fechmov_mov";
            this.txtFechmovMov.Visible = false;
            this.txtFechmovMov.EnabledChanged += new System.EventHandler(this.txtFechmovMov_EnabledChanged);
            this.txtFechmovMov.TextChanged += new System.EventHandler(this.txtFechmovMov_TextChanged);
            // 
            // txtCorrelativoMov
            // 
            this.txtCorrelativoMov.Location = new System.Drawing.Point(452, 156);
            this.txtCorrelativoMov.MaxLength = 15;
            this.txtCorrelativoMov.Name = "txtCorrelativoMov";
            this.txtCorrelativoMov.Size = new System.Drawing.Size(150, 22);
            this.txtCorrelativoMov.TabIndex = 21;
            this.txtCorrelativoMov.Tag = "correlativo_mov";
            this.txtCorrelativoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrelativoMov_KeyPress);
            // 
            // txtDescripMov
            // 
            this.txtDescripMov.Location = new System.Drawing.Point(125, 184);
            this.txtDescripMov.MaxLength = 100;
            this.txtDescripMov.Name = "txtDescripMov";
            this.txtDescripMov.Size = new System.Drawing.Size(150, 22);
            this.txtDescripMov.TabIndex = 22;
            this.txtDescripMov.Tag = "descrip_mov";
            this.txtDescripMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripMov_KeyPress);
            // 
            // txtDebitoMov
            // 
            this.txtDebitoMov.Location = new System.Drawing.Point(125, 212);
            this.txtDebitoMov.MaxLength = 25;
            this.txtDebitoMov.Name = "txtDebitoMov";
            this.txtDebitoMov.Size = new System.Drawing.Size(150, 22);
            this.txtDebitoMov.TabIndex = 23;
            this.txtDebitoMov.Tag = "debito_mov";
            this.txtDebitoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitoMov_KeyPress);
            // 
            // txtCreditoMov
            // 
            this.txtCreditoMov.Location = new System.Drawing.Point(452, 208);
            this.txtCreditoMov.MaxLength = 25;
            this.txtCreditoMov.Name = "txtCreditoMov";
            this.txtCreditoMov.Size = new System.Drawing.Size(150, 22);
            this.txtCreditoMov.TabIndex = 24;
            this.txtCreditoMov.Tag = "credito_mov";
            this.txtCreditoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditoMov_KeyPress);
            // 
            // txtEstadoMov
            // 
            this.txtEstadoMov.Location = new System.Drawing.Point(281, 240);
            this.txtEstadoMov.MaxLength = 1;
            this.txtEstadoMov.Name = "txtEstadoMov";
            this.txtEstadoMov.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoMov.TabIndex = 26;
            this.txtEstadoMov.Tag = "estado_mov";
            this.txtEstadoMov.Visible = false;
            this.txtEstadoMov.EnabledChanged += new System.EventHandler(this.txtEstadoMov_EnabledChanged);
            this.txtEstadoMov.TextChanged += new System.EventHandler(this.txtEstadoMov_TextChanged);
            // 
            // cboEstadoMov
            // 
            this.cboEstadoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoMov.FormattingEnabled = true;
            this.cboEstadoMov.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoMov.Location = new System.Drawing.Point(125, 240);
            this.cboEstadoMov.Name = "cboEstadoMov";
            this.cboEstadoMov.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoMov.TabIndex = 25;
            this.cboEstadoMov.SelectedIndexChanged += new System.EventHandler(this.cboEstadoMov_SelectedIndexChanged);
            // 
            // dtpFechMov
            // 
            this.dtpFechMov.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechMov.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechMov.Location = new System.Drawing.Point(125, 156);
            this.dtpFechMov.Name = "dtpFechMov";
            this.dtpFechMov.ShowUpDown = true;
            this.dtpFechMov.Size = new System.Drawing.Size(150, 22);
            this.dtpFechMov.TabIndex = 19;
            this.dtpFechMov.ValueChanged += new System.EventHandler(this.dtpFechMov_ValueChanged);
            // 
            // txtCod_Emp
            // 
            this.txtCod_Emp.Location = new System.Drawing.Point(452, 70);
            this.txtCod_Emp.Name = "txtCod_Emp";
            this.txtCod_Emp.Size = new System.Drawing.Size(150, 22);
            this.txtCod_Emp.TabIndex = 15;
            this.txtCod_Emp.Tag = "cod_empsa";
            this.txtCod_Emp.Enter += new System.EventHandler(this.txtCod_Emp_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Codigo Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo Moneda";
            // 
            // txtCod_Mon
            // 
            this.txtCod_Mon.Location = new System.Drawing.Point(125, 100);
            this.txtCod_Mon.Name = "txtCod_Mon";
            this.txtCod_Mon.Size = new System.Drawing.Size(150, 22);
            this.txtCod_Mon.TabIndex = 16;
            this.txtCod_Mon.Tag = "cod_mda";
            this.txtCod_Mon.Enter += new System.EventHandler(this.txtCod_Mon_Enter);
            // 
            // wfMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 276);
            this.Controls.Add(this.txtCod_Mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCod_Emp);
            this.Controls.Add(this.dtpFechMov);
            this.Controls.Add(this.cboEstadoMov);
            this.Controls.Add(this.txtEstadoMov);
            this.Controls.Add(this.txtCreditoMov);
            this.Controls.Add(this.txtDebitoMov);
            this.Controls.Add(this.txtDescripMov);
            this.Controls.Add(this.txtCorrelativoMov);
            this.Controls.Add(this.txtFechmovMov);
            this.Controls.Add(this.txtCodCtabco);
            this.Controls.Add(this.txtCodTmov);
            this.Controls.Add(this.txtCodMov);
            this.Controls.Add(this.lblEstadoMov);
            this.Controls.Add(this.lblCreditoMov);
            this.Controls.Add(this.lblDebitoMov);
            this.Controls.Add(this.lblDescripMov);
            this.Controls.Add(this.lblCorrelativoMov);
            this.Controls.Add(this.lblFechmovMov);
            this.Controls.Add(this.lblCodCtabco);
            this.Controls.Add(this.lblCodTmov);
            this.Controls.Add(this.lblCodMov);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfMovimientos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.wfMovimientos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodMov;
        private System.Windows.Forms.Label lblCodTmov;
        private System.Windows.Forms.Label lblCodCtabco;
        private System.Windows.Forms.Label lblFechmovMov;
        private System.Windows.Forms.Label lblCorrelativoMov;
        private System.Windows.Forms.Label lblDescripMov;
        private System.Windows.Forms.Label lblDebitoMov;
        private System.Windows.Forms.Label lblCreditoMov;
        private System.Windows.Forms.Label lblEstadoMov;
        private System.Windows.Forms.TextBox txtCodMov;
        private System.Windows.Forms.TextBox txtCodTmov;
        private System.Windows.Forms.TextBox txtCodCtabco;
        private System.Windows.Forms.TextBox txtFechmovMov;
        private System.Windows.Forms.TextBox txtCorrelativoMov;
        private System.Windows.Forms.TextBox txtDescripMov;
        private System.Windows.Forms.TextBox txtDebitoMov;
        private System.Windows.Forms.TextBox txtCreditoMov;
        private System.Windows.Forms.TextBox txtEstadoMov;
        private System.Windows.Forms.ComboBox cboEstadoMov;
        private System.Windows.Forms.DateTimePicker dtpFechMov;
        private System.Windows.Forms.TextBox txtCod_Emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod_Mon;
    }
}