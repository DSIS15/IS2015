namespace dll_idioma.Presentacion
{
    partial class cuIdioma
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbidioma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbidioma
            // 
            this.cbidioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidioma.FormattingEnabled = true;
            this.cbidioma.Items.AddRange(new object[] {
            "ES-GT",
            "EN-US",
            "JA-JP"});
            this.cbidioma.Location = new System.Drawing.Point(12, 7);
            this.cbidioma.Name = "cbidioma";
            this.cbidioma.Size = new System.Drawing.Size(121, 21);
            this.cbidioma.TabIndex = 0;
            this.cbidioma.SelectedIndexChanged += new System.EventHandler(this.cbidioma_SelectedIndexChanged);
            // 
            // cuIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbidioma);
            this.Name = "cuIdioma";
            this.Size = new System.Drawing.Size(146, 38);
            this.Load += new System.EventHandler(this.cuIdioma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbidioma;
    }
}
