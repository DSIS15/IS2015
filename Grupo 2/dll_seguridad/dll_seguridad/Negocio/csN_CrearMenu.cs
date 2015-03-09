/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 08-03-2015
 * Autor: Jaime Iván Muñoz Enriquez * 
 * Descripcion: Esta clase tiene como fin crear el menu asi como los sub menu
 * conectado en: Capa de datos csD_CrearMenu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace dll_seguridad.Negocio
{
    class csN_CrearMenu
    {
        //creando objeto de crear menu
        Datos.csD_CrearMenu csd_creamenu = new Datos.csD_CrearMenu();

        //variables para creacion de los menu
        private ToolStripMenuItem TsMINombreModulo;
        private ToolStripMenuItem[] TsMIcontenedores;
        private ArrayList alDatos;
        private ArrayList alSubMenu;

        //creando el menu y los sub menu
                                        //variables a sustituir por la consulta
        public ToolStripMenuItem TSMINmenu(String sModulo)
        {
        alDatos = new ArrayList();
        alDatos = alNsubmenu(sModulo);
        TsMINombreModulo = new ToolStripMenuItem("&"+ sModulo);
        TsMIcontenedores = new ToolStripMenuItem[alDatos.Count];
        for (int icont=0; icont < alDatos.Count; icont++)
            {
            alSubMenu = (ArrayList)alDatos[icont];
            //MessageBox.Show(alSubMenu[3].ToString()+".Presentacion."+alSubMenu[2].ToString());
            
            TsMIcontenedores[icont]= new ToolStripMenuItem (alSubMenu[1].ToString());
            TsMIcontenedores[icont].Tag = (alSubMenu[3].ToString() + ".Presentacion." + alSubMenu[2].ToString());
            TsMIcontenedores[icont].Click += new EventHandler(vclickevento_clic);
            }
        TsMINombreModulo.DropDownItems.AddRange(TsMIcontenedores);
        return TsMINombreModulo;
        }

        //crea el evento clic de los sub menu
        private void vclickevento_clic(object sender, EventArgs e)
        {
            var objeto = (ToolStripMenuItem)sender;
            //variable temporal a cambiar en la consulta
            //String SnombWf =alSubMenu[3].ToString()+".Presentacion."+alSubMenu[2].ToString();
            Form wfFormulario;            
            try
                {
                wfFormulario = (Form)Activator.CreateInstance(null, objeto.Tag.ToString()).Unwrap();
                wfFormulario.Activate();
                wfFormulario.WindowState = FormWindowState.Normal;
                wfFormulario.Show();
                }
                catch
                    {
                        MessageBox.Show("Error el modulo no existe");
                    }
        }


        //metodo que llama a csD_CrearMenu
        public ArrayList alNconsultaform()
        {
            return csd_creamenu.alDconsultaForm();
        }

        public ArrayList alNsubmenu(String sModulo)
        {
            return csd_creamenu.alDsubmenu(sModulo);
        }
    }
}
