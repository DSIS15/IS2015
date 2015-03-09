namespace Contable
{
    partial class wfPolizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPolizas));
            this.navegador1 = new Navegador.Navegador();
            this.lblCod_plz = new System.Windows.Forms.Label();
            this.txtCodigo_plz = new System.Windows.Forms.TextBox();
            this.lblNom_plz = new System.Windows.Forms.Label();
            this.txtNom_plz = new System.Windows.Forms.TextBox();
            this.lblFechemi_plz = new System.Windows.Forms.Label();
            this.lblDescrip_plz = new System.Windows.Forms.Label();
            this.dtpFechEmi = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
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
            this.navegador1.Size = new System.Drawing.Size(614, 55);
            this.navegador1.sNombreTabla = "";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            // 
            // lblCod_plz
            // 
            this.lblCod_plz.AutoSize = true;
            this.lblCod_plz.Location = new System.Drawing.Point(12, 76);
            this.lblCod_plz.Name = "lblCod_plz";
            this.lblCod_plz.Size = new System.Drawing.Size(89, 17);
            this.lblCod_plz.TabIndex = 1;
            this.lblCod_plz.Text = "Codigo Poliza";
            // 
            // txtCodigo_plz
            // 
            this.txtCodigo_plz.Enabled = false;
            this.txtCodigo_plz.Location = new System.Drawing.Point(107, 70);
            this.txtCodigo_plz.Name = "txtCodigo_plz";
            this.txtCodigo_plz.Size = new System.Drawing.Size(150, 22);
            this.txtCodigo_plz.TabIndex = 14;
            // 
            // lblNom_plz
            // 
            this.lblNom_plz.AutoSize = true;
            this.lblNom_plz.Location = new System.Drawing.Point(353, 74);
            this.lblNom_plz.Name = "lblNom_plz";
            this.lblNom_plz.Size = new System.Drawing.Size(93, 17);
            this.lblNom_plz.TabIndex = 3;
            this.lblNom_plz.Text = "Nombre Poliza";
            // 
            // txtNom_plz
            // 
            this.txtNom_plz.Location = new System.Drawing.Point(452, 71);
            this.txtNom_plz.Name = "txtNom_plz";
            this.txtNom_plz.Size = new System.Drawing.Size(150, 22);
            this.txtNom_plz.TabIndex = 15;
            this.txtNom_plz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_plz_KeyPress);
            // 
            // lblFechemi_plz
            // 
            this.lblFechemi_plz.AutoSize = true;
            this.lblFechemi_plz.Location = new System.Drawing.Point(12, 116);
            this.lblFechemi_plz.Name = "lblFechemi_plz";
            this.lblFechemi_plz.Size = new System.Drawing.Size(110, 17);
            this.lblFechemi_plz.TabIndex = 5;
            this.lblFechemi_plz.Text = "Fecha de Emision";
            // 
            // lblDescrip_plz
            // 
            this.lblDescrip_plz.AutoSize = true;
            this.lblDescrip_plz.Location = new System.Drawing.Point(12, 156);
            this.lblDescrip_plz.Name = "lblDescrip_plz";
            this.lblDescrip_plz.Size = new System.Drawing.Size(79, 17);
            this.lblDescrip_plz.TabIndex = 7;
            this.lblDescrip_plz.Text = "Descripcion";
            // 
            // dtpFechEmi
            // 
            this.dtpFechEmi.Location = new System.Drawing.Point(128, 111);
            this.dtpFechEmi.Name = "dtpFechEmi";
            this.dtpFechEmi.Size = new System.Drawing.Size(256, 22);
            this.dtpFechEmi.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 153);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(362, 125);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // wfPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 294);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtpFechEmi);
            this.Controls.Add(this.lblDescrip_plz);
            this.Controls.Add(this.lblFechemi_plz);
            this.Controls.Add(this.txtNom_plz);
            this.Controls.Add(this.lblNom_plz);
            this.Controls.Add(this.txtCodigo_plz);
            this.Controls.Add(this.lblCod_plz);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfPolizas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Polizas";
            this.Load += new System.EventHandler(this.wfPolizas_Load);
            this.EnabledChanged += new System.EventHandler(this.wfPolizas_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCod_plz;
        private System.Windows.Forms.TextBox txtCodigo_plz;
        private System.Windows.Forms.Label lblNom_plz;
        private System.Windows.Forms.TextBox txtNom_plz;
        private System.Windows.Forms.Label lblFechemi_plz;
        private System.Windows.Forms.Label lblDescrip_plz;
        private System.Windows.Forms.DateTimePicker dtpFechEmi;
        private System.Windows.Forms.TextBox txtDescripcion;

    }
}