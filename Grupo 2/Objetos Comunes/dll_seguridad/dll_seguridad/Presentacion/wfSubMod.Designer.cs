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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfSubMod));
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
            this.navegador1 = new Navegador.Navegador();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIDSubMod
            // 
            this.lblIDSubMod.AutoSize = true;
            this.lblIDSubMod.Location = new System.Drawing.Point(22, 100);
            this.lblIDSubMod.Name = "lblIDSubMod";
            this.lblIDSubMod.Size = new System.Drawing.Size(78, 13);
            this.lblIDSubMod.TabIndex = 0;
            this.lblIDSubMod.Text = "ID Sub Modulo";
            // 
            // lblIDMod
            // 
            this.lblIDMod.AutoSize = true;
            this.lblIDMod.Location = new System.Drawing.Point(186, 100);
            this.lblIDMod.Name = "lblIDMod";
            this.lblIDMod.Size = new System.Drawing.Size(56, 13);
            this.lblIDMod.TabIndex = 1;
            this.lblIDMod.Text = "ID Modulo";
            // 
            // lblNomSubMod
            // 
            this.lblNomSubMod.AutoSize = true;
            this.lblNomSubMod.Location = new System.Drawing.Point(22, 137);
            this.lblNomSubMod.Name = "lblNomSubMod";
            this.lblNomSubMod.Size = new System.Drawing.Size(104, 13);
            this.lblNomSubMod.TabIndex = 2;
            this.lblNomSubMod.Text = "Nombre Sub Modulo";
            // 
            // lblNomwf
            // 
            this.lblNomwf.AutoSize = true;
            this.lblNomwf.Location = new System.Drawing.Point(300, 136);
            this.lblNomwf.Name = "lblNomwf";
            this.lblNomwf.Size = new System.Drawing.Size(95, 13);
            this.lblNomwf.TabIndex = 3;
            this.lblNomwf.Text = "Nombre Formulario";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(355, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtIDSubMod
            // 
            this.txtIDSubMod.Location = new System.Drawing.Point(117, 93);
            this.txtIDSubMod.Name = "txtIDSubMod";
            this.txtIDSubMod.Size = new System.Drawing.Size(28, 20);
            this.txtIDSubMod.TabIndex = 5;
            this.txtIDSubMod.Tag = "id_submodulo";
            // 
            // txtIDMod
            // 
            this.txtIDMod.Location = new System.Drawing.Point(262, 93);
            this.txtIDMod.Name = "txtIDMod";
            this.txtIDMod.Size = new System.Drawing.Size(28, 20);
            this.txtIDMod.TabIndex = 5;
            this.txtIDMod.Tag = "id_modulo";
            // 
            // txtNomSubMod
            // 
            this.txtNomSubMod.Location = new System.Drawing.Point(142, 129);
            this.txtNomSubMod.Name = "txtNomSubMod";
            this.txtNomSubMod.Size = new System.Drawing.Size(100, 20);
            this.txtNomSubMod.TabIndex = 6;
            this.txtNomSubMod.Tag = "nombre_submodulo";
            // 
            // txtNomForm
            // 
            this.txtNomForm.Location = new System.Drawing.Point(420, 128);
            this.txtNomForm.Name = "txtNomForm";
            this.txtNomForm.Size = new System.Drawing.Size(100, 20);
            this.txtNomForm.TabIndex = 7;
            this.txtNomForm.Tag = "nombre_formulario";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(524, 93);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(21, 20);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(25, 27);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "sub_modulo";
            this.navegador1.TabIndex = 9;
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbestado.Location = new System.Drawing.Point(420, 91);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(98, 21);
            this.cbestado.TabIndex = 10;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // wfSubMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 179);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.navegador1);
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
            this.Load += new System.EventHandler(this.wfSubMod_Load);
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
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox cbestado;
    }
}