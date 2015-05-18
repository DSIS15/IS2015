namespace dll_seguridad.Presentacion
{
    partial class wfPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPerfiles));
            this.lblcodperfil = new System.Windows.Forms.Label();
            this.lblnombreperfil = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblfechcreacion = new System.Windows.Forms.Label();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblfechmodificacion = new System.Windows.Forms.Label();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcodperfil
            // 
            this.lblcodperfil.AutoSize = true;
            this.lblcodperfil.Location = new System.Drawing.Point(29, 109);
            this.lblcodperfil.Name = "lblcodperfil";
            this.lblcodperfil.Size = new System.Drawing.Size(65, 13);
            this.lblcodperfil.TabIndex = 0;
            this.lblcodperfil.Text = "Código perfil";
            // 
            // lblnombreperfil
            // 
            this.lblnombreperfil.AutoSize = true;
            this.lblnombreperfil.Location = new System.Drawing.Point(176, 108);
            this.lblnombreperfil.Name = "lblnombreperfil";
            this.lblnombreperfil.Size = new System.Drawing.Size(69, 13);
            this.lblnombreperfil.TabIndex = 1;
            this.lblnombreperfil.Text = "Nombre perfil";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(400, 109);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Estado";
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Enabled = false;
            this.txtCodPerfil.Location = new System.Drawing.Point(117, 102);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(26, 20);
            this.txtCodPerfil.TabIndex = 1;
            this.txtCodPerfil.Tag = "codigo_perfil";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(558, 101);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(21, 20);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(254, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tag = "nombre_perfil";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(15, 21);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "perfil";
            this.navegador1.TabIndex = 6;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.navegador1_btnBuscar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // lblfechcreacion
            // 
            this.lblfechcreacion.AutoSize = true;
            this.lblfechcreacion.Location = new System.Drawing.Point(29, 152);
            this.lblfechcreacion.Name = "lblfechcreacion";
            this.lblfechcreacion.Size = new System.Drawing.Size(81, 13);
            this.lblfechcreacion.TabIndex = 7;
            this.lblfechcreacion.Text = "Fecha creación";
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(125, 145);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(100, 20);
            this.txtfech.TabIndex = 4;
            this.txtfech.Tag = "fecha_creacion";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(456, 101);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbEstado.TabIndex = 2;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblfechmodificacion
            // 
            this.lblfechmodificacion.AutoSize = true;
            this.lblfechmodificacion.Location = new System.Drawing.Point(254, 152);
            this.lblfechmodificacion.Name = "lblfechmodificacion";
            this.lblfechmodificacion.Size = new System.Drawing.Size(99, 13);
            this.lblfechmodificacion.TabIndex = 8;
            this.lblfechmodificacion.Text = "Fecha modificación";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(360, 145);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 9;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // wfPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 197);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.lblfechmodificacion);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.lblfechcreacion);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblnombreperfil);
            this.Controls.Add(this.lblcodperfil);
            this.Name = "wfPerfiles";
            this.Text = "Crear Perfil";
            this.Load += new System.EventHandler(this.wfPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodperfil;
        private System.Windows.Forms.Label lblnombreperfil;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblfechcreacion;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblfechmodificacion;
        private System.Windows.Forms.TextBox txtfecm;

    }
}