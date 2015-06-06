using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ODBCconnector
{
    class csConexion
    {
        private static string gsConexion = "DSN=SCF";
        private static OdbcConnection ocConexion;
        csErrores Errores = new csErrores();
        
        public OdbcConnection Conexion
        {
            get { return ocConexion; }
            set { ocConexion = value; }
        }

        public csConexion()
        {
            ocConexion = new OdbcConnection(gsConexion);
        }

        public bool bAbrirConexion()
        {
            try
            {
                ocConexion = new OdbcConnection(gsConexion);
                ocConexion.Open();
                return true;
            }
            catch (OdbcException ex)
            {
                Errores.vControlErrores(ex.Errors);
                return false;
            }
        }

        public void vCerrarConexion()
        {
            try
            {
                ocConexion.Close();
            }
            catch (OdbcException ex)
            {
                Errores.vControlErrores(ex.Errors);
            }
        }
    }
}
