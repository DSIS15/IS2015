using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdFormula
{
    class cs_Datos
    {
        #region SELECT DE MATERIA PRIMA
        ArrayList dgv_materiaprima = new ArrayList();
        public ArrayList obtDatosEmpleados()
        {
            try
            {
                dgv_materiaprima = ODBCconnector.csFunciones.alConsultar("SELECT cod_mp,nom_mp,precio_mp,canitdad_mp FROM tabm_materiaprima");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dgv_materiaprima;

        }
        #endregion

        
    }
}
