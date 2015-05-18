namespace dll_paciente
{
    partial class wfAntecedentesMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAntecedentesMedicos));
            this.navegador1 = new Navegador.Navegador();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.Enfermedad = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblidenfermedad = new System.Windows.Forms.Label();
            this.lblidPaciente = new System.Windows.Forms.Label();
            this.lblidAnte = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtidenfermedad = new System.Windows.Forms.TextBox();
            this.txtidpaciente = new System.Windows.Forms.TextBox();
            this.txtidantecedente = new System.Windows.Forms.TextBox();
            this.Enfermedad.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(40, 26);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "antecedentes_medicos";
            this.navegador1.TabIndex = 0;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(6, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(578, 183);
            this.cuDataGridD1.STabla = "paciente";
            this.cuDataGridD1.TabIndex = 1;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            this.cuDataGridD1.Load += new System.EventHandler(this.cuDataGridD1_Load);
            // 
            // Enfermedad
            // 
            this.Enfermedad.Controls.Add(this.tabPage1);
            this.Enfermedad.Controls.Add(this.tabPage2);
            this.Enfermedad.Location = new System.Drawing.Point(40, 220);
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.SelectedIndex = 0;
            this.Enfermedad.Size = new System.Drawing.Size(598, 221);
            this.Enfermedad.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cuDataGridD2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enfermedad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(0, 6);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(584, 183);
            this.cuDataGridD2.STabla = "enfermedades_antecedentes";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(41, 130);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 16;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblidenfermedad
            // 
            this.lblidenfermedad.AutoSize = true;
            this.lblidenfermedad.Location = new System.Drawing.Point(513, 94);
            this.lblidenfermedad.Name = "lblidenfermedad";
            this.lblidenfermedad.Size = new System.Drawing.Size(77, 13);
            this.lblidenfermedad.TabIndex = 15;
            this.lblidenfermedad.Text = "ID enfermedad";
            // 
            // lblidPaciente
            // 
            this.lblidPaciente.AutoSize = true;
            this.lblidPaciente.Location = new System.Drawing.Point(295, 93);
            this.lblidPaciente.Name = "lblidPaciente";
            this.lblidPaciente.Size = new System.Drawing.Size(62, 13);
            this.lblidPaciente.TabIndex = 14;
            this.lblidPaciente.Text = "ID paciente";
            // 
            // lblidAnte
            // 
            this.lblidAnte.AutoSize = true;
            this.lblidAnte.Location = new System.Drawing.Point(41, 94);
            this.lblidAnte.Name = "lblidAnte";
            this.lblidAnte.Size = new System.Drawing.Size(86, 13);
            this.lblidAnte.TabIndex = 13;
            this.lblidAnte.Text = "ID antecedentes";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(133, 130);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(505, 75);
            this.txtdescripcion.TabIndex = 12;
            this.txtdescripcion.Tag = "Descripcion";
            // 
            // txtidenfermedad
            // 
            this.txtidenfermedad.Location = new System.Drawing.Point(596, 87);
            this.txtidenfermedad.Name = "txtidenfermedad";
            this.txtidenfermedad.Size = new System.Drawing.Size(42, 20);
            this.txtidenfermedad.TabIndex = 11;
            this.txtidenfermedad.Tag = "id_enfermedad";
            // 
            // txtidpaciente
            // 
            this.txtidpaciente.Location = new System.Drawing.Point(377, 86);
            this.txtidpaciente.Name = "txtidpaciente";
            this.txtidpaciente.Size = new System.Drawing.Size(35, 20);
            this.txtidpaciente.TabIndex = 10;
            this.txtidpaciente.Tag = "id_pacientes";
            // 
            // txtidantecedente
            // 
            this.txtidantecedente.Location = new System.Drawing.Point(133, 91);
            this.txtidantecedente.Name = "txtidantecedente";
            this.txtidantecedente.Size = new System.Drawing.Size(34, 20);
            this.txtidantecedente.TabIndex = 9;
            this.txtidantecedente.Tag = "id_antecente_medico";
            // 
            // wfAntecedentesMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 453);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblidenfermedad);
            this.Controls.Add(this.lblidPaciente);
            this.Controls.Add(this.lblidAnte);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtidenfermedad);
            this.Controls.Add(this.txtidpaciente);
            this.Controls.Add(this.txtidantecedente);
            this.Controls.Add(this.Enfermedad);
            this.Controls.Add(this.navegador1);
            this.Name = "wfAntecedentesMedicos";
            this.Text = "Antecedentes Medicos";
            this.Load += new System.EventHandler(this.wfAntecedentesMedicos_Load);
            this.Enfermedad.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabControl Enfermedad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblidenfermedad;
        private System.Windows.Forms.Label lblidPaciente;
        private System.Windows.Forms.Label lblidAnte;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtidenfermedad;
        private System.Windows.Forms.TextBox txtidpaciente;
        private System.Windows.Forms.TextBox txtidantecedente;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
    }
}