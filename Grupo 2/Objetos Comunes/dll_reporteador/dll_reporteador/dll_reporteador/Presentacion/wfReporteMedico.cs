/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 18-05-2015
 * Autor: Jessica Marisol Castellanos Martínez 
 * Descripcion: Este formulario muestra el Reporte Medico
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_reporteador.Presentacion
{
    public partial class wfReporteMedico : Form
    {
        public wfReporteMedico()
        {
            InitializeComponent();
        }

        private void wfReporteMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMedico.dtMedico' Puede moverla o quitarla según sea necesario.
            this.dtMedicoTA.Fill(this.dsMedico.dtMedico);

            this.reportViewer1.RefreshReport();
        }
    }
}
