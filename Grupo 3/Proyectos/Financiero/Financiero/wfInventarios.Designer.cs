namespace Financiero
{
    partial class wfInventarios
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
            this.lblCod_inv = new System.Windows.Forms.Label();
            this.txtCod_inv = new System.Windows.Forms.TextBox();
            this.txtNom_inv = new System.Windows.Forms.TextBox();
            this.lblNom_inv = new System.Windows.Forms.Label();
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
            // lblCod_inv
            // 
            this.lblCod_inv.AutoSize = true;
            this.lblCod_inv.Location = new System.Drawing.Point(12, 73);
            this.lblCod_inv.Name = "lblCod_inv";
            this.lblCod_inv.Size = new System.Drawing.Size(116, 17);
            this.lblCod_inv.TabIndex = 1;
            this.lblCod_inv.Text = "Codigo Inventario";
            // 
            // txtCod_inv
            // 
            this.txtCod_inv.Location = new System.Drawing.Point(134, 70);
            this.txtCod_inv.Name = "txtCod_inv";
            this.txtCod_inv.Size = new System.Drawing.Size(150, 22);
            this.txtCod_inv.TabIndex = 14;
            this.txtCod_inv.EnabledChanged += new System.EventHandler(this.txtCod_inv_EnabledChanged);
            // 
            // txtNom_inv
            // 
            this.txtNom_inv.Location = new System.Drawing.Point(452, 70);
            this.txtNom_inv.Name = "txtNom_inv";
            this.txtNom_inv.Size = new System.Drawing.Size(150, 22);
            this.txtNom_inv.TabIndex = 15;
            this.txtNom_inv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_inv_KeyPress);
            // 
            // lblNom_inv
            // 
            this.lblNom_inv.AutoSize = true;
            this.lblNom_inv.Location = new System.Drawing.Point(326, 73);
            this.lblNom_inv.Name = "lblNom_inv";
            this.lblNom_inv.Size = new System.Drawing.Size(120, 17);
            this.lblNom_inv.TabIndex = 4;
            this.lblNom_inv.Text = "Nombre Inventario";
            // 
            // wfInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 101);
            this.Controls.Add(this.lblNom_inv);
            this.Controls.Add(this.txtNom_inv);
            this.Controls.Add(this.txtCod_inv);
            this.Controls.Add(this.lblCod_inv);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfInventarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.wfInventarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCod_inv;
        private System.Windows.Forms.TextBox txtCod_inv;
        private System.Windows.Forms.TextBox txtNom_inv;
        private System.Windows.Forms.Label lblNom_inv;
    }
}