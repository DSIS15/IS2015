using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;

namespace Seguridad_Producción
{
    public class csValidaciones
    {
        /* Autor: Rodrigo Miranda
         * Fecha: 22/02/2015
         * Comentario: Función Validar_Usuario() se utiliza para validar el usuario y contraseña en el inicio de sesion.
         */
        private static string SConexion = "DSN=PROD;";
        public static int Validar_Usuario(string vUsuario, string vContrasena, string vEmpresa)
        {
            try
            {
                //----------------------------SIN ODBC----------------
                //string SConexion = "datasource=localhost;port=3306; database=bdproduccion; username=root;password=;";
                //MySqlConnection Nconexion = new MySqlConnection(SConexion);
                //MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM usuarios WHERE user='" + vUsuario + "' AND pass='" + vContrasena + "' ;", Nconexion);
                //MySqlDataReader myReader;
                //Nconexion.Open();
                //myReader = SelectCommand.ExecuteReader();
               // while (myReader.Read())
                //-----------------------------------------------------------------------------
                OdbcConnection Nconexion = new System.Data.Odbc.OdbcConnection(SConexion);
                Nconexion.Open();
               // string sValidar = "SELECT * FROM tabm_usuario WHERE user_usu='" + vUsuario + "' AND pass_usu='" + vContrasena + "';";
                string sValidar2 = "select user_usu, pass_usu, cod_empsa from tabm_usuario where user_usu = '"+ vUsuario +"' and pass_usu = '"+ vContrasena +"' and cod_empsa = '"+ vEmpresa +"'; ";
                OdbcCommand sVal = new OdbcCommand(sValidar2, Nconexion);
                OdbcDataReader sReader = sVal.ExecuteReader();
                int count = 0;
                while (sReader.Read())
                { 
                    count = count + 1;
                }
                Nconexion.Close();
                if (count == 1)
                {
                    MessageBox.Show("Bienvenido " + vUsuario, "Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 1;
                }
                else
                {
                    return 0;
                }
                           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

    }
        
}
