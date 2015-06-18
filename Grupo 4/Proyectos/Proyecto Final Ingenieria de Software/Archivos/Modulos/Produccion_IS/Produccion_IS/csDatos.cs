using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Produccion_EnterpriseSolution
{
    public class csDatos
    {

        ArrayList cbollenado = new ArrayList();

        public ArrayList obtDatosEmpresa()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("select cod_empsa, nomcomercial_empsa from tabm_empresa");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }

        public ArrayList obtDatosMoneda()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("SELECT cod_mda, moneda_mda from tabm_moneda");
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }

        public void RegistrarBitacora(int cu, string nm, string fs, string hs)
        {



            ODBCconnector.csFunciones.vInsertar("insert into tabm_bitacora (cod_usu, nom_maquina, fecha_bita, hora_bita) values ('" + cu + "', '" + nm + "','" + fs + "', '" +hs+ "')");
            

            }

        public ArrayList datoper() 
        {
            ArrayList dgvdato = new ArrayList();
            dgvdato = ODBCconnector.csFunciones.alConsultar("select usu.cod_usu, usu.cod_emp, usu.cod_perf, usu.user_usu, per.nombre_perf, per.insertar, per.eliminar, per.modificar, per.reporte from tabm_usuario usu inner join tabm_perfil per on usu.cod_perf = per.cod_perf");
            return dgvdato;
        
        }


        public ArrayList datoBit()
        {
            ArrayList dgvdato = new ArrayList();
            dgvdato = ODBCconnector.csFunciones.alConsultar("SELECT usu.user_usu, bit.nom_maquina, bit.fecha_bita, bit.hora_bita from tabm_usuario usu inner join tabm_bitacora bit on usu.cod_usu = bit.cod_usu");
            return dgvdato;

        }




       




    }///////////////////////////////

}
