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
using System.IO;
using System.Drawing.Printing;
using System.Reflection;



namespace dll_report
{
    public partial class wfReporte : Form
    {
        public string sNombreReporte = string.Empty;
        public string sSubReporte = string.Empty;
        private string sDataSet = string.Empty;
        private object objDataTable;

        public wfReporte()
        {
            InitializeComponent();
        }

        private void wfReporte_Load(object sender, EventArgs e)
        {
            this.Text = sNombreReporte;
           
            switch (sSubReporte)
            {
                case "Usuario": dtUsuarioTA.Fill(this.dsHospital.dtUsuario);
                    objDataTable = (object)this.dsHospital.dtUsuario;
                    sDataSet = "dsUsuario";
                 //   MessageBox.Show("Switch  " + sSubReporte+"   " +sDataSet.ToString());
                    break;  
                   
            }

            ReportParameter rp1 = new ReportParameter("rpNombreReporte", sNombreReporte);
            ReportParameter rp2 = new ReportParameter("rpSubReporte", sSubReporte);
           // MessageBox.Show(rp1.ToString() + "   " + sSubReporte);
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
