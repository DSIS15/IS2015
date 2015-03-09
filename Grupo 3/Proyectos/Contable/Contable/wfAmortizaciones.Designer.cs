namespace Contable
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
            this.lblValor_amortizacion = new System.Windows.Forms.Label();
            this.lblEstado_amortizacion = new System.Windows.Forms.Label();
            this.lblNom_amortizacion = new System.Windows.Forms.Label();
            this.lblCod_amortizacion = new System.Windows.Forms.Label();
            this.cboEstado_amortizacion = new System.Windows.Forms.ComboBox();
            this.txtEstado_amortizacion = new System.Windows.Forms.TextBox();
            this.txtValor_amortizacion = new System.Windows.Forms.TextBox();
            this.txtNom_amortizacion = new System.Windows.Forms.TextBox();
            this.txtCod_amortizacion = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // lblValor_amortizacion
            // 
            this.lblValor_amortizacion.AutoSize = true;
            this.lblValor_amortizacion.Location = new System.Drawing.Point(12, 106);
            this.lblValor_amortizacion.Name = "lblValor_amortizacion";
            this.lblValor_amortizacion.Size = new System.Drawing.Size(40, 17);
            this.lblValor_amortizacion.TabIndex = 34;
            this.lblValor_amortizacion.Text = "Valor";
            // 
            // lblEstado_amortizacion
            // 
            this.lblEstado_amortizacion.AutoSize = true;
            this.lblEstado_amortizacion.Location = new System.Drawing.Point(363, 103);
            this.lblEstado_amortizacion.Name = "lblEstado_amortizacion";
            this.lblEstado_amortizacion.Size = new System.Drawing.Size(48, 17);
            this.lblEstado_amortizacion.TabIndex = 28;
            this.lblEstado_amortizacion.Text = "Estado";
            // 
            // lblNom_amortizacion
            // 
            this.lblNom_amortizacion.AutoSize = true;
            this.lblNom_amortizacion.Location = new System.Drawing.Point(363, 73);
            this.lblNom_amortizacion.Name = "lblNom_amortizacion";
            this.lblNom_amortizacion.Size = new System.Drawing.Size(87, 17);
            this.lblNom_amortizacion.TabIndex = 27;
            this.lblNom_amortizacion.Text = "Amortización";
            // 
            // lblCod_amortizacion
            // 
            this.lblCod_amortizacion.AutoSize = true;
            this.lblCod_amortizacion.Location = new System.Drawing.Point(12, 73);
            this.lblCod_amortizacion.Name = "lblCod_amortizacion";
            this.lblCod_amortizacion.Size = new System.Drawing.Size(52, 17);
            this.lblCod_amortizacion.TabIndex = 26;
            this.lblCod_amortizacion.Text = "Codigo";
            // 
            // cboEstado_amortizacion
            // 
            this.cboEstado_amortizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_amortizacion.FormattingEnabled = true;
            this.cboEstado_amortizacion.IntegralHeight = false;
            this.cboEstado_amortizacion.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_amortizacion.Location = new System.Drawing.Point(456, 100);
            this.cboEstado_amortizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstado_amortizacion.Name = "cboEstado_amortizacion";
            this.cboEstado_amortizacion.Size = new System.Drawing.Size(150, 25);
            this.cboEstado_amortizacion.TabIndex = 17;
            this.cboEstado_amortizacion.SelectedIndexChanged += new System.EventHandler(this.cboEstado_amortizacion_SelectedIndexChanged);
            // 
            // txtEstado_amortizacion
            // 
            this.txtEstado_amortizacion.Location = new System.Drawing.Point(330, 106);
            this.txtEstado_amortizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado_amortizacion.MaxLength = 1;
            this.txtEstado_amortizacion.Name = "txtEstado_amortizacion";
            this.txtEstado_amortizacion.Size = new System.Drawing.Size(27, 22);
            this.txtEstado_amortizacion.TabIndex = 33;
            this.txtEstado_amortizacion.Tag = "estado_imp";
            this.txtEstado_amortizacion.Visible = false;
            this.txtEstado_amortizacion.TextChanged += new System.EventHandler(this.txtEstado_amortizacion_TextChanged);
            // 
            // txtValor_amortizacion
            // 
            this.txtValor_amortizacion.Location = new System.Drawing.Point(70, 103);
            this.txtValor_amortizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor_amortizacion.MaxLength = 10;
            this.txtValor_amortizacion.Name = "txtValor_amortizacion";
            this.txtValor_amortizacion.Size = new System.Drawing.Size(150, 22);
            this.txtValor_amortizacion.TabIndex = 16;
            this.txtValor_amortizacion.Tag = "";
            this.txtValor_amortizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_amortizacion_KeyPress);
            // 
            // txtNom_amortizacion
            // 
            this.txtNom_amortizacion.Location = new System.Drawing.Point(456, 70);
            this.txtNom_amortizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom_amortizacion.MaxLength = 25;
            this.txtNom_amortizacion.Name = "txtNom_amortizacion";
            this.txtNom_amortizacion.Size = new System.Drawing.Size(150, 22);
            this.txtNom_amortizacion.TabIndex = 15;
            this.txtNom_amortizacion.Tag = "";
            this.txtNom_amortizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_amortizacion_KeyPress);
            // 
            // txtCod_amortizacion
            // 
            this.txtCod_amortizacion.Enabled = false;
            this.txtCod_amortizacion.Location = new System.Drawing.Point(70, 70);
            this.txtCod_amortizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCod_amortizacion.MaxLength = 4;
            this.txtCod_amortizacion.Name = "txtCod_amortizacion";
            this.txtCod_amortizacion.Size = new System.Drawing.Size(150, 22);
            this.txtCod_amortizacion.TabIndex = 14;
            this.txtCod_amortizacion.Tag = "";
            this.txtCod_amortizacion.EnabledChanged += new System.EventHandler(this.txtCod_amortizacion_EnabledChanged);
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
            // wfAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 139);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblValor_amortizacion);
            this.Controls.Add(this.lblEstado_amortizacion);
            this.Controls.Add(this.lblNom_amortizacion);
            this.Controls.Add(this.lblCod_amortizacion);
            this.Controls.Add(this.cboEstado_amortizacion);
            this.Controls.Add(this.txtEstado_amortizacion);
            this.Controls.Add(this.txtValor_amortizacion);
            this.Controls.Add(this.txtNom_amortizacion);
            this.Controls.Add(this.txtCod_amortizacion);
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

        private System.Windows.Forms.Label lblValor_amortizacion;
        private System.Windows.Forms.Label lblEstado_amortizacion;
        private System.Windows.Forms.Label lblNom_amortizacion;
        private System.Windows.Forms.Label lblCod_amortizacion;
        private System.Windows.Forms.ComboBox cboEstado_amortizacion;
        private System.Windows.Forms.TextBox txtEstado_amortizacion;
        private System.Windows.Forms.TextBox txtValor_amortizacion;
        private System.Windows.Forms.TextBox txtNom_amortizacion;
        private System.Windows.Forms.TextBox txtCod_amortizacion;
        private Navegador.Navegador navegador1;
    }
}