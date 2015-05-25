using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_seguridad.Negocio
{
    class csN_llenarcmbMoneda
    {
        ArrayList alDatos = new ArrayList();
        ArrayList alObjetoscmb = new ArrayList();

        Datos.csD_llenarcmbMoneda csd_llenarcmbmoneda = new Datos.csD_llenarcmbMoneda();
        public ComboBox cmbLlenarcmbMoneda(ComboBox cmbLlenar)
        {
            alDatos = csd_llenarcmbmoneda.alLlenarcmbMoneda();
            for (int icontador = 0; icontador < alDatos.Count; icontador++)
            {
                alObjetoscmb = (ArrayList)alDatos[icontador];

                //MessageBox.Show((String)alObjetoscmb[0]);    
                cmbLlenar.Items.Add((String)alObjetoscmb[0]);
            }
            return cmbLlenar;
        }
    }
}
