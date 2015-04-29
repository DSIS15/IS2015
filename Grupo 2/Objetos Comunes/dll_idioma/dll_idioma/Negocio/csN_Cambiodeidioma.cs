using System;
using System.Collections;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_idioma.idiomas;
using System.Globalization;
using System.Threading;

namespace dll_idioma.Negocio
{
    class csN_Cambiodeidioma
    {
        //Variable que obtiene el tipo de idioma
        private CultureInfo CurrentUICulture;
        //Variable donde se almacena los lbl
        ArrayList alDatoslbl = new ArrayList();
        //variable donde se almacenan los botones
        ArrayList alDatosbtn = new ArrayList();


        public void vObtenerdatosformulario(String sinformacionidioma)
        {
        CurrentUICulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(sinformacionidioma);
        AplicarIdioma();
        
        }
        
        public void vObtenerdatosformulario(String sinformacionidioma,Form frmFormulario )
        {
            //obteniendo los datos del windowsform
            //Form Formulario = (Form)sender;
           // MessageBox.Show(frmFormulario.Controls.Count+"");
           
            //recorriendo los controles del windowsform
            foreach (Control cont in frmFormulario.Controls)
            {               
                //si es un boton se agrega al arraylist btn
                if (cont is Button) { alDatosbtn.Add(cont);  }
                //si es un label se agrea al arraylist lbl
                else if (cont is Label) { alDatoslbl.Add(cont); }

            }
            CurrentUICulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(sinformacionidioma);
            AplicarIdioma();
        }


        private void AplicarIdioma()
        {
            
                                  
                 //
                  ResourceSet resourceSet = cambiobutton.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

                 foreach (DictionaryEntry entry in resourceSet)
                 {
                    for (int icontador = 0; icontador < alDatosbtn.Count; icontador++)
                     {
                     Button btnvirtual = (Button)alDatosbtn[icontador];
                        if (String.Compare(btnvirtual.Name, entry.Key.ToString()) == 0)
                            {
                               
                            btnvirtual.Text = entry.Value.ToString();
                            icontador = alDatosbtn.Count;
                             }                        
                     }
                }

                //
                 resourceSet = cambiolabel.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
                 foreach (DictionaryEntry entry in resourceSet)
                 {
                     for (int icontador = 0; icontador < alDatoslbl.Count; icontador++)
                     {
                         Label lblvirtual = (Label)alDatoslbl[icontador];
                         if (String.Compare(lblvirtual.Name, entry.Key.ToString()) == 0)
                         {
                             //MessageBox.Show(lblvirtual.Name);
                             lblvirtual.Text = entry.Value.ToString();
                             icontador = alDatoslbl.Count;
                         }
                     }

                 }
            
        }
    }
}
