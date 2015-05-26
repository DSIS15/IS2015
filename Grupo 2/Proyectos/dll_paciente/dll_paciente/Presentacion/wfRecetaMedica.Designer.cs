namespace dll_paciente.Presentacion
{
    partial class wfRecetaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfRecetaMedica));
            this.lblrecetamedica = new System.Windows.Forms.Label();
            this.lblmedico = new System.Windows.Forms.Label();
            this.lblidpaciente = new System.Windows.Forms.Label();
            this.lblnombremedicamento = new System.Windows.Forms.Label();
            this.lblcatmedicamento = new System.Windows.Forms.Label();
            this.lblviadeadmin = new System.Windows.Forms.Label();
            this.lbldosis = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.tbcrecetamedica = new System.Windows.Forms.TabControl();
            this.tbppaciente = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbcmedico = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.navegador1 = new Navegador.Navegador();
            this.txtid_recetamedica = new System.Windows.Forms.TextBox();
            this.txtnom_med = new System.Windows.Forms.TextBox();
            this.txtcatmedico = new System.Windows.Forms.TextBox();
            this.txtid_medico = new System.Windows.Forms.TextBox();
            this.txtid_pacientes = new System.Windows.Forms.TextBox();
            this.txtvia_de_administracion = new System.Windows.Forms.TextBox();
            this.txtdosis = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cbocatmedico = new System.Windows.Forms.ComboBox();
            this.cbovia_de_administracion = new System.Windows.Forms.ComboBox();
            this.tbcrecetamedica.SuspendLayout();
            this.tbppaciente.SuspendLayout();
            this.tbcmedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblrecetamedica
            // 
            this.lblrecetamedica.AutoSize = true;
            this.lblrecetamedica.Location = new System.Drawing.Point(60, 92);
            this.lblrecetamedica.Name = "lblrecetamedica";
            this.lblrecetamedica.Size = new System.Drawing.Size(91, 13);
            this.lblrecetamedica.TabIndex = 0;
            this.lblrecetamedica.Text = "ID receta medica:";
            // 
            // lblmedico
            // 
            this.lblmedico.AutoSize = true;
            this.lblmedico.Location = new System.Drawing.Point(549, 92);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(58, 13);
            this.lblmedico.TabIndex = 1;
            this.lblmedico.Text = "ID médico:";
            // 
            // lblidpaciente
            // 
            this.lblidpaciente.AutoSize = true;
            this.lblidpaciente.Location = new System.Drawing.Point(366, 92);
            this.lblidpaciente.Name = "lblidpaciente";
            this.lblidpaciente.Size = new System.Drawing.Size(70, 13);
            this.lblidpaciente.TabIndex = 2;
            this.lblidpaciente.Text = "ID pacientes:";
            // 
            // lblnombremedicamento
            // 
            this.lblnombremedicamento.AutoSize = true;
            this.lblnombremedicamento.Location = new System.Drawing.Point(60, 138);
            this.lblnombremedicamento.Name = "lblnombremedicamento";
            this.lblnombremedicamento.Size = new System.Drawing.Size(113, 13);
            this.lblnombremedicamento.TabIndex = 3;
            this.lblnombremedicamento.Text = "Nombre medicamento:";
            // 
            // lblcatmedicamento
            // 
            this.lblcatmedicamento.AutoSize = true;
            this.lblcatmedicamento.Location = new System.Drawing.Point(61, 185);
            this.lblcatmedicamento.Name = "lblcatmedicamento";
            this.lblcatmedicamento.Size = new System.Drawing.Size(94, 13);
            this.lblcatmedicamento.TabIndex = 4;
            this.lblcatmedicamento.Text = "Categoría médico:";
            // 
            // lblviadeadmin
            // 
            this.lblviadeadmin.AutoSize = true;
            this.lblviadeadmin.Location = new System.Drawing.Point(549, 137);
            this.lblviadeadmin.Name = "lblviadeadmin";
            this.lblviadeadmin.Size = new System.Drawing.Size(108, 13);
            this.lblviadeadmin.TabIndex = 5;
            this.lblviadeadmin.Text = "Via de admnistración:";
            // 
            // lbldosis
            // 
            this.lbldosis.AutoSize = true;
            this.lbldosis.Location = new System.Drawing.Point(366, 138);
            this.lbldosis.Name = "lbldosis";
            this.lbldosis.Size = new System.Drawing.Size(36, 13);
            this.lbldosis.TabIndex = 6;
            this.lbldosis.Text = "Dosis:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(366, 185);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 7;
            this.lblestado.Text = "Estado:";
            // 
            // tbcrecetamedica
            // 
            this.tbcrecetamedica.Controls.Add(this.tbppaciente);
            this.tbcrecetamedica.Controls.Add(this.tbcmedico);
            this.tbcrecetamedica.Location = new System.Drawing.Point(63, 229);
            this.tbcrecetamedica.Name = "tbcrecetamedica";
            this.tbcrecetamedica.SelectedIndex = 0;
            this.tbcrecetamedica.Size = new System.Drawing.Size(734, 243);
            this.tbcrecetamedica.TabIndex = 8;
            // 
            // tbppaciente
            // 
            this.tbppaciente.Controls.Add(this.cuDataGridD1);
            this.tbppaciente.Location = new System.Drawing.Point(4, 22);
            this.tbppaciente.Name = "tbppaciente";
            this.tbppaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbppaciente.Size = new System.Drawing.Size(726, 217);
            this.tbppaciente.TabIndex = 0;
            this.tbppaciente.Text = "Paciente";
            this.tbppaciente.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.alObtenerCampos")));
            this.cuDataGridD1.AutoSize = true;
            this.cuDataGridD1.ICampo = 0;
            this.cuDataGridD1.Location = new System.Drawing.Point(6, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.Size = new System.Drawing.Size(714, 215);
            this.cuDataGridD1.STabla = "paciente";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tbcmedico
            // 
            this.tbcmedico.Controls.Add(this.cuDataGridD2);
            this.tbcmedico.Location = new System.Drawing.Point(4, 22);
            this.tbcmedico.Name = "tbcmedico";
            this.tbcmedico.Padding = new System.Windows.Forms.Padding(3);
            this.tbcmedico.Size = new System.Drawing.Size(726, 217);
            this.tbcmedico.TabIndex = 1;
            this.tbcmedico.Text = "Médico";
            this.tbcmedico.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.alObtenerCampos")));
            this.cuDataGridD2.AutoSize = true;
            this.cuDataGridD2.ICampo = 0;
            this.cuDataGridD2.Location = new System.Drawing.Point(6, 6);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.Size = new System.Drawing.Size(717, 215);
            this.cuDataGridD2.STabla = "medico";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(112, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "receta_medica";
            this.navegador1.TabIndex = 9;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // txtid_recetamedica
            // 
            this.txtid_recetamedica.Location = new System.Drawing.Point(180, 89);
            this.txtid_recetamedica.Name = "txtid_recetamedica";
            this.txtid_recetamedica.Size = new System.Drawing.Size(55, 20);
            this.txtid_recetamedica.TabIndex = 10;
            this.txtid_recetamedica.Tag = "id_recetamedica";
            this.txtid_recetamedica.TextChanged += new System.EventHandler(this.txtid_recetamedica_TextChanged);
            // 
            // txtnom_med
            // 
            this.txtnom_med.Location = new System.Drawing.Point(180, 130);
            this.txtnom_med.Name = "txtnom_med";
            this.txtnom_med.Size = new System.Drawing.Size(168, 20);
            this.txtnom_med.TabIndex = 11;
            this.txtnom_med.Tag = "nom_med";
            // 
            // txtcatmedico
            // 
            this.txtcatmedico.Location = new System.Drawing.Point(180, 203);
            this.txtcatmedico.Name = "txtcatmedico";
            this.txtcatmedico.Size = new System.Drawing.Size(168, 20);
            this.txtcatmedico.TabIndex = 12;
            this.txtcatmedico.Tag = "categoria_med";
            this.txtcatmedico.Visible = false;
            this.txtcatmedico.TextChanged += new System.EventHandler(this.txtcatmedico_TextChanged);
            // 
            // txtid_medico
            // 
            this.txtid_medico.Location = new System.Drawing.Point(664, 85);
            this.txtid_medico.Name = "txtid_medico";
            this.txtid_medico.Size = new System.Drawing.Size(61, 20);
            this.txtid_medico.TabIndex = 13;
            this.txtid_medico.Tag = "id_medico";
            // 
            // txtid_pacientes
            // 
            this.txtid_pacientes.Location = new System.Drawing.Point(442, 89);
            this.txtid_pacientes.Name = "txtid_pacientes";
            this.txtid_pacientes.Size = new System.Drawing.Size(66, 20);
            this.txtid_pacientes.TabIndex = 14;
            this.txtid_pacientes.Tag = "id_pacientes";
            // 
            // txtvia_de_administracion
            // 
            this.txtvia_de_administracion.Location = new System.Drawing.Point(664, 157);
            this.txtvia_de_administracion.Name = "txtvia_de_administracion";
            this.txtvia_de_administracion.Size = new System.Drawing.Size(133, 20);
            this.txtvia_de_administracion.TabIndex = 15;
            this.txtvia_de_administracion.Tag = "via_de_administracion";
            this.txtvia_de_administracion.Visible = false;
            this.txtvia_de_administracion.TextChanged += new System.EventHandler(this.txtvia_de_administracion_TextChanged);
            // 
            // txtdosis
            // 
            this.txtdosis.Location = new System.Drawing.Point(442, 130);
            this.txtdosis.Name = "txtdosis";
            this.txtdosis.Size = new System.Drawing.Size(100, 20);
            this.txtdosis.TabIndex = 16;
            this.txtdosis.Tag = "dosis";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(552, 177);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(51, 20);
            this.txtestado.TabIndex = 17;
            this.txtestado.Tag = "estado";
            this.txtestado.Visible = false;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(442, 177);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(100, 21);
            this.cboEstado.TabIndex = 18;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbocatmedico
            // 
            this.cbocatmedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocatmedico.FormattingEnabled = true;
            this.cbocatmedico.Items.AddRange(new object[] {
            "Cardiólogo",
            "Cirujano",
            "Ginecólogo",
            "Otorrinolarincólogo",
            "Traumatólogo"});
            this.cbocatmedico.Location = new System.Drawing.Point(180, 177);
            this.cbocatmedico.Name = "cbocatmedico";
            this.cbocatmedico.Size = new System.Drawing.Size(168, 21);
            this.cbocatmedico.TabIndex = 19;
            this.cbocatmedico.SelectedIndexChanged += new System.EventHandler(this.cbocatmedico_SelectedIndexChanged);
            // 
            // cbovia_de_administracion
            // 
            this.cbovia_de_administracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovia_de_administracion.FormattingEnabled = true;
            this.cbovia_de_administracion.Items.AddRange(new object[] {
            "Oral",
            "Ampolla",
            "Inyectado"});
            this.cbovia_de_administracion.Location = new System.Drawing.Point(664, 130);
            this.cbovia_de_administracion.Name = "cbovia_de_administracion";
            this.cbovia_de_administracion.Size = new System.Drawing.Size(133, 21);
            this.cbovia_de_administracion.TabIndex = 20;
            this.cbovia_de_administracion.Tag = "";
            this.cbovia_de_administracion.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // wfRecetaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 475);
            this.Controls.Add(this.cbovia_de_administracion);
            this.Controls.Add(this.cbocatmedico);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtdosis);
            this.Controls.Add(this.txtvia_de_administracion);
            this.Controls.Add(this.txtid_pacientes);
            this.Controls.Add(this.txtid_medico);
            this.Controls.Add(this.txtcatmedico);
            this.Controls.Add(this.txtnom_med);
            this.Controls.Add(this.txtid_recetamedica);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.tbcrecetamedica);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lbldosis);
            this.Controls.Add(this.lblviadeadmin);
            this.Controls.Add(this.lblcatmedicamento);
            this.Controls.Add(this.lblnombremedicamento);
            this.Controls.Add(this.lblidpaciente);
            this.Controls.Add(this.lblmedico);
            this.Controls.Add(this.lblrecetamedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfRecetaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receta Medica";
            this.Load += new System.EventHandler(this.wfRecetaMedica_Load);
            this.tbcrecetamedica.ResumeLayout(false);
            this.tbppaciente.ResumeLayout(false);
            this.tbppaciente.PerformLayout();
            this.tbcmedico.ResumeLayout(false);
            this.tbcmedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrecetamedica;
        private System.Windows.Forms.Label lblmedico;
        private System.Windows.Forms.Label lblidpaciente;
        private System.Windows.Forms.Label lblnombremedicamento;
        private System.Windows.Forms.Label lblcatmedicamento;
        private System.Windows.Forms.Label lblviadeadmin;
        private System.Windows.Forms.Label lbldosis;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TabControl tbcrecetamedica;
        private System.Windows.Forms.TabPage tbppaciente;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tbcmedico;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtid_recetamedica;
        private System.Windows.Forms.TextBox txtnom_med;
        private System.Windows.Forms.TextBox txtcatmedico;
        private System.Windows.Forms.TextBox txtid_medico;
        private System.Windows.Forms.TextBox txtid_pacientes;
        private System.Windows.Forms.TextBox txtvia_de_administracion;
        private System.Windows.Forms.TextBox txtdosis;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cbocatmedico;
        private System.Windows.Forms.ComboBox cbovia_de_administracion;
    }
}