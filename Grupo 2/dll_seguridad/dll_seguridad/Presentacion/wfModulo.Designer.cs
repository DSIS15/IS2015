namespace dll_seguridad.Presentacion
{
    partial class wfModulo
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
            this.lblIDmodulo = new System.Windows.Forms.Label();
            this.lblNomModulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNomDLL = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIDmodulo
            // 
            this.lblIDmodulo.AutoSize = true;
            this.lblIDmodulo.Location = new System.Drawing.Point(13, 36);
            this.lblIDmodulo.Name = "lblIDmodulo";
            this.lblIDmodulo.Size = new System.Drawing.Size(56, 13);
            this.lblIDmodulo.TabIndex = 0;
            this.lblIDmodulo.Text = "ID Modulo";
            // 
            // lblNomModulo
            // 
            this.lblNomModulo.AutoSize = true;
            this.lblNomModulo.Location = new System.Drawing.Point(13, 74);
            this.lblNomModulo.Name = "lblNomModulo";
            this.lblNomModulo.Size = new System.Drawing.Size(82, 13);
            this.lblNomModulo.TabIndex = 1;
            this.lblNomModulo.Text = "Nombre Modulo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblNomDLL
            // 
            this.lblNomDLL.AutoSize = true;
            this.lblNomDLL.Location = new System.Drawing.Point(13, 110);
            this.lblNomDLL.Name = "lblNomDLL";
            this.lblNomDLL.Size = new System.Drawing.Size(67, 13);
            this.lblNomDLL.TabIndex = 4;
            this.lblNomDLL.Text = "Nombre DLL";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(151, 36);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(31, 20);
            this.textBox4.TabIndex = 7;
            // 
            // wfModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblNomDLL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomModulo);
            this.Controls.Add(this.lblIDmodulo);
            this.Name = "wfModulo";
            this.Text = "Crear Modulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDmodulo;
        private System.Windows.Forms.Label lblNomModulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNomDLL;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox textBox4;
    }
}