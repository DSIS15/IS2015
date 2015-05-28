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
            this.lblcodusuario = new System.Windows.Forms.Label();
            this.lblcodperfil = new System.Windows.Forms.Label();
            this.lblnombreusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblalias = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lbl1apellido = new System.Windows.Forms.Label();
            this.txtPrimerAp = new System.Windows.Forms.TextBox();
            this.lblt2apellido = new System.Windows.Forms.Label();
            this.txtSegundoAp = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblfechcreacion = new System.Windows.Forms.Label();
            this.lblfechmodificacion = new System.Windows.Forms.Label();
            this.txtfechcrea = new System.Windows.Forms.TextBox();
            this.txtfechmod = new System.Windows.Forms.TextBox();
            this.txtEncriptar = new System.Windows.Forms.TextBox();
            this.dgvperfil = new dll_bitacora.Presentacion.cuDataGridD();
            this.SuspendLayout();
            // 
            // lblcodusuario
            // 
            this.lblcodusuario.AutoSize = true;
            this.lblcodusuario.Location = new System.Drawing.Point(41, 90);
            this.lblcodusuario.Name = "lblcodusuario";
            this.lblcodusuario.Size = new System.Drawing.Size(77, 13);
            this.lblcodusuario.TabIndex = 0;
            this.lblcodusuario.Text = "Código usuario";
            // 
            // lblcodperfil
            // 
            this.lblcodperfil.AutoSize = true;
            this.lblcodperfil.Location = new System.Drawing.Point(253, 91);
            this.lblcodperfil.Name = "lblcodperfil";
            this.lblcodperfil.Size = new System.Drawing.Size(65, 13);
            this.lblcodperfil.TabIndex = 1;
            this.lblcodperfil.Text = "Codigo perfil";
            // 
            // lblnombreusuario
            // 
            this.lblnombreusuario.AutoSize = true;
            this.lblnombreusuario.Location = new System.Drawing.Point(41, 126);
            this.lblnombreusuario.Name = "lblnombreusuario";
            this.lblnombreusuario.Size = new System.Drawing.Size(81, 13);
            this.lblnombreusuario.TabIndex = 2;
            this.lblnombreusuario.Text = "Nombre usuario";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(375, 207);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 3;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(425, 90);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "Estado";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(139, 85);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(30, 20);
            this.txtIDUsuario.TabIndex = 1;
            this.txtIDUsuario.Tag = "id_usuario";
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(340, 86);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(30, 20);
            this.txtCodPerfil.TabIndex = 2;
            this.txtCodPerfil.Tag = "codigo_perfil";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(139, 119);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtNomUsuario.TabIndex = 3;
            this.txtNomUsuario.Tag = "nombre_usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(478, 200);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 20);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Tag = "";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(622, 84);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(26, 20);
            this.txtEstado.TabIndex = 22;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
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
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.navegador1_btnBuscar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // lblalias
            // 
            this.lblalias.AutoSize = true;
            this.lblalias.Location = new System.Drawing.Point(375, 122);
            this.lblalias.Name = "lblalias";
            this.lblalias.Size = new System.Drawing.Size(66, 13);
            this.lblalias.TabIndex = 11;
            this.lblalias.Text = "Alias usuario";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(478, 119);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(157, 20);
            this.txtAlias.TabIndex = 6;
            this.txtAlias.Tag = "alias_usuario";
            // 
            // lbl1apellido
            // 
            this.lbl1apellido.AutoSize = true;
            this.lbl1apellido.Location = new System.Drawing.Point(41, 165);
            this.lbl1apellido.Name = "lbl1apellido";
            this.lbl1apellido.Size = new System.Drawing.Size(75, 13);
            this.lbl1apellido.TabIndex = 13;
            this.lbl1apellido.Text = "Primer apellido";
            // 
            // txtPrimerAp
            // 
            this.txtPrimerAp.Location = new System.Drawing.Point(140, 158);
            this.txtPrimerAp.Name = "txtPrimerAp";
            this.txtPrimerAp.Size = new System.Drawing.Size(153, 20);
            this.txtPrimerAp.TabIndex = 4;
            this.txtPrimerAp.Tag = "primer_apellido";
            // 
            // lblt2apellido
            // 
            this.lblt2apellido.AutoSize = true;
            this.lblt2apellido.Location = new System.Drawing.Point(41, 207);
            this.lblt2apellido.Name = "lblt2apellido";
            this.lblt2apellido.Size = new System.Drawing.Size(89, 13);
            this.lblt2apellido.TabIndex = 15;
            this.lblt2apellido.Text = "Segundo apellido";
            // 
            // txtSegundoAp
            // 
            this.txtSegundoAp.Location = new System.Drawing.Point(140, 200);
            this.txtSegundoAp.Name = "txtSegundoAp";
            this.txtSegundoAp.Size = new System.Drawing.Size(153, 20);
            this.txtSegundoAp.TabIndex = 5;
            this.txtSegundoAp.Tag = "segundo_apellido";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Descativado"});
            this.cbEstado.Location = new System.Drawing.Point(495, 85);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 3;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(375, 165);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(52, 13);
            this.lbldireccion.TabIndex = 18;
            this.lbldireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(478, 158);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(157, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Tag = "direccion";
            // 
            // lblfechcreacion
            // 
            this.lblfechcreacion.AutoSize = true;
            this.lblfechcreacion.Location = new System.Drawing.Point(41, 248);
            this.lblfechcreacion.Name = "lblfechcreacion";
            this.lblfechcreacion.Size = new System.Drawing.Size(81, 13);
            this.lblfechcreacion.TabIndex = 21;
            this.lblfechcreacion.Text = "Fecha creación";
            // 
            // lblfechmodificacion
            // 
            this.lblfechmodificacion.AutoSize = true;
            this.lblfechmodificacion.Location = new System.Drawing.Point(375, 248);
            this.lblfechmodificacion.Name = "lblfechmodificacion";
            this.lblfechmodificacion.Size = new System.Drawing.Size(90, 13);
            this.lblfechmodificacion.TabIndex = 22;
            this.lblfechmodificacion.Text = "fecha modificaión";
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
            this.txtfechmod.Location = new System.Drawing.Point(478, 239);
            this.txtfechmod.Name = "txtfechmod";
            this.txtfechmod.Size = new System.Drawing.Size(157, 20);
            this.txtfechmod.TabIndex = 11;
            this.txtfechmod.Tag = "fecha_de_modificacion";
            // 
            // txtEncriptar
            // 
            this.txtEncriptar.Location = new System.Drawing.Point(656, 200);
            this.txtEncriptar.Name = "txtEncriptar";
            this.txtEncriptar.Size = new System.Drawing.Size(46, 20);
            this.txtEncriptar.TabIndex = 29;
            this.txtEncriptar.Tag = "contrasena_usuario";
            this.txtEncriptar.TextChanged += new System.EventHandler(this.txtEncriptar_TextChanged);
            // 
            // dgvperfil
            // 
            this.dgvperfil.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvperfil.AlDatosEntrada")));
            this.dgvperfil.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvperfil.alObtenerCampos")));
            this.dgvperfil.AutoSize = true;
            this.dgvperfil.ICampo = 0;
            this.dgvperfil.Location = new System.Drawing.Point(32, 285);
            this.dgvperfil.Name = "dgvperfil";
            this.dgvperfil.Size = new System.Drawing.Size(670, 178);
            this.dgvperfil.STabla = "perfil";
            this.dgvperfil.TabIndex = 0;
            this.dgvperfil.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick_1);
            // 
            // wfUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 465);
            this.Controls.Add(this.dgvperfil);
            this.Controls.Add(this.txtEncriptar);
            this.Controls.Add(this.txtfechmod);
            this.Controls.Add(this.txtfechcrea);
            this.Controls.Add(this.lblfechmodificacion);
            this.Controls.Add(this.lblfechcreacion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtSegundoAp);
            this.Controls.Add(this.lblt2apellido);
            this.Controls.Add(this.txtPrimerAp);
            this.Controls.Add(this.lbl1apellido);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblalias);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblnombreusuario);
            this.Controls.Add(this.lblcodperfil);
            this.Controls.Add(this.lblcodusuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.wfUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodusuario;
        private System.Windows.Forms.Label lblcodperfil;
        private System.Windows.Forms.Label lblnombreusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtEstado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblalias;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lbl1apellido;
        private System.Windows.Forms.TextBox txtPrimerAp;
        private System.Windows.Forms.Label lblt2apellido;
        private System.Windows.Forms.TextBox txtSegundoAp;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblfechcreacion;
        private System.Windows.Forms.Label lblfechmodificacion;
        private System.Windows.Forms.TextBox txtfechcrea;
        private System.Windows.Forms.TextBox txtfechmod;
        private System.Windows.Forms.TextBox txtEncriptar;
        private dll_bitacora.Presentacion.cuDataGridD dgvperfil;

    }
}