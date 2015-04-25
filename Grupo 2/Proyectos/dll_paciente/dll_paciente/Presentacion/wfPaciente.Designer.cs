namespace dll_paciente.Presentacion
{
    partial class wfPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPaciente));
            this.lblID = new System.Windows.Forms.Label();
            this.lblNomPac = new System.Windows.Forms.Label();
            this.lblPrimerAp = new System.Windows.Forms.Label();
            this.lblSegundoApe = new System.Windows.Forms.Label();
            this.lblDire = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtprimerAp = new System.Windows.Forms.TextBox();
            this.txtSegundoApe = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.txtsangre = new System.Windows.Forms.TextBox();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.navegador1 = new Navegador.Navegador();
            this.lbltel = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 101);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID paciente";
            // 
            // lblNomPac
            // 
            this.lblNomPac.AutoSize = true;
            this.lblNomPac.Location = new System.Drawing.Point(41, 141);
            this.lblNomPac.Name = "lblNomPac";
            this.lblNomPac.Size = new System.Drawing.Size(89, 13);
            this.lblNomPac.TabIndex = 2;
            this.lblNomPac.Text = "Nombre Paciente";
            // 
            // lblPrimerAp
            // 
            this.lblPrimerAp.AutoSize = true;
            this.lblPrimerAp.Location = new System.Drawing.Point(331, 141);
            this.lblPrimerAp.Name = "lblPrimerAp";
            this.lblPrimerAp.Size = new System.Drawing.Size(76, 13);
            this.lblPrimerAp.TabIndex = 3;
            this.lblPrimerAp.Text = "Primer Apellido";
            // 
            // lblSegundoApe
            // 
            this.lblSegundoApe.AutoSize = true;
            this.lblSegundoApe.Location = new System.Drawing.Point(38, 178);
            this.lblSegundoApe.Name = "lblSegundoApe";
            this.lblSegundoApe.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoApe.TabIndex = 4;
            this.lblSegundoApe.Text = "Segundo Apellido";
            // 
            // lblDire
            // 
            this.lblDire.AutoSize = true;
            this.lblDire.Location = new System.Drawing.Point(331, 178);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(52, 13);
            this.lblDire.TabIndex = 5;
            this.lblDire.Text = "Direccion";
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(83, 95);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(45, 20);
            this.txtIDP.TabIndex = 0;
            this.txtIDP.Tag = "id_pacientes";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(150, 134);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            this.txtNom.Tag = "nombre_paciente";
            // 
            // txtprimerAp
            // 
            this.txtprimerAp.Location = new System.Drawing.Point(443, 134);
            this.txtprimerAp.Name = "txtprimerAp";
            this.txtprimerAp.Size = new System.Drawing.Size(100, 20);
            this.txtprimerAp.TabIndex = 5;
            this.txtprimerAp.Tag = "primer_apellido";
            // 
            // txtSegundoApe
            // 
            this.txtSegundoApe.Location = new System.Drawing.Point(150, 171);
            this.txtSegundoApe.Name = "txtSegundoApe";
            this.txtSegundoApe.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoApe.TabIndex = 6;
            this.txtSegundoApe.Tag = "segundo_apellido";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(443, 171);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(167, 20);
            this.txtdireccion.TabIndex = 7;
            this.txtdireccion.Tag = "direccion_paciente";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(169, 99);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(46, 13);
            this.lblEstatura.TabIndex = 11;
            this.lblEstatura.Text = "Estatura";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(221, 93);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(52, 20);
            this.txtEstatura.TabIndex = 1;
            this.txtEstatura.Tag = "estatura_paciente";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(306, 100);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 13;
            this.lblPeso.Text = "Peso";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(343, 92);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(64, 20);
            this.txtpeso.TabIndex = 2;
            this.txtpeso.Tag = "peso_paciente";
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.Location = new System.Drawing.Point(44, 259);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(41, 13);
            this.lblSangre.TabIndex = 15;
            this.lblSangre.Text = "Sangre";
            // 
            // txtsangre
            // 
            this.txtsangre.Location = new System.Drawing.Point(254, 253);
            this.txtsangre.Name = "txtsangre";
            this.txtsangre.Size = new System.Drawing.Size(30, 20);
            this.txtsangre.TabIndex = 16;
            this.txtsangre.Tag = "sangre_paciente";
            this.txtsangre.Text = "A+";
            this.txtsangre.Visible = false;
            this.txtsangre.TextChanged += new System.EventHandler(this.txtsangre_TextChanged);
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Location = new System.Drawing.Point(41, 220);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblidentificacion.TabIndex = 17;
            this.lblidentificacion.Text = "Identificacion";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(150, 213);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtidentificacion.TabIndex = 8;
            this.txtidentificacion.Tag = "identificacion_paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(443, 213);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 9;
            this.txtfecha.Tag = "fecha_nacimiento_paciente";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(417, 100);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 21;
            this.lblestado.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(590, 94);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(29, 20);
            this.txtestado.TabIndex = 22;
            this.txtestado.Tag = "estado";
            this.txtestado.Visible = false;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(476, 94);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(108, 21);
            this.cbEstado.TabIndex = 3;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbSangre
            // 
            this.cbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbSangre.Location = new System.Drawing.Point(148, 251);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(100, 21);
            this.cbSangre.TabIndex = 10;
            this.cbSangre.SelectedIndexChanged += new System.EventHandler(this.cbSangre_SelectedIndexChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "paciente";
            this.navegador1.TabIndex = 12;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(331, 260);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(49, 13);
            this.lbltel.TabIndex = 26;
            this.lbltel.Text = "Teléfono";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(443, 252);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 11;
            this.txttel.Tag = "telefono_paciente";
            // 
            // wfPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 293);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cbSangre);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.lblidentificacion);
            this.Controls.Add(this.txtsangre);
            this.Controls.Add(this.lblSangre);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtSegundoApe);
            this.Controls.Add(this.txtprimerAp);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtIDP);
            this.Controls.Add(this.lblDire);
            this.Controls.Add(this.lblSegundoApe);
            this.Controls.Add(this.lblPrimerAp);
            this.Controls.Add(this.lblNomPac);
            this.Controls.Add(this.lblID);
            this.Name = "wfPaciente";
            this.Text = "wfPaciente";
            this.Load += new System.EventHandler(this.wfPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNomPac;
        private System.Windows.Forms.Label lblPrimerAp;
        private System.Windows.Forms.Label lblSegundoApe;
        private System.Windows.Forms.Label lblDire;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtprimerAp;
        private System.Windows.Forms.TextBox txtSegundoApe;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.TextBox txtsangre;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbSangre;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txttel;
    }
}