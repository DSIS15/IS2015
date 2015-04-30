namespace Operaciones
{
    partial class wfClasificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfClasificacion));
            this.navegador1 = new Navegador.Navegador();
            this.txtNombreClf = new System.Windows.Forms.TextBox();
            this.lblNombreClf = new System.Windows.Forms.Label();
            this.txtDescripClf = new System.Windows.Forms.TextBox();
            this.lblDescripClf = new System.Windows.Forms.Label();
            this.cboEstadoClf = new System.Windows.Forms.ComboBox();
            this.txtEstadoClf = new System.Windows.Forms.TextBox();
            this.lblEstadoClf = new System.Windows.Forms.Label();
            this.txtNomencClf = new System.Windows.Forms.TextBox();
            this.lblNomencClf = new System.Windows.Forms.Label();
            this.txtCodigoClf = new System.Windows.Forms.TextBox();
            this.lblCodigoClf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(617, 55);
            this.navegador1.sNombreTabla = "";
            this.navegador1.TabIndex = 0;
            this.navegador1.Tag = "tabm_clasificacion";
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            // 
            // txtNombreClf
            // 
            this.txtNombreClf.Location = new System.Drawing.Point(97, 98);
            this.txtNombreClf.Name = "txtNombreClf";
            this.txtNombreClf.Size = new System.Drawing.Size(150, 22);
            this.txtNombreClf.TabIndex = 47;
            this.txtNombreClf.Tag = "nombre_clf";
            // 
            // lblNombreClf
            // 
            this.lblNombreClf.AutoSize = true;
            this.lblNombreClf.Location = new System.Drawing.Point(12, 101);
            this.lblNombreClf.Name = "lblNombreClf";
            this.lblNombreClf.Size = new System.Drawing.Size(56, 17);
            this.lblNombreClf.TabIndex = 46;
            this.lblNombreClf.Text = "Nombre";
            // 
            // txtDescripClf
            // 
            this.txtDescripClf.Location = new System.Drawing.Point(97, 126);
            this.txtDescripClf.Name = "txtDescripClf";
            this.txtDescripClf.Size = new System.Drawing.Size(150, 22);
            this.txtDescripClf.TabIndex = 41;
            this.txtDescripClf.Tag = "descrip_clf";
            // 
            // lblDescripClf
            // 
            this.lblDescripClf.AutoSize = true;
            this.lblDescripClf.Location = new System.Drawing.Point(12, 129);
            this.lblDescripClf.Name = "lblDescripClf";
            this.lblDescripClf.Size = new System.Drawing.Size(79, 17);
            this.lblDescripClf.TabIndex = 45;
            this.lblDescripClf.Text = "Descripción";
            // 
            // cboEstadoClf
            // 
            this.cboEstadoClf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoClf.FormattingEnabled = true;
            this.cboEstadoClf.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoClf.Location = new System.Drawing.Point(455, 126);
            this.cboEstadoClf.Name = "cboEstadoClf";
            this.cboEstadoClf.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoClf.TabIndex = 42;
            this.cboEstadoClf.Tag = "";
            this.cboEstadoClf.SelectedIndexChanged += new System.EventHandler(this.cboEstadoClf_SelectedIndexChanged);
            // 
            // txtEstadoClf
            // 
            this.txtEstadoClf.Location = new System.Drawing.Point(324, 126);
            this.txtEstadoClf.Name = "txtEstadoClf";
            this.txtEstadoClf.Size = new System.Drawing.Size(25, 22);
            this.txtEstadoClf.TabIndex = 44;
            this.txtEstadoClf.Tag = "estado_clf";
            this.txtEstadoClf.Visible = false;
            this.txtEstadoClf.TextChanged += new System.EventHandler(this.txtEstadoClf_TextChanged);
            // 
            // lblEstadoClf
            // 
            this.lblEstadoClf.AutoSize = true;
            this.lblEstadoClf.Location = new System.Drawing.Point(355, 129);
            this.lblEstadoClf.Name = "lblEstadoClf";
            this.lblEstadoClf.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoClf.TabIndex = 43;
            this.lblEstadoClf.Text = "Estado";
            // 
            // txtNomencClf
            // 
            this.txtNomencClf.Location = new System.Drawing.Point(455, 98);
            this.txtNomencClf.Name = "txtNomencClf";
            this.txtNomencClf.Size = new System.Drawing.Size(150, 22);
            this.txtNomencClf.TabIndex = 39;
            this.txtNomencClf.Tag = "nomenc_clf";
            // 
            // lblNomencClf
            // 
            this.lblNomencClf.AutoSize = true;
            this.lblNomencClf.Location = new System.Drawing.Point(355, 101);
            this.lblNomencClf.Name = "lblNomencClf";
            this.lblNomencClf.Size = new System.Drawing.Size(94, 17);
            this.lblNomencClf.TabIndex = 40;
            this.lblNomencClf.Text = "Nomenclatura";
            // 
            // txtCodigoClf
            // 
            this.txtCodigoClf.Location = new System.Drawing.Point(97, 70);
            this.txtCodigoClf.Name = "txtCodigoClf";
            this.txtCodigoClf.Size = new System.Drawing.Size(150, 22);
            this.txtCodigoClf.TabIndex = 37;
            this.txtCodigoClf.Tag = "cod_clf";
            this.txtCodigoClf.TextChanged += new System.EventHandler(this.txtCodigoClf_TextChanged);
            // 
            // lblCodigoClf
            // 
            this.lblCodigoClf.AutoSize = true;
            this.lblCodigoClf.Location = new System.Drawing.Point(12, 73);
            this.lblCodigoClf.Name = "lblCodigoClf";
            this.lblCodigoClf.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoClf.TabIndex = 38;
            this.lblCodigoClf.Text = "Código";
            // 
            // wfClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 164);
            this.Controls.Add(this.txtNombreClf);
            this.Controls.Add(this.lblNombreClf);
            this.Controls.Add(this.txtDescripClf);
            this.Controls.Add(this.lblDescripClf);
            this.Controls.Add(this.cboEstadoClf);
            this.Controls.Add(this.txtEstadoClf);
            this.Controls.Add(this.lblEstadoClf);
            this.Controls.Add(this.txtNomencClf);
            this.Controls.Add(this.lblNomencClf);
            this.Controls.Add(this.txtCodigoClf);
            this.Controls.Add(this.lblCodigoClf);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfClasificacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Clasificacion";
            this.Load += new System.EventHandler(this.wfClasificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtNombreClf;
        private System.Windows.Forms.Label lblNombreClf;
        private System.Windows.Forms.TextBox txtDescripClf;
        private System.Windows.Forms.Label lblDescripClf;
        private System.Windows.Forms.ComboBox cboEstadoClf;
        private System.Windows.Forms.TextBox txtEstadoClf;
        private System.Windows.Forms.Label lblEstadoClf;
        private System.Windows.Forms.TextBox txtNomencClf;
        private System.Windows.Forms.Label lblNomencClf;
        private System.Windows.Forms.TextBox txtCodigoClf;
        private System.Windows.Forms.Label lblCodigoClf;
    }
}