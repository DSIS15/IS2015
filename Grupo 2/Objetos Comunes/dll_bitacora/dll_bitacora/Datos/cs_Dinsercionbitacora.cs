using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_bitacora.Datos
{
    class cs_Dinsercionbitacora
    {

        public void vinsercion(string sIp, string sHostname, string sFecha, string sHora, string scodusr)
        {
           string sQuery = "insert into bitacora (hostname, fecha, hora, ip, descripcion)";
           ODBCconnector.csFunciones.vInsertar(sQuery);
        }

    }
}
