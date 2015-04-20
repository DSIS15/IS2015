namespace dll_seguridad.Presentacion
{
    partial class wfPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPerfiles));
            this.lblCodPerfil = new System.Windows.Forms.Label();
            this.lblNombre_perfil = new System.Windows.Forms.Label();
            this.lblEstadoPerf = new System.Windows.Forms.Label();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblfecCreaPerf = new System.Windows.Forms.Label();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblfecmPerf = new System.Windows.Forms.Label();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodPerfil
            // 
            this.lblCodPerfil.AutoSize = true;
            this.lblCodPerfil.Location = new System.Drawing.Point(29, 109);
            this.lblCodPerfil.Name = "lblCodPerfil";
            this.lblCodPerfil.Size = new System.Drawing.Size(66, 13);
            this.lblCodPerfil.TabIndex = 0;
            this.lblCodPerfil.Text = "Codigo Perfil";
            // 
            // lblNombre_perfil
            // 
            this.lblNombre_perfil.AutoSize = true;
            this.lblNombre_perfil.Location = new System.Drawing.Point(374, 108);
            this.lblNombre_perfil.Name = "lblNombre_perfil";
            this.lblNombre_perfil.Size = new System.Drawing.Size(70, 13);
            this.lblNombre_perfil.TabIndex = 1;
            this.lblNombre_perfil.Text = "Nombre Perfil";
            // 
            // lblEstadoPerf
            // 
            this.lblEstadoPerf.AutoSize = true;
            this.lblEstadoPerf.Location = new System.Drawing.Point(175, 109);
            this.lblEstadoPerf.Name = "lblEstadoPerf";
            this.lblEstadoPerf.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoPerf.TabIndex = 2;
            this.lblEstadoPerf.Text = "Estado";
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Enabled = false;
            this.txtCodPerfil.Location = new System.Drawing.Point(117, 102);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(26, 20);
            this.txtCodPerfil.TabIndex = 1;
            this.txtCodPerfil.Tag = "codigo_perfil";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(333, 101);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(21, 20);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(452, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tag = "nombre_perfil";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(15, 21);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "perfil";
            this.navegador1.TabIndex = 6;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_BeforeClick += new System.EventHandler(this.navegador1_btnModificar_BeforeClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            // 
            // lblfecCreaPerf
            // 
            this.lblfecCreaPerf.AutoSize = true;
            this.lblfecCreaPerf.Location = new System.Drawing.Point(29, 152);
            this.lblfecCreaPerf.Name = "lblfecCreaPerf";
            this.lblfecCreaPerf.Size = new System.Drawing.Size(82, 13);
            this.lblfecCreaPerf.TabIndex = 7;
            this.lblfecCreaPerf.Text = "Fecha Creación";
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(125, 145);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(100, 20);
            this.txtfech.TabIndex = 4;
            this.txtfech.Tag = "fecha_creacion";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(231, 101);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbEstado.TabIndex = 2;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblfecmPerf
            // 
            this.lblfecmPerf.AutoSize = true;
            this.lblfecmPerf.Location = new System.Drawing.Point(254, 152);
            this.lblfecmPerf.Name = "lblfecmPerf";
            this.lblfecmPerf.Size = new System.Drawing.Size(100, 13);
            this.lblfecmPerf.TabIndex = 8;
            this.lblfecmPerf.Text = "Fecha Modificación";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(360, 145);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 9;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "EN-US",
            "ES-CO",
            "JA-JP"});
            this.listBox1.Location = new System.Drawing.Point(563, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(50, 43);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(606, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 43);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // wfPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 197);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.lblfecmPerf);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.lblfecCreaPerf);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.lblEstadoPerf);
            this.Controls.Add(this.lblNombre_perfil);
            this.Controls.Add(this.lblCodPerfil);
            this.Name = "wfPerfiles";
            this.Text = "Crear Perfil";
            this.Load += new System.EventHandler(this.wfPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPerfil;
        private System.Windows.Forms.Label lblNombre_perfil;
        private System.Windows.Forms.Label lblEstadoPerf;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblfecCreaPerf;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblfecmPerf;
        private System.Windows.Forms.TextBox txtfecm;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}