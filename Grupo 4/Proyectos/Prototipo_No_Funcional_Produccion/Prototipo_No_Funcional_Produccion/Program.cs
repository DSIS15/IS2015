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
            Application.Run(new Seguridad_Producción.Presentación.wfInicioSesion(new wfMenuPrincipal()));
            //Application.Run(new wfInicioSesion());
                       
        }
    }
}
