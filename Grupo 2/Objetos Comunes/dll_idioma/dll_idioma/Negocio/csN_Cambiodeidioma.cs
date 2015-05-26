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
        private ArrayList alDatoslbl = new ArrayList();
        //variable donde se almacenan los botones
        private ArrayList alDatosbtn = new ArrayList();
        //variable donde se almacenan los tabcontrol
        private ArrayList alDatostbc = new ArrayList();
        //variable donde se almacenan los datagrid
        private ArrayList alDatosdgv = new ArrayList();


        public void vObtenerdatosformulario(String sinformacionidioma)
        {
        CurrentUICulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(sinformacionidioma);
        AplicarIdiomabtn(cambiobutton.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatosbtn);
        AplicarIdiomalbl( cambiolabel.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatoslbl);
        AplicarIdiomatbc(cambiotabcontrol.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatostbc);
        AplicarIdiomadgv(cambiodgv.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatosdgv);
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
                //si es un tabcontrol se agrea al arraylist tbc
                else if (cont is TabControl) { alDatostbc.Add(cont); }
                //si es un datagrid se agrea al arraylist dgv
                else if (cont is dll_bitacora.Presentacion.cuDataGridD) { alDatosdgv.Add(cont);}                

            }
            CurrentUICulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(sinformacionidioma);
            if (alDatosbtn.Count > 0)
            {
                AplicarIdiomabtn(cambiobutton.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatosbtn);
            }
            if (alDatoslbl.Count > 0)
            {
                AplicarIdiomalbl(cambiolabel.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatoslbl);
            }
            if (alDatostbc.Count > 0)
            {
                AplicarIdiomatbc(cambiotabcontrol.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatostbc);
            }
            if (alDatosdgv.Count > 0)
            {
                AplicarIdiomadgv(cambiodgv.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true), alDatosdgv);
            }
        }


        private void AplicarIdiomabtn(ResourceSet resourceSet, ArrayList alDatos)
        {
            //MessageBox.Show("btn");
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
        }

        private void AplicarIdiomalbl(ResourceSet resourceSet, ArrayList alDatos)
        {
            
                 foreach (DictionaryEntry entry in resourceSet)
                 {                    
                     for (int icontador = 0; icontador < alDatoslbl.Count; icontador++)
                     {
                         Label lblvirtual = (Label)alDatoslbl[icontador];
                         if (String.Compare(lblvirtual.Name, entry.Key.ToString()) == 0)
                         {                             
                             lblvirtual.Text = entry.Value.ToString();
                             icontador = alDatoslbl.Count;                             
                         }
                     }
                 }
        }

        private void AplicarIdiomatbc(ResourceSet resourceSet, ArrayList alDatos)
        {
           
                 foreach (DictionaryEntry entry in resourceSet)
                 {
                     for (int icontador = 0; icontador < alDatostbc.Count; icontador++)
                     {
                         //se asigna el tabcontrol a la varialbe
                         TabControl tbcvirtual = (TabControl)alDatostbc[icontador];

                         if (String.Compare(tbcvirtual.Name, entry.Key.ToString()) == 0)//validación si existe el nombre del tabcontrl
                         {
                             
                             if (tbcvirtual.TabPages.Count >0)
                             {
                                 //for que recorre el tabpage de un tabcontrol
                                 for (int icontadortbp = 0; icontadortbp < tbcvirtual.TabPages.Count; icontadortbp++ )
                                 {
                                     //se asigna un tabpage a la variable 
                                     TabPage tbpvirtual = tbcvirtual.TabPages[icontadortbp];
                                     ResourceSet resourceSet2 = cambiotabPage.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
                                     foreach(DictionaryEntry entry2 in resourceSet2)
                                     {
                                         if(String.Compare(tbpvirtual.Name,entry2.Key.ToString())==0)
                                         {                                             
                                             tbpvirtual.Text = entry2.Value.ToString();
                                             break;
                                         }
                                     }
                                 }
                             }//validación si existe tabPage 
                         }// validación si existe el tabcontrol.name en el archivo .resx
                     }//find del for que recorre tabcontrol
                 
                 }// fin del foreach que agrega los datos al diccionatyEntry                
            
        }// fin del metodo

        private void AplicarIdiomadgv(ResourceSet resourceSet, ArrayList alDatos)
        {
            
            foreach (DictionaryEntry entry in resourceSet)
            {  
                for (int icontador= 0; icontador < alDatosdgv.Count; icontador++)
                {
                    
                    dll_bitacora.Presentacion.cuDataGridD dgvvirtual = (dll_bitacora.Presentacion.cuDataGridD)alDatosdgv[icontador];                    
                    String[,] Scadena = (String[,])dgvvirtual.alObtenerCampos[0];
                   
                    for (int icontador2 = 0; icontador2 < dgvvirtual.Icount; icontador2++)
                    {
                        
                        ResourceSet resourceSet2 = cambioEncabezados.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
                        foreach (DictionaryEntry entry2 in resourceSet2)
                        {
                            //MessageBox.Show((Scadena[icontador2,1]+"----"+entry2.Key.ToString()));
                            if (String.Compare(Scadena[icontador2,1],entry2.Key.ToString())==0)
                            {
                                //MessageBox.Show(Scadena[icontador2, 1]);
                                Scadena[icontador2, 1] = entry2.Value.ToString();
                                //MessageBox.Show(Scadena[icontador2, 1]);
                                break;
                            }
                        }
                    }//fin del for que recorre los componentes del dgvvirtual                    
                }//fin del for que recorre los dgv
            }//fin del foreach
        }

    }
}
