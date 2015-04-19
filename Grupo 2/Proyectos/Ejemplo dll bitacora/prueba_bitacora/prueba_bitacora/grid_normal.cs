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
    public partial class grid_normal : Form
    {
        public grid_normal()
        {
            InitializeComponent();
        }

        private void grid_normal_Load(object sender, EventArgs e)
        {
            String[,] Scadena={
                             {"id_usuario","ID","true"},
                             {"nombre","Nombre","true"},
                             {"apellido","apellido","false"},
                             {"fecha_ingreso","Fecha","true"},
                             };
            cuDataGridD1.AlDatosEntrada.Add(Scadena);
            cuDataGridD1.vinicializar();
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = cuDataGridD1.SObtenerDato;
        }
    }
}
