using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produccion
{
    public partial class wfProducciones : Form
    {

        /*
         * Roberto Alexander Grave Vicente
         * 0901-11-16185
          */
        csNegocio obtDatosN = new csNegocio();
        public wfProducciones()
        {
            InitializeComponent();
        }

        private void wfProducciones_Load(object sender, EventArgs e)
        {
        

            BindingSource obtDatosPro = new BindingSource();
            obtDatosPro.DataSource = obtDatosN.obtDatosProduccion();
            dgvProduccion.DataSource = obtDatosPro;
            

        
        }

        private void btnReporteP_Click(object sender, EventArgs e)
        {
           
        }
    }
}
