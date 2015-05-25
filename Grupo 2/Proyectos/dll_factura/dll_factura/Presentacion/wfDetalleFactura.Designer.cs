namespace dll_factura.Presentacion
{
    partial class wfDetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetalleFactura));
            this.navegador1 = new Navegador.Navegador();
            this.txtid_detfact = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnumero_factura = new System.Windows.Forms.TextBox();
            this.lblid_detfact = new System.Windows.Forms.Label();
            this.lblnumero_factura = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.tbpfactura = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbcdet_fact = new System.Windows.Forms.TabControl();
            this.tbpfactura.SuspendLayout();
            this.tbcdet_fact.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(44, 45);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "det_fact";
            this.navegador1.TabIndex = 0;
            // 
            // txtid_detfact
            // 
            this.txtid_detfact.Location = new System.Drawing.Point(141, 130);
            this.txtid_detfact.Name = "txtid_detfact";
            this.txtid_detfact.Size = new System.Drawing.Size(100, 20);
            this.txtid_detfact.TabIndex = 2;
            this.txtid_detfact.Tag = "id_detfact";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(141, 178);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(341, 51);
            this.txtdescripcion.TabIndex = 3;
            this.txtdescripcion.Tag = "descripcion";
            // 
            // txtnumero_factura
            // 
            this.txtnumero_factura.Location = new System.Drawing.Point(382, 129);
            this.txtnumero_factura.Name = "txtnumero_factura";
            this.txtnumero_factura.Size = new System.Drawing.Size(100, 20);
            this.txtnumero_factura.TabIndex = 4;
            this.txtnumero_factura.Tag = "numero_factura";
            this.txtnumero_factura.TextChanged += new System.EventHandler(this.txtnumero_factura_TextChanged);
            // 
            // lblid_detfact
            // 
            this.lblid_detfact.AutoSize = true;
            this.lblid_detfact.Location = new System.Drawing.Point(44, 136);
            this.lblid_detfact.Name = "lblid_detfact";
            this.lblid_detfact.Size = new System.Drawing.Size(91, 13);
            this.lblid_detfact.TabIndex = 5;
            this.lblid_detfact.Text = "ID detalle factura:";
            // 
            // lblnumero_factura
            // 
            this.lblnumero_factura.AutoSize = true;
            this.lblnumero_factura.Location = new System.Drawing.Point(288, 132);
            this.lblnumero_factura.Name = "lblnumero_factura";
            this.lblnumero_factura.Size = new System.Drawing.Size(83, 13);
            this.lblnumero_factura.TabIndex = 6;
            this.lblnumero_factura.Text = "Numero factura:";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(47, 178);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbldescripcion.TabIndex = 7;
            this.lbldescripcion.Text = "Descripción:";
            // 
            // tbpfactura
            // 
            this.tbpfactura.Controls.Add(this.cuDataGridD2);
            this.tbpfactura.Location = new System.Drawing.Point(4, 22);
            this.tbpfactura.Name = "tbpfactura";
            this.tbpfactura.Padding = new System.Windows.Forms.Padding(3);
            this.tbpfactura.Size = new System.Drawing.Size(639, 241);
            this.tbpfactura.TabIndex = 1;
            this.tbpfactura.Text = "Factura";
            this.tbpfactura.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(3, 7);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(630, 228);
            this.cuDataGridD2.STabla = "factura";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // tbcdet_fact
            // 
            this.tbcdet_fact.Controls.Add(this.tbpfactura);
            this.tbcdet_fact.Location = new System.Drawing.Point(44, 235);
            this.tbcdet_fact.Name = "tbcdet_fact";
            this.tbcdet_fact.SelectedIndex = 0;
            this.tbcdet_fact.Size = new System.Drawing.Size(647, 267);
            this.tbcdet_fact.TabIndex = 1;
            // 
            // wfDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 514);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblnumero_factura);
            this.Controls.Add(this.lblid_detfact);
            this.Controls.Add(this.txtnumero_factura);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtid_detfact);
            this.Controls.Add(this.tbcdet_fact);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle factura";
            this.Load += new System.EventHandler(this.wfDetalleFactura_Load);
            this.tbpfactura.ResumeLayout(false);
            this.tbcdet_fact.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtid_detfact;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnumero_factura;
        private System.Windows.Forms.Label lblid_detfact;
        private System.Windows.Forms.Label lblnumero_factura;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TabPage tbpfactura;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private System.Windows.Forms.TabControl tbcdet_fact;
    }
}