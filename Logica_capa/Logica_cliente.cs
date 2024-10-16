using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;
using Capa_Entidades;
namespace Logica_capa
{
    public class Logica_cliente
    {
        private Cd_cliente CD_Usuario = new Cd_cliente();

            public List<Cliente> Listar()
        {
            return CD_Usuario.Listar();
        }
    }
}
