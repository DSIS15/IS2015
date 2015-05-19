namespace dll_citamedica.Presentacion
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
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cboEstadoMedico = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtPrimerApMedico = new System.Windows.Forms.TextBox();
            this.txtSegundoApMedico = new System.Windows.Forms.TextBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtEstadoMedico = new System.Windows.Forms.TextBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "medico";
            this.navegador1.TabIndex = 0;
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(161, 129);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(128, 20);
            this.txtIdMedico.TabIndex = 1;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(86, 129);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(53, 13);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Id medico";
            // 
            // cboEstadoMedico
            // 
            this.cboEstadoMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoMedico.FormattingEnabled = true;
            this.cboEstadoMedico.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoMedico.Location = new System.Drawing.Point(421, 126);
            this.cboEstadoMedico.Name = "cboEstadoMedico";
            this.cboEstadoMedico.Size = new System.Drawing.Size(128, 21);
            this.cboEstadoMedico.TabIndex = 3;
            this.cboEstadoMedico.SelectedIndexChanged += new System.EventHandler(this.cboEstadoMedico_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(95, 178);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(323, 178);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(76, 13);
            this.lblPrimerApellido.TabIndex = 5;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(49, 219);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(325, 219);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(74, 13);
            this.lblFechaIngreso.TabIndex = 7;
            this.lblFechaIngreso.Text = "Fecha ingreso";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(346, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(161, 171);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(128, 20);
            this.txtNombreMedico.TabIndex = 9;
            this.txtNombreMedico.Tag = "nombre_medico";
            // 
            // txtPrimerApMedico
            // 
            this.txtPrimerApMedico.Location = new System.Drawing.Point(421, 171);
            this.txtPrimerApMedico.Name = "txtPrimerApMedico";
            this.txtPrimerApMedico.Size = new System.Drawing.Size(128, 20);
            this.txtPrimerApMedico.TabIndex = 10;
            this.txtPrimerApMedico.Tag = "primer_apellido_medico";
            // 
            // txtSegundoApMedico
            // 
            this.txtSegundoApMedico.Location = new System.Drawing.Point(161, 219);
            this.txtSegundoApMedico.Name = "txtSegundoApMedico";
            this.txtSegundoApMedico.Size = new System.Drawing.Size(128, 20);
            this.txtSegundoApMedico.TabIndex = 11;
            this.txtSegundoApMedico.Tag = "medico_segundo_apellido";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(555, 219);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(25, 20);
            this.txtFechaIngreso.TabIndex = 12;
            this.txtFechaIngreso.Tag = "fecha_ingreso";
            this.txtFechaIngreso.TextChanged += new System.EventHandler(this.txtFechaIngreso_TextChanged);
            // 
            // txtEstadoMedico
            // 
            this.txtEstadoMedico.Location = new System.Drawing.Point(555, 127);
            this.txtEstadoMedico.Name = "txtEstadoMedico";
            this.txtEstadoMedico.Size = new System.Drawing.Size(24, 20);
            this.txtEstadoMedico.TabIndex = 13;
            this.txtEstadoMedico.Tag = "estado";
            this.txtEstadoMedico.Visible = false;
            this.txtEstadoMedico.TextChanged += new System.EventHandler(this.txtEstadoMedico_TextChanged);
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(429, 221);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(120, 20);
            this.dtFechaIngreso.TabIndex = 14;
            this.dtFechaIngreso.ValueChanged += new System.EventHandler(this.dtFechaIngreso_ValueChanged);
            // 
            // wfMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 330);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.txtEstadoMedico);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtSegundoApMedico);
            this.Controls.Add(this.txtPrimerApMedico);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboEstadoMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.navegador1);
            this.Name = "wfMedico";
            this.Text = "wfMedico";
            this.Load += new System.EventHandler(this.wfMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cboEstadoMedico;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtPrimerApMedico;
        private System.Windows.Forms.TextBox txtSegundoApMedico;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtEstadoMedico;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
    }
}