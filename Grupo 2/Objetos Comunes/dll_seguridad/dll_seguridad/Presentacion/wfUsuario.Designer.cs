namespace dll_seguridad.Presentacion
{
    partial class wfUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfUsuario));
            this.lblIDusuario = new System.Windows.Forms.Label();
            this.lblCodPer = new System.Windows.Forms.Label();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.lblPaswUser = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lbl1Apellido = new System.Windows.Forms.Label();
            this.txtPrimerAp = new System.Windows.Forms.TextBox();
            this.lbltxt2Apellido = new System.Windows.Forms.Label();
            this.txtSegundoAp = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIDusuario
            // 
            this.lblIDusuario.AutoSize = true;
            this.lblIDusuario.Location = new System.Drawing.Point(21, 100);
            this.lblIDusuario.Name = "lblIDusuario";
            this.lblIDusuario.Size = new System.Drawing.Size(57, 13);
            this.lblIDusuario.TabIndex = 0;
            this.lblIDusuario.Text = "ID Usuario";
            // 
            // lblCodPer
            // 
            this.lblCodPer.AutoSize = true;
            this.lblCodPer.Location = new System.Drawing.Point(164, 99);
            this.lblCodPer.Name = "lblCodPer";
            this.lblCodPer.Size = new System.Drawing.Size(66, 13);
            this.lblCodPer.TabIndex = 1;
            this.lblCodPer.Text = "Codigo Perfil";
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Location = new System.Drawing.Point(21, 142);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(83, 13);
            this.lblNomUser.TabIndex = 2;
            this.lblNomUser.Text = "Nombre Usuario";
            // 
            // lblPaswUser
            // 
            this.lblPaswUser.AutoSize = true;
            this.lblPaswUser.Location = new System.Drawing.Point(21, 227);
            this.lblPaswUser.Name = "lblPaswUser";
            this.lblPaswUser.Size = new System.Drawing.Size(61, 13);
            this.lblPaswUser.TabIndex = 3;
            this.lblPaswUser.Text = "Contraseña";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(322, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(84, 93);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(30, 20);
            this.txtIDUsuario.TabIndex = 5;
            this.txtIDUsuario.Tag = "id_usuario";
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(236, 93);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(30, 20);
            this.txtCodPerfil.TabIndex = 6;
            this.txtCodPerfil.Tag = "codigo_perfil";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(118, 135);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtNomUsuario.TabIndex = 7;
            this.txtNomUsuario.Tag = "nombre_Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(118, 220);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(154, 20);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Tag = "pasword_usuario";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(561, 91);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(26, 20);
            this.txtEstado.TabIndex = 9;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "usuario";
            this.navegador1.TabIndex = 10;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(21, 185);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(68, 13);
            this.lblAlias.TabIndex = 11;
            this.lblAlias.Text = "Alias Usuario";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(118, 178);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(154, 20);
            this.txtAlias.TabIndex = 12;
            this.txtAlias.Tag = "alias_usuario";
            // 
            // lbl1Apellido
            // 
            this.lbl1Apellido.AutoSize = true;
            this.lbl1Apellido.Location = new System.Drawing.Point(322, 142);
            this.lbl1Apellido.Name = "lbl1Apellido";
            this.lbl1Apellido.Size = new System.Drawing.Size(76, 13);
            this.lbl1Apellido.TabIndex = 13;
            this.lbl1Apellido.Text = "Primer Apellido";
            // 
            // txtPrimerAp
            // 
            this.txtPrimerAp.Location = new System.Drawing.Point(434, 135);
            this.txtPrimerAp.Name = "txtPrimerAp";
            this.txtPrimerAp.Size = new System.Drawing.Size(153, 20);
            this.txtPrimerAp.TabIndex = 14;
            this.txtPrimerAp.Tag = "primer_apellido";
            // 
            // lbltxt2Apellido
            // 
            this.lbltxt2Apellido.AutoSize = true;
            this.lbltxt2Apellido.Location = new System.Drawing.Point(322, 185);
            this.lbltxt2Apellido.Name = "lbltxt2Apellido";
            this.lbltxt2Apellido.Size = new System.Drawing.Size(90, 13);
            this.lbltxt2Apellido.TabIndex = 15;
            this.lbltxt2Apellido.Text = "Segundo Apellido";
            // 
            // txtSegundoAp
            // 
            this.txtSegundoAp.Location = new System.Drawing.Point(434, 177);
            this.txtSegundoAp.Name = "txtSegundoAp";
            this.txtSegundoAp.Size = new System.Drawing.Size(153, 20);
            this.txtSegundoAp.TabIndex = 16;
            this.txtSegundoAp.Tag = "segundo_apellido";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Descativado"});
            this.cbEstado.Location = new System.Drawing.Point(434, 91);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 17;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(322, 227);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(434, 220);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(153, 20);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.Tag = "direccion";
            // 
            // wfUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 332);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtSegundoAp);
            this.Controls.Add(this.lbltxt2Apellido);
            this.Controls.Add(this.txtPrimerAp);
            this.Controls.Add(this.lbl1Apellido);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPaswUser);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.lblCodPer);
            this.Controls.Add(this.lblIDusuario);
            this.Name = "wfUsuario";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.wfUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDusuario;
        private System.Windows.Forms.Label lblCodPer;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Label lblPaswUser;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtEstado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lbl1Apellido;
        private System.Windows.Forms.TextBox txtPrimerAp;
        private System.Windows.Forms.Label lbltxt2Apellido;
        private System.Windows.Forms.TextBox txtSegundoAp;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;

    }
}