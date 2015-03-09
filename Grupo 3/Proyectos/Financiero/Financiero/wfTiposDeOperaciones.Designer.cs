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
            this.txtCod_op = new System.Windows.Forms.TextBox();
            this.lblCod_Op = new System.Windows.Forms.Label();
            this.lblNom_op = new System.Windows.Forms.Label();
            this.txtNom_op = new System.Windows.Forms.TextBox();
            this.lblEstado_op = new System.Windows.Forms.Label();
            this.txtEstado_op = new System.Windows.Forms.TextBox();
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
            this.navegador1.sNombreTabla = "";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // txtCod_op
            // 
            this.txtCod_op.Location = new System.Drawing.Point(137, 70);
            this.txtCod_op.Name = "txtCod_op";
            this.txtCod_op.Size = new System.Drawing.Size(150, 22);
            this.txtCod_op.TabIndex = 14;
            this.txtCod_op.EnabledChanged += new System.EventHandler(this.txtCod_op_EnabledChanged);
            // 
            // lblCod_Op
            // 
            this.lblCod_Op.AutoSize = true;
            this.lblCod_Op.Location = new System.Drawing.Point(12, 73);
            this.lblCod_Op.Name = "lblCod_Op";
            this.lblCod_Op.Size = new System.Drawing.Size(119, 17);
            this.lblCod_Op.TabIndex = 2;
            this.lblCod_Op.Text = "Codigo Operacion";
            // 
            // lblNom_op
            // 
            this.lblNom_op.AutoSize = true;
            this.lblNom_op.Location = new System.Drawing.Point(335, 75);
            this.lblNom_op.Name = "lblNom_op";
            this.lblNom_op.Size = new System.Drawing.Size(123, 17);
            this.lblNom_op.TabIndex = 3;
            this.lblNom_op.Text = "Nombre Operacion";
            // 
            // txtNom_op
            // 
            this.txtNom_op.Location = new System.Drawing.Point(464, 70);
            this.txtNom_op.Name = "txtNom_op";
            this.txtNom_op.Size = new System.Drawing.Size(150, 22);
            this.txtNom_op.TabIndex = 15;
            this.txtNom_op.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_op_KeyPress);
            // 
            // lblEstado_op
            // 
            this.lblEstado_op.AutoSize = true;
            this.lblEstado_op.Location = new System.Drawing.Point(12, 101);
            this.lblEstado_op.Name = "lblEstado_op";
            this.lblEstado_op.Size = new System.Drawing.Size(115, 17);
            this.lblEstado_op.TabIndex = 5;
            this.lblEstado_op.Text = "Estado Operacion";
            // 
            // txtEstado_op
            // 
            this.txtEstado_op.Location = new System.Drawing.Point(137, 98);
            this.txtEstado_op.Name = "txtEstado_op";
            this.txtEstado_op.Size = new System.Drawing.Size(150, 22);
            this.txtEstado_op.TabIndex = 16;
            // 
            // wfTipoDeMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 129);
            this.Controls.Add(this.txtEstado_op);
            this.Controls.Add(this.lblEstado_op);
            this.Controls.Add(this.txtNom_op);
            this.Controls.Add(this.lblNom_op);
            this.Controls.Add(this.lblCod_Op);
            this.Controls.Add(this.txtCod_op);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoDeMovimiento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tipos De Movimiento";
            this.Load += new System.EventHandler(this.wfTiposDeOperaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtCod_op;
        private System.Windows.Forms.Label lblCod_Op;
        private System.Windows.Forms.Label lblNom_op;
        private System.Windows.Forms.TextBox txtNom_op;
        private System.Windows.Forms.Label lblEstado_op;
        private System.Windows.Forms.TextBox txtEstado_op;

    }
}