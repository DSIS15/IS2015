namespace Compras_Ventas
{
    partial class wfProCte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfProCte));
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCodProv_Cte = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtNombreProvCte = new System.Windows.Forms.TextBox();
            this.txtNitProCte = new System.Windows.Forms.TextBox();
            this.txtDescripProCte = new System.Windows.Forms.TextBox();
            this.txtDirProvCte = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelProCte = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.cboEstadoProCte = new System.Windows.Forms.ComboBox();
            this.txtEstadoProCte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProCte = new System.Windows.Forms.ComboBox();
            this.lblCteProv = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 73);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(46, 15);
            this.lblCod.TabIndex = 1;
            this.lblCod.Text = "Código";
            // 
            // txtCodProv_Cte
            // 
            this.txtCodProv_Cte.Enabled = false;
            this.txtCodProv_Cte.Location = new System.Drawing.Point(129, 70);
            this.txtCodProv_Cte.Name = "txtCodProv_Cte";
            this.txtCodProv_Cte.Size = new System.Drawing.Size(150, 21);
            this.txtCodProv_Cte.TabIndex = 0;
            this.txtCodProv_Cte.Tag = "cod_prov_cte";
            this.txtCodProv_Cte.TextChanged += new System.EventHandler(this.txtCodProv_Cte_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(15, 129);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(22, 15);
            this.lblNit.TabIndex = 4;
            this.lblNit.Text = "Nit";
            // 
            // txtNombreProvCte
            // 
            this.txtNombreProvCte.Location = new System.Drawing.Point(129, 98);
            this.txtNombreProvCte.Name = "txtNombreProvCte";
            this.txtNombreProvCte.Size = new System.Drawing.Size(150, 21);
            this.txtNombreProvCte.TabIndex = 5;
            this.txtNombreProvCte.Tag = "nombre_prov_cte";
            // 
            // txtNitProCte
            // 
            this.txtNitProCte.Location = new System.Drawing.Point(129, 126);
            this.txtNitProCte.Name = "txtNitProCte";
            this.txtNitProCte.Size = new System.Drawing.Size(150, 21);
            this.txtNitProCte.TabIndex = 6;
            this.txtNitProCte.Tag = "nit_prov_cte";
            // 
            // txtDescripProCte
            // 
            this.txtDescripProCte.Location = new System.Drawing.Point(285, 154);
            this.txtDescripProCte.Name = "txtDescripProCte";
            this.txtDescripProCte.Size = new System.Drawing.Size(22, 21);
            this.txtDescripProCte.TabIndex = 7;
            this.txtDescripProCte.Tag = "descrip";
            this.txtDescripProCte.Visible = false;
            this.txtDescripProCte.TextChanged += new System.EventHandler(this.txtDescripProCte_TextChanged);
            // 
            // txtDirProvCte
            // 
            this.txtDirProvCte.Location = new System.Drawing.Point(459, 100);
            this.txtDirProvCte.Name = "txtDirProvCte";
            this.txtDirProvCte.Size = new System.Drawing.Size(150, 21);
            this.txtDirProvCte.TabIndex = 8;
            this.txtDirProvCte.Tag = "dire";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(342, 103);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtTelProCte
            // 
            this.txtTelProCte.Location = new System.Drawing.Point(459, 128);
            this.txtTelProCte.MaxLength = 8;
            this.txtTelProCte.Name = "txtTelProCte";
            this.txtTelProCte.Size = new System.Drawing.Size(150, 21);
            this.txtTelProCte.TabIndex = 10;
            this.txtTelProCte.Tag = "tel_prov_cte";
            this.txtTelProCte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelProCte_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(342, 131);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(351, 159);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 15);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Estado";
            // 
            // cboEstadoProCte
            // 
            this.cboEstadoProCte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoProCte.FormattingEnabled = true;
            this.cboEstadoProCte.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.cboEstadoProCte.Location = new System.Drawing.Point(459, 156);
            this.cboEstadoProCte.Name = "cboEstadoProCte";
            this.cboEstadoProCte.Size = new System.Drawing.Size(150, 23);
            this.cboEstadoProCte.TabIndex = 13;
            this.cboEstadoProCte.SelectedIndexChanged += new System.EventHandler(this.cboEstadoProCte_SelectedIndexChanged);
            // 
            // txtEstadoProCte
            // 
            this.txtEstadoProCte.Location = new System.Drawing.Point(323, 156);
            this.txtEstadoProCte.Name = "txtEstadoProCte";
            this.txtEstadoProCte.Size = new System.Drawing.Size(22, 21);
            this.txtEstadoProCte.TabIndex = 14;
            this.txtEstadoProCte.Tag = "estado_prov_cte";
            this.txtEstadoProCte.Visible = false;
            this.txtEstadoProCte.TextChanged += new System.EventHandler(this.txtEstadoProCte_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 15;
            // 
            // cboProCte
            // 
            this.cboProCte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProCte.FormattingEnabled = true;
            this.cboProCte.Items.AddRange(new object[] {
            "Proveedor",
            "Cliente"});
            this.cboProCte.Location = new System.Drawing.Point(129, 154);
            this.cboProCte.Name = "cboProCte";
            this.cboProCte.Size = new System.Drawing.Size(150, 23);
            this.cboProCte.TabIndex = 16;
            this.cboProCte.SelectedIndexChanged += new System.EventHandler(this.cboProCte_SelectedIndexChanged);
            // 
            // lblCteProv
            // 
            this.lblCteProv.AutoSize = true;
            this.lblCteProv.Location = new System.Drawing.Point(12, 157);
            this.lblCteProv.Name = "lblCteProv";
            this.lblCteProv.Size = new System.Drawing.Size(97, 15);
            this.lblCteProv.TabIndex = 17;
            this.lblCteProv.Text = "Cliente/Provedor";
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
            this.navegador1.sNombreTabla = "tabm_prov_cte";
            this.navegador1.TabIndex = 18;
            // 
            // wfProCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 191);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblCteProv);
            this.Controls.Add(this.cboProCte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEstadoProCte);
            this.Controls.Add(this.cboEstadoProCte);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelProCte);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDirProvCte);
            this.Controls.Add(this.txtDescripProCte);
            this.Controls.Add(this.txtNitProCte);
            this.Controls.Add(this.txtNombreProvCte);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodProv_Cte);
            this.Controls.Add(this.lblCod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfProCte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Clientes y Proveedores";
            this.Load += new System.EventHandler(this.wfProCte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCodProv_Cte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox txtNombreProvCte;
        private System.Windows.Forms.TextBox txtNitProCte;
        private System.Windows.Forms.TextBox txtDescripProCte;
        private System.Windows.Forms.TextBox txtDirProvCte;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelProCte;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cboEstadoProCte;
        private System.Windows.Forms.TextBox txtEstadoProCte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboProCte;
        private System.Windows.Forms.Label lblCteProv;
        private Navegador.Navegador navegador1;
    }
}