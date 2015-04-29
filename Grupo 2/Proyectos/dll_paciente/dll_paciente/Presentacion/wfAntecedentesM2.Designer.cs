namespace dll_paciente.Presentacion
{
    partial class wfAntecedentesM2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAntecedentesM2));
            this.navegador1 = new Navegador.Navegador();
            this.txtidantecedente = new System.Windows.Forms.TextBox();
            this.txtidpaciente = new System.Windows.Forms.TextBox();
            this.txtidenfermedad = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblidenfermedad = new System.Windows.Forms.Label();
            this.lblidPaciente = new System.Windows.Forms.Label();
            this.lblidAnte = new System.Windows.Forms.Label();
            this.Enfermedad = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
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
            this.navegador1.Location = new System.Drawing.Point(12, 22);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "antecedentes_medicos";
            this.navegador1.TabIndex = 0;
            // 
            // txtidantecedente
            // 
            this.txtidantecedente.Location = new System.Drawing.Point(107, 94);
            this.txtidantecedente.Name = "txtidantecedente";
            this.txtidantecedente.Size = new System.Drawing.Size(34, 20);
            this.txtidantecedente.TabIndex = 1;
            this.txtidantecedente.Tag = "id_antecente_medico";
            // 
            // txtidpaciente
            // 
            this.txtidpaciente.Location = new System.Drawing.Point(248, 94);
            this.txtidpaciente.Name = "txtidpaciente";
            this.txtidpaciente.Size = new System.Drawing.Size(35, 20);
            this.txtidpaciente.TabIndex = 2;
            this.txtidpaciente.Tag = "id_pacientes";
            // 
            // txtidenfermedad
            // 
            this.txtidenfermedad.Location = new System.Drawing.Point(478, 90);
            this.txtidenfermedad.Name = "txtidenfermedad";
            this.txtidenfermedad.Size = new System.Drawing.Size(42, 20);
            this.txtidenfermedad.TabIndex = 3;
            this.txtidenfermedad.Tag = "id_enfermedad";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(107, 133);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(413, 75);
            this.txtdescripcion.TabIndex = 4;
            this.txtdescripcion.Tag = "Descripcion";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(15, 133);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 8;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblidenfermedad
            // 
            this.lblidenfermedad.AutoSize = true;
            this.lblidenfermedad.Location = new System.Drawing.Point(395, 97);
            this.lblidenfermedad.Name = "lblidenfermedad";
            this.lblidenfermedad.Size = new System.Drawing.Size(77, 13);
            this.lblidenfermedad.TabIndex = 7;
            this.lblidenfermedad.Text = "ID enfermedad";
            // 
            // lblidPaciente
            // 
            this.lblidPaciente.AutoSize = true;
            this.lblidPaciente.Location = new System.Drawing.Point(168, 97);
            this.lblidPaciente.Name = "lblidPaciente";
            this.lblidPaciente.Size = new System.Drawing.Size(62, 13);
            this.lblidPaciente.TabIndex = 6;
            this.lblidPaciente.Text = "ID paciente";
            // 
            // lblidAnte
            // 
            this.lblidAnte.AutoSize = true;
            this.lblidAnte.Location = new System.Drawing.Point(15, 97);
            this.lblidAnte.Name = "lblidAnte";
            this.lblidAnte.Size = new System.Drawing.Size(86, 13);
            this.lblidAnte.TabIndex = 5;
            this.lblidAnte.Text = "ID antecedentes";
            // 
            // Enfermedad
            // 
            this.Enfermedad.Controls.Add(this.tabPage1);
            this.Enfermedad.Controls.Add(this.tabPage2);
            this.Enfermedad.Location = new System.Drawing.Point(30, 225);
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.SelectedIndex = 0;
            this.Enfermedad.Size = new System.Drawing.Size(503, 172);
            this.Enfermedad.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 146);
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
            this.tabPage2.Size = new System.Drawing.Size(495, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enfermedad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(3, 3);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(483, 137);
            this.cuDataGridD1.STabla = "paciente";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            this.cuDataGridD1.Load += new System.EventHandler(this.cuDataGridD1_Load_1);
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(6, 3);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(480, 137);
            this.cuDataGridD2.STabla = "enfermedades_antecedentes";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // wfAntecedentesM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 422);
            this.Controls.Add(this.Enfermedad);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblidenfermedad);
            this.Controls.Add(this.lblidPaciente);
            this.Controls.Add(this.lblidAnte);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtidenfermedad);
            this.Controls.Add(this.txtidpaciente);
            this.Controls.Add(this.txtidantecedente);
            this.Controls.Add(this.navegador1);
            this.Name = "wfAntecedentesM2";
            this.Text = "wfAntecedentesM2";
            this.Load += new System.EventHandler(this.wfAntecedentesM2_Load);
            this.Enfermedad.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtidantecedente;
        private System.Windows.Forms.TextBox txtidpaciente;
        private System.Windows.Forms.TextBox txtidenfermedad;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblidenfermedad;
        private System.Windows.Forms.Label lblidPaciente;
        private System.Windows.Forms.Label lblidAnte;
        private System.Windows.Forms.TabControl Enfermedad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
    }
}