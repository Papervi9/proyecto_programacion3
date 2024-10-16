using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Logica
{
    internal class EmpleadoLogica
    {

        Empleado e = new Empleado();

        public void agregarEmpleado(string nombre, string apellido, string contacto, double salario)
        {

           
        }

        public void eliminarEmpleado(string cc)
        {


        }

        public void editarEmpleado(string cc, string nombre, string apellido, string contacto, double salario)
        {


        }


        public double calcularSueldo(double sueldo_base, double comision)
        {
           
return sueldo_base+ comision;
        }
    }
}
