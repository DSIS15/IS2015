namespace dll_citamedica.Presentacion
{
    partial class wfTipoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfTipoExamen));
            this.navegador1 = new Navegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdTipoExamen = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaModificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.dtFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            this.navegador1.sNombreTabla = "tipo_examen";
            this.navegador1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id tipo examen";
            // 
            // txtIdTipoExamen
            // 
            this.txtIdTipoExamen.Location = new System.Drawing.Point(136, 110);
            this.txtIdTipoExamen.Name = "txtIdTipoExamen";
            this.txtIdTipoExamen.Size = new System.Drawing.Size(114, 20);
            this.txtIdTipoExamen.TabIndex = 2;
            this.txtIdTipoExamen.Tag = "id_tipo_examen";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(405, 105);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 3;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha creacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Tag = "nombre_tipo_examen";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(405, 151);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.Tag = "descripcion_examen";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(268, 206);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(19, 20);
            this.txtFechaCreacion.TabIndex = 9;
            this.txtFechaCreacion.Tag = "fecha_creacion";
            this.txtFechaCreacion.Visible = false;
            this.txtFechaCreacion.TextChanged += new System.EventHandler(this.txtFechaCreacion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha modificacion";
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.Location = new System.Drawing.Point(548, 203);
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.Size = new System.Drawing.Size(17, 20);
            this.txtFechaModificacion.TabIndex = 11;
            this.txtFechaModificacion.Tag = "fecha_modificacion";
            this.txtFechaModificacion.Visible = false;
            this.txtFechaModificacion.TextChanged += new System.EventHandler(this.txtFechaModificacion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado";
            // 
            // dtFechaCreacion
            // 
            this.dtFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCreacion.Location = new System.Drawing.Point(136, 203);
            this.dtFechaCreacion.Name = "dtFechaCreacion";
            this.dtFechaCreacion.Size = new System.Drawing.Size(114, 20);
            this.dtFechaCreacion.TabIndex = 13;
            this.dtFechaCreacion.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtFechaModificacion
            // 
            this.dtFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaModificacion.Location = new System.Drawing.Point(405, 203);
            this.dtFechaModificacion.Name = "dtFechaModificacion";
            this.dtFechaModificacion.Size = new System.Drawing.Size(121, 20);
            this.dtFechaModificacion.TabIndex = 14;
            this.dtFechaModificacion.ValueChanged += new System.EventHandler(this.dtFechaModificacion_ValueChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(548, 107);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(17, 20);
            this.txtEstado.TabIndex = 15;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // wfTipoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 304);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dtFechaModificacion);
            this.Controls.Add(this.dtFechaCreacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechaModificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtIdTipoExamen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "wfTipoExamen";
            this.Text = "wfTipoExamen";
            this.Load += new System.EventHandler(this.wfTipoExamen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdTipoExamen;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaModificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtFechaModificacion;
        private System.Windows.Forms.TextBox txtEstado;
    }
}