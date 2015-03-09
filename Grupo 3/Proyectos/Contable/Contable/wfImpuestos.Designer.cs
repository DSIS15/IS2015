namespace Contable
{
    partial class wfImpuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfImpuesto));
            this.lblEstado_imp = new System.Windows.Forms.Label();
            this.lblNom_imp = new System.Windows.Forms.Label();
            this.lblCod_imp = new System.Windows.Forms.Label();
            this.cboEstado_imp = new System.Windows.Forms.ComboBox();
            this.txtEstado_imp = new System.Windows.Forms.TextBox();
            this.txtValor_imp = new System.Windows.Forms.TextBox();
            this.txtNom_imp = new System.Windows.Forms.TextBox();
            this.txtCod_imp = new System.Windows.Forms.TextBox();
            this.lblValor_imp = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // lblEstado_imp
            // 
            this.lblEstado_imp.AutoSize = true;
            this.lblEstado_imp.Location = new System.Drawing.Point(387, 100);
            this.lblEstado_imp.Name = "lblEstado_imp";
            this.lblEstado_imp.Size = new System.Drawing.Size(48, 17);
            this.lblEstado_imp.TabIndex = 19;
            this.lblEstado_imp.Text = "Estado";
            // 
            // lblNom_imp
            // 
            this.lblNom_imp.AutoSize = true;
            this.lblNom_imp.Location = new System.Drawing.Point(387, 73);
            this.lblNom_imp.Name = "lblNom_imp";
            this.lblNom_imp.Size = new System.Drawing.Size(63, 17);
            this.lblNom_imp.TabIndex = 18;
            this.lblNom_imp.Text = "Impuesto";
            // 
            // lblCod_imp
            // 
            this.lblCod_imp.AutoSize = true;
            this.lblCod_imp.Location = new System.Drawing.Point(12, 73);
            this.lblCod_imp.Name = "lblCod_imp";
            this.lblCod_imp.Size = new System.Drawing.Size(52, 17);
            this.lblCod_imp.TabIndex = 17;
            this.lblCod_imp.Text = "Codigo";
            // 
            // cboEstado_imp
            // 
            this.cboEstado_imp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_imp.FormattingEnabled = true;
            this.cboEstado_imp.IntegralHeight = false;
            this.cboEstado_imp.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_imp.Location = new System.Drawing.Point(456, 99);
            this.cboEstado_imp.Name = "cboEstado_imp";
            this.cboEstado_imp.Size = new System.Drawing.Size(150, 25);
            this.cboEstado_imp.TabIndex = 17;
            this.cboEstado_imp.SelectedIndexChanged += new System.EventHandler(this.cboEstado_imp_SelectedIndexChanged);
            // 
            // txtEstado_imp
            // 
            this.txtEstado_imp.Location = new System.Drawing.Point(357, 97);
            this.txtEstado_imp.MaxLength = 1;
            this.txtEstado_imp.Name = "txtEstado_imp";
            this.txtEstado_imp.Size = new System.Drawing.Size(24, 22);
            this.txtEstado_imp.TabIndex = 24;
            this.txtEstado_imp.Tag = "estado_imp";
            this.txtEstado_imp.Visible = false;
            this.txtEstado_imp.TextChanged += new System.EventHandler(this.txtEstado_imp_TextChanged);
            // 
            // txtValor_imp
            // 
            this.txtValor_imp.Location = new System.Drawing.Point(70, 98);
            this.txtValor_imp.MaxLength = 10;
            this.txtValor_imp.Name = "txtValor_imp";
            this.txtValor_imp.Size = new System.Drawing.Size(150, 22);
            this.txtValor_imp.TabIndex = 16;
            this.txtValor_imp.Tag = "";
            this.txtValor_imp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_imp_KeyPress);
            // 
            // txtNom_imp
            // 
            this.txtNom_imp.Location = new System.Drawing.Point(456, 70);
            this.txtNom_imp.MaxLength = 25;
            this.txtNom_imp.Name = "txtNom_imp";
            this.txtNom_imp.Size = new System.Drawing.Size(150, 22);
            this.txtNom_imp.TabIndex = 15;
            this.txtNom_imp.Tag = "";
            this.txtNom_imp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_imp_KeyPress);
            // 
            // txtCod_imp
            // 
            this.txtCod_imp.Enabled = false;
            this.txtCod_imp.Location = new System.Drawing.Point(70, 70);
            this.txtCod_imp.MaxLength = 4;
            this.txtCod_imp.Name = "txtCod_imp";
            this.txtCod_imp.Size = new System.Drawing.Size(150, 22);
            this.txtCod_imp.TabIndex = 14;
            this.txtCod_imp.Tag = "";
            this.txtCod_imp.EnabledChanged += new System.EventHandler(this.txtCod_imp_EnabledChanged);
            // 
            // lblValor_imp
            // 
            this.lblValor_imp.AutoSize = true;
            this.lblValor_imp.Location = new System.Drawing.Point(11, 99);
            this.lblValor_imp.Name = "lblValor_imp";
            this.lblValor_imp.Size = new System.Drawing.Size(40, 17);
            this.lblValor_imp.TabIndex = 25;
            this.lblValor_imp.Text = "Valor";
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
            this.navegador1.TabIndex = 26;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // wfImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 134);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblValor_imp);
            this.Controls.Add(this.lblEstado_imp);
            this.Controls.Add(this.lblNom_imp);
            this.Controls.Add(this.lblCod_imp);
            this.Controls.Add(this.cboEstado_imp);
            this.Controls.Add(this.txtEstado_imp);
            this.Controls.Add(this.txtValor_imp);
            this.Controls.Add(this.txtNom_imp);
            this.Controls.Add(this.txtCod_imp);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfImpuesto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Impuestos";
            this.Load += new System.EventHandler(this.wfImpuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado_imp;
        private System.Windows.Forms.Label lblNom_imp;
        private System.Windows.Forms.Label lblCod_imp;
        private System.Windows.Forms.ComboBox cboEstado_imp;
        private System.Windows.Forms.TextBox txtEstado_imp;
        private System.Windows.Forms.TextBox txtValor_imp;
        private System.Windows.Forms.TextBox txtNom_imp;
        private System.Windows.Forms.TextBox txtCod_imp;
        private System.Windows.Forms.Label lblValor_imp;
        private Navegador.Navegador navegador1;
    }
}