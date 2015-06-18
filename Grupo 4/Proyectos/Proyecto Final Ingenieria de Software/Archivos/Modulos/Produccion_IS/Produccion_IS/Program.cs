using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Producción;

namespace Produccion_EnterpriseSolution
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new wfInicioSesion());
           // Application.Run(new Cod_Bar.wf_CodigoBarras());
           //Application.Run(new wfMenuPrincipal());
        }
    }
}
