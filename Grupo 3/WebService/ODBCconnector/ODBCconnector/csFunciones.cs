using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ODBCconnector
{
    public class csFunciones
    {
        static csConexion Conn = new csConexion();
        static csErrores Errores = new csErrores();
        
        public static bool bEjecutarQuery(string sQuery, string sAccion, bool bTablaMaster, string sNombreTabla)
        {
            bool bRespuesta = false;
            if (Conn.bAbrirConexion())
            {
                try
                {
                    OdbcCommand ocComando = new OdbcCommand(sQuery, Conn.Conexion);
                    ocComando.ExecuteNonQuery();
                    Conn.vCerrarConexion();
                    bRespuesta = true;
                }
                catch (OdbcException ex)
                {
                    Errores.vControlErrores(ex.Errors);
                }
            }
            if (bTablaMaster)
            {
                vConsolidarBD(sAccion, bRespuesta, sNombreTabla);
            }
            return bRespuesta;
        }

        public static ArrayList alConsultarQuery(string sQuery)
        {
            ArrayList alDatos = new ArrayList();
            if (Conn.bAbrirConexion())
            {
                try
                {
                    OdbcCommand ocComando = new OdbcCommand(sQuery, Conn.Conexion);
                    OdbcDataReader odReader = ocComando.ExecuteReader();
                    while (odReader.Read())
                    {
                        ArrayList alFila = new ArrayList();
                        for (int iCont = 0; iCont < odReader.FieldCount; iCont++)
                        {
                            alFila.Add(odReader.GetString(iCont));
                        }
                        alDatos.Add(alFila);
                    }
                    Conn.vCerrarConexion();
                    return alDatos;
                }
                catch (OdbcException ex)
                {
                    Errores.vControlErrores(ex.Errors);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static void vConsolidarBD(string sAccion, bool bAccion, string sNombreTabla)
        {
            if(bAccion) 
            {
                MessageBox.Show("Registro " + sAccion + " correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                csBitacora.vRegistarEnBitacora("Registro " + sAccion + " en tabla " + sNombreTabla);
            }
            else
            {
                MessageBox.Show("Registro no " + sAccion, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                csBitacora.vRegistarEnBitacora("Registro no " + sAccion + " en tabla " + sNombreTabla);
            }
        }
    }
}
