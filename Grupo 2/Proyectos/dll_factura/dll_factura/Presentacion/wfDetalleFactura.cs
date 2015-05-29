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
            alDatosEntrada.Add(txtdescripcion);
            alDatosEntrada.Add(txtnumero_factura);
           
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();

            

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
           
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnumero_factura.Text = cuDataGridD2.SObtenerDato;
        }

        private void txtnumero_factura_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_btnPrimero_AfterClick(object sender, EventArgs e)
        {
            txtdescripcion.Enabled = false;
            txtnumero_factura.Enabled = false;
        }
    }
}
