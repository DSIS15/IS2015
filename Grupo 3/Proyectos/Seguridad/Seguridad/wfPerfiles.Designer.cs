namespace Seguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPerfiles));
            this.txtCodPfl = new System.Windows.Forms.TextBox();
            this.txtPerfilPfl = new System.Windows.Forms.TextBox();
            this.txtDescripPfl = new System.Windows.Forms.TextBox();
            this.txtEstadoPfl = new System.Windows.Forms.TextBox();
            this.cboEstadoPfl = new System.Windows.Forms.ComboBox();
            this.lblCodPfl = new System.Windows.Forms.Label();
            this.lblPerfilPfl = new System.Windows.Forms.Label();
            this.lblDescripPfl = new System.Windows.Forms.Label();
            this.lblEstadoPfl = new System.Windows.Forms.Label();
            this.dgvDPerfil = new System.Windows.Forms.DataGridView();
            this.navegador1 = new Navegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPfl
            // 
            this.txtCodPfl.Location = new System.Drawing.Point(97, 70);
            this.txtCodPfl.MaxLength = 7;
            this.txtCodPfl.Name = "txtCodPfl";
            this.txtCodPfl.Size = new System.Drawing.Size(150, 22);
            this.txtCodPfl.TabIndex = 14;
            this.txtCodPfl.Tag = "cod_pfl";
            this.txtCodPfl.EnabledChanged += new System.EventHandler(this.txtCodPfl_EnabledChanged);
            this.txtCodPfl.TextChanged += new System.EventHandler(this.txtCodPfl_TextChanged);
            // 
            // txtPerfilPfl
            // 
            this.txtPerfilPfl.Location = new System.Drawing.Point(97, 98);
            this.txtPerfilPfl.MaxLength = 25;
            this.txtPerfilPfl.Name = "txtPerfilPfl";
            this.txtPerfilPfl.Size = new System.Drawing.Size(150, 22);
            this.txtPerfilPfl.TabIndex = 15;
            this.txtPerfilPfl.Tag = "perfil_pfl";
            this.txtPerfilPfl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerfilPfl_KeyPress);
            // 
            // txtDescripPfl
            // 
            this.txtDescripPfl.Location = new System.Drawing.Point(452, 98);
            this.txtDescripPfl.MaxLength = 100;
            this.txtDescripPfl.Name = "txtDescripPfl";
            this.txtDescripPfl.Size = new System.Drawing.Size(150, 22);
            this.txtDescripPfl.TabIndex = 16;
            this.txtDescripPfl.Tag = "descrip_pfl";
            this.txtDescripPfl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripPfl_KeyPress);
            // 
            // txtEstadoPfl
            // 
            this.txtEstadoPfl.Location = new System.Drawing.Point(253, 126);
            this.txtEstadoPfl.MaxLength = 1;
            this.txtEstadoPfl.Name = "txtEstadoPfl";
            this.txtEstadoPfl.Size = new System.Drawing.Size(22, 22);
            this.txtEstadoPfl.TabIndex = 18;
            this.txtEstadoPfl.Tag = "estado_pfl";
            this.txtEstadoPfl.Visible = false;
            this.txtEstadoPfl.EnabledChanged += new System.EventHandler(this.txtEstadoPfl_EnabledChanged);
            this.txtEstadoPfl.TextChanged += new System.EventHandler(this.txtEstadoPfl_TextChanged);
            // 
            // cboEstadoPfl
            // 
            this.cboEstadoPfl.BackColor = System.Drawing.SystemColors.Window;
            this.cboEstadoPfl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPfl.FormattingEnabled = true;
            this.cboEstadoPfl.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstadoPfl.Location = new System.Drawing.Point(97, 126);
            this.cboEstadoPfl.Name = "cboEstadoPfl";
            this.cboEstadoPfl.Size = new System.Drawing.Size(150, 25);
            this.cboEstadoPfl.TabIndex = 17;
            this.cboEstadoPfl.SelectedIndexChanged += new System.EventHandler(this.cboEstadoPfl_SelectedIndexChanged);
            // 
            // lblCodPfl
            // 
            this.lblCodPfl.AutoSize = true;
            this.lblCodPfl.Location = new System.Drawing.Point(12, 73);
            this.lblCodPfl.Name = "lblCodPfl";
            this.lblCodPfl.Size = new System.Drawing.Size(52, 17);
            this.lblCodPfl.TabIndex = 6;
            this.lblCodPfl.Text = "Codigo";
            // 
            // lblPerfilPfl
            // 
            this.lblPerfilPfl.AutoSize = true;
            this.lblPerfilPfl.Location = new System.Drawing.Point(12, 101);
            this.lblPerfilPfl.Name = "lblPerfilPfl";
            this.lblPerfilPfl.Size = new System.Drawing.Size(37, 17);
            this.lblPerfilPfl.TabIndex = 7;
            this.lblPerfilPfl.Text = "Perfil";
            // 
            // lblDescripPfl
            // 
            this.lblDescripPfl.AutoSize = true;
            this.lblDescripPfl.Location = new System.Drawing.Point(367, 101);
            this.lblDescripPfl.Name = "lblDescripPfl";
            this.lblDescripPfl.Size = new System.Drawing.Size(79, 17);
            this.lblDescripPfl.TabIndex = 8;
            this.lblDescripPfl.Text = "Descripcion";
            // 
            // lblEstadoPfl
            // 
            this.lblEstadoPfl.AutoSize = true;
            this.lblEstadoPfl.Location = new System.Drawing.Point(12, 129);
            this.lblEstadoPfl.Name = "lblEstadoPfl";
            this.lblEstadoPfl.Size = new System.Drawing.Size(48, 17);
            this.lblEstadoPfl.TabIndex = 9;
            this.lblEstadoPfl.Text = "Estado";
            // 
            // dgvDPerfil
            // 
            this.dgvDPerfil.AllowUserToAddRows = false;
            this.dgvDPerfil.AllowUserToDeleteRows = false;
            this.dgvDPerfil.AllowUserToResizeColumns = false;
            this.dgvDPerfil.AllowUserToResizeRows = false;
            this.dgvDPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDPerfil.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDPerfil.Location = new System.Drawing.Point(12, 157);
            this.dgvDPerfil.MultiSelect = false;
            this.dgvDPerfil.Name = "dgvDPerfil";
            this.dgvDPerfil.ReadOnly = true;
            this.dgvDPerfil.RowHeadersVisible = false;
            this.dgvDPerfil.RowHeadersWidth = 30;
            this.dgvDPerfil.RowTemplate.Height = 20;
            this.dgvDPerfil.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDPerfil.Size = new System.Drawing.Size(590, 300);
            this.dgvDPerfil.TabIndex = 23;
            this.dgvDPerfil.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDPerfil_CellContentDoubleClick);
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
            this.navegador1.sNombreTabla = "tabm_perfil";
            this.navegador1.TabIndex = 24;
            this.navegador1.btnAfterNuevo += new System.EventHandler(this.navegador1_btnAfterNuevo);
            this.navegador1.btnBeforeGuardar += new System.EventHandler(this.navegador1_btnBeforeGuardar);
            this.navegador1.btnAfterGuardar += new System.EventHandler(this.navegador1_btnAfterGuardar);
            this.navegador1.btnAfterModificar += new System.EventHandler(this.navegador1_btnAfterModificar);
            this.navegador1.btnAfterEliminar += new System.EventHandler(this.navegador1_btnAfterEliminar);
            this.navegador1.btnBeforeLimpiar += new System.EventHandler(this.navegador1_btnBeforeLimpiar);
            this.navegador1.btnAfterLimpiar += new System.EventHandler(this.navegador1_btnAfterLimpiar);
            this.navegador1.btnAfterRecargar += new System.EventHandler(this.navegador1_btnAfterRecargar);
            // 
            // wfPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 466);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvDPerfil);
            this.Controls.Add(this.lblEstadoPfl);
            this.Controls.Add(this.lblDescripPfl);
            this.Controls.Add(this.lblPerfilPfl);
            this.Controls.Add(this.lblCodPfl);
            this.Controls.Add(this.cboEstadoPfl);
            this.Controls.Add(this.txtEstadoPfl);
            this.Controls.Add(this.txtDescripPfl);
            this.Controls.Add(this.txtPerfilPfl);
            this.Controls.Add(this.txtCodPfl);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfPerfiles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.wfPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodPfl;
        private System.Windows.Forms.TextBox txtPerfilPfl;
        private System.Windows.Forms.TextBox txtDescripPfl;
        private System.Windows.Forms.TextBox txtEstadoPfl;
        private System.Windows.Forms.ComboBox cboEstadoPfl;
        private System.Windows.Forms.Label lblCodPfl;
        private System.Windows.Forms.Label lblPerfilPfl;
        private System.Windows.Forms.Label lblDescripPfl;
        private System.Windows.Forms.Label lblEstadoPfl;
        private System.Windows.Forms.DataGridView dgvDPerfil;
        private Navegador.Navegador navegador1;
    }
}