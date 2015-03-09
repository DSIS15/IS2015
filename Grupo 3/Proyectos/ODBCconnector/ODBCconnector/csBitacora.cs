using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Net;

namespace ODBCconnector
{
    public class csBitacora
    {
        static csConexion Conn = new csConexion();
        static csErrores Errores = new csErrores();

        private static string sIP()
        {
            IPHostEntry Maquina;
            string sIPLocal = "";
            Maquina = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in Maquina.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    sIPLocal = ip.ToString();
                }
            }
            return sIPLocal;
        }

        private static string sMaquina(string localIP)
        {
            IPHostEntry ipHost = Dns.GetHostEntry(localIP);
            return ipHost.HostName;
        }

        public static void vRegistarEnBitacora(string sAccion)
        {
            if (Conn.bAbrirConexion())
            {
                try
                {
                    OdbcCommand ocComando = new OdbcCommand("insert into tabm_bitacora values (NULL,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Capas.csParametros.AlUsuario[2].ToString() + "','" + sMaquina(sIP()) + "','" + sIP() + "','" + Capas.csParametros.AlEmpresa[1].ToString() + "','" + sAccion + "')", Conn.Conexion);
                    ocComando.ExecuteNonQuery();
                    Conn.vCerrarConexion();
                }
                catch (OdbcException ex)
                {
                    Errores.vControlErrores(ex.Errors);
                }
            }
        }
    }
}
