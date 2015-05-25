namespace dll_inventario.Presentacion
{
    partial class wfInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfInventario));
            this.navegador1 = new Navegador.Navegador();
            this.lblidiventario = new System.Windows.Forms.Label();
            this.lbllaboratiro = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblforma = new System.Windows.Forms.Label();
            this.lbllote = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblpreciounitarioventa = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblfechavencimiento = new System.Windows.Forms.Label();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtIdInventario = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtForma = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 21);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "inventario";
            this.navegador1.TabIndex = 0;
            // 
            // lblidiventario
            // 
            this.lblidiventario.AutoSize = true;
            this.lblidiventario.Location = new System.Drawing.Point(68, 130);
            this.lblidiventario.Name = "lblidiventario";
            this.lblidiventario.Size = new System.Drawing.Size(65, 13);
            this.lblidiventario.TabIndex = 1;
            this.lblidiventario.Text = "Id inventario";
            // 
            // lbllaboratiro
            // 
            this.lbllaboratiro.AutoSize = true;
            this.lbllaboratiro.Location = new System.Drawing.Point(71, 172);
            this.lbllaboratiro.Name = "lbllaboratiro";
            this.lbllaboratiro.Size = new System.Drawing.Size(60, 13);
            this.lbllaboratiro.TabIndex = 2;
            this.lbllaboratiro.Text = "Laboratorio";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(86, 205);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            // 
            // lblforma
            // 
            this.lblforma.AutoSize = true;
            this.lblforma.Location = new System.Drawing.Point(370, 176);
            this.lblforma.Name = "lblforma";
            this.lblforma.Size = new System.Drawing.Size(36, 13);
            this.lblforma.TabIndex = 4;
            this.lblforma.Text = "Forma";
            // 
            // lbllote
            // 
            this.lbllote.AutoSize = true;
            this.lbllote.Location = new System.Drawing.Point(102, 244);
            this.lbllote.Name = "lbllote";
            this.lbllote.Size = new System.Drawing.Size(28, 13);
            this.lbllote.TabIndex = 5;
            this.lbllote.Text = "Lote";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(357, 212);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 6;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblpreciounitarioventa
            // 
            this.lblpreciounitarioventa.AutoSize = true;
            this.lblpreciounitarioventa.Location = new System.Drawing.Point(330, 244);
            this.lblpreciounitarioventa.Name = "lblpreciounitarioventa";
            this.lblpreciounitarioventa.Size = new System.Drawing.Size(76, 13);
            this.lblpreciounitarioventa.TabIndex = 7;
            this.lblpreciounitarioventa.Text = "Precio Unitario";
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Location = new System.Drawing.Point(71, 283);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(59, 13);
            this.lbldescuento.TabIndex = 8;
            this.lbldescuento.Text = "Descuento";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(371, 283);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 9;
            this.lbltotal.Text = "Total";
            // 
            // lblfechavencimiento
            // 
            this.lblfechavencimiento.AutoSize = true;
            this.lblfechavencimiento.Location = new System.Drawing.Point(308, 321);
            this.lblfechavencimiento.Name = "lblfechavencimiento";
            this.lblfechavencimiento.Size = new System.Drawing.Size(98, 13);
            this.lblfechavencimiento.TabIndex = 10;
            this.lblfechavencimiento.Text = "Fecha Vencimiento";
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Location = new System.Drawing.Point(72, 318);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(58, 13);
            this.lblexistencia.TabIndex = 11;
            this.lblexistencia.Text = "Existencia ";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(366, 137);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 12;
            this.lblestado.Text = "Estado";
            // 
            // txtIdInventario
            // 
            this.txtIdInventario.Location = new System.Drawing.Point(140, 130);
            this.txtIdInventario.Name = "txtIdInventario";
            this.txtIdInventario.Size = new System.Drawing.Size(100, 20);
            this.txtIdInventario.TabIndex = 13;
            this.txtIdInventario.Tag = "id_inven";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(140, 169);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 20);
            this.txtLaboratorio.TabIndex = 14;
            this.txtLaboratorio.Tag = "laboratorio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 205);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Tag = "nombre";
            // 
            // txtForma
            // 
            this.txtForma.Location = new System.Drawing.Point(416, 169);
            this.txtForma.Name = "txtForma";
            this.txtForma.Size = new System.Drawing.Size(100, 20);
            this.txtForma.TabIndex = 16;
            this.txtForma.Tag = "forma";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(140, 241);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 20);
            this.txtLote.TabIndex = 17;
            this.txtLote.Tag = "lote";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(416, 209);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.Tag = "cantidad";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(416, 241);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnitario.TabIndex = 19;
            this.txtPrecioUnitario.Tag = "pu_venta";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(140, 283);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 20;
            this.txtDescuento.Tag = "descuento";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(416, 280);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.Tag = "total";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(533, 324);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(23, 20);
            this.txtFechaVencimiento.TabIndex = 22;
            this.txtFechaVencimiento.Tag = "fech_vencimiento";
            this.txtFechaVencimiento.Visible = false;
            this.txtFechaVencimiento.TextChanged += new System.EventHandler(this.txtFechaVencimiento_TextChanged);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(140, 318);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtExistencia.TabIndex = 23;
            this.txtExistencia.Tag = "existencia";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(533, 130);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(23, 20);
            this.txtEstado.TabIndex = 24;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activado\t",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(413, 127);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(103, 21);
            this.cboEstado.TabIndex = 25;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(416, 321);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaVencimiento.TabIndex = 26;
            this.dtpFechaVencimiento.ValueChanged += new System.EventHandler(this.dtpFechaVencimiento_ValueChanged);
            // 
            // wfInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtIdInventario);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblexistencia);
            this.Controls.Add(this.lblfechavencimiento);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.lblpreciounitarioventa);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lbllote);
            this.Controls.Add(this.lblforma);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbllaboratiro);
            this.Controls.Add(this.lblidiventario);
            this.Controls.Add(this.navegador1);
            this.Name = "wfInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.wfInventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblidiventario;
        private System.Windows.Forms.Label lbllaboratiro;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblforma;
        private System.Windows.Forms.Label lbllote;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblpreciounitarioventa;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblfechavencimiento;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtIdInventario;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtForma;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
    }
}