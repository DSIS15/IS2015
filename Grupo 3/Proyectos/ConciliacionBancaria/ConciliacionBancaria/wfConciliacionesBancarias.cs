using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void vLlenarDgvConciliacionesBancarias()
        {
            sQuery = "select concat(a.anio_estcta, '-', a.nombre_estcta) AS Expr1, b.correlativo_mov, c.fechconci_conci, c.conciliado_conci, c.estado_conci from tabm_estadocuenta a, tabm_conciliacion c, tabm_movimiento b where a.cod_estcta = c.cod_estcta and c.cod_mov = b.cod_mov and (a.cod_estcta like '" + txtClave.Text + "%' or b.cod_mov like '" + txtClave.Text + "%' or c.fechconci_conci like '" + txtClave.Text + "%' or c.conciliado_conci like '" + txtClave.Text + "%' or c.estado_conci like '" + txtClave.Text + "%')";
            dtConciliaciones = Capas.csNegocio.dtConsultarRegistros(sQuery);
            if (dtConciliaciones.Rows.Count != 0)
            {
                dtConciliaciones.Columns[0].ColumnName = "Estado cuenta";
                dtConciliaciones.Columns[1].ColumnName = "Movimiento";
                dtConciliaciones.Columns[2].ColumnName = "Fecha";
                dtConciliaciones.Columns[3].ColumnName = "Conciliado";
                dtConciliaciones.Columns[4].ColumnName = "Estado";
            }
            else
            {
                dtConciliaciones.Columns.Add("Estado cuenta");
                dtConciliaciones.Columns.Add("Movimiento");
                dtConciliaciones.Columns.Add("Fecha");
                dtConciliaciones.Columns.Add("Conciliado");
                dtConciliaciones.Columns.Add("Estado");
            }
            bsConciliaciones.DataSource = dtConciliaciones;
            dgvConciliaciones.DataSource = bsConciliaciones;
        }

        private void wfConciliacionesBancarias_Load(object sender, EventArgs e)
        {
            txtClave_TextChanged(this, e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporte = new Reporteador.wfReportes();
            Reporte.sNombreReporte = "Conciliaciones Bancarias";
            Reporte.sSubReporte = "Conciliaciones";
            Reporte.sQuery = sQuery;
            Reporte.ShowDialog();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            vLlenarDgvConciliacionesBancarias();
        }
    }
}
