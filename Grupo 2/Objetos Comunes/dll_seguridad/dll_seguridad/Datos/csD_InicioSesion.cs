/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 08-03-2015
 * Autor: Jaime Iván Muñoz Enriquez *
 * Descripcion: Esta clase tiene como fin hacer la consulta de los usuarios
 * conectado en: DLL ODBConector (necesario para el funcionamiento de las consultas)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using ODBCconnector;

namespace dll_seguridad.Datos
{
    internal class csD_InicioSesion
    {

        private ArrayList alResultado = new ArrayList(); 
        private String sQuery= String.Empty;

        public bool bInicioSesion(String sUsuario, String sContraseña)
        {
            sQuery = "Select Alias_usuario, Pasword_usuario from usuario where  Alias_usuario= '" + sUsuario + "' AND Pasword_usuario= '" + sContraseña + "'";
            alResultado = csFunciones.alConsultar(sQuery);
            if (alResultado.Count != 0)
            {
                sQuery = "Select Alias_usuario, Pasword_usuario from usuario where  Alias_usuario= '" + sUsuario + "' AND Pasword_usuario= '" + sContraseña + "' AND estado=1";
                ArrayList alResp = csFunciones.alConsultar(sQuery);
                if (alResp.Count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                {
                    return false;
                }
        }
    }
}
