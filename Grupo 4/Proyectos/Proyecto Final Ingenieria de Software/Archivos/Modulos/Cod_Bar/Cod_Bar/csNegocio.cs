using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cod_Bar
{
    class csNegocio
    {
    /*    cs_Datos cbo = new cs_Datos();
        cs_Datos cbo2 = new cs_Datos();
        public DataTable obtDatosProductosPR()
        {
            ArrayList cboProductos = new ArrayList();

            cboProductos = cbo.obtDatosProductosPR();

            DataTable dt = new DataTable("Productos");
            DataColumn col1, col2, col3;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_pro";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "cod_formu";

            col3 = new DataColumn();
            col3.DataType = System.Type.GetType("System.String");
            col3.ColumnName = "cantidad_prod";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);

            foreach (ArrayList item in cboProductos)
            {
                fil = dt.NewRow();
                fil["cod_pro"] = item[0].ToString();
                fil["cod_formu"] = item[1].ToString();
                fil["cantidad_prod"] = item[2].ToString();
                dt.Rows.Add(fil);
            }
            return dt;
        }
        
        public DataTable obtDatosFormula()
        {
            ArrayList cboFormu = new ArrayList();

            cboFormu = cbo2.obtDatosProductosPR();

            DataTable dt = new DataTable("Formula");
            DataColumn col1, col2;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_formu";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "descrip_formu";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);

            foreach (ArrayList item in cboFormu)
            {
                fil = dt.NewRow();
                fil["cod_pro"] = item[0].ToString();
                fil["cod_formu"] = item[1].ToString();
                dt.Rows.Add(fil);
            }
            return dt;
        }
     * /*/
    }
}
