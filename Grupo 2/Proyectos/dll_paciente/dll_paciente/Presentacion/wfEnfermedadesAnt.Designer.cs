namespace dll_paciente.Presentacion
{
    partial class wfEnfermedadesAnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEnfermedadesAnt));
            this.navegador1 = new Navegador.Navegador();
            this.lblidenfermedad = new System.Windows.Forms.Label();
            this.lblnomenfer = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtidenfermedad = new System.Windows.Forms.TextBox();
            this.txtnomenfer = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 25);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "enfermedades_antecedentes";
            this.navegador1.TabIndex = 0;
            // 
            // lblidenfermedad
            // 
            this.lblidenfermedad.AutoSize = true;
            this.lblidenfermedad.Location = new System.Drawing.Point(62, 111);
            this.lblidenfermedad.Name = "lblidenfermedad";
            this.lblidenfermedad.Size = new System.Drawing.Size(77, 13);
            this.lblidenfermedad.TabIndex = 1;
            this.lblidenfermedad.Text = "ID enfermedad";
            // 
            // lblnomenfer
            // 
            this.lblnomenfer.AutoSize = true;
            this.lblnomenfer.Location = new System.Drawing.Point(62, 147);
            this.lblnomenfer.Name = "lblnomenfer";
            this.lblnomenfer.Size = new System.Drawing.Size(103, 13);
            this.lblnomenfer.TabIndex = 2;
            this.lblnomenfer.Text = "Nombre enfermedad";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(353, 111);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 3;
            this.lblestado.Text = "Estado";
            // 
            // txtidenfermedad
            // 
            this.txtidenfermedad.Location = new System.Drawing.Point(188, 104);
            this.txtidenfermedad.Name = "txtidenfermedad";
            this.txtidenfermedad.Size = new System.Drawing.Size(100, 20);
            this.txtidenfermedad.TabIndex = 4;
            this.txtidenfermedad.Tag = "id_enfermedad";
            // 
            // txtnomenfer
            // 
            this.txtnomenfer.Location = new System.Drawing.Point(188, 140);
            this.txtnomenfer.Name = "txtnomenfer";
            this.txtnomenfer.Size = new System.Drawing.Size(100, 20);
            this.txtnomenfer.TabIndex = 5;
            this.txtnomenfer.Tag = "nombre_enfermedad";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(554, 105);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(24, 20);
            this.txtestado.TabIndex = 6;
            this.txtestado.Tag = "estado";
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbEstado.Location = new System.Drawing.Point(427, 104);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 7;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // wfEnfermedadesAnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 184);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtnomenfer);
            this.Controls.Add(this.txtidenfermedad);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblnomenfer);
            this.Controls.Add(this.lblidenfermedad);
            this.Controls.Add(this.navegador1);
            this.Name = "wfEnfermedadesAnt";
            this.Text = "wfEnfermedadesAnt";
            this.Load += new System.EventHandler(this.wfEnfermedadesAnt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblidenfermedad;
        private System.Windows.Forms.Label lblnomenfer;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtidenfermedad;
        private System.Windows.Forms.TextBox txtnomenfer;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}