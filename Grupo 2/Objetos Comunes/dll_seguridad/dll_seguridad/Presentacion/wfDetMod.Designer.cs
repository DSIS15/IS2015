namespace dll_seguridad.Presentacion
{
    partial class wfDetMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetMod));
            this.lbliddetmod = new System.Windows.Forms.Label();
            this.txtIDDetMod = new System.Windows.Forms.TextBox();
            this.lblcodmod = new System.Windows.Forms.Label();
            this.txtIDModulo = new System.Windows.Forms.TextBox();
            this.lblcodperfil = new System.Windows.Forms.Label();
            this.txtCodPerf = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbcdetmodulo = new System.Windows.Forms.TabControl();
            this.tbpmodulo = new System.Windows.Forms.TabPage();
            this.dgvmodulo = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbpperfil = new System.Windows.Forms.TabPage();
            this.dgvperfil = new dll_bitacora.Presentacion.cuDataGridD();
            this.lblfechcreacion = new System.Windows.Forms.Label();
            this.txtfecC = new System.Windows.Forms.TextBox();
            this.lblfechmodificacion = new System.Windows.Forms.Label();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.tbcdetmodulo.SuspendLayout();
            this.tbpmodulo.SuspendLayout();
            this.tbpperfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbliddetmod
            // 
            this.lbliddetmod.AutoSize = true;
            this.lbliddetmod.Location = new System.Drawing.Point(45, 93);
            this.lbliddetmod.Name = "lbliddetmod";
            this.lbliddetmod.Size = new System.Drawing.Size(40, 13);
            this.lbliddetmod.TabIndex = 0;
            this.lbliddetmod.Text = "Código";
            // 
            // txtIDDetMod
            // 
            this.txtIDDetMod.Location = new System.Drawing.Point(91, 86);
            this.txtIDDetMod.Name = "txtIDDetMod";
            this.txtIDDetMod.Size = new System.Drawing.Size(27, 20);
            this.txtIDDetMod.TabIndex = 1;
            this.txtIDDetMod.Tag = "id_detmodulo";
            // 
            // lblcodmod
            // 
            this.lblcodmod.AutoSize = true;
            this.lblcodmod.Location = new System.Drawing.Point(145, 93);
            this.lblcodmod.Name = "lblcodmod";
            this.lblcodmod.Size = new System.Drawing.Size(77, 13);
            this.lblcodmod.TabIndex = 2;
            this.lblcodmod.Text = "Codigo módulo";
            // 
            // txtIDModulo
            // 
            this.txtIDModulo.Location = new System.Drawing.Point(229, 86);
            this.txtIDModulo.Name = "txtIDModulo";
            this.txtIDModulo.Size = new System.Drawing.Size(27, 20);
            this.txtIDModulo.TabIndex = 3;
            this.txtIDModulo.Tag = "id_modulo";
            // 
            // lblcodperfil
            // 
            this.lblcodperfil.AutoSize = true;
            this.lblcodperfil.Location = new System.Drawing.Point(281, 93);
            this.lblcodperfil.Name = "lblcodperfil";
            this.lblcodperfil.Size = new System.Drawing.Size(65, 13);
            this.lblcodperfil.TabIndex = 4;
            this.lblcodperfil.Text = "Código perfil";
            // 
            // txtCodPerf
            // 
            this.txtCodPerf.Location = new System.Drawing.Point(353, 86);
            this.txtCodPerf.Name = "txtCodPerf";
            this.txtCodPerf.Size = new System.Drawing.Size(27, 20);
            this.txtCodPerf.TabIndex = 5;
            this.txtCodPerf.Tag = "codigo_perfil";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(416, 93);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 6;
            this.lblestado.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(567, 86);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(27, 20);
            this.txtestado.TabIndex = 7;
            this.txtestado.Tag = "estado";
            this.txtestado.Visible = false;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(28, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "detalle_modulo";
            this.navegador1.TabIndex = 8;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.navegador1_btnBuscar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(462, 85);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(99, 21);
            this.cbEstado.TabIndex = 9;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // tbcdetmodulo
            // 
            this.tbcdetmodulo.Controls.Add(this.tbpmodulo);
            this.tbcdetmodulo.Controls.Add(this.tbpperfil);
            this.tbcdetmodulo.Location = new System.Drawing.Point(28, 164);
            this.tbcdetmodulo.Name = "tbcdetmodulo";
            this.tbcdetmodulo.SelectedIndex = 0;
            this.tbcdetmodulo.Size = new System.Drawing.Size(612, 180);
            this.tbcdetmodulo.TabIndex = 10;
            // 
            // tbpmodulo
            // 
            this.tbpmodulo.Controls.Add(this.dgvmodulo);
            this.tbpmodulo.Location = new System.Drawing.Point(4, 22);
            this.tbpmodulo.Name = "tbpmodulo";
            this.tbpmodulo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpmodulo.Size = new System.Drawing.Size(604, 154);
            this.tbpmodulo.TabIndex = 0;
            this.tbpmodulo.Text = "Modulo";
            this.tbpmodulo.UseVisualStyleBackColor = true;
            // 
            // dgvmodulo
            // 
            this.dgvmodulo.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvmodulo.AlDatosEntrada")));
            this.dgvmodulo.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvmodulo.alObtenerCampos")));
            this.dgvmodulo.AutoSize = true;
            this.dgvmodulo.ICampo = 0;
            this.dgvmodulo.Location = new System.Drawing.Point(3, 3);
            this.dgvmodulo.Name = "dgvmodulo";
            this.dgvmodulo.Size = new System.Drawing.Size(598, 151);
            this.dgvmodulo.STabla = "modulo";
            this.dgvmodulo.TabIndex = 0;
            this.dgvmodulo.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tbpperfil
            // 
            this.tbpperfil.Controls.Add(this.dgvperfil);
            this.tbpperfil.Location = new System.Drawing.Point(4, 22);
            this.tbpperfil.Name = "tbpperfil";
            this.tbpperfil.Padding = new System.Windows.Forms.Padding(3);
            this.tbpperfil.Size = new System.Drawing.Size(604, 154);
            this.tbpperfil.TabIndex = 1;
            this.tbpperfil.Text = "Perfil";
            this.tbpperfil.UseVisualStyleBackColor = true;
            // 
            // dgvperfil
            // 
            this.dgvperfil.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvperfil.AlDatosEntrada")));
            this.dgvperfil.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvperfil.alObtenerCampos")));
            this.dgvperfil.AutoSize = true;
            this.dgvperfil.ICampo = 0;
            this.dgvperfil.Location = new System.Drawing.Point(0, 4);
            this.dgvperfil.Name = "dgvperfil";
            this.dgvperfil.Size = new System.Drawing.Size(598, 147);
            this.dgvperfil.STabla = "perfil";
            this.dgvperfil.TabIndex = 0;
            this.dgvperfil.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            this.dgvperfil.Load += new System.EventHandler(this.cuDataGridD2_Load);
            // 
            // lblfechcreacion
            // 
            this.lblfechcreacion.AutoSize = true;
            this.lblfechcreacion.Location = new System.Drawing.Point(45, 134);
            this.lblfechcreacion.Name = "lblfechcreacion";
            this.lblfechcreacion.Size = new System.Drawing.Size(81, 13);
            this.lblfechcreacion.TabIndex = 11;
            this.lblfechcreacion.Text = "Fecha creación";
            // 
            // txtfecC
            // 
            this.txtfecC.Location = new System.Drawing.Point(133, 126);
            this.txtfecC.Name = "txtfecC";
            this.txtfecC.Size = new System.Drawing.Size(100, 20);
            this.txtfecC.TabIndex = 12;
            this.txtfecC.Tag = "fecha_creacion";
            // 
            // lblfechmodificacion
            // 
            this.lblfechmodificacion.AutoSize = true;
            this.lblfechmodificacion.Location = new System.Drawing.Point(311, 133);
            this.lblfechmodificacion.Name = "lblfechmodificacion";
            this.lblfechmodificacion.Size = new System.Drawing.Size(99, 13);
            this.lblfechmodificacion.TabIndex = 13;
            this.lblfechmodificacion.Text = "Fecha modificación";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(419, 125);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 14;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // wfDetMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 369);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.lblfechmodificacion);
            this.Controls.Add(this.txtfecC);
            this.Controls.Add(this.lblfechcreacion);
            this.Controls.Add(this.tbcdetmodulo);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtCodPerf);
            this.Controls.Add(this.lblcodperfil);
            this.Controls.Add(this.txtIDModulo);
            this.Controls.Add(this.lblcodmod);
            this.Controls.Add(this.txtIDDetMod);
            this.Controls.Add(this.lbliddetmod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDetMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Modulo";
            this.Load += new System.EventHandler(this.wfDetMod_Load);
            this.tbcdetmodulo.ResumeLayout(false);
            this.tbpmodulo.ResumeLayout(false);
            this.tbpmodulo.PerformLayout();
            this.tbpperfil.ResumeLayout(false);
            this.tbpperfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbliddetmod;
        private System.Windows.Forms.TextBox txtIDDetMod;
        private System.Windows.Forms.Label lblcodmod;
        private System.Windows.Forms.TextBox txtIDModulo;
        private System.Windows.Forms.Label lblcodperfil;
        private System.Windows.Forms.TextBox txtCodPerf;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TabControl tbcdetmodulo;
        private System.Windows.Forms.TabPage tbpmodulo;
        private System.Windows.Forms.TabPage tbpperfil;
        private dll_bitacora.Presentacion.cuDataGridD dgvmodulo;
        private dll_bitacora.Presentacion.cuDataGridD dgvperfil;
        private System.Windows.Forms.Label lblfechcreacion;
        private System.Windows.Forms.TextBox txtfecC;
        private System.Windows.Forms.Label lblfechmodificacion;
        private System.Windows.Forms.TextBox txtfecm;
    }
}