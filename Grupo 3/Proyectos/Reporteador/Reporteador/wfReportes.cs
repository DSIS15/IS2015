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
    public partial class wfReportes : Form
    {
        public string sNombreReporte = string.Empty;
        public string sSubReporte = string.Empty;
        public string sQuery = string.Empty;
        private string sDataSet = string.Empty;
        private object objDataTable;

        public wfReportes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = sNombreReporte;
            switch (sSubReporte)
            {
                case "Perfiles":
                    dtPerfilesTA.Fill(this.dsBaseDatosSCF.dtPerfiles);
                    if (string.Compare(sQuery, string.Empty) != 0)
                    {
                        dtPerfilesTA.Adapter.SelectCommand.CommandText = sQuery;
                    }
                    dtPerfilesTA.Fill(this.dsBaseDatosSCF.dtPerfiles);
                    objDataTable = (object)dsBaseDatosSCF.dtPerfiles;
                    sDataSet = "dsPerfiles";
                    break;
                case "Usuarios":
                    dtUsuariosTA.Fill(this.dsBaseDatosSCF.dtUsuarios);
                    if (string.Compare(sQuery, string.Empty) != 0)
                    {
                        dtUsuariosTA.Adapter.SelectCommand.CommandText = sQuery;
                    }
                    dtUsuariosTA.Fill(this.dsBaseDatosSCF.dtUsuarios);
                    objDataTable = (object)dsBaseDatosSCF.dtUsuarios;
                    sDataSet = "dsUsuarios";
                    break;
                case "Conciliaciones":
                    dtConciliacionesTA.Fill(this.dsBaseDatosSCF.dtConciliaciones);
                    if (string.Compare(sQuery, string.Empty) != 0)
                    {
                        dtConciliacionesTA.Adapter.SelectCommand.CommandText = sQuery;
                    }
                    dtConciliacionesTA.Fill(this.dsBaseDatosSCF.dtConciliaciones);
                    objDataTable = (object)dsBaseDatosSCF.dtConciliaciones;
                    sDataSet = "dsConciliaciones";
                    break;
                case "EstadoResultados":
                    dtEstadoResultadosTA.Fill(this.dsBaseDatosSCF.dtEstadoResultados);
                    if (string.Compare(sQuery, string.Empty) != 0)
                    {
                        dtEstadoResultadosTA.Adapter.SelectCommand.CommandText = sQuery;
                    }
                    dtEstadoResultadosTA.Fill(this.dsBaseDatosSCF.dtEstadoResultados);
                    objDataTable = (object)dsBaseDatosSCF.dtEstadoResultados;
                    sDataSet = "dsEstadoResultados";
                    break;
                case "BalanceGeneral":
                    dtBalanceGeneralTA.Fill(this.dsBaseDatosSCF.dtBalanceGeneral);
                    if (string.Compare(sQuery, string.Empty) != 0)
                    {
                        dtBalanceGeneralTA.Adapter.SelectCommand.CommandText = sQuery;
                    }
                    dtBalanceGeneralTA.Fill(this.dsBaseDatosSCF.dtBalanceGeneral);
                    objDataTable = (object)dsBaseDatosSCF.dtBalanceGeneral;
                    sDataSet = "dsBalanceGeneral";
                    break;
                case "BalanceSaldos":
                    dtBalanceSaldosTA.Fill(this.dsBaseDatosSCF.dtBalanceSaldos);
                    if (string.Compare(sQuery, string.Empty) != 0)
                    {
                        dtBalanceSaldosTA.Adapter.SelectCommand.CommandText = sQuery;
                    }
                    dtBalanceSaldosTA.Fill(this.dsBaseDatosSCF.dtBalanceSaldos);
                    objDataTable = (object)dsBaseDatosSCF.dtBalanceSaldos;
                    sDataSet = "dsBalanceSaldos";
                    break;
                default: break;
            }
            ReportParameter rp1 = new ReportParameter("rpNombreReporte", sNombreReporte);
            ReportParameter rp2 = new ReportParameter("rpSubReporte", sSubReporte);
            rpReporteador.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            PageSettings pg = new PageSettings();
            PaperSource ps = new PaperSource();
            ps.RawKind = 1;
            pg.PaperSource = ps;
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
