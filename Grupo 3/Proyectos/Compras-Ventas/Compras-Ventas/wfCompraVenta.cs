/* Autor: Daniel Isaias Moreno
 * Fecha: 16/05/2015
 * Comentario: Moodulo de Generacion de Reportes de Compras y Ventas 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compras_Ventas
{
    public partial class wfCompraVenta : Form
    {
        string sQuery = string.Empty;
        BindingSource bsConciliaciones = new BindingSource();
        DataTable dtConciliaciones = new DataTable();
        public wfCompraVenta()
        {
            InitializeComponent();
        }

        private void wfCompraVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Reporteador.wfReportesH Reporte = new Reporteador.wfReportesH();
            Reporte.sNombreReporte = "Libro de Compras y Ventas";
            Reporte.sSubReporte = "CompraVenta";
            Reporte.sQuery = sQuery;
            Reporte.ShowDialog();
        }



        private void vLlenarDgvComprasVentas()
        {
            sQuery = "SELECT * FROM compraventa where fecha_fact='"+txtClave.Text+"'";
            dtConciliaciones = Capas.csNegocio.dtConsultarRegistros(sQuery);
            if (dtConciliaciones.Rows.Count != 0)
            {
                dtConciliaciones.Columns[0].ColumnName = "Documento";
                dtConciliaciones.Columns[1].ColumnName = "ID Doc";
                dtConciliaciones.Columns[2].ColumnName = "Fecha";
                dtConciliaciones.Columns[3].ColumnName = "Movimiento";
                dtConciliaciones.Columns[4].ColumnName = "Precio";
                dtConciliaciones.Columns[5].ColumnName = "Impuesto";
                dtConciliaciones.Columns[6].ColumnName = "C/D";
                dtConciliaciones.Columns[4].ColumnName = "Total";
            }
            else
            {
                dtConciliaciones.Columns.Add("Documento");
                dtConciliaciones.Columns.Add("ID Doc");
                dtConciliaciones.Columns.Add("Fecha");
                dtConciliaciones.Columns.Add("Movimiento");
                dtConciliaciones.Columns.Add("Precio");
                dtConciliaciones.Columns.Add("Impuesto");
                dtConciliaciones.Columns.Add("C/D");
                dtConciliaciones.Columns.Add("Total");
            }
            bsConciliaciones.DataSource = dtConciliaciones;
            dgvConciliaciones.DataSource = bsConciliaciones;
        }
        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            vLlenarDgvComprasVentas();
        }        
    }
}
