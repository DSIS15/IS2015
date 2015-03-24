using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace dll_bitacora.Datos
{
    class csDCamposyDatos
    {
        public ArrayList alDcampos(String sTabla)
        {
                return ODBCconnector.csFunciones.alConsultar("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where table_name = '" +sTabla+"'");
           
        }

        public ArrayList alDDatos(String sQuery)
        {

            return ODBCconnector.csFunciones.alConsultar(sQuery);
        }
    }
}
