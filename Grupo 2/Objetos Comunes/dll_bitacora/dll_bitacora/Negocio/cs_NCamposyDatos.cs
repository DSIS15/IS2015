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

        public ComboBox cbllenarcombo(ArrayList alCampos)
        {
            sCadena = (String[,])alCampos[0];
            ComboBox cbDatos = new ComboBox();
            
            for (int icontador = 0; icontador < sCadena.GetLength(0); icontador++)
            {
                if (String.Compare(sCadena[icontador, 2], "true") == 0)
                {
                  cbDatos.Items.Add(sCadena[icontador,1]);                    
                }
            }            
            return cbDatos;
        
        }
        public DataTable dtNCamposyDatos(ArrayList alCampos, String sTabla)
        {
            //ArrayList alDatosEntrada =csd_obtenercampor.alDcampos();

            dtTabla = new DataTable();
            sCadena = (string[,])alCampos[0];
            String sQuery = "Select ";

            for (int icontador = 0; icontador < sCadena.GetLength(0); icontador++ )
            {
               // MessageBox.Show(icontador.ToString());
               // MessageBox.Show(sCadena[icontador,0] + "--"+ sCadena[icontador,2] );
                if (string.Compare(sCadena[icontador, 2], "true") == 0)
                {
                    dtTabla.Columns.Add(new DataColumn(sCadena[icontador, 1]));
                    if (icontador == (sCadena.GetLength(0)-1))
                        sQuery += sCadena[icontador, 0] ;
                    else
                        sQuery += sCadena[icontador, 0] + ", ";
                }
            }            
            sQuery += " from " + sTabla;           
            ArrayList alRegistro = csd_obtenercampor.alDDatos(sQuery);
            for (int icontador = 0; icontador < alRegistro.Count; icontador++)
            {
                ArrayList alDatos = (ArrayList)alRegistro[icontador];
                drfila = dtTabla.NewRow();
                for (int icontador2 = 0; icontador2 < alDatos.Count; icontador2++)
                {
                    drfila[icontador2] = alDatos[icontador2].ToString();  
                }
                dtTabla.Rows.Add(drfila);
            }
                return dtTabla;
        }

        public bool bCompararCampos(ArrayList alCampos, String STabla)
        {
            ArrayList alDatos = csd_obtenercampor.alDcampos(STabla);
            String[,] sCadena = (String[,])alCampos[0];

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
