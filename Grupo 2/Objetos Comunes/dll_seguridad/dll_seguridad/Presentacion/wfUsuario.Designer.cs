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
            this.lblEstadoUser = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lbl1ApellidoUser = new System.Windows.Forms.Label();
            this.txtPrimerAp = new System.Windows.Forms.TextBox();
            this.lbltxt2Apellido = new System.Windows.Forms.Label();
            this.txtSegundoAp = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblDireccionUser = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblfechcreauser = new System.Windows.Forms.Label();
            this.lblfecmodUser = new System.Windows.Forms.Label();
            this.txtfechcrea = new System.Windows.Forms.TextBox();
            this.txtfechmod = new System.Windows.Forms.TextBox();
            this.txtEncriptar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIDusuario
            // 
            this.lblIDusuario.AutoSize = true;
            this.lblIDusuario.Location = new System.Drawing.Point(40, 89);
            this.lblIDusuario.Name = "lblIDusuario";
            this.lblIDusuario.Size = new System.Drawing.Size(57, 13);
            this.lblIDusuario.TabIndex = 0;
            this.lblIDusuario.Text = "ID Usuario";
            // 
            // lblCodPer
            // 
            this.lblCodPer.AutoSize = true;
            this.lblCodPer.Location = new System.Drawing.Point(149, 89);
            this.lblCodPer.Name = "lblCodPer";
            this.lblCodPer.Size = new System.Drawing.Size(66, 13);
            this.lblCodPer.TabIndex = 1;
            this.lblCodPer.Text = "Codigo Perfil";
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Location = new System.Drawing.Point(38, 122);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(83, 13);
            this.lblNomUser.TabIndex = 2;
            this.lblNomUser.Text = "Nombre Usuario";
            // 
            // lblPaswUser
            // 
            this.lblPaswUser.AutoSize = true;
            this.lblPaswUser.Location = new System.Drawing.Point(377, 207);
            this.lblPaswUser.Name = "lblPaswUser";
            this.lblPaswUser.Size = new System.Drawing.Size(61, 13);
            this.lblPaswUser.TabIndex = 3;
            this.lblPaswUser.Text = "Contraseña";
            // 
            // lblEstadoUser
            // 
            this.lblEstadoUser.AutoSize = true;
            this.lblEstadoUser.Location = new System.Drawing.Point(377, 86);
            this.lblEstadoUser.Name = "lblEstadoUser";
            this.lblEstadoUser.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoUser.TabIndex = 4;
            this.lblEstadoUser.Text = "Estado";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(103, 82);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(30, 20);
            this.txtIDUsuario.TabIndex = 1;
            this.txtIDUsuario.Tag = "id_usuario";
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(221, 83);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(30, 20);
            this.txtCodPerfil.TabIndex = 2;
            this.txtCodPerfil.Tag = "codigo_perfil";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(139, 115);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtNomUsuario.TabIndex = 4;
            this.txtNomUsuario.Tag = "nombre_usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(480, 200);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 20);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.Tag = "";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(611, 80);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(26, 20);
            this.txtEstado.TabIndex = 22;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(44, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "usuario";
            this.navegador1.TabIndex = 10;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(377, 161);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(68, 13);
            this.lblAlias.TabIndex = 11;
            this.lblAlias.Text = "Alias Usuario";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(480, 158);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(157, 20);
            this.txtAlias.TabIndex = 8;
            this.txtAlias.Tag = "alias_usuario";
            // 
            // lbl1ApellidoUser
            // 
            this.lbl1ApellidoUser.AutoSize = true;
            this.lbl1ApellidoUser.Location = new System.Drawing.Point(38, 165);
            this.lbl1ApellidoUser.Name = "lbl1ApellidoUser";
            this.lbl1ApellidoUser.Size = new System.Drawing.Size(76, 13);
            this.lbl1ApellidoUser.TabIndex = 13;
            this.lbl1ApellidoUser.Text = "Primer Apellido";
            // 
            // txtPrimerAp
            // 
            this.txtPrimerAp.Location = new System.Drawing.Point(140, 158);
            this.txtPrimerAp.Name = "txtPrimerAp";
            this.txtPrimerAp.Size = new System.Drawing.Size(153, 20);
            this.txtPrimerAp.TabIndex = 5;
            this.txtPrimerAp.Tag = "primer_apellido";
            // 
            // lbltxt2Apellido
            // 
            this.lbltxt2Apellido.AutoSize = true;
            this.lbltxt2Apellido.Location = new System.Drawing.Point(38, 208);
            this.lbltxt2Apellido.Name = "lbltxt2Apellido";
            this.lbltxt2Apellido.Size = new System.Drawing.Size(90, 13);
            this.lbltxt2Apellido.TabIndex = 15;
            this.lbltxt2Apellido.Text = "Segundo Apellido";
            // 
            // txtSegundoAp
            // 
            this.txtSegundoAp.Location = new System.Drawing.Point(140, 200);
            this.txtSegundoAp.Name = "txtSegundoAp";
            this.txtSegundoAp.Size = new System.Drawing.Size(153, 20);
            this.txtSegundoAp.TabIndex = 6;
            this.txtSegundoAp.Tag = "segundo_apellido";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Descativado"});
            this.cbEstado.Location = new System.Drawing.Point(484, 80);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 3;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // lblDireccionUser
            // 
            this.lblDireccionUser.AutoSize = true;
            this.lblDireccionUser.Location = new System.Drawing.Point(377, 122);
            this.lblDireccionUser.Name = "lblDireccionUser";
            this.lblDireccionUser.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionUser.TabIndex = 18;
            this.lblDireccionUser.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(480, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(156, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Tag = "direccion";
            // 
            // lblfechcreauser
            // 
            this.lblfechcreauser.AutoSize = true;
            this.lblfechcreauser.Location = new System.Drawing.Point(37, 246);
            this.lblfechcreauser.Name = "lblfechcreauser";
            this.lblfechcreauser.Size = new System.Drawing.Size(78, 13);
            this.lblfechcreauser.TabIndex = 21;
            this.lblfechcreauser.Text = "fecha creación";
            // 
            // lblfecmodUser
            // 
            this.lblfecmodUser.AutoSize = true;
            this.lblfecmodUser.Location = new System.Drawing.Point(377, 248);
            this.lblfecmodUser.Name = "lblfecmodUser";
            this.lblfecmodUser.Size = new System.Drawing.Size(90, 13);
            this.lblfecmodUser.TabIndex = 22;
            this.lblfecmodUser.Text = "fecha modificaión";
            // 
            // txtfechcrea
            // 
            this.txtfechcrea.Location = new System.Drawing.Point(139, 241);
            this.txtfechcrea.Name = "txtfechcrea";
            this.txtfechcrea.Size = new System.Drawing.Size(153, 20);
            this.txtfechcrea.TabIndex = 10;
            this.txtfechcrea.Tag = "fecha_de_creacion";
            // 
            // txtfechmod
            // 
            this.txtfechmod.Location = new System.Drawing.Point(484, 241);
            this.txtfechmod.Name = "txtfechmod";
            this.txtfechmod.Size = new System.Drawing.Size(152, 20);
            this.txtfechmod.TabIndex = 11;
            this.txtfechmod.Tag = "fecha_de_modificacion";
            // 
            // txtEncriptar
            // 
            this.txtEncriptar.Location = new System.Drawing.Point(672, 180);
            this.txtEncriptar.Name = "txtEncriptar";
            this.txtEncriptar.Size = new System.Drawing.Size(46, 20);
            this.txtEncriptar.TabIndex = 29;
            this.txtEncriptar.Tag = "contrasena_usuario";
            this.txtEncriptar.TextChanged += new System.EventHandler(this.txtEncriptar_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "EN-US",
            "ES-CO",
            "JA-JP"});
            this.listBox1.Location = new System.Drawing.Point(668, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(50, 43);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(715, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 43);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Perfil";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(44, 278);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 175);
            this.tabControl1.TabIndex = 27;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.s);
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(6, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(581, 132);
            this.cuDataGridD1.STabla = "perfil";
            this.cuDataGridD1.TabIndex = 0;
            // 
            // wfUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 465);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtEncriptar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtfechmod);
            this.Controls.Add(this.txtfechcrea);
            this.Controls.Add(this.lblfecmodUser);
            this.Controls.Add(this.lblfechcreauser);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccionUser);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtSegundoAp);
            this.Controls.Add(this.lbltxt2Apellido);
            this.Controls.Add(this.txtPrimerAp);
            this.Controls.Add(this.lbl1ApellidoUser);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblEstadoUser);
            this.Controls.Add(this.lblPaswUser);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.lblCodPer);
            this.Controls.Add(this.lblIDusuario);
            this.Name = "wfUsuario";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.wfUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDusuario;
        private System.Windows.Forms.Label lblCodPer;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Label lblPaswUser;
        private System.Windows.Forms.Label lblEstadoUser;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtEstado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lbl1ApellidoUser;
        private System.Windows.Forms.TextBox txtPrimerAp;
        private System.Windows.Forms.Label lbltxt2Apellido;
        private System.Windows.Forms.TextBox txtSegundoAp;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblDireccionUser;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblfechcreauser;
        private System.Windows.Forms.Label lblfecmodUser;
        private System.Windows.Forms.TextBox txtfechcrea;
        private System.Windows.Forms.TextBox txtfechmod;
        private System.Windows.Forms.TextBox txtEncriptar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;

    }
}