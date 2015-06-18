namespace Materia_Prima
{
    partial class wf_MateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_MateriaPrima));
            this.navegador1 = new Navegador.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            this.gboMateriaPrima = new System.Windows.Forms.GroupBox();
            this.txtprecio_mp = new System.Windows.Forms.TextBox();
            this.lblpreciomp = new System.Windows.Forms.Label();
            this.lblunidmmp = new System.Windows.Forms.Label();
            this.txtunidm_mp = new System.Windows.Forms.TextBox();
            this.txtcant_mp = new System.Windows.Forms.TextBox();
            this.lblcantmp = new System.Windows.Forms.Label();
            this.txtnom_mp = new System.Windows.Forms.TextBox();
            this.lblnommp = new System.Windows.Forms.Label();
            this.txtcod_mp = new System.Windows.Forms.TextBox();
            this.lblcodmp = new System.Windows.Forms.Label();
            this.gboMateriaPrima.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(39, 23);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_materiaprima";
            this.navegador1.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(508, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gboMateriaPrima
            // 
            this.gboMateriaPrima.Controls.Add(this.txtprecio_mp);
            this.gboMateriaPrima.Controls.Add(this.lblpreciomp);
            this.gboMateriaPrima.Controls.Add(this.lblunidmmp);
            this.gboMateriaPrima.Controls.Add(this.txtunidm_mp);
            this.gboMateriaPrima.Controls.Add(this.txtcant_mp);
            this.gboMateriaPrima.Controls.Add(this.lblcantmp);
            this.gboMateriaPrima.Controls.Add(this.txtnom_mp);
            this.gboMateriaPrima.Controls.Add(this.lblnommp);
            this.gboMateriaPrima.Controls.Add(this.button1);
            this.gboMateriaPrima.Location = new System.Drawing.Point(39, 125);
            this.gboMateriaPrima.Name = "gboMateriaPrima";
            this.gboMateriaPrima.Size = new System.Drawing.Size(598, 139);
            this.gboMateriaPrima.TabIndex = 63;
            this.gboMateriaPrima.TabStop = false;
            this.gboMateriaPrima.Text = "Datos Materia Prima";
            // 
            // txtprecio_mp
            // 
            this.txtprecio_mp.Location = new System.Drawing.Point(81, 110);
            this.txtprecio_mp.Name = "txtprecio_mp";
            this.txtprecio_mp.Size = new System.Drawing.Size(100, 20);
            this.txtprecio_mp.TabIndex = 42;
            this.txtprecio_mp.Tag = "precio_mp";
            // 
            // lblpreciomp
            // 
            this.lblpreciomp.AutoSize = true;
            this.lblpreciomp.Location = new System.Drawing.Point(28, 113);
            this.lblpreciomp.Name = "lblpreciomp";
            this.lblpreciomp.Size = new System.Drawing.Size(40, 13);
            this.lblpreciomp.TabIndex = 41;
            this.lblpreciomp.Text = "Precio:";
            // 
            // lblunidmmp
            // 
            this.lblunidmmp.AutoSize = true;
            this.lblunidmmp.Location = new System.Drawing.Point(28, 75);
            this.lblunidmmp.Name = "lblunidmmp";
            this.lblunidmmp.Size = new System.Drawing.Size(97, 13);
            this.lblunidmmp.TabIndex = 40;
            this.lblunidmmp.Text = "Unidad de Medida:";
            // 
            // txtunidm_mp
            // 
            this.txtunidm_mp.Location = new System.Drawing.Point(131, 72);
            this.txtunidm_mp.Name = "txtunidm_mp";
            this.txtunidm_mp.Size = new System.Drawing.Size(215, 20);
            this.txtunidm_mp.TabIndex = 39;
            this.txtunidm_mp.Tag = "unimedida_mp";
            // 
            // txtcant_mp
            // 
            this.txtcant_mp.Location = new System.Drawing.Point(425, 72);
            this.txtcant_mp.Name = "txtcant_mp";
            this.txtcant_mp.Size = new System.Drawing.Size(131, 20);
            this.txtcant_mp.TabIndex = 38;
            this.txtcant_mp.Tag = "canitdad_mp";
            // 
            // lblcantmp
            // 
            this.lblcantmp.AutoSize = true;
            this.lblcantmp.Location = new System.Drawing.Point(370, 79);
            this.lblcantmp.Name = "lblcantmp";
            this.lblcantmp.Size = new System.Drawing.Size(49, 13);
            this.lblcantmp.TabIndex = 37;
            this.lblcantmp.Text = "Cantidad";
            // 
            // txtnom_mp
            // 
            this.txtnom_mp.Location = new System.Drawing.Point(81, 28);
            this.txtnom_mp.Name = "txtnom_mp";
            this.txtnom_mp.Size = new System.Drawing.Size(403, 20);
            this.txtnom_mp.TabIndex = 36;
            this.txtnom_mp.Tag = "nom_mp";
            // 
            // lblnommp
            // 
            this.lblnommp.AutoSize = true;
            this.lblnommp.Location = new System.Drawing.Point(28, 34);
            this.lblnommp.Name = "lblnommp";
            this.lblnommp.Size = new System.Drawing.Size(47, 13);
            this.lblnommp.TabIndex = 35;
            this.lblnommp.Text = "Nombre:";
            // 
            // txtcod_mp
            // 
            this.txtcod_mp.Location = new System.Drawing.Point(537, 99);
            this.txtcod_mp.Name = "txtcod_mp";
            this.txtcod_mp.Size = new System.Drawing.Size(100, 20);
            this.txtcod_mp.TabIndex = 64;
            this.txtcod_mp.Tag = "cod_mp";
            // 
            // lblcodmp
            // 
            this.lblcodmp.AutoSize = true;
            this.lblcodmp.Location = new System.Drawing.Point(464, 102);
            this.lblcodmp.Name = "lblcodmp";
            this.lblcodmp.Size = new System.Drawing.Size(43, 13);
            this.lblcodmp.TabIndex = 65;
            this.lblcodmp.Text = "Codigo:";
            // 
            // wf_MateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 296);
            this.Controls.Add(this.lblcodmp);
            this.Controls.Add(this.txtcod_mp);
            this.Controls.Add(this.gboMateriaPrima);
            this.Controls.Add(this.navegador1);
            this.Name = "wf_MateriaPrima";
            this.Text = "Materia Prima";
            this.Load += new System.EventHandler(this.wf_MateriaPrima_Load);
            this.gboMateriaPrima.ResumeLayout(false);
            this.gboMateriaPrima.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void wf_Proveedores_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gboMateriaPrima;
        private System.Windows.Forms.TextBox txtnom_mp;
        private System.Windows.Forms.Label lblnommp;
        private System.Windows.Forms.TextBox txtcod_mp;
        private System.Windows.Forms.Label lblcodmp;
        private System.Windows.Forms.TextBox txtcant_mp;
        private System.Windows.Forms.Label lblcantmp;
        private System.Windows.Forms.Label lblunidmmp;
        private System.Windows.Forms.TextBox txtunidm_mp;
        private System.Windows.Forms.TextBox txtprecio_mp;
        private System.Windows.Forms.Label lblpreciomp;
    }
}