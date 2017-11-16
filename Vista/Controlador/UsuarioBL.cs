using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador {
    public class UsuarioBL {
        private UsuarioDA usuarioDA;
        public UsuarioBL() {
            usuarioDA = new UsuarioDA();
        }
        public bool validarUsuario(Usuario u) {
            return usuarioDA.validarUsuario(u);
        }
    }
}
