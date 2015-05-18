﻿namespace dll_citamedica.Presentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEstadoCita = new System.Windows.Forms.ComboBox();
            this.txtTipoCita = new System.Windows.Forms.TextBox();
            this.txtEstadoCita = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.tbcCitaMedica = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cuDataGridD3 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tbcCitaMedica.SuspendLayout();
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
            this.navegador1.Location = new System.Drawing.Point(25, 26);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "cita_medica";
            this.navegador1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id cita";
            // 
            // txtIdCita
            // 
            this.txtIdCita.Location = new System.Drawing.Point(88, 103);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(100, 20);
            this.txtIdCita.TabIndex = 2;
            this.txtIdCita.Tag = "id_cita_medi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id medico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha cita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo cita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado";
            // 
            // cboEstadoCita
            // 
            this.cboEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCita.FormattingEnabled = true;
            this.cboEstadoCita.Location = new System.Drawing.Point(472, 103);
            this.cboEstadoCita.Name = "cboEstadoCita";
            this.cboEstadoCita.Size = new System.Drawing.Size(100, 21);
            this.cboEstadoCita.TabIndex = 13;
            this.cboEstadoCita.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCita_SelectedIndexChanged);
            // 
            // txtTipoCita
            // 
            this.txtTipoCita.Location = new System.Drawing.Point(100, 196);
            this.txtTipoCita.Name = "txtTipoCita";
            this.txtTipoCita.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCita.TabIndex = 14;
            this.txtTipoCita.Tag = "tipo_cita";
            // 
            // txtEstadoCita
            // 
            this.txtEstadoCita.Location = new System.Drawing.Point(587, 106);
            this.txtEstadoCita.Name = "txtEstadoCita";
            this.txtEstadoCita.Size = new System.Drawing.Size(21, 20);
            this.txtEstadoCita.TabIndex = 15;
            this.txtEstadoCita.Tag = "estado";
            this.txtEstadoCita.Visible = false;
            this.txtEstadoCita.TextChanged += new System.EventHandler(this.txtEstadoCita_TextChanged);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(317, 106);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(88, 20);
            this.txtIdUsuario.TabIndex = 16;
            this.txtIdUsuario.Tag = "id_usuario";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(88, 144);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(100, 20);
            this.txtIdMedico.TabIndex = 17;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(317, 153);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(88, 20);
            this.txtIdPaciente.TabIndex = 18;
            this.txtIdPaciente.Tag = "id_pacientes";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(472, 154);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 19;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(587, 154);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(21, 20);
            this.txtFecha.TabIndex = 20;
            this.txtFecha.Tag = "fecha_cita";
            this.txtFecha.Visible = false;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // tbcCitaMedica
            // 
            this.tbcCitaMedica.Controls.Add(this.tabPage1);
            this.tbcCitaMedica.Controls.Add(this.tabPage2);
            this.tbcCitaMedica.Controls.Add(this.tabPage3);
            this.tbcCitaMedica.Location = new System.Drawing.Point(68, 250);
            this.tbcCitaMedica.Name = "tbcCitaMedica";
            this.tbcCitaMedica.SelectedIndex = 0;
            this.tbcCitaMedica.Size = new System.Drawing.Size(540, 156);
            this.tbcCitaMedica.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 130);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(3, 3);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(526, 124);
            this.cuDataGridD1.STabla = "usuario";
            this.cuDataGridD1.TabIndex = 1;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick_1);
            this.cuDataGridD1.Load += new System.EventHandler(this.cuDataGridD1_Load_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cuDataGridD2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 130);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(6, 0);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(523, 123);
            this.cuDataGridD2.STabla = "medico";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            this.cuDataGridD2.Load += new System.EventHandler(this.cuDataGridD2_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cuDataGridD3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(532, 130);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paciente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD3
            // 
            this.cuDataGridD3.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD3.AlDatosEntrada")));
            this.cuDataGridD3.Location = new System.Drawing.Point(5, 3);
            this.cuDataGridD3.Name = "cuDataGridD3";
            this.cuDataGridD3.SCampo = "Codigo";
            this.cuDataGridD3.Size = new System.Drawing.Size(523, 124);
            this.cuDataGridD3.STabla = "paciente";
            this.cuDataGridD3.TabIndex = 1;
            this.cuDataGridD3.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD3_sdgv_CellClick);
            this.cuDataGridD3.Load += new System.EventHandler(this.cuDataGridD3_Load_1);
            // 
            // wfCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 418);
            this.Controls.Add(this.tbcCitaMedica);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtEstadoCita);
            this.Controls.Add(this.txtTipoCita);
            this.Controls.Add(this.cboEstadoCita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "wfCitaMedica";
            this.Text = "wfCitaMedica";
            this.Load += new System.EventHandler(this.wfCitaMedica_Load);
            this.tbcCitaMedica.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstadoCita;
        private System.Windows.Forms.TextBox txtTipoCita;
        private System.Windows.Forms.TextBox txtEstadoCita;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TabControl tbcCitaMedica;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD3;
    }
}