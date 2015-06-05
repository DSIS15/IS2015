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
    public partial class wf_RepoMateriaPrima : Form
    {
        public wf_RepoMateriaPrima()
        {
            InitializeComponent();
        }

        private void wf_RepoMateriaPrima_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DT_MateriaPrima.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DT_MateriaPrima.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
