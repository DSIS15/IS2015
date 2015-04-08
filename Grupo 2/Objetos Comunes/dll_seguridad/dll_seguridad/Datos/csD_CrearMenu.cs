/*Fecha y lugar de Modificacion: Guatemala, Guatemala 08-03-2015
 * Autor:Jaime Iván Muñoz Enriquez
 * Descripcion: Esta clase hace llamado a la base de datos para obtener 
 *              los datos necesarios en un arraylist
 * conectado en: DLL ODBConector (necesario para el funcionamiento)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace dll_seguridad.Datos
{
    class csD_CrearMenu
    {
        //array list para los datos
        private ArrayList alDatos;

        //metodo que consultara el nombre de los modulos y nombre de dll
        public ArrayList alDconsultaForm(String sUsuario)
        {
            alDatos = new ArrayList(); 
            alDatos = ODBCconnector.csFunciones.alConsultar("Select m.Nombre_modulo " +
                                                 "from Usuario u " +
                                                 "Inner Join Perfil p " +
                                                 "on p.Codigo_perfil = u.Codigo_perfil " +
                                                 "Inner Join Detalle_Modulo dm " +
                                                 "on dm.Codigo_perfil = p.Codigo_perfil " +
                                                 "Inner Join Modulo m " +
                                                 "on m.ID_modulo = dm.ID_modulo " +
                                                 "where u.Alias_Usuario = '" + sUsuario + "'"+
                                                 "and u.estado= 1 and p.estado =1 and m.estado = 1");
            
            return alDatos;
        }

        public ArrayList alDsubmenu(String sModulo)
        {
            alDatos = new ArrayList();
            alDatos = ODBCconnector.csFunciones.alConsultar("Select M.Nombre_modulo, SM.Nombre_submodulo, SM.Nombre_form, M.Nombre_DLL " +
                                                 "from modulo M " +
                                                 "Inner Join sub_modulo SM " +
                                                 "on SM.ID_modulo = M.ID_modulo " +
                                                 "where M.Nombre_modulo='" + sModulo + "'"+
                                                 "and M.estado=1 and SM.estado=1 ");
            return alDatos;
        }
    }
}
