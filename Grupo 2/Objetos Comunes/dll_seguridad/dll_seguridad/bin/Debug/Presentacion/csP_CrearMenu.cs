using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace dll_seguridad.Presentacion
{
    public class csP_CrearMenu
    {
        //creando objeto crea de la capa de negocio csN_CreaMenu
        Negocio.csN_CrearMenu csn_creamenu = new Negocio.csN_CrearMenu();

        public ArrayList alPconsultaform(String sUsuario)
        {
            return csn_creamenu.alNconsultaform(sUsuario);
        }

        public ToolStripMenuItem TsMIPCrearmenu(String sModulo, Form wfFormMdi)
        {
            return csn_creamenu.TSMINmenu(sModulo, wfFormMdi);
        }

        public void vAplicacion()
        {
            MessageBox.Show("Error No se le han asignado Modulos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Restart();
        }
    }
}
