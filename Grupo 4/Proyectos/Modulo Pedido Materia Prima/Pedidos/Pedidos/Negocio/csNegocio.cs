
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pedidos.Negocio
{
    class csNegocio
    {
        Datos.csDatos cbo = new Datos.csDatos();
        public DataTable obtDatosProductosMP()
        {
            ArrayList cboProductosMPList = new ArrayList();

            cboProductosMPList = cbo.obtDatosProductosMP();

            DataTable dt = new DataTable("Productos");
            DataColumn col1, col2,col3,col4;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_mp";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "nom_mp";

            col3 = new DataColumn();
            col3.DataType = System.Type.GetType("System.String");
            col3.ColumnName = "unimedida_mp";

            col4 = new DataColumn();
            col4.DataType = System.Type.GetType("System.String");
            col4.ColumnName = "precio_mp";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);

            foreach (ArrayList item in cboProductosMPList)
            {
                fil = dt.NewRow();
                fil["cod_mp"] = item[0].ToString();
                fil["nom_mp"] = item[1].ToString();
                fil["unimedida_mp"] = item[2].ToString();
                fil["precio_mp"] = item[3].ToString();

                dt.Rows.Add(fil);
            }
            return dt;
        }
      
    }
}
