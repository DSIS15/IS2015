using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Produccion_Mod_CTE;

namespace Produccion_EnterpriseSolution
{
    public partial class wfMenuPrincipal : Form
    {
        public wfMenuPrincipal()
        {
            InitializeComponent();
        }

        private void wfMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

       private void ordenesDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }

       private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           wfEmpleado empleado = new wfEmpleado();
           empleado.MdiParent = this;
           empleado.Show();
       }

       
      
    }
}
