namespace ConciliacionBancaria
{
    partial class wfConciliacionesBancarias
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
            this.tlpPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dgvConciliaciones = new System.Windows.Forms.DataGridView();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tlpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConciliaciones)).BeginInit();
            this.pnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPanel
            // 
            this.tlpPanel.ColumnCount = 1;
            this.tlpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanel.Controls.Add(this.dgvConciliaciones, 0, 1);
            this.tlpPanel.Controls.Add(this.pnlPanel, 0, 0);
            this.tlpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpPanel.Name = "tlpPanel";
            this.tlpPanel.RowCount = 2;
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.45576F));
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.54424F));
            this.tlpPanel.Size = new System.Drawing.Size(666, 409);
            this.tlpPanel.TabIndex = 2;
            // 
            // dgvConciliaciones
            // 
            this.dgvConciliaciones.AllowUserToAddRows = false;
            this.dgvConciliaciones.AllowUserToDeleteRows = false;
            this.dgvConciliaciones.AllowUserToResizeRows = false;
            this.dgvConciliaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConciliaciones.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvConciliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConciliaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConciliaciones.Location = new System.Drawing.Point(3, 46);
            this.dgvConciliaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvConciliaciones.Name = "dgvConciliaciones";
            this.dgvConciliaciones.ReadOnly = true;
            this.dgvConciliaciones.RowHeadersVisible = false;
            this.dgvConciliaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConciliaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConciliaciones.ShowCellErrors = false;
            this.dgvConciliaciones.ShowCellToolTips = false;
            this.dgvConciliaciones.ShowEditingIcon = false;
            this.dgvConciliaciones.ShowRowErrors = false;
            this.dgvConciliaciones.Size = new System.Drawing.Size(660, 359);
            this.dgvConciliaciones.TabIndex = 0;
            // 
            // pnlPanel
            // 
            this.pnlPanel.Controls.Add(this.btnImprimir);
            this.pnlPanel.Controls.Add(this.txtClave);
            this.pnlPanel.Controls.Add(this.lblFiltro);
            this.pnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPanel.Location = new System.Drawing.Point(3, 3);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(660, 36);
            this.pnlPanel.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(289, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(52, 6);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(231, 22);
            this.txtClave.TabIndex = 2;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(9, 9);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(37, 17);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtro";
            // 
            // wfConciliacionesBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 409);
            this.Controls.Add(this.tlpPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfConciliacionesBancarias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliaciones Bancarias";
            this.Load += new System.EventHandler(this.wfConciliacionesBancarias_Load);
            this.tlpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConciliaciones)).EndInit();
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPanel;
        private System.Windows.Forms.DataGridView dgvConciliaciones;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnImprimir;


    }
}