namespace dll_seguridad.Presentacion
{
    partial class wfDetMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetMod));
            this.lblIDDetMod = new System.Windows.Forms.Label();
            this.txtIDDetMod = new System.Windows.Forms.TextBox();
            this.lblCodMod = new System.Windows.Forms.Label();
            this.txtIDModulo = new System.Windows.Forms.TextBox();
            this.lblCodPerf = new System.Windows.Forms.Label();
            this.txtCodPerf = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cuDataGridD1 = new dll_bitacora.Presentacion.cuDataGridD();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cuDataGridD2 = new dll_bitacora.Presentacion.cuDataGridD();
            this.lblfecC = new System.Windows.Forms.Label();
            this.txtfecC = new System.Windows.Forms.TextBox();
            this.lblfecm = new System.Windows.Forms.Label();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIDDetMod
            // 
            this.lblIDDetMod.AutoSize = true;
            this.lblIDDetMod.Location = new System.Drawing.Point(45, 93);
            this.lblIDDetMod.Name = "lblIDDetMod";
            this.lblIDDetMod.Size = new System.Drawing.Size(40, 13);
            this.lblIDDetMod.TabIndex = 0;
            this.lblIDDetMod.Text = "Código";
            // 
            // txtIDDetMod
            // 
            this.txtIDDetMod.Location = new System.Drawing.Point(91, 86);
            this.txtIDDetMod.Name = "txtIDDetMod";
            this.txtIDDetMod.Size = new System.Drawing.Size(27, 20);
            this.txtIDDetMod.TabIndex = 1;
            this.txtIDDetMod.Tag = "id_detmod";
            // 
            // lblCodMod
            // 
            this.lblCodMod.AutoSize = true;
            this.lblCodMod.Location = new System.Drawing.Point(145, 93);
            this.lblCodMod.Name = "lblCodMod";
            this.lblCodMod.Size = new System.Drawing.Size(78, 13);
            this.lblCodMod.TabIndex = 2;
            this.lblCodMod.Text = "Codigo Modulo";
            // 
            // txtIDModulo
            // 
            this.txtIDModulo.Location = new System.Drawing.Point(229, 86);
            this.txtIDModulo.Name = "txtIDModulo";
            this.txtIDModulo.Size = new System.Drawing.Size(27, 20);
            this.txtIDModulo.TabIndex = 3;
            this.txtIDModulo.Tag = "id_modulo";
            // 
            // lblCodPerf
            // 
            this.lblCodPerf.AutoSize = true;
            this.lblCodPerf.Location = new System.Drawing.Point(281, 93);
            this.lblCodPerf.Name = "lblCodPerf";
            this.lblCodPerf.Size = new System.Drawing.Size(66, 13);
            this.lblCodPerf.TabIndex = 4;
            this.lblCodPerf.Text = "Codigo Perfil";
            // 
            // txtCodPerf
            // 
            this.txtCodPerf.Location = new System.Drawing.Point(353, 86);
            this.txtCodPerf.Name = "txtCodPerf";
            this.txtCodPerf.Size = new System.Drawing.Size(27, 20);
            this.txtCodPerf.TabIndex = 5;
            this.txtCodPerf.Tag = "codigo_perfil";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(416, 93);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(567, 86);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(27, 20);
            this.txtestado.TabIndex = 7;
            this.txtestado.Tag = "estado";
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(28, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "detalle_modulo";
            this.navegador1.TabIndex = 8;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(462, 85);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(99, 21);
            this.cbEstado.TabIndex = 9;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(48, 164);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 172);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cuDataGridD1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 146);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modulo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD1
            // 
            this.cuDataGridD1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD1.AlDatosEntrada")));
            this.cuDataGridD1.Location = new System.Drawing.Point(3, 7);
            this.cuDataGridD1.Name = "cuDataGridD1";
            this.cuDataGridD1.SCampo = "Codigo";
            this.cuDataGridD1.Size = new System.Drawing.Size(543, 133);
            this.cuDataGridD1.STabla = "modulo";
            this.cuDataGridD1.TabIndex = 0;
            this.cuDataGridD1.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD1_sdgv_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cuDataGridD2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuDataGridD2
            // 
            this.cuDataGridD2.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridD2.AlDatosEntrada")));
            this.cuDataGridD2.Location = new System.Drawing.Point(0, 4);
            this.cuDataGridD2.Name = "cuDataGridD2";
            this.cuDataGridD2.SCampo = "Codigo";
            this.cuDataGridD2.Size = new System.Drawing.Size(546, 136);
            this.cuDataGridD2.STabla = "perfil";
            this.cuDataGridD2.TabIndex = 0;
            this.cuDataGridD2.sdgv_CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuDataGridD2_sdgv_CellClick);
            // 
            // lblfecC
            // 
            this.lblfecC.AutoSize = true;
            this.lblfecC.Location = new System.Drawing.Point(45, 134);
            this.lblfecC.Name = "lblfecC";
            this.lblfecC.Size = new System.Drawing.Size(82, 13);
            this.lblfecC.TabIndex = 11;
            this.lblfecC.Text = "Fecha Creación";
            // 
            // txtfecC
            // 
            this.txtfecC.Location = new System.Drawing.Point(133, 126);
            this.txtfecC.Name = "txtfecC";
            this.txtfecC.Size = new System.Drawing.Size(100, 20);
            this.txtfecC.TabIndex = 12;
            this.txtfecC.Tag = "fecha_creacion";
            // 
            // lblfecm
            // 
            this.lblfecm.AutoSize = true;
            this.lblfecm.Location = new System.Drawing.Point(311, 133);
            this.lblfecm.Name = "lblfecm";
            this.lblfecm.Size = new System.Drawing.Size(100, 13);
            this.lblfecm.TabIndex = 13;
            this.lblfecm.Text = "Fecha Modificación";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(419, 125);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 14;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // wfDetMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.lblfecm);
            this.Controls.Add(this.txtfecC);
            this.Controls.Add(this.lblfecC);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCodPerf);
            this.Controls.Add(this.lblCodPerf);
            this.Controls.Add(this.txtIDModulo);
            this.Controls.Add(this.lblCodMod);
            this.Controls.Add(this.txtIDDetMod);
            this.Controls.Add(this.lblIDDetMod);
            this.Name = "wfDetMod";
            this.Text = "Detalle de Modulo";
            this.Load += new System.EventHandler(this.wfDetMod_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDDetMod;
        private System.Windows.Forms.TextBox txtIDDetMod;
        private System.Windows.Forms.Label lblCodMod;
        private System.Windows.Forms.TextBox txtIDModulo;
        private System.Windows.Forms.Label lblCodPerf;
        private System.Windows.Forms.TextBox txtCodPerf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtestado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD1;
        private dll_bitacora.Presentacion.cuDataGridD cuDataGridD2;
        private System.Windows.Forms.Label lblfecC;
        private System.Windows.Forms.TextBox txtfecC;
        private System.Windows.Forms.Label lblfecm;
        private System.Windows.Forms.TextBox txtfecm;
    }
}