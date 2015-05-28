namespace dll_medico.Presentacion
{
    partial class wfMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMedico));
            this.navegador1 = new Navegador.Navegador();
            this.lblmedico = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprimerapellido = new System.Windows.Forms.Label();
            this.lblsegundoapellido = new System.Windows.Forms.Label();
            this.lblfechaingreso = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "medico";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            // 
            // lblmedico
            // 
            this.lblmedico.AutoSize = true;
            this.lblmedico.Location = new System.Drawing.Point(69, 99);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(53, 13);
            this.lblmedico.TabIndex = 1;
            this.lblmedico.Text = "Id medico";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(69, 142);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lblprimerapellido
            // 
            this.lblprimerapellido.AutoSize = true;
            this.lblprimerapellido.Location = new System.Drawing.Point(333, 139);
            this.lblprimerapellido.Name = "lblprimerapellido";
            this.lblprimerapellido.Size = new System.Drawing.Size(76, 13);
            this.lblprimerapellido.TabIndex = 3;
            this.lblprimerapellido.Text = "Primer Apellido";
            // 
            // lblsegundoapellido
            // 
            this.lblsegundoapellido.AutoSize = true;
            this.lblsegundoapellido.Location = new System.Drawing.Point(69, 181);
            this.lblsegundoapellido.Name = "lblsegundoapellido";
            this.lblsegundoapellido.Size = new System.Drawing.Size(90, 13);
            this.lblsegundoapellido.TabIndex = 4;
            this.lblsegundoapellido.Text = "Segundo Apellido";
            // 
            // lblfechaingreso
            // 
            this.lblfechaingreso.AutoSize = true;
            this.lblfechaingreso.Location = new System.Drawing.Point(334, 181);
            this.lblfechaingreso.Name = "lblfechaingreso";
            this.lblfechaingreso.Size = new System.Drawing.Size(75, 13);
            this.lblfechaingreso.TabIndex = 5;
            this.lblfechaingreso.Text = "Fecha Ingreso";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(334, 102);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 6;
            this.lblestado.Text = "Estado";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Enabled = false;
            this.txtIdMedico.Location = new System.Drawing.Point(188, 96);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(35, 20);
            this.txtIdMedico.TabIndex = 7;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Tag = "nombre_medico";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(433, 139);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerApellido.TabIndex = 9;
            this.txtPrimerApellido.Tag = "priimer_apellido_medico";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(188, 181);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoApellido.TabIndex = 10;
            this.txtSegundoApellido.Tag = "medico_segundo_apellido";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(433, 94);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(101, 21);
            this.cboEstado.TabIndex = 14;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(540, 94);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(24, 20);
            this.txtEstado.TabIndex = 13;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(433, 181);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaIngreso.TabIndex = 12;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(539, 181);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(25, 20);
            this.txtFechaIngreso.TabIndex = 15;
            this.txtFechaIngreso.Tag = "fecha_ingreso";
            this.txtFechaIngreso.Visible = false;
            this.txtFechaIngreso.TextChanged += new System.EventHandler(this.txtFechaIngreso_TextChanged);
            // 
            // wfMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 253);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblfechaingreso);
            this.Controls.Add(this.lblsegundoapellido);
            this.Controls.Add(this.lblprimerapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblmedico);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.wfMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblmedico;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblprimerapellido;
        private System.Windows.Forms.Label lblsegundoapellido;
        private System.Windows.Forms.Label lblfechaingreso;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtFechaIngreso;
    }
}