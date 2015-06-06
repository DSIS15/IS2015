namespace Seguridad
{
    partial class wfUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfUsuarios));
            this.lblEstadoPfl = new System.Windows.Forms.Label();
            this.lblNomUsr = new System.Windows.Forms.Label();
            this.lblCodUsr = new System.Windows.Forms.Label();
            this.cboEstadoUsr = new System.Windows.Forms.ComboBox();
            this.txtEstadoUsr = new System.Windows.Forms.TextBox();
            this.txtNomUsr = new System.Windows.Forms.TextBox();
            this.txtCodUsr = new System.Windows.Forms.TextBox();
            this.lblCodPfl = new System.Windows.Forms.Label();
            this.txtCodPfl = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblConfContrasena = new System.Windows.Forms.Label();
            this.txtConfContrasena = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.dgvPermisosEspeciales = new System.Windows.Forms.DataGridView();
            this.btnPermisosEspeciales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosEspeciales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstadoPfl
            // 
            this.lblEstadoPfl.AutoSize = true;
            this.lblEstadoPfl.Location = new System.Drawing.Point(12, 157);
            this.lblEstadoPfl.Name = "lblEstadoPfl";
            this.lblEstadoPfl.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoPfl.TabIndex = 18;
            this.lblEstadoPfl.Text = "Estado";
            // 
            // lblNomUsr
            // 
            this.lblNomUsr.AutoSize = true;
            this.lblNomUsr.Location = new System.Drawing.Point(12, 101);
            this.lblNomUsr.Name = "lblNomUsr";
            this.lblNomUsr.Size = new System.Drawing.Size(51, 17);
            this.lblNomUsr.TabIndex = 16;
            this.lblNomUsr.Text = "Usuario";
            // 
            // lblCodUsr
            // 
            this.lblCodUsr.AutoSize = true;
            this.lblCodUsr.Location = new System.Drawing.Point(12, 73);
            this.lblCodUsr.Name = "lblCodUsr";
            this.lblCodUsr.Size = new System.Drawing.Size(52, 17);
            this.lblCodUsr.TabIndex = 15;
            this.lblCodUsr.Text = "Codigo";
            // 
            // cboEstadoUsr
            // 
            this.cboEstadoUsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoUsr.FormattingEnabled = true;
            this.cboEstadoUsr.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoUsr.Location = new System.Drawing.Point(95, 154);
            this.cboEstadoUsr.Name = "cboEstadoUsr";
            this.cboEstadoUsr.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoUsr.TabIndex = 19;
            this.cboEstadoUsr.SelectedIndexChanged += new System.EventHandler(this.cboEstadoUsr_SelectedIndexChanged);
            // 
            // txtEstadoUsr
            // 
            this.txtEstadoUsr.Location = new System.Drawing.Point(251, 154);
            this.txtEstadoUsr.Name = "txtEstadoUsr";
            this.txtEstadoUsr.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoUsr.TabIndex = 20;
            this.txtEstadoUsr.Tag = "estado_usr";
            this.txtEstadoUsr.Visible = false;
            this.txtEstadoUsr.EnabledChanged += new System.EventHandler(this.txtEstadoUsr_EnabledChanged);
            this.txtEstadoUsr.TextChanged += new System.EventHandler(this.txtEstadoUsr_TextChanged);
            // 
            // txtNomUsr
            // 
            this.txtNomUsr.Location = new System.Drawing.Point(95, 98);
            this.txtNomUsr.Name = "txtNomUsr";
            this.txtNomUsr.Size = new System.Drawing.Size(150, 22);
            this.txtNomUsr.TabIndex = 16;
            this.txtNomUsr.Tag = "usuario_usr";
            // 
            // txtCodUsr
            // 
            this.txtCodUsr.Location = new System.Drawing.Point(95, 70);
            this.txtCodUsr.Name = "txtCodUsr";
            this.txtCodUsr.Size = new System.Drawing.Size(150, 22);
            this.txtCodUsr.TabIndex = 14;
            this.txtCodUsr.Tag = "cod_usr";
            this.txtCodUsr.EnabledChanged += new System.EventHandler(this.txtCodUsr_EnabledChanged);
            this.txtCodUsr.TextChanged += new System.EventHandler(this.txtCodUsr_TextChanged);
            // 
            // lblCodPfl
            // 
            this.lblCodPfl.AutoSize = true;
            this.lblCodPfl.Location = new System.Drawing.Point(308, 73);
            this.lblCodPfl.Name = "lblCodPfl";
            this.lblCodPfl.Size = new System.Drawing.Size(84, 17);
            this.lblCodPfl.TabIndex = 20;
            this.lblCodPfl.Text = "Codigo Perfil";
            // 
            // txtCodPfl
            // 
            this.txtCodPfl.Location = new System.Drawing.Point(452, 70);
            this.txtCodPfl.Name = "txtCodPfl";
            this.txtCodPfl.Size = new System.Drawing.Size(150, 22);
            this.txtCodPfl.TabIndex = 15;
            this.txtCodPfl.Tag = "cod_pfl";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(12, 129);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(77, 17);
            this.lblContrasena.TabIndex = 22;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(95, 126);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(150, 22);
            this.txtContrasena.TabIndex = 17;
            this.txtContrasena.Tag = "password_usr";
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.EnabledChanged += new System.EventHandler(this.txtContrasena_EnabledChanged);
            // 
            // lblConfContrasena
            // 
            this.lblConfContrasena.AutoSize = true;
            this.lblConfContrasena.Location = new System.Drawing.Point(308, 129);
            this.lblConfContrasena.Name = "lblConfContrasena";
            this.lblConfContrasena.Size = new System.Drawing.Size(138, 17);
            this.lblConfContrasena.TabIndex = 24;
            this.lblConfContrasena.Text = "Confirmar Contraseña";
            // 
            // txtConfContrasena
            // 
            this.txtConfContrasena.Location = new System.Drawing.Point(452, 126);
            this.txtConfContrasena.Name = "txtConfContrasena";
            this.txtConfContrasena.Size = new System.Drawing.Size(150, 22);
            this.txtConfContrasena.TabIndex = 18;
            this.txtConfContrasena.UseSystemPasswordChar = true;
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
            this.navegador1.Size = new System.Drawing.Size(614, 55);
            this.navegador1.sNombreTabla = "tabm_usuario";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterGuardar += new System.EventHandler(this.navegador1_btnAfterGuardar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            this.navegador1.btnAfterImprimir += new System.EventHandler(this.navegador1_btnAfterImprimir);
            // 
            // dgvPermisosEspeciales
            // 
            this.dgvPermisosEspeciales.AllowUserToAddRows = false;
            this.dgvPermisosEspeciales.AllowUserToDeleteRows = false;
            this.dgvPermisosEspeciales.AllowUserToResizeColumns = false;
            this.dgvPermisosEspeciales.AllowUserToResizeRows = false;
            this.dgvPermisosEspeciales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermisosEspeciales.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvPermisosEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosEspeciales.Location = new System.Drawing.Point(12, 191);
            this.dgvPermisosEspeciales.MultiSelect = false;
            this.dgvPermisosEspeciales.Name = "dgvPermisosEspeciales";
            this.dgvPermisosEspeciales.ReadOnly = true;
            this.dgvPermisosEspeciales.RowHeadersVisible = false;
            this.dgvPermisosEspeciales.RowHeadersWidth = 30;
            this.dgvPermisosEspeciales.RowTemplate.Height = 20;
            this.dgvPermisosEspeciales.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermisosEspeciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisosEspeciales.Size = new System.Drawing.Size(590, 300);
            this.dgvPermisosEspeciales.TabIndex = 25;
            // 
            // btnPermisosEspeciales
            // 
            this.btnPermisosEspeciales.Location = new System.Drawing.Point(311, 154);
            this.btnPermisosEspeciales.Name = "btnPermisosEspeciales";
            this.btnPermisosEspeciales.Size = new System.Drawing.Size(291, 25);
            this.btnPermisosEspeciales.TabIndex = 26;
            this.btnPermisosEspeciales.Text = "Permisos Especiales";
            this.btnPermisosEspeciales.UseVisualStyleBackColor = true;
            this.btnPermisosEspeciales.Click += new System.EventHandler(this.btnPermisosEspeciales_Click);
            // 
            // wfUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 501);
            this.Controls.Add(this.btnPermisosEspeciales);
            this.Controls.Add(this.dgvPermisosEspeciales);
            this.Controls.Add(this.lblConfContrasena);
            this.Controls.Add(this.txtConfContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblCodPfl);
            this.Controls.Add(this.txtCodPfl);
            this.Controls.Add(this.lblEstadoPfl);
            this.Controls.Add(this.lblNomUsr);
            this.Controls.Add(this.lblCodUsr);
            this.Controls.Add(this.cboEstadoUsr);
            this.Controls.Add(this.txtEstadoUsr);
            this.Controls.Add(this.txtNomUsr);
            this.Controls.Add(this.txtCodUsr);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfUsuarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.wfUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosEspeciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblEstadoPfl;
        private System.Windows.Forms.Label lblNomUsr;
        private System.Windows.Forms.Label lblCodUsr;
        private System.Windows.Forms.ComboBox cboEstadoUsr;
        private System.Windows.Forms.TextBox txtEstadoUsr;
        private System.Windows.Forms.TextBox txtNomUsr;
        private System.Windows.Forms.TextBox txtCodUsr;
        private System.Windows.Forms.Label lblCodPfl;
        private System.Windows.Forms.TextBox txtCodPfl;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblConfContrasena;
        private System.Windows.Forms.TextBox txtConfContrasena;
        private System.Windows.Forms.DataGridView dgvPermisosEspeciales;
        private System.Windows.Forms.Button btnPermisosEspeciales;
    }
}