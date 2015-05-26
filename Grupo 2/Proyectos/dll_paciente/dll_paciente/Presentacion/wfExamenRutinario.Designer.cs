namespace dll_paciente.Presentacion
{
    partial class wfExamenRutinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfExamenRutinario));
            this.navegador1 = new Navegador.Navegador();
            this.lblid_exrutinario = new System.Windows.Forms.Label();
            this.lblpresion = new System.Windows.Forms.Label();
            this.lblcolesterol = new System.Windows.Forms.Label();
            this.lblglucosa = new System.Windows.Forms.Label();
            this.lblestatura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblestadocavidadbucal = new System.Windows.Forms.Label();
            this.lblestadooido = new System.Windows.Forms.Label();
            this.lblidpaciente = new System.Windows.Forms.Label();
            this.lblidmedico = new System.Windows.Forms.Label();
            this.lbltipodesangre = new System.Windows.Forms.Label();
            this.txtid_exrutinario = new System.Windows.Forms.TextBox();
            this.txtpresion = new System.Windows.Forms.TextBox();
            this.txtcolesterol = new System.Windows.Forms.TextBox();
            this.txtglucosa = new System.Windows.Forms.TextBox();
            this.txtid_pacientes = new System.Windows.Forms.TextBox();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtestado_cavidad_bucal = new System.Windows.Forms.TextBox();
            this.txtid_medico = new System.Windows.Forms.TextBox();
            this.txtestado_oido = new System.Windows.Forms.TextBox();
            this.cbosangre = new System.Windows.Forms.ComboBox();
            this.tbcexamenrutinario = new System.Windows.Forms.TabControl();
            this.tbppaciente = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbpmedico = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.txtsangre = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.tbcexamenrutinario.SuspendLayout();
            this.tbppaciente.SuspendLayout();
            this.tbpmedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(81, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "examen_rutinario";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // lblid_exrutinario
            // 
            this.lblid_exrutinario.AutoSize = true;
            this.lblid_exrutinario.Location = new System.Drawing.Point(29, 97);
            this.lblid_exrutinario.Name = "lblid_exrutinario";
            this.lblid_exrutinario.Size = new System.Drawing.Size(102, 13);
            this.lblid_exrutinario.TabIndex = 1;
            this.lblid_exrutinario.Text = "ID Examen rutinario:";
            // 
            // lblpresion
            // 
            this.lblpresion.AutoSize = true;
            this.lblpresion.Location = new System.Drawing.Point(29, 139);
            this.lblpresion.Name = "lblpresion";
            this.lblpresion.Size = new System.Drawing.Size(45, 13);
            this.lblpresion.TabIndex = 2;
            this.lblpresion.Text = "Presión:";
            // 
            // lblcolesterol
            // 
            this.lblcolesterol.AutoSize = true;
            this.lblcolesterol.Location = new System.Drawing.Point(29, 174);
            this.lblcolesterol.Name = "lblcolesterol";
            this.lblcolesterol.Size = new System.Drawing.Size(56, 13);
            this.lblcolesterol.TabIndex = 3;
            this.lblcolesterol.Text = "Colesterol:";
            // 
            // lblglucosa
            // 
            this.lblglucosa.AutoSize = true;
            this.lblglucosa.Location = new System.Drawing.Point(28, 209);
            this.lblglucosa.Name = "lblglucosa";
            this.lblglucosa.Size = new System.Drawing.Size(49, 13);
            this.lblglucosa.TabIndex = 4;
            this.lblglucosa.Text = "Glucosa:";
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Location = new System.Drawing.Point(297, 136);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(49, 13);
            this.lblestatura.TabIndex = 5;
            this.lblestatura.Text = "Estatura:";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(297, 173);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(34, 13);
            this.lblpeso.TabIndex = 6;
            this.lblpeso.Text = "Peso:";
            // 
            // lblestadocavidadbucal
            // 
            this.lblestadocavidadbucal.AutoSize = true;
            this.lblestadocavidadbucal.Location = new System.Drawing.Point(296, 209);
            this.lblestadocavidadbucal.Name = "lblestadocavidadbucal";
            this.lblestadocavidadbucal.Size = new System.Drawing.Size(113, 13);
            this.lblestadocavidadbucal.TabIndex = 7;
            this.lblestadocavidadbucal.Text = "Estado cavidad bucal:";
            // 
            // lblestadooido
            // 
            this.lblestadooido.AutoSize = true;
            this.lblestadooido.Location = new System.Drawing.Point(535, 206);
            this.lblestadooido.Name = "lblestadooido";
            this.lblestadooido.Size = new System.Drawing.Size(70, 13);
            this.lblestadooido.TabIndex = 8;
            this.lblestadooido.Text = "Estado Oído:";
            // 
            // lblidpaciente
            // 
            this.lblidpaciente.AutoSize = true;
            this.lblidpaciente.Location = new System.Drawing.Point(297, 97);
            this.lblidpaciente.Name = "lblidpaciente";
            this.lblidpaciente.Size = new System.Drawing.Size(66, 13);
            this.lblidpaciente.TabIndex = 9;
            this.lblidpaciente.Text = "ID Paciente:";
            // 
            // lblidmedico
            // 
            this.lblidmedico.AutoSize = true;
            this.lblidmedico.Location = new System.Drawing.Point(536, 97);
            this.lblidmedico.Name = "lblidmedico";
            this.lblidmedico.Size = new System.Drawing.Size(58, 13);
            this.lblidmedico.TabIndex = 10;
            this.lblidmedico.Text = "ID médico:";
            // 
            // lbltipodesangre
            // 
            this.lbltipodesangre.AutoSize = true;
            this.lbltipodesangre.Location = new System.Drawing.Point(536, 127);
            this.lbltipodesangre.Name = "lbltipodesangre";
            this.lbltipodesangre.Size = new System.Drawing.Size(81, 13);
            this.lbltipodesangre.TabIndex = 11;
            this.lbltipodesangre.Text = "Tipo de sangre:";
            this.lbltipodesangre.Click += new System.EventHandler(this.lbltipodesangre_Click);
            // 
            // txtid_exrutinario
            // 
            this.txtid_exrutinario.Location = new System.Drawing.Point(138, 97);
            this.txtid_exrutinario.Name = "txtid_exrutinario";
            this.txtid_exrutinario.Size = new System.Drawing.Size(41, 20);
            this.txtid_exrutinario.TabIndex = 12;
            this.txtid_exrutinario.Tag = "id_exrutinario";
            // 
            // txtpresion
            // 
            this.txtpresion.Location = new System.Drawing.Point(138, 132);
            this.txtpresion.Name = "txtpresion";
            this.txtpresion.Size = new System.Drawing.Size(100, 20);
            this.txtpresion.TabIndex = 13;
            this.txtpresion.Tag = "presion";
            // 
            // txtcolesterol
            // 
            this.txtcolesterol.Location = new System.Drawing.Point(138, 167);
            this.txtcolesterol.Name = "txtcolesterol";
            this.txtcolesterol.Size = new System.Drawing.Size(100, 20);
            this.txtcolesterol.TabIndex = 14;
            this.txtcolesterol.Tag = "colesterol";
            // 
            // txtglucosa
            // 
            this.txtglucosa.Location = new System.Drawing.Point(137, 202);
            this.txtglucosa.Name = "txtglucosa";
            this.txtglucosa.Size = new System.Drawing.Size(100, 20);
            this.txtglucosa.TabIndex = 15;
            this.txtglucosa.Tag = "glucosa";
            // 
            // txtid_pacientes
            // 
            this.txtid_pacientes.Location = new System.Drawing.Point(416, 89);
            this.txtid_pacientes.Name = "txtid_pacientes";
            this.txtid_pacientes.Size = new System.Drawing.Size(33, 20);
            this.txtid_pacientes.TabIndex = 16;
            this.txtid_pacientes.Tag = "id_pacientes";
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(416, 132);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 20);
            this.txtestatura.TabIndex = 17;
            this.txtestatura.Tag = "altura";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(416, 169);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 18;
            this.txtpeso.Tag = "peso";
            // 
            // txtestado_cavidad_bucal
            // 
            this.txtestado_cavidad_bucal.Location = new System.Drawing.Point(415, 202);
            this.txtestado_cavidad_bucal.Multiline = true;
            this.txtestado_cavidad_bucal.Name = "txtestado_cavidad_bucal";
            this.txtestado_cavidad_bucal.Size = new System.Drawing.Size(112, 65);
            this.txtestado_cavidad_bucal.TabIndex = 19;
            this.txtestado_cavidad_bucal.Tag = "estado_cavidad_bucal";
            // 
            // txtid_medico
            // 
            this.txtid_medico.Location = new System.Drawing.Point(622, 89);
            this.txtid_medico.Name = "txtid_medico";
            this.txtid_medico.Size = new System.Drawing.Size(36, 20);
            this.txtid_medico.TabIndex = 20;
            this.txtid_medico.Tag = "id_medico";
            // 
            // txtestado_oido
            // 
            this.txtestado_oido.Location = new System.Drawing.Point(622, 206);
            this.txtestado_oido.Multiline = true;
            this.txtestado_oido.Name = "txtestado_oido";
            this.txtestado_oido.Size = new System.Drawing.Size(121, 61);
            this.txtestado_oido.TabIndex = 21;
            this.txtestado_oido.Tag = "estado_oido";
            // 
            // cbosangre
            // 
            this.cbosangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosangre.FormattingEnabled = true;
            this.cbosangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbosangre.Location = new System.Drawing.Point(623, 119);
            this.cbosangre.Name = "cbosangre";
            this.cbosangre.Size = new System.Drawing.Size(121, 21);
            this.cbosangre.TabIndex = 22;
            this.cbosangre.SelectedIndexChanged += new System.EventHandler(this.cbosangre_SelectedIndexChanged);
            // 
            // tbcexamenrutinario
            // 
            this.tbcexamenrutinario.Controls.Add(this.tbppaciente);
            this.tbcexamenrutinario.Controls.Add(this.tbpmedico);
            this.tbcexamenrutinario.Location = new System.Drawing.Point(32, 277);
            this.tbcexamenrutinario.Name = "tbcexamenrutinario";
            this.tbcexamenrutinario.SelectedIndex = 0;
            this.tbcexamenrutinario.Size = new System.Drawing.Size(741, 259);
            this.tbcexamenrutinario.TabIndex = 23;
            // 
            // tbppaciente
            // 
            this.tbppaciente.Controls.Add(this.cuDataGridD1);
            this.tbppaciente.Location = new System.Drawing.Point(4, 22);
            this.tbppaciente.Name = "tbppaciente";
            this.tbppaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbppaciente.Size = new System.Drawing.Size(741, 233);
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
            this.cuDataGridD1.Size = new System.Drawing.Size(729, 227);
            this.cuDataGridD1.STabla = "paciente";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tbpmedico
            // 
            this.tbpmedico.Controls.Add(this.cuDataGridD2);
            this.tbpmedico.Location = new System.Drawing.Point(4, 22);
            this.tbpmedico.Name = "tbpmedico";
            this.tbpmedico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpmedico.Size = new System.Drawing.Size(733, 233);
            this.tbpmedico.TabIndex = 1;
            this.tbpmedico.Text = "Médico";
            this.tbpmedico.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.alObtenerCampos = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.alObtenerCampos")));
            this.cuDataGridD2.AutoSize = true;
            this.cuDataGridD2.ICampo = 0;
            this.cuDataGridD2.Location = new System.Drawing.Point(6, 7);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.Size = new System.Drawing.Size(724, 230);
            this.cuDataGridD2.STabla = "medico";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // txtsangre
            // 
            this.txtsangre.Location = new System.Drawing.Point(750, 119);
            this.txtsangre.Name = "txtsangre";
            this.txtsangre.Size = new System.Drawing.Size(31, 20);
            this.txtsangre.TabIndex = 24;
            this.txtsangre.Tag = "sangre";
            this.txtsangre.Visible = false;
            this.txtsangre.TextChanged += new System.EventHandler(this.txtsangre_TextChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(536, 169);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 25;
            this.lblestado.Tag = "estado";
            this.lblestado.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboestado.Location = new System.Drawing.Point(622, 165);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(121, 21);
            this.cboestado.TabIndex = 27;
            this.cboestado.SelectedIndexChanged += new System.EventHandler(this.cboestado_SelectedIndexChanged);
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(750, 166);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(32, 20);
            this.txtestado.TabIndex = 26;
            this.txtestado.Tag = "estado";
            this.txtestado.Visible = false;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // wfExamenRutinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 548);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtsangre);
            this.Controls.Add(this.tbcexamenrutinario);
            this.Controls.Add(this.cbosangre);
            this.Controls.Add(this.txtestado_oido);
            this.Controls.Add(this.txtid_medico);
            this.Controls.Add(this.txtestado_cavidad_bucal);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.txtid_pacientes);
            this.Controls.Add(this.txtglucosa);
            this.Controls.Add(this.txtcolesterol);
            this.Controls.Add(this.txtpresion);
            this.Controls.Add(this.txtid_exrutinario);
            this.Controls.Add(this.lbltipodesangre);
            this.Controls.Add(this.lblidmedico);
            this.Controls.Add(this.lblidpaciente);
            this.Controls.Add(this.lblestadooido);
            this.Controls.Add(this.lblestadocavidadbucal);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.lblglucosa);
            this.Controls.Add(this.lblcolesterol);
            this.Controls.Add(this.lblpresion);
            this.Controls.Add(this.lblid_exrutinario);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfExamenRutinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen Rutinario";
            this.Load += new System.EventHandler(this.wfExamenRutinario_Load);
            this.tbcexamenrutinario.ResumeLayout(false);
            this.tbppaciente.ResumeLayout(false);
            this.tbppaciente.PerformLayout();
            this.tbpmedico.ResumeLayout(false);
            this.tbpmedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblid_exrutinario;
        private System.Windows.Forms.Label lblpresion;
        private System.Windows.Forms.Label lblcolesterol;
        private System.Windows.Forms.Label lblglucosa;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblestadocavidadbucal;
        private System.Windows.Forms.Label lblestadooido;
        private System.Windows.Forms.Label lblidpaciente;
        private System.Windows.Forms.Label lblidmedico;
        private System.Windows.Forms.Label lbltipodesangre;
        private System.Windows.Forms.TextBox txtid_exrutinario;
        private System.Windows.Forms.TextBox txtpresion;
        private System.Windows.Forms.TextBox txtcolesterol;
        private System.Windows.Forms.TextBox txtglucosa;
        private System.Windows.Forms.TextBox txtid_pacientes;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtestado_cavidad_bucal;
        private System.Windows.Forms.TextBox txtid_medico;
        private System.Windows.Forms.TextBox txtestado_oido;
        private System.Windows.Forms.ComboBox cbosangre;
        private System.Windows.Forms.TabControl tbcexamenrutinario;
        private System.Windows.Forms.TabPage tbppaciente;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tbpmedico;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private System.Windows.Forms.TextBox txtsangre;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtestado;
    }
}