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
            this.lblCodPerfil = new System.Windows.Forms.Label();
            this.lblNombre_perfil = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCodPerfil
            // 
            this.lblCodPerfil.AutoSize = true;
            this.lblCodPerfil.Location = new System.Drawing.Point(29, 109);
            this.lblCodPerfil.Name = "lblCodPerfil";
            this.lblCodPerfil.Size = new System.Drawing.Size(63, 13);
            this.lblCodPerfil.TabIndex = 0;
            this.lblCodPerfil.Text = "Codigo Peril";
            // 
            // lblNombre_perfil
            // 
            this.lblNombre_perfil.AutoSize = true;
            this.lblNombre_perfil.Location = new System.Drawing.Point(29, 149);
            this.lblNombre_perfil.Name = "lblNombre_perfil";
            this.lblNombre_perfil.Size = new System.Drawing.Size(70, 13);
            this.lblNombre_perfil.TabIndex = 1;
            this.lblNombre_perfil.Text = "Nombre Perfil";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(267, 109);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Enabled = false;
            this.txtCodPerfil.Location = new System.Drawing.Point(117, 102);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(52, 20);
            this.txtCodPerfil.TabIndex = 3;
            this.txtCodPerfil.Tag = "codigo_perfil";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(468, 102);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(37, 20);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Creación";
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(366, 142);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(100, 20);
            this.txtfech.TabIndex = 8;
            this.txtfech.Tag = "fecha_creacion";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(366, 102);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(84, 21);
            this.cbEstado.TabIndex = 9;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // wfPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 215);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre_perfil);
            this.Controls.Add(this.lblCodPerfil);
            this.Name = "wfPerfiles";
            this.Text = "Crear Perfil";
            this.Load += new System.EventHandler(this.wfPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPerfil;
        private System.Windows.Forms.Label lblNombre_perfil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.ComboBox cbEstado;

    }
}