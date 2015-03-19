namespace Seguridad_Producción
{
    partial class wfMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMoneda));
            this.navegador1 = new Navegador.Navegador();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboEstado_mda = new System.Windows.Forms.ComboBox();
            this.txtEstado_mda = new System.Windows.Forms.TextBox();
            this.txtCambio_mda = new System.Windows.Forms.TextBox();
            this.txtAbrev_mda = new System.Windows.Forms.TextBox();
            this.txtMoneda_mda = new System.Windows.Forms.TextBox();
            this.txtCod_mda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.navegador1.sNombreTabla = "tabm_moneda";
            this.navegador1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(565, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // cboEstado_mda
            // 
            this.cboEstado_mda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_mda.FormattingEnabled = true;
            this.cboEstado_mda.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_mda.Location = new System.Drawing.Point(152, 188);
            this.cboEstado_mda.Name = "cboEstado_mda";
            this.cboEstado_mda.Size = new System.Drawing.Size(144, 21);
            this.cboEstado_mda.TabIndex = 45;
            this.cboEstado_mda.TextChanged += new System.EventHandler(this.cboEstado_mda_TextChanged);
            // 
            // txtEstado_mda
            // 
            this.txtEstado_mda.Location = new System.Drawing.Point(302, 189);
            this.txtEstado_mda.Name = "txtEstado_mda";
            this.txtEstado_mda.Size = new System.Drawing.Size(25, 20);
            this.txtEstado_mda.TabIndex = 44;
            this.txtEstado_mda.Tag = "estado_mda";
            this.txtEstado_mda.Visible = false;
            this.txtEstado_mda.TextChanged += new System.EventHandler(this.txtEstado_mda_TextChanged);
            // 
            // txtCambio_mda
            // 
            this.txtCambio_mda.Location = new System.Drawing.Point(152, 159);
            this.txtCambio_mda.Name = "txtCambio_mda";
            this.txtCambio_mda.Size = new System.Drawing.Size(144, 20);
            this.txtCambio_mda.TabIndex = 43;
            this.txtCambio_mda.Tag = "tipcambio_mda";
            // 
            // txtAbrev_mda
            // 
            this.txtAbrev_mda.Location = new System.Drawing.Point(406, 131);
            this.txtAbrev_mda.Name = "txtAbrev_mda";
            this.txtAbrev_mda.Size = new System.Drawing.Size(144, 20);
            this.txtAbrev_mda.TabIndex = 42;
            this.txtAbrev_mda.Tag = "abrev_mda";
            // 
            // txtMoneda_mda
            // 
            this.txtMoneda_mda.Location = new System.Drawing.Point(152, 131);
            this.txtMoneda_mda.Name = "txtMoneda_mda";
            this.txtMoneda_mda.Size = new System.Drawing.Size(144, 20);
            this.txtMoneda_mda.TabIndex = 41;
            this.txtMoneda_mda.Tag = "moneda_mda";
            this.txtMoneda_mda.TextChanged += new System.EventHandler(this.txtMoneda_mda_TextChanged);
            // 
            // txtCod_mda
            // 
            this.txtCod_mda.Location = new System.Drawing.Point(152, 104);
            this.txtCod_mda.Name = "txtCod_mda";
            this.txtCod_mda.Size = new System.Drawing.Size(144, 20);
            this.txtCod_mda.TabIndex = 40;
            this.txtCod_mda.Tag = "cod_mda";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tipo de Cambio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Abreviatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Moneda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Codigo:";
            // 
            // wfMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 235);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboEstado_mda);
            this.Controls.Add(this.txtEstado_mda);
            this.Controls.Add(this.txtCambio_mda);
            this.Controls.Add(this.txtAbrev_mda);
            this.Controls.Add(this.txtMoneda_mda);
            this.Controls.Add(this.txtCod_mda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wfMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moneda";
            this.Load += new System.EventHandler(this.wfMoneda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboEstado_mda;
        private System.Windows.Forms.TextBox txtEstado_mda;
        private System.Windows.Forms.TextBox txtCambio_mda;
        private System.Windows.Forms.TextBox txtAbrev_mda;
        private System.Windows.Forms.TextBox txtMoneda_mda;
        private System.Windows.Forms.TextBox txtCod_mda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}