namespace Operaciones
{
    partial class wfAmortizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAmortizacion));
            this.lblValorAmort = new System.Windows.Forms.Label();
            this.lblEstadoAmort = new System.Windows.Forms.Label();
            this.lblAmortizacion = new System.Windows.Forms.Label();
            this.lblCodAmort = new System.Windows.Forms.Label();
            this.cboEstadoAmort = new System.Windows.Forms.ComboBox();
            this.txtEstadoAmort = new System.Windows.Forms.TextBox();
            this.txtValorAmort = new System.Windows.Forms.TextBox();
            this.txtAmort = new System.Windows.Forms.TextBox();
            this.txtCodAmort = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblAnioAmort = new System.Windows.Forms.Label();
            this.txtAnioAmort = new System.Windows.Forms.TextBox();
            this.lblInteresAmort = new System.Windows.Forms.Label();
            this.txtInteresAmort = new System.Windows.Forms.TextBox();
            this.lblCuentaCta = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorAmort
            // 
            this.lblValorAmort.AutoSize = true;
            this.lblValorAmort.Location = new System.Drawing.Point(12, 161);
            this.lblValorAmort.Name = "lblValorAmort";
            this.lblValorAmort.Size = new System.Drawing.Size(40, 17);
            this.lblValorAmort.TabIndex = 34;
            this.lblValorAmort.Text = "Valor";
            // 
            // lblEstadoAmort
            // 
            this.lblEstadoAmort.AutoSize = true;
            this.lblEstadoAmort.Location = new System.Drawing.Point(359, 161);
            this.lblEstadoAmort.Name = "lblEstadoAmort";
            this.lblEstadoAmort.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoAmort.TabIndex = 28;
            this.lblEstadoAmort.Text = "Estado";
            // 
            // lblAmortizacion
            // 
            this.lblAmortizacion.AutoSize = true;
            this.lblAmortizacion.Location = new System.Drawing.Point(359, 131);
            this.lblAmortizacion.Name = "lblAmortizacion";
            this.lblAmortizacion.Size = new System.Drawing.Size(87, 17);
            this.lblAmortizacion.TabIndex = 27;
            this.lblAmortizacion.Text = "Amortización";
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
            this.cboEstadoAmort.Location = new System.Drawing.Point(452, 158);
            this.cboEstadoAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstadoAmort.Name = "cboEstadoAmort";
            this.cboEstadoAmort.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoAmort.TabIndex = 17;
            this.cboEstadoAmort.SelectedIndexChanged += new System.EventHandler(this.cboEstado_amortizacion_SelectedIndexChanged);
            // 
            // txtEstadoAmort
            // 
            this.txtEstadoAmort.Location = new System.Drawing.Point(326, 158);
            this.txtEstadoAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstadoAmort.MaxLength = 1;
            this.txtEstadoAmort.Name = "txtEstadoAmort";
            this.txtEstadoAmort.Size = new System.Drawing.Size(27, 22);
            this.txtEstadoAmort.TabIndex = 33;
            this.txtEstadoAmort.Tag = "estado_imp";
            this.txtEstadoAmort.Visible = false;
            this.txtEstadoAmort.TextChanged += new System.EventHandler(this.txtEstado_amortizacion_TextChanged);
            // 
            // txtValorAmort
            // 
            this.txtValorAmort.Location = new System.Drawing.Point(70, 158);
            this.txtValorAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorAmort.MaxLength = 10;
            this.txtValorAmort.Name = "txtValorAmort";
            this.txtValorAmort.Size = new System.Drawing.Size(150, 22);
            this.txtValorAmort.TabIndex = 16;
            this.txtValorAmort.Tag = "";
            this.txtValorAmort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_amortizacion_KeyPress);
            // 
            // txtAmort
            // 
            this.txtAmort.Location = new System.Drawing.Point(452, 128);
            this.txtAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmort.MaxLength = 25;
            this.txtAmort.Name = "txtAmort";
            this.txtAmort.Size = new System.Drawing.Size(150, 22);
            this.txtAmort.TabIndex = 15;
            this.txtAmort.Tag = "";
            this.txtAmort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_amortizacion_KeyPress);
            // 
            // txtCodAmort
            // 
            this.txtCodAmort.Enabled = false;
            this.txtCodAmort.Location = new System.Drawing.Point(70, 68);
            this.txtCodAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodAmort.MaxLength = 4;
            this.txtCodAmort.Name = "txtCodAmort";
            this.txtCodAmort.Size = new System.Drawing.Size(150, 22);
            this.txtCodAmort.TabIndex = 14;
            this.txtCodAmort.Tag = "";
            this.txtCodAmort.EnabledChanged += new System.EventHandler(this.txtCod_amortizacion_EnabledChanged);
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
            this.navegador1.sNombreTabla = "";
            this.navegador1.TabIndex = 35;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblAnioAmort
            // 
            this.lblAnioAmort.AutoSize = true;
            this.lblAnioAmort.Location = new System.Drawing.Point(359, 101);
            this.lblAnioAmort.Name = "lblAnioAmort";
            this.lblAnioAmort.Size = new System.Drawing.Size(32, 17);
            this.lblAnioAmort.TabIndex = 37;
            this.lblAnioAmort.Text = "Año";
            // 
            // txtAnioAmort
            // 
            this.txtAnioAmort.Enabled = false;
            this.txtAnioAmort.Location = new System.Drawing.Point(452, 98);
            this.txtAnioAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnioAmort.MaxLength = 4;
            this.txtAnioAmort.Name = "txtAnioAmort";
            this.txtAnioAmort.Size = new System.Drawing.Size(150, 22);
            this.txtAnioAmort.TabIndex = 36;
            this.txtAnioAmort.Tag = "";
            // 
            // lblInteresAmort
            // 
            this.lblInteresAmort.AutoSize = true;
            this.lblInteresAmort.Location = new System.Drawing.Point(12, 133);
            this.lblInteresAmort.Name = "lblInteresAmort";
            this.lblInteresAmort.Size = new System.Drawing.Size(48, 17);
            this.lblInteresAmort.TabIndex = 39;
            this.lblInteresAmort.Text = "Interés";
            // 
            // txtInteresAmort
            // 
            this.txtInteresAmort.Enabled = false;
            this.txtInteresAmort.Location = new System.Drawing.Point(70, 128);
            this.txtInteresAmort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInteresAmort.MaxLength = 4;
            this.txtInteresAmort.Name = "txtInteresAmort";
            this.txtInteresAmort.Size = new System.Drawing.Size(150, 22);
            this.txtInteresAmort.TabIndex = 38;
            this.txtInteresAmort.Tag = "";
            // 
            // lblCuentaCta
            // 
            this.lblCuentaCta.AutoSize = true;
            this.lblCuentaCta.Location = new System.Drawing.Point(12, 103);
            this.lblCuentaCta.Name = "lblCuentaCta";
            this.lblCuentaCta.Size = new System.Drawing.Size(52, 17);
            this.lblCuentaCta.TabIndex = 41;
            this.lblCuentaCta.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Location = new System.Drawing.Point(70, 98);
            this.txtCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCuenta.MaxLength = 4;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(150, 22);
            this.txtCuenta.TabIndex = 40;
            this.txtCuenta.Tag = "";
            // 
            // wfAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 193);
            this.Controls.Add(this.lblCuentaCta);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblInteresAmort);
            this.Controls.Add(this.txtInteresAmort);
            this.Controls.Add(this.lblAnioAmort);
            this.Controls.Add(this.txtAnioAmort);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblValorAmort);
            this.Controls.Add(this.lblEstadoAmort);
            this.Controls.Add(this.lblAmortizacion);
            this.Controls.Add(this.lblCodAmort);
            this.Controls.Add(this.cboEstadoAmort);
            this.Controls.Add(this.txtEstadoAmort);
            this.Controls.Add(this.txtValorAmort);
            this.Controls.Add(this.txtAmort);
            this.Controls.Add(this.txtCodAmort);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfAmortizacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Amortizaciones";
            this.Load += new System.EventHandler(this.wfAmortizacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorAmort;
        private System.Windows.Forms.Label lblEstadoAmort;
        private System.Windows.Forms.Label lblAmortizacion;
        private System.Windows.Forms.Label lblCodAmort;
        private System.Windows.Forms.ComboBox cboEstadoAmort;
        private System.Windows.Forms.TextBox txtEstadoAmort;
        private System.Windows.Forms.TextBox txtValorAmort;
        private System.Windows.Forms.TextBox txtAmort;
        private System.Windows.Forms.TextBox txtCodAmort;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblAnioAmort;
        private System.Windows.Forms.TextBox txtAnioAmort;
        private System.Windows.Forms.Label lblInteresAmort;
        private System.Windows.Forms.TextBox txtInteresAmort;
        private System.Windows.Forms.Label lblCuentaCta;
        private System.Windows.Forms.TextBox txtCuenta;
    }
}