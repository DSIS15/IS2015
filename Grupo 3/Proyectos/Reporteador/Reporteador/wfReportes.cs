using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Reporteador
{
    public partial class wfReportes : Form
    {
        private string sNombreReporte = string.Empty;

        public string SNombreReporte
        {
            get { return sNombreReporte; }
            set { sNombreReporte = value; }
        }

        public wfReportes()
        {
            InitializeComponent();
        }

        private void wfReportes_Load(object sender, EventArgs e)
        {

        }

        private void vSeleccionarReporte()
        {
            dynamic rdsFuenteDatos = new Microsoft.Reporting.WinForms.ReportDataSource();
            rvReporteador.LocalReport.DataSources.Clear();
            switch (sNombreReporte)
            {
                case "Estado Financiero":
                    rdsFuenteDatos.Name = "dsEstadoFinanciero";
                    dtAmbientesTA.Fill(dsBaseDatos.dtAmbientes);
                    rdsFuenteDatos.Value = dtAmbientesBindingSource;
                    rvReporteador.LocalReport.DataSources.Add(rdsFuenteDatos);
                    rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpEstadoFinanciero.rdlc";
                    break;
                case "Conciliación Bancaria":
                    rdsFuenteDatos.Name = "dsConciliacionBancaria";
                    dtCatProductosTA.Fill(dsBaseDatos.dtCatProductos);
                    rdsFuenteDatos.Value = dtCatProductosBindingSource;
                    rvReporteador.LocalReport.DataSources.Add(rdsFuenteDatos);
                    rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpConciliacionBancaria.rdlc";
                    break;
                case "Clientes":
                    rdsFuenteDatos.Name = "dsClientes";
                    dtClientesTA.Fill(dsBaseDatos.dtClientes);
                    rdsFuenteDatos.Value = dtClientesBindingSource;
                    rvReporteador.LocalReport.DataSources.Add(rdsFuenteDatos);
                    rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpClientes.rdlc";
                    break;
                case "Balance General":
                    rdsFuenteDatos.Name = "dsBalanceGeneral";
                    dtDocumentosTA.Fill(dsBaseDatos.dsDocumentos);
                    rdsFuenteDatos.Value = dtDocumentosBindingSource;
                    rvReporteador.LocalReport.DataSources.Add(rdsFuenteDatos);
                    rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpBalanceGeneral.rdlc";
                    break;
                case "Facturas":
                    rdsFuenteDatos.Name = "dsFacturas";
                    dtFacturasTA.Fill(dsBaseDatos.dtFacturas);
                    rdsFuenteDatos.Value = dtFacturasBindingSource;
                    rvReporteador.LocalReport.DataSources.Add(rdsFuenteDatos);
                    rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpFacturas.rdlc";
                    break;
                case "Reservaciones":
                    rdsFuenteDatos.Name = "dsReservaciones";
                    dtReservacionesTA.Fill(dsBaseDatos.dtReservaciones);
                    rdsFuenteDatos.Value = dtReservacionesBindingSource;
                    rvReporteador.LocalReport.DataSources.Add(rdsFuenteDatos);
                    rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpReservaciones.rdlc";
                    break;
                case "Servicios":
                    rdsFuenteDatos.Name = "dsServicios";
                    dtServiciosTA.Fill(dsBaseDatos.dtServicios);
                    rdsFuenteDatos.Value = dtServiciosBindingSource;
                    rvReporteador.LocalReport.DataSources.Add(rdsFuenteDatos);
                    rvReporteador.LocalReport.ReportEmbeddedResource = "Reporteador.rpServicios.rdlc";
                    break;
                default: break;
            }
            rvReporteador.RefreshReport();
        }

        private void cboInformes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
