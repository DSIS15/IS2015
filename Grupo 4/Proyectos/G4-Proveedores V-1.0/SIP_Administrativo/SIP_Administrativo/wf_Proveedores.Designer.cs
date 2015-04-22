namespace SIP_Administrativo
{
    partial class wf_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_Proveedores));
            this.navegador1 = new Navegador.Navegador();
            this.lblnit = new System.Windows.Forms.Label();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lbldire = new System.Windows.Forms.Label();
            this.txtnom_prov = new System.Windows.Forms.TextBox();
            this.txtnit_prov = new System.Windows.Forms.TextBox();
            this.txttel_prov = new System.Windows.Forms.TextBox();
            this.txtdir_prov = new System.Windows.Forms.TextBox();
            this.txtestado_prov = new System.Windows.Forms.TextBox();
            this.cboestado_prov = new System.Windows.Forms.ComboBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.gboPersonalesCte = new System.Windows.Forms.GroupBox();
            this.txtcod_prov = new System.Windows.Forms.TextBox();
            this.lblcodprov = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gboPersonalesCte.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(42, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_proveedor";
            this.navegador1.TabIndex = 62;
            // 
            // lblnit
            // 
            this.lblnit.AutoSize = true;
            this.lblnit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnit.Location = new System.Drawing.Point(25, 66);
            this.lblnit.Name = "lblnit";
            this.lblnit.Size = new System.Drawing.Size(23, 15);
            this.lblnit.TabIndex = 16;
            this.lblnit.Text = "NIT";
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
            this.lblnom1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom1.Location = new System.Drawing.Point(25, 39);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(51, 15);
            this.lblnom1.TabIndex = 17;
            this.lblnom1.Text = "Nombre";
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldire.Location = new System.Drawing.Point(25, 93);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(60, 15);
            this.lbldire.TabIndex = 21;
            this.lbldire.Text = "Dirección";
            // 
            // txtnom_prov
            // 
            this.txtnom_prov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom_prov.Location = new System.Drawing.Point(96, 36);
            this.txtnom_prov.Name = "txtnom_prov";
            this.txtnom_prov.Size = new System.Drawing.Size(409, 21);
            this.txtnom_prov.TabIndex = 22;
            this.txtnom_prov.Tag = "nom_prov";
            this.txtnom_prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_prov_KeyPress);
            // 
            // txtnit_prov
            // 
            this.txtnit_prov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit_prov.Location = new System.Drawing.Point(96, 63);
            this.txtnit_prov.Name = "txtnit_prov";
            this.txtnit_prov.Size = new System.Drawing.Size(160, 21);
            this.txtnit_prov.TabIndex = 27;
            this.txtnit_prov.Tag = "nit_prov";
            // 
            // txttel_prov
            // 
            this.txttel_prov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel_prov.Location = new System.Drawing.Point(412, 63);
            this.txttel_prov.Name = "txttel_prov";
            this.txttel_prov.Size = new System.Drawing.Size(160, 21);
            this.txttel_prov.TabIndex = 28;
            this.txttel_prov.Tag = "dire_prov";
            this.txttel_prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_prov_KeyPress);
            // 
            // txtdir_prov
            // 
            this.txtdir_prov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdir_prov.Location = new System.Drawing.Point(96, 93);
            this.txtdir_prov.Name = "txtdir_prov";
            this.txtdir_prov.Size = new System.Drawing.Size(476, 21);
            this.txtdir_prov.TabIndex = 29;
            this.txtdir_prov.Tag = "tel_prov";
            // 
            // txtestado_prov
            // 
            this.txtestado_prov.Location = new System.Drawing.Point(262, 124);
            this.txtestado_prov.Name = "txtestado_prov";
            this.txtestado_prov.Size = new System.Drawing.Size(20, 21);
            this.txtestado_prov.TabIndex = 30;
            this.txtestado_prov.Tag = "estado_prov";
            this.txtestado_prov.TextChanged += new System.EventHandler(this.txtestado_prov_TextChanged);
            // 
            // cboestado_prov
            // 
            this.cboestado_prov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado_prov.FormattingEnabled = true;
            this.cboestado_prov.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cboestado_prov.Location = new System.Drawing.Point(96, 122);
            this.cboestado_prov.Name = "cboestado_prov";
            this.cboestado_prov.Size = new System.Drawing.Size(160, 23);
            this.cboestado_prov.TabIndex = 31;
            this.cboestado_prov.SelectedIndexChanged += new System.EventHandler(this.cboestado_prov_SelectedIndexChanged);
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(328, 66);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(52, 15);
            this.lbltel.TabIndex = 32;
            this.lbltel.Text = "Telefono";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(25, 124);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(46, 15);
            this.lblestado.TabIndex = 33;
            this.lblestado.Text = "Estado";
            // 
            // gboPersonalesCte
            // 
            this.gboPersonalesCte.Controls.Add(this.button1);
            this.gboPersonalesCte.Controls.Add(this.lblestado);
            this.gboPersonalesCte.Controls.Add(this.lbltel);
            this.gboPersonalesCte.Controls.Add(this.cboestado_prov);
            this.gboPersonalesCte.Controls.Add(this.txtestado_prov);
            this.gboPersonalesCte.Controls.Add(this.txtdir_prov);
            this.gboPersonalesCte.Controls.Add(this.txttel_prov);
            this.gboPersonalesCte.Controls.Add(this.txtnit_prov);
            this.gboPersonalesCte.Controls.Add(this.txtnom_prov);
            this.gboPersonalesCte.Controls.Add(this.lbldire);
            this.gboPersonalesCte.Controls.Add(this.lblnom1);
            this.gboPersonalesCte.Controls.Add(this.lblnit);
            this.gboPersonalesCte.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPersonalesCte.Location = new System.Drawing.Point(42, 119);
            this.gboPersonalesCte.Name = "gboPersonalesCte";
            this.gboPersonalesCte.Size = new System.Drawing.Size(598, 161);
            this.gboPersonalesCte.TabIndex = 59;
            this.gboPersonalesCte.TabStop = false;
            this.gboPersonalesCte.Text = "Datos Personales";
            // 
            // txtcod_prov
            // 
            this.txtcod_prov.Location = new System.Drawing.Point(588, 94);
            this.txtcod_prov.Name = "txtcod_prov";
            this.txtcod_prov.Size = new System.Drawing.Size(49, 20);
            this.txtcod_prov.TabIndex = 60;
            this.txtcod_prov.Tag = "cod_prov";
            // 
            // lblcodprov
            // 
            this.lblcodprov.AutoSize = true;
            this.lblcodprov.Location = new System.Drawing.Point(490, 97);
            this.lblcodprov.Name = "lblcodprov";
            this.lblcodprov.Size = new System.Drawing.Size(92, 13);
            this.lblcodprov.TabIndex = 61;
            this.lblcodprov.Text = "Codigo Proveedor";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(511, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wf_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 328);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblcodprov);
            this.Controls.Add(this.txtcod_prov);
            this.Controls.Add(this.gboPersonalesCte);
            this.Name = "wf_Proveedores";
            this.Text = "SIP - Proveedores";
            this.Load += new System.EventHandler(this.wf_Proveedores_Load);
            this.gboPersonalesCte.ResumeLayout(false);
            this.gboPersonalesCte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblnit;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lbldire;
        private System.Windows.Forms.TextBox txtnom_prov;
        private System.Windows.Forms.TextBox txtnit_prov;
        private System.Windows.Forms.TextBox txttel_prov;
        private System.Windows.Forms.TextBox txtdir_prov;
        private System.Windows.Forms.TextBox txtestado_prov;
        private System.Windows.Forms.ComboBox cboestado_prov;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.GroupBox gboPersonalesCte;
        private System.Windows.Forms.TextBox txtcod_prov;
        private System.Windows.Forms.Label lblcodprov;
        private System.Windows.Forms.Button button1;
    }
}