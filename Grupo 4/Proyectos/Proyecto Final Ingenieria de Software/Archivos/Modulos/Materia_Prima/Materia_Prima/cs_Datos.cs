using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Materia_Prima
{
    class cs_Datos
    {
        ArrayList cbollenado = new ArrayList();

        public ArrayList obtenerDatosCombo()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("select cod_prov, nom_prov from tabm_proveedor");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }



        ArrayList cbollenado2 = new ArrayList();

        public ArrayList obtenerDatosCombo2()
        {
            try
            {
                cbollenado2 = ODBCconnector.csFunciones.alConsultar("select cod_mp, nom_mp from tabm_materiaprima");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado2;
        }

        //arraylist para llenar el Data DataGridView busqueda Materia Prima
        ArrayList dtlleno = new ArrayList();
        public ArrayList obtDatosMateriaPrima()
        {
            try
            {
                dtlleno = ODBCconnector.csFunciones.alConsultar("select cod_mp, nom_mp, unimedida_mp, canitdad_mp, precio_mp from tabm_materiaprima");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dtlleno;

        }

        //arraylist para llenar el Data DataGridView busqueda Pedido
        ArrayList dgv_pedido = new ArrayList();
        public ArrayList obtDatosPedido()
        {
            try
            {
                dgv_pedido = ODBCconnector.csFunciones.alConsultar("select cod_ped,unidad_ped,cantidad_ped,fecha_ped FROM tabm_pedido");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dgv_pedido;

        }

    }
}
