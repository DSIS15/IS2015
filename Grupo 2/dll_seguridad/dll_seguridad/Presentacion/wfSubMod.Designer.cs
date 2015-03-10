namespace dll_seguridad.Presentacion
{
    partial class wfSubMod
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
            this.lblIDSubMod = new System.Windows.Forms.Label();
            this.lblIDMod = new System.Windows.Forms.Label();
            this.lblNomSubMod = new System.Windows.Forms.Label();
            this.lblNomwf = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIDSubMod = new System.Windows.Forms.TextBox();
            this.txtIDMod = new System.Windows.Forms.TextBox();
            this.txtNomSubMod = new System.Windows.Forms.TextBox();
            this.txtNomForm = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIDSubMod
            // 
            this.lblIDSubMod.AutoSize = true;
            this.lblIDSubMod.Location = new System.Drawing.Point(31, 36);
            this.lblIDSubMod.Name = "lblIDSubMod";
            this.lblIDSubMod.Size = new System.Drawing.Size(78, 13);
            this.lblIDSubMod.TabIndex = 0;
            this.lblIDSubMod.Text = "ID Sub Modulo";
            // 
            // lblIDMod
            // 
            this.lblIDMod.AutoSize = true;
            this.lblIDMod.Location = new System.Drawing.Point(169, 36);
            this.lblIDMod.Name = "lblIDMod";
            this.lblIDMod.Size = new System.Drawing.Size(56, 13);
            this.lblIDMod.TabIndex = 1;
            this.lblIDMod.Text = "ID Modulo";
            // 
            // lblNomSubMod
            // 
            this.lblNomSubMod.AutoSize = true;
            this.lblNomSubMod.Location = new System.Drawing.Point(31, 73);
            this.lblNomSubMod.Name = "lblNomSubMod";
            this.lblNomSubMod.Size = new System.Drawing.Size(104, 13);
            this.lblNomSubMod.TabIndex = 2;
            this.lblNomSubMod.Text = "Nombre Sub Modulo";
            // 
            // lblNomwf
            // 
            this.lblNomwf.AutoSize = true;
            this.lblNomwf.Location = new System.Drawing.Point(31, 108);
            this.lblNomwf.Name = "lblNomwf";
            this.lblNomwf.Size = new System.Drawing.Size(95, 13);
            this.lblNomwf.TabIndex = 3;
            this.lblNomwf.Text = "Nombre Formulario";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(31, 146);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtIDSubMod
            // 
            this.txtIDSubMod.Location = new System.Drawing.Point(115, 29);
            this.txtIDSubMod.Name = "txtIDSubMod";
            this.txtIDSubMod.Size = new System.Drawing.Size(28, 20);
            this.txtIDSubMod.TabIndex = 5;
            // 
            // txtIDMod
            // 
            this.txtIDMod.Location = new System.Drawing.Point(244, 29);
            this.txtIDMod.Name = "txtIDMod";
            this.txtIDMod.Size = new System.Drawing.Size(28, 20);
            this.txtIDMod.TabIndex = 5;
            // 
            // txtNomSubMod
            // 
            this.txtNomSubMod.Location = new System.Drawing.Point(151, 65);
            this.txtNomSubMod.Name = "txtNomSubMod";
            this.txtNomSubMod.Size = new System.Drawing.Size(100, 20);
            this.txtNomSubMod.TabIndex = 6;
            // 
            // txtNomForm
            // 
            this.txtNomForm.Location = new System.Drawing.Point(151, 100);
            this.txtNomForm.Name = "txtNomForm";
            this.txtNomForm.Size = new System.Drawing.Size(100, 20);
            this.txtNomForm.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(151, 138);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(28, 20);
            this.txtEstado.TabIndex = 8;
            // 
            // wfSubMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNomForm);
            this.Controls.Add(this.txtNomSubMod);
            this.Controls.Add(this.txtIDMod);
            this.Controls.Add(this.txtIDSubMod);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNomwf);
            this.Controls.Add(this.lblNomSubMod);
            this.Controls.Add(this.lblIDMod);
            this.Controls.Add(this.lblIDSubMod);
            this.Name = "wfSubMod";
            this.Text = "Sub Modulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDSubMod;
        private System.Windows.Forms.Label lblIDMod;
        private System.Windows.Forms.Label lblNomSubMod;
        private System.Windows.Forms.Label lblNomwf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtIDSubMod;
        private System.Windows.Forms.TextBox txtIDMod;
        private System.Windows.Forms.TextBox txtNomSubMod;
        private System.Windows.Forms.TextBox txtNomForm;
        private System.Windows.Forms.TextBox txtEstado;
    }
}