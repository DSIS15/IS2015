using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Produccion_EnterpriseSolution
{
    public class csDatos
    {

        ArrayList cbollenado = new ArrayList();

        public ArrayList obtDatosEmpresa()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("select cod_empsa, nomcomercial_empsa from tabm_empresa");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }

        public ArrayList obtDatosMoneda()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("SELECT cod_mda, moneda_mda from tabm_moneda");
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }








    }

}
