using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Controlador {
    public class UsuarioBL {
        private UsuarioDA usuarioDA;
        public UsuarioBL() {
            usuarioDA = new UsuarioDA();
        }
        public bool validarUsuario(Usuario u) {
            return usuarioDA.validarUsuario(u);
        }

        public void obtenerEmpleadosConectados(BindingList<Empleado> lista)
        {
            lista = usuarioDA.obtenerEmpleadosConectados();
            foreach(Empleado e in lista)
            {
                Console.WriteLine(e.NombreEmpleado);
            }
            Console.WriteLine("-----------------");
        }
    }
}
