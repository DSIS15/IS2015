namespace dll_seguridad.Presentacion
{
    partial class wfSubMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfSubMod));
            this.lblcodsubmod = new System.Windows.Forms.Label();
            this.lblcodmod = new System.Windows.Forms.Label();
            this.lblnomsubmod = new System.Windows.Forms.Label();
            this.lblnombrewf = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtIDSubMod = new System.Windows.Forms.TextBox();
            this.txtIDMod = new System.Windows.Forms.TextBox();
            this.txtNomSubMod = new System.Windows.Forms.TextBox();
            this.txtNomForm = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.lblfechcreacion = new System.Windows.Forms.Label();
            this.lblfechmodificacion = new System.Windows.Forms.Label();
            this.txtfecc = new System.Windows.Forms.TextBox();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.dgvmodulo = new dll_bitacora.Presentacion.cuDataGridD();
            this.SuspendLayout();
            // 
            // lblcodsubmod
            // 
            this.lblcodsubmod.AutoSize = true;
            this.lblcodsubmod.Location = new System.Drawing.Point(22, 100);
            this.lblcodsubmod.Name = "lblcodsubmod";
            this.lblcodsubmod.Size = new System.Drawing.Size(97, 13);
            this.lblcodsubmod.TabIndex = 0;
            this.lblcodsubmod.Text = "Código sub módulo";
            // 
            // lblcodmod
            // 
            this.lblcodmod.AutoSize = true;
            this.lblcodmod.Location = new System.Drawing.Point(195, 100);
            this.lblcodmod.Name = "lblcodmod";
            this.lblcodmod.Size = new System.Drawing.Size(77, 13);
            this.lblcodmod.TabIndex = 1;
            this.lblcodmod.Text = "Código módulo";
            // 
            // lblnomsubmod
            // 
            this.lblnomsubmod.AutoSize = true;
            this.lblnomsubmod.Location = new System.Drawing.Point(22, 137);
            this.lblnomsubmod.Name = "lblnomsubmod";
            this.lblnomsubmod.Size = new System.Drawing.Size(101, 13);
            this.lblnomsubmod.TabIndex = 2;
            this.lblnomsubmod.Text = "Nombre sub módulo";
            // 
            // lblnombrewf
            // 
            this.lblnombrewf.AutoSize = true;
            this.lblnombrewf.Location = new System.Drawing.Point(312, 136);
            this.lblnombrewf.Name = "lblnombrewf";
            this.lblnombrewf.Size = new System.Drawing.Size(92, 13);
            this.lblnombrewf.TabIndex = 3;
            this.lblnombrewf.Text = "Nombre formulario";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(367, 101);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "Estado";
            // 
            // txtIDSubMod
            // 
            this.txtIDSubMod.Location = new System.Drawing.Point(123, 93);
            this.txtIDSubMod.Name = "txtIDSubMod";
            this.txtIDSubMod.Size = new System.Drawing.Size(28, 20);
            this.txtIDSubMod.TabIndex = 1;
            this.txtIDSubMod.Tag = "id_submodulo";
            // 
            // txtIDMod
            // 
            this.txtIDMod.Location = new System.Drawing.Point(288, 93);
            this.txtIDMod.Name = "txtIDMod";
            this.txtIDMod.Size = new System.Drawing.Size(28, 20);
            this.txtIDMod.TabIndex = 2;
            this.txtIDMod.Tag = "id_modulo";
            // 
            // txtNomSubMod
            // 
            this.txtNomSubMod.Location = new System.Drawing.Point(142, 129);
            this.txtNomSubMod.Name = "txtNomSubMod";
            this.txtNomSubMod.Size = new System.Drawing.Size(100, 20);
            this.txtNomSubMod.TabIndex = 4;
            this.txtNomSubMod.Tag = "nombre_submodulo";
            // 
            // txtNomForm
            // 
            this.txtNomForm.Location = new System.Drawing.Point(420, 128);
            this.txtNomForm.Name = "txtNomForm";
            this.txtNomForm.Size = new System.Drawing.Size(100, 20);
            this.txtNomForm.TabIndex = 5;
            this.txtNomForm.Tag = "nombre_form";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(524, 94);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(21, 20);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 22);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "sub_modulo";
            this.navegador1.TabIndex = 9;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.navegador1_btnBuscar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbestado.Location = new System.Drawing.Point(420, 92);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(98, 21);
            this.cbestado.TabIndex = 3;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // lblfechcreacion
            // 
            this.lblfechcreacion.AutoSize = true;
            this.lblfechcreacion.Location = new System.Drawing.Point(25, 168);
            this.lblfechcreacion.Name = "lblfechcreacion";
            this.lblfechcreacion.Size = new System.Drawing.Size(81, 13);
            this.lblfechcreacion.TabIndex = 11;
            this.lblfechcreacion.Text = "Fecha creación";
            // 
            // lblfechmodificacion
            // 
            this.lblfechmodificacion.AutoSize = true;
            this.lblfechmodificacion.Location = new System.Drawing.Point(315, 167);
            this.lblfechmodificacion.Name = "lblfechmodificacion";
            this.lblfechmodificacion.Size = new System.Drawing.Size(99, 13);
            this.lblfechmodificacion.TabIndex = 12;
            this.lblfechmodificacion.Text = "Fecha modificación";
            // 
            // txtfecc
            // 
            this.txtfecc.Location = new System.Drawing.Point(142, 168);
            this.txtfecc.Name = "txtfecc";
            this.txtfecc.Size = new System.Drawing.Size(100, 20);
            this.txtfecc.TabIndex = 13;
            this.txtfecc.Tag = "fecha_creacion";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(420, 160);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 14;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // dgvmodulo
            // 
            this.dgvmodulo.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("dgvmodulo.AlDatosEntrada")));
            this.dgvmodulo.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("dgvmodulo.alObtenerCampos")));
            this.dgvmodulo.AutoSize = true;
            this.dgvmodulo.ICampo = 0;
            this.dgvmodulo.Location = new System.Drawing.Point(12, 208);
            this.dgvmodulo.Name = "dgvmodulo";
            this.dgvmodulo.Size = new System.Drawing.Size(598, 157);
            this.dgvmodulo.STabla = "modulo";
            this.dgvmodulo.TabIndex = 15;
            this.dgvmodulo.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmodulo_sdgv_CellClick);
            // 
            // wfSubMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 377);
            this.Controls.Add(this.dgvmodulo);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.txtfecc);
            this.Controls.Add(this.lblfechmodificacion);
            this.Controls.Add(this.lblfechcreacion);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNomForm);
            this.Controls.Add(this.txtNomSubMod);
            this.Controls.Add(this.txtIDMod);
            this.Controls.Add(this.txtIDSubMod);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblnombrewf);
            this.Controls.Add(this.lblnomsubmod);
            this.Controls.Add(this.lblcodmod);
            this.Controls.Add(this.lblcodsubmod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfSubMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Modulo";
            this.Load += new System.EventHandler(this.wfSubMod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodsubmod;
        private System.Windows.Forms.Label lblcodmod;
        private System.Windows.Forms.Label lblnomsubmod;
        private System.Windows.Forms.Label lblnombrewf;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtIDSubMod;
        private System.Windows.Forms.TextBox txtIDMod;
        private System.Windows.Forms.TextBox txtNomSubMod;
        private System.Windows.Forms.TextBox txtNomForm;
        private System.Windows.Forms.TextBox txtEstado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Label lblfechcreacion;
        private System.Windows.Forms.Label lblfechmodificacion;
        private System.Windows.Forms.TextBox txtfecc;
        private System.Windows.Forms.TextBox txtfecm;
        private dll_bitacora.Presentacion.cuDataGridD dgvmodulo;
    }
}