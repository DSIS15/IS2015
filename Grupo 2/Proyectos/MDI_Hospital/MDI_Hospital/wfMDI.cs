using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MDI_Hospital
{
    public partial class wfMDI : Form
    {
        private ArrayList alDatos = new ArrayList();
        private dll_seguridad.Presentacion.csP_CrearMenu csp_crearmenu = new dll_seguridad.Presentacion.csP_CrearMenu();
        

        public wfMDI()
        {
            InitializeComponent();
            
        }

        private void wfMDI_Load(object sender, EventArgs e)
        {
            var objeto = (Form)sender;
            tllblNombre.Text = dll_seguridad.Presentacion.wfInicioSesion.SUsuario;
            alDatos = csp_crearmenu.alPconsultaform(tllblNombre.Text);
            if (alDatos.Count > 0)
            {
                for (int icont = 0; icont < alDatos.Count; icont++)
                {
                    ArrayList alColumnas = (ArrayList)alDatos[icont];
                    mSMenu.Items.Add(csp_crearmenu.TsMIPCrearmenu(alColumnas[0].ToString(), objeto));                       
                }
            }
            else
                {
                    csp_crearmenu.vAplicacion();                   
                }

        }

        private void wfMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();        
            
            
        }
    }
}
