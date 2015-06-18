namespace Produccion_EnterpriseSolution
{
    partial class wfPermiso
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
            this.dgvPermiso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermiso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPermiso
            // 
            this.dgvPermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermiso.Location = new System.Drawing.Point(12, 56);
            this.dgvPermiso.Name = "dgvPermiso";
            this.dgvPermiso.Size = new System.Drawing.Size(951, 263);
            this.dgvPermiso.TabIndex = 1;
            // 
            // wfPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 382);
            this.Controls.Add(this.dgvPermiso);
            this.Name = "wfPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfPermiso";
            this.Load += new System.EventHandler(this.wfPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermiso;
    }
}