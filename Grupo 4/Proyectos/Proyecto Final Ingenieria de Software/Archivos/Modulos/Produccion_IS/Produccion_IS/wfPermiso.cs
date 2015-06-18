using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produccion_EnterpriseSolution
{
    public partial class wfPermiso : Form
    {
        csNegocios datosDGVPer = new csNegocios();
        public wfPermiso()
        {
            InitializeComponent();
            obtdatosDGVPer();
        }

        private void wfPermiso_Load(object sender, EventArgs e)
        {

        }

        public void obtdatosDGVPer()
        {
            BindingSource dgv = new BindingSource();
            dgv.DataSource = datosDGVPer.obtDatosdgvPer();
            dgvPermiso.DataSource = dgv;
        }
    }
}
