namespace Compras_Ventas
{
    partial class wfCompraVenta
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
            this.dgvConciliaciones = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConciliaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConciliaciones
            // 
            this.dgvConciliaciones.AllowUserToAddRows = false;
            this.dgvConciliaciones.AllowUserToDeleteRows = false;
            this.dgvConciliaciones.AllowUserToResizeColumns = false;
            this.dgvConciliaciones.AllowUserToResizeRows = false;
            this.dgvConciliaciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConciliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConciliaciones.Location = new System.Drawing.Point(12, 48);
            this.dgvConciliaciones.Name = "dgvConciliaciones";
            this.dgvConciliaciones.Size = new System.Drawing.Size(600, 300);
            this.dgvConciliaciones.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGenerar.Location = new System.Drawing.Point(168, 16);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(121, 26);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(12, 18);
            this.txtClave.Mask = "9999/99/99";
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(150, 22);
            this.txtClave.TabIndex = 0;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // wfCompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvConciliaciones);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wfCompraVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Compra Y Venta";
            this.Load += new System.EventHandler(this.wfCompraVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConciliaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConciliaciones;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.MaskedTextBox txtClave;

    }
}