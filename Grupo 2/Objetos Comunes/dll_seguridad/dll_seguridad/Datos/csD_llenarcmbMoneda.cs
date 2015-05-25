using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_seguridad.Datos
{
    class csD_llenarcmbMoneda
    {
        ArrayList alDatos = new ArrayList();
        public ArrayList alLlenarcmbMoneda()
        {
            alDatos = ODBCconnector.csFunciones.alConsultar("SELECT descripcion FROM moneda");
            return alDatos;
        }
    }
}
