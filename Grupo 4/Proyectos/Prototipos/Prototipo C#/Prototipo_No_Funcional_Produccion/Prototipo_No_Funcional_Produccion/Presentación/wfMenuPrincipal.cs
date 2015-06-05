using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Producción;

namespace Produccion_EnterpriseSolution
{
   
    public partial class wfMenuPrincipal : Form
    {
        public string vgUsuario;//Variable global que contiene usuario conectado
        public string vgEmpresa;
        public string vgMoneda;
       

        public wfMenuPrincipal()
        {
            InitializeComponent();
        }

        private void wfMenuPrincipal_Load(object sender, EventArgs e)
        {
            //tsUsuario.Text = "Conectado - " + vgUsuario;
            tsUsuario.Text = vgUsuario;
            tsEmpresa.Text = vgEmpresa;
            tsMoneda.Text = vgMoneda;
            //tsBodega.Text = "Bodega - ";
            //tsFecha.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
            //tsFecha.Text = DateTime.Now.ToShortTimeString();
            
       }

       private void ordenesDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           //tsFecha.Text = "                                                                                                                                                                                                                                              "
           //    + DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
           tsHorario.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
       }

       private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
       {

       }

       private void tsMoneda_Click(object sender, EventArgs e)
       {
           Seguridad_Producción.wfMoneda Moneda = new Seguridad_Producción.wfMoneda();
           Moneda.MdiParent = this;
           Moneda.Show();
           tsMoneda.Text = Moneda.VMoneda_mda;

       }

       private void tsEmpresa_Click(object sender, EventArgs e)
       {
           Seguridad_Producción.wfEmpresa Empresa = new Seguridad_Producción.wfEmpresa();
           Empresa.MdiParent = this;
           Empresa.Show();
           tsEmpresa.Text = Empresa.VNom_empsa;
                               
       }

    

           
           

       
       
      
    }
}
