using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos.Datos
{
    class csDatos
    {
        ArrayList cbollenado = new ArrayList();

        public ArrayList obtDatosProductosMP()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("SELECT cod_mp, nom_mp,unimedida_mp,precio_mp FROM tabm_materiaprima ORDER BY nom_mp ASC");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }

        //public ArrayList obtDatosUMedida()
        //{
        //    try
        //    {
        //        cbollenado = ODBCconnector.csFunciones.alConsultar("SELECT cod_mp, unimedida_mp FROM tabm_materiaprima ORDER BY unimedida_mp ASC");
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    return cbollenado;
        //}
    }
}
