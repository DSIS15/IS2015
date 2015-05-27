/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 18-05-2015
 * Autor: Jessica Marisol Castellanos Martínez 
 * Descripcion: Este formulario muestra el Reporte Factura
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
    public partial class wfReporteFactura : Form
    {
        public wfReporteFactura()
        {
            InitializeComponent();
        }

        private void wfReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFactura.dtFactura' Puede moverla o quitarla según sea necesario.
            this.dtFacturaTA.Fill(this.dsFactura.dtFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
