using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ODBCconnector
{
    class csErrores
    {
        public void vControlErrores(OdbcErrorCollection oecErrores)
        {
            String sMensajeError = "Equipo: " + Environment.MachineName + Environment.NewLine + Environment.NewLine;         
            foreach(OdbcError Error in oecErrores)
            {
                sMensajeError += "Error " + Error.SQLState + ": " + sSeleccionarError(Error.SQLState)
                + Environment.NewLine;
            }
            MessageBox.Show(sMensajeError, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static string sSeleccionarError(String Error) 
        {
            String sMensaje= String.Empty;
            switch (Error) 
            {
                case "01000": sMensaje = "Alerta general"; break;
                case "01004": sMensaje = "Datos de cadena truncados"; break;
                case "01S02": sMensaje = "El valor de opción fue cambiado"; break;
                case "01S03": sMensaje = "No hay filas actualizadas o eliminadas"; break;
                case "01S04": sMensaje = "Más de una fila ha sido actualizada o borrada"; break;
                case "01S06": sMensaje = "Intento de recuperación antes de que el conjunto de resultados devolviera el primer conjunto de filas"; break;
                case "07001": case "07002": sMensaje = "SQLBindParameter no ha sido utilizado para todos los parámetros"; break;	
                case "07009": sMensaje = "Descriptor de indice invalido"; break;		
                case "08002": sMensaje = "El nombre de conexion esta en uso"; break;	
                case "08003": sMensaje = "Conexion no existente"; break;		
                case "24000": sMensaje = "Estado invalido de cursor"; break;		
                case "25000": sMensaje = "Estado invalido de transacción"; break;	
                case "25S01": sMensaje = "Estado de transacción desconocida"; break;	
                case "34000": sMensaje = "Nombre invalido de cursor"; break;	
                case "S1000": case "HY000":	sMensaje = "Error de driver general"; break;
                case "S1001": case "HY001": sMensaje = "Error de asignación de memoria"; break;	
                case "S1002": case "HY002":	sMensaje = "Numero invalido de columna"; break;	
                case "S1003": case "HY003":	sMensaje = "Tipo de buffer de aplicación invalido"; break;	
                case "S1004": case "HY004":	sMensaje = "Datos de SQL invalidos"; break;	
                case "S1009": case "HY009":	sMensaje = "Uso invalido del puntero nulo"; break;	
                case "S1010": case "HY010":	sMensaje = "Error en función de secuencia"; break;	
                case "S1011": case "HY011":	sMensaje = "El atributo no puede ser asignado ahora"; break;	
                case "S1012": case "HY012":	sMensaje = "Codigo invalido de operación de transacción"; break;	
                case "S1013": case "HY013":	sMensaje = "Error de administracion de memoria"; break;	
                case "S1015": case "HY015":	sMensaje = "El nombre del cursor no esta disponible"; break;	
                case "S1024": case "HY024":	sMensaje = "El Valor del Atributo no es valido"; break;	
                case "S1090": case "HY090":	sMensaje = "Cadena o longitud de buffer invalido"; break;	
                case "S1091": case "HY091":	sMensaje = "Identificador de descripor de campo incorrecto"; break;	
                case "S1092": case "HY092":	sMensaje = "Atributo o Identificador de opción invalido"; break;	
                case "S1093": case "HY093":	sMensaje = "Numero de parametro invalido"; break;	
                case "S1095": case "HY095":	sMensaje = "Tipo de función fuera del rango"; break;
                case "S1117": case "HY117": sMensaje = "Valor de la fila fuera del rango"; break;	
                case "S1109": case "HY109":	sMensaje = "Invalida posición del cursor"; break;
                case "S1C00": case "HYC00": sMensaje = "Función opcional no implementada"; break;
                case "21S01": sMensaje = "El número de columnas no corresponde al número de valores"; break;
                case "23000": sMensaje = "Violación de integridad"; break;
                case "42000": sMensaje = "Error de sintaxis o violación de acceso"; break;	
                case "42S02": sMensaje = "La tabla o vista no exite"; break;	
                case "42S12": sMensaje = "Indice no encontrado"; break;
                case "42S21": sMensaje = "La columna ya exite"; break;	
                case "42S22": sMensaje = "Columna no encotrada"; break;
                case "08S01": sMensaje = "Fallo del enlace de comunicación"; break;
                default: sMensaje = "Error indefinido"; break;
            }
            return sMensaje;
        }  
    }
}
