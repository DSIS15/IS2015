using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace SIP_Administrativo
{
    class cs_Datos
    {
        ArrayList cbollenado = new ArrayList();
        
        public ArrayList obtenerDatosCombo()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("select cod_empsa, nomcomercial_empsa from tabm_empresa");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }

        //arraylist para llenar el Data DataGridView busqueda proveedores
        ArrayList dtlleno = new ArrayList();
        public ArrayList obtDatosProveedor()
        {
            try
            {
                dtlleno = ODBCconnector.csFunciones.alConsultar("SELECT cod_prov as codigo, nom_prov, nit_prov, dire_prov, tel_prov, estado_prov from tabm_proveedor ");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dtlleno;

        }

        //arraylist para llenar el Data DataGridView busqueda clientes
        ArrayList dgv_clientes = new ArrayList();
        public ArrayList obtDatosClientes()
        {
            try
            {
               // dgv_clientes = ODBCconnector.csFunciones.alConsultar("SELECT cod_cte,cod_empsa,dpi_cte,nom1_cte,nom2_cte,apell1_cte,apell2_cte,dire_cte,estado_cte from tabm_cliente ");
               // dgv_clientes = ODBCconnector.csFunciones.alConsultar("SELECT cod_cte,nomcomercial_empsa,dpi_cte,nit_cte,nom1_cte,apell1_cte FROM tabm_cliente as cte inner join tabm_empresa as empre on cte.cod_empsa=empre.cod_empsa");
                dgv_clientes = ODBCconnector.csFunciones.alConsultar("SELECT cod_cte,nom1_cte,nom2_cte,apell1_cte,dpi_cte,nit_cte,tel_cte,dire_cte FROM tabm_cliente");
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dgv_clientes;

        }

        //arraylist para llenar el Data DataGridView busqueda empleados
        ArrayList dgv_empleados = new ArrayList();
        public ArrayList obtDatosEmpleados()
        {
            try
            {
                dgv_empleados = ODBCconnector.csFunciones.alConsultar("SELECT cod_emp,nomcomercial_empsa,nom1_emp,apell1_emp,dire_emp,afiigss_emp,nit_emp FROM tabm_empleado as emp inner join tabm_empresa as empre on emp.cod_empsa=empre.cod_empsa ");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dgv_empleados;

        }

       



    }
}
