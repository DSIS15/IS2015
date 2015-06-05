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
    public partial class wf_RepoFormula : Form
    {
        public wf_RepoFormula()
        {
            InitializeComponent();
        }

        private void wf_RepoFormula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DT_Formula.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DT_Formula.DataTable);
            // TODO: esta línea de código carga datos en la tabla 'DT_Formula.DataTable' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }
    }
}
