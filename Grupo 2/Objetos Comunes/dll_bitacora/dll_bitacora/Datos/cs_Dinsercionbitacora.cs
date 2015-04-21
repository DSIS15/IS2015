using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace dll_bitacora.Datos
{
    class cs_Dinsercionbitacora
    {

        public void vinsercion(string sIp, string sHostname, string sFecha, string sHora, string scodusr, string sDescripcion)
        {
            ArrayList alDatos = new ArrayList();
            alDatos = ODBCconnector.csFunciones.alConsultar("Select id_bitacora from bitacora_hospital");
            String sIDbitacora = alDatos.Count + 1 + "";
            
           string sQuery = "insert into bitacora_hospital (id_bitacora, id_usuario, hostname, fecha, hora, ip, descripcion) values ('"+sIDbitacora+"', '"+scodusr+"', '"+sHostname+"', '"+sFecha+"', '"+sHora+"', '"+sIp+"', '"+sDescripcion+"')" ;
           ODBCconnector.csFunciones.vInsertar(sQuery);
        }

    }
}
