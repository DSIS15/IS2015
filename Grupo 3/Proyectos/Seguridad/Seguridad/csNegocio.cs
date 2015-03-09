using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
    class csNegocio
    {
        public bool bValidarCredenciales(string sUsuario, string sContrasena)
        {
            bool bRespuesta = false;
            if ((string.Compare(sUsuario, string.Empty) != 0) && (string.Compare(sContrasena, string.Empty) != 0))
            {
                ArrayList alDatosUsuario = new ArrayList();
                alDatosUsuario = ODBCconnector.csFunciones.alConsultarQuery("select a.cod_usr, a.cod_pfl, a.usuario_usr, b.perfil_pfl from tabm_usuario a, tabm_perfil b where a.cod_pfl=b.cod_pfl and a.usuario_usr='" + sUsuario + "' and a.password_usr='" + sContrasena + "' and a.estado_usr=1 and b.estado_pfl=1");
                if (alDatosUsuario != null)
                {
                    if (alDatosUsuario.Count != 0)
                    {
                        Capas.csParametros.AlUsuario = (ArrayList)alDatosUsuario[0];
                        bRespuesta = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese el usuario y/o contraseña.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return bRespuesta;
        }
    }
}
