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
        //public string sUsuario;//Variable global que contiene usuario conectado
        //public string vgEmpresa;
        //public string vgMoneda;
               
        
        public wfMenuPrincipal()
        {
            InitializeComponent();
           
        }

        public void wfMenuPrincipal_Load(object sender, EventArgs e)
        {
            //tsUsuario.Text = "Conectado - " + vgUsuario;
            ////////////tsUsuario.Text = sUsuario;
            ////////////tsEmpresa.Text = vgEmpresa;
            ////////////tsMoneda.Text = vgMoneda;
            //tsBodega.Text = "Bodega - ";
            //tsFecha.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
            //tsFecha.Text = DateTime.Now.ToShortTimeString();
            datos();
                       
       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           //tsFecha.Text = "                                                                                                                                                                                                                                              "
           //    + DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
           tsHorario.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
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

       private void salirDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       public void cambioDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Seguridad_Producción.wfEmpresa Empresa = new Seguridad_Producción.wfEmpresa();
           Empresa.MdiParent = this;
           Empresa.Show();
           tsEmpresa.Text = Empresa.VNom_empsa;
       }

       private void cambioDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Seguridad_Producción.wfMoneda Moneda = new Seguridad_Producción.wfMoneda();
           Moneda.MdiParent = this;
           Moneda.Show();
           tsMoneda.Text = Moneda.VMoneda_mda;

          
       }

             
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
       {
           //wfMenuPrincipal.Hide();
           //new wfInicioSesion().Show();
       }

        public void datos() 
        {
            //////Seguridad_Producción.Presentación.wfInicioSesion InicioS = new Seguridad_Producción.Presentación.wfInicioSesion(new wfMenuPrincipal());
            ////tsUsuario.Text = InicioS.SUsuario;
            ////tsEmpresa.Text = InicioS.SEmpresa;
            ////tsMoneda.Text = InicioS.SMoneda;
            
        }

        private void reporteProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIP_Administrativo.wf_Empleados Clientes = new SIP_Administrativo.wf_Empleados();
            Clientes.MdiParent = this;
            Clientes.Show();
            
        }

        private void pedidoMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos.wfpedido_prov Pedido = new Pedidos.wfpedido_prov();
            Pedido.MdiParent = this;
            Pedido.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdFormula.wf_Formula Formula = new pdFormula.wf_Formula();
            Formula.MdiParent = this;
            Formula.Show();
        }

     

                     
      
    }
}
