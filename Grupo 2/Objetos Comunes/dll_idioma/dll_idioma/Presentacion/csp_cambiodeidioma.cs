using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_idioma.Presentacion
{
    public static class csp_cambiodeidioma
    {
        public static String sobteneridioma;

        public static void vinicializaridioma(Form frmFormulario)
        {
         Negocio.csN_Cambiodeidioma csn_cambiodeidioma = new Negocio.csN_Cambiodeidioma();         
         csn_cambiodeidioma.vObtenerdatosformulario(sobteneridioma, frmFormulario);
        }

    }
}
