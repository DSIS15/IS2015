using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Cod_Bar
{
    public class cs_Datos
    {
        ArrayList cbollenado = new ArrayList();
        ArrayList cbollenado2 = new ArrayList();

        public ArrayList obtDatosProductosPR()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("SELECT cod_pro, cod_formu, cantidad_product FROM tabm_produccion ORDER BY nom_mp ASC");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }
    }
}
