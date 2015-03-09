namespace Financiero
{
    partial class wfEstadoCuentaBanco
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
            this.lblCod_estdocta = new System.Windows.Forms.Label();
            this.txtCod_estdocta = new System.Windows.Forms.TextBox();
            this.lblCod_cta = new System.Windows.Forms.Label();
            this.txtCod_cta = new System.Windows.Forms.TextBox();
            this.lblEstado_estdocta = new System.Windows.Forms.Label();
            this.txtEstado_estdocta = new System.Windows.Forms.TextBox();
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
            // lblCod_estdocta
            // 
            this.lblCod_estdocta.AutoSize = true;
            this.lblCod_estdocta.Location = new System.Drawing.Point(12, 73);
            this.lblCod_estdocta.Name = "lblCod_estdocta";
            this.lblCod_estdocta.Size = new System.Drawing.Size(164, 17);
            this.lblCod_estdocta.TabIndex = 1;
            this.lblCod_estdocta.Text = "Codigo  Estado de Cuenta";
            // 
            // txtCod_estdocta
            // 
            this.txtCod_estdocta.Location = new System.Drawing.Point(197, 70);
            this.txtCod_estdocta.Name = "txtCod_estdocta";
            this.txtCod_estdocta.Size = new System.Drawing.Size(150, 22);
            this.txtCod_estdocta.TabIndex = 14;
            this.txtCod_estdocta.EnabledChanged += new System.EventHandler(this.txtCod_estdocta_EnabledChanged);
            // 
            // lblCod_cta
            // 
            this.lblCod_cta.AutoSize = true;
            this.lblCod_cta.Location = new System.Drawing.Point(355, 73);
            this.lblCod_cta.Name = "lblCod_cta";
            this.lblCod_cta.Size = new System.Drawing.Size(99, 17);
            this.lblCod_cta.TabIndex = 3;
            this.lblCod_cta.Text = "Codigo Cuenta";
            // 
            // txtCod_cta
            // 
            this.txtCod_cta.Location = new System.Drawing.Point(464, 70);
            this.txtCod_cta.Name = "txtCod_cta";
            this.txtCod_cta.Size = new System.Drawing.Size(150, 22);
            this.txtCod_cta.TabIndex = 15;
            // 
            // lblEstado_estdocta
            // 
            this.lblEstado_estdocta.AutoSize = true;
            this.lblEstado_estdocta.Location = new System.Drawing.Point(12, 101);
            this.lblEstado_estdocta.Name = "lblEstado_estdocta";
            this.lblEstado_estdocta.Size = new System.Drawing.Size(179, 17);
            this.lblEstado_estdocta.TabIndex = 5;
            this.lblEstado_estdocta.Text = "Estado del Estado de Cuenta";
            // 
            // txtEstado_estdocta
            // 
            this.txtEstado_estdocta.Location = new System.Drawing.Point(197, 98);
            this.txtEstado_estdocta.Name = "txtEstado_estdocta";
            this.txtEstado_estdocta.Size = new System.Drawing.Size(150, 22);
            this.txtEstado_estdocta.TabIndex = 16;
            // 
            // wfEstadoCuentaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 131);
            this.Controls.Add(this.txtEstado_estdocta);
            this.Controls.Add(this.lblEstado_estdocta);
            this.Controls.Add(this.txtCod_cta);
            this.Controls.Add(this.lblCod_cta);
            this.Controls.Add(this.txtCod_estdocta);
            this.Controls.Add(this.lblCod_estdocta);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEstadoCuentaBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Estado Cuenta Banco";
            this.Load += new System.EventHandler(this.wfEstadoCuentaBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCod_estdocta;
        private System.Windows.Forms.TextBox txtCod_estdocta;
        private System.Windows.Forms.Label lblCod_cta;
        private System.Windows.Forms.TextBox txtCod_cta;
        private System.Windows.Forms.Label lblEstado_estdocta;
        private System.Windows.Forms.TextBox txtEstado_estdocta;
    }
}