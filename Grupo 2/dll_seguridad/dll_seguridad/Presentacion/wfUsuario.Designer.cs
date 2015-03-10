namespace dll_seguridad.Presentacion
{
    partial class wfUsuario
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
            this.lblIDusuario = new System.Windows.Forms.Label();
            this.lblCodPer = new System.Windows.Forms.Label();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.lblPaswUser = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIDusuario
            // 
            this.lblIDusuario.AutoSize = true;
            this.lblIDusuario.Location = new System.Drawing.Point(3, 46);
            this.lblIDusuario.Name = "lblIDusuario";
            this.lblIDusuario.Size = new System.Drawing.Size(57, 13);
            this.lblIDusuario.TabIndex = 0;
            this.lblIDusuario.Text = "ID Usuario";
            // 
            // lblCodPer
            // 
            this.lblCodPer.AutoSize = true;
            this.lblCodPer.Location = new System.Drawing.Point(134, 46);
            this.lblCodPer.Name = "lblCodPer";
            this.lblCodPer.Size = new System.Drawing.Size(66, 13);
            this.lblCodPer.TabIndex = 1;
            this.lblCodPer.Text = "Codigo Perfil";
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.Location = new System.Drawing.Point(12, 83);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(83, 13);
            this.lblNomUser.TabIndex = 2;
            this.lblNomUser.Text = "Nombre Usuario";
            // 
            // lblPaswUser
            // 
            this.lblPaswUser.AutoSize = true;
            this.lblPaswUser.Location = new System.Drawing.Point(12, 114);
            this.lblPaswUser.Name = "lblPaswUser";
            this.lblPaswUser.Size = new System.Drawing.Size(61, 13);
            this.lblPaswUser.TabIndex = 3;
            this.lblPaswUser.Text = "Contraseña";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(263, 46);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(66, 39);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(41, 20);
            this.txtIDUsuario.TabIndex = 5;
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(206, 39);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(41, 20);
            this.txtCodPerfil.TabIndex = 6;
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(109, 76);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtNomUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(109, 114);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(154, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(309, 39);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(32, 20);
            this.txtEstado.TabIndex = 9;
            // 
            // wfUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 182);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPaswUser);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.lblCodPer);
            this.Controls.Add(this.lblIDusuario);
            this.Name = "wfUsuario";
            this.Text = "Crear Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDusuario;
        private System.Windows.Forms.Label lblCodPer;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Label lblPaswUser;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtEstado;

    }
}