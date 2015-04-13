namespace Presentacion_Bitacora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cuDataGridConBusqueda1 = new dll_bitacora.Presentacion.cuDataGridConBusqueda();
            this.SuspendLayout();
            // 
            // cuDataGridConBusqueda1
            // 
            this.cuDataGridConBusqueda1.AlDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("cuDataGridConBusqueda1.AlDatosEntrada")));
            this.cuDataGridConBusqueda1.Location = new System.Drawing.Point(12, 12);
            this.cuDataGridConBusqueda1.Name = "cuDataGridConBusqueda1";
            this.cuDataGridConBusqueda1.Size = new System.Drawing.Size(572, 324);
            this.cuDataGridConBusqueda1.STabla = "bitacora";
            this.cuDataGridConBusqueda1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 348);
            this.Controls.Add(this.cuDataGridConBusqueda1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dll_bitacora.Presentacion.cuDataGridConBusqueda cuDataGridConBusqueda1;
    }
}

