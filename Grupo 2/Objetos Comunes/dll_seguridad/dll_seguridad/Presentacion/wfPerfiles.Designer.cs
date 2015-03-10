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
            this.lblCodPerfil = new System.Windows.Forms.Label();
            this.lblNombre_perfil = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodPerfil
            // 
            this.lblCodPerfil.AutoSize = true;
            this.lblCodPerfil.Location = new System.Drawing.Point(12, 31);
            this.lblCodPerfil.Name = "lblCodPerfil";
            this.lblCodPerfil.Size = new System.Drawing.Size(63, 13);
            this.lblCodPerfil.TabIndex = 0;
            this.lblCodPerfil.Text = "Codigo Peril";
            // 
            // lblNombre_perfil
            // 
            this.lblNombre_perfil.AutoSize = true;
            this.lblNombre_perfil.Location = new System.Drawing.Point(12, 76);
            this.lblNombre_perfil.Name = "lblNombre_perfil";
            this.lblNombre_perfil.Size = new System.Drawing.Size(70, 13);
            this.lblNombre_perfil.TabIndex = 1;
            this.lblNombre_perfil.Text = "Nombre Perfil";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(152, 31);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(89, 24);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(52, 20);
            this.txtCodPerfil.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(199, 23);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(37, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // wfPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre_perfil);
            this.Controls.Add(this.lblCodPerfil);
            this.Name = "wfPerfiles";
            this.Text = "Crear Perfil";
            this.Load += new System.EventHandler(this.wfPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPerfil;
        private System.Windows.Forms.Label lblNombre_perfil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNombre;

    }
}