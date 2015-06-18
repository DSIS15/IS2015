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
    public partial class wfBitacora : Form
    {
        csNegocios dgvBt = new csNegocios();
       wfMenuPrincipal wfm = new wfMenuPrincipal();
       private static int opb;
        public wfBitacora(int ipermisos)
        {
            InitializeComponent();
            
            obtdatosDGVPer();
            opb=ipermisos;
        }
       

        private void wfBitacora_Load(object sender, EventArgs e)
        {
            h();
            
        }

        public void h()
        {
            
           // MessageBox.Show(" " + opb);
            switch (opb)
            {

                case 2:
                    {

                        navegador1.btnEliminar.Enabled = false;
                        navegador1.btnModificar.Enabled = false;
                        
                    } break;
                case 3:
                    {
                        navegador1.btnNuevo.Enabled = false;
                        navegador1.btnEliminar.Enabled = false;
                        navegador1.btnModificar.Enabled = false;
                    }break;
                case 4:
                    {
                        navegador1.btnEliminar.Enabled = false;
                        navegador1.btnModificar.Enabled = false;
                    }break;


            }

        }

        public void obtdatosDGVPer()
        {
            BindingSource dgv = new BindingSource();
            dgv.DataSource = dgvBt.obtDatosBit();
            dgvBitacora.DataSource = dgv;
        }

    }
}
