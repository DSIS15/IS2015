namespace SIP_Administrativo
{
    partial class wf_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_Clientes));
            this.gboPersonalesCte = new System.Windows.Forms.GroupBox();
            this.cbocodempsa = new System.Windows.Forms.ComboBox();
            this.lblempsa = new System.Windows.Forms.Label();
            this.txtcod_empsa = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.cboestado_cte = new System.Windows.Forms.ComboBox();
            this.txtestado_cte = new System.Windows.Forms.TextBox();
            this.txttel_cte = new System.Windows.Forms.TextBox();
            this.txtdire_cte = new System.Windows.Forms.TextBox();
            this.txtnit_cte = new System.Windows.Forms.TextBox();
            this.txtdpi_cte = new System.Windows.Forms.TextBox();
            this.txtapell2_cte = new System.Windows.Forms.TextBox();
            this.txtapell1_cte = new System.Windows.Forms.TextBox();
            this.txtnom2_cte = new System.Windows.Forms.TextBox();
            this.txtnom1_cte = new System.Windows.Forms.TextBox();
            this.lbldire = new System.Windows.Forms.Label();
            this.lbldpi = new System.Windows.Forms.Label();
            this.lblnom1 = new System.Windows.Forms.Label();
            this.lblnit = new System.Windows.Forms.Label();
            this.lblnom2 = new System.Windows.Forms.Label();
            this.lblape1 = new System.Windows.Forms.Label();
            this.lblape2 = new System.Windows.Forms.Label();
            this.lblcodcte = new System.Windows.Forms.Label();
            this.txtcod_cte = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            this.gboPersonalesCte.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboPersonalesCte
            // 
            this.gboPersonalesCte.Controls.Add(this.button1);
            this.gboPersonalesCte.Controls.Add(this.cbocodempsa);
            this.gboPersonalesCte.Controls.Add(this.lblempsa);
            this.gboPersonalesCte.Controls.Add(this.txtcod_empsa);
            this.gboPersonalesCte.Controls.Add(this.lblestado);
            this.gboPersonalesCte.Controls.Add(this.lbltel);
            this.gboPersonalesCte.Controls.Add(this.cboestado_cte);
            this.gboPersonalesCte.Controls.Add(this.txtestado_cte);
            this.gboPersonalesCte.Controls.Add(this.txttel_cte);
            this.gboPersonalesCte.Controls.Add(this.txtdire_cte);
            this.gboPersonalesCte.Controls.Add(this.txtnit_cte);
            this.gboPersonalesCte.Controls.Add(this.txtdpi_cte);
            this.gboPersonalesCte.Controls.Add(this.txtapell2_cte);
            this.gboPersonalesCte.Controls.Add(this.txtapell1_cte);
            this.gboPersonalesCte.Controls.Add(this.txtnom2_cte);
            this.gboPersonalesCte.Controls.Add(this.txtnom1_cte);
            this.gboPersonalesCte.Controls.Add(this.lbldire);
            this.gboPersonalesCte.Controls.Add(this.lbldpi);
            this.gboPersonalesCte.Controls.Add(this.lblnom1);
            this.gboPersonalesCte.Controls.Add(this.lblnit);
            this.gboPersonalesCte.Controls.Add(this.lblnom2);
            this.gboPersonalesCte.Controls.Add(this.lblape1);
            this.gboPersonalesCte.Controls.Add(this.lblape2);
            this.gboPersonalesCte.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPersonalesCte.Location = new System.Drawing.Point(55, 105);
            this.gboPersonalesCte.Name = "gboPersonalesCte";
            this.gboPersonalesCte.Size = new System.Drawing.Size(612, 196);
            this.gboPersonalesCte.TabIndex = 53;
            this.gboPersonalesCte.TabStop = false;
            this.gboPersonalesCte.Text = "Datos Personales";
            // 
            // cbocodempsa
            // 
            this.cbocodempsa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocodempsa.FormattingEnabled = true;
            this.cbocodempsa.Location = new System.Drawing.Point(121, 26);
            this.cbocodempsa.Name = "cbocodempsa";
            this.cbocodempsa.Size = new System.Drawing.Size(162, 24);
            this.cbocodempsa.TabIndex = 50;
            this.cbocodempsa.SelectedIndexChanged += new System.EventHandler(this.cbocodempsa_SelectedIndexChanged);
            // 
            // lblempsa
            // 
            this.lblempsa.AutoSize = true;
            this.lblempsa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempsa.Location = new System.Drawing.Point(25, 30);
            this.lblempsa.Name = "lblempsa";
            this.lblempsa.Size = new System.Drawing.Size(58, 15);
            this.lblempsa.TabIndex = 48;
            this.lblempsa.Text = "Empresa:";
            // 
            // txtcod_empsa
            // 
            this.txtcod_empsa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_empsa.Location = new System.Drawing.Point(289, 27);
            this.txtcod_empsa.Name = "txtcod_empsa";
            this.txtcod_empsa.Size = new System.Drawing.Size(29, 21);
            this.txtcod_empsa.TabIndex = 49;
            this.txtcod_empsa.Tag = "cod_empsa";
            this.txtcod_empsa.TextChanged += new System.EventHandler(this.txtcod_empsa_TextChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(298, 163);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(46, 15);
            this.lblestado.TabIndex = 33;
            this.lblestado.Text = "Estado";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(23, 166);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(52, 15);
            this.lbltel.TabIndex = 32;
            this.lbltel.Text = "Telefono";
            // 
            // cboestado_cte
            // 
            this.cboestado_cte.FormattingEnabled = true;
            this.cboestado_cte.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cboestado_cte.Location = new System.Drawing.Point(410, 161);
            this.cboestado_cte.Name = "cboestado_cte";
            this.cboestado_cte.Size = new System.Drawing.Size(160, 23);
            this.cboestado_cte.TabIndex = 31;
            this.cboestado_cte.SelectedIndexChanged += new System.EventHandler(this.cboestado_cte_SelectedIndexChanged);
            // 
            // txtestado_cte
            // 
            this.txtestado_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado_cte.Location = new System.Drawing.Point(384, 161);
            this.txtestado_cte.Name = "txtestado_cte";
            this.txtestado_cte.Size = new System.Drawing.Size(20, 21);
            this.txtestado_cte.TabIndex = 30;
            this.txtestado_cte.Tag = "estado_cte";
            this.txtestado_cte.TextChanged += new System.EventHandler(this.txtestado_cte_TextChanged);
            // 
            // txttel_cte
            // 
            this.txttel_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel_cte.Location = new System.Drawing.Point(121, 160);
            this.txttel_cte.Name = "txttel_cte";
            this.txttel_cte.Size = new System.Drawing.Size(160, 21);
            this.txttel_cte.TabIndex = 29;
            this.txttel_cte.Tag = "tel_cte";
            // 
            // txtdire_cte
            // 
            this.txtdire_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdire_cte.Location = new System.Drawing.Point(121, 134);
            this.txtdire_cte.Name = "txtdire_cte";
            this.txtdire_cte.Size = new System.Drawing.Size(449, 21);
            this.txtdire_cte.TabIndex = 28;
            this.txtdire_cte.Tag = "dire_cte";
            // 
            // txtnit_cte
            // 
            this.txtnit_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit_cte.Location = new System.Drawing.Point(410, 106);
            this.txtnit_cte.Name = "txtnit_cte";
            this.txtnit_cte.Size = new System.Drawing.Size(160, 21);
            this.txtnit_cte.TabIndex = 27;
            this.txtnit_cte.Tag = "nit_cte";
            // 
            // txtdpi_cte
            // 
            this.txtdpi_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdpi_cte.Location = new System.Drawing.Point(121, 107);
            this.txtdpi_cte.Name = "txtdpi_cte";
            this.txtdpi_cte.Size = new System.Drawing.Size(160, 21);
            this.txtdpi_cte.TabIndex = 26;
            this.txtdpi_cte.Tag = "dpi_cte";
            // 
            // txtapell2_cte
            // 
            this.txtapell2_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapell2_cte.Location = new System.Drawing.Point(410, 79);
            this.txtapell2_cte.Name = "txtapell2_cte";
            this.txtapell2_cte.Size = new System.Drawing.Size(160, 21);
            this.txtapell2_cte.TabIndex = 25;
            this.txtapell2_cte.Tag = "apell2_cte";
            // 
            // txtapell1_cte
            // 
            this.txtapell1_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapell1_cte.Location = new System.Drawing.Point(121, 80);
            this.txtapell1_cte.Name = "txtapell1_cte";
            this.txtapell1_cte.Size = new System.Drawing.Size(161, 21);
            this.txtapell1_cte.TabIndex = 24;
            this.txtapell1_cte.Tag = "apell1_cte";
            // 
            // txtnom2_cte
            // 
            this.txtnom2_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom2_cte.Location = new System.Drawing.Point(410, 51);
            this.txtnom2_cte.Name = "txtnom2_cte";
            this.txtnom2_cte.Size = new System.Drawing.Size(160, 21);
            this.txtnom2_cte.TabIndex = 23;
            this.txtnom2_cte.Tag = "nom2_cte";
            // 
            // txtnom1_cte
            // 
            this.txtnom1_cte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom1_cte.Location = new System.Drawing.Point(121, 54);
            this.txtnom1_cte.Name = "txtnom1_cte";
            this.txtnom1_cte.Size = new System.Drawing.Size(160, 21);
            this.txtnom1_cte.TabIndex = 22;
            this.txtnom1_cte.Tag = "nom1_cte";
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldire.Location = new System.Drawing.Point(23, 134);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(60, 15);
            this.lbldire.TabIndex = 21;
            this.lbldire.Text = "Dirección";
            // 
            // lbldpi
            // 
            this.lbldpi.AutoSize = true;
            this.lbldpi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldpi.Location = new System.Drawing.Point(23, 107);
            this.lbldpi.Name = "lbldpi";
            this.lbldpi.Size = new System.Drawing.Size(25, 15);
            this.lbldpi.TabIndex = 15;
            this.lbldpi.Text = "DPI";
            // 
            // lblnom1
            // 
            this.lblnom1.AutoSize = true;
            this.lblnom1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom1.Location = new System.Drawing.Point(23, 57);
            this.lblnom1.Name = "lblnom1";
            this.lblnom1.Size = new System.Drawing.Size(92, 15);
            this.lblnom1.TabIndex = 17;
            this.lblnom1.Text = "Primer Nombre:";
            // 
            // lblnit
            // 
            this.lblnit.AutoSize = true;
            this.lblnit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnit.Location = new System.Drawing.Point(298, 107);
            this.lblnit.Name = "lblnit";
            this.lblnit.Size = new System.Drawing.Size(23, 15);
            this.lblnit.TabIndex = 16;
            this.lblnit.Text = "NIT";
            // 
            // lblnom2
            // 
            this.lblnom2.AutoSize = true;
            this.lblnom2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom2.Location = new System.Drawing.Point(298, 54);
            this.lblnom2.Name = "lblnom2";
            this.lblnom2.Size = new System.Drawing.Size(106, 15);
            this.lblnom2.TabIndex = 18;
            this.lblnom2.Text = "Segundo Nombre:";
            // 
            // lblape1
            // 
            this.lblape1.AutoSize = true;
            this.lblape1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblape1.Location = new System.Drawing.Point(23, 82);
            this.lblape1.Name = "lblape1";
            this.lblape1.Size = new System.Drawing.Size(93, 15);
            this.lblape1.TabIndex = 19;
            this.lblape1.Text = "Primer Apellido:";
            // 
            // lblape2
            // 
            this.lblape2.AutoSize = true;
            this.lblape2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblape2.Location = new System.Drawing.Point(298, 80);
            this.lblape2.Name = "lblape2";
            this.lblape2.Size = new System.Drawing.Size(107, 15);
            this.lblape2.TabIndex = 20;
            this.lblape2.Text = "Segundo Apellido:";
            // 
            // lblcodcte
            // 
            this.lblcodcte.AutoSize = true;
            this.lblcodcte.Location = new System.Drawing.Point(506, 82);
            this.lblcodcte.Name = "lblcodcte";
            this.lblcodcte.Size = new System.Drawing.Size(75, 13);
            this.lblcodcte.TabIndex = 58;
            this.lblcodcte.Text = "Codigo Cliente";
            // 
            // txtcod_cte
            // 
            this.txtcod_cte.Location = new System.Drawing.Point(602, 79);
            this.txtcod_cte.Name = "txtcod_cte";
            this.txtcod_cte.Size = new System.Drawing.Size(49, 20);
            this.txtcod_cte.TabIndex = 57;
            this.txtcod_cte.Tag = "cod_cte";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(55, 14);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_cliente";
            this.navegador1.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(410, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wf_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 331);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblcodcte);
            this.Controls.Add(this.txtcod_cte);
            this.Controls.Add(this.gboPersonalesCte);
            this.Name = "wf_Clientes";
            this.Text = "SIP - Clientes";
            this.Load += new System.EventHandler(this.wf_Clientes_Load);
            this.gboPersonalesCte.ResumeLayout(false);
            this.gboPersonalesCte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboPersonalesCte;
        private System.Windows.Forms.TextBox txtdire_cte;
        private System.Windows.Forms.TextBox txtnit_cte;
        private System.Windows.Forms.TextBox txtdpi_cte;
        private System.Windows.Forms.TextBox txtapell2_cte;
        private System.Windows.Forms.TextBox txtapell1_cte;
        private System.Windows.Forms.TextBox txtnom2_cte;
        private System.Windows.Forms.TextBox txtnom1_cte;
        private System.Windows.Forms.Label lbldire;
        private System.Windows.Forms.Label lbldpi;
        private System.Windows.Forms.Label lblnom1;
        private System.Windows.Forms.Label lblnit;
        private System.Windows.Forms.Label lblnom2;
        private System.Windows.Forms.Label lblape1;
        private System.Windows.Forms.Label lblape2;
        private System.Windows.Forms.TextBox txtestado_cte;
        private System.Windows.Forms.TextBox txttel_cte;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.ComboBox cboestado_cte;
        private System.Windows.Forms.Label lblcodcte;
        private System.Windows.Forms.TextBox txtcod_cte;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbocodempsa;
        private System.Windows.Forms.Label lblempsa;
        private System.Windows.Forms.TextBox txtcod_empsa;
        private System.Windows.Forms.Button button1;
    }
}