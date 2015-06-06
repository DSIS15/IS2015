using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capas
{
    public class csNegocio
    {
        static csEntidades Entidades = new csEntidades();
        private static string sNombreTabla = string.Empty;
        static csDatos Datos = new csDatos();

        public static string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        public static void vValidarTexto(KeyPressEventArgs e, string sCadena)
        {
            sCadena = sCadena + (char)8;
            if (!sCadena.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public static bool bValidarTextBoxes(ArrayList alDatosEntrada)
        {
            for (int iPosicion = 1; iPosicion < alDatosEntrada.Count; iPosicion++)
            {
                TextBox txtTextBoxes = (TextBox)alDatosEntrada[iPosicion];
                if (string.Compare(txtTextBoxes.Text, string.Empty) == 0)
                {
                    MessageBox.Show("Ingrese todos los campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTextBoxes.Focus();
                    return false;
                }
            }
            return true;
        }

        public static void vInsertarRegistros(ArrayList alCodigos, DataTable dtDatos)
        {
            ArrayList alFila = new ArrayList();
            bool bRespuesta = true;
            for (int iContadorFila = 0; iContadorFila < dtDatos.Rows.Count; iContadorFila++)
            {
                alFila.Clear();
                foreach (string sCodigo in alCodigos)
                {
                    alFila.Add(sCodigo);
                }
                for (int iContadorColum = 0; iContadorColum < dtDatos.Columns.Count; iContadorColum++)
                {
                    alFila.Add(dtDatos.Rows[iContadorFila][iContadorColum].ToString());
                }
                Datos.SNombreTabla = SNombreTabla;
                if (!Datos.bInsertarRegistro(alFila))
                {
                    bRespuesta = false;
                }
            }
            ODBCconnector.csFunciones.vConsolidarBD("insertado", bRespuesta, SNombreTabla);
        }

        public static DataTable dtConsultarRegistros(string sQuery)
        {
            DataTable dtDatosSalida = new DataTable();
            ArrayList alDatosEntrada = new ArrayList();
            if (sQuery != null)
            {
                alDatosEntrada = Datos.alConsultarRegistro(sQuery);
                if (alDatosEntrada != null)
                {
                    if (alDatosEntrada.Count != 0)
                    {
                        ArrayList alColumnas = (ArrayList)alDatosEntrada[0];
                        for (int iPosicion = 0; iPosicion < alColumnas.Count; iPosicion++)
                        {
                            dtDatosSalida.Columns.Add("Columna" + iPosicion);
                        }
                        if (alDatosEntrada != null)
                        {
                            foreach (ArrayList alFilas in alDatosEntrada)
                            {
                                DataRow drFila = dtDatosSalida.NewRow();
                                for (int iPosicion = 0; iPosicion < alFilas.Count; iPosicion++)
                                {
                                    drFila["Columna" + iPosicion] = alFilas[iPosicion];
                                }
                                dtDatosSalida.Rows.Add(drFila);
                            }
                        }
                    }
                }
            }
            return dtDatosSalida;
        }

        public static void vModificarRegistros(ArrayList alCodigos, DataTable dtDatos)
        {
            ArrayList alFila = new ArrayList();            
            bool bRespuesta = true;
            int iCantCodigos = alCodigos.Count + 1;
            for (int iContadorFila = 0; iContadorFila < dtDatos.Rows.Count; iContadorFila++)
            {
                alFila.Clear();
                foreach (string sCodigo in alCodigos)
                {
                    alFila.Add(sCodigo);
                }
                for (int iContadorColum = 0; iContadorColum < dtDatos.Columns.Count; iContadorColum++)
                {
                    alFila.Add(dtDatos.Rows[iContadorFila][iContadorColum].ToString());
                }
                Entidades.SNombreTabla = SNombreTabla;
                ArrayList alCampos = Entidades.alObtenerCamposTabla();
                Datos.SNombreTabla = SNombreTabla;
                if (!Datos.bModificarRegistro(alCampos, alFila, iCantCodigos))
                {
                    bRespuesta = false;
                }
            }
            ODBCconnector.csFunciones.vConsolidarBD("modificado", bRespuesta, SNombreTabla);
        }

        public static void vEliminarRegistros(ArrayList alCodigos, DataTable dtDatos)
        {
            ArrayList alFila = new ArrayList();            
            bool bRespuesta = true;
            int iCantCodigos = alCodigos.Count + 1;
            for (int iContadorFila = 0; iContadorFila < dtDatos.Rows.Count; iContadorFila++)
            {
                alFila.Clear();
                foreach (string sCodigo in alCodigos)
                {
                    alFila.Add(sCodigo);
                }
                for (int iContadorColum = 0; iContadorColum < dtDatos.Columns.Count; iContadorColum++)
                {
                    alFila.Add(dtDatos.Rows[iContadorFila][iContadorColum].ToString());
                }
                Entidades.SNombreTabla = SNombreTabla;
                ArrayList alCampos = Entidades.alObtenerCamposTabla();
                Datos.SNombreTabla = SNombreTabla;
                if (!Datos.vEliminarRegistro(alCampos, alFila, iCantCodigos))
                {
                    bRespuesta = false;
                }
            }
            ODBCconnector.csFunciones.vConsolidarBD("eliminado", bRespuesta, SNombreTabla);
        }
    }
}
