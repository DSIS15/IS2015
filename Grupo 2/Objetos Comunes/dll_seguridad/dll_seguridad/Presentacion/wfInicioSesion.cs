/*Fecha y lugar de Modificacion: Guatemala, Guatemala, 08-03-2015
 * Autor: Jaime Iván Muñoz Enriquez  
 * Descripcion: Este es el formulario de Inicio de sesion de los usuarios
 * conectado en: Capa de Negocio csN_InicioSesion (necesaria para validar el usuario)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_seguridad.Presentacion
{
    public partial class wfInicioSesion : Form
    {
        //Creando objeto de la capa de negocio csN_InicioSesion
        private Negocio.csN_InicioSesion csn_inicio = new Negocio.csN_InicioSesion();
        private static String sUsuario;

        public static String SUsuario
        {
            get { return wfInicioSesion.sUsuario; }
            set { wfInicioSesion.sUsuario = value; }
        }

        //constructor del windows form agregando un formulario como parametro
        public  wfInicioSesion(Form wfFormulario)
        {
            //validacion del windows form si es nulo.
            if (wfFormulario != null) csn_inicio.Wfformulario = wfFormulario;//llamando a la variable encapsulada (Politica de proteccion)
            InitializeComponent();
            
        }


        private void wfInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SUsuario = txtUsuario.Text;
            //metodo de la clase csN_InicioSesion capa Negocio para validar datos
            csn_inicio.vIninicio(txtUsuario.Text, txtContraseña.Text);
        }
        //boton de salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //se utiliza este metodo para no dejar provesos abiertos
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
