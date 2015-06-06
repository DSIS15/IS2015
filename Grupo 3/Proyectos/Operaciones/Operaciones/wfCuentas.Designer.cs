namespace Operaciones
{
    partial class wfCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCuentas));
            this.navegador1 = new Navegador.Navegador();
            this.cboEstadoCta = new System.Windows.Forms.ComboBox();
            this.txtEstadoCta = new System.Windows.Forms.TextBox();
            this.lblEstadoCta = new System.Windows.Forms.Label();
            this.txtNombreCta = new System.Windows.Forms.TextBox();
            this.lblNombreCta = new System.Windows.Forms.Label();
            this.txtCodigoCta = new System.Windows.Forms.TextBox();
            this.lblCodigoCta = new System.Windows.Forms.Label();
            this.txtNomencCta = new System.Windows.Forms.TextBox();
            this.lblNomencCta = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtCodEmpsa = new System.Windows.Forms.TextBox();
            this.lblCodEmpsa = new System.Windows.Forms.Label();
            this.lblPredecesorCta = new System.Windows.Forms.Label();
            this.txtAbonosAcumCta = new System.Windows.Forms.TextBox();
            this.lblAbonosAcumCta = new System.Windows.Forms.Label();
            this.txtSactualCta = new System.Windows.Forms.TextBox();
            this.lblSactualCta = new System.Windows.Forms.Label();
            this.txtPredecesor = new System.Windows.Forms.TextBox();
            this.cboDebeCta = new System.Windows.Forms.ComboBox();
            this.lblDebeCta = new System.Windows.Forms.Label();
            this.txtDebeCta = new System.Windows.Forms.TextBox();
            this.cboHaberCta = new System.Windows.Forms.ComboBox();
            this.lblHaberCta = new System.Windows.Forms.Label();
            this.txtHaberCta = new System.Windows.Forms.TextBox();
            this.txtGananciaCta = new System.Windows.Forms.TextBox();
            this.cboGananciaCta = new System.Windows.Forms.ComboBox();
            this.lblGananciaCta = new System.Windows.Forms.Label();
            this.txtPerdidaCta = new System.Windows.Forms.TextBox();
            this.cboPerdidaCta = new System.Windows.Forms.ComboBox();
            this.lblPerdidaCta = new System.Windows.Forms.Label();
            this.txtPasivoCta = new System.Windows.Forms.TextBox();
            this.cboPasivoCta = new System.Windows.Forms.ComboBox();
            this.lblPasivoCta = new System.Windows.Forms.Label();
            this.txtActivoCta = new System.Windows.Forms.TextBox();
            this.cboActivoCta = new System.Windows.Forms.ComboBox();
            this.lblActivoCta = new System.Windows.Forms.Label();
            this.txtNivelCta = new System.Windows.Forms.TextBox();
            this.lblNivelCta = new System.Windows.Forms.Label();
            this.txtSanteriorCta = new System.Windows.Forms.TextBox();
            this.lblSanteriorCta = new System.Windows.Forms.Label();
            this.txtCargoCta = new System.Windows.Forms.TextBox();
            this.lblCargoCta = new System.Windows.Forms.Label();
            this.txtAbonoCta = new System.Windows.Forms.TextBox();
            this.lblAbonoCta = new System.Windows.Forms.Label();
            this.txtCargosAcumCta = new System.Windows.Forms.TextBox();
            this.lblCargosAcumCta = new System.Windows.Forms.Label();
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
            this.navegador1.sNombreTabla = "tabm_cuenta";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "";
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // cboEstadoCta
            // 
            this.cboEstadoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCta.FormattingEnabled = true;
            this.cboEstadoCta.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoCta.Location = new System.Drawing.Point(455, 331);
            this.cboEstadoCta.Name = "cboEstadoCta";
            this.cboEstadoCta.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoCta.TabIndex = 33;
            this.cboEstadoCta.Tag = "";
            this.cboEstadoCta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCuenta_SelectedIndexChanged);
            // 
            // txtEstadoCta
            // 
            this.txtEstadoCta.Location = new System.Drawing.Point(326, 333);
            this.txtEstadoCta.Name = "txtEstadoCta";
            this.txtEstadoCta.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoCta.TabIndex = 6;
            this.txtEstadoCta.Tag = "estado_cta";
            this.txtEstadoCta.Visible = false;
            this.txtEstadoCta.EnabledChanged += new System.EventHandler(this.txtEstadoCta_EnabledChanged);
            this.txtEstadoCta.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstadoCta
            // 
            this.lblEstadoCta.AutoSize = true;
            this.lblEstadoCta.Location = new System.Drawing.Point(357, 334);
            this.lblEstadoCta.Name = "lblEstadoCta";
            this.lblEstadoCta.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoCta.TabIndex = 5;
            this.lblEstadoCta.Text = "Estado";
            // 
            // txtNombreCta
            // 
            this.txtNombreCta.Location = new System.Drawing.Point(112, 154);
            this.txtNombreCta.Name = "txtNombreCta";
            this.txtNombreCta.Size = new System.Drawing.Size(150, 22);
            this.txtNombreCta.TabIndex = 20;
            this.txtNombreCta.Tag = "cuenta_cta";
            this.txtNombreCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCta_KeyPress);
            // 
            // lblNombreCta
            // 
            this.lblNombreCta.AutoSize = true;
            this.lblNombreCta.Location = new System.Drawing.Point(12, 157);
            this.lblNombreCta.Name = "lblNombreCta";
            this.lblNombreCta.Size = new System.Drawing.Size(56, 17);
            this.lblNombreCta.TabIndex = 3;
            this.lblNombreCta.Text = "Nombre";
            // 
            // txtCodigoCta
            // 
            this.txtCodigoCta.Enabled = false;
            this.txtCodigoCta.Location = new System.Drawing.Point(112, 70);
            this.txtCodigoCta.Name = "txtCodigoCta";
            this.txtCodigoCta.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoCta.TabIndex = 14;
            this.txtCodigoCta.Tag = "cod_cta";
            this.txtCodigoCta.TextChanged += new System.EventHandler(this.txtCodigoCta_TextChanged);
            // 
            // lblCodigoCta
            // 
            this.lblCodigoCta.AutoSize = true;
            this.lblCodigoCta.Location = new System.Drawing.Point(12, 73);
            this.lblCodigoCta.Name = "lblCodigoCta";
            this.lblCodigoCta.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoCta.TabIndex = 1;
            this.lblCodigoCta.Text = "Código";
            // 
            // txtNomencCta
            // 
            this.txtNomencCta.Location = new System.Drawing.Point(112, 126);
            this.txtNomencCta.Name = "txtNomencCta";
            this.txtNomencCta.Size = new System.Drawing.Size(150, 22);
            this.txtNomencCta.TabIndex = 18;
            this.txtNomencCta.Tag = "nomenc_cta";
            this.txtNomencCta.TextChanged += new System.EventHandler(this.txtNomencCta_TextChanged);
            this.txtNomencCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomencCta_KeyPress);
            // 
            // lblNomencCta
            // 
            this.lblNomencCta.AutoSize = true;
            this.lblNomencCta.Location = new System.Drawing.Point(12, 129);
            this.lblNomencCta.Name = "lblNomencCta";
            this.lblNomencCta.Size = new System.Drawing.Size(94, 17);
            this.lblNomencCta.TabIndex = 4;
            this.lblNomencCta.Text = "Nomenclatura";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Enabled = false;
            this.txtMoneda.Location = new System.Drawing.Point(112, 98);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(150, 22);
            this.txtMoneda.TabIndex = 16;
            this.txtMoneda.Tag = "cod_mda";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(12, 101);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(58, 17);
            this.lblMoneda.TabIndex = 10;
            this.lblMoneda.Text = "Moneda";
            // 
            // txtCodEmpsa
            // 
            this.txtCodEmpsa.Enabled = false;
            this.txtCodEmpsa.Location = new System.Drawing.Point(455, 70);
            this.txtCodEmpsa.Name = "txtCodEmpsa";
            this.txtCodEmpsa.Size = new System.Drawing.Size(150, 22);
            this.txtCodEmpsa.TabIndex = 15;
            this.txtCodEmpsa.Tag = "cod_empsa";
            // 
            // lblCodEmpsa
            // 
            this.lblCodEmpsa.AutoSize = true;
            this.lblCodEmpsa.Location = new System.Drawing.Point(357, 73);
            this.lblCodEmpsa.Name = "lblCodEmpsa";
            this.lblCodEmpsa.Size = new System.Drawing.Size(58, 17);
            this.lblCodEmpsa.TabIndex = 8;
            this.lblCodEmpsa.Text = "Empresa";
            // 
            // lblPredecesorCta
            // 
            this.lblPredecesorCta.AutoSize = true;
            this.lblPredecesorCta.Location = new System.Drawing.Point(357, 101);
            this.lblPredecesorCta.Name = "lblPredecesorCta";
            this.lblPredecesorCta.Size = new System.Drawing.Size(76, 17);
            this.lblPredecesorCta.TabIndex = 11;
            this.lblPredecesorCta.Text = "Predecesor";
            // 
            // txtAbonosAcumCta
            // 
            this.txtAbonosAcumCta.Location = new System.Drawing.Point(112, 238);
            this.txtAbonosAcumCta.Name = "txtAbonosAcumCta";
            this.txtAbonosAcumCta.Size = new System.Drawing.Size(150, 22);
            this.txtAbonosAcumCta.TabIndex = 26;
            this.txtAbonosAcumCta.Tag = "abonosacum_cta";
            this.txtAbonosAcumCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbonosAcumCta_KeyPress);
            // 
            // lblAbonosAcumCta
            // 
            this.lblAbonosAcumCta.AutoSize = true;
            this.lblAbonosAcumCta.Location = new System.Drawing.Point(12, 241);
            this.lblAbonosAcumCta.Name = "lblAbonosAcumCta";
            this.lblAbonosAcumCta.Size = new System.Drawing.Size(93, 17);
            this.lblAbonosAcumCta.TabIndex = 13;
            this.lblAbonosAcumCta.Text = "Abonos acum.";
            // 
            // txtSactualCta
            // 
            this.txtSactualCta.Location = new System.Drawing.Point(112, 210);
            this.txtSactualCta.Name = "txtSactualCta";
            this.txtSactualCta.Size = new System.Drawing.Size(150, 22);
            this.txtSactualCta.TabIndex = 24;
            this.txtSactualCta.Tag = "sactual_cta";
            this.txtSactualCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSactualCta_KeyPress);
            // 
            // lblSactualCta
            // 
            this.lblSactualCta.AutoSize = true;
            this.lblSactualCta.Location = new System.Drawing.Point(12, 213);
            this.lblSactualCta.Name = "lblSactualCta";
            this.lblSactualCta.Size = new System.Drawing.Size(84, 17);
            this.lblSactualCta.TabIndex = 15;
            this.lblSactualCta.Text = "Saldo actual";
            // 
            // txtPredecesor
            // 
            this.txtPredecesor.Enabled = false;
            this.txtPredecesor.Location = new System.Drawing.Point(455, 98);
            this.txtPredecesor.Name = "txtPredecesor";
            this.txtPredecesor.Size = new System.Drawing.Size(150, 22);
            this.txtPredecesor.TabIndex = 17;
            this.txtPredecesor.Tag = "predec_cta";
            this.txtPredecesor.Enter += new System.EventHandler(this.txtPredecesor_Enter);
            // 
            // cboDebeCta
            // 
            this.cboDebeCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebeCta.FormattingEnabled = true;
            this.cboDebeCta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboDebeCta.Location = new System.Drawing.Point(455, 238);
            this.cboDebeCta.Name = "cboDebeCta";
            this.cboDebeCta.Size = new System.Drawing.Size(150, 25);
            this.cboDebeCta.TabIndex = 27;
            this.cboDebeCta.Tag = "";
            this.cboDebeCta.SelectedIndexChanged += new System.EventHandler(this.cboDebeCta_SelectedIndexChanged);
            // 
            // lblDebeCta
            // 
            this.lblDebeCta.AutoSize = true;
            this.lblDebeCta.Location = new System.Drawing.Point(357, 241);
            this.lblDebeCta.Name = "lblDebeCta";
            this.lblDebeCta.Size = new System.Drawing.Size(41, 17);
            this.lblDebeCta.TabIndex = 23;
            this.lblDebeCta.Text = "Debe";
            // 
            // txtDebeCta
            // 
            this.txtDebeCta.Location = new System.Drawing.Point(326, 238);
            this.txtDebeCta.Name = "txtDebeCta";
            this.txtDebeCta.Size = new System.Drawing.Size(25, 22);
            this.txtDebeCta.TabIndex = 25;
            this.txtDebeCta.Tag = "debe_cta";
            this.txtDebeCta.Visible = false;
            this.txtDebeCta.EnabledChanged += new System.EventHandler(this.txtDebeCta_EnabledChanged);
            this.txtDebeCta.TextChanged += new System.EventHandler(this.txtDebeCta_TextChanged);
            // 
            // cboHaberCta
            // 
            this.cboHaberCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHaberCta.FormattingEnabled = true;
            this.cboHaberCta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboHaberCta.Location = new System.Drawing.Point(112, 269);
            this.cboHaberCta.Name = "cboHaberCta";
            this.cboHaberCta.Size = new System.Drawing.Size(150, 25);
            this.cboHaberCta.TabIndex = 28;
            this.cboHaberCta.Tag = "";
            this.cboHaberCta.SelectedIndexChanged += new System.EventHandler(this.cboHaberCta_SelectedIndexChanged);
            // 
            // lblHaberCta
            // 
            this.lblHaberCta.AutoSize = true;
            this.lblHaberCta.Location = new System.Drawing.Point(12, 272);
            this.lblHaberCta.Name = "lblHaberCta";
            this.lblHaberCta.Size = new System.Drawing.Size(44, 17);
            this.lblHaberCta.TabIndex = 26;
            this.lblHaberCta.Text = "Haber";
            // 
            // txtHaberCta
            // 
            this.txtHaberCta.Location = new System.Drawing.Point(268, 269);
            this.txtHaberCta.Name = "txtHaberCta";
            this.txtHaberCta.Size = new System.Drawing.Size(25, 22);
            this.txtHaberCta.TabIndex = 28;
            this.txtHaberCta.Tag = "haber_cta";
            this.txtHaberCta.Visible = false;
            this.txtHaberCta.EnabledChanged += new System.EventHandler(this.txtHaberCta_EnabledChanged);
            this.txtHaberCta.TextChanged += new System.EventHandler(this.txtHaberCta_TextChanged);
            // 
            // txtGananciaCta
            // 
            this.txtGananciaCta.Location = new System.Drawing.Point(268, 300);
            this.txtGananciaCta.Name = "txtGananciaCta";
            this.txtGananciaCta.Size = new System.Drawing.Size(25, 22);
            this.txtGananciaCta.TabIndex = 34;
            this.txtGananciaCta.Tag = "ganancia_cta";
            this.txtGananciaCta.Visible = false;
            this.txtGananciaCta.EnabledChanged += new System.EventHandler(this.txtGananciaCta_EnabledChanged);
            this.txtGananciaCta.TextChanged += new System.EventHandler(this.txtGananciaCta_TextChanged);
            // 
            // cboGananciaCta
            // 
            this.cboGananciaCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGananciaCta.FormattingEnabled = true;
            this.cboGananciaCta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboGananciaCta.Location = new System.Drawing.Point(112, 300);
            this.cboGananciaCta.Name = "cboGananciaCta";
            this.cboGananciaCta.Size = new System.Drawing.Size(150, 25);
            this.cboGananciaCta.TabIndex = 30;
            this.cboGananciaCta.Tag = "";
            this.cboGananciaCta.SelectedIndexChanged += new System.EventHandler(this.cboGananciaCta_SelectedIndexChanged);
            // 
            // lblGananciaCta
            // 
            this.lblGananciaCta.AutoSize = true;
            this.lblGananciaCta.Location = new System.Drawing.Point(12, 303);
            this.lblGananciaCta.Name = "lblGananciaCta";
            this.lblGananciaCta.Size = new System.Drawing.Size(67, 17);
            this.lblGananciaCta.TabIndex = 32;
            this.lblGananciaCta.Text = "Ganancia";
            // 
            // txtPerdidaCta
            // 
            this.txtPerdidaCta.Location = new System.Drawing.Point(326, 271);
            this.txtPerdidaCta.Name = "txtPerdidaCta";
            this.txtPerdidaCta.Size = new System.Drawing.Size(25, 22);
            this.txtPerdidaCta.TabIndex = 31;
            this.txtPerdidaCta.Tag = "perdida_cta";
            this.txtPerdidaCta.Visible = false;
            this.txtPerdidaCta.DockChanged += new System.EventHandler(this.txtPerdidaCta_DockChanged);
            this.txtPerdidaCta.EnabledChanged += new System.EventHandler(this.txtPerdidaCta_EnabledChanged);
            this.txtPerdidaCta.TextChanged += new System.EventHandler(this.txtPerdidaCta_TextChanged);
            // 
            // cboPerdidaCta
            // 
            this.cboPerdidaCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerdidaCta.FormattingEnabled = true;
            this.cboPerdidaCta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboPerdidaCta.Location = new System.Drawing.Point(455, 269);
            this.cboPerdidaCta.Name = "cboPerdidaCta";
            this.cboPerdidaCta.Size = new System.Drawing.Size(150, 25);
            this.cboPerdidaCta.TabIndex = 29;
            this.cboPerdidaCta.Tag = "";
            this.cboPerdidaCta.SelectedIndexChanged += new System.EventHandler(this.cboPerdidaCta_SelectedIndexChanged);
            // 
            // lblPerdidaCta
            // 
            this.lblPerdidaCta.AutoSize = true;
            this.lblPerdidaCta.Location = new System.Drawing.Point(357, 274);
            this.lblPerdidaCta.Name = "lblPerdidaCta";
            this.lblPerdidaCta.Size = new System.Drawing.Size(54, 17);
            this.lblPerdidaCta.TabIndex = 29;
            this.lblPerdidaCta.Text = "Pérdida";
            // 
            // txtPasivoCta
            // 
            this.txtPasivoCta.Location = new System.Drawing.Point(268, 331);
            this.txtPasivoCta.Name = "txtPasivoCta";
            this.txtPasivoCta.Size = new System.Drawing.Size(25, 22);
            this.txtPasivoCta.TabIndex = 40;
            this.txtPasivoCta.Tag = "pasivo_cta";
            this.txtPasivoCta.Visible = false;
            this.txtPasivoCta.EnabledChanged += new System.EventHandler(this.txtPasivoCta_EnabledChanged);
            this.txtPasivoCta.TextChanged += new System.EventHandler(this.txtPasivoCta_TextChanged);
            // 
            // cboPasivoCta
            // 
            this.cboPasivoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPasivoCta.FormattingEnabled = true;
            this.cboPasivoCta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboPasivoCta.Location = new System.Drawing.Point(112, 331);
            this.cboPasivoCta.Name = "cboPasivoCta";
            this.cboPasivoCta.Size = new System.Drawing.Size(150, 25);
            this.cboPasivoCta.TabIndex = 32;
            this.cboPasivoCta.Tag = "";
            this.cboPasivoCta.SelectedIndexChanged += new System.EventHandler(this.cboPasivoCta_SelectedIndexChanged);
            // 
            // lblPasivoCta
            // 
            this.lblPasivoCta.AutoSize = true;
            this.lblPasivoCta.Location = new System.Drawing.Point(12, 334);
            this.lblPasivoCta.Name = "lblPasivoCta";
            this.lblPasivoCta.Size = new System.Drawing.Size(47, 17);
            this.lblPasivoCta.TabIndex = 38;
            this.lblPasivoCta.Text = "Pasivo";
            // 
            // txtActivoCta
            // 
            this.txtActivoCta.Location = new System.Drawing.Point(326, 302);
            this.txtActivoCta.Name = "txtActivoCta";
            this.txtActivoCta.Size = new System.Drawing.Size(25, 22);
            this.txtActivoCta.TabIndex = 37;
            this.txtActivoCta.Tag = "activo_cta";
            this.txtActivoCta.Visible = false;
            this.txtActivoCta.EnabledChanged += new System.EventHandler(this.txtActivoCta_EnabledChanged);
            this.txtActivoCta.TextChanged += new System.EventHandler(this.txtActivoCta_TextChanged);
            // 
            // cboActivoCta
            // 
            this.cboActivoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivoCta.FormattingEnabled = true;
            this.cboActivoCta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboActivoCta.Location = new System.Drawing.Point(455, 300);
            this.cboActivoCta.Name = "cboActivoCta";
            this.cboActivoCta.Size = new System.Drawing.Size(150, 25);
            this.cboActivoCta.TabIndex = 31;
            this.cboActivoCta.Tag = "";
            this.cboActivoCta.SelectedIndexChanged += new System.EventHandler(this.cboActivoCta_SelectedIndexChanged);
            // 
            // lblActivoCta
            // 
            this.lblActivoCta.AutoSize = true;
            this.lblActivoCta.Location = new System.Drawing.Point(357, 308);
            this.lblActivoCta.Name = "lblActivoCta";
            this.lblActivoCta.Size = new System.Drawing.Size(49, 17);
            this.lblActivoCta.TabIndex = 35;
            this.lblActivoCta.Text = "Activo";
            // 
            // txtNivelCta
            // 
            this.txtNivelCta.Location = new System.Drawing.Point(455, 126);
            this.txtNivelCta.Name = "txtNivelCta";
            this.txtNivelCta.Size = new System.Drawing.Size(150, 22);
            this.txtNivelCta.TabIndex = 19;
            this.txtNivelCta.Tag = "nivel_cta";
            this.txtNivelCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivelCta_KeyPress);
            // 
            // lblNivelCta
            // 
            this.lblNivelCta.AutoSize = true;
            this.lblNivelCta.Location = new System.Drawing.Point(357, 129);
            this.lblNivelCta.Name = "lblNivelCta";
            this.lblNivelCta.Size = new System.Drawing.Size(39, 17);
            this.lblNivelCta.TabIndex = 41;
            this.lblNivelCta.Text = "Nivel";
            // 
            // txtSanteriorCta
            // 
            this.txtSanteriorCta.Location = new System.Drawing.Point(455, 154);
            this.txtSanteriorCta.Name = "txtSanteriorCta";
            this.txtSanteriorCta.Size = new System.Drawing.Size(150, 22);
            this.txtSanteriorCta.TabIndex = 21;
            this.txtSanteriorCta.Tag = "santerior_cta";
            this.txtSanteriorCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSanteriorCta_KeyPress_1);
            // 
            // lblSanteriorCta
            // 
            this.lblSanteriorCta.AutoSize = true;
            this.lblSanteriorCta.Location = new System.Drawing.Point(357, 157);
            this.lblSanteriorCta.Name = "lblSanteriorCta";
            this.lblSanteriorCta.Size = new System.Drawing.Size(92, 17);
            this.lblSanteriorCta.TabIndex = 42;
            this.lblSanteriorCta.Text = "Saldo anterior";
            // 
            // txtCargoCta
            // 
            this.txtCargoCta.Location = new System.Drawing.Point(112, 182);
            this.txtCargoCta.Name = "txtCargoCta";
            this.txtCargoCta.Size = new System.Drawing.Size(150, 22);
            this.txtCargoCta.TabIndex = 22;
            this.txtCargoCta.Tag = "cargo_cta";
            this.txtCargoCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargoCta_KeyPress);
            // 
            // lblCargoCta
            // 
            this.lblCargoCta.AutoSize = true;
            this.lblCargoCta.Location = new System.Drawing.Point(12, 185);
            this.lblCargoCta.Name = "lblCargoCta";
            this.lblCargoCta.Size = new System.Drawing.Size(45, 17);
            this.lblCargoCta.TabIndex = 44;
            this.lblCargoCta.Text = "Cargo";
            // 
            // txtAbonoCta
            // 
            this.txtAbonoCta.Location = new System.Drawing.Point(455, 182);
            this.txtAbonoCta.Name = "txtAbonoCta";
            this.txtAbonoCta.Size = new System.Drawing.Size(150, 22);
            this.txtAbonoCta.TabIndex = 23;
            this.txtAbonoCta.Tag = "abono_cta";
            this.txtAbonoCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbonoCta_KeyPress);
            // 
            // lblAbonoCta
            // 
            this.lblAbonoCta.AutoSize = true;
            this.lblAbonoCta.Location = new System.Drawing.Point(357, 185);
            this.lblAbonoCta.Name = "lblAbonoCta";
            this.lblAbonoCta.Size = new System.Drawing.Size(48, 17);
            this.lblAbonoCta.TabIndex = 46;
            this.lblAbonoCta.Text = "Abono";
            // 
            // txtCargosAcumCta
            // 
            this.txtCargosAcumCta.Location = new System.Drawing.Point(455, 210);
            this.txtCargosAcumCta.Name = "txtCargosAcumCta";
            this.txtCargosAcumCta.Size = new System.Drawing.Size(150, 22);
            this.txtCargosAcumCta.TabIndex = 25;
            this.txtCargosAcumCta.Tag = "cargosacum_cta";
            this.txtCargosAcumCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargosAcumCta_KeyPress);
            // 
            // lblCargosAcumCta
            // 
            this.lblCargosAcumCta.AutoSize = true;
            this.lblCargosAcumCta.Location = new System.Drawing.Point(357, 213);
            this.lblCargosAcumCta.Name = "lblCargosAcumCta";
            this.lblCargosAcumCta.Size = new System.Drawing.Size(90, 17);
            this.lblCargosAcumCta.TabIndex = 48;
            this.lblCargosAcumCta.Text = "Cargos acum.";
            // 
            // wfCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 386);
            this.Controls.Add(this.txtCargosAcumCta);
            this.Controls.Add(this.lblCargosAcumCta);
            this.Controls.Add(this.txtAbonoCta);
            this.Controls.Add(this.lblAbonoCta);
            this.Controls.Add(this.txtCargoCta);
            this.Controls.Add(this.lblCargoCta);
            this.Controls.Add(this.txtSanteriorCta);
            this.Controls.Add(this.lblSanteriorCta);
            this.Controls.Add(this.txtNivelCta);
            this.Controls.Add(this.lblNivelCta);
            this.Controls.Add(this.txtPasivoCta);
            this.Controls.Add(this.cboPasivoCta);
            this.Controls.Add(this.lblPasivoCta);
            this.Controls.Add(this.txtActivoCta);
            this.Controls.Add(this.cboActivoCta);
            this.Controls.Add(this.lblActivoCta);
            this.Controls.Add(this.txtGananciaCta);
            this.Controls.Add(this.cboGananciaCta);
            this.Controls.Add(this.lblGananciaCta);
            this.Controls.Add(this.txtPerdidaCta);
            this.Controls.Add(this.cboPerdidaCta);
            this.Controls.Add(this.lblPerdidaCta);
            this.Controls.Add(this.txtHaberCta);
            this.Controls.Add(this.cboHaberCta);
            this.Controls.Add(this.lblHaberCta);
            this.Controls.Add(this.txtDebeCta);
            this.Controls.Add(this.cboDebeCta);
            this.Controls.Add(this.lblDebeCta);
            this.Controls.Add(this.txtPredecesor);
            this.Controls.Add(this.txtSactualCta);
            this.Controls.Add(this.lblSactualCta);
            this.Controls.Add(this.txtAbonosAcumCta);
            this.Controls.Add(this.lblAbonosAcumCta);
            this.Controls.Add(this.lblPredecesorCta);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.txtCodEmpsa);
            this.Controls.Add(this.lblCodEmpsa);
            this.Controls.Add(this.txtNomencCta);
            this.Controls.Add(this.lblNomencCta);
            this.Controls.Add(this.cboEstadoCta);
            this.Controls.Add(this.txtEstadoCta);
            this.Controls.Add(this.lblEstadoCta);
            this.Controls.Add(this.txtNombreCta);
            this.Controls.Add(this.lblNombreCta);
            this.Controls.Add(this.txtCodigoCta);
            this.Controls.Add(this.lblCodigoCta);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCuentas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.wfCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cboEstadoCta;
        private System.Windows.Forms.TextBox txtEstadoCta;
        private System.Windows.Forms.Label lblEstadoCta;
        private System.Windows.Forms.TextBox txtNombreCta;
        private System.Windows.Forms.Label lblNombreCta;
        private System.Windows.Forms.TextBox txtCodigoCta;
        private System.Windows.Forms.Label lblCodigoCta;
        private System.Windows.Forms.TextBox txtNomencCta;
        private System.Windows.Forms.Label lblNomencCta;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtCodEmpsa;
        private System.Windows.Forms.Label lblCodEmpsa;
        private System.Windows.Forms.Label lblPredecesorCta;
        private System.Windows.Forms.TextBox txtAbonosAcumCta;
        private System.Windows.Forms.Label lblAbonosAcumCta;
        private System.Windows.Forms.TextBox txtSactualCta;
        private System.Windows.Forms.Label lblSactualCta;
        private System.Windows.Forms.TextBox txtPredecesor;
        private System.Windows.Forms.ComboBox cboDebeCta;
        private System.Windows.Forms.Label lblDebeCta;
        private System.Windows.Forms.TextBox txtDebeCta;
        private System.Windows.Forms.ComboBox cboHaberCta;
        private System.Windows.Forms.Label lblHaberCta;
        private System.Windows.Forms.TextBox txtHaberCta;
        private System.Windows.Forms.TextBox txtGananciaCta;
        private System.Windows.Forms.ComboBox cboGananciaCta;
        private System.Windows.Forms.Label lblGananciaCta;
        private System.Windows.Forms.TextBox txtPerdidaCta;
        private System.Windows.Forms.ComboBox cboPerdidaCta;
        private System.Windows.Forms.Label lblPerdidaCta;
        private System.Windows.Forms.TextBox txtPasivoCta;
        private System.Windows.Forms.ComboBox cboPasivoCta;
        private System.Windows.Forms.Label lblPasivoCta;
        private System.Windows.Forms.TextBox txtActivoCta;
        private System.Windows.Forms.ComboBox cboActivoCta;
        private System.Windows.Forms.Label lblActivoCta;
        private System.Windows.Forms.TextBox txtNivelCta;
        private System.Windows.Forms.Label lblNivelCta;
        private System.Windows.Forms.TextBox txtSanteriorCta;
        private System.Windows.Forms.Label lblSanteriorCta;
        private System.Windows.Forms.TextBox txtCargoCta;
        private System.Windows.Forms.Label lblCargoCta;
        private System.Windows.Forms.TextBox txtAbonoCta;
        private System.Windows.Forms.Label lblAbonoCta;
        private System.Windows.Forms.TextBox txtCargosAcumCta;
        private System.Windows.Forms.Label lblCargosAcumCta;
    }
}