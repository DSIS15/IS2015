namespace dll_bitacora.Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBitacora));
            this.cuDataGridConBusqueda1 = new dll_bitacora.Presentacion.cuDataGridConBusqueda();
            this.SuspendLayout();
            // 
            // cuDataGridConBusqueda1
            // 
            this.cuDataGridConBusqueda1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridConBusqueda1.AlDatosEntrada")));
            this.cuDataGridConBusqueda1.AutoScroll = true;
            this.cuDataGridConBusqueda1.AutoSize = true;
            this.cuDataGridConBusqueda1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cuDataGridConBusqueda1.Location = new System.Drawing.Point(12, 12);
            this.cuDataGridConBusqueda1.Name = "cuDataGridConBusqueda1";
            this.cuDataGridConBusqueda1.Size = new System.Drawing.Size(571, 322);
            this.cuDataGridConBusqueda1.STabla = "viewbitacora_hospital";
            this.cuDataGridConBusqueda1.TabIndex = 0;
            this.cuDataGridConBusqueda1.AutoSizeChanged += new System.EventHandler(this.cuDataGridConBusqueda1_AutoSizeChanged);
            this.cuDataGridConBusqueda1.Load += new System.EventHandler(this.cuDataGridConBusqueda1_Load);
            // 
            // wfBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 339);
            this.Controls.Add(this.cuDataGridConBusqueda1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfBitacora";
            this.Text = "wfBitacora";
            this.Load += new System.EventHandler(this.wfBitacora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cuDataGridConBusqueda cuDataGridConBusqueda1;
    }
}