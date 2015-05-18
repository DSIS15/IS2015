namespace dll_seguridad.Presentacion
{
    partial class wfRoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfRoll));
            this.navegador1 = new Navegador.Navegador();
            this.lblIDroll = new System.Windows.Forms.Label();
            this.txtIDRoll = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtnomroll = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.lblfecc = new System.Windows.Forms.Label();
            this.lblfecm = new System.Windows.Forms.Label();
            this.txtfecc = new System.Windows.Forms.TextBox();
            this.txtfecm = new System.Windows.Forms.TextBox();
            this.lblestadoRoll = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(53, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "roll";
            this.navegador1.TabIndex = 9;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.navegador1_btnBuscar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // lblIDroll
            // 
            this.lblIDroll.AutoSize = true;
            this.lblIDroll.Location = new System.Drawing.Point(25, 89);
            this.lblIDroll.Name = "lblIDroll";
            this.lblIDroll.Size = new System.Drawing.Size(39, 13);
            this.lblIDroll.TabIndex = 10;
            this.lblIDroll.Text = "ID Roll";
            // 
            // txtIDRoll
            // 
            this.txtIDRoll.Location = new System.Drawing.Point(113, 82);
            this.txtIDRoll.Name = "txtIDRoll";
            this.txtIDRoll.Size = new System.Drawing.Size(25, 20);
            this.txtIDRoll.TabIndex = 11;
            this.txtIDRoll.Tag = "id_roll";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(231, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre Roll";
            // 
            // txtnomroll
            // 
            this.txtnomroll.Location = new System.Drawing.Point(337, 84);
            this.txtnomroll.Name = "txtnomroll";
            this.txtnomroll.Size = new System.Drawing.Size(100, 20);
            this.txtnomroll.TabIndex = 13;
            this.txtnomroll.Tag = "nombre_roll";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(467, 134);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(63, 13);
            this.lbldesc.TabIndex = 14;
            this.lbldesc.Text = "Descripción";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(536, 127);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 20);
            this.txtdesc.TabIndex = 15;
            this.txtdesc.Tag = "descripcion";
            // 
            // lblfecc
            // 
            this.lblfecc.AutoSize = true;
            this.lblfecc.Location = new System.Drawing.Point(25, 134);
            this.lblfecc.Name = "lblfecc";
            this.lblfecc.Size = new System.Drawing.Size(82, 13);
            this.lblfecc.TabIndex = 16;
            this.lblfecc.Text = "Fecha Creación";
            // 
            // lblfecm
            // 
            this.lblfecm.AutoSize = true;
            this.lblfecm.Location = new System.Drawing.Point(231, 134);
            this.lblfecm.Name = "lblfecm";
            this.lblfecm.Size = new System.Drawing.Size(100, 13);
            this.lblfecm.TabIndex = 17;
            this.lblfecm.Text = "Fecha Modificación";
            // 
            // txtfecc
            // 
            this.txtfecc.Location = new System.Drawing.Point(113, 127);
            this.txtfecc.Name = "txtfecc";
            this.txtfecc.Size = new System.Drawing.Size(100, 20);
            this.txtfecc.TabIndex = 18;
            this.txtfecc.Tag = "fecha_creacion";
            // 
            // txtfecm
            // 
            this.txtfecm.Location = new System.Drawing.Point(337, 127);
            this.txtfecm.Name = "txtfecm";
            this.txtfecm.Size = new System.Drawing.Size(100, 20);
            this.txtfecm.TabIndex = 19;
            this.txtfecm.Tag = "fecha_modificacion";
            // 
            // lblestadoRoll
            // 
            this.lblestadoRoll.AutoSize = true;
            this.lblestadoRoll.Location = new System.Drawing.Point(467, 91);
            this.lblestadoRoll.Name = "lblestadoRoll";
            this.lblestadoRoll.Size = new System.Drawing.Size(40, 13);
            this.lblestadoRoll.TabIndex = 20;
            this.lblestadoRoll.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(628, 83);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(23, 20);
            this.txtestado.TabIndex = 21;
            this.txtestado.Tag = "estado";
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbestado.Location = new System.Drawing.Point(528, 82);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(94, 21);
            this.cbestado.TabIndex = 22;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // wfRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 238);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblestadoRoll);
            this.Controls.Add(this.txtfecm);
            this.Controls.Add(this.txtfecc);
            this.Controls.Add(this.lblfecm);
            this.Controls.Add(this.lblfecc);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.txtnomroll);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIDRoll);
            this.Controls.Add(this.lblIDroll);
            this.Controls.Add(this.navegador1);
            this.Name = "wfRoll";
            this.Text = "wfRoll";
            this.Load += new System.EventHandler(this.wfRoll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblIDroll;
        private System.Windows.Forms.TextBox txtIDRoll;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtnomroll;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label lblfecc;
        private System.Windows.Forms.Label lblfecm;
        private System.Windows.Forms.TextBox txtfecc;
        private System.Windows.Forms.TextBox txtfecm;
        private System.Windows.Forms.Label lblestadoRoll;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.ComboBox cbestado;
    }
}