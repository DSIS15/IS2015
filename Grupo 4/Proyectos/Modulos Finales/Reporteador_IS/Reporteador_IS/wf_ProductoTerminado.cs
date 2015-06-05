using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporteador_IS
{
    public partial class wf_ProductoTerminado : Form
    {
        public wf_ProductoTerminado()
        {
            InitializeComponent();
        }

        private void wf_ProductoTerminado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DT_Produccion.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DT_Produccion.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
