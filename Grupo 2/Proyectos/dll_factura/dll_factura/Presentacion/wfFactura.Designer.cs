namespace dll_factura.Presentacion
{
    partial class wfFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfFactura));
            this.lblnumero_factura = new System.Windows.Forms.Label();
            this.lblnit_cliente = new System.Windows.Forms.Label();
            this.lblid_usuario = new System.Windows.Forms.Label();
            this.lblid_pacientes = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.txtnumero_factura = new System.Windows.Forms.TextBox();
            this.txtid_usuario = new System.Windows.Forms.TextBox();
            this.txtid_pacientes = new System.Windows.Forms.TextBox();
            this.txtnit_cliente = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.tbcfactura = new System.Windows.Forms.TabControl();
            this.tbpusuario = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbppaciente = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbcfactura.SuspendLayout();
            this.tbpusuario.SuspendLayout();
            this.tbppaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnumero_factura
            // 
            this.lblnumero_factura.AutoSize = true;
            this.lblnumero_factura.Location = new System.Drawing.Point(54, 81);
            this.lblnumero_factura.Name = "lblnumero_factura";
            this.lblnumero_factura.Size = new System.Drawing.Size(98, 13);
            this.lblnumero_factura.TabIndex = 0;
            this.lblnumero_factura.Text = "Numero de factura:";
            // 
            // lblnit_cliente
            // 
            this.lblnit_cliente.AutoSize = true;
            this.lblnit_cliente.Location = new System.Drawing.Point(54, 142);
            this.lblnit_cliente.Name = "lblnit_cliente";
            this.lblnit_cliente.Size = new System.Drawing.Size(57, 13);
            this.lblnit_cliente.TabIndex = 1;
            this.lblnit_cliente.Text = "Nit cliente:";
            // 
            // lblid_usuario
            // 
            this.lblid_usuario.AutoSize = true;
            this.lblid_usuario.Location = new System.Drawing.Point(292, 81);
            this.lblid_usuario.Name = "lblid_usuario";
            this.lblid_usuario.Size = new System.Drawing.Size(58, 13);
            this.lblid_usuario.TabIndex = 2;
            this.lblid_usuario.Text = "ID usuario:";
            // 
            // lblid_pacientes
            // 
            this.lblid_pacientes.AutoSize = true;
            this.lblid_pacientes.Location = new System.Drawing.Point(475, 81);
            this.lblid_pacientes.Name = "lblid_pacientes";
            this.lblid_pacientes.Size = new System.Drawing.Size(67, 13);
            this.lblid_pacientes.TabIndex = 3;
            this.lblid_pacientes.Text = "ID pacientes";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(292, 143);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(40, 13);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "Fecha:";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(57, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "factura";
            this.navegador1.TabIndex = 5;
            // 
            // txtnumero_factura
            // 
            this.txtnumero_factura.Location = new System.Drawing.Point(158, 74);
            this.txtnumero_factura.Name = "txtnumero_factura";
            this.txtnumero_factura.Size = new System.Drawing.Size(100, 20);
            this.txtnumero_factura.TabIndex = 6;
            this.txtnumero_factura.Tag = "numero_factura";
            // 
            // txtid_usuario
            // 
            this.txtid_usuario.Location = new System.Drawing.Point(357, 73);
            this.txtid_usuario.Name = "txtid_usuario";
            this.txtid_usuario.Size = new System.Drawing.Size(100, 20);
            this.txtid_usuario.TabIndex = 7;
            this.txtid_usuario.Tag = "id_usuario";
            // 
            // txtid_pacientes
            // 
            this.txtid_pacientes.Location = new System.Drawing.Point(558, 72);
            this.txtid_pacientes.Name = "txtid_pacientes";
            this.txtid_pacientes.Size = new System.Drawing.Size(93, 20);
            this.txtid_pacientes.TabIndex = 8;
            this.txtid_pacientes.Tag = "id_pacientes";
            // 
            // txtnit_cliente
            // 
            this.txtnit_cliente.Location = new System.Drawing.Point(158, 136);
            this.txtnit_cliente.Name = "txtnit_cliente";
            this.txtnit_cliente.Size = new System.Drawing.Size(100, 20);
            this.txtnit_cliente.TabIndex = 9;
            this.txtnit_cliente.Tag = "nit_cliente";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(357, 136);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(100, 20);
            this.dtpfecha.TabIndex = 10;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(478, 136);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 11;
            this.txtfecha.Tag = "fecha";
            this.txtfecha.TextChanged += new System.EventHandler(this.txtfecha_TextChanged);
            // 
            // tbcfactura
            // 
            this.tbcfactura.Controls.Add(this.tbpusuario);
            this.tbcfactura.Controls.Add(this.tbppaciente);
            this.tbcfactura.Location = new System.Drawing.Point(53, 212);
            this.tbcfactura.Name = "tbcfactura";
            this.tbcfactura.SelectedIndex = 0;
            this.tbcfactura.Size = new System.Drawing.Size(642, 272);
            this.tbcfactura.TabIndex = 12;
            // 
            // tbpusuario
            // 
            this.tbpusuario.Controls.Add(this.cuDataGridD1);
            this.tbpusuario.Location = new System.Drawing.Point(4, 22);
            this.tbpusuario.Name = "tbpusuario";
            this.tbpusuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpusuario.Size = new System.Drawing.Size(634, 246);
            this.tbpusuario.TabIndex = 0;
            this.tbpusuario.Text = "Usuario";
            this.tbpusuario.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(3, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(628, 237);
            this.cuDataGridD1.STabla = "usuario";
            this.cuDataGridD1.TabIndex = 13;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            this.cuDataGridD1.Load += new System.EventHandler(this.cuDataGridD1_Load);
            // 
            // tbppaciente
            // 
            this.tbppaciente.Controls.Add(this.cuDataGridD2);
            this.tbppaciente.Location = new System.Drawing.Point(4, 22);
            this.tbppaciente.Name = "tbppaciente";
            this.tbppaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbppaciente.Size = new System.Drawing.Size(634, 246);
            this.tbppaciente.TabIndex = 1;
            this.tbppaciente.Text = "Paciente";
            this.tbppaciente.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(3, 6);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(625, 237);
            this.cuDataGridD2.STabla = "paciente";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // wfFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 496);
            this.Controls.Add(this.tbcfactura);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtnit_cliente);
            this.Controls.Add(this.txtid_pacientes);
            this.Controls.Add(this.txtid_usuario);
            this.Controls.Add(this.txtnumero_factura);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblid_pacientes);
            this.Controls.Add(this.lblid_usuario);
            this.Controls.Add(this.lblnit_cliente);
            this.Controls.Add(this.lblnumero_factura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.wfFactura_Load);
            this.tbcfactura.ResumeLayout(false);
            this.tbpusuario.ResumeLayout(false);
            this.tbppaciente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero_factura;
        private System.Windows.Forms.Label lblnit_cliente;
        private System.Windows.Forms.Label lblid_usuario;
        private System.Windows.Forms.Label lblid_pacientes;
        private System.Windows.Forms.Label lblfecha;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtnumero_factura;
        private System.Windows.Forms.TextBox txtid_usuario;
        private System.Windows.Forms.TextBox txtid_pacientes;
        private System.Windows.Forms.TextBox txtnit_cliente;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TabControl tbcfactura;
        private System.Windows.Forms.TabPage tbpusuario;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tbppaciente;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
    }
}