namespace dll_medico.Presentacion
{
    partial class wfDetalleExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetalleExamen));
            this.navegador1 = new Navegador.Navegador();
            this.txtIdDetalleExamen = new System.Windows.Forms.TextBox();
            this.txtIdPacientes = new System.Windows.Forms.TextBox();
            this.txtIdTipoExamen = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.lbldetalleexamen = new System.Windows.Forms.Label();
            this.lblidpacientes = new System.Windows.Forms.Label();
            this.lbltipoexamen = new System.Windows.Forms.Label();
            this.lblidmedico = new System.Windows.Forms.Label();
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
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "det_examen";
            this.navegador1.TabIndex = 0;
            // 
            // txtIdDetalleExamen
            // 
            this.txtIdDetalleExamen.Location = new System.Drawing.Point(162, 83);
            this.txtIdDetalleExamen.Name = "txtIdDetalleExamen";
            this.txtIdDetalleExamen.Size = new System.Drawing.Size(100, 20);
            this.txtIdDetalleExamen.TabIndex = 1;
            this.txtIdDetalleExamen.Tag = "id_det_examen";
            // 
            // txtIdPacientes
            // 
            this.txtIdPacientes.Location = new System.Drawing.Point(380, 83);
            this.txtIdPacientes.Name = "txtIdPacientes";
            this.txtIdPacientes.Size = new System.Drawing.Size(100, 20);
            this.txtIdPacientes.TabIndex = 2;
            this.txtIdPacientes.Tag = "id_pacientes";
            // 
            // txtIdTipoExamen
            // 
            this.txtIdTipoExamen.Location = new System.Drawing.Point(162, 115);
            this.txtIdTipoExamen.Name = "txtIdTipoExamen";
            this.txtIdTipoExamen.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoExamen.TabIndex = 3;
            this.txtIdTipoExamen.Tag = "id_tipo_examen";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(380, 115);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(100, 20);
            this.txtIdMedico.TabIndex = 4;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // lbldetalleexamen
            // 
            this.lbldetalleexamen.AutoSize = true;
            this.lbldetalleexamen.Location = new System.Drawing.Point(59, 86);
            this.lbldetalleexamen.Name = "lbldetalleexamen";
            this.lbldetalleexamen.Size = new System.Drawing.Size(93, 13);
            this.lbldetalleexamen.TabIndex = 5;
            this.lbldetalleexamen.Text = "Id Detalle Examen";
            // 
            // lblidpacientes
            // 
            this.lblidpacientes.AutoSize = true;
            this.lblidpacientes.Location = new System.Drawing.Point(292, 86);
            this.lblidpacientes.Name = "lblidpacientes";
            this.lblidpacientes.Size = new System.Drawing.Size(66, 13);
            this.lblidpacientes.TabIndex = 6;
            this.lblidpacientes.Text = "Id Pacientes";
            // 
            // lbltipoexamen
            // 
            this.lbltipoexamen.AutoSize = true;
            this.lbltipoexamen.Location = new System.Drawing.Point(71, 118);
            this.lbltipoexamen.Name = "lbltipoexamen";
            this.lbltipoexamen.Size = new System.Drawing.Size(81, 13);
            this.lbltipoexamen.TabIndex = 7;
            this.lbltipoexamen.Text = "Id Tipo Examen";
            // 
            // lblidmedico
            // 
            this.lblidmedico.AutoSize = true;
            this.lblidmedico.Location = new System.Drawing.Point(305, 115);
            this.lblidmedico.Name = "lblidmedico";
            this.lblidmedico.Size = new System.Drawing.Size(53, 13);
            this.lblidmedico.TabIndex = 8;
            this.lblidmedico.Text = "Id medico";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(47, 174);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 173);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(3, 3);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(520, 141);
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
            this.tabPage2.Size = new System.Drawing.Size(526, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipo Examen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(3, 3);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(520, 141);
            this.cuDataGridD2.STabla = "tipo_examen";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cuDataGridD3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(526, 147);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Medico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD3
            // 
            this.cuDataGridD3.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD3.AlDatosEntrada")));
            this.cuDataGridD3.Location = new System.Drawing.Point(3, 0);
            this.cuDataGridD3.Name = "cuDataGridD3";
            this.cuDataGridD3.SCampo = "Codigo";
            this.cuDataGridD3.Size = new System.Drawing.Size(520, 144);
            this.cuDataGridD3.STabla = "medico";
            this.cuDataGridD3.TabIndex = 0;
            this.cuDataGridD3.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD3_sdgv_CellClick);
            // 
            // wfDetalleExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblidmedico);
            this.Controls.Add(this.lbltipoexamen);
            this.Controls.Add(this.lblidpacientes);
            this.Controls.Add(this.lbldetalleexamen);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.txtIdTipoExamen);
            this.Controls.Add(this.txtIdPacientes);
            this.Controls.Add(this.txtIdDetalleExamen);
            this.Controls.Add(this.navegador1);
            this.Name = "wfDetalleExamen";
            this.Text = "Detalle Examen";
            this.Load += new System.EventHandler(this.wfDetalleExamen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtIdDetalleExamen;
        private System.Windows.Forms.TextBox txtIdPacientes;
        private System.Windows.Forms.TextBox txtIdTipoExamen;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label lbldetalleexamen;
        private System.Windows.Forms.Label lblidpacientes;
        private System.Windows.Forms.Label lbltipoexamen;
        private System.Windows.Forms.Label lblidmedico;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD3;
    }
}