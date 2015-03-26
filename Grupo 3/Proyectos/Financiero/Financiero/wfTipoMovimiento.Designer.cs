namespace Financiero
{
    partial class wfTipoDeMovimiento
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
            this.navegador1 = new Navegador.Navegador();
            this.lblCodTmov = new System.Windows.Forms.Label();
            this.lblNombreTmov = new System.Windows.Forms.Label();
            this.lblDescripTmov = new System.Windows.Forms.Label();
            this.lblEstadoTmov = new System.Windows.Forms.Label();
            this.txtCodTmov = new System.Windows.Forms.TextBox();
            this.txtNombreTmov = new System.Windows.Forms.TextBox();
            this.txtDescripTmov = new System.Windows.Forms.TextBox();
            this.txtEstadoTmov = new System.Windows.Forms.TextBox();
            this.cboEstadoTmov = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = null;
            this.navegador1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(614, 55);
            this.navegador1.sNombreTabla = "tabm_tmovimiento";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblCodTmov
            // 
            this.lblCodTmov.AutoSize = true;
            this.lblCodTmov.Location = new System.Drawing.Point(12, 73);
            this.lblCodTmov.Name = "lblCodTmov";
            this.lblCodTmov.Size = new System.Drawing.Size(52, 17);
            this.lblCodTmov.TabIndex = 1;
            this.lblCodTmov.Text = "Codigo";
            // 
            // lblNombreTmov
            // 
            this.lblNombreTmov.AutoSize = true;
            this.lblNombreTmov.Location = new System.Drawing.Point(12, 101);
            this.lblNombreTmov.Name = "lblNombreTmov";
            this.lblNombreTmov.Size = new System.Drawing.Size(56, 17);
            this.lblNombreTmov.TabIndex = 2;
            this.lblNombreTmov.Text = "Nombre";
            // 
            // lblDescripTmov
            // 
            this.lblDescripTmov.AutoSize = true;
            this.lblDescripTmov.Location = new System.Drawing.Point(367, 101);
            this.lblDescripTmov.Name = "lblDescripTmov";
            this.lblDescripTmov.Size = new System.Drawing.Size(79, 17);
            this.lblDescripTmov.TabIndex = 3;
            this.lblDescripTmov.Text = "Descripcion";
            // 
            // lblEstadoTmov
            // 
            this.lblEstadoTmov.AutoSize = true;
            this.lblEstadoTmov.Location = new System.Drawing.Point(12, 129);
            this.lblEstadoTmov.Name = "lblEstadoTmov";
            this.lblEstadoTmov.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoTmov.TabIndex = 4;
            this.lblEstadoTmov.Text = "Estado";
            // 
            // txtCodTmov
            // 
            this.txtCodTmov.Location = new System.Drawing.Point(74, 70);
            this.txtCodTmov.MaxLength = 7;
            this.txtCodTmov.Name = "txtCodTmov";
            this.txtCodTmov.Size = new System.Drawing.Size(150, 22);
            this.txtCodTmov.TabIndex = 14;
            this.txtCodTmov.Tag = "codigo_tmov";
            this.txtCodTmov.TextChanged += new System.EventHandler(this.txtCodTmov_TextChanged);
            // 
            // txtNombreTmov
            // 
            this.txtNombreTmov.Location = new System.Drawing.Point(74, 98);
            this.txtNombreTmov.MaxLength = 25;
            this.txtNombreTmov.Name = "txtNombreTmov";
            this.txtNombreTmov.Size = new System.Drawing.Size(150, 22);
            this.txtNombreTmov.TabIndex = 15;
            this.txtNombreTmov.Tag = "nombre_tmov";
            this.txtNombreTmov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTmov_KeyPress);
            // 
            // txtDescripTmov
            // 
            this.txtDescripTmov.Location = new System.Drawing.Point(452, 98);
            this.txtDescripTmov.MaxLength = 100;
            this.txtDescripTmov.Name = "txtDescripTmov";
            this.txtDescripTmov.Size = new System.Drawing.Size(150, 22);
            this.txtDescripTmov.TabIndex = 16;
            this.txtDescripTmov.Tag = "descrip_tmov";
            this.txtDescripTmov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripTmov_KeyPress);
            // 
            // txtEstadoTmov
            // 
            this.txtEstadoTmov.Location = new System.Drawing.Point(230, 126);
            this.txtEstadoTmov.MaxLength = 1;
            this.txtEstadoTmov.Name = "txtEstadoTmov";
            this.txtEstadoTmov.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoTmov.TabIndex = 18;
            this.txtEstadoTmov.Tag = "estado_tmov";
            this.txtEstadoTmov.Visible = false;
            this.txtEstadoTmov.EnabledChanged += new System.EventHandler(this.txtEstadoTmov_EnabledChanged);
            this.txtEstadoTmov.TextChanged += new System.EventHandler(this.txtEstadoTmov_TextChanged);
            // 
            // cboEstadoTmov
            // 
            this.cboEstadoTmov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoTmov.FormattingEnabled = true;
            this.cboEstadoTmov.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoTmov.Location = new System.Drawing.Point(74, 126);
            this.cboEstadoTmov.Name = "cboEstadoTmov";
            this.cboEstadoTmov.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoTmov.TabIndex = 17;
            this.cboEstadoTmov.SelectedIndexChanged += new System.EventHandler(this.cboEstadoTmov_SelectedIndexChanged);
            // 
            // wfTipoDeMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 161);
            this.Controls.Add(this.cboEstadoTmov);
            this.Controls.Add(this.txtEstadoTmov);
            this.Controls.Add(this.txtDescripTmov);
            this.Controls.Add(this.txtNombreTmov);
            this.Controls.Add(this.txtCodTmov);
            this.Controls.Add(this.lblEstadoTmov);
            this.Controls.Add(this.lblDescripTmov);
            this.Controls.Add(this.lblNombreTmov);
            this.Controls.Add(this.lblCodTmov);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoDeMovimiento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tipos de Movimientos";
            this.Load += new System.EventHandler(this.wfTiposDeOperaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodTmov;
        private System.Windows.Forms.Label lblNombreTmov;
        private System.Windows.Forms.Label lblDescripTmov;
        private System.Windows.Forms.Label lblEstadoTmov;
        private System.Windows.Forms.TextBox txtCodTmov;
        private System.Windows.Forms.TextBox txtNombreTmov;
        private System.Windows.Forms.TextBox txtDescripTmov;
        private System.Windows.Forms.TextBox txtEstadoTmov;
        private System.Windows.Forms.ComboBox cboEstadoTmov;

    }
}