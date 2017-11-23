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

        public BindingList<Empleado> obtenerEmpleadosConectados()
        {            
            return usuarioDA.obtenerEmpleadosConectados();
            
        }
    }
}
