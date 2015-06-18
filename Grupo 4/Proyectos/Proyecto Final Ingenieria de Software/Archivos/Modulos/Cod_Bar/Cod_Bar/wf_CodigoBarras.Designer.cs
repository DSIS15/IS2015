namespace Cod_Bar
{
    partial class wf_CodigoBarras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_CodigoBarras));
            this.grBox_InsertCode = new System.Windows.Forms.GroupBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngresoCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngLote = new System.Windows.Forms.TextBox();
            this.grBox_EscogeOpcion = new System.Windows.Forms.GroupBox();
            this.rbtn8 = new System.Windows.Forms.RadioButton();
            this.rbtn13 = new System.Windows.Forms.RadioButton();
            this.txtCodigoBar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.navegador1 = new Navegador.Navegador();
            this.TtInfo = new System.Windows.Forms.ToolTip(this.components);
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCEmpsa = new System.Windows.Forms.TextBox();
            this.txtNEmpsa = new System.Windows.Forms.TextBox();
            this.lblNEmpresa = new System.Windows.Forms.Label();
            this.lblCEmpresa = new System.Windows.Forms.Label();
            this.txtCaProd = new System.Windows.Forms.TextBox();
            this.txtNProd = new System.Windows.Forms.TextBox();
            this.cboCodProducto = new System.Windows.Forms.ComboBox();
            this.lblCaProducto = new System.Windows.Forms.Label();
            this.lblNProducto = new System.Windows.Forms.Label();
            this.lblCProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodIdentificador = new System.Windows.Forms.TextBox();
            this.Vista_Codigo = new System.Windows.Forms.PrintPreviewDialog();
            this.Imprimir_Codigo = new System.Drawing.Printing.PrintDocument();
            this.gbCodBarras = new System.Windows.Forms.GroupBox();
            this.grBox_InsertCode.SuspendLayout();
            this.grBox_EscogeOpcion.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.gbCodBarras.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBox_InsertCode
            // 
            this.grBox_InsertCode.Controls.Add(this.lblIngreso);
            this.grBox_InsertCode.Controls.Add(this.txtIngresoCode);
            this.grBox_InsertCode.Controls.Add(this.label2);
            this.grBox_InsertCode.Controls.Add(this.txtIngLote);
            this.grBox_InsertCode.Location = new System.Drawing.Point(59, 31);
            this.grBox_InsertCode.Name = "grBox_InsertCode";
            this.grBox_InsertCode.Size = new System.Drawing.Size(191, 115);
            this.grBox_InsertCode.TabIndex = 0;
            this.grBox_InsertCode.TabStop = false;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(6, 25);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(78, 13);
            this.lblIngreso.TabIndex = 2;
            this.lblIngreso.Text = "Ingrese Codigo";
            // 
            // txtIngresoCode
            // 
            this.txtIngresoCode.Location = new System.Drawing.Point(6, 41);
            this.txtIngresoCode.Name = "txtIngresoCode";
            this.txtIngresoCode.Size = new System.Drawing.Size(140, 20);
            this.txtIngresoCode.TabIndex = 0;
            this.txtIngresoCode.Tag = "cod_termi";
            this.txtIngresoCode.TextChanged += new System.EventHandler(this.txtIngresoCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Lote";
            // 
            // txtIngLote
            // 
            this.txtIngLote.Location = new System.Drawing.Point(6, 85);
            this.txtIngLote.MaxLength = 2;
            this.txtIngLote.Name = "txtIngLote";
            this.txtIngLote.Size = new System.Drawing.Size(140, 20);
            this.txtIngLote.TabIndex = 1;
            this.txtIngLote.Tag = "cod_lote";
            this.txtIngLote.TextChanged += new System.EventHandler(this.txtIngDos_TextChanged);
            // 
            // grBox_EscogeOpcion
            // 
            this.grBox_EscogeOpcion.Controls.Add(this.rbtn8);
            this.grBox_EscogeOpcion.Controls.Add(this.rbtn13);
            this.grBox_EscogeOpcion.Location = new System.Drawing.Point(272, 31);
            this.grBox_EscogeOpcion.Name = "grBox_EscogeOpcion";
            this.grBox_EscogeOpcion.Size = new System.Drawing.Size(161, 115);
            this.grBox_EscogeOpcion.TabIndex = 1;
            this.grBox_EscogeOpcion.TabStop = false;
            // 
            // rbtn8
            // 
            this.rbtn8.AutoSize = true;
            this.rbtn8.Location = new System.Drawing.Point(37, 42);
            this.rbtn8.Name = "rbtn8";
            this.rbtn8.Size = new System.Drawing.Size(67, 17);
            this.rbtn8.TabIndex = 2;
            this.rbtn8.TabStop = true;
            this.rbtn8.Text = "Codigo 8";
            this.rbtn8.UseVisualStyleBackColor = true;
            this.rbtn8.CheckedChanged += new System.EventHandler(this.rbtn8_CheckedChanged_1);
            // 
            // rbtn13
            // 
            this.rbtn13.AutoSize = true;
            this.rbtn13.Location = new System.Drawing.Point(37, 69);
            this.rbtn13.Name = "rbtn13";
            this.rbtn13.Size = new System.Drawing.Size(73, 17);
            this.rbtn13.TabIndex = 1;
            this.rbtn13.TabStop = true;
            this.rbtn13.Text = "Codigo 13";
            this.TtInfo.SetToolTip(this.rbtn13, "Utilizado para la identificación de unidades de consumo");
            this.rbtn13.UseVisualStyleBackColor = true;
            this.rbtn13.CheckedChanged += new System.EventHandler(this.rbtn13_CheckedChanged);
            // 
            // txtCodigoBar
            // 
            this.txtCodigoBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBar.Font = new System.Drawing.Font("Code EAN13", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtCodigoBar.Location = new System.Drawing.Point(59, 152);
            this.txtCodigoBar.Name = "txtCodigoBar";
            this.txtCodigoBar.ReadOnly = true;
            this.txtCodigoBar.Size = new System.Drawing.Size(374, 87);
            this.txtCodigoBar.TabIndex = 3;
            this.txtCodigoBar.Tag = "";
            this.txtCodigoBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoBar.TextChanged += new System.EventHandler(this.txtCodigoBar_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(439, 152);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Grabar Codigo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(439, 182);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Imprimir Codigo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(34, 25);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_codbarras";
            this.navegador1.TabIndex = 6;
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.txtCodProducto);
            this.gbAdmin.Controls.Add(this.btnConsultar);
            this.gbAdmin.Controls.Add(this.txtCEmpsa);
            this.gbAdmin.Controls.Add(this.txtNEmpsa);
            this.gbAdmin.Controls.Add(this.lblNEmpresa);
            this.gbAdmin.Controls.Add(this.lblCEmpresa);
            this.gbAdmin.Controls.Add(this.txtCaProd);
            this.gbAdmin.Controls.Add(this.txtNProd);
            this.gbAdmin.Controls.Add(this.cboCodProducto);
            this.gbAdmin.Controls.Add(this.lblCaProducto);
            this.gbAdmin.Controls.Add(this.lblNProducto);
            this.gbAdmin.Controls.Add(this.lblCProducto);
            this.gbAdmin.Location = new System.Drawing.Point(34, 132);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(598, 100);
            this.gbAdmin.TabIndex = 7;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Datos Administrativos";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(259, 45);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(41, 20);
            this.txtCodProducto.TabIndex = 12;
            this.txtCodProducto.Tag = "cod_pro";
            this.txtCodProducto.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(259, 16);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(69, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCEmpsa
            // 
            this.txtCEmpsa.Location = new System.Drawing.Point(458, 19);
            this.txtCEmpsa.Name = "txtCEmpsa";
            this.txtCEmpsa.ReadOnly = true;
            this.txtCEmpsa.Size = new System.Drawing.Size(132, 20);
            this.txtCEmpsa.TabIndex = 11;
            this.txtCEmpsa.TextChanged += new System.EventHandler(this.txtCEmpsa_TextChanged);
            // 
            // txtNEmpsa
            // 
            this.txtNEmpsa.Location = new System.Drawing.Point(458, 45);
            this.txtNEmpsa.Name = "txtNEmpsa";
            this.txtNEmpsa.ReadOnly = true;
            this.txtNEmpsa.Size = new System.Drawing.Size(132, 20);
            this.txtNEmpsa.TabIndex = 10;
            // 
            // lblNEmpresa
            // 
            this.lblNEmpresa.AutoSize = true;
            this.lblNEmpresa.Location = new System.Drawing.Point(349, 48);
            this.lblNEmpresa.Name = "lblNEmpresa";
            this.lblNEmpresa.Size = new System.Drawing.Size(88, 13);
            this.lblNEmpresa.TabIndex = 7;
            this.lblNEmpresa.Text = "Nombre Empresa";
            // 
            // lblCEmpresa
            // 
            this.lblCEmpresa.AutoSize = true;
            this.lblCEmpresa.Location = new System.Drawing.Point(349, 21);
            this.lblCEmpresa.Name = "lblCEmpresa";
            this.lblCEmpresa.Size = new System.Drawing.Size(84, 13);
            this.lblCEmpresa.TabIndex = 6;
            this.lblCEmpresa.Text = "Codigo Empresa";
            // 
            // txtCaProd
            // 
            this.txtCaProd.Location = new System.Drawing.Point(121, 71);
            this.txtCaProd.Name = "txtCaProd";
            this.txtCaProd.ReadOnly = true;
            this.txtCaProd.Size = new System.Drawing.Size(132, 20);
            this.txtCaProd.TabIndex = 5;
            // 
            // txtNProd
            // 
            this.txtNProd.Location = new System.Drawing.Point(121, 44);
            this.txtNProd.Name = "txtNProd";
            this.txtNProd.ReadOnly = true;
            this.txtNProd.Size = new System.Drawing.Size(132, 20);
            this.txtNProd.TabIndex = 4;
            // 
            // cboCodProducto
            // 
            this.cboCodProducto.FormattingEnabled = true;
            this.cboCodProducto.Location = new System.Drawing.Point(121, 17);
            this.cboCodProducto.Name = "cboCodProducto";
            this.cboCodProducto.Size = new System.Drawing.Size(132, 21);
            this.cboCodProducto.TabIndex = 3;
            this.cboCodProducto.SelectedIndexChanged += new System.EventHandler(this.cboCodProducto_SelectedIndexChanged);
            // 
            // lblCaProducto
            // 
            this.lblCaProducto.AutoSize = true;
            this.lblCaProducto.Location = new System.Drawing.Point(7, 71);
            this.lblCaProducto.Name = "lblCaProducto";
            this.lblCaProducto.Size = new System.Drawing.Size(95, 13);
            this.lblCaProducto.TabIndex = 2;
            this.lblCaProducto.Text = "Cantidad Producto";
            // 
            // lblNProducto
            // 
            this.lblNProducto.AutoSize = true;
            this.lblNProducto.Location = new System.Drawing.Point(7, 47);
            this.lblNProducto.Name = "lblNProducto";
            this.lblNProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNProducto.TabIndex = 1;
            this.lblNProducto.Text = "Nombre Producto";
            // 
            // lblCProducto
            // 
            this.lblCProducto.AutoSize = true;
            this.lblCProducto.Location = new System.Drawing.Point(7, 20);
            this.lblCProducto.Name = "lblCProducto";
            this.lblCProducto.Size = new System.Drawing.Size(97, 13);
            this.lblCProducto.TabIndex = 0;
            this.lblCProducto.Text = "Codigo Produccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo";
            // 
            // txtCodIdentificador
            // 
            this.txtCodIdentificador.Location = new System.Drawing.Point(538, 116);
            this.txtCodIdentificador.Name = "txtCodIdentificador";
            this.txtCodIdentificador.Size = new System.Drawing.Size(65, 20);
            this.txtCodIdentificador.TabIndex = 9;
            this.txtCodIdentificador.Tag = "cod_cobar";
            // 
            // Vista_Codigo
            // 
            this.Vista_Codigo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Vista_Codigo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Vista_Codigo.ClientSize = new System.Drawing.Size(400, 300);
            this.Vista_Codigo.Enabled = true;
            this.Vista_Codigo.Icon = ((System.Drawing.Icon)(resources.GetObject("Vista_Codigo.Icon")));
            this.Vista_Codigo.Name = "Vista_Codigo";
            this.Vista_Codigo.Visible = false;
            // 
            // Imprimir_Codigo
            // 
            this.Imprimir_Codigo.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir_Codigo_PrintPage);
            // 
            // gbCodBarras
            // 
            this.gbCodBarras.Controls.Add(this.grBox_InsertCode);
            this.gbCodBarras.Controls.Add(this.grBox_EscogeOpcion);
            this.gbCodBarras.Controls.Add(this.txtCodigoBar);
            this.gbCodBarras.Controls.Add(this.btnPrint);
            this.gbCodBarras.Controls.Add(this.btnGuardar);
            this.gbCodBarras.Location = new System.Drawing.Point(34, 253);
            this.gbCodBarras.Name = "gbCodBarras";
            this.gbCodBarras.Size = new System.Drawing.Size(598, 262);
            this.gbCodBarras.TabIndex = 10;
            this.gbCodBarras.TabStop = false;
            this.gbCodBarras.Text = "Generar Código";
            // 
            // wf_CodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 561);
            this.Controls.Add(this.gbCodBarras);
            this.Controls.Add(this.txtCodIdentificador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wf_CodigoBarras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de Barras";
            this.Load += new System.EventHandler(this.wf_CodigoBarras_Load);
            this.grBox_InsertCode.ResumeLayout(false);
            this.grBox_InsertCode.PerformLayout();
            this.grBox_EscogeOpcion.ResumeLayout(false);
            this.grBox_EscogeOpcion.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbCodBarras.ResumeLayout(false);
            this.gbCodBarras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBox_InsertCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtIngLote;
        private System.Windows.Forms.TextBox txtIngresoCode;
        private System.Windows.Forms.GroupBox grBox_EscogeOpcion;
        private System.Windows.Forms.RadioButton rbtn13;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnPrint;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ToolTip TtInfo;
        private System.Windows.Forms.RadioButton rbtn8;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.TextBox txtCEmpsa;
        private System.Windows.Forms.TextBox txtNEmpsa;
        private System.Windows.Forms.Label lblNEmpresa;
        private System.Windows.Forms.Label lblCEmpresa;
        private System.Windows.Forms.TextBox txtCaProd;
        private System.Windows.Forms.TextBox txtNProd;
        private System.Windows.Forms.ComboBox cboCodProducto;
        private System.Windows.Forms.Label lblCaProducto;
        private System.Windows.Forms.Label lblNProducto;
        private System.Windows.Forms.Label lblCProducto;
        private System.Windows.Forms.TextBox txtCodigoBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodIdentificador;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.PrintPreviewDialog Vista_Codigo;
        private System.Drawing.Printing.PrintDocument Imprimir_Codigo;
        private System.Windows.Forms.GroupBox gbCodBarras;
        private System.Windows.Forms.Button btnConsultar;
    }
}