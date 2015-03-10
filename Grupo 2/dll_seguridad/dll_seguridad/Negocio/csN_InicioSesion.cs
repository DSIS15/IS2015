/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 08-03-2015
 * Autor: Jaime Iván Muñoz Enriquez * 
 * Descripcion: Esta clase tiene como fin validar los los datos que ha ingresado
 *              el usuario
 * conectado en: Capa de datos csD_InicioSesion (necesario para hacer la consulta)
 */
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
        //se almacenara el windows form enviado como parametro en el constructor de wfInicioSesion->Capa Presentacion
        private Form wfFormulario;

        //creando objeto de la capa de Datos csD_InicioSesion
        private csD_InicioSesion csd_inicio = new csD_InicioSesion();

        //Variable encapsulada-->politica de proteccion
        public Form Wfformulario
        {
            get { return wfFormulario; }
            set { wfFormulario = value; }
        }
        ///////////////////////////////////////////////

        //metodo para validar el loguin del usuario
        public void vIninicio(string sUsuario, string sContraseña)
        {
            if (String.IsNullOrEmpty(sUsuario) || string.IsNullOrEmpty(sContraseña))
            {
                //Mensaje de error
                MessageBox.Show("Ingrese el Usuario/Contraseña vacios","Hospital");                
            }
            else
                {
                    if (csd_inicio.bInicioSesion(sUsuario, sContraseña) == true)
                    {
                        //Ocultando la ventanda wfInicioSesion
                        Presentacion.wfInicioSesion.ActiveForm.Visible = false;

                        //LLamando al metodo vCargarMenu--> el cual nos carga el MDI
                        vCargaMenu();                        
                    }
                    else
                        {
                            //Mensaje de error de autentificacion
                            MessageBox.Show("Error en autentificacion","Hospital");
                        }
                }        
        }


        //Metodo para cargar el MDI
        private void vCargaMenu()
        {
            
            try
            {
                //Creando formulario local obtenido desde la variable encapsulada
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
