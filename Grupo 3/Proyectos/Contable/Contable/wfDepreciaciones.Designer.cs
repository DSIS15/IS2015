namespace Contable
{
    partial class wfDepreciacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDepreciacion));
            this.lblValor_depreciacion = new System.Windows.Forms.Label();
            this.lblEstado_depreciacion = new System.Windows.Forms.Label();
            this.lblNom_depreciacion = new System.Windows.Forms.Label();
            this.lblCod_depreciacion = new System.Windows.Forms.Label();
            this.cboEstado_depreciacion = new System.Windows.Forms.ComboBox();
            this.txtEstado_depreciacion = new System.Windows.Forms.TextBox();
            this.txtValor_depreciacion = new System.Windows.Forms.TextBox();
            this.txtNom_depreciacion = new System.Windows.Forms.TextBox();
            this.txtCod_depreciacion = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // lblValor_depreciacion
            // 
            this.lblValor_depreciacion.AutoSize = true;
            this.lblValor_depreciacion.Location = new System.Drawing.Point(12, 106);
            this.lblValor_depreciacion.Name = "lblValor_depreciacion";
            this.lblValor_depreciacion.Size = new System.Drawing.Size(40, 17);
            this.lblValor_depreciacion.TabIndex = 43;
            this.lblValor_depreciacion.Text = "Valor";
            // 
            // lblEstado_depreciacion
            // 
            this.lblEstado_depreciacion.AutoSize = true;
            this.lblEstado_depreciacion.Location = new System.Drawing.Point(359, 106);
            this.lblEstado_depreciacion.Name = "lblEstado_depreciacion";
            this.lblEstado_depreciacion.Size = new System.Drawing.Size(48, 17);
            this.lblEstado_depreciacion.TabIndex = 37;
            this.lblEstado_depreciacion.Text = "Estado";
            // 
            // lblNom_depreciacion
            // 
            this.lblNom_depreciacion.AutoSize = true;
            this.lblNom_depreciacion.Location = new System.Drawing.Point(359, 73);
            this.lblNom_depreciacion.Name = "lblNom_depreciacion";
            this.lblNom_depreciacion.Size = new System.Drawing.Size(90, 17);
            this.lblNom_depreciacion.TabIndex = 36;
            this.lblNom_depreciacion.Text = "Depreciación";
            // 
            // lblCod_depreciacion
            // 
            this.lblCod_depreciacion.AutoSize = true;
            this.lblCod_depreciacion.Location = new System.Drawing.Point(12, 73);
            this.lblCod_depreciacion.Name = "lblCod_depreciacion";
            this.lblCod_depreciacion.Size = new System.Drawing.Size(52, 17);
            this.lblCod_depreciacion.TabIndex = 35;
            this.lblCod_depreciacion.Text = "Codigo";
            // 
            // cboEstado_depreciacion
            // 
            this.cboEstado_depreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_depreciacion.FormattingEnabled = true;
            this.cboEstado_depreciacion.IntegralHeight = false;
            this.cboEstado_depreciacion.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_depreciacion.Location = new System.Drawing.Point(455, 103);
            this.cboEstado_depreciacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboEstado_depreciacion.Name = "cboEstado_depreciacion";
            this.cboEstado_depreciacion.Size = new System.Drawing.Size(150, 25);
            this.cboEstado_depreciacion.TabIndex = 17;
            this.cboEstado_depreciacion.SelectedIndexChanged += new System.EventHandler(this.cboEstado_depreciacion_SelectedIndexChanged);
            // 
            // txtEstado_depreciacion
            // 
            this.txtEstado_depreciacion.Location = new System.Drawing.Point(322, 103);
            this.txtEstado_depreciacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEstado_depreciacion.MaxLength = 1;
            this.txtEstado_depreciacion.Name = "txtEstado_depreciacion";
            this.txtEstado_depreciacion.Size = new System.Drawing.Size(31, 22);
            this.txtEstado_depreciacion.TabIndex = 42;
            this.txtEstado_depreciacion.Tag = "estado_imp";
            this.txtEstado_depreciacion.Visible = false;
            this.txtEstado_depreciacion.TextChanged += new System.EventHandler(this.txtEstado_depreciacion_TextChanged);
            // 
            // txtValor_depreciacion
            // 
            this.txtValor_depreciacion.Location = new System.Drawing.Point(70, 103);
            this.txtValor_depreciacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtValor_depreciacion.MaxLength = 10;
            this.txtValor_depreciacion.Name = "txtValor_depreciacion";
            this.txtValor_depreciacion.Size = new System.Drawing.Size(150, 22);
            this.txtValor_depreciacion.TabIndex = 16;
            this.txtValor_depreciacion.Tag = "";
            this.txtValor_depreciacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_depreciacion_KeyPress);
            // 
            // txtNom_depreciacion
            // 
            this.txtNom_depreciacion.Location = new System.Drawing.Point(455, 70);
            this.txtNom_depreciacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNom_depreciacion.MaxLength = 25;
            this.txtNom_depreciacion.Name = "txtNom_depreciacion";
            this.txtNom_depreciacion.Size = new System.Drawing.Size(150, 22);
            this.txtNom_depreciacion.TabIndex = 15;
            this.txtNom_depreciacion.Tag = "";
            this.txtNom_depreciacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_depreciacion_KeyPress);
            // 
            // txtCod_depreciacion
            // 
            this.txtCod_depreciacion.Enabled = false;
            this.txtCod_depreciacion.Location = new System.Drawing.Point(70, 70);
            this.txtCod_depreciacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCod_depreciacion.MaxLength = 4;
            this.txtCod_depreciacion.Name = "txtCod_depreciacion";
            this.txtCod_depreciacion.Size = new System.Drawing.Size(150, 22);
            this.txtCod_depreciacion.TabIndex = 14;
            this.txtCod_depreciacion.Tag = "";
            this.txtCod_depreciacion.EnabledChanged += new System.EventHandler(this.txtCod_depreciacion_EnabledChanged);
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
            this.navegador1.TabIndex = 44;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // wfDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 135);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblValor_depreciacion);
            this.Controls.Add(this.lblEstado_depreciacion);
            this.Controls.Add(this.lblNom_depreciacion);
            this.Controls.Add(this.lblCod_depreciacion);
            this.Controls.Add(this.cboEstado_depreciacion);
            this.Controls.Add(this.txtEstado_depreciacion);
            this.Controls.Add(this.txtValor_depreciacion);
            this.Controls.Add(this.txtNom_depreciacion);
            this.Controls.Add(this.txtCod_depreciacion);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDepreciacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Depreciaciones";
            this.Load += new System.EventHandler(this.wfDepreciacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor_depreciacion;
        private System.Windows.Forms.Label lblEstado_depreciacion;
        private System.Windows.Forms.Label lblNom_depreciacion;
        private System.Windows.Forms.Label lblCod_depreciacion;
        private System.Windows.Forms.ComboBox cboEstado_depreciacion;
        private System.Windows.Forms.TextBox txtEstado_depreciacion;
        private System.Windows.Forms.TextBox txtValor_depreciacion;
        private System.Windows.Forms.TextBox txtNom_depreciacion;
        private System.Windows.Forms.TextBox txtCod_depreciacion;
        private Navegador.Navegador navegador1;
    }
}