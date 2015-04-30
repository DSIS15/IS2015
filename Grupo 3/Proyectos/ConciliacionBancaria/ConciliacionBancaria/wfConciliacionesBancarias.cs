using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConciliacionBancaria
{
    public partial class wfConciliacionesBancarias : Form
    {
        BindingSource bsConciliaciones = new BindingSource();
        DataTable dtConciliaciones = new DataTable();
        private string sQuery = string.Empty;

        public wfConciliacionesBancarias()
        {
            InitializeComponent();
        }

        private void vLlenarDgvProductosAmbiente()
        {
            sQuery = "select cod_estcta, cod_mov, fechconci_conci, conciliado_conci, estado_conci from tabm_conciliacion where cod_estcta like '" + txtClave.Text + "%' or cod_mov like '" + txtClave.Text + "%' or fechconci_conci like '" + txtClave.Text + "%' or conciliado_conci like '" + txtClave.Text + "%' or estado_conci like '" + txtClave.Text + "%'";
            dtConciliaciones = Capas.csNegocio.dtConsultarRegistros(sQuery);
            if (dtConciliaciones.Rows.Count != 0)
            {
                dtConciliaciones.Columns[0].ColumnName = "Código";
                dtConciliaciones.Columns[1].ColumnName = "Movimiento";
                dtConciliaciones.Columns[2].ColumnName = "Fecha";
                dtConciliaciones.Columns[3].ColumnName = "Conciliado";
                dtConciliaciones.Columns[4].ColumnName = "Estado";
            }
            else
            {
                dtConciliaciones.Columns.Add("Código");
                dtConciliaciones.Columns.Add("Movimiento");
                dtConciliaciones.Columns.Add("Fecha");
                dtConciliaciones.Columns.Add("Conciliado");
                dtConciliaciones.Columns.Add("Estado");
            }
            bsConciliaciones.DataSource = dtConciliaciones;
            dgvBitacora.DataSource = bsConciliaciones;
        }

        private void wfConciliacionesBancarias_Load(object sender, EventArgs e)
        {
            btnRecargar_Click(this, e);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            vLlenarDgvProductosAmbiente();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporte = new Reporteador.wfReportes();
            Reporte.sNombreReporte = "Conciliaciones Bancarias";
            Reporte.sSubReporte = "ConciliacionesBancarias";
            //Reporte.sQuery = sQuery;
            Reporte.ShowDialog();
        }
    }
}
