namespace ConciliacionBancaria
{
    partial class wfProcesoConciBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfProcesoConciBancaria));
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblEstadoCuenta = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.btnConciliarMovimientos = new System.Windows.Forms.Button();
            this.cboEstadoCuenta = new System.Windows.Forms.ComboBox();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.VisorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.spcContenedor = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisorPDF)).BeginInit();
            this.spcContenedor.Panel1.SuspendLayout();
            this.spcContenedor.Panel2.SuspendLayout();
            this.spcContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(12, 20);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(108, 17);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta Bancaria";
            // 
            // lblEstadoCuenta
            // 
            this.lblEstadoCuenta.AutoSize = true;
            this.lblEstadoCuenta.Location = new System.Drawing.Point(294, 20);
            this.lblEstadoCuenta.Name = "lblEstadoCuenta";
            this.lblEstadoCuenta.Size = new System.Drawing.Size(114, 17);
            this.lblEstadoCuenta.TabIndex = 1;
            this.lblEstadoCuenta.Text = "Estado de Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(126, 17);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(150, 22);
            this.txtCuenta.TabIndex = 0;
            this.txtCuenta.TextChanged += new System.EventHandler(this.txtCuenta_TextChanged);
            this.txtCuenta.Enter += new System.EventHandler(this.txtCuenta_Enter);
            this.txtCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuenta_KeyPress);
            // 
            // btnConciliarMovimientos
            // 
            this.btnConciliarMovimientos.Location = new System.Drawing.Point(781, 16);
            this.btnConciliarMovimientos.Name = "btnConciliarMovimientos";
            this.btnConciliarMovimientos.Size = new System.Drawing.Size(180, 25);
            this.btnConciliarMovimientos.TabIndex = 3;
            this.btnConciliarMovimientos.Text = "Conciliar movimientos";
            this.btnConciliarMovimientos.UseVisualStyleBackColor = true;
            this.btnConciliarMovimientos.Click += new System.EventHandler(this.btnConciliarMovimientos_Click);
            // 
            // cboEstadoCuenta
            // 
            this.cboEstadoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCuenta.FormattingEnabled = true;
            this.cboEstadoCuenta.Location = new System.Drawing.Point(414, 17);
            this.cboEstadoCuenta.Name = "cboEstadoCuenta";
            this.cboEstadoCuenta.Size = new System.Drawing.Size(200, 25);
            this.cboEstadoCuenta.TabIndex = 4;
            this.cboEstadoCuenta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCuenta_SelectedIndexChanged);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.AllowUserToResizeColumns = false;
            this.dgvMovimientos.AllowUserToResizeRows = false;
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientos.Location = new System.Drawing.Point(0, 0);
            this.dgvMovimientos.MultiSelect = false;
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersVisible = false;
            this.dgvMovimientos.RowHeadersWidth = 30;
            this.dgvMovimientos.RowTemplate.Height = 20;
            this.dgvMovimientos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(475, 300);
            this.dgvMovimientos.TabIndex = 24;
            // 
            // VisorPDF
            // 
            this.VisorPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorPDF.Enabled = true;
            this.VisorPDF.Location = new System.Drawing.Point(0, 0);
            this.VisorPDF.Name = "VisorPDF";
            this.VisorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VisorPDF.OcxState")));
            this.VisorPDF.Size = new System.Drawing.Size(475, 300);
            this.VisorPDF.TabIndex = 25;
            // 
            // spcContenedor
            // 
            this.spcContenedor.Location = new System.Drawing.Point(6, 55);
            this.spcContenedor.Name = "spcContenedor";
            // 
            // spcContenedor.Panel1
            // 
            this.spcContenedor.Panel1.Controls.Add(this.VisorPDF);
            this.spcContenedor.Panel1MinSize = 300;
            // 
            // spcContenedor.Panel2
            // 
            this.spcContenedor.Panel2.Controls.Add(this.dgvMovimientos);
            this.spcContenedor.Panel2MinSize = 146;
            this.spcContenedor.Size = new System.Drawing.Size(955, 300);
            this.spcContenedor.SplitterDistance = 475;
            this.spcContenedor.SplitterWidth = 5;
            this.spcContenedor.TabIndex = 26;
            // 
            // wfProcesoConciBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 361);
            this.Controls.Add(this.spcContenedor);
            this.Controls.Add(this.cboEstadoCuenta);
            this.Controls.Add(this.btnConciliarMovimientos);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblEstadoCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfProcesoConciBancaria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliar Movimientos Bancarios";
            this.Load += new System.EventHandler(this.wfProcesoConciBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisorPDF)).EndInit();
            this.spcContenedor.Panel1.ResumeLayout(false);
            this.spcContenedor.Panel2.ResumeLayout(false);
            this.spcContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblEstadoCuenta;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Button btnConciliarMovimientos;
        private System.Windows.Forms.ComboBox cboEstadoCuenta;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private AxAcroPDFLib.AxAcroPDF VisorPDF;
        private System.Windows.Forms.SplitContainer spcContenedor;
    }
}