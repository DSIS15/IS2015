namespace Financiero
{
    partial class wfMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMovimiento));
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
            this.dtpFechmovMov = new System.Windows.Forms.DateTimePicker();
            this.cboEstadoMov = new System.Windows.Forms.ComboBox();
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
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblCodMov
            // 
            this.lblCodMov.AutoSize = true;
            this.lblCodMov.Location = new System.Drawing.Point(12, 73);
            this.lblCodMov.Name = "lblCodMov";
            this.lblCodMov.Size = new System.Drawing.Size(52, 17);
            this.lblCodMov.TabIndex = 1;
            this.lblCodMov.Text = "Codigo";
            // 
            // lblCodTmov
            // 
            this.lblCodTmov.AutoSize = true;
            this.lblCodTmov.Location = new System.Drawing.Point(339, 73);
            this.lblCodTmov.Name = "lblCodTmov";
            this.lblCodTmov.Size = new System.Drawing.Size(107, 17);
            this.lblCodTmov.TabIndex = 2;
            this.lblCodTmov.Text = "Tipo Movimiento";
            // 
            // lblCodCtabco
            // 
            this.lblCodCtabco.AutoSize = true;
            this.lblCodCtabco.Location = new System.Drawing.Point(12, 101);
            this.lblCodCtabco.Name = "lblCodCtabco";
            this.lblCodCtabco.Size = new System.Drawing.Size(52, 17);
            this.lblCodCtabco.TabIndex = 3;
            this.lblCodCtabco.Text = "Cuenta";
            // 
            // lblFechmovMov
            // 
            this.lblFechmovMov.AutoSize = true;
            this.lblFechmovMov.Location = new System.Drawing.Point(12, 131);
            this.lblFechmovMov.Name = "lblFechmovMov";
            this.lblFechmovMov.Size = new System.Drawing.Size(45, 17);
            this.lblFechmovMov.TabIndex = 4;
            this.lblFechmovMov.Text = "Fecha";
            // 
            // lblCorrelativoMov
            // 
            this.lblCorrelativoMov.AutoSize = true;
            this.lblCorrelativoMov.Location = new System.Drawing.Point(339, 129);
            this.lblCorrelativoMov.Name = "lblCorrelativoMov";
            this.lblCorrelativoMov.Size = new System.Drawing.Size(76, 17);
            this.lblCorrelativoMov.TabIndex = 5;
            this.lblCorrelativoMov.Text = "Correlativo";
            // 
            // lblDescripMov
            // 
            this.lblDescripMov.AutoSize = true;
            this.lblDescripMov.Location = new System.Drawing.Point(12, 157);
            this.lblDescripMov.Name = "lblDescripMov";
            this.lblDescripMov.Size = new System.Drawing.Size(79, 17);
            this.lblDescripMov.TabIndex = 6;
            this.lblDescripMov.Text = "Descripcion";
            // 
            // lblDebitoMov
            // 
            this.lblDebitoMov.AutoSize = true;
            this.lblDebitoMov.Location = new System.Drawing.Point(12, 185);
            this.lblDebitoMov.Name = "lblDebitoMov";
            this.lblDebitoMov.Size = new System.Drawing.Size(49, 17);
            this.lblDebitoMov.TabIndex = 7;
            this.lblDebitoMov.Text = "Debito";
            // 
            // lblCreditoMov
            // 
            this.lblCreditoMov.AutoSize = true;
            this.lblCreditoMov.Location = new System.Drawing.Point(339, 185);
            this.lblCreditoMov.Name = "lblCreditoMov";
            this.lblCreditoMov.Size = new System.Drawing.Size(53, 17);
            this.lblCreditoMov.TabIndex = 8;
            this.lblCreditoMov.Text = "Credito";
            // 
            // lblEstadoMov
            // 
            this.lblEstadoMov.AutoSize = true;
            this.lblEstadoMov.Location = new System.Drawing.Point(12, 213);
            this.lblEstadoMov.Name = "lblEstadoMov";
            this.lblEstadoMov.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoMov.TabIndex = 10;
            this.lblEstadoMov.Text = "Estado";
            // 
            // txtCodMov
            // 
            this.txtCodMov.Location = new System.Drawing.Point(97, 70);
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
            this.txtCodTmov.Location = new System.Drawing.Point(452, 70);
            this.txtCodTmov.MaxLength = 7;
            this.txtCodTmov.Name = "txtCodTmov";
            this.txtCodTmov.Size = new System.Drawing.Size(150, 22);
            this.txtCodTmov.TabIndex = 15;
            this.txtCodTmov.Tag = "cod_tmov";
            this.txtCodTmov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodTmov_KeyPress);
            // 
            // txtCodCtabco
            // 
            this.txtCodCtabco.Location = new System.Drawing.Point(97, 98);
            this.txtCodCtabco.MaxLength = 7;
            this.txtCodCtabco.Name = "txtCodCtabco";
            this.txtCodCtabco.Size = new System.Drawing.Size(150, 22);
            this.txtCodCtabco.TabIndex = 16;
            this.txtCodCtabco.Tag = "cod_ctabco";
            this.txtCodCtabco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCtabco_KeyPress);
            // 
            // txtFechmovMov
            // 
            this.txtFechmovMov.Location = new System.Drawing.Point(253, 126);
            this.txtFechmovMov.MaxLength = 25;
            this.txtFechmovMov.Name = "txtFechmovMov";
            this.txtFechmovMov.Size = new System.Drawing.Size(22, 22);
            this.txtFechmovMov.TabIndex = 18;
            this.txtFechmovMov.Tag = "fechmov_mov";
            this.txtFechmovMov.Visible = false;
            this.txtFechmovMov.TextChanged += new System.EventHandler(this.txtFechmovMov_TextChanged);
            // 
            // txtCorrelativoMov
            // 
            this.txtCorrelativoMov.Location = new System.Drawing.Point(452, 126);
            this.txtCorrelativoMov.MaxLength = 15;
            this.txtCorrelativoMov.Name = "txtCorrelativoMov";
            this.txtCorrelativoMov.Size = new System.Drawing.Size(150, 22);
            this.txtCorrelativoMov.TabIndex = 19;
            this.txtCorrelativoMov.Tag = "correlativo_mov";
            this.txtCorrelativoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrelativoMov_KeyPress);
            // 
            // txtDescripMov
            // 
            this.txtDescripMov.Location = new System.Drawing.Point(97, 154);
            this.txtDescripMov.MaxLength = 100;
            this.txtDescripMov.Name = "txtDescripMov";
            this.txtDescripMov.Size = new System.Drawing.Size(150, 22);
            this.txtDescripMov.TabIndex = 20;
            this.txtDescripMov.Tag = "descrip_mov";
            this.txtDescripMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripMov_KeyPress);
            // 
            // txtDebitoMov
            // 
            this.txtDebitoMov.Location = new System.Drawing.Point(97, 182);
            this.txtDebitoMov.MaxLength = 25;
            this.txtDebitoMov.Name = "txtDebitoMov";
            this.txtDebitoMov.Size = new System.Drawing.Size(150, 22);
            this.txtDebitoMov.TabIndex = 21;
            this.txtDebitoMov.Tag = "debito_mov";
            this.txtDebitoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitoMov_KeyPress);
            // 
            // txtCreditoMov
            // 
            this.txtCreditoMov.Location = new System.Drawing.Point(452, 182);
            this.txtCreditoMov.MaxLength = 25;
            this.txtCreditoMov.Name = "txtCreditoMov";
            this.txtCreditoMov.Size = new System.Drawing.Size(150, 22);
            this.txtCreditoMov.TabIndex = 22;
            this.txtCreditoMov.Tag = "credito_mov";
            this.txtCreditoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditoMov_KeyPress);
            // 
            // txtEstadoMov
            // 
            this.txtEstadoMov.Location = new System.Drawing.Point(253, 210);
            this.txtEstadoMov.MaxLength = 1;
            this.txtEstadoMov.Name = "txtEstadoMov";
            this.txtEstadoMov.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoMov.TabIndex = 24;
            this.txtEstadoMov.Tag = "estado_mov";
            this.txtEstadoMov.Visible = false;
            this.txtEstadoMov.EnabledChanged += new System.EventHandler(this.txtEstadoMov_EnabledChanged);
            this.txtEstadoMov.TextChanged += new System.EventHandler(this.txtEstadoMov_TextChanged);
            // 
            // dtpFechmovMov
            // 
            this.dtpFechmovMov.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechmovMov.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechmovMov.Location = new System.Drawing.Point(97, 126);
            this.dtpFechmovMov.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpFechmovMov.Name = "dtpFechmovMov";
            this.dtpFechmovMov.ShowUpDown = true;
            this.dtpFechmovMov.Size = new System.Drawing.Size(150, 22);
            this.dtpFechmovMov.TabIndex = 17;
            this.dtpFechmovMov.ValueChanged += new System.EventHandler(this.dtpFechmovMov_ValueChanged);
            this.dtpFechmovMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechmovMov_KeyPress);
            // 
            // cboEstadoMov
            // 
            this.cboEstadoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoMov.FormattingEnabled = true;
            this.cboEstadoMov.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoMov.Location = new System.Drawing.Point(97, 210);
            this.cboEstadoMov.Name = "cboEstadoMov";
            this.cboEstadoMov.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoMov.TabIndex = 23;
            this.cboEstadoMov.SelectedIndexChanged += new System.EventHandler(this.cboEstadoMov_SelectedIndexChanged);
            // 
            // wfMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 246);
            this.Controls.Add(this.cboEstadoMov);
            this.Controls.Add(this.dtpFechmovMov);
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
            this.Name = "wfMovimiento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.wfMovimiento_Load);
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
        private System.Windows.Forms.DateTimePicker dtpFechmovMov;
        private System.Windows.Forms.ComboBox cboEstadoMov;
    }
}