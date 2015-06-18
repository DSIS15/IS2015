using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Produccion
{
   /*Roberto Alexander Grave Vicente
    * 0901-11-16185
    * */
    public class csNegocio
    {
        csDatos datosObt = new csDatos();
        ArrayList datosMP = new ArrayList();

        public DataTable obtDatosF()
        {
            datosMP = datosObt.obtDatosF();

            DataTable dtFormula = new DataTable();
            DataColumn c1, c2, c3, c4, c5;
            DataRow fila;

            c1 = new DataColumn();
            c1.DataType = System.Type.GetType("System.String");
            c1.ColumnName = "Codigo Formula";

            c2 = new DataColumn();
            c2.DataType = System.Type.GetType("System.String");
            c2.ColumnName = "Descripción";

            c3 = new DataColumn();
            c3.DataType = System.Type.GetType("System.String");
            c3.ColumnName = "Unidad de Medida";

            c4 = new DataColumn();
            c4.DataType = System.Type.GetType("System.String");
            c4.ColumnName = "Costo Unidad";

            c5 = new DataColumn();
            c5.DataType = System.Type.GetType("System.String");
            c5.ColumnName = "Estado";

            dtFormula.Columns.Add(c1);
            dtFormula.Columns.Add(c2);
            dtFormula.Columns.Add(c3);
            dtFormula.Columns.Add(c4);
            dtFormula.Columns.Add(c5);

            foreach(ArrayList formula in datosMP)
            {

                fila = dtFormula.NewRow();

                fila["Codigo Formula"] = formula[0].ToString();
                fila["Descripción"] = formula[1].ToString();
                fila["Unidad de Medida"] = formula[2].ToString();
                fila["Costo Unidad"] = formula[3].ToString();
                fila["Estado"] = formula[4].ToString();

                dtFormula.Rows.Add(fila);
            }

            return dtFormula;
        }




        public DataTable obtDatosFMP()
        {
            datosMP = datosObt.obtDatosFMP();

            DataTable dtDetFormula = new DataTable();
            DataColumn c1, c2, c3, c4, c5;
            DataRow fila;

            c1 = new DataColumn();
            c1.DataType = System.Type.GetType("System.String");
            c1.ColumnName = "Formula";

            c2 = new DataColumn();
            c2.DataType = System.Type.GetType("System.String");
            c2.ColumnName = "Costo";

            c3 = new DataColumn();
            c3.DataType = System.Type.GetType("System.String");
            c3.ColumnName = "Materia Prima";

            c4 = new DataColumn();
            c4.DataType = System.Type.GetType("System.String");
            c4.ColumnName = "Unidad de Medida";

            c5 = new DataColumn();
            c5.DataType = System.Type.GetType("System.String");
            c5.ColumnName = "Cantidad";

            dtDetFormula.Columns.Add(c1);
            dtDetFormula.Columns.Add(c2);
            dtDetFormula.Columns.Add(c3);
            dtDetFormula.Columns.Add(c4);
            dtDetFormula.Columns.Add(c5);

            foreach (ArrayList formula in datosMP)
            {

                fila = dtDetFormula.NewRow();

                fila["Formula"] = formula[0].ToString();
                fila["Costo"] = formula[1].ToString();
                fila["Materia Prima"] = formula[2].ToString();
                fila["Unidad de Medida"] = formula[3].ToString();
                fila["Cantidad"] = formula[4].ToString();

                dtDetFormula.Rows.Add(fila);
            }

            return dtDetFormula;
        }

        public DataTable obtDatosProduccion()
        {
            datosMP = datosObt.obtDatosProd();

            DataTable dtDetFormula = new DataTable();
            DataColumn c1, c2, c3, c4, c5, c6, c7, c8;
            DataRow fila;

            c1 = new DataColumn();
            c1.DataType = System.Type.GetType("System.String");
            c1.ColumnName = "Descripción";

            c2 = new DataColumn();
            c2.DataType = System.Type.GetType("System.String");
            c2.ColumnName = "Cantidad";

            c3 = new DataColumn();
            c3.DataType = System.Type.GetType("System.String");
            c3.ColumnName = "Estado";

            c4 = new DataColumn();
            c4.DataType = System.Type.GetType("System.String");
            c4.ColumnName = "Costo Directo";

            c5 = new DataColumn();
            c5.DataType = System.Type.GetType("System.String");
            c5.ColumnName = "Costo Indirecto";

            c6 = new DataColumn();
            c6.DataType = System.Type.GetType("System.String");
            c6.ColumnName = "Costo Producción";

            c7 = new DataColumn();
            c7.DataType = System.Type.GetType("System.String");
            c7.ColumnName = "Costo Total";

            c8 = new DataColumn();
            c8.DataType = System.Type.GetType("System.String");
            c8.ColumnName = "Costo Venta";


            dtDetFormula.Columns.Add(c1);
            dtDetFormula.Columns.Add(c2);
            dtDetFormula.Columns.Add(c3);
            dtDetFormula.Columns.Add(c4);
            dtDetFormula.Columns.Add(c5);
            dtDetFormula.Columns.Add(c6);
            dtDetFormula.Columns.Add(c7);
            dtDetFormula.Columns.Add(c8);

            foreach (ArrayList formula in datosMP)
            {

                fila = dtDetFormula.NewRow();

                fila["Descripción"] = formula[0].ToString();
                fila["Cantidad"] = formula[1].ToString();
                fila["Estado"] = formula[2].ToString();
                fila["Costo Directo"] = formula[3].ToString();
                fila["Costo Indirecto"] = formula[4].ToString();
                fila["Costo Producción"] = formula[5].ToString();
                fila["Costo Total"] = formula[6].ToString();
                fila["Costo Venta"] = formula[7].ToString();

                dtDetFormula.Rows.Add(fila);
            }

            return dtDetFormula;
        }




    }
}
