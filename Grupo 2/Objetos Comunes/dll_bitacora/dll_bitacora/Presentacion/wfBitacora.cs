using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_bitacora.Presentacion
{
    public partial class wfBitacora : Form
    {
        public wfBitacora()
        {
            InitializeComponent();
        }

        private void wfBitacora_Load(object sender, EventArgs e)
        {
            String[,] sCadena = {
                                    {"id_bitacora","ID","true"},
                                    {"alias_usuario","Alias","true"},
                                    {"nombre_usuario","Nombre","true"},
                                    {"primer_apellido","Apellido","true"},
                                    {"hostname","Hostname","true"},
                                    {"fecha","Fecha","true"},
                                    {"hora","Hora","true"},
                                    {"ip","IP","true"},
                                    {"descripcion","Descripción","true"}
                                };
            cuDataGridConBusqueda1.AlDatosEntrada.Add(sCadena);
            cuDataGridConBusqueda1.vinicializar();
        }

        private void cuDataGridConBusqueda1_Load(object sender, EventArgs e)
        {

        }
    }
}
