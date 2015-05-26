using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace dll_bitacora.Negocio
{
    class cs_NCamposyDatos
    {
        private DataTable dtTabla;
        private DataRow drfila;
        private String[,] sCadena;
        private Datos.csDCamposyDatos csd_obtenercampor = new Datos.csDCamposyDatos();

        //esta funcion maneja el llenado del combobox del cuDaataGridConBusqueda
        public ComboBox cbllenarcombo(ArrayList alCampos)
        {
            ////asignación del objeto que trae el arraylist alCampos
            sCadena = (String[,])alCampos[0];   /*Composición del objeto string
                                                 * { {"nombre campo","alias","true/false"}}
                                                 *                          dependiendo si se quiere mostrar
                                                 */
            ComboBox cbDatos = new ComboBox();
            //este ciclo recorre y agrega los datos obtenidos de alCampos almacenados ahora en sCadena
            for (int icontador = 0; icontador < sCadena.GetLength(0); icontador++)
            {
                if (String.Compare(sCadena[icontador, 2], "true") == 0)
                {
                 //se agrega el nuevo elemento
                  cbDatos.Items.Add(sCadena[icontador,1]);                    
                }
            }            
            return cbDatos;        
        }

        public ArrayList alObtenerCampos(ArrayList alCampos)
        {
            ArrayList alObtenerCampos = new ArrayList();
            sCadena= (String[,])alCampos[0];
            for (int icontador = 0; icontador < sCadena.GetLength(0); icontador++)
            {
                if (String.Compare(sCadena[icontador, 2], "true") == 0) { alObtenerCampos.Add(sCadena[icontador,1]); }
            }
                return alObtenerCampos;
        }


        public int iObtenerCount(ArrayList alCampos)
        { 
        String[,] sCadena2 = (String[,])alCampos[0];        
        return sCadena2.GetLength(0);
        }

        //esta función maneja la construccion del datagried de la capa presentación
        public DataTable dtNCamposyDatos(ArrayList alCampos, String sTabla)
        {
            //variable necesaria para crear el datagried
            dtTabla = new DataTable();
            //asignación del objeto que trae el arraylist alCampos
            sCadena = (string[,])alCampos[0];       /*Composición del objeto string
                                                     * { {"nombre campo","alias","true/false"}}
                                                     *                          dependiendo si se quiere mostrar
                                                      */
            //construcción del query
            String sQuery = "Select ";
            //creacion de arraylis para obtener los campos que se quieren mostrar
            ArrayList alCadena = new ArrayList();

            //agrega las columnas que vienen de la variable alCampos
            for (int icontador = 0; icontador < sCadena.GetLength(0); icontador++ )
            {                        
                if (string.Compare(sCadena[icontador, 2], "true") == 0)
                {
                    dtTabla.Columns.Add(new DataColumn(sCadena[icontador, 1]));
                    alCadena.Add(sCadena[icontador, 0]);                    
                }
            }

            //este for maneja la construccion del query dinamico
            //agrega los campos que se verificaron como true en el for anterior
            for (int icontador = 0; icontador < alCadena.Count; icontador++ )
            {
                if (icontador < alCadena.Count - 1)
                {
                   
                    sQuery += alCadena[icontador].ToString() + ", ";                    
                }
                else
                    {
                        sQuery += alCadena[icontador];
                    }
            }
            //se concatena con la tabla
            sQuery += " from " + sTabla;            

            //se almacenan los registros de la consulta generada
            ArrayList alRegistro = csd_obtenercampor.alDDatos(sQuery);

            /*ciclos anidados para recorrer el arraylist obtenido de
             * la consulta realizada */
            for (int icontador = 0; icontador < alRegistro.Count; icontador++)
            {
                ArrayList alDatos = (ArrayList)alRegistro[icontador];
                drfila = dtTabla.NewRow();
                
                for (int icontador2 = 0; icontador2 < alDatos.Count; icontador2++)
                {  //se agrega los datos de alDatos (variable tipo arraylis 'Local')
                    drfila[icontador2] = alDatos[icontador2].ToString();  
                }                
                dtTabla.Rows.Add(drfila);
            }
                return dtTabla;
        }

        //este metodo verifica si los campos ingresados son iguales a los de la tabla
        public bool bCompararCampos(ArrayList alCampos, String STabla)
        {

            ArrayList alDatos = csd_obtenercampor.alDcampos(STabla);
            sCadena = (String[,])alCampos[0];

            if (alDatos.Count == sCadena.GetLength(0))
            {
                for (int icontador = 0; icontador < alDatos.Count; icontador++ )
                {                    
                    ArrayList alContenido = (ArrayList)alDatos[icontador];
                    if (string.Compare(sCadena[icontador,0],alContenido[0].ToString())!=0)
                        {
                            return false;
                        }                   
                }

            }
            else
                {
                    return false;            
                }    
            return true;
        }
    }
}
