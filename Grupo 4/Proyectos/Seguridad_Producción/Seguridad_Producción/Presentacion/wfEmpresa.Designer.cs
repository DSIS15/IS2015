namespace Seguridad_Producción
{
    partial class wfEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEmpresa));
            this.navegador1 = new Navegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCod_empsa = new System.Windows.Forms.TextBox();
            this.txtNom_empsa = new System.Windows.Forms.TextBox();
            this.txtDire_empsa = new System.Windows.Forms.TextBox();
            this.txtNit_empsa = new System.Windows.Forms.TextBox();
            this.txtEstado_empsa = new System.Windows.Forms.TextBox();
            this.cboEstado_empsa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_empresa";
            this.navegador1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Comercial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estado:";
            // 
            // txtCod_empsa
            // 
            this.txtCod_empsa.Location = new System.Drawing.Point(150, 105);
            this.txtCod_empsa.Name = "txtCod_empsa";
            this.txtCod_empsa.Size = new System.Drawing.Size(144, 20);
            this.txtCod_empsa.TabIndex = 28;
            this.txtCod_empsa.Tag = "cod_empsa";
            
            // 
            // txtNom_empsa
            // 
            this.txtNom_empsa.Location = new System.Drawing.Point(150, 132);
            this.txtNom_empsa.Name = "txtNom_empsa";
            this.txtNom_empsa.Size = new System.Drawing.Size(144, 20);
            this.txtNom_empsa.TabIndex = 29;
            this.txtNom_empsa.Tag = "nomcomercial_empsa";
            this.txtNom_empsa.TextChanged += new System.EventHandler(this.txtNom_empsa_TextChanged);
            // 
            // txtDire_empsa
            // 
            this.txtDire_empsa.Location = new System.Drawing.Point(404, 132);
            this.txtDire_empsa.Name = "txtDire_empsa";
            this.txtDire_empsa.Size = new System.Drawing.Size(144, 20);
            this.txtDire_empsa.TabIndex = 30;
            this.txtDire_empsa.Tag = "dire_empsa";
            // 
            // txtNit_empsa
            // 
            this.txtNit_empsa.Location = new System.Drawing.Point(150, 160);
            this.txtNit_empsa.Name = "txtNit_empsa";
            this.txtNit_empsa.Size = new System.Drawing.Size(144, 20);
            this.txtNit_empsa.TabIndex = 31;
            this.txtNit_empsa.Tag = "nit_empsa";
            // 
            // txtEstado_empsa
            // 
            this.txtEstado_empsa.Location = new System.Drawing.Point(300, 190);
            this.txtEstado_empsa.Name = "txtEstado_empsa";
            this.txtEstado_empsa.Size = new System.Drawing.Size(25, 20);
            this.txtEstado_empsa.TabIndex = 32;
            this.txtEstado_empsa.Tag = "estado_empsa";
            this.txtEstado_empsa.Visible = false;
            this.txtEstado_empsa.TextChanged += new System.EventHandler(this.txtEstado_empsa_TextChanged);
            // 
            // cboEstado_empsa
            // 
            this.cboEstado_empsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_empsa.FormattingEnabled = true;
            this.cboEstado_empsa.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_empsa.Location = new System.Drawing.Point(150, 189);
            this.cboEstado_empsa.Name = "cboEstado_empsa";
            this.cboEstado_empsa.Size = new System.Drawing.Size(144, 21);
            this.cboEstado_empsa.TabIndex = 33;
            this.cboEstado_empsa.TextChanged += new System.EventHandler(this.cboEstado_empsa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(564, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // wfEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(621, 234);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboEstado_empsa);
            this.Controls.Add(this.txtEstado_empsa);
            this.Controls.Add(this.txtNit_empsa);
            this.Controls.Add(this.txtDire_empsa);
            this.Controls.Add(this.txtNom_empsa);
            this.Controls.Add(this.txtCod_empsa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wfEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.wfEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCod_empsa;
        private System.Windows.Forms.TextBox txtNom_empsa;
        private System.Windows.Forms.TextBox txtDire_empsa;
        private System.Windows.Forms.TextBox txtNit_empsa;
        private System.Windows.Forms.TextBox txtEstado_empsa;
        private System.Windows.Forms.ComboBox cboEstado_empsa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}