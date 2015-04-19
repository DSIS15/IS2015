namespace prueba_bitacora
{
    partial class grid_con_busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grid_con_busqueda));
            this.cuDataGridConBusqueda1 = new dll_bitacora.Presentacion.cuDataGridConBusqueda();
            this.SuspendLayout();
            // 
            // cuDataGridConBusqueda1
            // 
            this.cuDataGridConBusqueda1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridConBusqueda1.AlDatosEntrada")));
            this.cuDataGridConBusqueda1.Location = new System.Drawing.Point(3, 0);
            this.cuDataGridConBusqueda1.Name = "cuDataGridConBusqueda1";
            this.cuDataGridConBusqueda1.Size = new System.Drawing.Size(572, 324);
            this.cuDataGridConBusqueda1.STabla = "viewbitacora";
            this.cuDataGridConBusqueda1.TabIndex = 0;
            // 
            // grid_con_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 330);
            this.Controls.Add(this.cuDataGridConBusqueda1);
            this.Name = "grid_con_busqueda";
            this.Text = "grid_con_busqueda";
            this.Load += new System.EventHandler(this.grid_con_busqueda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dll_bitacora.Presentacion.cuDataGridConBusqueda cuDataGridConBusqueda1;

    }
}