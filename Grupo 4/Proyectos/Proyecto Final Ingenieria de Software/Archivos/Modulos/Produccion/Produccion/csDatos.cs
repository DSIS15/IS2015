using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using ODBCconnector;


namespace Produccion
{
    /*
     * Roberto Alexander Grave Vicente
     * 0901-11-16185
     * capa datos
     * */
    public class csDatos
    {
        ArrayList obtDatos = new ArrayList();

        public ArrayList obtDatosF() {

            try
            {
                obtDatos = csFunciones.alConsultar("select * from tabm_Formula");

            }catch(Exception e)
            
            {

                MessageBox.Show(e.Message);
            }

            return obtDatos;
        
        }


        public ArrayList obtDatosFMP()
        {

            try
            {
                obtDatos = csFunciones.alConsultar("select f.descrip_formu, f.costouni_formu, mp.nom_mp, mp.unimedida_mp, mp.canitdad_mp from tabm_formula f inner join tabt_detalleformu d on f.cod_formu = d.cod_formu inner join tabm_materiaPrima mp on d.cod_mp = mp.cod_mp ");
               
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return obtDatos;

        }


        public ArrayList obtDatosProd()
        {

            try
            {
                obtDatos = csFunciones.alConsultar("select f.descrip_formu,p.cantidad_prod, p.estado_prod,p.costo_dir,p.costo_ind,p.costo_prod, p.costo_total,p.precio_vta from tabm_formula f inner join tabm_produccion p on f.cod_formu = p.cod_formu ");
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return obtDatos;

        }

        


    }
}
