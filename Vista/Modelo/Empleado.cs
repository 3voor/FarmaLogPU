using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombreEmpleado;

        public Empleado()
        {

        }

        public Empleado(int idEmpleado, string nombreEmpleado)
        {
            this.idEmpleado = idEmpleado;
            this.nombreEmpleado = nombreEmpleado;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
    }
}
