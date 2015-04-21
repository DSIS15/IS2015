using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_bitacora.Presentacion
{
    public static class cs_PInsercionBitacora
    {
        private static string sCodiUsuario;
        
        public static string SCodiUsuario
        {
            get { return sCodiUsuario; }
            set { sCodiUsuario = value; }
        } 
        public static void vinsertar (string sDescripcion)
        {
            Negocio.cs_Ninsertarbitacora cs_insertarbitacora = new Negocio.cs_Ninsertarbitacora();
            cs_insertarbitacora.vInsercion(sCodiUsuario, sDescripcion);
        }
    }
}
