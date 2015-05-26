namespace dll_medico.Presentacion
{
    partial class wfCitaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCitaMedica));
            this.navegador1 = new Navegador.Navegador();
            this.lblcitamedica = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblmedico = new System.Windows.Forms.Label();
            this.lblpacientes = new System.Windows.Forms.Label();
            this.lblfechacita = new System.Windows.Forms.Label();
            this.lbltipocita = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtIdCitaMedica = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.txtIdPacientes = new System.Windows.Forms.TextBox();
            this.txtFechaCita = new System.Windows.Forms.TextBox();
            this.txtTipoCita = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cuDataGridD3 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(24, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "cita_medi";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "";
            this.navegador1.btnNuevo_BeforeClick += new System.EventHandler(this.navegador1_btnNuevo_BeforeClick);
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            this.navegador1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navegador1_MouseMove);
            // 
            // lblcitamedica
            // 
            this.lblcitamedica.AutoSize = true;
            this.lblcitamedica.Location = new System.Drawing.Point(52, 95);
            this.lblcitamedica.Name = "lblcitamedica";
            this.lblcitamedica.Size = new System.Drawing.Size(75, 13);
            this.lblcitamedica.TabIndex = 1;
            this.lblcitamedica.Text = "Id Cita Medica";
            this.lblcitamedica.Click += new System.EventHandler(this.lblcitamedico_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(221, 95);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(55, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Id Usuario";
            // 
            // lblmedico
            // 
            this.lblmedico.AutoSize = true;
            this.lblmedico.Location = new System.Drawing.Point(225, 131);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(54, 13);
            this.lblmedico.TabIndex = 3;
            this.lblmedico.Text = "Id Medico";
            // 
            // lblpacientes
            // 
            this.lblpacientes.AutoSize = true;
            this.lblpacientes.Location = new System.Drawing.Point(52, 135);
            this.lblpacientes.Name = "lblpacientes";
            this.lblpacientes.Size = new System.Drawing.Size(66, 13);
            this.lblpacientes.TabIndex = 4;
            this.lblpacientes.Text = "Id Pacientes";
            // 
            // lblfechacita
            // 
            this.lblfechacita.AutoSize = true;
            this.lblfechacita.Location = new System.Drawing.Point(372, 165);
            this.lblfechacita.Name = "lblfechacita";
            this.lblfechacita.Size = new System.Drawing.Size(57, 13);
            this.lblfechacita.TabIndex = 5;
            this.lblfechacita.Text = "Fecha cita";
            // 
            // lbltipocita
            // 
            this.lbltipocita.AutoSize = true;
            this.lbltipocita.Location = new System.Drawing.Point(378, 129);
            this.lbltipocita.Name = "lbltipocita";
            this.lbltipocita.Size = new System.Drawing.Size(48, 13);
            this.lbltipocita.TabIndex = 6;
            this.lbltipocita.Text = "Tipo cita";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(389, 95);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 7;
            this.lblestado.Text = "Estado";
            // 
            // txtIdCitaMedica
            // 
            this.txtIdCitaMedica.Enabled = false;
            this.txtIdCitaMedica.Location = new System.Drawing.Point(161, 92);
            this.txtIdCitaMedica.Name = "txtIdCitaMedica";
            this.txtIdCitaMedica.Size = new System.Drawing.Size(30, 20);
            this.txtIdCitaMedica.TabIndex = 8;
            this.txtIdCitaMedica.Tag = "id_cita_medi";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(290, 92);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(30, 20);
            this.txtIdUsuario.TabIndex = 9;
            this.txtIdUsuario.Tag = "id_usuario";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Enabled = false;
            this.txtIdMedico.Location = new System.Drawing.Point(290, 126);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(30, 20);
            this.txtIdMedico.TabIndex = 10;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // txtIdPacientes
            // 
            this.txtIdPacientes.Enabled = false;
            this.txtIdPacientes.Location = new System.Drawing.Point(161, 129);
            this.txtIdPacientes.Name = "txtIdPacientes";
            this.txtIdPacientes.Size = new System.Drawing.Size(30, 20);
            this.txtIdPacientes.TabIndex = 11;
            this.txtIdPacientes.Tag = "id_pacientes";
            // 
            // txtFechaCita
            // 
            this.txtFechaCita.Location = new System.Drawing.Point(546, 165);
            this.txtFechaCita.Name = "txtFechaCita";
            this.txtFechaCita.Size = new System.Drawing.Size(24, 20);
            this.txtFechaCita.TabIndex = 12;
            this.txtFechaCita.Tag = "fecha_cita";
            this.txtFechaCita.Visible = false;
            this.txtFechaCita.TextChanged += new System.EventHandler(this.txtFechaCita_TextChanged);
            // 
            // txtTipoCita
            // 
            this.txtTipoCita.Location = new System.Drawing.Point(440, 126);
            this.txtTipoCita.Name = "txtTipoCita";
            this.txtTipoCita.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCita.TabIndex = 13;
            this.txtTipoCita.Tag = "tipo_cita";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(546, 92);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(24, 20);
            this.txtEstado.TabIndex = 14;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(440, 92);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(100, 21);
            this.cboEstado.TabIndex = 15;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Enabled = false;
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(440, 165);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCita.TabIndex = 16;
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(55, 205);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 176);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 150);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.alObtenerCampos")));
            this.cuDataGridD1.AutoSize = true;
            this.cuDataGridD1.ICampo = 0;
            this.cuDataGridD1.Location = new System.Drawing.Point(-4, 3);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.Size = new System.Drawing.Size(543, 151);
            this.cuDataGridD1.STabla = "usuario";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cuDataGridD2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.alObtenerCampos")));
            this.cuDataGridD2.AutoSize = true;
            this.cuDataGridD2.ICampo = 0;
            this.cuDataGridD2.Location = new System.Drawing.Point(-4, 3);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.Size = new System.Drawing.Size(543, 151);
            this.cuDataGridD2.STabla = "medico";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cuDataGridD3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(535, 150);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pacientes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD3
            // 
            this.cuDataGridD3.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD3.AlDatosEntrada")));
            this.cuDataGridD3.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD3.alObtenerCampos")));
            this.cuDataGridD3.AutoSize = true;
            this.cuDataGridD3.ICampo = 0;
            this.cuDataGridD3.Location = new System.Drawing.Point(-4, 0);
            this.cuDataGridD3.Name = "cuDataGridD3";
            this.cuDataGridD3.Size = new System.Drawing.Size(543, 154);
            this.cuDataGridD3.STabla = "paciente";
            this.cuDataGridD3.TabIndex = 0;
            this.cuDataGridD3.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD3_sdgv_CellClick);
            // 
            // wfCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 414);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtTipoCita);
            this.Controls.Add(this.txtFechaCita);
            this.Controls.Add(this.txtIdPacientes);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtIdCitaMedica);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lbltipocita);
            this.Controls.Add(this.lblfechacita);
            this.Controls.Add(this.lblpacientes);
            this.Controls.Add(this.lblmedico);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcitamedica);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfCitaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita Medica";
            this.Load += new System.EventHandler(this.wfCitaMedica_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblcitamedica;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblmedico;
        private System.Windows.Forms.Label lblpacientes;
        private System.Windows.Forms.Label lblfechacita;
        private System.Windows.Forms.Label lbltipocita;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtIdCitaMedica;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.TextBox txtIdPacientes;
        private System.Windows.Forms.TextBox txtFechaCita;
        private System.Windows.Forms.TextBox txtTipoCita;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD3;
    }
}