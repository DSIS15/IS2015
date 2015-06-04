namespace Pedidos
{
    partial class wfpedido_prov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfpedido_prov));
            this.dgvDetallePedProv = new System.Windows.Forms.DataGridView();
            this.gbdetallepedido = new System.Windows.Forms.GroupBox();
            this.txtUMedida = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboUMedida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCod_ped = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.dtpFechaPed = new System.Windows.Forms.DateTimePicker();
            this.txtFechaPed = new System.Windows.Forms.TextBox();
            this.txtCodAux = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedProv)).BeginInit();
            this.gbdetallepedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetallePedProv
            // 
            this.dgvDetallePedProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedProv.Location = new System.Drawing.Point(22, 142);
            this.dgvDetallePedProv.Name = "dgvDetallePedProv";
            this.dgvDetallePedProv.Size = new System.Drawing.Size(445, 162);
            this.dgvDetallePedProv.TabIndex = 0;
            // 
            // gbdetallepedido
            // 
            this.gbdetallepedido.Controls.Add(this.txtUMedida);
            this.gbdetallepedido.Controls.Add(this.txtProducto);
            this.gbdetallepedido.Controls.Add(this.btnAgregar);
            this.gbdetallepedido.Controls.Add(this.cboUMedida);
            this.gbdetallepedido.Controls.Add(this.label3);
            this.gbdetallepedido.Controls.Add(this.label2);
            this.gbdetallepedido.Controls.Add(this.cboProducto);
            this.gbdetallepedido.Controls.Add(this.label1);
            this.gbdetallepedido.Controls.Add(this.txtCantidad);
            this.gbdetallepedido.Controls.Add(this.dgvDetallePedProv);
            this.gbdetallepedido.Location = new System.Drawing.Point(75, 167);
            this.gbdetallepedido.Name = "gbdetallepedido";
            this.gbdetallepedido.Size = new System.Drawing.Size(492, 325);
            this.gbdetallepedido.TabIndex = 1;
            this.gbdetallepedido.TabStop = false;
            this.gbdetallepedido.Text = "Detalle Pedido";
            // 
            // txtUMedida
            // 
            this.txtUMedida.Location = new System.Drawing.Point(385, 74);
            this.txtUMedida.Name = "txtUMedida";
            this.txtUMedida.Size = new System.Drawing.Size(22, 20);
            this.txtUMedida.TabIndex = 11;
            this.txtUMedida.Visible = false;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(298, 29);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(30, 20);
            this.txtProducto.TabIndex = 10;
            this.txtProducto.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(423, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 44);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboUMedida
            // 
            this.cboUMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUMedida.FormattingEnabled = true;
            this.cboUMedida.Location = new System.Drawing.Point(247, 73);
            this.cboUMedida.Name = "cboUMedida";
            this.cboUMedida.Size = new System.Drawing.Size(132, 21);
            this.cboUMedida.TabIndex = 5;
            this.cboUMedida.SelectedIndexChanged += new System.EventHandler(this.cboUMedida_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unid. Medida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(75, 28);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(217, 21);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(75, 73);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Código de Pedido";
            // 
            // txtCod_ped
            // 
            this.txtCod_ped.Enabled = false;
            this.txtCod_ped.Location = new System.Drawing.Point(174, 78);
            this.txtCod_ped.Name = "txtCod_ped";
            this.txtCod_ped.Size = new System.Drawing.Size(91, 20);
            this.txtCod_ped.TabIndex = 5;
            this.txtCod_ped.Tag = "cod_ped";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Código de Proveedor";
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(174, 104);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(91, 20);
            this.txtProv.TabIndex = 2;
            this.txtProv.Enter += new System.EventHandler(this.txtProv_Enter);
            this.txtProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProv_KeyPress);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(23, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_pedido";
            this.navegador1.TabIndex = 14;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick_1);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // dtpFechaPed
            // 
            this.dtpFechaPed.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaPed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPed.Location = new System.Drawing.Point(399, 79);
            this.dtpFechaPed.Name = "dtpFechaPed";
            this.dtpFechaPed.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaPed.TabIndex = 1;
            this.dtpFechaPed.Tag = "";
            this.dtpFechaPed.ValueChanged += new System.EventHandler(this.dtpFechaPed_ValueChanged);
            // 
            // txtFechaPed
            // 
            this.txtFechaPed.Location = new System.Drawing.Point(514, 79);
            this.txtFechaPed.Name = "txtFechaPed";
            this.txtFechaPed.Size = new System.Drawing.Size(55, 20);
            this.txtFechaPed.TabIndex = 16;
            this.txtFechaPed.Tag = "fecha_ped";
            this.txtFechaPed.Visible = false;
            this.txtFechaPed.TextChanged += new System.EventHandler(this.txtFechaPed_TextChanged);
            // 
            // txtCodAux
            // 
            this.txtCodAux.Location = new System.Drawing.Point(271, 78);
            this.txtCodAux.Name = "txtCodAux";
            this.txtCodAux.Size = new System.Drawing.Size(33, 20);
            this.txtCodAux.TabIndex = 17;
            this.txtCodAux.Visible = false;
            // 
            // wfpedido_prov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 509);
            this.Controls.Add(this.txtCodAux);
            this.Controls.Add(this.txtFechaPed);
            this.Controls.Add(this.dtpFechaPed);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCod_ped);
            this.Controls.Add(this.gbdetallepedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wfpedido_prov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido a Proveedores";
            this.Load += new System.EventHandler(this.pedido_prov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedProv)).EndInit();
            this.gbdetallepedido.ResumeLayout(false);
            this.gbdetallepedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetallePedProv;
        private System.Windows.Forms.GroupBox gbdetallepedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboUMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCod_ped;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtUMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProv;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.DateTimePicker dtpFechaPed;
        private System.Windows.Forms.TextBox txtFechaPed;
        private System.Windows.Forms.TextBox txtCodAux;
    }
}