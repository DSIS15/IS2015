using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIP_Administrativo
{
    class cs_Negocio
    {
        cs_Datos cbo = new cs_Datos();
        public DataTable obtenerDatosCombo()
        {
            ArrayList cbo2 = cbo.obtenerDatosCombo();
            DataTable dt = new DataTable("Empresa");
            DataColumn colunm, dcol;
            DataRow row;

            dcol = new DataColumn();
            dcol.DataType = System.Type.GetType("System.String");
            dcol.ColumnName = "cod_empsa";

            colunm = new DataColumn();
            colunm.DataType = System.Type.GetType("System.String");
            colunm.ColumnName = "nomcomercial_empsa";

            dt.Columns.Add(dcol);
            dt.Columns.Add(colunm);

            foreach (ArrayList item in cbo2)
            {
                row = dt.NewRow();
                row["cod_empsa"] = item[0].ToString();
                row["nomcomercial_empsa"] = item[1].ToString();
                dt.Rows.Add(row);
            }
            return dt;
        }

        //datatable para busqueda de proveedores
        public DataTable obtDatosProveedor()
        {
            ArrayList cboEmpresaList = new ArrayList();

            cboEmpresaList = cbo.obtDatosProveedor();

            DataTable dt = new DataTable("Empresa");
            DataColumn col1, col2, col3, col4 ,col5,col6;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_prov";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "nom_prov";

            col3 = new DataColumn();
            col3.DataType = System.Type.GetType("System.String");
            col3.ColumnName = "nit_prov";

            col4 = new DataColumn();
            col4.DataType = System.Type.GetType("System.String");
            col4.ColumnName = "dire_prov";

            col5 = new DataColumn();
            col5.DataType = System.Type.GetType("System.String");
            col5.ColumnName = "tel_prov";


            col6 = new DataColumn();
            col6.DataType = System.Type.GetType("System.String");
            col6.ColumnName = "estado_prov";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);


            foreach (ArrayList item in cboEmpresaList)
            {
                fil = dt.NewRow();
                fil["cod_prov"] = item[0].ToString();
                fil["nom_prov"] = item[1].ToString();
                fil["nit_prov"] = item[2].ToString();
                fil["dire_prov"] = item[3].ToString();
                fil["tel_prov"] = item[4].ToString();
                fil["estado_prov"] = item[5].ToString();
                dt.Rows.Add(fil);

            }

            return dt;
        }

        //datatable para clientes
        public DataTable obtDatosClientes()
        {
            ArrayList obtcliente = new ArrayList();

            obtcliente = cbo.obtDatosClientes();

            DataTable dt = new DataTable("Busqueda");
            DataColumn col1, col2, col3, col4, col5,col6,col7;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_cte";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "nom1_cte";

            col3 = new DataColumn();
            col3.DataType = System.Type.GetType("System.String");
            col3.ColumnName = "apell1_cte";

            col4 = new DataColumn();
            col4.DataType = System.Type.GetType("System.String");
            col4.ColumnName = "dpi_cte";
          
            col5 = new DataColumn();
            col5.DataType = System.Type.GetType("System.String");
            col5.ColumnName = "nit_cte";


           col6 = new DataColumn();
            col6.DataType = System.Type.GetType("System.String");
            col6.ColumnName = "tel_cte";

            col7 = new DataColumn();
            col7.DataType = System.Type.GetType("System.String");
            col7.ColumnName = "dire_cte";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);
            dt.Columns.Add(col7);


            foreach (ArrayList item in obtcliente)
            {
                fil = dt.NewRow();
                fil["cod_cte"] = item[0].ToString();
                fil["nom1_cte"] = item[1].ToString();
                fil["apell1_cte"] = item[2].ToString();
                fil["dpi_cte"] = item[3].ToString();
                fil["nit_cte"] = item[4].ToString();
                fil["tel_cte"] = item[5].ToString();
                fil["dire_cte"] = item[6].ToString();
                dt.Rows.Add(fil);

            }

            return dt;
        }

        //datatable para empleados

        public DataTable obteemp()
        {
            ArrayList obtEmpleado = new ArrayList();

            obtEmpleado = cbo.obtDatosEmpleados();

            DataTable dt = new DataTable("empleado");
            DataColumn col1, col2, col3, col4, col5, col6, col7;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_emp";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "nomcomercial_empsa";

            col3 = new DataColumn();
            col3.DataType = System.Type.GetType("System.String");
            col3.ColumnName = "nom1_emp";

            col4 = new DataColumn();
            col4.DataType = System.Type.GetType("System.String");
            col4.ColumnName = "apell1_emp";

            col5 = new DataColumn();
            col5.DataType = System.Type.GetType("System.String");
            col5.ColumnName = "dire_emp";


            col6 = new DataColumn();
            col6.DataType = System.Type.GetType("System.String");
            col6.ColumnName = "afiigss_emp";

            col7 = new DataColumn();
            col7.DataType = System.Type.GetType("System.String");
            col7.ColumnName = "nit_emp";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);
            dt.Columns.Add(col7);


            foreach (ArrayList item in obtEmpleado)
            {
                fil = dt.NewRow();
                fil["cod_emp"] = item[0].ToString();
                fil["nomcomercial_empsa"] = item[1].ToString();
                fil["nom1_emp"] = item[2].ToString();
                fil["apell1_emp"] = item[3].ToString();
                fil["dire_emp"] = item[4].ToString();
                fil["afiigss_emp"] = item[5].ToString();
                fil["nit_emp"] = item[6].ToString();
                dt.Rows.Add(fil);

            }

            return dt;
        }

    }
}
