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
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstadoMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id medico";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado";
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEstadoMedico);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstadoMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtPrimerApMedico;
        private System.Windows.Forms.TextBox txtSegundoApMedico;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtEstadoMedico;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
    }
}