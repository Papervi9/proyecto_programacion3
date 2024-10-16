using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace Capa_datos
{
    public class Conexion
    {
        public static string conn = ConfigurationManager.ConnectionStrings["server=EDUARDO; database=prueba; integrated security=true"].ToString();



    }
}
