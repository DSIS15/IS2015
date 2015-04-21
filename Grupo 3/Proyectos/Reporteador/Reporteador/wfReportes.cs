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
using System.Reflection;
using System.IO;
using System.Drawing.Printing;

namespace Reporteador
{
    public partial class wfReportes : Form
    {
        public string sNombreReporte = string.Empty;
        public string sSubReporte = string.Empty;
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
                    objDataTable = (object)dsBaseDatosSCF.dtPerfiles;
                    sDataSet = "dsPerfiles";
                    break;
                case "Usuarios":
                    dtUsuariosTA.Fill(this.dsBaseDatosSCF.dtUsuarios);
                    objDataTable = (object)dsBaseDatosSCF.dtUsuarios;
                    sDataSet = "dsUsuarios";
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
