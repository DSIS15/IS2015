namespace dll_seguridad.Presentacion
{
    partial class wfModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfModulo));
            this.lblIDmodulo = new System.Windows.Forms.Label();
            this.lblNomModulo = new System.Windows.Forms.Label();
            this.txtIDModulo = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.lblNomDLL = new System.Windows.Forms.Label();
            this.txtNombreDLL = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblfecC = new System.Windows.Forms.Label();
            this.lblfecm = new System.Windows.Forms.Label();
            this.txtfecc = new System.Windows.Forms.TextBox();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIDmodulo
            // 
            this.lblIDmodulo.AutoSize = true;
            this.lblIDmodulo.Location = new System.Drawing.Point(29, 108);
            this.lblIDmodulo.Name = "lblIDmodulo";
            this.lblIDmodulo.Size = new System.Drawing.Size(56, 13);
            this.lblIDmodulo.TabIndex = 0;
            this.lblIDmodulo.Text = "ID Modulo";
            // 
            // lblNomModulo
            // 
            this.lblNomModulo.AutoSize = true;
            this.lblNomModulo.Location = new System.Drawing.Point(29, 147);
            this.lblNomModulo.Name = "lblNomModulo";
            this.lblNomModulo.Size = new System.Drawing.Size(82, 13);
            this.lblNomModulo.TabIndex = 1;
            this.lblNomModulo.Text = "Nombre Modulo";
            // 
            // txtIDModulo
            // 
            this.txtIDModulo.Location = new System.Drawing.Point(127, 102);
            this.txtIDModulo.Name = "txtIDModulo";
            this.txtIDModulo.Size = new System.Drawing.Size(31, 20);
            this.txtIDModulo.TabIndex = 1;
            this.txtIDModulo.Tag = "id_modulo";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(127, 140);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMod.TabIndex = 3;
            this.txtNombreMod.Tag = "nombre_modulo";
            // 
            // lblNomDLL
            // 
            this.lblNomDLL.AutoSize = true;
            this.lblNomDLL.Location = new System.Drawing.Point(260, 108);
            this.lblNomDLL.Name = "lblNomDLL";
            this.lblNomDLL.Size = new System.Drawing.Size(67, 13);
            this.lblNomDLL.TabIndex = 4;
            this.lblNomDLL.Text = "Nombre DLL";
            // 
            // txtNombreDLL
            // 
            this.txtNombreDLL.Location = new System.Drawing.Point(359, 102);
            this.txtNombreDLL.Name = "txtNombreDLL";
            this.txtNombreDLL.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDLL.TabIndex = 2;
            this.txtNombreDLL.Tag = "nombre_dll";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(499, 108);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(709, 103);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(19, 20);
            this.txtestado.TabIndex = 6;
            this.txtestado.Tag = "estado";
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(79, 23);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "modulo";
            this.navegador1.TabIndex = 8;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(608, 105);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // lblfecC
            // 
            this.lblfecC.AutoSize = true;
            this.lblfecC.Location = new System.Drawing.Point(260, 146);
            this.lblfecC.Name = "lblfecC";
            this.lblfecC.Size = new System.Drawing.Size(82, 13);
            this.lblfecC.TabIndex = 9;
            this.lblfecC.Text = "Fecha Creacion";
            // 
            // lblfecm
            // 
            this.lblfecm.AutoSize = true;
            this.lblfecm.Location = new System.Drawing.Point(499, 147);
            this.lblfecm.Name = "lblfecm";
            this.lblfecm.Size = new System.Drawing.Size(100, 13);
            this.lblfecm.TabIndex = 10;
            this.lblfecm.Text = "Fecha Modificacoin";
            // 
            // txtfecc
            // 
            this.txtfecc.Location = new System.Drawing.Point(359, 139);
            this.txtfecc.Name = "txtfecc";
            this.txtfecc.Size = new System.Drawing.Size(100, 20);
            this.txtfecc.TabIndex = 11;
            this.txtfecc.Tag = "fecha_creacion";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(608, 140);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 12;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // wfModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 196);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.txtfecc);
            this.Controls.Add(this.lblfecm);
            this.Controls.Add(this.lblfecC);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNombreDLL);
            this.Controls.Add(this.lblNomDLL);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.txtIDModulo);
            this.Controls.Add(this.lblNomModulo);
            this.Controls.Add(this.lblIDmodulo);
            this.Name = "wfModulo";
            this.Text = "Crear Modulo";
            this.Load += new System.EventHandler(this.wfModulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDmodulo;
        private System.Windows.Forms.Label lblNomModulo;
        private System.Windows.Forms.TextBox txtIDModulo;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label lblNomDLL;
        private System.Windows.Forms.TextBox txtNombreDLL;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtestado;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblfecC;
        private System.Windows.Forms.Label lblfecm;
        private System.Windows.Forms.TextBox txtfecc;
        private System.Windows.Forms.TextBox txtfecm;
    }
}