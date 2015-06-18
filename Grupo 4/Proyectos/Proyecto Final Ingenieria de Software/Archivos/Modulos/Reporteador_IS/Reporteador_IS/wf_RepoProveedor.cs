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
    public partial class wf_RepoProveedor : Form
    {
        public wf_RepoProveedor()
        {
            InitializeComponent();
        }

        private void wf_RepoProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DT_Proveedor.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DT_Proveedor.DataTable);
            // TODO: esta línea de código carga datos en la tabla 'Rep_Cliente.DataTable' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }
    }
}
