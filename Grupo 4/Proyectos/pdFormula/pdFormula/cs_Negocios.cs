using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdFormula
{
    class cs_Negocios
    {
        cs_Datos dgv = new cs_Datos();
        #region Datatable para obtener materia prima
        public DataTable obtemp()
        {
            try
            {
                ArrayList obtEmpleado = new ArrayList();

                obtEmpleado = dgv.obtDatosEmpleados();

                DataTable dt = new DataTable("materia");
                DataColumn col1, col2, col3, col4;
                DataRow fil;

                col1 = new DataColumn();
                col1.DataType = System.Type.GetType("System.String");
                col1.ColumnName = "cod_materiaPrima";

                col2 = new DataColumn();
                col2.DataType = System.Type.GetType("System.String");
                col2.ColumnName = "Materia_Prima";

                col3 = new DataColumn();
                col3.DataType = System.Type.GetType("System.String");
                col3.ColumnName = "Precio";

                col4 = new DataColumn();
                col4.DataType = System.Type.GetType("System.String");
                col4.ColumnName = "Cantidad";



                dt.Columns.Add(col1);
                dt.Columns.Add(col2);
                dt.Columns.Add(col3);
                dt.Columns.Add(col4);



                foreach (ArrayList item in obtEmpleado)
                {
                    fil = dt.NewRow();
                    fil["cod_materiaPrima"] = item[0].ToString();
                    fil["Materia_Prima"] = item[1].ToString();
                    fil["Precio"] = item[2].ToString();
                    fil["Cantidad"] = item[3].ToString();
                    dt.Rows.Add(fil);

                }

                return dt;
            }catch(Exception ex)
            {
                throw new Exception("Se genero el siguiente error: " + ex.Message.ToString().Replace("'", ""));
            }
        }
        #endregion
    }
}
