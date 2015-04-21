namespace EstadosFinancieros
{
    partial class wfEstadoFinanciero
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
            this.dgvEstadosFinancieros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosFinancieros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstadosFinancieros
            // 
            this.dgvEstadosFinancieros.AllowUserToAddRows = false;
            this.dgvEstadosFinancieros.AllowUserToDeleteRows = false;
            this.dgvEstadosFinancieros.AllowUserToResizeColumns = false;
            this.dgvEstadosFinancieros.AllowUserToResizeRows = false;
            this.dgvEstadosFinancieros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadosFinancieros.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvEstadosFinancieros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadosFinancieros.Location = new System.Drawing.Point(12, 125);
            this.dgvEstadosFinancieros.MultiSelect = false;
            this.dgvEstadosFinancieros.Name = "dgvEstadosFinancieros";
            this.dgvEstadosFinancieros.ReadOnly = true;
            this.dgvEstadosFinancieros.RowHeadersVisible = false;
            this.dgvEstadosFinancieros.RowHeadersWidth = 30;
            this.dgvEstadosFinancieros.RowTemplate.Height = 20;
            this.dgvEstadosFinancieros.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadosFinancieros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadosFinancieros.Size = new System.Drawing.Size(590, 300);
            this.dgvEstadosFinancieros.TabIndex = 24;
            this.dgvEstadosFinancieros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadosFinancieros_CellContentDoubleClick);
            // 
            // wfEstadoFinanciero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 437);
            this.Controls.Add(this.dgvEstadosFinancieros);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEstadoFinanciero";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Estado Financiero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosFinancieros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadosFinancieros;

    }
}