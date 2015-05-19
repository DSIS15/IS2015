using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Seguridad_Producción.Negocio
{
    public class csNegocio
    {
        Datos.csDatos cbo = new Datos.csDatos();
        public DataTable obtDatosEmpresa()
        {
            ArrayList cboEmpresaList = new ArrayList();

            cboEmpresaList = cbo.obtDatosEmpresa();

            DataTable dt = new DataTable("Empresa");
            DataColumn col1, col2;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_empsa";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "nom_empsa";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);

            foreach (ArrayList item in cboEmpresaList)
            {
                fil = dt.NewRow();
                fil["cod_empsa"] = item[0].ToString();
                fil["nom_empsa"] = item[1].ToString();

                dt.Rows.Add(fil);

            }

            return dt;
        }


        public DataTable obtDatosMoneda()
        {
            ArrayList cboEmpresaList = new ArrayList();

            cboEmpresaList = cbo.obtDatosMoneda();

            DataTable dt = new DataTable("Moneda");
            DataColumn col1, col2;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_mda";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "nom_mda";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);

            foreach (ArrayList item in cboEmpresaList)
            {
                fil = dt.NewRow();
                fil["cod_mda"] = item[0].ToString();
                fil["nom_mda"] = item[1].ToString();

                dt.Rows.Add(fil);

            }

            return dt;
        }
    }
}
