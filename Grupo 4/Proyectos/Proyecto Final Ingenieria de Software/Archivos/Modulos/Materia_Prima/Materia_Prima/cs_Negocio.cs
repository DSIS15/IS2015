using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Materia_Prima
{
    class cs_Negocio
    {
        cs_Datos cbo = new cs_Datos();
        public DataTable obtenerDatosCombo()
        {
            ArrayList cbo2 = cbo.obtenerDatosCombo();
            DataTable dt = new DataTable("proveedor");
            DataColumn colunm, dcol;
            DataRow row;

            dcol = new DataColumn();
            dcol.DataType = System.Type.GetType("System.String");
            dcol.ColumnName = "cod_prov";

            colunm = new DataColumn();
            colunm.DataType = System.Type.GetType("System.String");
            colunm.ColumnName = "nom_prov";

            dt.Columns.Add(dcol);
            dt.Columns.Add(colunm);

            foreach (ArrayList item in cbo2)
            {
                row = dt.NewRow();
                row["cod_prov"] = item[0].ToString();
                row["nom_prov"] = item[1].ToString();
                dt.Rows.Add(row);
            }
            return dt;
        }

        
        cs_Datos cbo3 = new cs_Datos();
        public DataTable obtenerDatosCombo2()
        {
            ArrayList cbo4 = cbo.obtenerDatosCombo2();
            DataTable dt = new DataTable("Materia_Prima");
            DataColumn colunm, dcol;
            DataRow row;

            dcol = new DataColumn();
            dcol.DataType = System.Type.GetType("System.String");
            dcol.ColumnName = "cod_mp";

            colunm = new DataColumn();
            colunm.DataType = System.Type.GetType("System.String");
            colunm.ColumnName = "nom_mp";

            dt.Columns.Add(dcol);
            dt.Columns.Add(colunm);

            foreach (ArrayList item in cbo4)
            {
                row = dt.NewRow();
                row["cod_mp"] = item[0].ToString();
                row["nom_mp"] = item[1].ToString();
                dt.Rows.Add(row);
            }
            return dt;
        }






        //datatable para busqueda de Materia Prima
        public DataTable obtDatosMateriaPrima()
        {
            ArrayList cboMateriaPrimaList = new ArrayList();

            cboMateriaPrimaList = cbo.obtDatosMateriaPrima();

            DataTable dt = new DataTable("materiaprima");
            DataColumn col1, col2, col3, col4, col5;
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
            col4.ColumnName = "canitdad_mp";

            col5 = new DataColumn();
            col5.DataType = System.Type.GetType("System.String");
            col5.ColumnName = "precio_mp";


            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);


            foreach (ArrayList item in cboMateriaPrimaList)
            {
                fil = dt.NewRow();
                fil["cod_mp"] = item[0].ToString();
                fil["nom_mp"] = item[1].ToString();
                fil["unimedida_mp"] = item[2].ToString();
                fil["canitdad_mp"] = item[3].ToString();
                fil["precio_mp"] = item[4].ToString();
                dt.Rows.Add(fil);

            }

            return dt;
        }


        //datatable para Pedido
        public DataTable obtDatosPedido()
        {
            ArrayList obtpedido = new ArrayList();

            obtpedido = cbo.obtDatosPedido();

            DataTable dt = new DataTable("pedido");
            DataColumn col1, col2, col3, col4, col5, col6;
            DataRow fil;

            col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "cod_ped";

            col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.String");
            col2.ColumnName = "cod_prov";

            col3 = new DataColumn();
            col3.DataType = System.Type.GetType("System.String");
            col3.ColumnName = "cod_mp";

            col4 = new DataColumn();
            col4.DataType = System.Type.GetType("System.String");
            col4.ColumnName = "unidad_ped";

            col5 = new DataColumn();
            col5.DataType = System.Type.GetType("System.String");
            col5.ColumnName = "cantidad_ped";

            col6 = new DataColumn();
            col6.DataType = System.Type.GetType("System.String");
            col6.ColumnName = "fecha_ped";

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);


            foreach (ArrayList item in obtpedido)
            {
                fil = dt.NewRow();
                fil["cod_ped"] = item[0].ToString();
                fil["cod_prov"] = item[1].ToString();
                fil["cod_mp"] = item[2].ToString();
                fil["unidad_ped"] = item[3].ToString();
                fil["cantidad_ped"] = item[4].ToString();
                fil["fecha_ped"] = item[5].ToString();
                dt.Rows.Add(fil);

            }

            return dt;
        }

    }

}

