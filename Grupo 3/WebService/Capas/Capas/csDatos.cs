using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas
{
    class csDatos
    {
        private string sNombreTabla = string.Empty;

        public string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        public bool bInsertarRegistro(ArrayList alDatos)
        {
            string sQuery = "insert into " + sNombreTabla + " values (";
            bool bComa = false;
            foreach (string sDato in alDatos)
            {
                if (!bComa)
                {
                    bComa = true;
                }
                else
                {
                    sQuery += ",";
                }
                sQuery += "'" + sDato + "'";
            }
            sQuery += ")";
            return ODBCconnector.csFunciones.bEjecutarQuery(sQuery, "insertado", false, SNombreTabla);
        }

        public ArrayList alConsultarRegistro(string sQuery)
        {
            return ODBCconnector.csFunciones.alConsultarQuery(sQuery);
        }

        public bool bModificarRegistro(ArrayList alCampos, ArrayList alDatos, int iCantCodigos)
        {
            string sQuery = "update " + sNombreTabla + " set ";
            bool bComa = false;
            for (int iPosicion = iCantCodigos; iPosicion < alDatos.Count; iPosicion++)
            {
                if (!bComa)
                {
                    bComa = true;
                }
                else
                {
                    sQuery += ",";
                }
                sQuery += alCampos[iPosicion].ToString() + "='" + alDatos[iPosicion].ToString() + "'";
            }
            sQuery += " where ";
            bool bAnd = false;
            for (int iPosicion = 0; iPosicion < iCantCodigos; iPosicion++)
            {
                if (!bAnd)
                {
                    bAnd = true;
                }
                else
                {
                    sQuery += " and ";
                }
                sQuery += alCampos[iPosicion].ToString() + "='" + alDatos[iPosicion].ToString() + "'";
            }
            return ODBCconnector.csFunciones.bEjecutarQuery(sQuery, "modificado", false, SNombreTabla);
        }

        public bool vEliminarRegistro(ArrayList alCampos, ArrayList alDatos, int iCantCodigos)
        {
            string sQuery = "update " + sNombreTabla + " set " + alCampos[alCampos.Count - 1].ToString() + "=0 where ";
            bool bAnd = false;
            for (int iPosicion = 0; iPosicion < iCantCodigos; iPosicion++)
            {
                if (!bAnd)
                {
                    bAnd = true;
                }
                else
                {
                    sQuery += " and ";
                }
                sQuery += alCampos[iPosicion].ToString() + "='" + alDatos[iPosicion].ToString() + "'";
            }
            return ODBCconnector.csFunciones.bEjecutarQuery(sQuery, "eliminado", false, SNombreTabla);
        }
    }
}
