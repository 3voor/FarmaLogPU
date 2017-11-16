using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo {
    public class Usuario {
        string nombre;
        string pass;
        public Usuario() {

        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
