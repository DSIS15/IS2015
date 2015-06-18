namespace Produccion
{
    partial class wfProduccion
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
            this.dgvFormula = new System.Windows.Forms.DataGridView();
            this.dgvDetalleF = new System.Windows.Forms.DataGridView();
            this.txtNombreFormula = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.grpProduccion = new System.Windows.Forms.GroupBox();
            this.cboProduccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstadoP = new System.Windows.Forms.TextBox();
            this.txtCantP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.txtCodF = new System.Windows.Forms.TextBox();
            this.lblCantP = new System.Windows.Forms.Label();
            this.lblCodP = new System.Windows.Forms.Label();
            this.lblCodF = new System.Windows.Forms.Label();
            this.grpCostos = new System.Windows.Forms.GroupBox();
            this.txtGF = new System.Windows.Forms.TextBox();
            this.txtMOD = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtMOI = new System.Windows.Forms.TextBox();
            this.lblMobraI = new System.Windows.Forms.Label();
            this.lblMobraD = new System.Windows.Forms.Label();
            this.lblGastosD = new System.Windows.Forms.Label();
            this.lblGastoI = new System.Windows.Forms.Label();
            this.grpCostosT = new System.Windows.Forms.GroupBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.txtPrecioVta = new System.Windows.Forms.TextBox();
            this.txtCostoIndFabricacion = new System.Windows.Forms.TextBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblcostoIF = new System.Windows.Forms.Label();
            this.txtCostoP = new System.Windows.Forms.TextBox();
            this.txtCostoDirFab = new System.Windows.Forms.TextBox();
            this.lblPrecioVta = new System.Windows.Forms.Label();
            this.lblCostoP = new System.Windows.Forms.Label();
            this.lblCostoDirFab = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnProduccion = new System.Windows.Forms.Button();
            this.txtNombreMp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleF)).BeginInit();
            this.grpProduccion.SuspendLayout();
            this.grpCostos.SuspendLayout();
            this.grpCostosT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFormula
            // 
            this.dgvFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormula.Location = new System.Drawing.Point(27, 190);
            this.dgvFormula.Name = "dgvFormula";
            this.dgvFormula.Size = new System.Drawing.Size(562, 150);
            this.dgvFormula.TabIndex = 0;
            this.dgvFormula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormula_CellClick);
            this.dgvFormula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvDetalleF
            // 
            this.dgvDetalleF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleF.Location = new System.Drawing.Point(622, 190);
            this.dgvDetalleF.Name = "dgvDetalleF";
            this.dgvDetalleF.Size = new System.Drawing.Size(545, 150);
            this.dgvDetalleF.TabIndex = 1;
            // 
            // txtNombreFormula
            // 
            this.txtNombreFormula.Enabled = false;
            this.txtNombreFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFormula.Location = new System.Drawing.Point(396, 60);
            this.txtNombreFormula.Name = "txtNombreFormula";
            this.txtNombreFormula.Size = new System.Drawing.Size(168, 22);
            this.txtNombreFormula.TabIndex = 20;
            this.txtNombreFormula.TextChanged += new System.EventHandler(this.txtNombreFormula_TextChanged);
            this.txtNombreFormula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreFormula_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(292, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Ver Existencias";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Enabled = false;
            this.btnMover.Location = new System.Drawing.Point(1059, 446);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(131, 48);
            this.btnMover.TabIndex = 23;
            this.btnMover.Text = "Producción";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // grpProduccion
            // 
            this.grpProduccion.Controls.Add(this.cboProduccion);
            this.grpProduccion.Controls.Add(this.label2);
            this.grpProduccion.Controls.Add(this.txtEstadoP);
            this.grpProduccion.Controls.Add(this.txtCantP);
            this.grpProduccion.Controls.Add(this.label1);
            this.grpProduccion.Controls.Add(this.btnAgregar);
            this.grpProduccion.Controls.Add(this.txtCodP);
            this.grpProduccion.Controls.Add(this.txtCodF);
            this.grpProduccion.Controls.Add(this.lblCantP);
            this.grpProduccion.Controls.Add(this.txtNombreFormula);
            this.grpProduccion.Controls.Add(this.lblCodP);
            this.grpProduccion.Controls.Add(this.lblCodF);
            this.grpProduccion.Location = new System.Drawing.Point(9, 55);
            this.grpProduccion.Name = "grpProduccion";
            this.grpProduccion.Size = new System.Drawing.Size(605, 129);
            this.grpProduccion.TabIndex = 31;
            this.grpProduccion.TabStop = false;
            this.grpProduccion.Text = "Datos Producción";
            // 
            // cboProduccion
            // 
            this.cboProduccion.Enabled = false;
            this.cboProduccion.FormattingEnabled = true;
            this.cboProduccion.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.cboProduccion.Location = new System.Drawing.Point(396, 99);
            this.cboProduccion.Name = "cboProduccion";
            this.cboProduccion.Size = new System.Drawing.Size(168, 21);
            this.cboProduccion.TabIndex = 36;
            this.cboProduccion.SelectedIndexChanged += new System.EventHandler(this.cboProduccion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre Formula";
            // 
            // txtEstadoP
            // 
            this.txtEstadoP.Location = new System.Drawing.Point(571, 99);
            this.txtEstadoP.Name = "txtEstadoP";
            this.txtEstadoP.Size = new System.Drawing.Size(21, 20);
            this.txtEstadoP.TabIndex = 34;
            this.txtEstadoP.Tag = "estado_prod";
            this.txtEstadoP.Visible = false;
            this.txtEstadoP.TextChanged += new System.EventHandler(this.txtEstadoP_TextChanged);
            // 
            // txtCantP
            // 
            this.txtCantP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantP.Location = new System.Drawing.Point(111, 26);
            this.txtCantP.Name = "txtCantP";
            this.txtCantP.Size = new System.Drawing.Size(168, 22);
            this.txtCantP.TabIndex = 19;
            this.txtCantP.Tag = "cantidad_prod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Estado";
            // 
            // txtCodP
            // 
            this.txtCodP.Enabled = false;
            this.txtCodP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodP.Location = new System.Drawing.Point(111, 60);
            this.txtCodP.Name = "txtCodP";
            this.txtCodP.Size = new System.Drawing.Size(168, 22);
            this.txtCodP.TabIndex = 18;
            this.txtCodP.Tag = "cod_prod";
            // 
            // txtCodF
            // 
            this.txtCodF.Enabled = false;
            this.txtCodF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodF.Location = new System.Drawing.Point(111, 103);
            this.txtCodF.Name = "txtCodF";
            this.txtCodF.Size = new System.Drawing.Size(168, 22);
            this.txtCodF.TabIndex = 20;
            this.txtCodF.Tag = "cod_formu";
            // 
            // lblCantP
            // 
            this.lblCantP.AutoSize = true;
            this.lblCantP.Location = new System.Drawing.Point(15, 29);
            this.lblCantP.Name = "lblCantP";
            this.lblCantP.Size = new System.Drawing.Size(95, 13);
            this.lblCantP.TabIndex = 17;
            this.lblCantP.Text = "Cantidad Producto";
            // 
            // lblCodP
            // 
            this.lblCodP.AutoSize = true;
            this.lblCodP.Location = new System.Drawing.Point(15, 67);
            this.lblCodP.Name = "lblCodP";
            this.lblCodP.Size = new System.Drawing.Size(97, 13);
            this.lblCodP.TabIndex = 15;
            this.lblCodP.Text = "Codigo Producción";
            // 
            // lblCodF
            // 
            this.lblCodF.AutoSize = true;
            this.lblCodF.Location = new System.Drawing.Point(15, 102);
            this.lblCodF.Name = "lblCodF";
            this.lblCodF.Size = new System.Drawing.Size(80, 13);
            this.lblCodF.TabIndex = 16;
            this.lblCodF.Text = "Codigo Formula";
            // 
            // grpCostos
            // 
            this.grpCostos.Controls.Add(this.txtGF);
            this.grpCostos.Controls.Add(this.txtMOD);
            this.grpCostos.Controls.Add(this.txtMP);
            this.grpCostos.Controls.Add(this.txtMOI);
            this.grpCostos.Controls.Add(this.lblMobraI);
            this.grpCostos.Controls.Add(this.lblMobraD);
            this.grpCostos.Controls.Add(this.lblGastosD);
            this.grpCostos.Controls.Add(this.lblGastoI);
            this.grpCostos.Location = new System.Drawing.Point(620, 65);
            this.grpCostos.Name = "grpCostos";
            this.grpCostos.Size = new System.Drawing.Size(547, 119);
            this.grpCostos.TabIndex = 32;
            this.grpCostos.TabStop = false;
            this.grpCostos.Text = "Datos Costo de Fabricación";
            // 
            // txtGF
            // 
            this.txtGF.Enabled = false;
            this.txtGF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGF.Location = new System.Drawing.Point(129, 55);
            this.txtGF.Name = "txtGF";
            this.txtGF.Size = new System.Drawing.Size(131, 22);
            this.txtGF.TabIndex = 26;
            // 
            // txtMOD
            // 
            this.txtMOD.Enabled = false;
            this.txtMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOD.Location = new System.Drawing.Point(385, 15);
            this.txtMOD.Name = "txtMOD";
            this.txtMOD.Size = new System.Drawing.Size(134, 22);
            this.txtMOD.TabIndex = 25;
            // 
            // txtMP
            // 
            this.txtMP.Enabled = false;
            this.txtMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP.Location = new System.Drawing.Point(129, 19);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(131, 22);
            this.txtMP.TabIndex = 24;
            // 
            // txtMOI
            // 
            this.txtMOI.Enabled = false;
            this.txtMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOI.Location = new System.Drawing.Point(385, 52);
            this.txtMOI.Name = "txtMOI";
            this.txtMOI.Size = new System.Drawing.Size(134, 22);
            this.txtMOI.TabIndex = 23;
            // 
            // lblMobraI
            // 
            this.lblMobraI.AutoSize = true;
            this.lblMobraI.Location = new System.Drawing.Point(282, 62);
            this.lblMobraI.Name = "lblMobraI";
            this.lblMobraI.Size = new System.Drawing.Size(104, 13);
            this.lblMobraI.TabIndex = 22;
            this.lblMobraI.Text = "Mano Obra Indirecta";
            // 
            // lblMobraD
            // 
            this.lblMobraD.AutoSize = true;
            this.lblMobraD.Location = new System.Drawing.Point(282, 22);
            this.lblMobraD.Name = "lblMobraD";
            this.lblMobraD.Size = new System.Drawing.Size(97, 13);
            this.lblMobraD.TabIndex = 21;
            this.lblMobraD.Text = "Mano Obra Directa";
            // 
            // lblGastosD
            // 
            this.lblGastosD.AutoSize = true;
            this.lblGastosD.Location = new System.Drawing.Point(12, 26);
            this.lblGastosD.Name = "lblGastosD";
            this.lblGastosD.Size = new System.Drawing.Size(71, 13);
            this.lblGastosD.TabIndex = 20;
            this.lblGastosD.Text = "Materia Prima";
            // 
            // lblGastoI
            // 
            this.lblGastoI.AutoSize = true;
            this.lblGastoI.Location = new System.Drawing.Point(12, 62);
            this.lblGastoI.Name = "lblGastoI";
            this.lblGastoI.Size = new System.Drawing.Size(111, 13);
            this.lblGastoI.TabIndex = 19;
            this.lblGastoI.Text = "Gastos Administracion";
            // 
            // grpCostosT
            // 
            this.grpCostosT.Controls.Add(this.txtCostoTotal);
            this.grpCostosT.Controls.Add(this.txtPrecioVta);
            this.grpCostosT.Controls.Add(this.txtCostoIndFabricacion);
            this.grpCostosT.Controls.Add(this.lblCostoTotal);
            this.grpCostosT.Controls.Add(this.lblcostoIF);
            this.grpCostosT.Controls.Add(this.txtCostoP);
            this.grpCostosT.Controls.Add(this.txtCostoDirFab);
            this.grpCostosT.Controls.Add(this.lblPrecioVta);
            this.grpCostosT.Controls.Add(this.lblCostoP);
            this.grpCostosT.Controls.Add(this.lblCostoDirFab);
            this.grpCostosT.Location = new System.Drawing.Point(176, 399);
            this.grpCostosT.Name = "grpCostosT";
            this.grpCostosT.Size = new System.Drawing.Size(877, 95);
            this.grpCostosT.TabIndex = 27;
            this.grpCostosT.TabStop = false;
            this.grpCostosT.Text = "Datos Costos Totales";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Enabled = false;
            this.txtCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.Location = new System.Drawing.Point(545, 57);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(134, 22);
            this.txtCostoTotal.TabIndex = 40;
            this.txtCostoTotal.Tag = "costo_total";
            // 
            // txtPrecioVta
            // 
            this.txtPrecioVta.Enabled = false;
            this.txtPrecioVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVta.Location = new System.Drawing.Point(699, 57);
            this.txtPrecioVta.Name = "txtPrecioVta";
            this.txtPrecioVta.Size = new System.Drawing.Size(142, 22);
            this.txtPrecioVta.TabIndex = 39;
            this.txtPrecioVta.Tag = "precio_vta";
            // 
            // txtCostoIndFabricacion
            // 
            this.txtCostoIndFabricacion.Enabled = false;
            this.txtCostoIndFabricacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoIndFabricacion.Location = new System.Drawing.Point(212, 57);
            this.txtCostoIndFabricacion.Name = "txtCostoIndFabricacion";
            this.txtCostoIndFabricacion.Size = new System.Drawing.Size(131, 22);
            this.txtCostoIndFabricacion.TabIndex = 38;
            this.txtCostoIndFabricacion.Tag = "costo_ind";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(575, 32);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(61, 13);
            this.lblCostoTotal.TabIndex = 37;
            this.lblCostoTotal.Text = "Costo Total";
            // 
            // lblcostoIF
            // 
            this.lblcostoIF.AutoSize = true;
            this.lblcostoIF.Location = new System.Drawing.Point(209, 32);
            this.lblcostoIF.Name = "lblcostoIF";
            this.lblcostoIF.Size = new System.Drawing.Size(151, 13);
            this.lblcostoIF.TabIndex = 36;
            this.lblcostoIF.Text = "Costo Indirecto de Fabricacion";
            // 
            // txtCostoP
            // 
            this.txtCostoP.Enabled = false;
            this.txtCostoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoP.Location = new System.Drawing.Point(394, 57);
            this.txtCostoP.Name = "txtCostoP";
            this.txtCostoP.Size = new System.Drawing.Size(131, 22);
            this.txtCostoP.TabIndex = 35;
            this.txtCostoP.Tag = "costo_prod";
            // 
            // txtCostoDirFab
            // 
            this.txtCostoDirFab.Enabled = false;
            this.txtCostoDirFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoDirFab.Location = new System.Drawing.Point(43, 57);
            this.txtCostoDirFab.Name = "txtCostoDirFab";
            this.txtCostoDirFab.Size = new System.Drawing.Size(131, 22);
            this.txtCostoDirFab.TabIndex = 34;
            this.txtCostoDirFab.Tag = "costo_dir";
            // 
            // lblPrecioVta
            // 
            this.lblPrecioVta.AutoSize = true;
            this.lblPrecioVta.Location = new System.Drawing.Point(721, 32);
            this.lblPrecioVta.Name = "lblPrecioVta";
            this.lblPrecioVta.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioVta.TabIndex = 33;
            this.lblPrecioVta.Text = "Precio Venta";
            // 
            // lblCostoP
            // 
            this.lblCostoP.AutoSize = true;
            this.lblCostoP.Location = new System.Drawing.Point(401, 32);
            this.lblCostoP.Name = "lblCostoP";
            this.lblCostoP.Size = new System.Drawing.Size(106, 13);
            this.lblCostoP.TabIndex = 32;
            this.lblCostoP.Text = "Costo de Produccion";
            // 
            // lblCostoDirFab
            // 
            this.lblCostoDirFab.AutoSize = true;
            this.lblCostoDirFab.Location = new System.Drawing.Point(40, 32);
            this.lblCostoDirFab.Name = "lblCostoDirFab";
            this.lblCostoDirFab.Size = new System.Drawing.Size(150, 13);
            this.lblCostoDirFab.TabIndex = 31;
            this.lblCostoDirFab.Text = "Costo Directo de Faabricacion";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(1173, 80);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(67, 89);
            this.btnGenerar.TabIndex = 24;
            this.btnGenerar.Text = "Calcular";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.Enabled = false;
            this.btnProduccion.Location = new System.Drawing.Point(1059, 403);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(131, 47);
            this.btnProduccion.TabIndex = 25;
            this.btnProduccion.Text = "Generar";
            this.btnProduccion.UseVisualStyleBackColor = true;
            this.btnProduccion.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNombreMp
            // 
            this.txtNombreMp.Location = new System.Drawing.Point(635, 346);
            this.txtNombreMp.Name = "txtNombreMp";
            this.txtNombreMp.Size = new System.Drawing.Size(177, 20);
            this.txtNombreMp.TabIndex = 33;
            this.txtNombreMp.Visible = false;
            this.txtNombreMp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreMp_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Generar Producción";
            // 
            // wfProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreMp);
            this.Controls.Add(this.grpCostosT);
            this.Controls.Add(this.grpCostos);
            this.Controls.Add(this.grpProduccion);
            this.Controls.Add(this.btnProduccion);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.dgvDetalleF);
            this.Controls.Add(this.dgvFormula);
            this.Name = "wfProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producción";
            this.Load += new System.EventHandler(this.wfProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleF)).EndInit();
            this.grpProduccion.ResumeLayout(false);
            this.grpProduccion.PerformLayout();
            this.grpCostos.ResumeLayout(false);
            this.grpCostos.PerformLayout();
            this.grpCostosT.ResumeLayout(false);
            this.grpCostosT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormula;
        private System.Windows.Forms.DataGridView dgvDetalleF;
        private System.Windows.Forms.TextBox txtNombreFormula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.GroupBox grpProduccion;
        private System.Windows.Forms.TextBox txtCodP;
        private System.Windows.Forms.TextBox txtCodF;
        private System.Windows.Forms.TextBox txtCantP;
        private System.Windows.Forms.Label lblCantP;
        private System.Windows.Forms.Label lblCodF;
        private System.Windows.Forms.Label lblCodP;
        private System.Windows.Forms.GroupBox grpCostos;
        private System.Windows.Forms.TextBox txtGF;
        private System.Windows.Forms.TextBox txtMOD;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtMOI;
        private System.Windows.Forms.Label lblMobraI;
        private System.Windows.Forms.Label lblMobraD;
        private System.Windows.Forms.Label lblGastosD;
        private System.Windows.Forms.Label lblGastoI;
        private System.Windows.Forms.GroupBox grpCostosT;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.TextBox txtPrecioVta;
        private System.Windows.Forms.TextBox txtCostoIndFabricacion;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblcostoIF;
        private System.Windows.Forms.TextBox txtCostoP;
        private System.Windows.Forms.TextBox txtCostoDirFab;
        private System.Windows.Forms.Label lblPrecioVta;
        private System.Windows.Forms.Label lblCostoP;
        private System.Windows.Forms.Label lblCostoDirFab;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnProduccion;
        private System.Windows.Forms.TextBox txtEstadoP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProduccion;
        private System.Windows.Forms.TextBox txtNombreMp;
        private System.Windows.Forms.Label label3;
    }
}