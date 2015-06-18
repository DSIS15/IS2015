using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Produccion;


namespace Produccion_EnterpriseSolution
{
   
    public partial class wfMenuPrincipal : Form
    {
        
        csNegocios dgvBt = new csNegocios();
       
        public string vgUsuario;//Variable global que contiene usuario conectado
        public string vgEmpresa;
        public string vgMoneda;
        private int per;
        public string op;
        //wfBitacora wfbi;
        
        
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
            op = vgUsuario;

            h(op);
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

       private void privilegiosToolStripMenuItem_Click(object sender, EventArgs e)
       {
           wfPermiso wfper = new wfPermiso();
           wfper.MdiParent = this;
           wfper.Show();  

       }


       public void h(string opc)
       {
           DataTable dt = new DataTable();
           string dtd;
           dt = dgvBt.obtDatosdgvPer();
           DataRow[] result = dt.Select("Usuario = '" + opc + "' ");

           foreach(DataRow row in result)
               {
                   dtd = row[2].ToString();
                   per = Convert.ToInt32(dtd);
           }
           
          // MessageBox.Show("permisos..... "+ per);
           switch(per)
           {
               
               case 4: {
                    this.reporteBitacoraDeUsuariosToolStripMenuItem.Enabled = false;
                    this.reporteInventarioToolStripMenuItem.Enabled = false;
                    this.reporteProducciónToolStripMenuItem.Enabled = false;

               }break;
                        
           
           }
        
           
       }

       private void salirDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
       {
           wfBitacora wfBit = new wfBitacora(per);
           wfBit.MdiParent = this;
           wfBit.Show();
       }

       private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Restart();
           
       }

       private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
       {
           
       }

       private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           wfUsuario wfUsuario = new wfUsuario(per);
           wfUsuario.MdiParent = this;
           wfUsuario.Show();
       }

       private void fabricaciónProductoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           wfProduccion prod = new wfProduccion();
           prod.MdiParent = this;
           prod.Show();
       }

       private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_Clientes cte = new SIP_Administrativo.wf_Clientes();
           cte.MdiParent = this;
           cte.Show();
       }
       private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_Clientes cte = new SIP_Administrativo.wf_Clientes();
           cte.MdiParent = this;
           cte.Show();
       }
       private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_Busquedacte cte_busqueda = new SIP_Administrativo.wf_Busquedacte();
           cte_busqueda.MdiParent = this;
           cte_busqueda.Show();
       }

       private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_Proveedores provee = new SIP_Administrativo.wf_Proveedores();
           provee.MdiParent = this;
           provee.Show();
       }

       private void editarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_Proveedores provee = new SIP_Administrativo.wf_Proveedores();
           provee.MdiParent = this;
           provee.Show();
       }

       private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_BusquedaPro provee_busqueda = new SIP_Administrativo.wf_BusquedaPro();
           provee_busqueda.MdiParent = this;
           provee_busqueda.Show();
       }

       private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_Empleados emp = new SIP_Administrativo.wf_Empleados();
           emp.MdiParent = this;
           emp.Show();
       }

       private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_Empleados emp = new SIP_Administrativo.wf_Empleados();
           emp.MdiParent = this;
           emp.Show();
       }

       private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SIP_Administrativo.wf_BusquedaEmp emp_busqueda = new SIP_Administrativo.wf_BusquedaEmp();
           emp_busqueda.MdiParent = this;
           emp_busqueda.Show();
       }

       private void ingresoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Materia_Prima.wf_MateriaPrima materia_prima = new Materia_Prima.wf_MateriaPrima();
           materia_prima.MdiParent = this;
           materia_prima.Show();
       }

       private void busquedaMPToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Materia_Prima.wf_BusquedaMp mp_busqueda = new Materia_Prima.wf_BusquedaMp();
           mp_busqueda.MdiParent = this;
           mp_busqueda.Show();
       }

       private void generadorCodigoDeBarrasToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Cod_Bar.wf_CodigoBarras codigo_barras = new Cod_Bar.wf_CodigoBarras();
           codigo_barras.MdiParent = this;
           codigo_barras.Show();
       }

       private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Pedidos.wfpedido_prov pedido_provee = new Pedidos.wfpedido_prov();
           pedido_provee.MdiParent = this;
           pedido_provee.Show();
       }

       private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
       {
           
       }

       private void reporteProductosTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }

       private void rerporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoCliente cliente_rep = new Reporteador_IS.wf_RepoCliente();
           cliente_rep.MdiParent = this;
           cliente_rep.Show();
       }

       private void reporteEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoEmpleado empleado_rep = new Reporteador_IS.wf_RepoEmpleado();
           empleado_rep.MdiParent = this;
           empleado_rep.Show();  
       }

       private void reporteProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoProveedor proveedor_rep = new Reporteador_IS.wf_RepoProveedor();
           proveedor_rep.MdiParent = this;
           proveedor_rep.Show();
       }

       private void repMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoMateriaPrima mp_rep = new Reporteador_IS.wf_RepoMateriaPrima();
           mp_rep.MdiParent = this;
           mp_rep.Show();

       }

       private void pedidosToolStripMenuItem2_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoPedido pedido_rep = new Reporteador_IS.wf_RepoPedido();
           pedido_rep.MdiParent = this;
           pedido_rep.Show();
       }

       private void formulaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoFormula formula_rep = new Reporteador_IS.wf_RepoFormula();
           formula_rep.MdiParent = this;
           formula_rep.Show();
       }

       private void codigoBarrasToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoCodigoBarras codigobarra_rep = new Reporteador_IS.wf_RepoCodigoBarras();
           codigobarra_rep.MdiParent = this;
           codigobarra_rep.Show();
       }

       private void repProduccionToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_RepoProduccion produccion_rep = new Reporteador_IS.wf_RepoProduccion();
           produccion_rep.MdiParent = this;
           produccion_rep.Show();
       }

       private void formuDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           pdFormula.wf_Formula formula = new pdFormula.wf_Formula();
           formula.MdiParent = this;
           formula.Show();
       }

       private void productosEnBodegaToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Reporteador_IS.wf_ProductoTerminado prodterminado_repo = new Reporteador_IS.wf_ProductoTerminado();
           prodterminado_repo.MdiParent = this;
           prodterminado_repo.Show();
       }

      
    }///////////////
}
