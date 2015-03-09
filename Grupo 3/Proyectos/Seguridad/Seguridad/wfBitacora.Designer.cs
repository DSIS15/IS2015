namespace Seguridad
{
    partial class wfBitacora
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
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.tlpPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.tlpPanel.SuspendLayout();
            this.pnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacora.Location = new System.Drawing.Point(3, 46);
            this.dgvBitacora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.ShowCellErrors = false;
            this.dgvBitacora.ShowCellToolTips = false;
            this.dgvBitacora.ShowEditingIcon = false;
            this.dgvBitacora.ShowRowErrors = false;
            this.dgvBitacora.Size = new System.Drawing.Size(760, 359);
            this.dgvBitacora.TabIndex = 0;
            // 
            // tlpPanel
            // 
            this.tlpPanel.ColumnCount = 1;
            this.tlpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanel.Controls.Add(this.dgvBitacora, 0, 1);
            this.tlpPanel.Controls.Add(this.pnlPanel, 0, 0);
            this.tlpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpPanel.Name = "tlpPanel";
            this.tlpPanel.RowCount = 2;
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.45576F));
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.54424F));
            this.tlpPanel.Size = new System.Drawing.Size(766, 409);
            this.tlpPanel.TabIndex = 1;
            // 
            // pnlPanel
            // 
            this.pnlPanel.Controls.Add(this.btnRecargar);
            this.pnlPanel.Controls.Add(this.txtClave);
            this.pnlPanel.Controls.Add(this.lblFiltro);
            this.pnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPanel.Location = new System.Drawing.Point(3, 3);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(760, 36);
            this.pnlPanel.TabIndex = 1;
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
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(52, 6);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(150, 22);
            this.txtClave.TabIndex = 2;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(208, 6);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // wfBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 409);
            this.Controls.Add(this.tlpPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfBitacora";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Bitácora";
            this.Load += new System.EventHandler(this.wfBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.tlpPanel.ResumeLayout(false);
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.TableLayoutPanel tlpPanel;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.TextBox txtClave;
    }
}