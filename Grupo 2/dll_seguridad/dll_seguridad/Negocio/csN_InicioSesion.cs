using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_seguridad.Datos;

namespace dll_seguridad.Negocio
{
    class csN_InicioSesion: csD_InicioSesion
    {
        private Form wfFormulario;
        private csD_InicioSesion csd_inicio = new csD_InicioSesion();

        public Form Wfformulario
        {
            get { return wfFormulario; }
            set { wfFormulario = value; }
        }
        
        public void vIninicio(string sUsuario, string sContraseña)
        {
            if (String.IsNullOrEmpty(sUsuario) || string.IsNullOrEmpty(sContraseña))
            {
                MessageBox.Show("Ingrese el Usuario/Contraseña vacios","Hospital");
                
            }
            else
                {
                    if (csd_inicio.bInicioSesion(sUsuario, sContraseña) == true)
                    {
                        Presentacion.wfInicioSesion.ActiveForm.Visible = false;
                        vCargaMenu();
                        
                    }
                    else
                        {
                            MessageBox.Show("Error en autentificacion","Hospital");
                        }
                }        
        }

        private void vCargaMenu()
        {
            try
            {
                Form wfMenu = wfFormulario;
                wfMenu.Dock = DockStyle.Fill;
                wfMenu.Show();
            }
            catch (Exception)
               {
                   MessageBox.Show("Error al cargar Menu", "Hospital");
            }
        }
    }
}
