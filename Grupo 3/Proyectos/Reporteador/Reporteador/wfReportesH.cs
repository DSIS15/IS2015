using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Reflection;
using System.IO;
using System.Drawing.Printing;

namespace Reporteador
{
    public partial class wfReportesH : Form
    {
        public string sNombreReporte = string.Empty;
        public string sSubReporte = string.Empty;
        public string sQuery = string.Empty;
        private string sDataSet = string.Empty;
        private object objDataTable;

        public wfReportesH()
        {
            InitializeComponent();
        }

        private void wfReportesH_Load(object sender, EventArgs e)
        {
            this.Text = sNombreReporte;
            switch (sSubReporte)
            {
                case "CompraVenta":
                    dtCompraVentaTA.Fill(this.dsBaseDatosSCF.dtCompraVenta);
                    if (string.Compare(sQuery, string.Empty) != 0)
                    {
                        dtCompraVentaTA.Adapter.SelectCommand.CommandText = sQuery;
                    }
                    dtCompraVentaTA.Fill(this.dsBaseDatosSCF.dtCompraVenta);
                    objDataTable = (object)dsBaseDatosSCF.dtCompraVenta;
                    sDataSet = "dsCompraVenta";
                    break;
                default: break;
            }
            ReportParameter rp1 = new ReportParameter("rpNombreReporte", sNombreReporte);
            ReportParameter rp2 = new ReportParameter("rpSubReporte", sSubReporte);
            rpReporteador.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            PageSettings pg = new PageSettings();
            PaperSource ps = new PaperSource();
            ps.RawKind = 75;            
            pg.PaperSource = ps;
            pg.Landscape = true;
            rpReporteador.SetPageSettings(pg);
            rpReporteador.LocalReport.DisplayName = sNombreReporte;
            rpReporteador.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2 });
            rpReporteador.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
            rpReporteador.RefreshReport();
        }

        private void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource(sDataSet, objDataTable));
        }
    }
}
