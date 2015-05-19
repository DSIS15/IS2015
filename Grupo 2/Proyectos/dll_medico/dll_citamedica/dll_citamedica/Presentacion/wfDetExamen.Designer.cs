namespace dll_citamedica.Presentacion
{
    partial class wfDetExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetExamen));
            this.navegador1 = new Navegador.Navegador();
            this.lblIdDetalle = new System.Windows.Forms.Label();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.lblIdPacientes = new System.Windows.Forms.Label();
            this.lblIdTipoExamen = new System.Windows.Forms.Label();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.txtIdPacientes = new System.Windows.Forms.TextBox();
            this.txtIdTipoExamen = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
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
            // lblIdDetalle
            // 
            this.lblIdDetalle.AutoSize = true;
            this.lblIdDetalle.Location = new System.Drawing.Point(72, 101);
            this.lblIdDetalle.Name = "lblIdDetalle";
            this.lblIdDetalle.Size = new System.Drawing.Size(52, 13);
            this.lblIdDetalle.TabIndex = 1;
            this.lblIdDetalle.Text = "Id Detalle";
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Location = new System.Drawing.Point(173, 95);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtIdDetalle.TabIndex = 3;
            this.txtIdDetalle.Tag = "id_det_examen";
            // 
            // lblIdPacientes
            // 
            this.lblIdPacientes.AutoSize = true;
            this.lblIdPacientes.Location = new System.Drawing.Point(302, 98);
            this.lblIdPacientes.Name = "lblIdPacientes";
            this.lblIdPacientes.Size = new System.Drawing.Size(65, 13);
            this.lblIdPacientes.TabIndex = 4;
            this.lblIdPacientes.Text = "Id pacientes";
            // 
            // lblIdTipoExamen
            // 
            this.lblIdTipoExamen.AutoSize = true;
            this.lblIdTipoExamen.Location = new System.Drawing.Point(72, 137);
            this.lblIdTipoExamen.Name = "lblIdTipoExamen";
            this.lblIdTipoExamen.Size = new System.Drawing.Size(76, 13);
            this.lblIdTipoExamen.TabIndex = 5;
            this.lblIdTipoExamen.Text = "Id tipo examen";
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.AutoSize = true;
            this.lblIdMedico.Location = new System.Drawing.Point(302, 138);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(53, 13);
            this.lblIdMedico.TabIndex = 6;
            this.lblIdMedico.Text = "Id medico";
            // 
            // txtIdPacientes
            // 
            this.txtIdPacientes.Location = new System.Drawing.Point(402, 98);
            this.txtIdPacientes.Name = "txtIdPacientes";
            this.txtIdPacientes.Size = new System.Drawing.Size(100, 20);
            this.txtIdPacientes.TabIndex = 7;
            this.txtIdPacientes.Tag = "id_pacientes";
            // 
            // txtIdTipoExamen
            // 
            this.txtIdTipoExamen.Location = new System.Drawing.Point(173, 138);
            this.txtIdTipoExamen.Name = "txtIdTipoExamen";
            this.txtIdTipoExamen.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoExamen.TabIndex = 8;
            this.txtIdTipoExamen.Tag = "id_tipo_examen";
            this.txtIdTipoExamen.TextChanged += new System.EventHandler(this.txtIdTipoExamen_TextChanged);
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(402, 138);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(100, 20);
            this.txtIdMedico.TabIndex = 9;
            this.txtIdMedico.Tag = "id_medico";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(59, 212);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 158);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(6, 3);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(487, 121);
            this.cuDataGridD1.STabla = "det_examen";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            this.cuDataGridD1.Load += new System.EventHandler(this.cuDataGridD1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cuDataGridD2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipo Examen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(3, 4);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(490, 125);
            this.cuDataGridD2.STabla = "tipo_examen";
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
            this.tabPage3.Size = new System.Drawing.Size(499, 132);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Medico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD3
            // 
            this.cuDataGridD3.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD3.AlDatosEntrada")));
            this.cuDataGridD3.Location = new System.Drawing.Point(3, 3);
            this.cuDataGridD3.Name = "cuDataGridD3";
            this.cuDataGridD3.SCampo = "Codigo";
            this.cuDataGridD3.Size = new System.Drawing.Size(490, 123);
            this.cuDataGridD3.STabla = "medico";
            this.cuDataGridD3.TabIndex = 0;
            this.cuDataGridD3.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD3_sdgv_CellClick);
            this.cuDataGridD3.Load += new System.EventHandler(this.cuDataGridD3_Load);
            // 
            // wfDetExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 382);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.txtIdTipoExamen);
            this.Controls.Add(this.txtIdPacientes);
            this.Controls.Add(this.lblIdMedico);
            this.Controls.Add(this.lblIdTipoExamen);
            this.Controls.Add(this.lblIdPacientes);
            this.Controls.Add(this.txtIdDetalle);
            this.Controls.Add(this.lblIdDetalle);
            this.Controls.Add(this.navegador1);
            this.Name = "wfDetExamen";
            this.Text = "wfDetExamen";
            this.Load += new System.EventHandler(this.wfDetExamen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblIdDetalle;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Label lblIdPacientes;
        private System.Windows.Forms.Label lblIdTipoExamen;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.TextBox txtIdPacientes;
        private System.Windows.Forms.TextBox txtIdTipoExamen;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private System.Windows.Forms.TabPage tabPage2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private System.Windows.Forms.TabPage tabPage3;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD3;
    }
}