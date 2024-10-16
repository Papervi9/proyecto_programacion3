using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Cita
    {

        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string tipo_pago { get; set; }
        public Cliente cc_cliente { get; set; }

        public Empleado cc_empleado { get; set; }


        public Servicio id_servicio { get; set; }



    }
}
