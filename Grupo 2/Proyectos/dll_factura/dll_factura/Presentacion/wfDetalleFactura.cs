using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_factura.Presentacion
{
    public partial class wfDetalleFactura : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfDetalleFactura()
        {
            InitializeComponent();
        }

        private void wfDetalleFactura_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtid_detfact );
            alDatosEntrada.Add(txtid_inven);
            alDatosEntrada.Add(txtnumero_factura);
           
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();

            ///////////////////////////////////////
            //Datos Grid Usuario
            String[,] Scadena ={
                              {"id_usuario","Codigo","true"},
                              {"codigo_perfil","Perfil","true"},
                              {"alias_usuario","Alias","true"},
                              {"contrasena_usuario","Contrasena","false"},
                              {"nombre_usuario","Nombre usuario","true"},
                              {"primer_apellido","Primer apellido","true"},
                              {"segundo_apellido","Segundo apellido","true"},
                              {"direccion","Direccion","true"}, 
                              {"fecha_de_creacion","Fecha de creacion","true",},
                              {"fecha_de_modificacion","Fecha de modificacion","true",},
                              {"estado","Estado","true",},
                              };
            cuDataGridD1.AlDatosEntrada.Add(Scadena);
            cuDataGridD1.vinicializar();
            ///////////////////////////////////

            ///////////////////////////////////////
            //Datos Grid factura
            String[,] Scaden ={
                              {"numero_factura","Codigo","true"},
                              {"nit_cliente","NIT","true"},
                              {"id_usuario","ID usuario","true"},
                              {"id_pacientes","ID pacientes","false"},
                              {"fecha","Fecha","true"},
                              
                              };
            cuDataGridD2.AlDatosEntrada.Add(Scaden);
            cuDataGridD2.vinicializar();
            ///////////////////////////////////

        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbpinventario.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnumero_factura.Text = cuDataGridD2.SObtenerDato;
        }
    }
}
