namespace Materia_Prima
{
    partial class wf_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_Pedido));
            this.navegador1 = new Navegador.Navegador();
            this.lblcodped = new System.Windows.Forms.Label();
            this.txtcod_ped = new System.Windows.Forms.TextBox();
            this.gboPersonalesPed = new System.Windows.Forms.GroupBox();
            this.txtcod_mp = new System.Windows.Forms.TextBox();
            this.cbocodmp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbocodprov = new System.Windows.Forms.ComboBox();
            this.lblprov = new System.Windows.Forms.Label();
            this.txtcod_prov = new System.Windows.Forms.TextBox();
            this.txtfecha_ped = new System.Windows.Forms.TextBox();
            this.txtcant_ped = new System.Windows.Forms.TextBox();
            this.txtunitm_ped = new System.Windows.Forms.TextBox();
            this.lblmp = new System.Windows.Forms.Label();
            this.lblunitm_ped = new System.Windows.Forms.Label();
            this.lblcant_ped = new System.Windows.Forms.Label();
            this.lblfecha_ped = new System.Windows.Forms.Label();
            this.gboPersonalesPed.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(32, 29);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_pedido";
            this.navegador1.TabIndex = 63;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblcodped
            // 
            this.lblcodped.AutoSize = true;
            this.lblcodped.Location = new System.Drawing.Point(483, 97);
            this.lblcodped.Name = "lblcodped";
            this.lblcodped.Size = new System.Drawing.Size(76, 13);
            this.lblcodped.TabIndex = 62;
            this.lblcodped.Text = "Codigo Pedido";
            // 
            // txtcod_ped
            // 
            this.txtcod_ped.Location = new System.Drawing.Point(579, 94);
            this.txtcod_ped.Name = "txtcod_ped";
            this.txtcod_ped.Size = new System.Drawing.Size(49, 20);
            this.txtcod_ped.TabIndex = 61;
            this.txtcod_ped.Tag = "cod_ped";
            // 
            // gboPersonalesPed
            // 
            this.gboPersonalesPed.Controls.Add(this.txtcod_mp);
            this.gboPersonalesPed.Controls.Add(this.cbocodmp);
            this.gboPersonalesPed.Controls.Add(this.button1);
            this.gboPersonalesPed.Controls.Add(this.cbocodprov);
            this.gboPersonalesPed.Controls.Add(this.lblprov);
            this.gboPersonalesPed.Controls.Add(this.txtcod_prov);
            this.gboPersonalesPed.Controls.Add(this.txtfecha_ped);
            this.gboPersonalesPed.Controls.Add(this.txtcant_ped);
            this.gboPersonalesPed.Controls.Add(this.txtunitm_ped);
            this.gboPersonalesPed.Controls.Add(this.lblmp);
            this.gboPersonalesPed.Controls.Add(this.lblunitm_ped);
            this.gboPersonalesPed.Controls.Add(this.lblcant_ped);
            this.gboPersonalesPed.Controls.Add(this.lblfecha_ped);
            this.gboPersonalesPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPersonalesPed.Location = new System.Drawing.Point(32, 120);
            this.gboPersonalesPed.Name = "gboPersonalesPed";
            this.gboPersonalesPed.Size = new System.Drawing.Size(612, 123);
            this.gboPersonalesPed.TabIndex = 60;
            this.gboPersonalesPed.TabStop = false;
            this.gboPersonalesPed.Text = "Datos de Pedido";
            // 
            // txtcod_mp
            // 
            this.txtcod_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_mp.Location = new System.Drawing.Point(289, 55);
            this.txtcod_mp.Name = "txtcod_mp";
            this.txtcod_mp.Size = new System.Drawing.Size(29, 20);
            this.txtcod_mp.TabIndex = 62;
            this.txtcod_mp.Tag = "cod_mp";
            // 
            // cbocodmp
            // 
            this.cbocodmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocodmp.FormattingEnabled = true;
            this.cbocodmp.Location = new System.Drawing.Point(121, 54);
            this.cbocodmp.Name = "cbocodmp";
            this.cbocodmp.Size = new System.Drawing.Size(162, 21);
            this.cbocodmp.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(436, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbocodprov
            // 
            this.cbocodprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocodprov.FormattingEnabled = true;
            this.cbocodprov.Location = new System.Drawing.Point(121, 26);
            this.cbocodprov.Name = "cbocodprov";
            this.cbocodprov.Size = new System.Drawing.Size(162, 21);
            this.cbocodprov.TabIndex = 50;
            // 
            // lblprov
            // 
            this.lblprov.AutoSize = true;
            this.lblprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprov.Location = new System.Drawing.Point(25, 30);
            this.lblprov.Name = "lblprov";
            this.lblprov.Size = new System.Drawing.Size(59, 13);
            this.lblprov.TabIndex = 48;
            this.lblprov.Text = "Proveedor:";
            // 
            // txtcod_prov
            // 
            this.txtcod_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_prov.Location = new System.Drawing.Point(289, 27);
            this.txtcod_prov.Name = "txtcod_prov";
            this.txtcod_prov.Size = new System.Drawing.Size(29, 20);
            this.txtcod_prov.TabIndex = 49;
            this.txtcod_prov.Tag = "cod_prov";
            // 
            // txtfecha_ped
            // 
            this.txtfecha_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha_ped.Location = new System.Drawing.Point(436, 79);
            this.txtfecha_ped.Name = "txtfecha_ped";
            this.txtfecha_ped.Size = new System.Drawing.Size(142, 20);
            this.txtfecha_ped.TabIndex = 25;
            this.txtfecha_ped.Tag = "fecha_ped";
            // 
            // txtcant_ped
            // 
            this.txtcant_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcant_ped.Location = new System.Drawing.Point(121, 80);
            this.txtcant_ped.Name = "txtcant_ped";
            this.txtcant_ped.Size = new System.Drawing.Size(161, 20);
            this.txtcant_ped.TabIndex = 24;
            this.txtcant_ped.Tag = "cantidad_ped";
            // 
            // txtunitm_ped
            // 
            this.txtunitm_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunitm_ped.Location = new System.Drawing.Point(436, 50);
            this.txtunitm_ped.Name = "txtunitm_ped";
            this.txtunitm_ped.Size = new System.Drawing.Size(142, 20);
            this.txtunitm_ped.TabIndex = 23;
            this.txtunitm_ped.Tag = "unidad_ped";
            // 
            // lblmp
            // 
            this.lblmp.AutoSize = true;
            this.lblmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmp.Location = new System.Drawing.Point(23, 57);
            this.lblmp.Name = "lblmp";
            this.lblmp.Size = new System.Drawing.Size(74, 13);
            this.lblmp.TabIndex = 17;
            this.lblmp.Text = "Materia Prima:";
            // 
            // lblunitm_ped
            // 
            this.lblunitm_ped.AutoSize = true;
            this.lblunitm_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunitm_ped.Location = new System.Drawing.Point(325, 54);
            this.lblunitm_ped.Name = "lblunitm_ped";
            this.lblunitm_ped.Size = new System.Drawing.Size(105, 13);
            this.lblunitm_ped.TabIndex = 18;
            this.lblunitm_ped.Text = "Unididad de Medida:";
            // 
            // lblcant_ped
            // 
            this.lblcant_ped.AutoSize = true;
            this.lblcant_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcant_ped.Location = new System.Drawing.Point(23, 82);
            this.lblcant_ped.Name = "lblcant_ped";
            this.lblcant_ped.Size = new System.Drawing.Size(52, 13);
            this.lblcant_ped.TabIndex = 19;
            this.lblcant_ped.Text = "Cantidad:";
            // 
            // lblfecha_ped
            // 
            this.lblfecha_ped.AutoSize = true;
            this.lblfecha_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha_ped.Location = new System.Drawing.Point(325, 83);
            this.lblfecha_ped.Name = "lblfecha_ped";
            this.lblfecha_ped.Size = new System.Drawing.Size(40, 13);
            this.lblfecha_ped.TabIndex = 20;
            this.lblfecha_ped.Text = "Fecha:";
            // 
            // wf_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 275);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblcodped);
            this.Controls.Add(this.txtcod_ped);
            this.Controls.Add(this.gboPersonalesPed);
            this.Name = "wf_Pedido";
            this.Text = "wf_Pedido";
            this.gboPersonalesPed.ResumeLayout(false);
            this.gboPersonalesPed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblcodped;
        private System.Windows.Forms.TextBox txtcod_ped;
        private System.Windows.Forms.GroupBox gboPersonalesPed;
        private System.Windows.Forms.TextBox txtcod_mp;
        private System.Windows.Forms.ComboBox cbocodmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbocodprov;
        private System.Windows.Forms.Label lblprov;
        private System.Windows.Forms.TextBox txtcod_prov;
        private System.Windows.Forms.TextBox txtfecha_ped;
        private System.Windows.Forms.TextBox txtcant_ped;
        private System.Windows.Forms.TextBox txtunitm_ped;
        private System.Windows.Forms.Label lblmp;
        private System.Windows.Forms.Label lblunitm_ped;
        private System.Windows.Forms.Label lblcant_ped;
        private System.Windows.Forms.Label lblfecha_ped;
    }
}