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
            this.tbcdet_fact = new System.Windows.Forms.TabControl();
            this.tbpinventario = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbpfactura = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.txtid_detfact = new System.Windows.Forms.TextBox();
            this.txtid_inven = new System.Windows.Forms.TextBox();
            this.txtnumero_factura = new System.Windows.Forms.TextBox();
            this.lblid_detfact = new System.Windows.Forms.Label();
            this.lblnumero_factura = new System.Windows.Forms.Label();
            this.lblid_inven = new System.Windows.Forms.Label();
            this.tbcdet_fact.SuspendLayout();
            this.tbpinventario.SuspendLayout();
            this.tbpfactura.SuspendLayout();
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
            // tbcdet_fact
            // 
            this.tbcdet_fact.Controls.Add(this.tbpinventario);
            this.tbcdet_fact.Controls.Add(this.tbpfactura);
            this.tbcdet_fact.Location = new System.Drawing.Point(44, 213);
            this.tbcdet_fact.Name = "tbcdet_fact";
            this.tbcdet_fact.SelectedIndex = 0;
            this.tbcdet_fact.Size = new System.Drawing.Size(647, 267);
            this.tbcdet_fact.TabIndex = 1;
            // 
            // tbpinventario
            // 
            this.tbpinventario.Controls.Add(this.cuDataGridD1);
            this.tbpinventario.Location = new System.Drawing.Point(4, 22);
            this.tbpinventario.Name = "tbpinventario";
            this.tbpinventario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpinventario.Size = new System.Drawing.Size(639, 241);
            this.tbpinventario.TabIndex = 0;
            this.tbpinventario.Text = "Inventario";
            this.tbpinventario.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(6, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(627, 229);
            this.cuDataGridD1.STabla = "inventario";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
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
            // txtid_detfact
            // 
            this.txtid_detfact.Location = new System.Drawing.Point(145, 130);
            this.txtid_detfact.Name = "txtid_detfact";
            this.txtid_detfact.Size = new System.Drawing.Size(100, 20);
            this.txtid_detfact.TabIndex = 2;
            this.txtid_detfact.Tag = "id_detfact";
            // 
            // txtid_inven
            // 
            this.txtid_inven.Location = new System.Drawing.Point(542, 129);
            this.txtid_inven.Name = "txtid_inven";
            this.txtid_inven.Size = new System.Drawing.Size(100, 20);
            this.txtid_inven.TabIndex = 3;
            this.txtid_inven.Tag = "id_inven";
            // 
            // txtnumero_factura
            // 
            this.txtnumero_factura.Location = new System.Drawing.Point(352, 130);
            this.txtnumero_factura.Name = "txtnumero_factura";
            this.txtnumero_factura.Size = new System.Drawing.Size(100, 20);
            this.txtnumero_factura.TabIndex = 4;
            this.txtnumero_factura.Tag = "numero_factura";
            // 
            // lblid_detfact
            // 
            this.lblid_detfact.AutoSize = true;
            this.lblid_detfact.Location = new System.Drawing.Point(48, 136);
            this.lblid_detfact.Name = "lblid_detfact";
            this.lblid_detfact.Size = new System.Drawing.Size(91, 13);
            this.lblid_detfact.TabIndex = 5;
            this.lblid_detfact.Text = "ID detalle factura:";
            // 
            // lblnumero_factura
            // 
            this.lblnumero_factura.AutoSize = true;
            this.lblnumero_factura.Location = new System.Drawing.Point(258, 133);
            this.lblnumero_factura.Name = "lblnumero_factura";
            this.lblnumero_factura.Size = new System.Drawing.Size(83, 13);
            this.lblnumero_factura.TabIndex = 6;
            this.lblnumero_factura.Text = "Numero factura:";
            // 
            // lblid_inven
            // 
            this.lblid_inven.AutoSize = true;
            this.lblid_inven.Location = new System.Drawing.Point(467, 136);
            this.lblid_inven.Name = "lblid_inven";
            this.lblid_inven.Size = new System.Drawing.Size(70, 13);
            this.lblid_inven.TabIndex = 7;
            this.lblid_inven.Text = "ID inventario:";
            // 
            // wfDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 514);
            this.Controls.Add(this.lblid_inven);
            this.Controls.Add(this.lblnumero_factura);
            this.Controls.Add(this.lblid_detfact);
            this.Controls.Add(this.txtnumero_factura);
            this.Controls.Add(this.txtid_inven);
            this.Controls.Add(this.txtid_detfact);
            this.Controls.Add(this.tbcdet_fact);
            this.Controls.Add(this.navegador1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle factura";
            this.Load += new System.EventHandler(this.wfDetalleFactura_Load);
            this.tbcdet_fact.ResumeLayout(false);
            this.tbpinventario.ResumeLayout(false);
            this.tbpfactura.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TabControl tbcdet_fact;
        private System.Windows.Forms.TabPage tbpinventario;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tbpfactura;
        private System.Windows.Forms.TextBox txtid_detfact;
        private System.Windows.Forms.TextBox txtid_inven;
        private System.Windows.Forms.TextBox txtnumero_factura;
        private System.Windows.Forms.Label lblid_detfact;
        private System.Windows.Forms.Label lblnumero_factura;
        private System.Windows.Forms.Label lblid_inven;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
    }
}