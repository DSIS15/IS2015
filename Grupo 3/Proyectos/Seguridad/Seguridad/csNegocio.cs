using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Seguridad
{
    class csNegocio
    {
        private string sClave = "%#SCF2015#%";
        private byte[] btResultado;
        private byte[] btArreglo;
        private byte[] btLlave;

        public string sCifrarCadena(string cadena)
        {
            btArreglo = UTF8Encoding.UTF8.GetBytes(cadena);
            MD5CryptoServiceProvider mcsMD5 = new MD5CryptoServiceProvider();
            btLlave = mcsMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sClave));
            mcsMD5.Clear();
            TripleDESCryptoServiceProvider tdcDES = new TripleDESCryptoServiceProvider();
            tdcDES.Key = btLlave;
            tdcDES.Mode = CipherMode.ECB;
            tdcDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform ictConvertir = tdcDES.CreateEncryptor();
            btResultado = ictConvertir.TransformFinalBlock(btArreglo, 0, btArreglo.Length);
            tdcDES.Clear();
            return Convert.ToBase64String(btResultado, 0, btResultado.Length);
        }

        public bool bValidarCredenciales(string sUsuario, string sContrasena)
        {
            bool bRespuesta = false;
            if ((string.Compare(sUsuario, string.Empty) != 0) && (string.Compare(sContrasena, string.Empty) != 0))
            {
                ArrayList alDatosUsuario = new ArrayList();
                alDatosUsuario = ODBCconnector.csFunciones.alConsultarQuery("select a.cod_usr, a.cod_pfl, a.usuario_usr, b.perfil_pfl from tabm_usuario a, tabm_perfil b where a.cod_pfl=b.cod_pfl and a.usuario_usr='" + sUsuario + "' and a.password_usr='" + sCifrarCadena(sContrasena) + "' and a.estado_usr=1 and b.estado_pfl=1");
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
