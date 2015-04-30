namespace Operaciones
{
    partial class wfDetalleCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetalleCuentas));
            this.navegador1 = new Navegador.Navegador();
            this.cboEstadoDcta = new System.Windows.Forms.ComboBox();
            this.txtEstadoDcta = new System.Windows.Forms.TextBox();
            this.lblEstadoDcta = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtCodigoDcta = new System.Windows.Forms.TextBox();
            this.lblCodigoDcta = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cboMesDcta = new System.Windows.Forms.ComboBox();
            this.txtMesDcta = new System.Windows.Forms.TextBox();
            this.lblMesDcta = new System.Windows.Forms.Label();
            this.txtAnioDcta = new System.Windows.Forms.TextBox();
            this.lblAnioDcta = new System.Windows.Forms.Label();
            this.plDcta = new System.Windows.Forms.Panel();
            this.txtPasivoDcta = new System.Windows.Forms.TextBox();
            this.txtActivoDcta = new System.Windows.Forms.TextBox();
            this.txtGananciaDcta = new System.Windows.Forms.TextBox();
            this.txtPerdidaDcta = new System.Windows.Forms.TextBox();
            this.txtHaberDcta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDebeDcta = new System.Windows.Forms.TextBox();
            this.plDcta.SuspendLayout();
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
            this.navegador1.Size = new System.Drawing.Size(617, 55);
            this.navegador1.sNombreTabla = "tabm_dcuenta";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "";
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterGuardar += new System.EventHandler(this.navegador1_btnAfterGuardar);
            // 
            // cboEstadoDcta
            // 
            this.cboEstadoDcta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoDcta.FormattingEnabled = true;
            this.cboEstadoDcta.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoDcta.Location = new System.Drawing.Point(455, 154);
            this.cboEstadoDcta.Name = "cboEstadoDcta";
            this.cboEstadoDcta.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoDcta.TabIndex = 7;
            this.cboEstadoDcta.Tag = "";
            this.cboEstadoDcta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCuenta_SelectedIndexChanged);
            // 
            // txtEstadoDcta
            // 
            this.txtEstadoDcta.Location = new System.Drawing.Point(333, 157);
            this.txtEstadoDcta.Name = "txtEstadoDcta";
            this.txtEstadoDcta.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoDcta.TabIndex = 16;
            this.txtEstadoDcta.Tag = "estado_dcta";
            this.txtEstadoDcta.Visible = false;
            this.txtEstadoDcta.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstadoDcta
            // 
            this.lblEstadoDcta.AutoSize = true;
            this.lblEstadoDcta.Location = new System.Drawing.Point(364, 160);
            this.lblEstadoDcta.Name = "lblEstadoDcta";
            this.lblEstadoDcta.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoDcta.TabIndex = 7;
            this.lblEstadoDcta.Text = "Estado";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(76, 98);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(150, 22);
            this.txtEmpresa.TabIndex = 2;
            this.txtEmpresa.Tag = "cod_empsa";
            this.txtEmpresa.Enter += new System.EventHandler(this.txtEmpresa_Enter);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(12, 101);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(58, 17);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa";
            // 
            // txtCodigoDcta
            // 
            this.txtCodigoDcta.Location = new System.Drawing.Point(76, 70);
            this.txtCodigoDcta.Name = "txtCodigoDcta";
            this.txtCodigoDcta.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoDcta.TabIndex = 1;
            this.txtCodigoDcta.Tag = "cod_dcta";
            // 
            // lblCodigoDcta
            // 
            this.lblCodigoDcta.AutoSize = true;
            this.lblCodigoDcta.Location = new System.Drawing.Point(12, 73);
            this.lblCodigoDcta.Name = "lblCodigoDcta";
            this.lblCodigoDcta.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoDcta.TabIndex = 1;
            this.lblCodigoDcta.Text = "Código";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(455, 98);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(150, 22);
            this.txtMoneda.TabIndex = 3;
            this.txtMoneda.Tag = "cod_mda";
            this.txtMoneda.Enter += new System.EventHandler(this.txtMoneda_Enter);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(364, 101);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(58, 17);
            this.lblMoneda.TabIndex = 3;
            this.lblMoneda.Text = "Moneda";
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.Location = new System.Drawing.Point(76, 126);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Size = new System.Drawing.Size(150, 22);
            this.txtTipoCuenta.TabIndex = 4;
            this.txtTipoCuenta.Tag = "cod_cta";
            this.txtTipoCuenta.Enter += new System.EventHandler(this.txtTipoCuenta_Enter);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(12, 129);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(52, 17);
            this.lblTipoCuenta.TabIndex = 4;
            this.lblTipoCuenta.Text = "Cuenta";
            // 
            // cboMesDcta
            // 
            this.cboMesDcta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesDcta.FormattingEnabled = true;
            this.cboMesDcta.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMesDcta.Location = new System.Drawing.Point(455, 126);
            this.cboMesDcta.Name = "cboMesDcta";
            this.cboMesDcta.Size = new System.Drawing.Size(150, 25);
            this.cboMesDcta.TabIndex = 5;
            this.cboMesDcta.Tag = "";
            this.cboMesDcta.SelectedIndexChanged += new System.EventHandler(this.cboMesDcta_SelectedIndexChanged);
            // 
            // txtMesDcta
            // 
            this.txtMesDcta.Location = new System.Drawing.Point(333, 126);
            this.txtMesDcta.Name = "txtMesDcta";
            this.txtMesDcta.Size = new System.Drawing.Size(25, 22);
            this.txtMesDcta.TabIndex = 36;
            this.txtMesDcta.Tag = "mes_dcta";
            this.txtMesDcta.TextChanged += new System.EventHandler(this.txtMesDcta_TextChanged);
            // 
            // lblMesDcta
            // 
            this.lblMesDcta.AutoSize = true;
            this.lblMesDcta.Location = new System.Drawing.Point(364, 129);
            this.lblMesDcta.Name = "lblMesDcta";
            this.lblMesDcta.Size = new System.Drawing.Size(32, 17);
            this.lblMesDcta.TabIndex = 5;
            this.lblMesDcta.Text = "Mes";
            // 
            // txtAnioDcta
            // 
            this.txtAnioDcta.Location = new System.Drawing.Point(76, 154);
            this.txtAnioDcta.Name = "txtAnioDcta";
            this.txtAnioDcta.Size = new System.Drawing.Size(150, 22);
            this.txtAnioDcta.TabIndex = 6;
            this.txtAnioDcta.Tag = "anio_dcta";
            // 
            // lblAnioDcta
            // 
            this.lblAnioDcta.AutoSize = true;
            this.lblAnioDcta.Location = new System.Drawing.Point(12, 157);
            this.lblAnioDcta.Name = "lblAnioDcta";
            this.lblAnioDcta.Size = new System.Drawing.Size(32, 17);
            this.lblAnioDcta.TabIndex = 6;
            this.lblAnioDcta.Text = "Año";
            // 
            // plDcta
            // 
            this.plDcta.Controls.Add(this.txtPasivoDcta);
            this.plDcta.Controls.Add(this.txtActivoDcta);
            this.plDcta.Controls.Add(this.txtGananciaDcta);
            this.plDcta.Controls.Add(this.txtPerdidaDcta);
            this.plDcta.Controls.Add(this.txtHaberDcta);
            this.plDcta.Controls.Add(this.label6);
            this.plDcta.Controls.Add(this.label5);
            this.plDcta.Controls.Add(this.label4);
            this.plDcta.Controls.Add(this.label3);
            this.plDcta.Controls.Add(this.label2);
            this.plDcta.Controls.Add(this.label1);
            this.plDcta.Controls.Add(this.txtDebeDcta);
            this.plDcta.Location = new System.Drawing.Point(15, 185);
            this.plDcta.Name = "plDcta";
            this.plDcta.Size = new System.Drawing.Size(590, 63);
            this.plDcta.TabIndex = 67;
            // 
            // txtPasivoDcta
            // 
            this.txtPasivoDcta.Location = new System.Drawing.Point(487, 29);
            this.txtPasivoDcta.Name = "txtPasivoDcta";
            this.txtPasivoDcta.Size = new System.Drawing.Size(88, 22);
            this.txtPasivoDcta.TabIndex = 13;
            this.txtPasivoDcta.Tag = "pasivo_dcta";
            // 
            // txtActivoDcta
            // 
            this.txtActivoDcta.Location = new System.Drawing.Point(393, 29);
            this.txtActivoDcta.Name = "txtActivoDcta";
            this.txtActivoDcta.Size = new System.Drawing.Size(88, 22);
            this.txtActivoDcta.TabIndex = 12;
            this.txtActivoDcta.Tag = "activo_dcta";
            // 
            // txtGananciaDcta
            // 
            this.txtGananciaDcta.Location = new System.Drawing.Point(299, 29);
            this.txtGananciaDcta.Name = "txtGananciaDcta";
            this.txtGananciaDcta.Size = new System.Drawing.Size(88, 22);
            this.txtGananciaDcta.TabIndex = 11;
            this.txtGananciaDcta.Tag = "ganancia_dcta";
            // 
            // txtPerdidaDcta
            // 
            this.txtPerdidaDcta.Location = new System.Drawing.Point(205, 29);
            this.txtPerdidaDcta.Name = "txtPerdidaDcta";
            this.txtPerdidaDcta.Size = new System.Drawing.Size(88, 22);
            this.txtPerdidaDcta.TabIndex = 10;
            this.txtPerdidaDcta.Tag = "perdida_dcta";
            // 
            // txtHaberDcta
            // 
            this.txtHaberDcta.Location = new System.Drawing.Point(111, 29);
            this.txtHaberDcta.Name = "txtHaberDcta";
            this.txtHaberDcta.Size = new System.Drawing.Size(88, 22);
            this.txtHaberDcta.TabIndex = 9;
            this.txtHaberDcta.Tag = "haber_dcta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pasivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Activo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ganancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pérdida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Haber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Debe";
            // 
            // txtDebeDcta
            // 
            this.txtDebeDcta.Location = new System.Drawing.Point(17, 29);
            this.txtDebeDcta.Name = "txtDebeDcta";
            this.txtDebeDcta.Size = new System.Drawing.Size(88, 22);
            this.txtDebeDcta.TabIndex = 8;
            this.txtDebeDcta.Tag = "debe_dcta";
            // 
            // wfDetalleCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 261);
            this.Controls.Add(this.plDcta);
            this.Controls.Add(this.txtAnioDcta);
            this.Controls.Add(this.lblAnioDcta);
            this.Controls.Add(this.cboMesDcta);
            this.Controls.Add(this.txtMesDcta);
            this.Controls.Add(this.lblMesDcta);
            this.Controls.Add(this.txtTipoCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.cboEstadoDcta);
            this.Controls.Add(this.txtEstadoDcta);
            this.Controls.Add(this.lblEstadoDcta);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtCodigoDcta);
            this.Controls.Add(this.lblCodigoDcta);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDetalleCuentas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Detalle de cuentas";
            this.Load += new System.EventHandler(this.wfDetalleCuentas_Load);
            this.plDcta.ResumeLayout(false);
            this.plDcta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cboEstadoDcta;
        private System.Windows.Forms.TextBox txtEstadoDcta;
        private System.Windows.Forms.Label lblEstadoDcta;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtCodigoDcta;
        private System.Windows.Forms.Label lblCodigoDcta;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cboMesDcta;
        private System.Windows.Forms.TextBox txtMesDcta;
        private System.Windows.Forms.Label lblMesDcta;
        private System.Windows.Forms.TextBox txtAnioDcta;
        private System.Windows.Forms.Label lblAnioDcta;
        private System.Windows.Forms.Panel plDcta;
        private System.Windows.Forms.TextBox txtPasivoDcta;
        private System.Windows.Forms.TextBox txtActivoDcta;
        private System.Windows.Forms.TextBox txtGananciaDcta;
        private System.Windows.Forms.TextBox txtPerdidaDcta;
        private System.Windows.Forms.TextBox txtHaberDcta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDebeDcta;
    }
}