using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Produccion_EnterpriseSolution
{
    public class csNegocios
    {
        csDatos cbo = new csDatos();

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
                fil["cod_empsa"]= item[0].ToString();
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



        public DataTable obtDatosdgvPer()
        {
            ArrayList dgvper = new ArrayList();
            dgvper = cbo.datoper();

            DataTable dt = new DataTable("perfil");
            DataColumn c1, c2, c3, c4, c5, c6, c7, c8, c9;
            DataRow row;

            c1 = new DataColumn();
            c2 = new DataColumn();
            c3 = new DataColumn();
            c4 = new DataColumn();
            c5 = new DataColumn();
            c6 = new DataColumn();
            c7 = new DataColumn();
            c8 = new DataColumn();
            c9 = new DataColumn();

            c1.DataType = System.Type.GetType("System.String");
            c1.ColumnName = "Codigo Usuario";
            c2.DataType = System.Type.GetType("System.String");
            c2.ColumnName = "Codigo Empleado";
            c3.DataType = System.Type.GetType("System.String");
            c3.ColumnName = "Codigo Perfil";
            c4.DataType = System.Type.GetType("System.String");
            c4.ColumnName = "Usuario";
            c5.DataType = System.Type.GetType("System.String");
            c5.ColumnName = "Nombre Perfil";
            c6.DataType = System.Type.GetType("System.String");
            c6.ColumnName = "Insertar";
            c7.DataType = System.Type.GetType("System.String");
            c7.ColumnName = "Eliminar";
            c8.DataType = System.Type.GetType("System.String");
            c8.ColumnName = "Modificar";
            c9.DataType = System.Type.GetType("System.String");
            c9.ColumnName = "Reporte";

            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);
            dt.Columns.Add(c4);
            dt.Columns.Add(c5);
            dt.Columns.Add(c6);
            dt.Columns.Add(c7);
            dt.Columns.Add(c8);
            dt.Columns.Add(c9);

            foreach(ArrayList item in dgvper)
            {
                row = dt.NewRow();
                row["Codigo Usuario"] = item[0].ToString();
           
                row["Codigo Empleado"] = item[1].ToString();
                
                row["Codigo Perfil"] = item[2].ToString();
                
                row["Usuario"] = item[3].ToString();
              
                row["Nombre Perfil"] = item[4].ToString();
              
                row["Insertar"] = item[5].ToString();
               
                row["Eliminar"] = item[6].ToString();
                
                row["Modificar"] = item[7].ToString();
           
                row["Reporte"] = item[8].ToString();

                dt.Rows.Add(row);
            }
            return dt;
        }


        public DataTable obtDatosBit()
        {
            ArrayList dgvper = new ArrayList();
            dgvper = cbo.datoBit();

            DataTable dt = new DataTable("bitacora");
            DataColumn c1, c2, c3, c4;
            DataRow row;

            c1 = new DataColumn();
            c2 = new DataColumn();
            c3 = new DataColumn();
            c4 = new DataColumn();
           

            c1.DataType = System.Type.GetType("System.String");
            c1.ColumnName = "Usuario";
            c2.DataType = System.Type.GetType("System.String");
            c2.ColumnName = "Nombre Maquina";
            c3.DataType = System.Type.GetType("System.String");
            c3.ColumnName = "Fecha Sesion";
            c4.DataType = System.Type.GetType("System.String");
            c4.ColumnName = "Hora Sesion";

            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);
            dt.Columns.Add(c4);
            

            foreach (ArrayList item in dgvper)
            {
                row = dt.NewRow();
                row["Usuario"] = item[0].ToString();

                row["Nombre Maquina"] = item[1].ToString();

                row["Fecha Sesion"] = item[2].ToString();

                row["Hora Sesion"] = item[3].ToString();

                dt.Rows.Add(row);
            }
            return dt;
        }


    }/////////////
}
