using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace pdFormula
{
    class ConexionBD
    {
        public static MySqlConnection cn()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=produccion2015; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
            
        }
    }
}
