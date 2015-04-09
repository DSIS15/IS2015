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
        private Form wfFormMDI;

        //creando el menu y los sub menu                                        
        public ToolStripMenuItem TSMINmenu(String sModulo, Form wfFormMdi)
        {
        alDatos = new ArrayList();
        wfFormMDI = wfFormMdi;
        //se asignan los datos que viene en la variable sModulo -->una tabla de la bd
        alDatos = alNsubmenu(sModulo);

        //se crea el primer contenido del toolmenustrip
        TsMINombreModulo = new ToolStripMenuItem("&"+ sModulo);
        //crea el numero de submenus consultados en alNsubmenu
        TsMIcontenedores = new ToolStripMenuItem[alDatos.Count];
        
        //metodo que agrega los submenu
        if (string.Compare(sModulo, "Inicio") != 0)
        {
            vAgregarSubmenu();
        }
        else
            {
                vAgregarSubmenu2();
            }
       
        //retorna el objeto creado
        return TsMINombreModulo;
        }

        //crea lo que es el menu de inicio
        private void vAgregarSubmenu2()
        {
            //datos obtenidos en la funcion TSMINmenu de esta misma clase
            //se recorre para ir construyenndo el submenu
            for (int icont = 0; icont < alDatos.Count; icont++)
            {
                alSubMenu = (ArrayList)alDatos[icont];
                TsMIcontenedores[icont] = new ToolStripMenuItem(alSubMenu[1].ToString());
                TsMIcontenedores[icont].Tag = alSubMenu[1].ToString();
                TsMIcontenedores[icont].Click += new EventHandler(vclickevento_click);
            }
            TsMINombreModulo.DropDownItems.AddRange(TsMIcontenedores);
        }

        //evento click especializado para el modulo de inicio
        private void vclickevento_click(object sender, EventArgs e)
        {
            var objeto = (ToolStripMenuItem)sender; 
            switch (objeto.Tag.ToString())
            {
                case "Ordenar modo cascada": wfFormMDI.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Ordenar modo Horizontal": wfFormMDI.LayoutMdi(MdiLayout.TileHorizontal);            
                    break;
                case "Ordenar modo Vertical": wfFormMDI.LayoutMdi(MdiLayout.TileVertical);
                    break;
                case "Cerrar Sesion": Application.Restart();
                    break;
                case "Salir": Application.Exit();
                    break;
            
            }
        }

        private void vAgregarSubmenu()
        {
            //datos obtenidos en la funcion TSMINmenu de esta misma clase
            //se recorre para ir construyenndo el submenu
            for (int icont = 0; icont < alDatos.Count; icont++)
            {
                alSubMenu = (ArrayList)alDatos[icont];
                TsMIcontenedores[icont] = new ToolStripMenuItem(alSubMenu[1].ToString());
                TsMIcontenedores[icont].Tag = (alSubMenu[3].ToString() + ".Presentacion." + alSubMenu[2].ToString());
                TsMIcontenedores[icont].Click += new EventHandler(vclickevento_clic);
            }
        TsMINombreModulo.DropDownItems.AddRange(TsMIcontenedores);
        }

        //crea el evento clic de los sub menu
        private void vclickevento_clic(object sender, EventArgs e)
        {
            var objeto = (ToolStripMenuItem)sender;                        
            Form wfFormulario;           
            String[] sNomDLL = objeto.Tag.ToString().Split('.');           
            try
                {
                wfFormulario = (Form)Activator.CreateInstance(sNomDLL[0], objeto.Tag.ToString()).Unwrap();
                wfFormulario.Activate();
                
                wfFormulario.WindowState = FormWindowState.Normal;
                wfFormulario.MdiParent = wfFormMDI;
                wfFormulario.Show();
                }
                catch
                    {
                        MessageBox.Show("Error el modulo no existe","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }

        //metodo que llama a csD_CrearMenu
        public ArrayList alNconsultaform(String sUsuario)
        {
            return csd_creamenu.alDconsultaForm(sUsuario);
        }

        public ArrayList alNsubmenu(String sModulo)
        {
            return csd_creamenu.alDsubmenu(sModulo);
        }
    }
}
