using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Capas
{
    public class csParametros
    {
        private static ArrayList alEmpresa = new ArrayList();
        private static ArrayList alMoneda = new ArrayList();
        private static ArrayList alPrivilegios = new ArrayList();
        private static ArrayList alUsuario = new ArrayList();

        public static ArrayList AlEmpresa
        {
            get { return csParametros.alEmpresa; }
            set { csParametros.alEmpresa = value; }
        }
        
        public static ArrayList AlMoneda
        {
            get { return csParametros.alMoneda; }
            set { csParametros.alMoneda = value; }
        }
                
        public static ArrayList AlUsuario
        {
            get { return csParametros.alUsuario; }
            set { csParametros.alUsuario = value; }
        }

        public static ArrayList AlPrivilegios
        {
            get { return csParametros.alPrivilegios; }
            set { csParametros.alPrivilegios = value; }
        }

        public static void vObtenerPrivelegios()
        {
            AlPrivilegios = null;
            AlPrivilegios = ODBCconnector.csFunciones.alConsultarQuery("select b.tabla_tbl, a.insert_dpfl, a.update_dpfl, a.delete_dpfl, a.print_dpfl, a.select_dpfl from tabt_dperfil a, tabm_tabla b, tabm_perfil c where a.cod_tbl=b.cod_tbl and a.cod_pfl=c.cod_pfl and a.cod_pfl='" + AlUsuario[1].ToString() + "' and c.estado_pfl=1 and a.estado_dpfl=1");
        }
    }
}