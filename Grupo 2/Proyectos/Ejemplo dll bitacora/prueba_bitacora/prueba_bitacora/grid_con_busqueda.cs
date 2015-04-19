using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_bitacora
{
    public partial class grid_con_busqueda : Form
    {
        public grid_con_busqueda()
        {
            InitializeComponent();
        }

        private void grid_con_busqueda_Load(object sender, EventArgs e)
        {
            String[,] Scadena = {
                                {"id_bitacora","ID","true"},
                                {"nombre","Nombre","true",},
                                {"descripcion","Descripcion","true"},
                                {"fecha","Fecha","true"},
                                };
            cuDataGridConBusqueda1.AlDatosEntrada.Add(Scadena);
            cuDataGridConBusqueda1.vinicializar();
        }
    }
}
