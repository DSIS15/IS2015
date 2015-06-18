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
    public partial class wf_RepoCodigoBarras : Form
    {
        public wf_RepoCodigoBarras()
        {
            InitializeComponent();
        }

        private void wf_RepoCodigoBarras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DT_CodigoBarras.Tabm_produccion' Puede moverla o quitarla según sea necesario.
            this.Tabm_produccionTableAdapter.Fill(this.DT_CodigoBarras.Tabm_produccion);

            this.reportViewer1.RefreshReport();
        }
    }
}
