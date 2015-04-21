using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace dll_bitacora.Negocio
{
    class cs_Ninsertarbitacora
    {
        Datos.cs_Dinsercionbitacora cs_dinsercionbitacora = new Datos.cs_Dinsercionbitacora();
       string sIP, sHostname, sFecha, sHora;
        public void vInsercion(string scodusr, string sDescripcion)
        {
            IPHostEntry host;
            
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    sIP = ip.ToString();
                }
            }// Fin de foreach
            sHostname = Environment.MachineName.ToString();
            sFecha = DateTime.Now.ToString("dd/MM/yyyy");
            sHora = DateTime.Now.ToString("HH:mm");

            cs_dinsercionbitacora.vinsercion(sIP,sHostname,sFecha,sHora,scodusr, sDescripcion);

        }


     }
}
