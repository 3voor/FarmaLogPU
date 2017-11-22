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
        private int idArea;
        private string nombreEmpleado;
        private string apellidosEmpleado;
        private string correo;
        private string telefono;
        private bool conectado;

        public Empleado()
        {

        }

        public Empleado(int idEmpleado, int idArea, string nombreEmpleado, string apellidosEmpleado, string correo, string telefono, bool conectado)
        {
            this.idEmpleado = idEmpleado;
            this.idArea = idArea;
            this.nombreEmpleado = nombreEmpleado;
            this.apellidosEmpleado = apellidosEmpleado;
            this.correo = correo;
            this.telefono = telefono;
            this.conectado = conectado;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdArea { get => idArea; set => idArea = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string ApellidosEmpleado { get => apellidosEmpleado; set => apellidosEmpleado = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Conectado { get => conectado; set => conectado = value; }
    }
}
