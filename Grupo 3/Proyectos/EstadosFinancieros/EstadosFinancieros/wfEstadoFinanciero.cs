using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosFinancieros
{
    public partial class wfEstadoFinanciero : Form
    {
        public string sEstadoFinanciero = string.Empty;
        public wfEstadoFinanciero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (sEstadoFinanciero) 
            {
                case "Balance de Saldos": vBalanceSaldos(); break;
                case "Balance General": vBalanceGeneral(); break;
                case "Estado de Resultados": vEstadoResultados(); break;
                case "Flujo de Efectivo": vFlujoEfectivo(); break;
                default: break;
            }
        }

        private void vBalanceSaldos() 
        {
 
        }

        private void vBalanceGeneral()
        {

        }

        private void vEstadoResultados()
        {

        }

        private void vFlujoEfectivo()
        {

        }

        private void dgvEstadosFinancieros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Reporteador.wfReportes Reporte = new Reporteador.wfReportes();
            Reporte.sNombreReporte = sEstadoFinanciero;
            Reporte.sSubReporte = sEstadoFinanciero;
            Reporte.ShowDialog();
        }
    }
}
