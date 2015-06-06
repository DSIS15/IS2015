namespace Compras_Ventas
{
    partial class wfDocumento
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
            this.txtCod_ProvCte = new System.Windows.Forms.TextBox();
            this.lblProCte = new System.Windows.Forms.Label();
            this.lblTipoDocto = new System.Windows.Forms.Label();
            this.txtTipoDocto = new System.Windows.Forms.TextBox();
            this.lblNoDocto = new System.Windows.Forms.Label();
            this.txtNoDocto = new System.Windows.Forms.TextBox();
            this.lblPrecioNeto = new System.Windows.Forms.Label();
            this.txtPrecioDocto = new System.Windows.Forms.TextBox();
            this.btnIngresarDocto = new System.Windows.Forms.Button();
            this.lblCodFact = new System.Windows.Forms.Label();
            this.txtCodFact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechDocto = new System.Windows.Forms.MaskedTextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCod_ProvCte
            // 
            this.txtCod_ProvCte.Location = new System.Drawing.Point(194, 51);
            this.txtCod_ProvCte.Name = "txtCod_ProvCte";
            this.txtCod_ProvCte.Size = new System.Drawing.Size(150, 22);
            this.txtCod_ProvCte.TabIndex = 1;
            this.txtCod_ProvCte.Click += new System.EventHandler(this.txtCod_ProvCte_Click);
            // 
            // lblProCte
            // 
            this.lblProCte.AutoSize = true;
            this.lblProCte.Location = new System.Drawing.Point(18, 54);
            this.lblProCte.Name = "lblProCte";
            this.lblProCte.Size = new System.Drawing.Size(166, 17);
            this.lblProCte.TabIndex = 1;
            this.lblProCte.Text = "Codigo Cliente/Proveedor";
            this.lblProCte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTipoDocto
            // 
            this.lblTipoDocto.AutoSize = true;
            this.lblTipoDocto.Location = new System.Drawing.Point(19, 85);
            this.lblTipoDocto.Name = "lblTipoDocto";
            this.lblTipoDocto.Size = new System.Drawing.Size(125, 17);
            this.lblTipoDocto.TabIndex = 2;
            this.lblTipoDocto.Text = "Tipo de Documento";
            this.lblTipoDocto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTipoDocto
            // 
            this.txtTipoDocto.Location = new System.Drawing.Point(194, 82);
            this.txtTipoDocto.Name = "txtTipoDocto";
            this.txtTipoDocto.Size = new System.Drawing.Size(150, 22);
            this.txtTipoDocto.TabIndex = 2;
            // 
            // lblNoDocto
            // 
            this.lblNoDocto.AutoSize = true;
            this.lblNoDocto.Location = new System.Drawing.Point(19, 113);
            this.lblNoDocto.Name = "lblNoDocto";
            this.lblNoDocto.Size = new System.Drawing.Size(102, 17);
            this.lblNoDocto.TabIndex = 4;
            this.lblNoDocto.Text = "No. Documento";
            this.lblNoDocto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNoDocto
            // 
            this.txtNoDocto.Location = new System.Drawing.Point(194, 110);
            this.txtNoDocto.Name = "txtNoDocto";
            this.txtNoDocto.Size = new System.Drawing.Size(150, 22);
            this.txtNoDocto.TabIndex = 3;
            // 
            // lblPrecioNeto
            // 
            this.lblPrecioNeto.AutoSize = true;
            this.lblPrecioNeto.Location = new System.Drawing.Point(19, 169);
            this.lblPrecioNeto.Name = "lblPrecioNeto";
            this.lblPrecioNeto.Size = new System.Drawing.Size(79, 17);
            this.lblPrecioNeto.TabIndex = 6;
            this.lblPrecioNeto.Text = "Precio Neto";
            this.lblPrecioNeto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecioDocto
            // 
            this.txtPrecioDocto.Location = new System.Drawing.Point(194, 166);
            this.txtPrecioDocto.Name = "txtPrecioDocto";
            this.txtPrecioDocto.Size = new System.Drawing.Size(150, 22);
            this.txtPrecioDocto.TabIndex = 5;
            this.txtPrecioDocto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioDocto.TextChanged += new System.EventHandler(this.txtPrecioDocto_TextChanged);
            this.txtPrecioDocto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioDocto_KeyPress);
            // 
            // btnIngresarDocto
            // 
            this.btnIngresarDocto.Location = new System.Drawing.Point(111, 251);
            this.btnIngresarDocto.Name = "btnIngresarDocto";
            this.btnIngresarDocto.Size = new System.Drawing.Size(116, 26);
            this.btnIngresarDocto.TabIndex = 8;
            this.btnIngresarDocto.Text = "Ingresar";
            this.btnIngresarDocto.UseVisualStyleBackColor = true;
            this.btnIngresarDocto.Click += new System.EventHandler(this.btnIngresarDocto_Click);
            // 
            // lblCodFact
            // 
            this.lblCodFact.AutoSize = true;
            this.lblCodFact.Location = new System.Drawing.Point(18, 26);
            this.lblCodFact.Name = "lblCodFact";
            this.lblCodFact.Size = new System.Drawing.Size(126, 17);
            this.lblCodFact.TabIndex = 9;
            this.lblCodFact.Text = "Codigo Documento";
            this.lblCodFact.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodFact
            // 
            this.txtCodFact.Enabled = false;
            this.txtCodFact.Location = new System.Drawing.Point(194, 23);
            this.txtCodFact.Name = "txtCodFact";
            this.txtCodFact.Size = new System.Drawing.Size(150, 22);
            this.txtCodFact.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Documento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFechDocto
            // 
            this.txtFechDocto.Location = new System.Drawing.Point(194, 138);
            this.txtFechDocto.Mask = "0000-00-00";
            this.txtFechDocto.Name = "txtFechDocto";
            this.txtFechDocto.Size = new System.Drawing.Size(150, 22);
            this.txtFechDocto.TabIndex = 4;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(19, 197);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(63, 17);
            this.lblImpuesto.TabIndex = 18;
            this.lblImpuesto.Text = "Impuesto";
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(194, 194);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(150, 22);
            this.txtImpuesto.TabIndex = 6;
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(194, 222);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 22);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(19, 225);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wfDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 289);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.txtFechDocto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodFact);
            this.Controls.Add(this.lblCodFact);
            this.Controls.Add(this.btnIngresarDocto);
            this.Controls.Add(this.txtPrecioDocto);
            this.Controls.Add(this.lblPrecioNeto);
            this.Controls.Add(this.txtNoDocto);
            this.Controls.Add(this.lblNoDocto);
            this.Controls.Add(this.txtTipoDocto);
            this.Controls.Add(this.lblTipoDocto);
            this.Controls.Add(this.lblProCte);
            this.Controls.Add(this.txtCod_ProvCte);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDocumento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento";
            this.Load += new System.EventHandler(this.wfDocumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod_ProvCte;
        private System.Windows.Forms.Label lblProCte;
        private System.Windows.Forms.Label lblTipoDocto;
        private System.Windows.Forms.TextBox txtTipoDocto;
        private System.Windows.Forms.Label lblNoDocto;
        private System.Windows.Forms.TextBox txtNoDocto;
        private System.Windows.Forms.Label lblPrecioNeto;
        private System.Windows.Forms.TextBox txtPrecioDocto;
        private System.Windows.Forms.Button btnIngresarDocto;
        private System.Windows.Forms.Label lblCodFact;
        private System.Windows.Forms.TextBox txtCodFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFechDocto;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}