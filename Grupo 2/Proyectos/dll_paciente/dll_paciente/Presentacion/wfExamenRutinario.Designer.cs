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
            this.label3 = new System.Windows.Forms.Label();
            this.lblestatura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblestadocavidadbucal = new System.Windows.Forms.Label();
            this.lblestadooido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.txtsangre = new System.Windows.Forms.TextBox();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
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
            this.navegador1.Location = new System.Drawing.Point(81, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "examen_rutinario";
            this.navegador1.TabIndex = 0;
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
            this.lblpresion.Location = new System.Drawing.Point(29, 132);
            this.lblpresion.Name = "lblpresion";
            this.lblpresion.Size = new System.Drawing.Size(45, 13);
            this.lblpresion.TabIndex = 2;
            this.lblpresion.Text = "Presión:";
            // 
            // lblcolesterol
            // 
            this.lblcolesterol.AutoSize = true;
            this.lblcolesterol.Location = new System.Drawing.Point(29, 169);
            this.lblcolesterol.Name = "lblcolesterol";
            this.lblcolesterol.Size = new System.Drawing.Size(56, 13);
            this.lblcolesterol.TabIndex = 3;
            this.lblcolesterol.Text = "Colesterol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Glucosa:";
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Location = new System.Drawing.Point(297, 132);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(49, 13);
            this.lblestatura.TabIndex = 5;
            this.lblestatura.Text = "Estatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Peso:";
            // 
            // lblestadocavidadbucal
            // 
            this.lblestadocavidadbucal.AutoSize = true;
            this.lblestadocavidadbucal.Location = new System.Drawing.Point(297, 200);
            this.lblestadocavidadbucal.Name = "lblestadocavidadbucal";
            this.lblestadocavidadbucal.Size = new System.Drawing.Size(113, 13);
            this.lblestadocavidadbucal.TabIndex = 7;
            this.lblestadocavidadbucal.Text = "Estado cavidad bucal:";
            // 
            // lblestadooido
            // 
            this.lblestadooido.AutoSize = true;
            this.lblestadooido.Location = new System.Drawing.Point(547, 168);
            this.lblestadooido.Name = "lblestadooido";
            this.lblestadooido.Size = new System.Drawing.Size(70, 13);
            this.lblestadooido.TabIndex = 8;
            this.lblestadooido.Text = "Estado Oído:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Paciente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID médico:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tipo de sangre:";
            // 
            // txtid_exrutinario
            // 
            this.txtid_exrutinario.Location = new System.Drawing.Point(138, 97);
            this.txtid_exrutinario.Name = "txtid_exrutinario";
            this.txtid_exrutinario.Size = new System.Drawing.Size(100, 20);
            this.txtid_exrutinario.TabIndex = 12;
            this.txtid_exrutinario.Tag = "id_exrutinario";
            // 
            // txtpresion
            // 
            this.txtpresion.Location = new System.Drawing.Point(138, 125);
            this.txtpresion.Name = "txtpresion";
            this.txtpresion.Size = new System.Drawing.Size(100, 20);
            this.txtpresion.TabIndex = 13;
            this.txtpresion.Tag = "presion";
            // 
            // txtcolesterol
            // 
            this.txtcolesterol.Location = new System.Drawing.Point(138, 162);
            this.txtcolesterol.Name = "txtcolesterol";
            this.txtcolesterol.Size = new System.Drawing.Size(100, 20);
            this.txtcolesterol.TabIndex = 14;
            this.txtcolesterol.Tag = "colesterol";
            // 
            // txtglucosa
            // 
            this.txtglucosa.Location = new System.Drawing.Point(138, 193);
            this.txtglucosa.Name = "txtglucosa";
            this.txtglucosa.Size = new System.Drawing.Size(100, 20);
            this.txtglucosa.TabIndex = 15;
            this.txtglucosa.Tag = "glucosa";
            // 
            // txtid_pacientes
            // 
            this.txtid_pacientes.Location = new System.Drawing.Point(416, 89);
            this.txtid_pacientes.Name = "txtid_pacientes";
            this.txtid_pacientes.Size = new System.Drawing.Size(100, 20);
            this.txtid_pacientes.TabIndex = 16;
            this.txtid_pacientes.Tag = "id_pacientes";
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(416, 124);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 20);
            this.txtestatura.TabIndex = 17;
            this.txtestatura.Tag = "estatura";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(416, 161);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 18;
            this.txtpeso.Tag = "peso";
            // 
            // txtestado_cavidad_bucal
            // 
            this.txtestado_cavidad_bucal.Location = new System.Drawing.Point(416, 193);
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
            this.txtid_medico.Size = new System.Drawing.Size(118, 20);
            this.txtid_medico.TabIndex = 20;
            this.txtid_medico.Tag = "id_medico";
            // 
            // txtestado_oido
            // 
            this.txtestado_oido.Location = new System.Drawing.Point(623, 166);
            this.txtestado_oido.Multiline = true;
            this.txtestado_oido.Name = "txtestado_oido";
            this.txtestado_oido.Size = new System.Drawing.Size(121, 65);
            this.txtestado_oido.TabIndex = 21;
            this.txtestado_oido.Tag = "estado_oido";
            // 
            // cbosangre
            // 
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 277);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 160);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 134);
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
            this.tabPage2.Size = new System.Drawing.Size(704, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Médico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(6, 6);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(692, 122);
            this.cuDataGridD1.STabla = "paciente";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
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
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(6, 7);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(692, 122);
            this.cuDataGridD2.STabla = "medico";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // wfExamenRutinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Controls.Add(this.txtsangre);
            this.Controls.Add(this.tabControl1);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblestadooido);
            this.Controls.Add(this.lblestadocavidadbucal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcolesterol);
            this.Controls.Add(this.lblpresion);
            this.Controls.Add(this.lblid_exrutinario);
            this.Controls.Add(this.navegador1);
            this.Name = "wfExamenRutinario";
            this.Text = "Examen Rutinario";
            this.Load += new System.EventHandler(this.wfExamenRutinario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblid_exrutinario;
        private System.Windows.Forms.Label lblpresion;
        private System.Windows.Forms.Label lblcolesterol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblestadocavidadbucal;
        private System.Windows.Forms.Label lblestadooido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tabPage2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private System.Windows.Forms.TextBox txtsangre;
    }
}