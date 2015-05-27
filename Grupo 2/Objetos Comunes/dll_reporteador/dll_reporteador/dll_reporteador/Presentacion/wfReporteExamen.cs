/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 18-05-2015
 * Autor: Jessica Marisol Castellanos Martínez 
 * Descripcion: Este formulario muestra el Reporte Examen Rutinario
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
    public partial class wfReporteExamen : Form
    {
        public wfReporteExamen()
        {
            InitializeComponent();
        }

        private void wfReporteExamen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsExamen.dtExamen' Puede moverla o quitarla según sea necesario.
            this.dtExamenTA.Fill(this.dsExamen.dtExamen);

            this.reportViewer1.RefreshReport();
        }
    }
}
