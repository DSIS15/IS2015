namespace Seguridad
{
    partial class wfMonedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMonedas));
            this.txtCodMda = new System.Windows.Forms.TextBox();
            this.lblCodMda = new System.Windows.Forms.Label();
            this.txtMonedaMda = new System.Windows.Forms.TextBox();
            this.lblMonedaMda = new System.Windows.Forms.Label();
            this.txtEstadoMda = new System.Windows.Forms.TextBox();
            this.cboEstadoMda = new System.Windows.Forms.ComboBox();
            this.lblEstadoMda = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.txtAbrevMda = new System.Windows.Forms.TextBox();
            this.lblAbrevMda = new System.Windows.Forms.Label();
            this.txtTipoCambioMda = new System.Windows.Forms.TextBox();
            this.lblTipoCambioMda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodMda
            // 
            this.txtCodMda.Enabled = false;
            this.txtCodMda.Location = new System.Drawing.Point(119, 72);
            this.txtCodMda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodMda.MaxLength = 7;
            this.txtCodMda.Name = "txtCodMda";
            this.txtCodMda.Size = new System.Drawing.Size(150, 22);
            this.txtCodMda.TabIndex = 14;
            this.txtCodMda.Tag = "cod_mda";
            this.txtCodMda.EnabledChanged += new System.EventHandler(this.txtCodMda_EnabledChanged);
            this.txtCodMda.TextChanged += new System.EventHandler(this.txtCodMda_TextChanged);
            // 
            // lblCodMda
            // 
            this.lblCodMda.AutoSize = true;
            this.lblCodMda.Location = new System.Drawing.Point(12, 75);
            this.lblCodMda.Name = "lblCodMda";
            this.lblCodMda.Size = new System.Drawing.Size(52, 17);
            this.lblCodMda.TabIndex = 15;
            this.lblCodMda.Text = "Codigo";
            // 
            // txtMonedaMda
            // 
            this.txtMonedaMda.Enabled = false;
            this.txtMonedaMda.Location = new System.Drawing.Point(119, 102);
            this.txtMonedaMda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonedaMda.MaxLength = 25;
            this.txtMonedaMda.Name = "txtMonedaMda";
            this.txtMonedaMda.Size = new System.Drawing.Size(150, 22);
            this.txtMonedaMda.TabIndex = 15;
            this.txtMonedaMda.Tag = "moneda_mda";
            this.txtMonedaMda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonedaMda_KeyPress);
            // 
            // lblMonedaMda
            // 
            this.lblMonedaMda.AutoSize = true;
            this.lblMonedaMda.Location = new System.Drawing.Point(12, 105);
            this.lblMonedaMda.Name = "lblMonedaMda";
            this.lblMonedaMda.Size = new System.Drawing.Size(58, 17);
            this.lblMonedaMda.TabIndex = 17;
            this.lblMonedaMda.Text = "Moneda";
            // 
            // txtEstadoMda
            // 
            this.txtEstadoMda.Location = new System.Drawing.Point(336, 132);
            this.txtEstadoMda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstadoMda.MaxLength = 1;
            this.txtEstadoMda.Name = "txtEstadoMda";
            this.txtEstadoMda.Size = new System.Drawing.Size(24, 22);
            this.txtEstadoMda.TabIndex = 19;
            this.txtEstadoMda.Tag = "estado_mda";
            this.txtEstadoMda.Visible = false;
            this.txtEstadoMda.EnabledChanged += new System.EventHandler(this.txtEstadoMda_EnabledChanged);
            this.txtEstadoMda.TextChanged += new System.EventHandler(this.txtEstadoMda_TextChanged);
            // 
            // cboEstadoMda
            // 
            this.cboEstadoMda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoMda.FormattingEnabled = true;
            this.cboEstadoMda.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoMda.Location = new System.Drawing.Point(452, 132);
            this.cboEstadoMda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstadoMda.Name = "cboEstadoMda";
            this.cboEstadoMda.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoMda.TabIndex = 18;
            this.cboEstadoMda.SelectedIndexChanged += new System.EventHandler(this.cboEstadoMda_SelectedIndexChanged);
            // 
            // lblEstadoMda
            // 
            this.lblEstadoMda.AutoSize = true;
            this.lblEstadoMda.Location = new System.Drawing.Point(366, 135);
            this.lblEstadoMda.Name = "lblEstadoMda";
            this.lblEstadoMda.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoMda.TabIndex = 28;
            this.lblEstadoMda.Text = "Estado";
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
            this.navegador1.sNombreTabla = "tabm_moneda";
            this.navegador1.TabIndex = 31;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // txtAbrevMda
            // 
            this.txtAbrevMda.Enabled = false;
            this.txtAbrevMda.Location = new System.Drawing.Point(452, 102);
            this.txtAbrevMda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAbrevMda.MaxLength = 25;
            this.txtAbrevMda.Name = "txtAbrevMda";
            this.txtAbrevMda.Size = new System.Drawing.Size(150, 22);
            this.txtAbrevMda.TabIndex = 16;
            this.txtAbrevMda.Tag = "abrev_mda";
            this.txtAbrevMda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbrevMda_KeyPress);
            // 
            // lblAbrevMda
            // 
            this.lblAbrevMda.AutoSize = true;
            this.lblAbrevMda.Location = new System.Drawing.Point(366, 105);
            this.lblAbrevMda.Name = "lblAbrevMda";
            this.lblAbrevMda.Size = new System.Drawing.Size(80, 17);
            this.lblAbrevMda.TabIndex = 32;
            this.lblAbrevMda.Text = "Abreviatura";
            // 
            // txtTipoCambioMda
            // 
            this.txtTipoCambioMda.Enabled = false;
            this.txtTipoCambioMda.Location = new System.Drawing.Point(119, 132);
            this.txtTipoCambioMda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTipoCambioMda.MaxLength = 25;
            this.txtTipoCambioMda.Name = "txtTipoCambioMda";
            this.txtTipoCambioMda.Size = new System.Drawing.Size(150, 22);
            this.txtTipoCambioMda.TabIndex = 17;
            this.txtTipoCambioMda.Tag = "tipocambio_mda";
            this.txtTipoCambioMda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoCambioMda_KeyPress);
            // 
            // lblTipoCambioMda
            // 
            this.lblTipoCambioMda.AutoSize = true;
            this.lblTipoCambioMda.Location = new System.Drawing.Point(12, 135);
            this.lblTipoCambioMda.Name = "lblTipoCambioMda";
            this.lblTipoCambioMda.Size = new System.Drawing.Size(101, 17);
            this.lblTipoCambioMda.TabIndex = 34;
            this.lblTipoCambioMda.Text = "Tipo de Cambio";
            // 
            // wfMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 166);
            this.Controls.Add(this.txtTipoCambioMda);
            this.Controls.Add(this.lblTipoCambioMda);
            this.Controls.Add(this.txtAbrevMda);
            this.Controls.Add(this.lblAbrevMda);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstadoMda);
            this.Controls.Add(this.cboEstadoMda);
            this.Controls.Add(this.lblEstadoMda);
            this.Controls.Add(this.txtMonedaMda);
            this.Controls.Add(this.lblMonedaMda);
            this.Controls.Add(this.txtCodMda);
            this.Controls.Add(this.lblCodMda);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfMonedas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moneda";
            this.Load += new System.EventHandler(this.wfMoneda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodMda;
        private System.Windows.Forms.Label lblCodMda;
        private System.Windows.Forms.TextBox txtMonedaMda;
        private System.Windows.Forms.Label lblMonedaMda;
        private System.Windows.Forms.TextBox txtEstadoMda;
        private System.Windows.Forms.ComboBox cboEstadoMda;
        private System.Windows.Forms.Label lblEstadoMda;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtAbrevMda;
        private System.Windows.Forms.Label lblAbrevMda;
        private System.Windows.Forms.TextBox txtTipoCambioMda;
        private System.Windows.Forms.Label lblTipoCambioMda;
    }
}