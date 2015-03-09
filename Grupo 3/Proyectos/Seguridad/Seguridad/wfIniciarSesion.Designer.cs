namespace Seguridad
{
    partial class wfIniciarSesion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfIniciarSesion));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tmrRelojEntrada = new System.Windows.Forms.Timer(this.components);
            this.tmrRelojSalida = new System.Windows.Forms.Timer(this.components);
            this.pnlPanel1 = new System.Windows.Forms.Panel();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.btnConfigBaseDatos = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(7, 253);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(87, 220);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 250);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // tmrRelojEntrada
            // 
            this.tmrRelojEntrada.Tick += new System.EventHandler(this.tmrRelojEntrada_Tick);
            // 
            // tmrRelojSalida
            // 
            this.tmrRelojSalida.Tick += new System.EventHandler(this.tmrRelojSalida_Tick);
            // 
            // pnlPanel1
            // 
            this.pnlPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPanel1.Controls.Add(this.pboLogo);
            this.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(270, 156);
            this.pnlPanel1.TabIndex = 13;
            // 
            // pboLogo
            // 
            this.pboLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboLogo.Image")));
            this.pboLogo.Location = new System.Drawing.Point(6, 7);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(258, 141);
            this.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboLogo.TabIndex = 14;
            this.pboLogo.TabStop = false;
            // 
            // btnConfigBaseDatos
            // 
            this.btnConfigBaseDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfigBaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigBaseDatos.Image")));
            this.btnConfigBaseDatos.Location = new System.Drawing.Point(222, 167);
            this.btnConfigBaseDatos.Name = "btnConfigBaseDatos";
            this.btnConfigBaseDatos.Size = new System.Drawing.Size(40, 40);
            this.btnConfigBaseDatos.TabIndex = 5;
            this.btnConfigBaseDatos.UseVisualStyleBackColor = false;
            this.btnConfigBaseDatos.Click += new System.EventHandler(this.btnConfigBaseDatos_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(7, 188);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(181, 18);
            this.lblTitulo2.TabIndex = 20;
            this.lblTitulo2.Text = "CONTABLE-FINANCIERO";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(7, 169);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(84, 18);
            this.lblTitulo1.TabIndex = 19;
            this.lblTitulo1.Text = "SOFTWARE";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIniciarSesion.Location = new System.Drawing.Point(0, 286);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(270, 27);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Location = new System.Drawing.Point(0, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(270, 27);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // wfIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 340);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfigBaseDatos);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.pnlPanel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfIniciarSesion";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCF - Iniciar Sesión";
            this.Load += new System.EventHandler(this.wfIniciarSesion_Load);
            this.VisibleChanged += new System.EventHandler(this.wfIniciarSesion_VisibleChanged);
            this.pnlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Timer tmrRelojEntrada;
        private System.Windows.Forms.Timer tmrRelojSalida;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.Button btnConfigBaseDatos;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnSalir;
    }
}