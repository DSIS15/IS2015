namespace dll_paciente.Presentacion
{
    partial class wfAntecedentesM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAntecedentesM));
            this.navegador1 = new Navegador.Navegador();
            this.lblidAnte = new System.Windows.Forms.Label();
            this.lblidPaciente = new System.Windows.Forms.Label();
            this.lblidenfermedad = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtidantecedente = new System.Windows.Forms.TextBox();
            this.txtidpaciente = new System.Windows.Forms.TextBox();
            this.txtidenfermedad = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.btnenferdedad = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(34, 30);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "antecedentes_medicos";
            this.navegador1.TabIndex = 0;
            // 
            // lblidAnte
            // 
            this.lblidAnte.AutoSize = true;
            this.lblidAnte.Location = new System.Drawing.Point(65, 107);
            this.lblidAnte.Name = "lblidAnte";
            this.lblidAnte.Size = new System.Drawing.Size(86, 13);
            this.lblidAnte.TabIndex = 1;
            this.lblidAnte.Text = "ID antecedentes";
            // 
            // lblidPaciente
            // 
            this.lblidPaciente.AutoSize = true;
            this.lblidPaciente.Location = new System.Drawing.Point(260, 106);
            this.lblidPaciente.Name = "lblidPaciente";
            this.lblidPaciente.Size = new System.Drawing.Size(62, 13);
            this.lblidPaciente.TabIndex = 2;
            this.lblidPaciente.Text = "ID paciente";
            // 
            // lblidenfermedad
            // 
            this.lblidenfermedad.AutoSize = true;
            this.lblidenfermedad.Location = new System.Drawing.Point(445, 107);
            this.lblidenfermedad.Name = "lblidenfermedad";
            this.lblidenfermedad.Size = new System.Drawing.Size(77, 13);
            this.lblidenfermedad.TabIndex = 3;
            this.lblidenfermedad.Text = "ID enfermedad";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(65, 143);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 4;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // txtidantecedente
            // 
            this.txtidantecedente.Location = new System.Drawing.Point(168, 99);
            this.txtidantecedente.Name = "txtidantecedente";
            this.txtidantecedente.Size = new System.Drawing.Size(22, 20);
            this.txtidantecedente.TabIndex = 5;
            this.txtidantecedente.Tag = "id_antecedente_medico";
            // 
            // txtidpaciente
            // 
            this.txtidpaciente.Location = new System.Drawing.Point(342, 98);
            this.txtidpaciente.Name = "txtidpaciente";
            this.txtidpaciente.Size = new System.Drawing.Size(23, 20);
            this.txtidpaciente.TabIndex = 6;
            this.txtidpaciente.Tag = "id_pacientes";
            // 
            // txtidenfermedad
            // 
            this.txtidenfermedad.Location = new System.Drawing.Point(528, 99);
            this.txtidenfermedad.Name = "txtidenfermedad";
            this.txtidenfermedad.Size = new System.Drawing.Size(26, 20);
            this.txtidenfermedad.TabIndex = 7;
            this.txtidenfermedad.Tag = "id_enfermedad";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(153, 143);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(266, 52);
            this.txtdescripcion.TabIndex = 8;
            this.txtdescripcion.Tag = "Descripcion";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 205);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 147);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paciente";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(7, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "ID";
            this.cuDataGridD1.Size = new System.Drawing.Size(624, 109);
            this.cuDataGridD1.STabla = "paciente";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cuDataGridD2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enfermedad";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(7, 6);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "ID";
            this.cuDataGridD2.Size = new System.Drawing.Size(624, 109);
            this.cuDataGridD2.STabla = "enfermedades_antecedentes";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            this.cuDataGridD2.Load += new System.EventHandler(this.cuDataGridD2_Load);
            // 
            // btnenferdedad
            // 
            this.btnenferdedad.Enabled = false;
            this.btnenferdedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenferdedad.Location = new System.Drawing.Point(560, 97);
            this.btnenferdedad.Name = "btnenferdedad";
            this.btnenferdedad.Size = new System.Drawing.Size(116, 23);
            this.btnenferdedad.TabIndex = 10;
            this.btnenferdedad.Text = "Nueva Enfermedad";
            this.btnenferdedad.UseVisualStyleBackColor = true;
            this.btnenferdedad.Click += new System.EventHandler(this.btnenferdedad_Click);
            // 
            // wfAntecedentesM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 364);
            this.Controls.Add(this.btnenferdedad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtidenfermedad);
            this.Controls.Add(this.txtidpaciente);
            this.Controls.Add(this.txtidantecedente);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblidenfermedad);
            this.Controls.Add(this.lblidPaciente);
            this.Controls.Add(this.lblidAnte);
            this.Controls.Add(this.navegador1);
            this.Name = "wfAntecedentesM";
            this.Text = "wfAntecedentesM";
            this.Load += new System.EventHandler(this.wfAntecedentesM_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblidAnte;
        private System.Windows.Forms.Label lblidPaciente;
        private System.Windows.Forms.Label lblidenfermedad;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtidantecedente;
        private System.Windows.Forms.TextBox txtidpaciente;
        private System.Windows.Forms.TextBox txtidenfermedad;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tabPage2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private System.Windows.Forms.Button btnenferdedad;
    }
}